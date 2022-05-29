namespace AI.Fuzzy.Samples.TipsSample
{
    partial class MainForm
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
            this.fbInput = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbCrispResult = new System.Windows.Forms.GroupBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.tbFaiz = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.fbInput.SuspendLayout();
            this.gbCrispResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // fbInput
            // 
            this.fbInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fbInput.BackColor = System.Drawing.Color.Tan;
            this.fbInput.Controls.Add(this.comboBox2);
            this.fbInput.Controls.Add(this.comboBox1);
            this.fbInput.Controls.Add(this.label2);
            this.fbInput.Controls.Add(this.label1);
            this.fbInput.Location = new System.Drawing.Point(15, 17);
            this.fbInput.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.fbInput.Name = "fbInput";
            this.fbInput.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.fbInput.Size = new System.Drawing.Size(702, 67);
            this.fbInput.TabIndex = 2;
            this.fbInput.TabStop = false;
            this.fbInput.Text = "Girdiler";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.comboBox2.Location = new System.Drawing.Point(487, 23);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(136, 31);
            this.comboBox2.TabIndex = 10;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "500",
            "1000",
            "1500",
            "2000",
            "2500",
            "3000",
            "3500",
            "4000",
            "4500",
            "5000",
            "5500",
            "6000",
            "6500",
            "7000",
            "7500",
            "8000",
            "8500",
            "9000",
            "9500",
            "10000"});
            this.comboBox1.Location = new System.Drawing.Point(203, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(136, 31);
            this.comboBox1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(348, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Taksit (1 – 24):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kredi (500 – 10.000):";
            // 
            // gbCrispResult
            // 
            this.gbCrispResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCrispResult.BackColor = System.Drawing.Color.Tan;
            this.gbCrispResult.Controls.Add(this.btnRun);
            this.gbCrispResult.Controls.Add(this.tbFaiz);
            this.gbCrispResult.Controls.Add(this.label19);
            this.gbCrispResult.Location = new System.Drawing.Point(15, 92);
            this.gbCrispResult.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.gbCrispResult.Name = "gbCrispResult";
            this.gbCrispResult.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.gbCrispResult.Size = new System.Drawing.Size(702, 59);
            this.gbCrispResult.TabIndex = 7;
            this.gbCrispResult.TabStop = false;
            // 
            // btnRun
            // 
            this.btnRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRun.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRun.Location = new System.Drawing.Point(559, 18);
            this.btnRun.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(114, 32);
            this.btnRun.TabIndex = 8;
            this.btnRun.Text = "Çalýþtýr";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // tbFaiz
            // 
            this.tbFaiz.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbFaiz.Location = new System.Drawing.Point(122, 22);
            this.tbFaiz.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.tbFaiz.Name = "tbFaiz";
            this.tbFaiz.ReadOnly = true;
            this.tbFaiz.Size = new System.Drawing.Size(131, 30);
            this.tbFaiz.TabIndex = 17;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(9, 25);
            this.label19.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(101, 23);
            this.label19.TabIndex = 0;
            this.label19.Text = "Aylýk Faiz:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(738, 199);
            this.Controls.Add(this.gbCrispResult);
            this.Controls.Add(this.fbInput);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Bulanýk Mantýk Uygulama";
            this.fbInput.ResumeLayout(false);
            this.fbInput.PerformLayout();
            this.gbCrispResult.ResumeLayout(false);
            this.gbCrispResult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox fbInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbCrispResult;
        private System.Windows.Forms.TextBox tbFaiz;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}

