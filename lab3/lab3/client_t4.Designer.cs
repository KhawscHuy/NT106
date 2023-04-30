namespace lab3
{
    partial class client_t4
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
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Port = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_IP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.txt_Name1 = new System.Windows.Forms.TextBox();
            this.txt_Message = new System.Windows.Forms.TextBox();
            this.btn_Send = new System.Windows.Forms.Button();
            this.btn_SendImage = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pb_Avatar = new System.Windows.Forms.PictureBox();
            this.lv_ShowConversation = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(711, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên người chat";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(812, 12);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(170, 22);
            this.txt_Name.TabIndex = 2;
            // 
            // txt_Port
            // 
            this.txt_Port.Location = new System.Drawing.Point(799, 65);
            this.txt_Port.Name = "txt_Port";
            this.txt_Port.Size = new System.Drawing.Size(183, 22);
            this.txt_Port.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(711, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port";
            // 
            // txt_IP
            // 
            this.txt_IP.Location = new System.Drawing.Point(799, 120);
            this.txt_IP.Name = "txt_IP";
            this.txt_IP.Size = new System.Drawing.Size(183, 22);
            this.txt_IP.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(711, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Server IP";
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(799, 148);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(84, 59);
            this.btn_OK.TabIndex = 7;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(890, 148);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(84, 59);
            this.btn_Cancel.TabIndex = 8;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // txt_Name1
            // 
            this.txt_Name1.Location = new System.Drawing.Point(714, 405);
            this.txt_Name1.Name = "txt_Name1";
            this.txt_Name1.Size = new System.Drawing.Size(268, 22);
            this.txt_Name1.TabIndex = 9;
            // 
            // txt_Message
            // 
            this.txt_Message.Location = new System.Drawing.Point(12, 528);
            this.txt_Message.Name = "txt_Message";
            this.txt_Message.Size = new System.Drawing.Size(561, 22);
            this.txt_Message.TabIndex = 10;
            // 
            // btn_Send
            // 
            this.btn_Send.Location = new System.Drawing.Point(582, 525);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(126, 28);
            this.btn_Send.TabIndex = 11;
            this.btn_Send.Text = "Send";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // btn_SendImage
            // 
            this.btn_SendImage.Location = new System.Drawing.Point(714, 523);
            this.btn_SendImage.Name = "btn_SendImage";
            this.btn_SendImage.Size = new System.Drawing.Size(139, 33);
            this.btn_SendImage.TabIndex = 12;
            this.btn_SendImage.Text = "Send image";
            this.btn_SendImage.UseVisualStyleBackColor = true;
            this.btn_SendImage.Click += new System.EventHandler(this.btn_SendImage_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(711, 386);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "nhập tên người bạn muốn trò chuyện";
            // 
            // pb_Avatar
            // 
            this.pb_Avatar.Location = new System.Drawing.Point(714, 213);
            this.pb_Avatar.Name = "pb_Avatar";
            this.pb_Avatar.Size = new System.Drawing.Size(139, 153);
            this.pb_Avatar.TabIndex = 15;
            this.pb_Avatar.TabStop = false;
            // 
            // lv_ShowConversation
            // 
            this.lv_ShowConversation.HideSelection = false;
            this.lv_ShowConversation.Location = new System.Drawing.Point(-2, 15);
            this.lv_ShowConversation.Name = "lv_ShowConversation";
            this.lv_ShowConversation.Size = new System.Drawing.Size(606, 412);
            this.lv_ShowConversation.TabIndex = 16;
            this.lv_ShowConversation.UseCompatibleStateImageBehavior = false;
            this.lv_ShowConversation.View = System.Windows.Forms.View.List;
            // 
            // client_t4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 604);
            this.Controls.Add(this.lv_ShowConversation);
            this.Controls.Add(this.pb_Avatar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_SendImage);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.txt_Message);
            this.Controls.Add(this.txt_Name1);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.txt_IP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Port);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.label1);
            this.Name = "client_t4";
            this.Text = "Form5";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.client_t4_FormClosed);
            this.Load += new System.EventHandler(this.client_t4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_Port;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_IP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.TextBox txt_Name1;
        private System.Windows.Forms.TextBox txt_Message;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.Button btn_SendImage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pb_Avatar;
        private System.Windows.Forms.ListView lv_ShowConversation;
    }
}