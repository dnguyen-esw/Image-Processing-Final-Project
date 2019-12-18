namespace Final_Project
{
    partial class Main_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_importImg = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox_original = new System.Windows.Forms.PictureBox();
            this.button_preprocessing = new System.Windows.Forms.Button();
            this.pictureBox_step1 = new System.Windows.Forms.PictureBox();
            this.pictureBox_step2 = new System.Windows.Forms.PictureBox();
            this.pictureBox_step3 = new System.Windows.Forms.PictureBox();
            this.pictureBox_step4 = new System.Windows.Forms.PictureBox();
            this.pictureBox_drawContour = new System.Windows.Forms.PictureBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label_threshold = new System.Windows.Forms.Label();
            this.label_input = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_segment = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox_segmented = new System.Windows.Forms.PictureBox();
            this.button_featureExtraction = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_meanrgb = new System.Windows.Forms.TextBox();
            this.textBox_meangray = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_stdrgb = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_stdgray = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_varGray = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_varRGB = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox_energy = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox_contrast = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox_correlation = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox_entropy = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox_homogeneity = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_original)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_step1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_step2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_step3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_step4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_drawContour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_segmented)).BeginInit();
            this.SuspendLayout();
            // 
            // button_importImg
            // 
            this.button_importImg.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_importImg.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_importImg.Location = new System.Drawing.Point(140, 3);
            this.button_importImg.Name = "button_importImg";
            this.button_importImg.Size = new System.Drawing.Size(139, 45);
            this.button_importImg.TabIndex = 0;
            this.button_importImg.Text = "Import Image";
            this.button_importImg.UseVisualStyleBackColor = false;
            this.button_importImg.Click += new System.EventHandler(this.button_importImg_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox_original
            // 
            this.pictureBox_original.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_original.Location = new System.Drawing.Point(12, 54);
            this.pictureBox_original.Name = "pictureBox_original";
            this.pictureBox_original.Size = new System.Drawing.Size(400, 400);
            this.pictureBox_original.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_original.TabIndex = 1;
            this.pictureBox_original.TabStop = false;
            // 
            // button_preprocessing
            // 
            this.button_preprocessing.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_preprocessing.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_preprocessing.Location = new System.Drawing.Point(804, 3);
            this.button_preprocessing.Name = "button_preprocessing";
            this.button_preprocessing.Size = new System.Drawing.Size(162, 45);
            this.button_preprocessing.TabIndex = 2;
            this.button_preprocessing.Text = "Pre-processing";
            this.button_preprocessing.UseVisualStyleBackColor = false;
            this.button_preprocessing.Click += new System.EventHandler(this.button_preprocessing_Click);
            // 
            // pictureBox_step1
            // 
            this.pictureBox_step1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_step1.Location = new System.Drawing.Point(418, 54);
            this.pictureBox_step1.Name = "pictureBox_step1";
            this.pictureBox_step1.Size = new System.Drawing.Size(230, 230);
            this.pictureBox_step1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_step1.TabIndex = 3;
            this.pictureBox_step1.TabStop = false;
            // 
            // pictureBox_step2
            // 
            this.pictureBox_step2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_step2.Location = new System.Drawing.Point(654, 54);
            this.pictureBox_step2.Name = "pictureBox_step2";
            this.pictureBox_step2.Size = new System.Drawing.Size(230, 230);
            this.pictureBox_step2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_step2.TabIndex = 4;
            this.pictureBox_step2.TabStop = false;
            // 
            // pictureBox_step3
            // 
            this.pictureBox_step3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_step3.Location = new System.Drawing.Point(890, 54);
            this.pictureBox_step3.Name = "pictureBox_step3";
            this.pictureBox_step3.Size = new System.Drawing.Size(230, 230);
            this.pictureBox_step3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_step3.TabIndex = 5;
            this.pictureBox_step3.TabStop = false;
            // 
            // pictureBox_step4
            // 
            this.pictureBox_step4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_step4.Location = new System.Drawing.Point(1126, 54);
            this.pictureBox_step4.Name = "pictureBox_step4";
            this.pictureBox_step4.Size = new System.Drawing.Size(230, 230);
            this.pictureBox_step4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_step4.TabIndex = 6;
            this.pictureBox_step4.TabStop = false;
            // 
            // pictureBox_drawContour
            // 
            this.pictureBox_drawContour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_drawContour.Location = new System.Drawing.Point(1362, 54);
            this.pictureBox_drawContour.Name = "pictureBox_drawContour";
            this.pictureBox_drawContour.Size = new System.Drawing.Size(400, 400);
            this.pictureBox_drawContour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_drawContour.TabIndex = 7;
            this.pictureBox_drawContour.TabStop = false;
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.SkyBlue;
            this.trackBar1.Location = new System.Drawing.Point(1770, 54);
            this.trackBar1.Maximum = 255;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBar1.Size = new System.Drawing.Size(45, 400);
            this.trackBar1.TabIndex = 8;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label_threshold
            // 
            this.label_threshold.AutoSize = true;
            this.label_threshold.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_threshold.Location = new System.Drawing.Point(1764, 30);
            this.label_threshold.Name = "label_threshold";
            this.label_threshold.Size = new System.Drawing.Size(0, 21);
            this.label_threshold.TabIndex = 9;
            // 
            // label_input
            // 
            this.label_input.AutoSize = true;
            this.label_input.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_input.Location = new System.Drawing.Point(148, 457);
            this.label_input.Name = "label_input";
            this.label_input.Size = new System.Drawing.Size(99, 21);
            this.label_input.TabIndex = 10;
            this.label_input.Text = "Input Image";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(423, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Step1 : Convert RGB to Lab";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(674, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Step 2: Enhance contrast";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(903, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "Step 3: Smooth B channel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1165, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 21);
            this.label4.TabIndex = 14;
            this.label4.Text = "Step 4: Binarization";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1488, 457);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "Find and Draw contours";
            // 
            // button_segment
            // 
            this.button_segment.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_segment.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_segment.Location = new System.Drawing.Point(520, 457);
            this.button_segment.Name = "button_segment";
            this.button_segment.Size = new System.Drawing.Size(190, 45);
            this.button_segment.TabIndex = 16;
            this.button_segment.Text = "Segment ROI";
            this.button_segment.UseVisualStyleBackColor = false;
            this.button_segment.Click += new System.EventHandler(this.button_segment_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(587, 911);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 21);
            this.label6.TabIndex = 18;
            this.label6.Text = "ROI";
            // 
            // pictureBox_segmented
            // 
            this.pictureBox_segmented.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_segmented.Location = new System.Drawing.Point(409, 508);
            this.pictureBox_segmented.Name = "pictureBox_segmented";
            this.pictureBox_segmented.Size = new System.Drawing.Size(400, 400);
            this.pictureBox_segmented.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_segmented.TabIndex = 17;
            this.pictureBox_segmented.TabStop = false;
            // 
            // button_featureExtraction
            // 
            this.button_featureExtraction.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_featureExtraction.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_featureExtraction.Location = new System.Drawing.Point(959, 455);
            this.button_featureExtraction.Name = "button_featureExtraction";
            this.button_featureExtraction.Size = new System.Drawing.Size(258, 47);
            this.button_featureExtraction.TabIndex = 19;
            this.button_featureExtraction.Text = "Feature Extraction";
            this.button_featureExtraction.UseVisualStyleBackColor = false;
            this.button_featureExtraction.Click += new System.EventHandler(this.button_featureExtraction_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(961, 505);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(50, 10, 50, 10);
            this.label7.Size = new System.Drawing.Size(378, 49);
            this.label7.TabIndex = 20;
            this.label7.Text = "Parameters";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(961, 557);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 29);
            this.label8.TabIndex = 21;
            this.label8.Text = "Mean RGB";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_meanrgb
            // 
            this.textBox_meanrgb.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_meanrgb.Location = new System.Drawing.Point(1093, 558);
            this.textBox_meanrgb.Name = "textBox_meanrgb";
            this.textBox_meanrgb.ReadOnly = true;
            this.textBox_meanrgb.Size = new System.Drawing.Size(246, 29);
            this.textBox_meanrgb.TabIndex = 22;
            this.textBox_meanrgb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_meangray
            // 
            this.textBox_meangray.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_meangray.Location = new System.Drawing.Point(1093, 597);
            this.textBox_meangray.Name = "textBox_meangray";
            this.textBox_meangray.ReadOnly = true;
            this.textBox_meangray.Size = new System.Drawing.Size(246, 29);
            this.textBox_meangray.TabIndex = 24;
            this.textBox_meangray.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(961, 596);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 29);
            this.label9.TabIndex = 23;
            this.label9.Text = "Mean Gray";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_stdrgb
            // 
            this.textBox_stdrgb.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_stdrgb.Location = new System.Drawing.Point(1093, 635);
            this.textBox_stdrgb.Name = "textBox_stdrgb";
            this.textBox_stdrgb.ReadOnly = true;
            this.textBox_stdrgb.Size = new System.Drawing.Size(246, 29);
            this.textBox_stdrgb.TabIndex = 27;
            this.textBox_stdrgb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(961, 634);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 29);
            this.label10.TabIndex = 26;
            this.label10.Text = "S.D RGB";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_stdgray
            // 
            this.textBox_stdgray.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_stdgray.Location = new System.Drawing.Point(1093, 674);
            this.textBox_stdgray.Name = "textBox_stdgray";
            this.textBox_stdgray.ReadOnly = true;
            this.textBox_stdgray.Size = new System.Drawing.Size(246, 29);
            this.textBox_stdgray.TabIndex = 29;
            this.textBox_stdgray.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(961, 673);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 29);
            this.label11.TabIndex = 28;
            this.label11.Text = "S.D Gray";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_varGray
            // 
            this.textBox_varGray.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_varGray.Location = new System.Drawing.Point(1093, 751);
            this.textBox_varGray.Name = "textBox_varGray";
            this.textBox_varGray.ReadOnly = true;
            this.textBox_varGray.Size = new System.Drawing.Size(246, 29);
            this.textBox_varGray.TabIndex = 33;
            this.textBox_varGray.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(961, 750);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 29);
            this.label12.TabIndex = 32;
            this.label12.Text = "Var Gray";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_varRGB
            // 
            this.textBox_varRGB.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_varRGB.Location = new System.Drawing.Point(1093, 713);
            this.textBox_varRGB.Name = "textBox_varRGB";
            this.textBox_varRGB.ReadOnly = true;
            this.textBox_varRGB.Size = new System.Drawing.Size(246, 29);
            this.textBox_varRGB.TabIndex = 31;
            this.textBox_varRGB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(961, 712);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(127, 29);
            this.label13.TabIndex = 30;
            this.label13.Text = "Var RGB";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(867, 557);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 222);
            this.label14.TabIndex = 34;
            this.label14.Text = "Color features";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(867, 793);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 182);
            this.label15.TabIndex = 35;
            this.label15.Text = "Texture features";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_energy
            // 
            this.textBox_energy.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_energy.Location = new System.Drawing.Point(1094, 794);
            this.textBox_energy.Name = "textBox_energy";
            this.textBox_energy.ReadOnly = true;
            this.textBox_energy.Size = new System.Drawing.Size(246, 29);
            this.textBox_energy.TabIndex = 37;
            this.textBox_energy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label16.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(962, 793);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(126, 29);
            this.label16.TabIndex = 36;
            this.label16.Text = "Energy";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_contrast
            // 
            this.textBox_contrast.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_contrast.Location = new System.Drawing.Point(1094, 833);
            this.textBox_contrast.Name = "textBox_contrast";
            this.textBox_contrast.ReadOnly = true;
            this.textBox_contrast.Size = new System.Drawing.Size(246, 29);
            this.textBox_contrast.TabIndex = 39;
            this.textBox_contrast.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label17.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(962, 832);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(126, 29);
            this.label17.TabIndex = 38;
            this.label17.Text = "Contrast";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_correlation
            // 
            this.textBox_correlation.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_correlation.Location = new System.Drawing.Point(1094, 871);
            this.textBox_correlation.Name = "textBox_correlation";
            this.textBox_correlation.ReadOnly = true;
            this.textBox_correlation.Size = new System.Drawing.Size(246, 29);
            this.textBox_correlation.TabIndex = 41;
            this.textBox_correlation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label18.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(962, 870);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(126, 29);
            this.label18.TabIndex = 40;
            this.label18.Text = "Correlation";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_entropy
            // 
            this.textBox_entropy.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_entropy.Location = new System.Drawing.Point(1094, 908);
            this.textBox_entropy.Name = "textBox_entropy";
            this.textBox_entropy.ReadOnly = true;
            this.textBox_entropy.Size = new System.Drawing.Size(246, 29);
            this.textBox_entropy.TabIndex = 43;
            this.textBox_entropy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label19.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(962, 907);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(126, 29);
            this.label19.TabIndex = 42;
            this.label19.Text = "Entropy";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_homogeneity
            // 
            this.textBox_homogeneity.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_homogeneity.Location = new System.Drawing.Point(1094, 946);
            this.textBox_homogeneity.Name = "textBox_homogeneity";
            this.textBox_homogeneity.ReadOnly = true;
            this.textBox_homogeneity.Size = new System.Drawing.Size(246, 29);
            this.textBox_homogeneity.TabIndex = 45;
            this.textBox_homogeneity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label20.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label20.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(962, 945);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(126, 29);
            this.label20.TabIndex = 44;
            this.label20.Text = "Homonegeity";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.textBox_homogeneity);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.textBox_entropy);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.textBox_correlation);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.textBox_contrast);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.textBox_energy);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBox_varGray);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox_varRGB);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox_stdgray);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox_stdrgb);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox_meangray);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox_meanrgb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button_featureExtraction);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox_segmented);
            this.Controls.Add(this.button_segment);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_input);
            this.Controls.Add(this.label_threshold);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.pictureBox_drawContour);
            this.Controls.Add(this.pictureBox_step4);
            this.Controls.Add(this.pictureBox_step3);
            this.Controls.Add(this.pictureBox_step2);
            this.Controls.Add(this.pictureBox_step1);
            this.Controls.Add(this.button_preprocessing);
            this.Controls.Add(this.pictureBox_original);
            this.Controls.Add(this.button_importImg);
            this.Name = "Main_form";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_original)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_step1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_step2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_step3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_step4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_drawContour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_segmented)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_importImg;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox_original;
        private System.Windows.Forms.Button button_preprocessing;
        private System.Windows.Forms.PictureBox pictureBox_step1;
        private System.Windows.Forms.PictureBox pictureBox_step2;
        private System.Windows.Forms.PictureBox pictureBox_step3;
        private System.Windows.Forms.PictureBox pictureBox_step4;
        private System.Windows.Forms.PictureBox pictureBox_drawContour;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label_threshold;
        private System.Windows.Forms.Label label_input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_segment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox_segmented;
        private System.Windows.Forms.Button button_featureExtraction;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_meanrgb;
        private System.Windows.Forms.TextBox textBox_meangray;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_stdrgb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_stdgray;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_varGray;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_varRGB;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox_energy;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox_contrast;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox_correlation;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox_entropy;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBox_homogeneity;
        private System.Windows.Forms.Label label20;
    }
}