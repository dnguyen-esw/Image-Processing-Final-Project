using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Accord.Imaging;           //use for GLCM (gray-level-cooccurrence-matrix) ma trận đồng hiện mức xám
using Accord.Imaging.Filters;   //use for converting RGB to Gray (R:0.2125, G:7154, B: 0.0721)- dùng để convert ảnh rgb sang ảnh xám bằng thuật toán BT709
namespace Final_Project
{
    public partial class Main_form : Form
    {
        Mat img = new Mat();            //input image - ảnh đầu vào
        Mat imgThreshed = new Mat();    //threshed image - ảnh Binary đã phân ngưỡng
        Mat segment = new Mat();        //segmented image - ảnh màu đã phân đoạn vùng bị sâu hại
        Bitmap noimg;                   //no available image
        
        public Main_form()
        {
            InitializeComponent();
            noimg = new Bitmap(@"C:\Users\hoang\OneDrive\Máy tính\Final Project\Final_Project\noimg.jpg");
            pictureBox_original.Image = noimg;
            pictureBox_step1.Image = noimg;
            pictureBox_step2.Image = noimg;
            pictureBox_step3.Image = noimg;
            pictureBox_step4.Image = noimg;
            pictureBox_drawContour.Image = noimg;
            pictureBox_segmented.Image = noimg;
            label_threshold.Text = "Threshold: " + trackBar1.Value.ToString();
        }
        
        //tiền xử lý ảnh đầu vào - out put là ảnh ROI dạng binary
        public Mat Pre_processing(Mat image)
        {
            //resize tất cả ảnh đầu vào về size 500x500
            CvInvoke.Resize(image, image, new Size(500, 500));

            //Step 1: convert rgb->lab(or hsv)
            Image<Lab, byte> imgLab = new Image<Lab, byte>(img.Width, img.Height);
            CvInvoke.CvtColor(image, imgLab, ColorConversion.Rgb2Lab);
            pictureBox_step1.Image = imgLab.ToBitmap();

            //Step 2: Histogram equalization & increase contrast
            imgLab._EqualizeHist();
            imgLab._GammaCorrect(2.4d);
            pictureBox_step2.Image = imgLab.ToBitmap();

            //Split Lab to 3-channel l,a,b
            imgLab.Split();

            //Step 3: Smooth image - loại bỏ nhiễu
            Image<Gray, byte> imgSmooth = new Image<Gray, byte>(img.Width, img.Height);
            Size size = new Size(3, 3);
            CvInvoke.GaussianBlur(imgLab[2], imgSmooth, size, 0, 0);
            pictureBox_step3.Image = imgSmooth.ToBitmap();

            //Step 4: Threshold - chuyển sang ảnh binary để phân đoạn region of interest (ROI)
            Image<Gray, byte> imgThres = new Image<Gray, byte>(img.Width, img.Height);
            CvInvoke.Threshold(imgSmooth, imgThres, Convert.ToInt32(trackBar1.Value), 255, ThresholdType.BinaryInv);
            pictureBox_step4.Image = imgThres.ToBitmap();
            
            Emgu.CV.Util.VectorOfVectorOfPoint contours = new Emgu.CV.Util.VectorOfVectorOfPoint();//tạo 1 contours là 1 vector chứa vector tập hợp các điểm để vẽ contours
            Mat hier = new Mat();//chứa thông tin về hình ảnh như số đường viền, xếp hạng các đường viền theo kích thước, trong ngoài

            Image<Bgr, byte> img_contour = new Image<Bgr, byte>(img.Bitmap);//khai báo ảnh màu để vẽ contours vào - chính là ảnh gốc
            CvInvoke.FindContours(imgThres, contours, hier, RetrType.External, ChainApproxMethod.ChainApproxSimple);//tìm contours, đầu vào là ảnh binary đã phân đoạn, đầu ra là contours tìm đc
            CvInvoke.DrawContours(img_contour, contours, -1, new MCvScalar(0, 0, 255), 1);//vẽ contours lên ảnh với biên dạng màu đỏ, độ dày nét 1
            pictureBox_drawContour.Image = img_contour.ToBitmap();

            imgThreshed = imgThres.Mat; //gán ảnh đã phân ngưỡng vào 1 biến toàn cục để sử dụng cho hàm khác
            return imgThres.Mat;
        }

