namespace _12_Linq
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
            button1 = new Button();
            button2 = new Button();
            listBox1 = new ListBox();
            button3 = new Button();
            txtOgrenci = new TextBox();
            lboxOgrenciler = new ListBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(28, 41);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(119, 42);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "link1 ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(51, 80);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(126, 109);
            listBox1.TabIndex = 2;
            // 
            // button3
            // 
            button3.Location = new Point(200, 42);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 3;
            button3.Text = "linq 2";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // txtOgrenci
            // 
            txtOgrenci.Location = new Point(284, 106);
            txtOgrenci.Name = "txtOgrenci";
            txtOgrenci.Size = new Size(117, 23);
            txtOgrenci.TabIndex = 4;
            txtOgrenci.TextChanged += txtOgrenci_TextChanged;
            // 
            // lboxOgrenciler
            // 
            lboxOgrenciler.FormattingEnabled = true;
            lboxOgrenciler.ItemHeight = 15;
            lboxOgrenciler.Location = new Point(288, 141);
            lboxOgrenciler.Name = "lboxOgrenciler";
            lboxOgrenciler.Size = new Size(113, 109);
            lboxOgrenciler.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(476, 335);
            Controls.Add(lboxOgrenciler);
            Controls.Add(txtOgrenci);
            Controls.Add(button3);
            Controls.Add(listBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private ListBox listBox1;
        private Button button3;
        private TextBox txtOgrenci;
        private ListBox lboxOgrenciler;
    }
}
