using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ShaleyPoshanAhar
{
    public partial class Menu : Form
    {
        private int childFormNumber = 0;

        public Menu()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            Connection.GlobalConnection = @"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\ShaleyPoshanAhar\ShaleyPoshanAhar\SchoolDB.mdf;Integrated Security=True;User Instance=True";
        }

        private void groupEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GroupMaster r = new GroupMaster();
            r.MdiParent = this;
            r.Show();


        }

        private void itemEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemMaster r = new ItemMaster();
            r.MdiParent = this;
            r.Show();
        }

        private void dailyEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DailyEntry r = new DailyEntry();
            r.MdiParent = this;
            r.Show();
        }

        private void dailyEntryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Reports.ReportDailyEntry r = new Reports.ReportDailyEntry();
            r.MdiParent = this;
            r.Show();
        }

        private void weightUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {

            UpdateWeight r = new UpdateWeight();
            r.MdiParent = this;
            r.Show();
        }

        private void toolTip_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
