using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LZWCompactor
{
    public partial class NewDlg : Form
    {
        public String m_compaction_name
        {
            get
            {
                if (this.txtLocation.Text != "" && this.txtName.Text != "")
                {
                    return this.txtLocation.Text + "\\" + this.txtName.Text + ".lzw";
                }
                else
                {
                    return "";
                }
            }
        }

        public NewDlg()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                this.txtLocation.Text = fbd.SelectedPath;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.txtName.Text != "" && this.txtLocation.Text != "")
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Please type in compaction location and name", "LZW Compactor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void NewDlg_Load(object sender, EventArgs e)
        {
            this.txtLocation.SelectionStart = this.txtLocation.Text.Length;
            this.txtLocation.SelectionLength = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}