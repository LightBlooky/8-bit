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
            ((System.ComponentModel.ISupportInitialize)(this.gif)).BeginInit();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Red;
            this.btn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
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
            this.btn2.Font = new System.Drawing.Font("Comic Sans MS", 9.25F);
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
            this.btn3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.soundbtn.BackgroundImage = global::Launch.Properties.Resources.sound_off;
            this.soundbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.soundbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.soundbtn.Location = new System.Drawing.Point(109, 144);
            this.soundbtn.Name = "soundbtn";
            this.soundbtn.Size = new System.Drawing.Size(50, 50);
            this.soundbtn.TabIndex = 4;
            this.soundbtn.UseVisualStyleBackColor = true;
            this.soundbtn.Click += new System.EventHandler(this.soundbtn_Click_1);
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
            // 
            // gif
            // 
            this.gif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gif.Image = global::Launch.Properties.Resources._6oa;
            this.gif.Location = new System.Drawing.Point(215, 98);
            this.gif.Name = "gif";
            this.gif.Size = new System.Drawing.Size(62, 53);
            this.gif.TabIndex = 6;
            this.gif.TabStop = false;
            // 
            // draggy
            // 
            this.draggy.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.draggy.Location = new System.Drawing.Point(2, 2);
            this.draggy.Name = "draggy";
            this.draggy.Size = new System.Drawing.Size(216, 31);
            this.draggy.TabIndex = 7;
            this.draggy.MouseDown += new System.Windows.Forms.MouseEventHandler(this.draggy_MouseDown);
            this.draggy.MouseMove += new System.Windows.Forms.MouseEventHandler(this.draggy_MouseMove);
            this.draggy.MouseUp += new System.Windows.Forms.MouseEventHandler(this.draggy_MouseUp);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Launch.Properties.Resources.Sweetie_Bot_v_2_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(284, 332);
            this.Controls.Add(this.draggy);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.gif);
            this.Controls.Add(this.ex_btn);
            this.Controls.Add(this.soundbtn);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form";
            this.Text = "8-bit";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gif)).EndInit();
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
    }
}

