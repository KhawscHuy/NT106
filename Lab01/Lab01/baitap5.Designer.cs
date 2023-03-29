namespace Lab01
{
    partial class baitap5
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
            this.A = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.B = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ans = new System.Windows.Forms.Button();
            this.xoa = new System.Windows.Forms.Button();
            this.thoat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ans2 = new System.Windows.Forms.TextBox();
            this.ans5 = new System.Windows.Forms.TextBox();
            this.ans4 = new System.Windows.Forms.TextBox();
            this.ans3 = new System.Windows.Forms.TextBox();
            this.ans1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // A
            // 
            this.A.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A.Location = new System.Drawing.Point(264, 79);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(204, 38);
            this.A.TabIndex = 4;
            this.A.TextChanged += new System.EventHandler(this.A_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nhập A";
            // 
            // B
            // 
            this.B.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B.Location = new System.Drawing.Point(617, 79);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(204, 38);
            this.B.TabIndex = 6;
            this.B.TextChanged += new System.EventHandler(this.B_TextChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(501, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 33);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nhập B";
            // 
            // ans
            // 
            this.ans.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ans.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ans.Location = new System.Drawing.Point(198, 153);
            this.ans.Name = "ans";
            this.ans.Size = new System.Drawing.Size(270, 60);
            this.ans.TabIndex = 7;
            this.ans.Text = "Tính các giá trị";
            this.ans.UseVisualStyleBackColor = false;
            this.ans.Click += new System.EventHandler(this.ans_Click);
            // 
            // xoa
            // 
            this.xoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.xoa.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoa.Location = new System.Drawing.Point(507, 152);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(137, 61);
            this.xoa.TabIndex = 8;
            this.xoa.Text = "Xóa";
            this.xoa.UseVisualStyleBackColor = false;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // thoat
            // 
            this.thoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.thoat.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thoat.Location = new System.Drawing.Point(684, 152);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(137, 61);
            this.thoat.TabIndex = 9;
            this.thoat.Text = "Thoát";
            this.thoat.UseVisualStyleBackColor = false;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ans2);
            this.groupBox1.Controls.Add(this.ans5);
            this.groupBox1.Controls.Add(this.ans4);
            this.groupBox1.Controls.Add(this.ans3);
            this.groupBox1.Controls.Add(this.ans1);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(62, 262);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(845, 264);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "KẾT QUẢ";
            // 
            // ans2
            // 
            this.ans2.BackColor = System.Drawing.SystemColors.Control;
            this.ans2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ans2.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ans2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ans2.Location = new System.Drawing.Point(474, 44);
            this.ans2.Name = "ans2";
            this.ans2.Size = new System.Drawing.Size(365, 31);
            this.ans2.TabIndex = 4;
            // 
            // ans5
            // 
            this.ans5.BackColor = System.Drawing.SystemColors.Control;
            this.ans5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ans5.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ans5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ans5.Location = new System.Drawing.Point(17, 197);
            this.ans5.Name = "ans5";
            this.ans5.Size = new System.Drawing.Size(822, 31);
            this.ans5.TabIndex = 3;
            // 
            // ans4
            // 
            this.ans4.BackColor = System.Drawing.SystemColors.Control;
            this.ans4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ans4.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ans4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ans4.Location = new System.Drawing.Point(17, 146);
            this.ans4.Name = "ans4";
            this.ans4.Size = new System.Drawing.Size(587, 31);
            this.ans4.TabIndex = 2;
            // 
            // ans3
            // 
            this.ans3.BackColor = System.Drawing.SystemColors.Control;
            this.ans3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ans3.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ans3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ans3.Location = new System.Drawing.Point(17, 95);
            this.ans3.Name = "ans3";
            this.ans3.Size = new System.Drawing.Size(587, 31);
            this.ans3.TabIndex = 1;
            // 
            // ans1
            // 
            this.ans1.BackColor = System.Drawing.SystemColors.Control;
            this.ans1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ans1.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ans1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ans1.Location = new System.Drawing.Point(17, 44);
            this.ans1.Name = "ans1";
            this.ans1.Size = new System.Drawing.Size(428, 31);
            this.ans1.TabIndex = 0;
            // 
            // baitap5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 550);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.thoat);
            this.Controls.Add(this.xoa);
            this.Controls.Add(this.ans);
            this.Controls.Add(this.B);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.A);
            this.Controls.Add(this.label1);
            this.Name = "baitap5";
            this.Text = "baitap5";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox A;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox B;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ans;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Button thoat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ans2;
        private System.Windows.Forms.TextBox ans5;
        private System.Windows.Forms.TextBox ans4;
        private System.Windows.Forms.TextBox ans3;
        private System.Windows.Forms.TextBox ans1;
    }
}