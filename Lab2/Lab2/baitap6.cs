using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab2
{
    public partial class baitap6 : Form
    {
        public baitap6()
        {
            InitializeComponent();
        }

        private void baitap6_Load(object sender, EventArgs e)
        {
            initTree();
        }
        private void initTree()
        {
            string[] drives = Directory.GetLogicalDrives();
            TreeNode node = null;
            foreach (string drive in drives)
            {
                node = new TreeNode(drive);
                tv_Path.Nodes.Add(node);
                node.Nodes.Add("temp");
            }
        }
        private void tv_Path_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode node = e.Node;
            node.Nodes.Clear();
            //load folder
            try
            {
                foreach (string drive in Directory.GetDirectories(node.FullPath))
                {
                    TreeNode n = node.Nodes.Add(Path.GetFileName(drive));
                    n.Nodes.Add("temp");
                }
                foreach (string file in Directory.GetFiles(node.FullPath))
                {
                    TreeNode n = new TreeNode(Path.GetFileName(file)); 
                    n.Tag = Path.GetFullPath(file);
                    node.Nodes.Add(n);
                }
            }
            catch { }
        }

        private void tv_Path_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
        }

        private void tv_Path_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                pb_Data.Image = null;
                if (e.Node.Text.ToLower().EndsWith(".jpg") ||
                    e.Node.Text.ToLower().EndsWith(".gif") ||
                    e.Node.Text.ToLower().EndsWith(".png") ||
                    e.Node.Text.ToLower().EndsWith(".bmp") ||
                    e.Node.Text.ToLower().EndsWith(".jpeg")
                    )
                {
                    pb_Data.Image = Image.FromFile(e.Node.Tag?.ToString());
                }
            }
            catch (Exception ex) { }
        }
    }
}
