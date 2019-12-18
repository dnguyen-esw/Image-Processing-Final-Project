using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class Start_form : Form
    {
        Bitmap logoUTE, logoFHQ;

        private void button_start_Click(object sender, EventArgs e)
        {
            Main_form main = new Main_form();
            main.ShowDialog();
            this.Close();
        }

        public Start_form()
        {
            InitializeComponent();
            logoUTE = new Bitmap(@"C:\Users\hoang\OneDrive\Máy tính\Final Project\Final_Project\LogoUTE.jpg");
            logoFHQ = new Bitmap(@"C:\Users\hoang\OneDrive\Máy tính\Final Project\Final_Project\LogoFHQ.png");
            pictureBox_logoUTE.Image = logoUTE;
            pictureBox_logoFHQ.Image = logoFHQ;

            this.label_khoa.Text = "Khoa Đào tạo Chất lượng cao";
            this.label_nganh.Text = "Ngành Cơ điện tử";
        }
    }
}
