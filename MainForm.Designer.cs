namespace WFA230117
{
    partial class MainForm
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
            this.mainPictureBox = new System.Windows.Forms.PictureBox();
            this.oktatokButton = new System.Windows.Forms.Button();
            this.programokButton = new System.Windows.Forms.Button();
            this.jelentkezesButton = new System.Windows.Forms.Button();
            this.kilepesButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPictureBox
            // 
            this.mainPictureBox.Image = global::WFA230117.Properties.Resources.joga_BG;
            this.mainPictureBox.Location = new System.Drawing.Point(12, 25);
            this.mainPictureBox.Name = "mainPictureBox";
            this.mainPictureBox.Size = new System.Drawing.Size(376, 207);
            this.mainPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mainPictureBox.TabIndex = 0;
            this.mainPictureBox.TabStop = false;
            // 
            // oktatokButton
            // 
            this.oktatokButton.BackColor = System.Drawing.Color.White;
            this.oktatokButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.oktatokButton.ForeColor = System.Drawing.Color.DarkOrange;
            this.oktatokButton.Location = new System.Drawing.Point(12, 252);
            this.oktatokButton.Name = "oktatokButton";
            this.oktatokButton.Size = new System.Drawing.Size(376, 67);
            this.oktatokButton.TabIndex = 1;
            this.oktatokButton.Text = "OKTATÓK";
            this.oktatokButton.UseVisualStyleBackColor = false;
            // 
            // programokButton
            // 
            this.programokButton.BackColor = System.Drawing.Color.White;
            this.programokButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.programokButton.ForeColor = System.Drawing.Color.DarkOrange;
            this.programokButton.Location = new System.Drawing.Point(12, 325);
            this.programokButton.Name = "programokButton";
            this.programokButton.Size = new System.Drawing.Size(376, 67);
            this.programokButton.TabIndex = 1;
            this.programokButton.Text = "PROGRAMOK";
            this.programokButton.UseVisualStyleBackColor = false;
            // 
            // jelentkezesButton
            // 
            this.jelentkezesButton.BackColor = System.Drawing.Color.White;
            this.jelentkezesButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.jelentkezesButton.ForeColor = System.Drawing.Color.DarkOrange;
            this.jelentkezesButton.Location = new System.Drawing.Point(12, 398);
            this.jelentkezesButton.Name = "jelentkezesButton";
            this.jelentkezesButton.Size = new System.Drawing.Size(376, 67);
            this.jelentkezesButton.TabIndex = 1;
            this.jelentkezesButton.Text = "JELENTKEZÉS";
            this.jelentkezesButton.UseVisualStyleBackColor = false;
            // 
            // kilepesButton
            // 
            this.kilepesButton.BackColor = System.Drawing.Color.White;
            this.kilepesButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kilepesButton.ForeColor = System.Drawing.Color.OrangeRed;
            this.kilepesButton.Location = new System.Drawing.Point(12, 471);
            this.kilepesButton.Name = "kilepesButton";
            this.kilepesButton.Size = new System.Drawing.Size(376, 67);
            this.kilepesButton.TabIndex = 1;
            this.kilepesButton.Text = "KILÉPÉS";
            this.kilepesButton.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 550);
            this.Controls.Add(this.kilepesButton);
            this.Controls.Add(this.jelentkezesButton);
            this.Controls.Add(this.programokButton);
            this.Controls.Add(this.oktatokButton);
            this.Controls.Add(this.mainPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private PictureBox mainPictureBox;
        private Button oktatokButton;
        private Button programokButton;
        private Button jelentkezesButton;
        private Button kilepesButton;
    }
}