                    /*-----TRÍCH ĐẶC TRƯNG ẢNH- Features extraction-----*/
        //hàm tính trung bình các kênh màu R, G, B. Ảnh đầu vào là ROI(ảnh đã phân đoạn vùng hư hỏng của lá) dạng RGB
        double[] MeanRGB(Bitmap segmentImg) //dùng để so sánh với hàm CvInvoke.Mean trong Emgu
        {
            double[] mean = new double[3];//vector màu trung bình-giá trị trung bình các kênh R-G-B trong vùng màu đã chọn
            mean[0] = 0;
            mean[1] = 0;
            mean[2] = 0;
            double size = 0;
            for (int x = 0; x < segmentImg.Width; x++)
                for (int y = 0; y < segmentImg.Height; y++)
                {
                    Color c = segmentImg.GetPixel(x, y);
                    byte R = c.R;
                    byte G = c.G;
                    byte B = c.B;
                    if (R != 0)
                    {
                        size++;
                        mean[0] += R;//cộng dồn giá trị màu đỏ của tất cả pixel trong vùng màu trung bình
                        mean[1] += G;//_____________________green_______________________________________
                        mean[2] += B;//_____________________blue_________________________________________
                    }
                }
            mean[0] = mean[0] / size;//giá trị màu đỏ trung bình
            mean[1] = mean[1] / size;//giá trị màu green trung bình
            mean[2] = mean[2] / size;//____________blue________

            return mean;
        }
        //hàm tính giá trị trung bình của ảnh grayscale đã segment vùng lá hư hại
        double MeanGray(Mat segmentImg) //dùng để so sánh với hàm trong Emgu
        {
            //đầu vào là ảnh RGB đã segment -> chuyển sang ảnh xám
            Mat segmentImgGray = new Mat();
            CvInvoke.CvtColor(segmentImg, segmentImgGray, ColorConversion.Rgb2Gray);
            Bitmap grayImgSegmented = segmentImgGray.Bitmap;
            double mean = 0;//giá trị trung bình của ảnh xám
            double size = 0;
            for (int x = 0; x < grayImgSegmented.Width; x++)
                for (int y = 0; y < grayImgSegmented.Height; y++)
                {
                    Color c = grayImgSegmented.GetPixel(x, y);
                    byte pixelValue = c.R;
                    if (pixelValue != 0)
                    {
                        size++;
                        mean += pixelValue;//cộng dồn giá trị màu đỏ của tất cả pixel trong vùng màu trung bình
                    }
                }
            mean = mean / size;
            return mean;
        }
        //hàm tính mean(trung bình) của emgucv, tương đương 2 hàm MeanGray và MeanRGB 
        double[] MeanCv(Mat inputmean)
        {
            double[] mean = new double[4];//vector màu trung bình-giá trị trung bình các kênh R-G-B trong vùng màu đã chọn
            mean[0] = CvInvoke.Mean(inputmean, imgThreshed).V2; //mean R channel
            mean[1] = CvInvoke.Mean(inputmean, imgThreshed).V1; //mean G channel
            mean[2] = CvInvoke.Mean(inputmean, imgThreshed).V0; //mean B channel
            Mat grayMeanImg = new Mat();
            CvInvoke.CvtColor(inputmean, grayMeanImg, ColorConversion.Rgb2Gray);
            mean[3] = CvInvoke.Mean(grayMeanImg,imgThreshed).V0;//mean gray
            return mean;
        }

        //hàm tính mean và standard deviation(độ lệch chuẩn)--lý thuyết xác suất
       MCvScalar[] MeanStdCv(Mat inputimg)  //MCvScalar: 1 dạng cấu trúc dữ liệu của Emgu(dạng container) tương tự dạng Array, 1 MCvScalar chứa từ 1->4 elements
        {
            //tạo 4 container meanstd
            MCvScalar[] meanstd = new MCvScalar[4]; 
            //tính mean và std của ảnh segmented RGB và lưu vào 2 containers meanstd[0], meanstd[1]
            CvInvoke.MeanStdDev(inputimg, ref meanstd[0], ref meanstd[1], imgThreshed);

            //chuyển ảnh sang grayscale để tính mean và std trên grayscale
            Mat grayMeanImg = new Mat();
            CvInvoke.CvtColor(inputimg, grayMeanImg, ColorConversion.Rgb2Gray);
            //mean của ảnh grayscale lưu vào meanstd[2], std của ảnh grayscale lưu vào meanstd[3]
            CvInvoke.MeanStdDev(grayMeanImg, ref meanstd[2], ref meanstd[3], imgThreshed);

            return meanstd;
        }

