using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Launch
{
    public partial class Form : System.Windows.Forms.Form
    {
        SoundPlayer s1 = new SoundPlayer(Properties.Resources.Unity);
        SoundPlayer s2 = new SoundPlayer(Properties.Resources.BadGuy);
        SoundPlayer s3 = new SoundPlayer(Properties.Resources.Blue);
        Font plf = new Font("Comic Sans", 12);

        private Point mouseOffset;
        private bool isMouseDown = false;

        public Form()
        {
            InitializeComponent();

            gif.SizeMode = PictureBoxSizeMode.StretchImage;


            draggy.BackColor = Color.Transparent;

            this.FormBorderStyle = FormBorderStyle.None;

            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            Title.BackColor = Color.Transparent;
            gif.BackColor = Color.Transparent;

            //круглые кнопки
            System.Drawing.Drawing2D.GraphicsPath myPath =
            new System.Drawing.Drawing2D.GraphicsPath();
            myPath.AddEllipse(0, 0, soundbtn.Width, soundbtn.Height);

            Region myRegion = new Region(myPath);
            soundbtn.Region = myRegion;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gif.Hide();
            Title.Text = "Что послушаем?";

        }


        #region кнопки
        private void soundbtn_Click_1(object sender, EventArgs e)
        {
            if (Title.Text != "Что послушаем?")
            {
                gif.Hide();

                s1.Stop();
                s2.Stop();
                s3.Stop();

                Title.Text = "Ещё что-нибудь?";
            }
        }


        private void btn3_Click(object sender, EventArgs e)
        {
            gif.Show();

            s3.Play();

            Title.Font = plf;
            Title.Text = "Сейчас играет: I'm Blue 8-bit";
        }

        private void ex_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            gif.Show();

            s1.Play();

            Title.Font = plf;
            Title.Text = "Сейчас играет:\n TheFatRat - Unity";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            gif.Show();

            s2.Play();

            Title.Font = plf;
            Title.Text = "Сейчас играет: Bad Guy 8-bit";
        }
        #endregion


        #region перетаскивать
        private void draggy_MouseDown(object sender, MouseEventArgs e)
        {
            int xOffset;
            int yOffset;

            if (e.Button == MouseButtons.Left)
            {
                xOffset = -e.X - SystemInformation.FrameBorderSize.Width;
                yOffset = -e.Y - SystemInformation.CaptionHeight -
                    SystemInformation.FrameBorderSize.Height;
                mouseOffset = new Point(xOffset, yOffset);
                isMouseDown = true;
            }
        }

        private void draggy_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                Location = mousePos;
            }
        }

        private void draggy_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
