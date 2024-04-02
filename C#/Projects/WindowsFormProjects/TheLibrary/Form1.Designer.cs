
namespace WindowsFormsApp1
{
    partial class Form1
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
            this.button_hello = new System.Windows.Forms.Button();
            this.button_hit = new System.Windows.Forms.Button();
            this.label_mess = new System.Windows.Forms.Label();
            this.button_forward = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelmess = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_hello
            // 
            this.button_hello.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_hello.ForeColor = System.Drawing.Color.Black;
            this.button_hello.Location = new System.Drawing.Point(320, 12);
            this.button_hello.Name = "button_hello";
            this.button_hello.Size = new System.Drawing.Size(242, 95);
            this.button_hello.TabIndex = 0;
            this.button_hello.Text = "Welcome to our library! \r\n(click me)";
            this.button_hello.UseVisualStyleBackColor = true;
            this.button_hello.Click += new System.EventHandler(this.button_hello_Click);
            // 
            // button_hit
            // 
            this.button_hit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_hit.ForeColor = System.Drawing.Color.Black;
            this.button_hit.Location = new System.Drawing.Point(347, 113);
            this.button_hit.Name = "button_hit";
            this.button_hit.Size = new System.Drawing.Size(196, 39);
            this.button_hit.TabIndex = 2;
            this.button_hit.Text = "Hit for fashion style!";
            this.button_hit.UseVisualStyleBackColor = true;
            this.button_hit.Click += new System.EventHandler(this.button_hit_Click);
            // 
            // label_mess
            // 
            this.label_mess.AutoSize = true;
            this.label_mess.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_mess.ForeColor = System.Drawing.Color.DimGray;
            this.label_mess.Location = new System.Drawing.Point(257, 284);
            this.label_mess.Name = "label_mess";
            this.label_mess.Size = new System.Drawing.Size(0, 32);
            this.label_mess.TabIndex = 3;
            this.label_mess.Click += new System.EventHandler(this.label_mess_Click);
            // 
            // button_forward
            // 
            this.button_forward.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_forward.ForeColor = System.Drawing.Color.Red;
            this.button_forward.Location = new System.Drawing.Point(595, 478);
            this.button_forward.Name = "button_forward";
            this.button_forward.Size = new System.Drawing.Size(141, 34);
            this.button_forward.TabIndex = 4;
            this.button_forward.Text = "Go forward! ->";
            this.button_forward.UseVisualStyleBackColor = true;
            this.button_forward.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(149, -35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(587, 580);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // labelmess
            // 
            this.labelmess.AutoSize = true;
            this.labelmess.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmess.ForeColor = System.Drawing.Color.Sienna;
            this.labelmess.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.labelmess.Location = new System.Drawing.Point(185, 479);
            this.labelmess.Name = "labelmess";
            this.labelmess.Size = new System.Drawing.Size(0, 36);
            this.labelmess.TabIndex = 6;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(920, 524);
            this.Controls.Add(this.labelmess);
            this.Controls.Add(this.button_forward);
            this.Controls.Add(this.label_mess);
            this.Controls.Add(this.button_hit);
            this.Controls.Add(this.button_hello);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.DarkViolet;
            this.Name = "Form1";
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_hello;
        private System.Windows.Forms.Button button_hit;
        private System.Windows.Forms.Label label_mess;
        private System.Windows.Forms.Button button_forward;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelmess;
    }
}

