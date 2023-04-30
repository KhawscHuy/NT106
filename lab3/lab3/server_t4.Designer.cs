namespace lab3
{
    partial class server_t4
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
            this.pb_Avatar = new System.Windows.Forms.PictureBox();
            this.btn_SendImage = new System.Windows.Forms.Button();
            this.btn_Send = new System.Windows.Forms.Button();
            this.txt_Message = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Port = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Listen = new System.Windows.Forms.Button();
            this.btn_Disconnect = new System.Windows.Forms.Button();
            this.btn_ListClientsConnecting = new System.Windows.Forms.Button();
            this.lv_ListAccount = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_Client = new System.Windows.Forms.ListBox();
            this.lv_Message = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_Avatar
            // 
            this.pb_Avatar.Location = new System.Drawing.Point(495, 108);
            this.pb_Avatar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pb_Avatar.Name = "pb_Avatar";
            this.pb_Avatar.Size = new System.Drawing.Size(412, 430);
            this.pb_Avatar.TabIndex = 1;
            this.pb_Avatar.TabStop = false;
            // 
            // btn_SendImage
            // 
            this.btn_SendImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SendImage.Location = new System.Drawing.Point(727, 576);
            this.btn_SendImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_SendImage.Name = "btn_SendImage";
            this.btn_SendImage.Size = new System.Drawing.Size(180, 44);
            this.btn_SendImage.TabIndex = 15;
            this.btn_SendImage.Text = "Send image";
            this.btn_SendImage.UseVisualStyleBackColor = true;
            this.btn_SendImage.Click += new System.EventHandler(this.btn_SendImage_Click);
            // 
            // btn_Send
            // 
            this.btn_Send.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Send.Location = new System.Drawing.Point(13, 616);
            this.btn_Send.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(185, 44);
            this.btn_Send.TabIndex = 14;
            this.btn_Send.Text = "Send";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // txt_Message
            // 
            this.txt_Message.Location = new System.Drawing.Point(13, 576);
            this.txt_Message.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Message.Name = "txt_Message";
            this.txt_Message.Size = new System.Drawing.Size(688, 30);
            this.txt_Message.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Message";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(924, 708);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Chọn 1 client để nhắn tin riêng";
            // 
            // txt_Port
            // 
            this.txt_Port.Location = new System.Drawing.Point(929, 108);
            this.txt_Port.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Port.Name = "txt_Port";
            this.txt_Port.Size = new System.Drawing.Size(271, 30);
            this.txt_Port.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(924, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Port";
            // 
            // btn_Listen
            // 
            this.btn_Listen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Listen.Location = new System.Drawing.Point(929, 159);
            this.btn_Listen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Listen.Name = "btn_Listen";
            this.btn_Listen.Size = new System.Drawing.Size(225, 48);
            this.btn_Listen.TabIndex = 21;
            this.btn_Listen.Text = "Listen";
            this.btn_Listen.UseVisualStyleBackColor = true;
            this.btn_Listen.Click += new System.EventHandler(this.btn_Listen_Click);
            // 
            // btn_Disconnect
            // 
            this.btn_Disconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Disconnect.Location = new System.Drawing.Point(929, 264);
            this.btn_Disconnect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Disconnect.Name = "btn_Disconnect";
            this.btn_Disconnect.Size = new System.Drawing.Size(225, 48);
            this.btn_Disconnect.TabIndex = 22;
            this.btn_Disconnect.Text = "Disconnect";
            this.btn_Disconnect.UseVisualStyleBackColor = true;
            this.btn_Disconnect.Click += new System.EventHandler(this.btn_Disconnect_Click);
            // 
            // btn_ListClientsConnecting
            // 
            this.btn_ListClientsConnecting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ListClientsConnecting.Location = new System.Drawing.Point(929, 375);
            this.btn_ListClientsConnecting.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_ListClientsConnecting.Name = "btn_ListClientsConnecting";
            this.btn_ListClientsConnecting.Size = new System.Drawing.Size(225, 48);
            this.btn_ListClientsConnecting.TabIndex = 23;
            this.btn_ListClientsConnecting.Text = "List clients connecting";
            this.btn_ListClientsConnecting.UseVisualStyleBackColor = true;
            this.btn_ListClientsConnecting.Click += new System.EventHandler(this.btn_ListClientsConnecting_Click);
            // 
            // lv_ListAccount
            // 
            this.lv_ListAccount.HideSelection = false;
            this.lv_ListAccount.Location = new System.Drawing.Point(1208, 107);
            this.lv_ListAccount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lv_ListAccount.Name = "lv_ListAccount";
            this.lv_ListAccount.Size = new System.Drawing.Size(217, 626);
            this.lv_ListAccount.TabIndex = 24;
            this.lv_ListAccount.UseCompatibleStateImageBehavior = false;
            this.lv_ListAccount.View = System.Windows.Forms.View.List;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1203, 78);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 25);
            this.label4.TabIndex = 26;
            this.label4.Text = "List Account";
            // 
            // lb_Client
            // 
            this.lb_Client.FormattingEnabled = true;
            this.lb_Client.ItemHeight = 25;
            this.lb_Client.Location = new System.Drawing.Point(934, 459);
            this.lb_Client.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lb_Client.Name = "lb_Client";
            this.lb_Client.Size = new System.Drawing.Size(220, 229);
            this.lb_Client.TabIndex = 27;
            this.lb_Client.SelectedIndexChanged += new System.EventHandler(this.lb_Client_SelectedIndexChanged);
            // 
            // lv_Message
            // 
            this.lv_Message.HideSelection = false;
            this.lv_Message.Location = new System.Drawing.Point(18, 108);
            this.lv_Message.Name = "lv_Message";
            this.lv_Message.Size = new System.Drawing.Size(453, 430);
            this.lv_Message.TabIndex = 28;
            this.lv_Message.UseCompatibleStateImageBehavior = false;
            this.lv_Message.View = System.Windows.Forms.View.List;
            this.lv_Message.SelectedIndexChanged += new System.EventHandler(this.lv_Message_SelectedIndexChanged);
            // 
            // server_t4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1455, 755);
            this.Controls.Add(this.lv_Message);
            this.Controls.Add(this.lb_Client);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lv_ListAccount);
            this.Controls.Add(this.btn_ListClientsConnecting);
            this.Controls.Add(this.btn_Disconnect);
            this.Controls.Add(this.btn_Listen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Port);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_SendImage);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.txt_Message);
            this.Controls.Add(this.pb_Avatar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "server_t4";
            this.Text = "Form7";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.server_t4_FormClosed);
            this.Load += new System.EventHandler(this.server_t4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pb_Avatar;
        private System.Windows.Forms.Button btn_SendImage;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.TextBox txt_Message;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Port;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Listen;
        private System.Windows.Forms.Button btn_Disconnect;
        private System.Windows.Forms.Button btn_ListClientsConnecting;
        private System.Windows.Forms.ListView lv_ListAccount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lb_Client;
        private System.Windows.Forms.ListView lv_Message;
    }
}