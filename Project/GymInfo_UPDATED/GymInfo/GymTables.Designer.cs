namespace GymInfo
{
    partial class GymTables
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GymTables));
            this.label1 = new System.Windows.Forms.Label();
            this.classBtn = new System.Windows.Forms.Button();
            this.membershipBtn = new System.Windows.Forms.Button();
            this.memberBtn = new System.Windows.Forms.Button();
            this.clubBtn = new System.Windows.Forms.Button();
            this.employeeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(506, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Which table would you like to see?";
            // 
            // classBtn
            // 
            this.classBtn.BackColor = System.Drawing.Color.Transparent;
            this.classBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("classBtn.BackgroundImage")));
            this.classBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.classBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.classBtn.FlatAppearance.BorderSize = 100;
            this.classBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classBtn.ForeColor = System.Drawing.Color.Black;
            this.classBtn.Location = new System.Drawing.Point(12, 89);
            this.classBtn.Name = "classBtn";
            this.classBtn.Size = new System.Drawing.Size(228, 127);
            this.classBtn.TabIndex = 1;
            this.classBtn.Text = "CLASS";
            this.classBtn.UseVisualStyleBackColor = true;
            this.classBtn.Click += new System.EventHandler(this.classBtn_Click);
            // 
            // membershipBtn
            // 
            this.membershipBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("membershipBtn.BackgroundImage")));
            this.membershipBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.membershipBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.membershipBtn.Location = new System.Drawing.Point(452, 271);
            this.membershipBtn.Name = "membershipBtn";
            this.membershipBtn.Size = new System.Drawing.Size(228, 127);
            this.membershipBtn.TabIndex = 2;
            this.membershipBtn.Text = "MEMBERSHIP";
            this.membershipBtn.UseVisualStyleBackColor = true;
            this.membershipBtn.Click += new System.EventHandler(this.membershipBtn_Click);
            // 
            // memberBtn
            // 
            this.memberBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("memberBtn.BackgroundImage")));
            this.memberBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.memberBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberBtn.Location = new System.Drawing.Point(145, 271);
            this.memberBtn.Name = "memberBtn";
            this.memberBtn.Size = new System.Drawing.Size(228, 127);
            this.memberBtn.TabIndex = 3;
            this.memberBtn.Text = "MEMBER";
            this.memberBtn.UseVisualStyleBackColor = true;
            this.memberBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // clubBtn
            // 
            this.clubBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("clubBtn.BackgroundImage")));
            this.clubBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clubBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clubBtn.ForeColor = System.Drawing.Color.Black;
            this.clubBtn.Location = new System.Drawing.Point(294, 89);
            this.clubBtn.Name = "clubBtn";
            this.clubBtn.Size = new System.Drawing.Size(228, 127);
            this.clubBtn.TabIndex = 4;
            this.clubBtn.Text = "CLUB";
            this.clubBtn.UseVisualStyleBackColor = true;
            this.clubBtn.Click += new System.EventHandler(this.clubBtn_Click);
            // 
            // employeeBtn
            // 
            this.employeeBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("employeeBtn.BackgroundImage")));
            this.employeeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.employeeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeBtn.Location = new System.Drawing.Point(560, 89);
            this.employeeBtn.Name = "employeeBtn";
            this.employeeBtn.Size = new System.Drawing.Size(228, 127);
            this.employeeBtn.TabIndex = 5;
            this.employeeBtn.Text = "EMPLOYEE";
            this.employeeBtn.UseVisualStyleBackColor = true;
            this.employeeBtn.Click += new System.EventHandler(this.employeeBtn_Click);
            // 
            // GymTables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.employeeBtn);
            this.Controls.Add(this.clubBtn);
            this.Controls.Add(this.memberBtn);
            this.Controls.Add(this.membershipBtn);
            this.Controls.Add(this.classBtn);
            this.Controls.Add(this.label1);
            this.Name = "GymTables";
            this.Text = "GymTables";
            this.Load += new System.EventHandler(this.GymTables_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button classBtn;
        private System.Windows.Forms.Button membershipBtn;
        private System.Windows.Forms.Button memberBtn;
        private System.Windows.Forms.Button clubBtn;
        private System.Windows.Forms.Button employeeBtn;
    }
}