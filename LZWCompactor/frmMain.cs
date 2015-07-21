using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Collections;

namespace LZWCompactor
{
    public partial class frmMain : Form
    {
        private ListViewColumnSorter m_list_view_column_sorter;

        ListViewItem m_encoder_list_view_item;

        ArrayList m_extract_items;

        FolderBrowserDialog m_folder_browser_dialog;

        ArrayList m_compact_file_names;

        ArrayList m_compact_file_orgsizes;

        ArrayList m_compact_file_sizes;

        ArrayList m_compact_file_contents;

        String m_compaction_name;

        byte[] m_compact_file_chars;

        String m_word = "";

        Hashtable m_encoder_dictionary;

        Hashtable m_decoder_dictionary_indexes;

        ArrayList m_decoder_dictionary_values;

        String m_word_char = null;

        ArrayList m_encoded_dictionary_indexes;

        ushort m_encoded_dictionary_index = 0;

        NewDlg m_new_compaction_dialog;

        String m_file_name;

        float m_compaction_ratio;

        float m_compaction_percentage;

        public delegate void UpdateEncoderListDelegate(ListViewItem elvi);

        public UpdateEncoderListDelegate m_updateEncoderListDelegate;

        private void UpdateEncoderList(ListViewItem elvi)
        {
            if (this.lvEncoder.InvokeRequired)
            {
                m_updateEncoderListDelegate = new UpdateEncoderListDelegate(UpdateEncoderList);

                this.lvEncoder.Invoke(m_updateEncoderListDelegate, elvi);
            }
            else
            {
                this.lvEncoder.Items.Add(elvi);
            }
        }

        public delegate void UpdateDecoderListDelegate(ListViewItem dlvi);

        public UpdateDecoderListDelegate m_updateDecoderListDelegate;

        private void UpdateDecoderList(ListViewItem dlvi)
        {
            if (this.lvDecoder.InvokeRequired)
            {
                m_updateDecoderListDelegate = new UpdateDecoderListDelegate(UpdateDecoderList);

                this.lvDecoder.Invoke(m_updateDecoderListDelegate, dlvi);
            }
            else
            {
                this.lvDecoder.Items.Add(dlvi);
            }
        }

        public delegate void UpdateProgressBarDelegate(int progress);

        public UpdateProgressBarDelegate m_updateProgressBarDelegate;

        private void UpdateProgressBar(int progress)
        {
            if (this.ssMain.InvokeRequired)
            {
                m_updateProgressBarDelegate = new UpdateProgressBarDelegate(UpdateProgressBar);

                this.ssMain.Invoke(m_updateProgressBarDelegate, progress);
            }
            else
            {
                if (this.ProgressBar.Value + progress <= this.ProgressBar.Maximum)
                {
                    this.ProgressBar.Value += progress;
                }
            }
        }

        public delegate void UpdateStatusBarDelegate(String status);

        public UpdateStatusBarDelegate m_updateStatusBarDelegate;

        private void UpdateStatusBar(String status)
        {
            if (this.ssMain.InvokeRequired)
            {
                m_updateStatusBarDelegate = new UpdateStatusBarDelegate(UpdateStatusBar);

                this.ssMain.Invoke(m_updateStatusBarDelegate, status);
            }
            else
            {
                this.Status.Text = status;
            }
        }

