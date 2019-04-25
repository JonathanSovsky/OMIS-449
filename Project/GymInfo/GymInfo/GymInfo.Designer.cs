namespace GymInfo
{
    partial class WelcomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomePage));
            this.welcomeLbl = new System.Windows.Forms.Label();
            this.instructionsLbl = new System.Windows.Forms.Label();
            this.logoPicBox = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkPasswordBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // welcomeLbl
            // 
            this.welcomeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLbl.Location = new System.Drawing.Point(1, 47);
            this.welcomeLbl.Name = "welcomeLbl";
            this.welcomeLbl.Size = new System.Drawing.Size(799, 52);
            this.welcomeLbl.TabIndex = 0;
            this.welcomeLbl.Text = "Welcome!";
            this.welcomeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // instructionsLbl
            // 
            this.instructionsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionsLbl.Location = new System.Drawing.Point(0, 111);
            this.instructionsLbl.Name = "instructionsLbl";
            this.instructionsLbl.Size = new System.Drawing.Size(800, 37);
            this.instructionsLbl.TabIndex = 1;
            this.instructionsLbl.Text = "Please enter your password";
            this.instructionsLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logoPicBox
            // 
            this.logoPicBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPicBox.Image")));
            this.logoPicBox.Location = new System.Drawing.Point(305, 164);
            this.logoPicBox.Name = "logoPicBox";
            this.logoPicBox.Size = new System.Drawing.Size(191, 144);
            this.logoPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPicBox.TabIndex = 2;
            this.logoPicBox.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(281, 352);
            this.textBox1.MaxLength = 10;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(191, 33);
            this.textBox1.TabIndex = 3;
            // 
            // checkPasswordBtn
            // 
            this.checkPasswordBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkPasswordBtn.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.checkPasswordBtn.Location = new System.Drawing.Point(478, 352);
            this.checkPasswordBtn.Name = "checkPasswordBtn";
            this.checkPasswordBtn.Size = new System.Drawing.Size(57, 33);
            this.checkPasswordBtn.TabIndex = 4;
            this.checkPasswordBtn.Text = "-->";
            this.checkPasswordBtn.UseVisualStyleBackColor = true;
            this.checkPasswordBtn.Click += new System.EventHandler(this.checkPasswordBtn_Click);
            // 
            // WelcomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkPasswordBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.logoPicBox);
            this.Controls.Add(this.instructionsLbl);
            this.Controls.Add(this.welcomeLbl);
            this.Name = "WelcomePage";
            this.Text = "Welcome Page";
            ((System.ComponentModel.ISupportInitialize)(this.logoPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLbl;
        private System.Windows.Forms.Label instructionsLbl;
        private System.Windows.Forms.PictureBox logoPicBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button checkPasswordBtn;
    }
}

