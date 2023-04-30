namespace lab3
{
    partial class server_t3
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
            this.btn_Listen = new System.Windows.Forms.Button();
            this.lv_ShowMessage = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btn_Listen
            // 
            this.btn_Listen.Location = new System.Drawing.Point(729, 18);
            this.btn_Listen.Name = "btn_Listen";
            this.btn_Listen.Size = new System.Drawing.Size(105, 23);
            this.btn_Listen.TabIndex = 2;
            this.btn_Listen.Text = "Listen";
            this.btn_Listen.UseVisualStyleBackColor = true;
            this.btn_Listen.Click += new System.EventHandler(this.btn_Listen_Click);
            // 
            // lv_ShowMessage
            // 
            this.lv_ShowMessage.HideSelection = false;
            this.lv_ShowMessage.Location = new System.Drawing.Point(51, 47);
            this.lv_ShowMessage.Name = "lv_ShowMessage";
            this.lv_ShowMessage.Size = new System.Drawing.Size(783, 471);
            this.lv_ShowMessage.TabIndex = 3;
            this.lv_ShowMessage.UseCompatibleStateImageBehavior = false;
            this.lv_ShowMessage.View = System.Windows.Forms.View.List;
            // 
            // server_t3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 561);
            this.Controls.Add(this.lv_ShowMessage);
            this.Controls.Add(this.btn_Listen);
            this.Name = "server_t3";
            this.Text = "Form6";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.server_t3_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Listen;
        private System.Windows.Forms.ListView lv_ShowMessage;
    }
}