        private void AddFiles()
        {
            FileInfo fi = new FileInfo(this.m_file_name);

            this.UpdateStatusBar("Compacting file " + fi.Name);

            FileStream fStream = new FileStream(fi.FullName, FileMode.Open, FileAccess.Read);

            BinaryReader br = new BinaryReader(fStream);

            m_compact_file_chars = br.ReadBytes((int)fi.Length);

            FileStream ofStream = new FileStream(this.m_compaction_name, FileMode.Append, FileAccess.Write);

            BinaryWriter bwr = new BinaryWriter(ofStream);

            br.Close();

            fStream.Close();

            m_word = "";

            this.m_encoder_dictionary = new Hashtable();

            m_word_char = null;

            m_encoded_dictionary_indexes = new ArrayList();

            int count = 0;

            int dictionary_index = 255;

            ListViewItem elvi;

            object ret = null;

            foreach (char c in m_compact_file_chars)
            {                                                                
                bool in_dict = false;

                if (count % 1024 == 0)
                {
                    this.UpdateProgressBar(1024);
                }

                count++;

                m_word_char = m_word + c.ToString();

                elvi = new ListViewItem();

                if (count <= 150)
                {
                    elvi.SubItems[0].Text = fi.Name;

                    elvi.SubItems.Add(c.ToString());

                    elvi.SubItems.Add(m_word);

                    elvi.SubItems.Add(m_word_char);
                }

                if (this.m_encoder_dictionary.Contains(m_word_char) && m_word_char.Length > 1)
                {
                    m_word = m_word_char;

                    in_dict = true;
                }
                else
                {
                    if (m_word_char.Length > 1)
                    {                                                                     
                        this.m_encoder_dictionary.Add(m_word_char, dictionary_index - 255);
                        
                        dictionary_index++;                        
                    }

                    m_encoded_dictionary_index = 65535;
                    
                    ret = this.m_encoder_dictionary[m_word];

                    if (ret != null)
                    {
                        m_encoded_dictionary_index = (ushort)((int)ret);
                    }

                    if (m_encoded_dictionary_index == 65535)
                    {
                        if (m_word.Length > 0)
                        {
                            m_encoded_dictionary_index = (ushort)m_word[0];
                        }
                    }
                    else
                    {
                        m_encoded_dictionary_index += 256;
                    }

                    if (m_encoded_dictionary_index != 65535)
                    {
                        m_encoded_dictionary_indexes.Add(m_encoded_dictionary_index);
                    }

                    m_word = c.ToString();
                }

                if (count <= 150)
                {
                    if (!in_dict)
                    {
                        if (m_encoded_dictionary_index > 255 && m_encoded_dictionary_index != 65535)
                        {
                            elvi.SubItems.Add(m_encoded_dictionary_index.ToString());
                        }
                        else if (m_encoded_dictionary_index <= 255)
                        {
                            char ch = (char)m_encoded_dictionary_index;
                                
                            elvi.SubItems.Add(ch.ToString());
                        }
                        else
                        {
                            elvi.SubItems.Add("");
                        }
                    }
                    else
                    {
                        elvi.SubItems.Add("");
                    }

                    if (!in_dict && this.m_word_char.Length > 1)
                    {
                        elvi.SubItems.Add(this.m_word_char);

                        elvi.SubItems.Add(dictionary_index.ToString());
                    }
                    else
                    {
                        elvi.SubItems.Add("");
                    }

                    this.UpdateEncoderList(elvi);
                }

                //RESET Dictionary at 65534                        
                if (this.m_encoder_dictionary.Count == 65000)                        
                {                            
                    this.m_encoder_dictionary.Clear();
                            
                    dictionary_index = 255;

                    m_word = c.ToString();

                    m_word_char = m_word + c.ToString();                                        
                }
            }

            m_encoded_dictionary_index = 65535;

            ret = this.m_encoder_dictionary[m_word];

            if (ret != null)
            {
                m_encoded_dictionary_index = (ushort)((int)ret);
            }

            if (m_encoded_dictionary_index == 65535)
            {
                if (m_word.Length > 0)
                {
                    m_encoded_dictionary_index = (ushort)m_word[0];
                }
            }
            else
            {
                m_encoded_dictionary_index += 256;
            }

            if (m_encoded_dictionary_index != 65535)
            {
                m_encoded_dictionary_indexes.Add(m_encoded_dictionary_index);
            }

            if (count <= 150)
            {
                elvi = new ListViewItem();

                elvi.SubItems[0].Text = fi.Name;

                elvi.SubItems.Add("");

                elvi.SubItems.Add(m_word);

                elvi.SubItems.Add("");

                if (m_encoded_dictionary_index > 255)
                {
                    elvi.SubItems.Add(m_encoded_dictionary_index.ToString());
                }
                else
                {
                    if (m_encoded_dictionary_index != 65535)
                    {
                        char ch = (char)m_encoded_dictionary_index;

                        elvi.SubItems.Add(ch.ToString());
                    }
                }

                elvi.SubItems.Add("");

                this.UpdateEncoderList(elvi);
            }

            char[] filename = new char[32];

            for (int i = 0; i < fi.Name.Length; i++)
            {
                filename[i] = fi.Name[i];
            }

            bwr.Write(filename);

            this.m_compact_file_names.Add(filename);

            bwr.Write(m_compact_file_chars.Length);

            bwr.Write(m_encoded_dictionary_indexes.Count * 2);

            this.m_compact_file_orgsizes.Add(m_compact_file_chars.Length);

            this.m_compact_file_sizes.Add(m_encoded_dictionary_indexes.Count * 2);

            byte[] file_contents = new byte[m_encoded_dictionary_indexes.Count * 2];

            int b = 0;

            foreach (ushort s in m_encoded_dictionary_indexes)
            {
                bwr.Write(s);

                byte[] sbytes = BitConverter.GetBytes(s);

                file_contents[b] = sbytes[0];

                file_contents[b + 1] = sbytes[1];

                b += 2;
            }

            this.m_compact_file_contents.Add(file_contents);

            int ns = 40 + m_encoded_dictionary_indexes.Count * 2;

            m_compaction_ratio = (float)(fi.Length * 1.0) / ns;

            m_compaction_percentage = -100.0f * (ns - fi.Length) * 1.0f / fi.Length;

            bwr.Close();
        }

