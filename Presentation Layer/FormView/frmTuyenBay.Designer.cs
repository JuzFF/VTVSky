﻿namespace Presentation_Layer.FormView
{
    partial class frmTuyenBay
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTuyenBay));
            this.dgvTuyenBays = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cmt = new Guna.UI.WinForms.GunaContextMenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnContain = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnView = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pnSearch = new System.Windows.Forms.Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.cbSearch = new Guna.UI2.WinForms.Guna2ComboBox();
            this.tbSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.pnEdit = new System.Windows.Forms.Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.cbSBDen = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbSBDen = new System.Windows.Forms.Label();
            this.cbSBDi = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbSBDi = new System.Windows.Forms.Label();
            this.lbMaTB = new System.Windows.Forms.Label();
            this.tbMaTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTuyenBays)).BeginInit();
            this.cmt.SuspendLayout();
            this.pnContain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnView.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.pnSearch.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.pnEdit.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTuyenBays
            // 
            this.dgvTuyenBays.AllowUserToAddRows = false;
            this.dgvTuyenBays.AllowUserToDeleteRows = false;
            this.dgvTuyenBays.AllowUserToResizeColumns = false;
            this.dgvTuyenBays.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            this.dgvTuyenBays.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTuyenBays.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTuyenBays.BackgroundColor = System.Drawing.Color.White;
            this.dgvTuyenBays.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTuyenBays.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTuyenBays.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTuyenBays.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTuyenBays.ColumnHeadersHeight = 40;
            this.dgvTuyenBays.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTuyenBays.ContextMenuStrip = this.cmt;
            this.guna2Transition1.SetDecoration(this.dgvTuyenBays, Guna.UI2.AnimatorNS.DecorationType.None);
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTuyenBays.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTuyenBays.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTuyenBays.EnableHeadersVisualStyles = false;
            this.dgvTuyenBays.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.dgvTuyenBays.Location = new System.Drawing.Point(0, 0);
            this.dgvTuyenBays.Margin = new System.Windows.Forms.Padding(0);
            this.dgvTuyenBays.MultiSelect = false;
            this.dgvTuyenBays.Name = "dgvTuyenBays";
            this.dgvTuyenBays.ReadOnly = true;
            this.dgvTuyenBays.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvTuyenBays.RowHeadersVisible = false;
            this.dgvTuyenBays.RowHeadersWidth = 51;
            this.dgvTuyenBays.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvTuyenBays.RowTemplate.Height = 24;
            this.dgvTuyenBays.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTuyenBays.ShowCellToolTips = false;
            this.dgvTuyenBays.Size = new System.Drawing.Size(557, 482);
            this.dgvTuyenBays.TabIndex = 2;
            this.dgvTuyenBays.TabStop = false;
            this.dgvTuyenBays.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.GreenSea;
            this.dgvTuyenBays.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            this.dgvTuyenBays.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvTuyenBays.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvTuyenBays.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvTuyenBays.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvTuyenBays.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvTuyenBays.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.dgvTuyenBays.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.dgvTuyenBays.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvTuyenBays.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTuyenBays.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTuyenBays.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTuyenBays.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvTuyenBays.ThemeStyle.ReadOnly = true;
            this.dgvTuyenBays.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            this.dgvTuyenBays.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTuyenBays.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTuyenBays.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvTuyenBays.ThemeStyle.RowsStyle.Height = 24;
            this.dgvTuyenBays.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            this.dgvTuyenBays.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvTuyenBays.DataSourceChanged += new System.EventHandler(this.dgvTuyenBays_DataSourceChanged);
            this.dgvTuyenBays.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTuyenBays_CellMouseDown);
            this.dgvTuyenBays.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTuyenBays_CellMouseEnter);
            this.dgvTuyenBays.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTuyenBays_CellMouseLeave);
            this.dgvTuyenBays.SelectionChanged += new System.EventHandler(this.dgvTuyenBays_SelectionChanged);
            // 
            // cmt
            // 
            this.guna2Transition1.SetDecoration(this.cmt, Guna.UI2.AnimatorNS.DecorationType.None);
            this.cmt.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmt.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.refreshToolStripMenuItem,
            this.toolStripMenuItem4,
            this.editToolStripMenuItem,
            this.editToolStripMenuItem1,
            this.deleteToolStripMenuItem});
            this.cmt.Name = "cmt";
            this.cmt.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.cmt.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.cmt.RenderStyle.ColorTable = null;
            this.cmt.RenderStyle.RoundedEdges = true;
            this.cmt.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.cmt.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmt.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.cmt.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.cmt.RenderStyle.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            this.cmt.Size = new System.Drawing.Size(156, 136);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(155, 24);
            this.toolStripMenuItem1.Text = "Create New";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(152, 6);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(155, 24);
            this.refreshToolStripMenuItem.Text = "Refresh";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(152, 6);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Enabled = false;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(155, 24);
            this.editToolStripMenuItem.Text = "Detail";
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(155, 24);
            this.editToolStripMenuItem1.Text = "Edit";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(155, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // pnContain
            // 
            this.pnContain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnContain.BackColor = System.Drawing.Color.Transparent;
            this.pnContain.BorderRadius = 20;
            this.pnContain.Controls.Add(this.dgvTuyenBays);
            this.guna2Transition1.SetDecoration(this.pnContain, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnContain.Location = new System.Drawing.Point(23, 38);
            this.pnContain.Name = "pnContain";
            this.pnContain.ShadowDecoration.BorderRadius = 20;
            this.pnContain.ShadowDecoration.Enabled = true;
            this.pnContain.ShadowDecoration.Parent = this.pnContain;
            this.pnContain.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 7, 7);
            this.pnContain.Size = new System.Drawing.Size(557, 482);
            this.pnContain.TabIndex = 3;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this.dgvTuyenBays;
            // 
            // guna2Transition1
            // 
            this.guna2Transition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.guna2Transition1.DefaultAnimation = animation1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 500F));
            this.tableLayoutPanel1.Controls.Add(this.pnView, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.guna2Transition1.SetDecoration(this.tableLayoutPanel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1100, 570);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // pnView
            // 
            this.pnView.Controls.Add(this.pnContain);
            this.guna2Transition1.SetDecoration(this.pnView, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnView.Location = new System.Drawing.Point(0, 0);
            this.pnView.Margin = new System.Windows.Forms.Padding(0);
            this.pnView.Name = "pnView";
            this.pnView.Size = new System.Drawing.Size(600, 570);
            this.pnView.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.pnSearch, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.pnEdit, 0, 1);
            this.guna2Transition1.SetDecoration(this.tableLayoutPanel2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(600, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 225F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(500, 570);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // pnSearch
            // 
            this.pnSearch.Controls.Add(this.guna2Panel1);
            this.guna2Transition1.SetDecoration(this.pnSearch, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnSearch.Location = new System.Drawing.Point(0, 0);
            this.pnSearch.Margin = new System.Windows.Forms.Padding(0);
            this.pnSearch.Name = "pnSearch";
            this.pnSearch.Size = new System.Drawing.Size(500, 225);
            this.pnSearch.TabIndex = 0;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 20;
            this.guna2Panel1.Controls.Add(this.cbSearch);
            this.guna2Panel1.Controls.Add(this.tbSearch);
            this.guna2Panel1.Controls.Add(this.btnSearch);
            this.guna2Transition1.SetDecoration(this.guna2Panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Panel1.FillColor = System.Drawing.Color.Linen;
            this.guna2Panel1.Location = new System.Drawing.Point(20, 38);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.BorderRadius = 20;
            this.guna2Panel1.ShadowDecoration.Enabled = true;
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 7, 7);
            this.guna2Panel1.Size = new System.Drawing.Size(457, 152);
            this.guna2Panel1.TabIndex = 25;
            // 
            // cbSearch
            // 
            this.cbSearch.BackColor = System.Drawing.Color.Transparent;
            this.cbSearch.BorderRadius = 6;
            this.guna2Transition1.SetDecoration(this.cbSearch, Guna.UI2.AnimatorNS.DecorationType.None);
            this.cbSearch.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearch.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSearch.FocusedState.Parent = this.cbSearch;
            this.cbSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbSearch.HoverState.Parent = this.cbSearch;
            this.cbSearch.ItemHeight = 30;
            this.cbSearch.ItemsAppearance.Parent = this.cbSearch;
            this.cbSearch.Location = new System.Drawing.Point(20, 86);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.ShadowDecoration.Parent = this.cbSearch;
            this.cbSearch.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.cbSearch.Size = new System.Drawing.Size(267, 36);
            this.cbSearch.TabIndex = 1;
            // 
            // tbSearch
            // 
            this.tbSearch.BackColor = System.Drawing.Color.Transparent;
            this.tbSearch.BorderRadius = 6;
            this.tbSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.tbSearch, Guna.UI2.AnimatorNS.DecorationType.None);
            this.tbSearch.DefaultText = "";
            this.tbSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearch.DisabledState.Parent = this.tbSearch;
            this.tbSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSearch.FocusedState.Parent = this.tbSearch;
            this.tbSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSearch.HoverState.Parent = this.tbSearch;
            this.tbSearch.Location = new System.Drawing.Point(20, 30);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.PasswordChar = '\0';
            this.tbSearch.PlaceholderText = "";
            this.tbSearch.SelectedText = "";
            this.tbSearch.ShadowDecoration.Parent = this.tbSearch;
            this.tbSearch.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.tbSearch.Size = new System.Drawing.Size(417, 36);
            this.tbSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BorderRadius = 6;
            this.btnSearch.CheckedState.Parent = this.btnSearch;
            this.btnSearch.CustomImages.Parent = this.btnSearch;
            this.guna2Transition1.SetDecoration(this.btnSearch, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.HoverState.Parent = this.btnSearch;
            this.btnSearch.Image = global::Presentation_Layer.Properties.Resources.search;
            this.btnSearch.Location = new System.Drawing.Point(311, 86);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.ShadowDecoration.Parent = this.btnSearch;
            this.btnSearch.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.btnSearch.Size = new System.Drawing.Size(126, 36);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pnEdit
            // 
            this.pnEdit.Controls.Add(this.guna2Panel2);
            this.guna2Transition1.SetDecoration(this.pnEdit, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnEdit.Location = new System.Drawing.Point(0, 225);
            this.pnEdit.Margin = new System.Windows.Forms.Padding(0);
            this.pnEdit.Name = "pnEdit";
            this.pnEdit.Size = new System.Drawing.Size(500, 345);
            this.pnEdit.TabIndex = 1;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.BorderRadius = 20;
            this.guna2Panel2.Controls.Add(this.cbSBDen);
            this.guna2Panel2.Controls.Add(this.lbSBDen);
            this.guna2Panel2.Controls.Add(this.cbSBDi);
            this.guna2Panel2.Controls.Add(this.lbSBDi);
            this.guna2Panel2.Controls.Add(this.lbMaTB);
            this.guna2Panel2.Controls.Add(this.tbMaTB);
            this.guna2Panel2.Controls.Add(this.btnAdd);
            this.guna2Panel2.Controls.Add(this.btnEdit);
            this.guna2Transition1.SetDecoration(this.guna2Panel2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.guna2Panel2.Location = new System.Drawing.Point(20, 14);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.BorderRadius = 20;
            this.guna2Panel2.ShadowDecoration.Enabled = true;
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 7, 7);
            this.guna2Panel2.Size = new System.Drawing.Size(457, 274);
            this.guna2Panel2.TabIndex = 0;
            // 
            // cbSBDen
            // 
            this.cbSBDen.BackColor = System.Drawing.Color.Transparent;
            this.cbSBDen.BorderRadius = 6;
            this.guna2Transition1.SetDecoration(this.cbSBDen, Guna.UI2.AnimatorNS.DecorationType.None);
            this.cbSBDen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSBDen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSBDen.Enabled = false;
            this.cbSBDen.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSBDen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSBDen.FocusedState.Parent = this.cbSBDen;
            this.cbSBDen.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbSBDen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbSBDen.HoverState.Parent = this.cbSBDen;
            this.cbSBDen.IntegralHeight = false;
            this.cbSBDen.ItemHeight = 30;
            this.cbSBDen.ItemsAppearance.Parent = this.cbSBDen;
            this.cbSBDen.Location = new System.Drawing.Point(159, 142);
            this.cbSBDen.Name = "cbSBDen";
            this.cbSBDen.ShadowDecoration.Parent = this.cbSBDen;
            this.cbSBDen.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.cbSBDen.Size = new System.Drawing.Size(278, 36);
            this.cbSBDen.TabIndex = 2;
            // 
            // lbSBDen
            // 
            this.lbSBDen.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.lbSBDen, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lbSBDen.Location = new System.Drawing.Point(15, 150);
            this.lbSBDen.Name = "lbSBDen";
            this.lbSBDen.Size = new System.Drawing.Size(124, 28);
            this.lbSBDen.TabIndex = 25;
            this.lbSBDen.Text = "Sân Bay Đến:";
            // 
            // cbSBDi
            // 
            this.cbSBDi.BackColor = System.Drawing.Color.Transparent;
            this.cbSBDi.BorderRadius = 6;
            this.guna2Transition1.SetDecoration(this.cbSBDi, Guna.UI2.AnimatorNS.DecorationType.None);
            this.cbSBDi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSBDi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSBDi.Enabled = false;
            this.cbSBDi.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSBDi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSBDi.FocusedState.Parent = this.cbSBDi;
            this.cbSBDi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSBDi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbSBDi.HoverState.Parent = this.cbSBDi;
            this.cbSBDi.IntegralHeight = false;
            this.cbSBDi.ItemHeight = 30;
            this.cbSBDi.ItemsAppearance.Parent = this.cbSBDi;
            this.cbSBDi.Location = new System.Drawing.Point(159, 86);
            this.cbSBDi.Name = "cbSBDi";
            this.cbSBDi.ShadowDecoration.Parent = this.cbSBDi;
            this.cbSBDi.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.cbSBDi.Size = new System.Drawing.Size(278, 36);
            this.cbSBDi.TabIndex = 1;
            // 
            // lbSBDi
            // 
            this.lbSBDi.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.lbSBDi, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lbSBDi.Location = new System.Drawing.Point(15, 94);
            this.lbSBDi.Name = "lbSBDi";
            this.lbSBDi.Size = new System.Drawing.Size(108, 28);
            this.lbSBDi.TabIndex = 25;
            this.lbSBDi.Text = "Sân Bay Đi:";
            // 
            // lbMaTB
            // 
            this.lbMaTB.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.lbMaTB, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lbMaTB.Location = new System.Drawing.Point(15, 38);
            this.lbMaTB.Name = "lbMaTB";
            this.lbMaTB.Size = new System.Drawing.Size(137, 28);
            this.lbMaTB.TabIndex = 25;
            this.lbMaTB.Text = "Mã Tuyến Bay:";
            // 
            // tbMaTB
            // 
            this.tbMaTB.BackColor = System.Drawing.Color.Transparent;
            this.tbMaTB.BorderRadius = 6;
            this.tbMaTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.tbMaTB, Guna.UI2.AnimatorNS.DecorationType.None);
            this.tbMaTB.DefaultText = "#####";
            this.tbMaTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.tbMaTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.tbMaTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbMaTB.DisabledState.Parent = this.tbMaTB;
            this.tbMaTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbMaTB.Enabled = false;
            this.tbMaTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbMaTB.FocusedState.Parent = this.tbMaTB;
            this.tbMaTB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaTB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbMaTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbMaTB.HoverState.Parent = this.tbMaTB;
            this.tbMaTB.Location = new System.Drawing.Point(159, 30);
            this.tbMaTB.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.tbMaTB.Name = "tbMaTB";
            this.tbMaTB.PasswordChar = '\0';
            this.tbMaTB.PlaceholderText = "";
            this.tbMaTB.SelectedText = "";
            this.tbMaTB.SelectionStart = 5;
            this.tbMaTB.ShadowDecoration.Parent = this.tbMaTB;
            this.tbMaTB.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.tbMaTB.Size = new System.Drawing.Size(278, 36);
            this.tbMaTB.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BorderRadius = 6;
            this.btnAdd.CheckedState.Parent = this.btnAdd;
            this.btnAdd.CustomImages.Parent = this.btnAdd;
            this.guna2Transition1.SetDecoration(this.btnAdd, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.HoverState.Parent = this.btnAdd;
            this.btnAdd.Image = global::Presentation_Layer.Properties.Resources.plus;
            this.btnAdd.Location = new System.Drawing.Point(76, 208);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.btnAdd.Size = new System.Drawing.Size(126, 36);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.BorderRadius = 6;
            this.btnEdit.CheckedState.Parent = this.btnEdit;
            this.btnEdit.CustomImages.Parent = this.btnEdit;
            this.guna2Transition1.SetDecoration(this.btnEdit, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.HoverState.Parent = this.btnEdit;
            this.btnEdit.Image = global::Presentation_Layer.Properties.Resources.edit;
            this.btnEdit.Location = new System.Drawing.Point(261, 208);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ShadowDecoration.Parent = this.btnEdit;
            this.btnEdit.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.btnEdit.Size = new System.Drawing.Size(126, 36);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // frmTuyenBay
            // 
            this.AcceptButton = this.btnSearch;
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1100, 570);
            this.Controls.Add(this.tableLayoutPanel1);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmTuyenBay";
            this.Text = "frmHome";
            this.Load += new System.EventHandler(this.frmTuyenBay_Load);
            this.SizeChanged += new System.EventHandler(this.frmTuyenBay_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTuyenBays)).EndInit();
            this.cmt.ResumeLayout(false);
            this.pnContain.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnView.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.pnSearch.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.pnEdit.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvTuyenBays;
        private Guna.UI2.WinForms.Guna2Panel pnContain;
        private Guna.UI.WinForms.GunaContextMenuStrip cmt;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel pnSearch;
        private System.Windows.Forms.Panel pnEdit;
        private Guna.UI2.WinForms.Guna2TextBox tbSearch;
        private Guna.UI2.WinForms.Guna2ComboBox cbSearch;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2TextBox tbMaTB;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private System.Windows.Forms.Label lbMaTB;
        private System.Windows.Forms.Label lbSBDi;
        private Guna.UI2.WinForms.Guna2ComboBox cbSBDi;
        private Guna.UI2.WinForms.Guna2ComboBox cbSBDen;
        private System.Windows.Forms.Label lbSBDen;
    }
}