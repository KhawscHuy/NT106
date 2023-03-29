namespace Lab01
{
    partial class baitap4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.num = new System.Windows.Forms.TextBox();
            this.choose = new System.Windows.Forms.ComboBox();
            this.ans = new System.Windows.Forms.TextBox();
            this.tygia = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "số tiền cần đổi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "số tiền đã đổi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 389);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tỷ giá quy đổi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(301, 43);
            this.label4.TabIndex = 3;
            this.label4.Text = "Chuyển đổi tiền tệ";
            // 
            // num
            // 
            this.num.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num.Location = new System.Drawing.Point(245, 87);
            this.num.Multiline = true;
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(245, 37);
            this.num.TabIndex = 4;
            this.num.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // choose
            // 
            this.choose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.choose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choose.FormattingEnabled = true;
            this.choose.Items.AddRange(new object[] {
            "USD",
            "EUR",
            "GBP",
            "SGD",
            "JPY"});
            this.choose.Location = new System.Drawing.Point(511, 87);
            this.choose.Name = "choose";
            this.choose.Size = new System.Drawing.Size(212, 37);
            this.choose.TabIndex = 5;
            this.choose.SelectedIndexChanged += new System.EventHandler(this.combo_SelectedIndexChanged);
            // 
            // ans
            // 
            this.ans.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ans.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ans.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ans.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ans.Location = new System.Drawing.Point(245, 273);
            this.ans.Multiline = true;
            this.ans.Name = "ans";
            this.ans.Size = new System.Drawing.Size(245, 37);
            this.ans.TabIndex = 6;
            this.ans.TextChanged += new System.EventHandler(this.ans_TextChanged);
            // 
            // tygia
            // 
            this.tygia.BackColor = System.Drawing.SystemColors.Control;
            this.tygia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tygia.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tygia.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tygia.Location = new System.Drawing.Point(245, 389);
            this.tygia.Multiline = true;
            this.tygia.Name = "tygia";
            this.tygia.Size = new System.Drawing.Size(245, 37);
            this.tygia.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(73, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(417, 56);
            this.button1.TabIndex = 8;
            this.button1.Text = "Chuyển đổi";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // baitap4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 503);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tygia);
            this.Controls.Add(this.ans);
            this.Controls.Add(this.choose);
            this.Controls.Add(this.num);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "baitap4";
            this.Text = "baitap4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox num;
        private System.Windows.Forms.ComboBox choose;
        private System.Windows.Forms.TextBox ans;
        private System.Windows.Forms.TextBox tygia;
        private System.Windows.Forms.Button button1;
    }
}