        private void ExtractFiles()
        {
            this.m_decoder_dictionary_values = new ArrayList();

            this.m_decoder_dictionary_indexes = new Hashtable();

            int fileindex = 0;

            FileStream ofStream = new FileStream(m_folder_browser_dialog.SelectedPath + "\\" + m_encoder_list_view_item.SubItems[0].Text, FileMode.Create, FileAccess.Write);

            BinaryWriter bwr = new BinaryWriter(ofStream);

            foreach (char[] fn in this.m_compact_file_names)
            {
                if (new string(fn).Substring(0, m_encoder_list_view_item.SubItems[0].Text.Length) == m_encoder_list_view_item.SubItems[0].Text)
                {
                    fileindex = this.m_compact_file_names.IndexOf(fn);
                }
            }

            string output = "";

            byte[] filechars = (byte[])this.m_compact_file_contents[fileindex];

            char ck = (char)filechars[0];

            bwr.Write(ck);

            output = ck.ToString();

            this.m_word = ck.ToString();

            string entry = "";

            int j = 0;

            ListViewItem dlvi = new ListViewItem();

            dlvi.SubItems[0].Text = m_encoder_list_view_item.Text;

            dlvi.SubItems.Add(ck.ToString());

            dlvi.SubItems.Add(this.m_word);

            dlvi.SubItems.Add(output);

            this.UpdateDecoderList(dlvi);

            this.UpdateStatusBar("Extracting file " + dlvi.Text);

            for (int i = 2; i < filechars.Length; i = i + 2)
            {
                if (i % 1024 == 0)
                {
                    this.UpdateProgressBar(512);
                }

                ushort low = (ushort)filechars[i];

                ushort high = (ushort)filechars[i + 1];

                high = (ushort)(high << 8);

                ushort sk = (ushort)(low | high);
                
                ck = (char)low;

                if (sk > 255 && this.m_decoder_dictionary_indexes.ContainsKey(sk.ToString()))
                {
                    entry = (string)this.m_decoder_dictionary_values[sk - 256];
                }
                else if (sk > 255 && !this.m_decoder_dictionary_indexes.ContainsKey(sk.ToString()))
                {
                    entry = this.m_word + this.m_word[0].ToString();
                }
                else
                {
                    entry = ck.ToString();
                }

                output = entry;

                if (i <= 300)
                {
                    dlvi = new ListViewItem();

                    dlvi.SubItems[0].Text = m_encoder_list_view_item.Text;

                    if (sk < 255)
                    {
                        dlvi.SubItems.Add(ck.ToString());
                    }
                    else
                    {
                        dlvi.SubItems.Add(sk.ToString());
                    }

                    dlvi.SubItems.Add(this.m_word);

                    dlvi.SubItems.Add(output);

                    if (entry.Length > 0)
                    {
                        dlvi.SubItems.Add(this.m_word + entry[0].ToString());
                    }
                    else
                    {
                        dlvi.SubItems.Add(this.m_word);
                    }
                }

                for (int c = 0; c < entry.Length; c++)
                {
                    bwr.Write(entry[c]);
                }

                j++;

                int index = j + 255;

                this.m_decoder_dictionary_values.Add(this.m_word + entry[0].ToString());

                this.m_decoder_dictionary_indexes.Add(index.ToString(), index);

                this.m_word = entry;

                if (i <= 300)
                {
                    dlvi.SubItems.Add(index.ToString());

                    this.UpdateDecoderList(dlvi);
                }

                //Reset at 65534
                if (this.m_decoder_dictionary_indexes.Count == 65000)
                {
                    this.m_decoder_dictionary_indexes.Clear();
                    this.m_decoder_dictionary_values.Clear();
                    j = 0;
                }
            }

            bwr.Close();
        }

