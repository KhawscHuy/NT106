namespace Lab2
{
    partial class baitap2
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
            this.btn_readfile = new System.Windows.Forms.Button();
            this.ReadfileRTB = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_FileName = new System.Windows.Forms.TextBox();
            this.tb_Size = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_LineCount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_URL = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_CharCount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_WordsCount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_readfile
            // 
            this.btn_readfile.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_readfile.Location = new System.Drawing.Point(890, 475);
            this.btn_readfile.Name = "btn_readfile";
            this.btn_readfile.Size = new System.Drawing.Size(497, 116);
            this.btn_readfile.TabIndex = 1;
            this.btn_readfile.Text = "Read From File";
            this.btn_readfile.UseVisualStyleBackColor = true;
            this.btn_readfile.Click += new System.EventHandler(this.btn_readfile_Click);
            // 
            // ReadfileRTB
            // 
            this.ReadfileRTB.Location = new System.Drawing.Point(12, 12);
            this.ReadfileRTB.Name = "ReadfileRTB";
            this.ReadfileRTB.Size = new System.Drawing.Size(872, 752);
            this.ReadfileRTB.TabIndex = 2;
            this.ReadfileRTB.Text = "";
            this.ReadfileRTB.TextChanged += new System.EventHandler(this.ReadfileRTB_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(898, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = " File name:";
            // 
            // tb_FileName
            // 
            this.tb_FileName.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_FileName.Location = new System.Drawing.Point(1004, 81);
            this.tb_FileName.Name = "tb_FileName";
            this.tb_FileName.Size = new System.Drawing.Size(383, 34);
            this.tb_FileName.TabIndex = 4;
            // 
            // tb_Size
            // 
            this.tb_Size.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Size.Location = new System.Drawing.Point(957, 147);
            this.tb_Size.Name = "tb_Size";
            this.tb_Size.Size = new System.Drawing.Size(430, 34);
            this.tb_Size.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(898, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "Size:";
            // 
            // tb_LineCount
            // 
            this.tb_LineCount.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_LineCount.Location = new System.Drawing.Point(1004, 277);
            this.tb_LineCount.Name = "tb_LineCount";
            this.tb_LineCount.Size = new System.Drawing.Size(383, 34);
            this.tb_LineCount.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(898, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 27);
            this.label3.TabIndex = 9;
            this.label3.Text = "Line count:";
            // 
            // tb_URL
            // 
            this.tb_URL.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_URL.Location = new System.Drawing.Point(959, 213);
            this.tb_URL.Name = "tb_URL";
            this.tb_URL.Size = new System.Drawing.Size(428, 34);
            this.tb_URL.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(898, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 27);
            this.label4.TabIndex = 7;
            this.label4.Text = "URL:";
            // 
            // tb_CharCount
            // 
            this.tb_CharCount.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_CharCount.Location = new System.Drawing.Point(1061, 414);
            this.tb_CharCount.Name = "tb_CharCount";
            this.tb_CharCount.Size = new System.Drawing.Size(326, 34);
            this.tb_CharCount.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(898, 417);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 27);
            this.label5.TabIndex = 13;
            this.label5.Text = "Character count:";
            // 
            // tb_WordsCount
            // 
            this.tb_WordsCount.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_WordsCount.Location = new System.Drawing.Point(1023, 348);
            this.tb_WordsCount.Name = "tb_WordsCount";
            this.tb_WordsCount.Size = new System.Drawing.Size(364, 34);
            this.tb_WordsCount.TabIndex = 12;
            this.tb_WordsCount.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(898, 351);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 27);
            this.label6.TabIndex = 11;
            this.label6.Text = "Words count:";
            // 
            // baitap2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1399, 776);
            this.Controls.Add(this.tb_CharCount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_WordsCount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_LineCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_URL);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_Size);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_FileName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReadfileRTB);
            this.Controls.Add(this.btn_readfile);
            this.Name = "baitap2";
            this.Text = "bài tập 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_readfile;
        private System.Windows.Forms.RichTextBox ReadfileRTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_FileName;
        private System.Windows.Forms.TextBox tb_Size;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_LineCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_URL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_CharCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_WordsCount;
        private System.Windows.Forms.Label label6;
    }
}