namespace Lab2
{
    partial class baitap1
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
            this.btn_Read = new System.Windows.Forms.Button();
            this.btn_Write = new System.Windows.Forms.Button();
            this.rtb_Read = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btn_Read
            // 
            this.btn_Read.Location = new System.Drawing.Point(48, 33);
            this.btn_Read.Name = "btn_Read";
            this.btn_Read.Size = new System.Drawing.Size(247, 144);
            this.btn_Read.TabIndex = 0;
            this.btn_Read.Text = "Đọc FILE";
            this.btn_Read.UseVisualStyleBackColor = true;
            this.btn_Read.Click += new System.EventHandler(this.btn_read_Click);
            // 
            // btn_Write
            // 
            this.btn_Write.Location = new System.Drawing.Point(48, 265);
            this.btn_Write.Name = "btn_Write";
            this.btn_Write.Size = new System.Drawing.Size(247, 144);
            this.btn_Write.TabIndex = 1;
            this.btn_Write.Text = "Ghi file";
            this.btn_Write.UseVisualStyleBackColor = true;
            this.btn_Write.Click += new System.EventHandler(this.btn_write_Click);
            // 
            // rtb_Read
            // 
            this.rtb_Read.Location = new System.Drawing.Point(339, 33);
            this.rtb_Read.Name = "rtb_Read";
            this.rtb_Read.Size = new System.Drawing.Size(449, 376);
            this.rtb_Read.TabIndex = 2;
            this.rtb_Read.Text = "";
            this.rtb_Read.TextChanged += new System.EventHandler(this.ReadfileRTB_TextChanged);
            // 
            // baitap1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtb_Read);
            this.Controls.Add(this.btn_Write);
            this.Controls.Add(this.btn_Read);
            this.Name = "baitap1";
            this.Text = "bài tập 1";
            this.Load += new System.EventHandler(this.baitap1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Read;
        private System.Windows.Forms.Button btn_Write;
        private System.Windows.Forms.RichTextBox rtb_Read;
    }
}