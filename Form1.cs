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
        bool isrep = false;

        public Form()
        {
            InitializeComponent();


            gif.SizeMode = PictureBoxSizeMode.StretchImage;


            draggy.BackColor = Color.Transparent;

            this.FormBorderStyle = FormBorderStyle.None;

            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            Title.BackColor = Color.Transparent;
            gif.BackColor = Color.Transparent;
            rep_btn.BackColor = Color.Transparent;

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
            rep_btn.Image = Properties.Resources.iconfinder_Gnome_Media_Playlist_Repeat_32_55080;

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

            if (isrep)
                s3.PlayLooping();
            else
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


            if (isrep)
                s1.PlayLooping();
            else
                s1.Play();

            Title.Font = plf;
            Title.Text = "Сейчас играет:\n TheFatRat - Unity";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            gif.Show();


            if (isrep)
                s2.PlayLooping();
            else
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


        private void rep_btn_Click(object sender, EventArgs e)
        {
            if (isrep)
            {
                rep_btn.Image = Properties.Resources.iconfinder_Gnome_Media_Playlist_Repeat_32_55080;
            }
            else
            {
                rep_btn.Image = Properties.Resources.iconfinder_arrow_repeat_once_45844;
            }

            isrep = !isrep;
        }

        

        private void soundbtn_MouseLeave(object sender, EventArgs e)
        {
            soundbtn.Image = Properties.Resources.sound_off;
        }

        private void soundbtn_MouseDown(object sender, MouseEventArgs e)
        {
            soundbtn.Image = Properties.Resources.i01_sound_off__1_;
        }

        private void soundbtn_MouseMove(object sender, MouseEventArgs e)
        {
            soundbtn.Image = Properties.Resources.i01_sound_off;

        }

        private void hid_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void hid_btn_MouseDown(object sender, MouseEventArgs e)
        {
            hid_btn.BackgroundImage = Properties.Resources.i01_Скриншот_14_04_2020_023602__1_;
        }

        private void hid_btn_MouseMove(object sender, MouseEventArgs e)
        {
            hid_btn.BackgroundImage = Properties.Resources.i01_Скриншот_14_04_2020_023602;
        }

        private void hid_btn_MouseLeave(object sender, EventArgs e)
        {
            hid_btn.BackgroundImage = Properties.Resources.Скриншот_14_04_2020_023602;
        }

        private void ex_btn_MouseMove(object sender, MouseEventArgs e)
        {
            ex_btn.BackgroundImage = Properties.Resources.i01_61xXvEXqjbL__SL1313_;
        }

        private void ex_btn_MouseLeave(object sender, EventArgs e)
        {
            ex_btn.BackgroundImage = Properties.Resources._61xXvEXqjbL__SL1313_;
        }

        private void ex_btn_MouseDown(object sender, MouseEventArgs e)
        {
            ex_btn.BackgroundImage = Properties.Resources.i01_61xXvEXqjbL__SL1313___1_;
        }

        private void gif_MouseEnter(object sender, EventArgs e)
        {
            gif.Image = Properties.Resources.Папуг;
        }

        private void gif_MouseLeave(object sender, EventArgs e)
        {
            gif.Image = Properties.Resources._6oa;
        }
    }
}
