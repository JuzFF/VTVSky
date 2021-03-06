﻿namespace Presentation_Layer.FormView
{
    partial class frmHangVe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHangVe));
            this.dgvHangVe = new Guna.UI2.WinForms.Guna2DataGridView();
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
            this.lbTiLe = new System.Windows.Forms.Label();
            this.lbTenHV = new System.Windows.Forms.Label();
            this.lbMaHV = new System.Windows.Forms.Label();
            this.tbTiLe = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbTenHV = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbMaHV = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangVe)).BeginInit();
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
            // dgvHangVe
            // 
            this.dgvHangVe.AllowUserToAddRows = false;
            this.dgvHangVe.AllowUserToDeleteRows = false;
            this.dgvHangVe.AllowUserToResizeColumns = false;
            this.dgvHangVe.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            this.dgvHangVe.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHangVe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHangVe.BackgroundColor = System.Drawing.Color.White;
            this.dgvHangVe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHangVe.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvHangVe.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHangVe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHangVe.ColumnHeadersHeight = 40;
            this.dgvHangVe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvHangVe.ContextMenuStrip = this.cmt;
            this.guna2Transition1.SetDecoration(this.dgvHangVe, Guna.UI2.AnimatorNS.DecorationType.None);
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHangVe.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHangVe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHangVe.EnableHeadersVisualStyles = false;
            this.dgvHangVe.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.dgvHangVe.Location = new System.Drawing.Point(0, 0);
            this.dgvHangVe.Margin = new System.Windows.Forms.Padding(0);
            this.dgvHangVe.MultiSelect = false;
            this.dgvHangVe.Name = "dgvHangVe";
            this.dgvHangVe.ReadOnly = true;
            this.dgvHangVe.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvHangVe.RowHeadersVisible = false;
            this.dgvHangVe.RowHeadersWidth = 51;
            this.dgvHangVe.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvHangVe.RowTemplate.Height = 24;
            this.dgvHangVe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHangVe.ShowCellToolTips = false;
            this.dgvHangVe.Size = new System.Drawing.Size(557, 482);
            this.dgvHangVe.TabIndex = 2;
            this.dgvHangVe.TabStop = false;
            this.dgvHangVe.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.GreenSea;
            this.dgvHangVe.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            this.dgvHangVe.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvHangVe.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvHangVe.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvHangVe.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvHangVe.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvHangVe.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.dgvHangVe.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.dgvHangVe.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvHangVe.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvHangVe.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvHangVe.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvHangVe.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvHangVe.ThemeStyle.ReadOnly = true;
            this.dgvHangVe.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            this.dgvHangVe.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvHangVe.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvHangVe.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvHangVe.ThemeStyle.RowsStyle.Height = 24;
            this.dgvHangVe.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            this.dgvHangVe.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvHangVe.DataSourceChanged += new System.EventHandler(this.dgvHangVe_DataSourceChanged);
            this.dgvHangVe.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvHangVe_CellMouseDown);
            this.dgvHangVe.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHangVe_CellMouseEnter);
            this.dgvHangVe.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHangVe_CellMouseLeave);
            this.dgvHangVe.SelectionChanged += new System.EventHandler(this.dgvHangVe_SelectionChanged);
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
            this.pnContain.Controls.Add(this.dgvHangVe);
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
            this.guna2Elipse1.TargetControl = this.dgvHangVe;
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
            this.cbSearch.TabIndex = 23;
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
            this.tbSearch.ForeColor = System.Drawing.SystemColors.ControlText;
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
            this.tbSearch.TabIndex = 22;
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
            this.btnSearch.TabIndex = 24;
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
            this.guna2Panel2.Controls.Add(this.lbTiLe);
            this.guna2Panel2.Controls.Add(this.lbTenHV);
            this.guna2Panel2.Controls.Add(this.lbMaHV);
            this.guna2Panel2.Controls.Add(this.tbTiLe);
            this.guna2Panel2.Controls.Add(this.tbTenHV);
            this.guna2Panel2.Controls.Add(this.tbMaHV);
            this.guna2Panel2.Controls.Add(this.btnAdd);
            this.guna2Panel2.Controls.Add(this.btnDelete);
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
            this.guna2Panel2.TabIndex = 26;
            // 
            // lbTiLe
            // 
            this.lbTiLe.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.lbTiLe, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lbTiLe.Location = new System.Drawing.Point(15, 150);
            this.lbTiLe.Name = "lbTiLe";
            this.lbTiLe.Size = new System.Drawing.Size(55, 28);
            this.lbTiLe.TabIndex = 25;
            this.lbTiLe.Text = "Tỉ Lệ:";
            // 
            // lbTenHV
            // 
            this.lbTenHV.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.lbTenHV, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lbTenHV.Location = new System.Drawing.Point(15, 94);
            this.lbTenHV.Name = "lbTenHV";
            this.lbTenHV.Size = new System.Drawing.Size(123, 28);
            this.lbTenHV.TabIndex = 25;
            this.lbTenHV.Text = "Tên Hạng Vé:";
            // 
            // lbMaHV
            // 
            this.lbMaHV.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.lbMaHV, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lbMaHV.Location = new System.Drawing.Point(15, 38);
            this.lbMaHV.Name = "lbMaHV";
            this.lbMaHV.Size = new System.Drawing.Size(122, 28);
            this.lbMaHV.TabIndex = 25;
            this.lbMaHV.Text = "Mã Hạng Vé:";
            // 
            // tbTiLe
            // 
            this.tbTiLe.BackColor = System.Drawing.Color.Transparent;
            this.tbTiLe.BorderRadius = 6;
            this.tbTiLe.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.tbTiLe, Guna.UI2.AnimatorNS.DecorationType.None);
            this.tbTiLe.DefaultText = "";
            this.tbTiLe.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.tbTiLe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.tbTiLe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTiLe.DisabledState.Parent = this.tbTiLe;
            this.tbTiLe.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTiLe.Enabled = false;
            this.tbTiLe.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbTiLe.FocusedState.Parent = this.tbTiLe;
            this.tbTiLe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTiLe.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbTiLe.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbTiLe.HoverState.Parent = this.tbTiLe;
            this.tbTiLe.Location = new System.Drawing.Point(159, 142);
            this.tbTiLe.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.tbTiLe.Name = "tbTiLe";
            this.tbTiLe.PasswordChar = '\0';
            this.tbTiLe.PlaceholderText = "";
            this.tbTiLe.SelectedText = "";
            this.tbTiLe.ShadowDecoration.Parent = this.tbTiLe;
            this.tbTiLe.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.tbTiLe.Size = new System.Drawing.Size(278, 36);
            this.tbTiLe.TabIndex = 22;
            // 
            // tbTenHV
            // 
            this.tbTenHV.BackColor = System.Drawing.Color.Transparent;
            this.tbTenHV.BorderRadius = 6;
            this.tbTenHV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.tbTenHV, Guna.UI2.AnimatorNS.DecorationType.None);
            this.tbTenHV.DefaultText = "";
            this.tbTenHV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.tbTenHV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.tbTenHV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTenHV.DisabledState.Parent = this.tbTenHV;
            this.tbTenHV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTenHV.Enabled = false;
            this.tbTenHV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbTenHV.FocusedState.Parent = this.tbTenHV;
            this.tbTenHV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenHV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbTenHV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbTenHV.HoverState.Parent = this.tbTenHV;
            this.tbTenHV.Location = new System.Drawing.Point(159, 86);
            this.tbTenHV.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.tbTenHV.Name = "tbTenHV";
            this.tbTenHV.PasswordChar = '\0';
            this.tbTenHV.PlaceholderText = "";
            this.tbTenHV.SelectedText = "";
            this.tbTenHV.ShadowDecoration.Parent = this.tbTenHV;
            this.tbTenHV.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.tbTenHV.Size = new System.Drawing.Size(278, 36);
            this.tbTenHV.TabIndex = 22;
            // 
            // tbMaHV
            // 
            this.tbMaHV.BackColor = System.Drawing.Color.Transparent;
            this.tbMaHV.BorderRadius = 6;
            this.tbMaHV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.tbMaHV, Guna.UI2.AnimatorNS.DecorationType.None);
            this.tbMaHV.DefaultText = "#####";
            this.tbMaHV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.tbMaHV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.tbMaHV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbMaHV.DisabledState.Parent = this.tbMaHV;
            this.tbMaHV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbMaHV.Enabled = false;
            this.tbMaHV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbMaHV.FocusedState.Parent = this.tbMaHV;
            this.tbMaHV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaHV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbMaHV.HoverState.Parent = this.tbMaHV;
            this.tbMaHV.Location = new System.Drawing.Point(159, 30);
            this.tbMaHV.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.tbMaHV.Name = "tbMaHV";
            this.tbMaHV.PasswordChar = '\0';
            this.tbMaHV.PlaceholderText = "";
            this.tbMaHV.SelectedText = "";
            this.tbMaHV.SelectionStart = 5;
            this.tbMaHV.ShadowDecoration.Parent = this.tbMaHV;
            this.tbMaHV.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.tbMaHV.Size = new System.Drawing.Size(278, 36);
            this.tbMaHV.TabIndex = 22;
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
            this.btnAdd.Location = new System.Drawing.Point(59, 208);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.btnAdd.Size = new System.Drawing.Size(100, 36);
            this.btnAdd.TabIndex = 24;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BorderRadius = 6;
            this.btnDelete.CheckedState.Parent = this.btnDelete;
            this.btnDelete.CustomImages.Parent = this.btnDelete;
            this.guna2Transition1.SetDecoration(this.btnDelete, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.HoverState.Parent = this.btnDelete;
            this.btnDelete.Image = global::Presentation_Layer.Properties.Resources.edit;
            this.btnDelete.Location = new System.Drawing.Point(297, 208);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ShadowDecoration.Parent = this.btnDelete;
            this.btnDelete.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.btnDelete.Size = new System.Drawing.Size(100, 36);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.btnEdit.Location = new System.Drawing.Point(178, 208);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ShadowDecoration.Parent = this.btnEdit;
            this.btnEdit.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.btnEdit.Size = new System.Drawing.Size(100, 36);
            this.btnEdit.TabIndex = 24;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // frmHangVe
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
            this.Name = "frmHangVe";
            this.Text = "frmHome";
            this.Load += new System.EventHandler(this.frmHangVe_Load);
            this.SizeChanged += new System.EventHandler(this.frmHangVe_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangVe)).EndInit();
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

        private Guna.UI2.WinForms.Guna2DataGridView dgvHangVe;
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
        private Guna.UI2.WinForms.Guna2TextBox tbMaHV;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private System.Windows.Forms.Label lbMaHV;
        private System.Windows.Forms.Label lbTenHV;
        private Guna.UI2.WinForms.Guna2TextBox tbTenHV;
        private System.Windows.Forms.Label lbTiLe;
        private Guna.UI2.WinForms.Guna2TextBox tbTiLe;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
    }
}