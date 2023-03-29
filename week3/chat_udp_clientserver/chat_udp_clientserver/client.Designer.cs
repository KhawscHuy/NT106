namespace chat_udp_clientserver
{
    partial class client
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
            this.txt_port = new System.Windows.Forms.TextBox();
            this.port = new System.Windows.Forms.Label();
            this.btn_send = new System.Windows.Forms.Button();
            this.txt_IP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_con = new System.Windows.Forms.Button();
            this.txt_Mess = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_port
            // 
            this.txt_port.Location = new System.Drawing.Point(370, 113);
            this.txt_port.Name = "txt_port";
            this.txt_port.Size = new System.Drawing.Size(45, 22);
            this.txt_port.TabIndex = 15;
            this.txt_port.TextChanged += new System.EventHandler(this.txt_port_TextChanged);
            // 
            // port
            // 
            this.port.AutoSize = true;
            this.port.Location = new System.Drawing.Point(334, 116);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(30, 16);
            this.port.TabIndex = 14;
            this.port.Text = "port";
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(431, 65);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 23);
            this.btn_send.TabIndex = 13;
            this.btn_send.Text = "send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // txt_IP
            // 
            this.txt_IP.Location = new System.Drawing.Point(193, 112);
            this.txt_IP.Name = "txt_IP";
            this.txt_IP.Size = new System.Drawing.Size(130, 22);
            this.txt_IP.TabIndex = 12;
            this.txt_IP.TextChanged += new System.EventHandler(this.txt_IP_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "IP";
            // 
            // btn_con
            // 
            this.btn_con.Location = new System.Drawing.Point(431, 112);
            this.btn_con.Name = "btn_con";
            this.btn_con.Size = new System.Drawing.Size(75, 23);
            this.btn_con.TabIndex = 10;
            this.btn_con.Text = "connect";
            this.btn_con.UseVisualStyleBackColor = true;
            this.btn_con.Click += new System.EventHandler(this.btn_con_Click);
            // 
            // txt_Mess
            // 
            this.txt_Mess.Location = new System.Drawing.Point(144, 66);
            this.txt_Mess.Name = "txt_Mess";
            this.txt_Mess.Size = new System.Drawing.Size(271, 22);
            this.txt_Mess.TabIndex = 9;
            this.txt_Mess.TextChanged += new System.EventHandler(this.txt_Mess_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = " message";
            // 
            // client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 208);
            this.Controls.Add(this.txt_port);
            this.Controls.Add(this.port);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.txt_IP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_con);
            this.Controls.Add(this.txt_Mess);
            this.Controls.Add(this.label1);
            this.Name = "client";
            this.Text = "client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_port;
        private System.Windows.Forms.Label port;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.TextBox txt_IP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_con;
        private System.Windows.Forms.TextBox txt_Mess;
        private System.Windows.Forms.Label label1;
    }
}

