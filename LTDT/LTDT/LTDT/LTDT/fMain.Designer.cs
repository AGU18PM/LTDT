namespace LTDT
{
    partial class fMain
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
            this.nUDCityAmount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nUDRoadAmount = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbTS = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.cboB = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboA = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txbCash = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbEnds = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbStartPoint = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.pBDT = new System.Windows.Forms.PictureBox();
            this.btnResult = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txbDoDai = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nUDCityAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDRoadAmount)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBDT)).BeginInit();
            this.SuspendLayout();
            // 
            // nUDCityAmount
            // 
            this.nUDCityAmount.Location = new System.Drawing.Point(104, 138);
            this.nUDCityAmount.Name = "nUDCityAmount";
            this.nUDCityAmount.Size = new System.Drawing.Size(120, 20);
            this.nUDCityAmount.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số thành phố";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Số đoạn đường";
            // 
            // nUDRoadAmount
            // 
            this.nUDRoadAmount.Location = new System.Drawing.Point(104, 177);
            this.nUDRoadAmount.Name = "nUDRoadAmount";
            this.nUDRoadAmount.Size = new System.Drawing.Size(120, 20);
            this.nUDRoadAmount.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txbDoDai);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txbTS);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.cboB);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cboA);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txbCash);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txbEnds);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txbStartPoint);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nUDCityAmount);
            this.groupBox1.Controls.Add(this.nUDRoadAmount);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 414);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Số tiền";
            // 
            // txbTS
            // 
            this.txbTS.Location = new System.Drawing.Point(104, 285);
            this.txbTS.Name = "txbTS";
            this.txbTS.Size = new System.Drawing.Size(120, 20);
            this.txbTS.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(9, 372);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 36);
            this.button2.TabIndex = 13;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cboB
            // 
            this.cboB.FormattingEnabled = true;
            this.cboB.Location = new System.Drawing.Point(126, 254);
            this.cboB.Name = "cboB";
            this.cboB.Size = new System.Drawing.Size(70, 21);
            this.cboB.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(98, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "--->";
            // 
            // cboA
            // 
            this.cboA.FormattingEnabled = true;
            this.cboA.Location = new System.Drawing.Point(22, 254);
            this.cboA.Name = "cboA";
            this.cboA.Size = new System.Drawing.Size(70, 21);
            this.cboA.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 36);
            this.button1.TabIndex = 5;
            this.button1.Text = "Xong";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Số tiền";
            // 
            // txbCash
            // 
            this.txbCash.Location = new System.Drawing.Point(104, 100);
            this.txbCash.Name = "txbCash";
            this.txbCash.Size = new System.Drawing.Size(120, 20);
            this.txbCash.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Điểm kết thúc";
            // 
            // txbEnds
            // 
            this.txbEnds.Location = new System.Drawing.Point(104, 64);
            this.txbEnds.Name = "txbEnds";
            this.txbEnds.Size = new System.Drawing.Size(120, 20);
            this.txbEnds.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Điểm bắt đầu";
            // 
            // txbStartPoint
            // 
            this.txbStartPoint.Location = new System.Drawing.Point(104, 28);
            this.txbStartPoint.Name = "txbStartPoint";
            this.txbStartPoint.Size = new System.Drawing.Size(120, 20);
            this.txbStartPoint.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(13, 433);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(64, 44);
            this.button3.TabIndex = 5;
            this.button3.Text = "Load";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pBDT
            // 
            this.pBDT.Location = new System.Drawing.Point(262, 13);
            this.pBDT.Name = "pBDT";
            this.pBDT.Size = new System.Drawing.Size(586, 464);
            this.pBDT.TabIndex = 6;
            this.pBDT.TabStop = false;
            this.pBDT.Paint += new System.Windows.Forms.PaintEventHandler(this.pBDT_Paint);
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(101, 434);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(72, 43);
            this.btnResult.TabIndex = 7;
            this.btnResult.Text = "Ket qua";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 332);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Độ dài";
            // 
            // txbDoDai
            // 
            this.txbDoDai.Location = new System.Drawing.Point(104, 325);
            this.txbDoDai.Name = "txbDoDai";
            this.txbDoDai.Size = new System.Drawing.Size(120, 20);
            this.txbDoDai.TabIndex = 16;
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 489);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.pBDT);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "fMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nUDCityAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDRoadAmount)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBDT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nUDCityAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nUDRoadAmount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbEnds;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbStartPoint;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbCash;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cboB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboA;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbTS;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pBDT;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbDoDai;
    }
}

