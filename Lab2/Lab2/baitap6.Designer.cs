namespace Lab2
{
    partial class baitap6
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
            this.pb_Data = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tv_Path = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Data)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pb_Data
            // 
            this.pb_Data.Location = new System.Drawing.Point(6, 21);
            this.pb_Data.Name = "pb_Data";
            this.pb_Data.Size = new System.Drawing.Size(991, 556);
            this.pb_Data.TabIndex = 1;
            this.pb_Data.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pb_Data);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.PanEast;
            this.groupBox1.Location = new System.Drawing.Point(287, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1003, 583);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File Content";
            // 
            // tv_Path
            // 
            this.tv_Path.Location = new System.Drawing.Point(12, 12);
            this.tv_Path.Name = "tv_Path";
            this.tv_Path.Size = new System.Drawing.Size(269, 583);
            this.tv_Path.TabIndex = 2;
            this.tv_Path.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.tv_Path_BeforeExpand);
            this.tv_Path.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tv_Path_AfterSelect);
            this.tv_Path.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tv_Path_NodeMouseDoubleClick);
            // 
            // baitap6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 607);
            this.Controls.Add(this.tv_Path);
            this.Controls.Add(this.groupBox1);
            this.Name = "baitap6";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.baitap6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Data)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pb_Data;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TreeView tv_Path;
    }
}