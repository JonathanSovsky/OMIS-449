namespace GymInfo
{
    partial class Gym_QT
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
            this.instructionLbl = new System.Windows.Forms.Label();
            this.tableBtn = new System.Windows.Forms.Button();
            this.queriesBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // instructionLbl
            // 
            this.instructionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLbl.Location = new System.Drawing.Point(12, 62);
            this.instructionLbl.Name = "instructionLbl";
            this.instructionLbl.Size = new System.Drawing.Size(776, 49);
            this.instructionLbl.TabIndex = 0;
            this.instructionLbl.Text = "What would you like to see?";
            this.instructionLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableBtn
            // 
            this.tableBtn.Location = new System.Drawing.Point(141, 203);
            this.tableBtn.Name = "tableBtn";
            this.tableBtn.Size = new System.Drawing.Size(174, 73);
            this.tableBtn.TabIndex = 1;
            this.tableBtn.Text = "Tables";
            this.tableBtn.UseVisualStyleBackColor = true;
            this.tableBtn.Click += new System.EventHandler(this.tableBtn_Click);
            // 
            // queriesBtn
            // 
            this.queriesBtn.Location = new System.Drawing.Point(443, 203);
            this.queriesBtn.Name = "queriesBtn";
            this.queriesBtn.Size = new System.Drawing.Size(174, 73);
            this.queriesBtn.TabIndex = 2;
            this.queriesBtn.Text = "Queries";
            this.queriesBtn.UseVisualStyleBackColor = true;
            this.queriesBtn.Click += new System.EventHandler(this.queriesBtn_Click);
            // 
            // Gym_QT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.queriesBtn);
            this.Controls.Add(this.tableBtn);
            this.Controls.Add(this.instructionLbl);
            this.Name = "Gym_QT";
            this.Text = "Gym_QT";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label instructionLbl;
        private System.Windows.Forms.Button tableBtn;
        private System.Windows.Forms.Button queriesBtn;
    }
}