namespace _8_Collections
{
    partial class Form1
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
            btnKonu = new Button();
            SuspendLayout();
            // 
            // btnKonu
            // 
            btnKonu.Location = new Point(46, 12);
            btnKonu.Name = "btnKonu";
            btnKonu.Size = new Size(75, 23);
            btnKonu.TabIndex = 0;
            btnKonu.Text = "Konu";
            btnKonu.UseVisualStyleBackColor = true;
            btnKonu.Click += btnKonu_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 270);
            Controls.Add(btnKonu);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnKonu;
    }
}
