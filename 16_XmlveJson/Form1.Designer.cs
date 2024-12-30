namespace _16_XmlveJson
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
            btnXml = new Button();
            dgwData = new DataGridView();
            btnJson = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgwData).BeginInit();
            SuspendLayout();
            // 
            // btnXml
            // 
            btnXml.Location = new Point(44, 12);
            btnXml.Name = "btnXml";
            btnXml.Size = new Size(100, 30);
            btnXml.TabIndex = 0;
            btnXml.Text = "Xml Okuma";
            btnXml.UseVisualStyleBackColor = true;
            btnXml.Click += btnXml_Click;
            // 
            // dgwData
            // 
            dgwData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwData.Dock = DockStyle.Bottom;
            dgwData.Location = new Point(0, 61);
            dgwData.Name = "dgwData";
            dgwData.RowTemplate.Height = 25;
            dgwData.Size = new Size(511, 150);
            dgwData.TabIndex = 1;
            // 
            // btnJson
            // 
            btnJson.Location = new Point(192, 12);
            btnJson.Name = "btnJson";
            btnJson.Size = new Size(105, 30);
            btnJson.TabIndex = 2;
            btnJson.Text = "Json Okuma";
            btnJson.UseVisualStyleBackColor = true;
            btnJson.Click += btnJson_Click;
            // 
            // button1
            // 
            button1.Location = new Point(336, 16);
            button1.Name = "button1";
            button1.Size = new Size(100, 26);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 211);
            Controls.Add(button1);
            Controls.Add(btnJson);
            Controls.Add(dgwData);
            Controls.Add(btnXml);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgwData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnXml;
        private DataGridView dgwData;
        private Button btnJson;
        private Button button1;
    }
}