        //trích xuất đặc trưng kết cấu của ảnh dùng pp Haralick ----- texture features
        public double[,] CreateGLCM(Bitmap image)   //gray-level-cooccurrence-matrix - tạo ảnh 
        {
            Bitmap grayImage = Grayscale.CommonAlgorithms.BT709.Apply(image);       //chuyển ảnh màu đã segment vùng bệnh sang ảnh xám bằng thuật toán BT709
            var grayLevelCooccurrenceMatrix = new GrayLevelCooccurrenceMatrix();    //ma trận đồng hiện mức xám
            return grayLevelCooccurrenceMatrix.Compute(grayImage);       
        }
        public double[] GlcmFeatures(Bitmap image)
        {
            var descriptor = new HaralickDescriptor(CreateGLCM(image));
            var features = new double[5];
            features[0] = descriptor.F01;               //energy - tham số năng lượng
            features[1] = descriptor.F02;               //contrast - độ tương phản
            features[2] = descriptor.F03;               //correlation - độ tương đồng
            features[3] = descriptor.F09;               //entropy
            features[4] = descriptor.TextureHomogeneity;//homogeneity- tính đồng nhất

            return features;
        }

        private void button_importImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            DialogResult result = open.ShowDialog();
            if (result == DialogResult.OK)
            {
                img = new Mat(open.FileName);            //- lấy ảnh đầu vào
                pictureBox_original.Image = img.Bitmap; //show input image 
            }
        }

        private void button_preprocessing_Click(object sender, EventArgs e)
        {
            Pre_processing(img);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Pre_processing(img);
            label_threshold.Text = "Threshold: "+trackBar1.Value.ToString();
        }

        private void button_segment_Click(object sender, EventArgs e)
        {
            Mat segmented = new Mat();
            //chuyển ảnh ROI dưới dạng binary sang ROI dạng RGB bằng toán tử bitwise and
            CvInvoke.BitwiseAnd(img, img, segmented, imgThreshed);
            pictureBox_segmented.Image = segmented.Bitmap;
            segment = segmented;//lưu vào segment là global variable dùng cho các bước khác
        }

        private void button_featureExtraction_Click(object sender, EventArgs e)
        {
            textBox_meanrgb.Text = "R: " + MeanStdCv(segment)[0].V2.ToString("0.00") + " G: " + MeanStdCv(segment)[0].V1.ToString("0.00") + " B: " + MeanStdCv(segment)[0].V0.ToString("0.00");
            textBox_meangray.Text = MeanStdCv(segment)[2].V0.ToString("0.00");

            textBox_stdrgb.Text = "R: " + MeanStdCv(segment)[1].V2.ToString("0.00") + " G: " + MeanStdCv(segment)[1].V1.ToString("0.00") + " B: " + MeanStdCv(segment)[1].V0.ToString("0.00");
            textBox_stdgray.Text = MeanStdCv(segment)[3].V0.ToString("0.00");

            double varR = Math.Pow(MeanStdCv(segment)[1].V2, 2);
            double varG = Math.Pow(MeanStdCv(segment)[1].V1, 2);
            double varB = Math.Pow(MeanStdCv(segment)[1].V0, 2);
            double varGray = Math.Pow(MeanStdCv(segment)[3].V0, 2);
            textBox_varRGB.Text = "R: " + varR.ToString("0.00") + " G: " + varG.ToString("0.00") + " B: " + varB.ToString("0.00");
            textBox_varGray.Text = varGray.ToString("0.00");

            double[] fea = GlcmFeatures(segment.Bitmap);            //get features
            textBox_energy.Text = fea[0].ToString("0.00");          //energy
            textBox_contrast.Text = fea[1].ToString("0.00");        //contrast
            textBox_correlation.Text = fea[2].ToString("0.00");     //correlation
            textBox_entropy.Text = fea[3].ToString("0.00");         //entropy
            textBox_homogeneity.Text = fea[4].ToString("0.00");     //homogeneity

        }
    }
}
