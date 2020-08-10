namespace ForCarol
{
    partial class ForCarol
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForCarol));
            this.label1 = new System.Windows.Forms.Label();
            this.btnCarol = new System.Windows.Forms.Button();
            this.VerifyAnswer = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "For the Love of my life, Carol";
            // 
            // btnCarol
            // 
            this.btnCarol.Location = new System.Drawing.Point(12, 225);
            this.btnCarol.Name = "btnCarol";
            this.btnCarol.Size = new System.Drawing.Size(75, 23);
            this.btnCarol.TabIndex = 1;
            this.btnCarol.Text = "Click Me";
            this.btnCarol.UseVisualStyleBackColor = true;
            this.btnCarol.Click += new System.EventHandler(this.btnCarol_Click);
            // 
            // VerifyAnswer
            // 
            this.VerifyAnswer.Location = new System.Drawing.Point(141, 225);
            this.VerifyAnswer.Name = "VerifyAnswer";
            this.VerifyAnswer.Size = new System.Drawing.Size(125, 23);
            this.VerifyAnswer.TabIndex = 2;
            this.VerifyAnswer.Text = "Verify Answer";
            this.VerifyAnswer.UseVisualStyleBackColor = true;
            this.VerifyAnswer.Visible = false;
            this.VerifyAnswer.Click += new System.EventHandler(this.VerifyAnswer_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(56, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // ForCarol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 260);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.VerifyAnswer);
            this.Controls.Add(this.btnCarol);
            this.Controls.Add(this.label1);
            this.Name = "ForCarol";
            this.Text = "ForCarol";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button btnCarol;
        public System.Windows.Forms.Button VerifyAnswer;
    }
}

