namespace lab3
{
    partial class server_t1
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
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Port = new System.Windows.Forms.TextBox();
            this.btn_Listen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rtb_Receive = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "port";
            // 
            // tb_Port
            // 
            this.tb_Port.Location = new System.Drawing.Point(12, 33);
            this.tb_Port.Name = "tb_Port";
            this.tb_Port.Size = new System.Drawing.Size(151, 22);
            this.tb_Port.TabIndex = 4;
            // 
            // btn_Listen
            // 
            this.btn_Listen.Location = new System.Drawing.Point(529, 33);
            this.btn_Listen.Name = "btn_Listen";
            this.btn_Listen.Size = new System.Drawing.Size(75, 23);
            this.btn_Listen.TabIndex = 6;
            this.btn_Listen.Text = "Listen";
            this.btn_Listen.UseVisualStyleBackColor = true;
            this.btn_Listen.Click += new System.EventHandler(this.btn_Listen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Receive Message";
            // 
            // rtb_Receive
            // 
            this.rtb_Receive.Location = new System.Drawing.Point(15, 112);
            this.rtb_Receive.Name = "rtb_Receive";
            this.rtb_Receive.Size = new System.Drawing.Size(589, 326);
            this.rtb_Receive.TabIndex = 9;
            this.rtb_Receive.Text = "";
            this.rtb_Receive.TextChanged += new System.EventHandler(this.rtb_Receive_TextChanged);
            // 
            // server_t1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 450);
            this.Controls.Add(this.rtb_Receive);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Listen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_Port);
            this.Name = "server_t1";
            this.Text = "server";
            this.Load += new System.EventHandler(this.server_t1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Port;
        private System.Windows.Forms.Button btn_Listen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtb_Receive;
    }
}