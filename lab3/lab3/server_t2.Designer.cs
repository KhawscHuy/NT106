namespace lab3
{
    partial class server_t2
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
            this.lsv_Messages = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_Listen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsv_Messages
            // 
            this.lsv_Messages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lsv_Messages.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lsv_Messages.HideSelection = false;
            this.lsv_Messages.Location = new System.Drawing.Point(160, 117);
            this.lsv_Messages.Margin = new System.Windows.Forms.Padding(4);
            this.lsv_Messages.Name = "lsv_Messages";
            this.lsv_Messages.Size = new System.Drawing.Size(479, 253);
            this.lsv_Messages.TabIndex = 3;
            this.lsv_Messages.UseCompatibleStateImageBehavior = false;
            this.lsv_Messages.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 330;
            // 
            // btn_Listen
            // 
            this.btn_Listen.Location = new System.Drawing.Point(540, 80);
            this.btn_Listen.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Listen.Name = "btn_Listen";
            this.btn_Listen.Size = new System.Drawing.Size(100, 28);
            this.btn_Listen.TabIndex = 2;
            this.btn_Listen.Text = "Listen";
            this.btn_Listen.UseVisualStyleBackColor = true;
            this.btn_Listen.Click += new System.EventHandler(this.btn_Listen_Click);
            // 
            // server_t2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lsv_Messages);
            this.Controls.Add(this.btn_Listen);
            this.Name = "server_t2";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lsv_Messages;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btn_Listen;
    }
}