        public frmMain()
        {
            InitializeComponent();

            m_new_compaction_dialog = new NewDlg();

            m_compact_file_names = new ArrayList();

            m_compact_file_orgsizes = new ArrayList();

            m_compact_file_sizes = new ArrayList();

            m_compact_file_contents = new ArrayList();

            m_encoder_list_view_item = new ListViewItem();

            m_extract_items = new ArrayList();

            m_folder_browser_dialog = new FolderBrowserDialog();

            m_list_view_column_sorter = new ListViewColumnSorter();

            this.lvFiles.ListViewItemSorter = m_list_view_column_sorter;

            Thread th = new Thread(new ThreadStart(DoSplash));

            th.Start();
            
            Thread.Sleep(3000);

            th.Abort();
        }

        private void DoSplash()
        {
            Splash sp = new Splash();

            sp.ShowDialog();
        }

        private void tsbOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();

            openDialog.Title = "LZW Compactor - Open Compact File";

            openDialog.Filter = "Compact Files (*.lzw)|*.lzw";

            openDialog.RestoreDirectory = true;

            openDialog.FileName = "";

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                this.m_compaction_name = openDialog.FileName;

                FileInfo fi = new FileInfo(openDialog.FileName);

                this.Text = "LZW Compactor - " + System.IO.Path.GetFileName(openDialog.FileName);

                this.tsbAdd.Enabled = true;

                this.mnuAdd.Enabled = true;

                this.cmnuAdd.Enabled = true;

                this.tsbRemove.Enabled = true;

                this.mnuRemove.Enabled = true;

                this.cmnuRemove.Enabled = true;

                this.tsbExtract.Enabled = true;

                this.mnuExtract.Enabled = true;

                this.cmnuExtract.Enabled = true;

                FileStream fStream = new FileStream(fi.FullName, FileMode.Open, FileAccess.Read);

                BinaryReader br = new BinaryReader(fStream);

                this.lvFiles.Items.Clear();

                while (br.PeekChar() != -1)
                {
                    char[] filename = new char[32];

                    filename = br.ReadChars(32);

                    m_compact_file_names.Add(filename);

                    int orgfilesize = br.ReadInt32();

                    m_compact_file_orgsizes.Add(orgfilesize);

                    int filesize = br.ReadInt32();

                    m_compact_file_sizes.Add(filesize);

                    byte[] filecontent = new byte[filesize];

                    filecontent = br.ReadBytes(filesize);

                    m_compact_file_contents.Add(filecontent);

                    ListViewItem lvi = new ListViewItem();

                    lvi.ImageIndex = 0;

                    lvi.Text = (new String(filename)).TrimEnd(new char[] { '\0' });

                    lvi.SubItems.Add(orgfilesize.ToString());

                    lvi.SubItems.Add(filesize.ToString());

                    float ratio = 1.0f * orgfilesize / filesize;

                    lvi.SubItems.Add(ratio.ToString());

                    float percentage = -100.0f * (filesize - orgfilesize) * 1.0f / orgfilesize;

                    if (percentage > 0)
                    {
                        lvi.SubItems.Add(percentage.ToString());
                    }
                    else
                    {
                        lvi.SubItems.Add("0.000000 %");
                    }

                    this.lvFiles.Items.Add(lvi);
                }

                br.Close();

                fStream.Close();
            }
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openDialog = new OpenFileDialog();

                openDialog.Title = "LZW Compactor - Add Files";

                openDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

                openDialog.RestoreDirectory = true;

                openDialog.Multiselect = true;

                openDialog.FileName = "";

