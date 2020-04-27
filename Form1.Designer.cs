namespace Launch
{
    partial class Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.btn1 = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.soundbtn = new System.Windows.Forms.Button();
            this.ex_btn = new System.Windows.Forms.Button();
            this.gif = new System.Windows.Forms.PictureBox();
            this.draggy = new System.Windows.Forms.Panel();
            this.rep_btn = new System.Windows.Forms.PictureBox();
            this.hid_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rep_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Red;
            this.btn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn1.Location = new System.Drawing.Point(22, 251);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(63, 44);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "Unity";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // Title
            // 
            this.Title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Title.AutoSize = true;
            this.Title.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Title.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Title.ForeColor = System.Drawing.Color.Crimson;
            this.Title.Location = new System.Drawing.Point(40, 60);
            this.Title.MaximumSize = new System.Drawing.Size(285, 355);
            this.Title.MinimumSize = new System.Drawing.Size(200, 35);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(200, 35);
            this.Title.TabIndex = 1;
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.btn2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn2.Location = new System.Drawing.Point(112, 251);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(66, 44);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "Bad Guy\r\n8-bit";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Yellow;
            this.btn3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(0)))));
            this.btn3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(62)))));
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Comic Sans MS", 8.75F);
            this.btn3.Location = new System.Drawing.Point(203, 251);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(69, 44);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "Blue\r\n8-bit";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // soundbtn
            // 
            this.soundbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(49)))), ((int)(((byte)(87)))));
            this.soundbtn.BackgroundImage = global::Launch.Properties.Resources.sound_off;
            this.soundbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.soundbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.soundbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.soundbtn.Location = new System.Drawing.Point(109, 144);
            this.soundbtn.Name = "soundbtn";
            this.soundbtn.Size = new System.Drawing.Size(50, 50);
            this.soundbtn.TabIndex = 4;
            this.soundbtn.UseVisualStyleBackColor = false;
            this.soundbtn.Click += new System.EventHandler(this.soundbtn_Click_1);
            this.soundbtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.soundbtn_MouseDown);
            this.soundbtn.MouseLeave += new System.EventHandler(this.soundbtn_MouseLeave);
            this.soundbtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.soundbtn_MouseMove);
            // 
            // ex_btn
            // 
            this.ex_btn.BackgroundImage = global::Launch.Properties.Resources._61xXvEXqjbL__SL1313_;
            this.ex_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ex_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ex_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ex_btn.Location = new System.Drawing.Point(218, 8);
            this.ex_btn.Name = "ex_btn";
            this.ex_btn.Size = new System.Drawing.Size(59, 26);
            this.ex_btn.TabIndex = 5;
            this.ex_btn.UseVisualStyleBackColor = true;
            this.ex_btn.Click += new System.EventHandler(this.ex_btn_Click);
            this.ex_btn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ex_btn_MouseDown);
            this.ex_btn.MouseLeave += new System.EventHandler(this.ex_btn_MouseLeave);
            this.ex_btn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ex_btn_MouseMove);
            // 
            // gif
            // 
            this.gif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gif.Image = global::Launch.Properties.Resources._6oa;
            this.gif.Location = new System.Drawing.Point(215, 98);
            this.gif.Name = "gif";
            this.gif.Size = new System.Drawing.Size(62, 53);
            this.gif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gif.TabIndex = 6;
            this.gif.TabStop = false;
            this.gif.MouseEnter += new System.EventHandler(this.gif_MouseEnter);
            this.gif.MouseLeave += new System.EventHandler(this.gif_MouseLeave);
            // 
            // draggy
            // 
            this.draggy.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.draggy.Location = new System.Drawing.Point(33, 2);
            this.draggy.Name = "draggy";
            this.draggy.Size = new System.Drawing.Size(185, 31);
            this.draggy.TabIndex = 7;
            this.draggy.MouseDown += new System.Windows.Forms.MouseEventHandler(this.draggy_MouseDown);
            this.draggy.MouseMove += new System.Windows.Forms.MouseEventHandler(this.draggy_MouseMove);
            this.draggy.MouseUp += new System.Windows.Forms.MouseEventHandler(this.draggy_MouseUp);
            // 
            // rep_btn
            // 
            this.rep_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rep_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rep_btn.Location = new System.Drawing.Point(120, 206);
            this.rep_btn.MaximumSize = new System.Drawing.Size(30, 30);
            this.rep_btn.MinimumSize = new System.Drawing.Size(30, 30);
            this.rep_btn.Name = "rep_btn";
            this.rep_btn.Size = new System.Drawing.Size(30, 30);
            this.rep_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rep_btn.TabIndex = 9;
            this.rep_btn.TabStop = false;
            this.rep_btn.Click += new System.EventHandler(this.rep_btn_Click);
            // 
            // hid_btn
            // 
            this.hid_btn.BackgroundImage = global::Launch.Properties.Resources.Скриншот_14_04_2020_023602;
            this.hid_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hid_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hid_btn.FlatAppearance.BorderSize = 0;
            this.hid_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hid_btn.Location = new System.Drawing.Point(3, 8);
            this.hid_btn.Name = "hid_btn";
            this.hid_btn.Size = new System.Drawing.Size(22, 19);
            this.hid_btn.TabIndex = 10;
            this.hid_btn.UseVisualStyleBackColor = true;
            this.hid_btn.Click += new System.EventHandler(this.hid_btn_Click);
            this.hid_btn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.hid_btn_MouseDown);
            this.hid_btn.MouseLeave += new System.EventHandler(this.hid_btn_MouseLeave);
            this.hid_btn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.hid_btn_MouseMove);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Launch.Properties.Resources.Sweetie_Bot_v_2_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(284, 332);
            this.Controls.Add(this.hid_btn);
            this.Controls.Add(this.rep_btn);
            this.Controls.Add(this.draggy);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.gif);
            this.Controls.Add(this.ex_btn);
            this.Controls.Add(this.soundbtn);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(49)))), ((int)(((byte)(87)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form";
            this.Opacity = 0.95D;
            this.Text = "8-bit";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rep_btn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button soundbtn;
        private System.Windows.Forms.Button ex_btn;
        private System.Windows.Forms.PictureBox gif;
        private System.Windows.Forms.Panel draggy;
        private System.Windows.Forms.PictureBox rep_btn;
        private System.Windows.Forms.Button hid_btn;
    }
}

