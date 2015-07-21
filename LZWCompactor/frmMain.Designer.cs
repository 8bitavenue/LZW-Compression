namespace LZWCompactor
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.tsbNew = new System.Windows.Forms.ToolStripButton();
            this.tsbOpen = new System.Windows.Forms.ToolStripButton();
            this.sep1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbRemove = new System.Windows.Forms.ToolStripButton();
            this.tsbExtract = new System.Windows.Forms.ToolStripButton();
            this.sep2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAlgorithm = new System.Windows.Forms.ToolStripButton();
            this.tsbHelp = new System.Windows.Forms.ToolStripButton();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.sep = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAction = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExtract = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAlgorithm = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClearLog = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContents = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.ProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.bmsMain = new System.Windows.Forms.SplitContainer();
            this.lvFiles = new System.Windows.Forms.ListView();
            this.FileName = new System.Windows.Forms.ColumnHeader();
            this.OrgSize = new System.Windows.Forms.ColumnHeader();
            this.NewSize = new System.Windows.Forms.ColumnHeader();
            this.Ratio = new System.Windows.Forms.ColumnHeader();
            this.Percentage = new System.Windows.Forms.ColumnHeader();
            this.tcAlgorithm = new System.Windows.Forms.TabControl();
            this.encoder = new System.Windows.Forms.TabPage();
            this.lvEncoder = new System.Windows.Forms.ListView();
            this.e_filename = new System.Windows.Forms.ColumnHeader();
            this.e_symbol = new System.Windows.Forms.ColumnHeader();
            this.e_word = new System.Windows.Forms.ColumnHeader();
            this.e_word_symbol = new System.Windows.Forms.ColumnHeader();
            this.e_output = new System.Windows.Forms.ColumnHeader();
            this.e_dictionary = new System.Windows.Forms.ColumnHeader();
            this.e_index = new System.Windows.Forms.ColumnHeader();
            this.decoder = new System.Windows.Forms.TabPage();
            this.lvDecoder = new System.Windows.Forms.ListView();
            this.d_filename = new System.Windows.Forms.ColumnHeader();
            this.d_symbol = new System.Windows.Forms.ColumnHeader();
            this.d_word = new System.Windows.Forms.ColumnHeader();
            this.d_output = new System.Windows.Forms.ColumnHeader();
            this.d_dictionary = new System.Windows.Forms.ColumnHeader();
            this.d_index = new System.Windows.Forms.ColumnHeader();
            this.cmnuMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmnuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.sep3 = new System.Windows.Forms.ToolStripSeparator();
            this.cmnuAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuExtract = new System.Windows.Forms.ToolStripMenuItem();
            this.sep4 = new System.Windows.Forms.ToolStripSeparator();
            this.cmnuAlgorithm = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuClearLog = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMain.SuspendLayout();
            this.mnuMain.SuspendLayout();
            this.ssMain.SuspendLayout();
            this.bmsMain.Panel1.SuspendLayout();
            this.bmsMain.Panel2.SuspendLayout();
            this.bmsMain.SuspendLayout();
            this.tcAlgorithm.SuspendLayout();
            this.encoder.SuspendLayout();
            this.decoder.SuspendLayout();
            this.cmnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsMain
            // 
            this.tsMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsMain.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNew,
            this.tsbOpen,
            this.sep1,
            this.tsbAdd,
            this.tsbRemove,
            this.tsbExtract,
            this.sep2,
            this.tsbAlgorithm,
            this.tsbHelp});
            this.tsMain.Location = new System.Drawing.Point(0, 24);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(662, 55);
            this.tsMain.TabIndex = 0;
            this.tsMain.Text = "toolStrip1";
            // 
            // tsbNew
            // 
            this.tsbNew.Image = ((System.Drawing.Image)(resources.GetObject("tsbNew.Image")));
            this.tsbNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNew.Name = "tsbNew";
            this.tsbNew.Size = new System.Drawing.Size(81, 52);
            this.tsbNew.Text = "New";
            this.tsbNew.ToolTipText = "New Compaction";
            this.tsbNew.Click += new System.EventHandler(this.tsbNew_Click);
            // 
            // tsbOpen
            // 
            this.tsbOpen.Image = ((System.Drawing.Image)(resources.GetObject("tsbOpen.Image")));
            this.tsbOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOpen.Name = "tsbOpen";
            this.tsbOpen.Size = new System.Drawing.Size(85, 52);
            this.tsbOpen.Text = "Open";
            this.tsbOpen.ToolTipText = "Open Compaction";
            this.tsbOpen.Click += new System.EventHandler(this.tsbOpen_Click);
            // 
            // sep1
            // 
            this.sep1.Name = "sep1";
            this.sep1.Size = new System.Drawing.Size(6, 55);
            // 
            // tsbAdd
            // 
            this.tsbAdd.Enabled = false;
            this.tsbAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsbAdd.Image")));
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(78, 52);
            this.tsbAdd.Text = "Add";
            this.tsbAdd.ToolTipText = "Add Files to Compaction";
            this.tsbAdd.Click += new System.EventHandler(this.tsbAdd_Click);
            // 
            // tsbRemove
            // 
            this.tsbRemove.Enabled = false;
            this.tsbRemove.Image = ((System.Drawing.Image)(resources.GetObject("tsbRemove.Image")));
            this.tsbRemove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRemove.Name = "tsbRemove";
            this.tsbRemove.Size = new System.Drawing.Size(99, 52);
            this.tsbRemove.Text = "Remove";
            this.tsbRemove.ToolTipText = "Remove Files From Compaction";
            this.tsbRemove.Click += new System.EventHandler(this.tsbRemove_Click);
            // 
            // tsbExtract
            // 
            this.tsbExtract.Enabled = false;
            this.tsbExtract.Image = ((System.Drawing.Image)(resources.GetObject("tsbExtract.Image")));
            this.tsbExtract.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExtract.Name = "tsbExtract";
            this.tsbExtract.Size = new System.Drawing.Size(92, 52);
            this.tsbExtract.Text = "Extract";
            this.tsbExtract.ToolTipText = "Extract Compaction";
            this.tsbExtract.Click += new System.EventHandler(this.tsbExtract_Click);
            // 
            // sep2
            // 
            this.sep2.Name = "sep2";
            this.sep2.Size = new System.Drawing.Size(6, 55);
            // 
            // tsbAlgorithm
            // 
            this.tsbAlgorithm.Enabled = false;
            this.tsbAlgorithm.Image = ((System.Drawing.Image)(resources.GetObject("tsbAlgorithm.Image")));
            this.tsbAlgorithm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAlgorithm.Name = "tsbAlgorithm";
            this.tsbAlgorithm.Size = new System.Drawing.Size(102, 52);
            this.tsbAlgorithm.Text = "Algorithm";
            this.tsbAlgorithm.ToolTipText = "Show/Hide Algorithm Log";
            this.tsbAlgorithm.Click += new System.EventHandler(this.tsbAlgorithm_Click);
            // 
            // tsbHelp
            // 
            this.tsbHelp.Image = ((System.Drawing.Image)(resources.GetObject("tsbHelp.Image")));
            this.tsbHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbHelp.Name = "tsbHelp";
            this.tsbHelp.Size = new System.Drawing.Size(81, 52);
            this.tsbHelp.Text = "Help";
            this.tsbHelp.ToolTipText = "Program Help";
            this.tsbHelp.Click += new System.EventHandler(this.tsbHelp_Click);
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuAction,
            this.mnuHelp});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(662, 24);
            this.mnuMain.TabIndex = 1;
            this.mnuMain.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNew,
            this.mnuOpen,
            this.mnuAdd,
            this.sep,
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(35, 20);
            this.mnuFile.Text = "File";
            // 
            // mnuNew
            // 
            this.mnuNew.Image = ((System.Drawing.Image)(resources.GetObject("mnuNew.Image")));
            this.mnuNew.Name = "mnuNew";
            this.mnuNew.Size = new System.Drawing.Size(100, 22);
            this.mnuNew.Text = "New";
            this.mnuNew.Click += new System.EventHandler(this.tsbNew_Click);
            // 
            // mnuOpen
            // 
            this.mnuOpen.Image = ((System.Drawing.Image)(resources.GetObject("mnuOpen.Image")));
            this.mnuOpen.Name = "mnuOpen";
            this.mnuOpen.Size = new System.Drawing.Size(100, 22);
            this.mnuOpen.Text = "Open";
            this.mnuOpen.Click += new System.EventHandler(this.tsbOpen_Click);
            // 
            // mnuAdd
            // 
            this.mnuAdd.Enabled = false;
            this.mnuAdd.Image = ((System.Drawing.Image)(resources.GetObject("mnuAdd.Image")));
            this.mnuAdd.Name = "mnuAdd";
            this.mnuAdd.Size = new System.Drawing.Size(100, 22);
            this.mnuAdd.Text = "Add";
            this.mnuAdd.Click += new System.EventHandler(this.tsbAdd_Click);
            // 
            // sep
            // 
            this.sep.Name = "sep";
            this.sep.Size = new System.Drawing.Size(97, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(100, 22);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuAction
            // 
            this.mnuAction.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRemove,
            this.mnuExtract,
            this.mnuAlgorithm,
            this.mnuClearLog});
            this.mnuAction.Name = "mnuAction";
            this.mnuAction.Size = new System.Drawing.Size(49, 20);
            this.mnuAction.Text = "Action";
            // 
            // mnuRemove
            // 
            this.mnuRemove.Enabled = false;
            this.mnuRemove.Image = ((System.Drawing.Image)(resources.GetObject("mnuRemove.Image")));
            this.mnuRemove.Name = "mnuRemove";
            this.mnuRemove.Size = new System.Drawing.Size(119, 22);
            this.mnuRemove.Text = "Remove";
            this.mnuRemove.Click += new System.EventHandler(this.tsbRemove_Click);
            // 
            // mnuExtract
            // 
            this.mnuExtract.Enabled = false;
            this.mnuExtract.Image = ((System.Drawing.Image)(resources.GetObject("mnuExtract.Image")));
            this.mnuExtract.Name = "mnuExtract";
            this.mnuExtract.Size = new System.Drawing.Size(119, 22);
            this.mnuExtract.Text = "Extract";
            this.mnuExtract.Click += new System.EventHandler(this.tsbExtract_Click);
            // 
            // mnuAlgorithm
            // 
            this.mnuAlgorithm.Enabled = false;
            this.mnuAlgorithm.Image = ((System.Drawing.Image)(resources.GetObject("mnuAlgorithm.Image")));
            this.mnuAlgorithm.Name = "mnuAlgorithm";
            this.mnuAlgorithm.Size = new System.Drawing.Size(119, 22);
            this.mnuAlgorithm.Text = "Algorithm";
            this.mnuAlgorithm.Click += new System.EventHandler(this.tsbAlgorithm_Click);
            // 
            // mnuClearLog
            // 
            this.mnuClearLog.Enabled = false;
            this.mnuClearLog.Image = ((System.Drawing.Image)(resources.GetObject("mnuClearLog.Image")));
            this.mnuClearLog.Name = "mnuClearLog";
            this.mnuClearLog.Size = new System.Drawing.Size(119, 22);
            this.mnuClearLog.Text = "Clear Log";
            this.mnuClearLog.Click += new System.EventHandler(this.cmnuClearLog_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuContents,
            this.mnuAbout});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(41, 20);
            this.mnuHelp.Text = "Help";
            // 
            // mnuContents
            // 
            this.mnuContents.Image = ((System.Drawing.Image)(resources.GetObject("mnuContents.Image")));
            this.mnuContents.Name = "mnuContents";
            this.mnuContents.Size = new System.Drawing.Size(116, 22);
            this.mnuContents.Text = "Contents";
            this.mnuContents.Click += new System.EventHandler(this.tsbHelp_Click);
            // 
            // mnuAbout
            // 
            this.mnuAbout.Image = ((System.Drawing.Image)(resources.GetObject("mnuAbout.Image")));
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(116, 22);
            this.mnuAbout.Text = "About";
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // ssMain
            // 
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Status,
            this.ProgressBar});
            this.ssMain.Location = new System.Drawing.Point(0, 313);
            this.ssMain.Name = "ssMain";
            this.ssMain.Size = new System.Drawing.Size(662, 22);
            this.ssMain.TabIndex = 2;
            this.ssMain.Text = "statusStrip1";
            // 
            // Status
            // 
            this.Status.AutoSize = false;
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(240, 17);
            this.Status.Text = "Ready ...";
            this.Status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ProgressBar
            // 
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(400, 16);
            // 
            // bmsMain
            // 
            this.bmsMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bmsMain.Location = new System.Drawing.Point(0, 79);
            this.bmsMain.Name = "bmsMain";
            this.bmsMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // bmsMain.Panel1
            // 
            this.bmsMain.Panel1.Controls.Add(this.lvFiles);
            // 
            // bmsMain.Panel2
            // 
            this.bmsMain.Panel2.Controls.Add(this.tcAlgorithm);
            this.bmsMain.Size = new System.Drawing.Size(662, 234);
            this.bmsMain.SplitterDistance = 120;
            this.bmsMain.TabIndex = 3;
            // 
            // lvFiles
            // 
            this.lvFiles.AllowColumnReorder = true;
            this.lvFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FileName,
            this.OrgSize,
            this.NewSize,
            this.Ratio,
            this.Percentage});
            this.lvFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvFiles.FullRowSelect = true;
            this.lvFiles.Location = new System.Drawing.Point(0, 0);
            this.lvFiles.Name = "lvFiles";
            this.lvFiles.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lvFiles.Size = new System.Drawing.Size(662, 120);
            this.lvFiles.TabIndex = 2;
            this.lvFiles.UseCompatibleStateImageBehavior = false;
            this.lvFiles.View = System.Windows.Forms.View.Details;
            this.lvFiles.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvFiles_ColumnClick);
            // 
            // FileName
            // 
            this.FileName.Text = "File Name";
            this.FileName.Width = 200;
            // 
            // OrgSize
            // 
            this.OrgSize.Text = "Original Size (Bytes)";
            this.OrgSize.Width = 200;
            // 
            // NewSize
            // 
            this.NewSize.Text = "New Size (Bytes)";
            this.NewSize.Width = 200;
            // 
            // Ratio
            // 
            this.Ratio.Text = "Compression Ratio";
            this.Ratio.Width = 200;
            // 
            // Percentage
            // 
            this.Percentage.Text = "Compression Percentage";
            this.Percentage.Width = 200;
            // 
            // tcAlgorithm
            // 
            this.tcAlgorithm.Controls.Add(this.encoder);
            this.tcAlgorithm.Controls.Add(this.decoder);
            this.tcAlgorithm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcAlgorithm.Location = new System.Drawing.Point(0, 0);
            this.tcAlgorithm.Multiline = true;
            this.tcAlgorithm.Name = "tcAlgorithm";
            this.tcAlgorithm.SelectedIndex = 0;
            this.tcAlgorithm.Size = new System.Drawing.Size(662, 110);
            this.tcAlgorithm.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcAlgorithm.TabIndex = 3;
            // 
            // encoder
            // 
            this.encoder.Controls.Add(this.lvEncoder);
            this.encoder.Location = new System.Drawing.Point(4, 22);
            this.encoder.Name = "encoder";
            this.encoder.Padding = new System.Windows.Forms.Padding(3);
            this.encoder.Size = new System.Drawing.Size(654, 84);
            this.encoder.TabIndex = 0;
            this.encoder.Text = "Encoder";
            this.encoder.UseVisualStyleBackColor = true;
            // 
            // lvEncoder
            // 
            this.lvEncoder.AllowColumnReorder = true;
            this.lvEncoder.AutoArrange = false;
            this.lvEncoder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.e_filename,
            this.e_symbol,
            this.e_word,
            this.e_word_symbol,
            this.e_output,
            this.e_dictionary,
            this.e_index});
            this.lvEncoder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvEncoder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvEncoder.FullRowSelect = true;
            this.lvEncoder.GridLines = true;
            this.lvEncoder.Location = new System.Drawing.Point(3, 3);
            this.lvEncoder.MultiSelect = false;
            this.lvEncoder.Name = "lvEncoder";
            this.lvEncoder.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lvEncoder.ShowItemToolTips = true;
            this.lvEncoder.Size = new System.Drawing.Size(648, 78);
            this.lvEncoder.TabIndex = 2;
            this.lvEncoder.UseCompatibleStateImageBehavior = false;
            this.lvEncoder.View = System.Windows.Forms.View.Details;
            // 
            // e_filename
            // 
            this.e_filename.Text = "File Name";
            this.e_filename.Width = 200;
            // 
            // e_symbol
            // 
            this.e_symbol.Text = "Input Symbol";
            this.e_symbol.Width = 100;
            // 
            // e_word
            // 
            this.e_word.Text = "Word";
            this.e_word.Width = 100;
            // 
            // e_word_symbol
            // 
            this.e_word_symbol.Text = "Word + Symbol";
            this.e_word_symbol.Width = 100;
            // 
            // e_output
            // 
            this.e_output.Text = "Output Symbol";
            this.e_output.Width = 100;
            // 
            // e_dictionary
            // 
            this.e_dictionary.Text = "Dictionary Entry";
            this.e_dictionary.Width = 100;
            // 
            // e_index
            // 
            this.e_index.Text = "Dictionary Index";
            this.e_index.Width = 100;
            // 
            // decoder
            // 
            this.decoder.Controls.Add(this.lvDecoder);
            this.decoder.Location = new System.Drawing.Point(4, 22);
            this.decoder.Name = "decoder";
            this.decoder.Padding = new System.Windows.Forms.Padding(3);
            this.decoder.Size = new System.Drawing.Size(654, 84);
            this.decoder.TabIndex = 1;
            this.decoder.Text = "Decoder";
            this.decoder.UseVisualStyleBackColor = true;
            // 
            // lvDecoder
            // 
            this.lvDecoder.AllowColumnReorder = true;
            this.lvDecoder.AutoArrange = false;
            this.lvDecoder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.d_filename,
            this.d_symbol,
            this.d_word,
            this.d_output,
            this.d_dictionary,
            this.d_index});
            this.lvDecoder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvDecoder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvDecoder.FullRowSelect = true;
            this.lvDecoder.GridLines = true;
            this.lvDecoder.Location = new System.Drawing.Point(3, 3);
            this.lvDecoder.MultiSelect = false;
            this.lvDecoder.Name = "lvDecoder";
            this.lvDecoder.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lvDecoder.ShowItemToolTips = true;
            this.lvDecoder.Size = new System.Drawing.Size(648, 78);
            this.lvDecoder.TabIndex = 3;
            this.lvDecoder.UseCompatibleStateImageBehavior = false;
            this.lvDecoder.View = System.Windows.Forms.View.Details;
            // 
            // d_filename
            // 
            this.d_filename.Text = "File Name";
            this.d_filename.Width = 200;
            // 
            // d_symbol
            // 
            this.d_symbol.Text = "Input Symbol";
            this.d_symbol.Width = 100;
            // 
            // d_word
            // 
            this.d_word.Text = "Word";
            this.d_word.Width = 100;
            // 
            // d_output
            // 
            this.d_output.Text = "Output Symbol";
            this.d_output.Width = 100;
            // 
            // d_dictionary
            // 
            this.d_dictionary.Text = "Dictionary Entry";
            this.d_dictionary.Width = 100;
            // 
            // d_index
            // 
            this.d_index.Text = "Dictionary Index";
            this.d_index.Width = 100;
            // 
            // cmnuMain
            // 
            this.cmnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmnuNew,
            this.cmnuOpen,
            this.sep3,
            this.cmnuAdd,
            this.cmnuRemove,
            this.cmnuExtract,
            this.sep4,
            this.cmnuAlgorithm,
            this.cmnuClearLog});
            this.cmnuMain.Name = "cmnuMain";
            this.cmnuMain.Size = new System.Drawing.Size(120, 170);
            // 
            // cmnuNew
            // 
            this.cmnuNew.Image = ((System.Drawing.Image)(resources.GetObject("cmnuNew.Image")));
            this.cmnuNew.Name = "cmnuNew";
            this.cmnuNew.Size = new System.Drawing.Size(119, 22);
            this.cmnuNew.Text = "New";
            this.cmnuNew.Click += new System.EventHandler(this.tsbNew_Click);
            // 
            // cmnuOpen
            // 
            this.cmnuOpen.Image = ((System.Drawing.Image)(resources.GetObject("cmnuOpen.Image")));
            this.cmnuOpen.Name = "cmnuOpen";
            this.cmnuOpen.Size = new System.Drawing.Size(119, 22);
            this.cmnuOpen.Text = "Open";
            this.cmnuOpen.Click += new System.EventHandler(this.tsbOpen_Click);
            // 
            // sep3
            // 
            this.sep3.Name = "sep3";
            this.sep3.Size = new System.Drawing.Size(116, 6);
            // 
            // cmnuAdd
            // 
            this.cmnuAdd.Enabled = false;
            this.cmnuAdd.Image = ((System.Drawing.Image)(resources.GetObject("cmnuAdd.Image")));
            this.cmnuAdd.Name = "cmnuAdd";
            this.cmnuAdd.Size = new System.Drawing.Size(119, 22);
            this.cmnuAdd.Text = "Add";
            this.cmnuAdd.Click += new System.EventHandler(this.tsbAdd_Click);
            // 
            // cmnuRemove
            // 
            this.cmnuRemove.Enabled = false;
            this.cmnuRemove.Image = ((System.Drawing.Image)(resources.GetObject("cmnuRemove.Image")));
            this.cmnuRemove.Name = "cmnuRemove";
            this.cmnuRemove.Size = new System.Drawing.Size(119, 22);
            this.cmnuRemove.Text = "Remove";
            this.cmnuRemove.Click += new System.EventHandler(this.tsbRemove_Click);
            // 
            // cmnuExtract
            // 
            this.cmnuExtract.Enabled = false;
            this.cmnuExtract.Image = ((System.Drawing.Image)(resources.GetObject("cmnuExtract.Image")));
            this.cmnuExtract.Name = "cmnuExtract";
            this.cmnuExtract.Size = new System.Drawing.Size(119, 22);
            this.cmnuExtract.Text = "Extract";
            this.cmnuExtract.Click += new System.EventHandler(this.tsbExtract_Click);
            // 
            // sep4
            // 
            this.sep4.Name = "sep4";
            this.sep4.Size = new System.Drawing.Size(116, 6);
            // 
            // cmnuAlgorithm
            // 
            this.cmnuAlgorithm.Enabled = false;
            this.cmnuAlgorithm.Image = ((System.Drawing.Image)(resources.GetObject("cmnuAlgorithm.Image")));
            this.cmnuAlgorithm.Name = "cmnuAlgorithm";
            this.cmnuAlgorithm.Size = new System.Drawing.Size(119, 22);
            this.cmnuAlgorithm.Text = "Algorithm";
            this.cmnuAlgorithm.Click += new System.EventHandler(this.tsbAlgorithm_Click);
            // 
            // cmnuClearLog
            // 
            this.cmnuClearLog.Enabled = false;
            this.cmnuClearLog.Image = ((System.Drawing.Image)(resources.GetObject("cmnuClearLog.Image")));
            this.cmnuClearLog.Name = "cmnuClearLog";
            this.cmnuClearLog.Size = new System.Drawing.Size(119, 22);
            this.cmnuClearLog.Text = "Clear Log";
            this.cmnuClearLog.Click += new System.EventHandler(this.cmnuClearLog_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 335);
            this.ContextMenuStrip = this.cmnuMain;
            this.Controls.Add(this.bmsMain);
            this.Controls.Add(this.ssMain);
            this.Controls.Add(this.tsMain);
            this.Controls.Add(this.mnuMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuMain;
            this.MinimumSize = new System.Drawing.Size(670, 300);
            this.Name = "frmMain";
            this.Text = "LZW Compactor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            this.bmsMain.Panel1.ResumeLayout(false);
            this.bmsMain.Panel2.ResumeLayout(false);
            this.bmsMain.ResumeLayout(false);
            this.tcAlgorithm.ResumeLayout(false);
            this.encoder.ResumeLayout(false);
            this.decoder.ResumeLayout(false);
            this.cmnuMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.ToolStripButton tsbOpen;
        private System.Windows.Forms.ToolStripButton tsbExtract;
        private System.Windows.Forms.ToolStripButton tsbAlgorithm;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.ToolStripStatusLabel Status;
        private System.Windows.Forms.ToolStripProgressBar ProgressBar;
        private System.Windows.Forms.SplitContainer bmsMain;
        private System.Windows.Forms.ToolStripButton tsbNew;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripSeparator sep1;
        private System.Windows.Forms.ToolStripSeparator sep2;
        private System.Windows.Forms.ToolStripButton tsbHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuNew;
        private System.Windows.Forms.ToolStripMenuItem mnuOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuAdd;
        private System.Windows.Forms.ToolStripMenuItem mnuAction;
        private System.Windows.Forms.ToolStripMenuItem mnuExtract;
        private System.Windows.Forms.ToolStripMenuItem mnuAlgorithm;
        private System.Windows.Forms.ToolStripMenuItem mnuContents;
        private System.Windows.Forms.ListView lvFiles;
        private System.Windows.Forms.ColumnHeader FileName;
        private System.Windows.Forms.ColumnHeader OrgSize;
        private System.Windows.Forms.ColumnHeader Ratio;
        private System.Windows.Forms.ListView lvEncoder;
        private System.Windows.Forms.ColumnHeader e_symbol;
        private System.Windows.Forms.ColumnHeader e_word;
        private System.Windows.Forms.ColumnHeader e_output;
        private System.Windows.Forms.ColumnHeader e_dictionary;
        private System.Windows.Forms.ContextMenuStrip cmnuMain;
        private System.Windows.Forms.ToolStripMenuItem cmnuNew;
        private System.Windows.Forms.ToolStripMenuItem cmnuOpen;
        private System.Windows.Forms.ToolStripSeparator sep3;
        private System.Windows.Forms.ToolStripMenuItem cmnuAdd;
        private System.Windows.Forms.ToolStripMenuItem cmnuExtract;
        private System.Windows.Forms.ToolStripSeparator sep4;
        private System.Windows.Forms.ToolStripMenuItem cmnuAlgorithm;
        private System.Windows.Forms.ColumnHeader NewSize;
        private System.Windows.Forms.ToolStripButton tsbRemove;
        private System.Windows.Forms.TabControl tcAlgorithm;
        private System.Windows.Forms.TabPage encoder;
        private System.Windows.Forms.TabPage decoder;
        private System.Windows.Forms.ListView lvDecoder;
        private System.Windows.Forms.ColumnHeader d_symbol;
        private System.Windows.Forms.ColumnHeader d_word;
        private System.Windows.Forms.ColumnHeader d_output;
        private System.Windows.Forms.ColumnHeader d_dictionary;
        private System.Windows.Forms.ColumnHeader d_index;
        private System.Windows.Forms.ColumnHeader e_index;
        private System.Windows.Forms.ColumnHeader e_filename;
        private System.Windows.Forms.ColumnHeader d_filename;
        private System.Windows.Forms.ToolStripMenuItem cmnuRemove;
        private System.Windows.Forms.ColumnHeader e_word_symbol;
        private System.Windows.Forms.ToolStripMenuItem cmnuClearLog;
        private System.Windows.Forms.ToolStripMenuItem mnuClearLog;
        private System.Windows.Forms.ToolStripMenuItem mnuRemove;
        private System.Windows.Forms.ToolStripSeparator sep;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ColumnHeader Percentage;
    }
}