                if (openDialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (String fn in openDialog.FileNames)
                    {
                        FileInfo fi = new FileInfo(fn);

                        if (fi.Name.Length <= 32)
                        {

                            ListViewItem lvi = new ListViewItem();

                            lvi.ImageIndex = 0;

                            lvi.Text = fi.Name;

                            lvi.SubItems.Add(fi.Length.ToString());

                            Status = (ToolStripStatusLabel)this.ssMain.Items[0];

                            this.m_file_name = fn;

                            ProgressBar = (ToolStripProgressBar)this.ssMain.Items[1];

                            ProgressBar.Step = 10;

                            ProgressBar.Minimum = 0;

                            ProgressBar.Maximum = (int)fi.Length;

                            ProgressBar.Value = 0;

                            this.Cursor = Cursors.WaitCursor;

                            Thread t = new Thread(new ThreadStart(this.AddFiles));

                            t.Start();

                            while (t.IsAlive)
                            {
                                Application.DoEvents();

                                Thread.Sleep(10);
                            }

                            this.Cursor = Cursors.Default;

                            int ns = 40 + m_encoded_dictionary_indexes.Count * 2;

                            lvi.SubItems.Add(ns.ToString());

                            lvi.SubItems.Add(m_compaction_ratio.ToString());

                            if (m_compaction_percentage > 0)
                            {
                                lvi.SubItems.Add(m_compaction_percentage.ToString() + " %");
                            }
                            else
                            {
                                lvi.SubItems.Add("0.000000 %");
                            }

                            this.lvFiles.Items.Add(lvi);
                        }
                        else
                        {
                            MessageBox.Show("File name " + fi.Name + " is greater than 32 characters");
                        }

                    }

                    this.tcAlgorithm.SelectedIndex = 0;

                    this.tsbRemove.Enabled = true;

                    this.mnuRemove.Enabled = true;

                    this.cmnuRemove.Enabled = true;

                    this.tsbExtract.Enabled = true;

                    this.mnuExtract.Enabled = true;

                    this.cmnuExtract.Enabled = true;

                    this.tsbAlgorithm.Enabled = true;

                    this.mnuAlgorithm.Enabled = true;

                    this.cmnuAlgorithm.Enabled = true;

                    this.mnuClearLog.Enabled = true;

                    this.cmnuClearLog.Enabled = true;

                    this.Status.Text = "Ready ...";

                    this.ProgressBar.Value = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "LZW Compactor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            AboutDlg about = new AboutDlg();

            about.ShowDialog();

            about.DialogResult = DialogResult.OK;
        }

        private void tsbAlgorithm_Click(object sender, EventArgs e)
        {
            this.bmsMain.Panel2Collapsed = !this.bmsMain.Panel2Collapsed;
        }

        private void tsbNew_Click(object sender, EventArgs e)
        {
            if (this.m_new_compaction_dialog.ShowDialog() == DialogResult.OK)
            {
                if (this.m_new_compaction_dialog.m_compaction_name != "")
                {
                    this.m_compaction_name = this.m_new_compaction_dialog.m_compaction_name;

                    FileInfo fi = new FileInfo(this.m_compaction_name);

                    if (fi.Exists)
                    {
                        if (MessageBox.Show("Compaction alread exist, overwrite ?", "LZW Compactor", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            File.Delete(this.m_new_compaction_dialog.m_compaction_name);

                            this.tsbAdd.Enabled = true;

                            this.mnuAdd.Enabled = true;

                            this.cmnuAdd.Enabled = true;

                            this.Text = "LZW Compactor - " + System.IO.Path.GetFileName(this.m_new_compaction_dialog.m_compaction_name);

                            this.lvFiles.Items.Clear();

                            this.lvDecoder.Items.Clear();

                            this.lvEncoder.Items.Clear();

                            this.ProgressBar.Value = 0;

                            this.tcAlgorithm.SelectedIndex = 0;

                            this.bmsMain.Panel2Collapsed = true;
                        }
                    }
                    else
                    {
                        this.tsbAdd.Enabled = true;

                        this.mnuAdd.Enabled = true;

                        this.cmnuAdd.Enabled = true;

                        this.Text = "LZW Compactor - " + System.IO.Path.GetFileName(this.m_new_compaction_dialog.m_compaction_name);

                        this.lvFiles.Items.Clear();

                        this.lvDecoder.Items.Clear();

                        this.lvEncoder.Items.Clear();

                        this.ProgressBar.Value = 0;

                        this.tcAlgorithm.SelectedIndex = 0;

                        this.bmsMain.Panel2Collapsed = true;
                    }
                }
            }
        }

        private void tsbRemove_Click(object sender, EventArgs e)
        {
            if (this.lvFiles.SelectedItems.Count > 0)
            {
                File.Delete(this.m_compaction_name);

                foreach (ListViewItem lvi in this.lvFiles.SelectedItems)
                {
                    lvi.Remove();
                }

                FileStream ofStream = new FileStream(this.m_compaction_name, FileMode.Create, FileAccess.Write);

                BinaryWriter bwr = new BinaryWriter(ofStream);

                foreach (ListViewItem lvi in this.lvFiles.Items)
                {
                    int fileindex = 0;

                    foreach (char[] fn in this.m_compact_file_names)
                    {
                        if (new string(fn).Substring(0, lvi.SubItems[0].Text.Length) == lvi.SubItems[0].Text)
                        {
                            fileindex = this.m_compact_file_names.IndexOf(fn);
                        }
                    }

                    char[] filename = (char[])this.m_compact_file_names[fileindex];

                    int filesize = (int)this.m_compact_file_sizes[fileindex];

                    int orgfilesize = (int)this.m_compact_file_orgsizes[fileindex];

                    byte[] filechars = (byte[])this.m_compact_file_contents[fileindex];

                    bwr.Write(filename);

                    bwr.Write(orgfilesize);

                    bwr.Write(filesize);

                    bwr.Write(filechars);
                }


                if (this.lvFiles.Items.Count == 0)
                {
                    this.tsbRemove.Enabled = false;

                    this.mnuRemove.Enabled = false;

                    this.cmnuRemove.Enabled = false;

                    this.tsbExtract.Enabled = false;

                    this.mnuExtract.Enabled = false;

                    this.cmnuExtract.Enabled = false;

                    this.mnuAlgorithm.Enabled = false;

                    this.cmnuAlgorithm.Enabled = false;

                    this.tsbAlgorithm.Enabled = false;

                    this.mnuClearLog.Enabled = false;

                    this.cmnuClearLog.Enabled = false;

                    this.lvEncoder.Items.Clear();

                    this.lvDecoder.Items.Clear();

                    this.bmsMain.Panel2Collapsed = true;
                }

                bwr.Close();
            }
            else
            {
                MessageBox.Show("No files selected to delete from compaction", "LZW Compactor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tsbExtract_Click(object sender, EventArgs e)
        {
            m_extract_items.Clear();

            if (m_folder_browser_dialog.ShowDialog() == DialogResult.OK)
            {
                if (this.lvFiles.SelectedItems.Count > 0)
                {
                    foreach (ListViewItem lvi in this.lvFiles.SelectedItems)
                    {
                        m_extract_items.Add(lvi);
                    }
                }
                else
                {
                    foreach (ListViewItem lvi in this.lvFiles.Items)
                    {
                        m_extract_items.Add(lvi);
                    }
                }

                foreach (ListViewItem lvi in m_extract_items)
                {
                    this.m_encoder_list_view_item = lvi;

                    Status = (ToolStripStatusLabel)this.ssMain.Items[0];

                    ProgressBar = (ToolStripProgressBar)this.ssMain.Items[1];

                    int fileindex = 0;

                    foreach (char[] fn in this.m_compact_file_names)
                    {
                        if (new string(fn).Substring(0, m_encoder_list_view_item.SubItems[0].Text.Length) == m_encoder_list_view_item.SubItems[0].Text)
                        {
                            fileindex = this.m_compact_file_names.IndexOf(fn);
                        }
                    }

                    ProgressBar.Step = 10;

                    ProgressBar.Minimum = 0;

                    ProgressBar.Maximum = ((int)this.m_compact_file_sizes[fileindex]) / 2;

                    ProgressBar.Value = 0;

                    this.Cursor = Cursors.WaitCursor;

                    Thread t = new Thread(new ThreadStart(this.ExtractFiles));

                    t.Start();

                    while (t.IsAlive)
                    {
                        Application.DoEvents();

                        Thread.Sleep(10);
                    }

                    this.tcAlgorithm.SelectedIndex = 1;

                    this.Status.Text = "Ready ...";

                    this.ProgressBar.Value = 0;

                    this.mnuClearLog.Enabled = true;

                    this.cmnuClearLog.Enabled = true;

                    this.mnuAlgorithm.Enabled = true;

                    this.cmnuAlgorithm.Enabled = true;

                    this.tsbAlgorithm.Enabled = true;

                    this.Cursor = Cursors.Default;
                }
            }
        }

        private void lvFiles_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == m_list_view_column_sorter.SortColumn)
            {
                if (m_list_view_column_sorter.Order == SortOrder.Ascending)
                {
                    m_list_view_column_sorter.Order = SortOrder.Descending;
                }
                else
                {
                    m_list_view_column_sorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                m_list_view_column_sorter.SortColumn = e.Column;

                m_list_view_column_sorter.Order = SortOrder.Ascending;
            }

            this.lvFiles.Sort();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.bmsMain.Panel2Collapsed = true;
        }

        private void cmnuClearLog_Click(object sender, EventArgs e)
        {
            this.lvEncoder.Items.Clear();

            this.lvDecoder.Items.Clear();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbHelp_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("LZW_Project.html");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}