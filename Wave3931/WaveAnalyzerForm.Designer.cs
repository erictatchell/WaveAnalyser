﻿namespace Wave3931
{
    partial class WaveAnalyzerForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WaveAnalyzerForm));
            this.BottomStatusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.TopMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDFT = new System.Windows.Forms.Button();
            this.btnRecord = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.RightChannelChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.LeftChannelChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.OptionsPanel = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnThreading = new System.Windows.Forms.Button();
            this.btnLength = new System.Windows.Forms.Button();
            this.btnSamples = new System.Windows.Forms.Button();
            this.BottomStatusStrip.SuspendLayout();
            this.TopMenuStrip.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RightChannelChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftChannelChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            this.OptionsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BottomStatusStrip
            // 
            this.BottomStatusStrip.AccessibleDescription = "Bottom window status strip";
            this.BottomStatusStrip.AccessibleName = "StatusStrip";
            this.BottomStatusStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
            this.BottomStatusStrip.AllowItemReorder = true;
            this.BottomStatusStrip.AllowMerge = false;
            this.BottomStatusStrip.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BottomStatusStrip.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BottomStatusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.BottomStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel1});
            this.BottomStatusStrip.Location = new System.Drawing.Point(0, 576);
            this.BottomStatusStrip.Name = "BottomStatusStrip";
            this.BottomStatusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 17, 0);
            this.BottomStatusStrip.Size = new System.Drawing.Size(1262, 25);
            this.BottomStatusStrip.TabIndex = 9;
            this.BottomStatusStrip.Text = "bottomStatusStrip";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 19);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripStatusLabel1.Margin = new System.Windows.Forms.Padding(5, 3, 0, 2);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(96, 20);
            this.toolStripStatusLabel1.Text = "Selected File:";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TopMenuStrip
            // 
            this.TopMenuStrip.AccessibleDescription = "Menu bar at the top of the wave analyzer window";
            this.TopMenuStrip.AccessibleName = "Top menu bar";
            this.TopMenuStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.TopMenuStrip.AllowMerge = false;
            this.TopMenuStrip.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TopMenuStrip.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.TopMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.TopMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.TopMenuStrip.Name = "TopMenuStrip";
            this.TopMenuStrip.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.TopMenuStrip.Size = new System.Drawing.Size(1262, 24);
            this.TopMenuStrip.TabIndex = 10;
            this.TopMenuStrip.Text = "TopMenuStrip";
            this.TopMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.TopMenuStrip_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFileMenu,
            this.openFileMenu,
            this.saveFileMenu});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(45, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newFileMenu
            // 
            this.newFileMenu.Name = "newFileMenu";
            this.newFileMenu.Size = new System.Drawing.Size(224, 26);
            this.newFileMenu.Text = "New";
            this.newFileMenu.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // openFileMenu
            // 
            this.openFileMenu.Name = "openFileMenu";
            this.openFileMenu.Size = new System.Drawing.Size(224, 26);
            this.openFileMenu.Text = "Open";
            this.openFileMenu.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // saveFileMenu
            // 
            this.saveFileMenu.Name = "saveFileMenu";
            this.saveFileMenu.Size = new System.Drawing.Size(224, 26);
            this.saveFileMenu.Text = "Save";
            this.saveFileMenu.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // btnDFT
            // 
            this.btnDFT.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDFT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDFT.FlatAppearance.BorderSize = 2;
            this.btnDFT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDFT.Location = new System.Drawing.Point(3, 116);
            this.btnDFT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDFT.Name = "btnDFT";
            this.btnDFT.Size = new System.Drawing.Size(120, 34);
            this.btnDFT.TabIndex = 4;
            this.btnDFT.Text = "DFT";
            this.btnDFT.UseVisualStyleBackColor = false;
            this.btnDFT.Click += new System.EventHandler(this.btnDFT_Click);
            // 
            // btnRecord
            // 
            this.btnRecord.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRecord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecord.FlatAppearance.BorderSize = 2;
            this.btnRecord.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRecord.Location = new System.Drawing.Point(3, 78);
            this.btnRecord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(120, 34);
            this.btnRecord.TabIndex = 5;
            this.btnRecord.Text = "Record";
            this.btnRecord.UseVisualStyleBackColor = false;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.AccessibleDescription = "Play currently open sound file";
            this.btnPlay.AccessibleName = "Play Button";
            this.btnPlay.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.FlatAppearance.BorderSize = 2;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlay.Location = new System.Drawing.Point(3, 2);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(120, 34);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStop.FlatAppearance.BorderSize = 2;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStop.Location = new System.Drawing.Point(3, 40);
            this.btnStop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(120, 34);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.AutoSize = true;
            this.panel2.BackgroundImage = global::Wave3931.Properties.Resources.StartScreen;
            this.panel2.Controls.Add(this.splitContainer2);
            this.panel2.Controls.Add(this.splitContainer1);
            this.panel2.Controls.Add(this.OptionsPanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1262, 552);
            this.panel2.TabIndex = 11;
            // 
            // splitContainer2
            // 
            this.splitContainer2.AccessibleDescription = "Split container with 2 charts.";
            this.splitContainer2.AccessibleName = "Split Container";
            this.splitContainer2.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.RightChannelChart);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.LeftChannelChart);
            this.splitContainer2.Size = new System.Drawing.Size(1136, 552);
            this.splitContainer2.SplitterDistance = 222;
            this.splitContainer2.SplitterWidth = 1;
            this.splitContainer2.TabIndex = 10;
            // 
            // RightChannelChart
            // 
            this.RightChannelChart.AccessibleDescription = "Left Channel";
            this.RightChannelChart.AccessibleName = "Left Channel";
            this.RightChannelChart.AccessibleRole = System.Windows.Forms.AccessibleRole.Chart;
            this.RightChannelChart.BackColor = System.Drawing.Color.Black;
            this.RightChannelChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.RightChannelChart.BackSecondaryColor = System.Drawing.Color.WhiteSmoke;
            this.RightChannelChart.BorderlineColor = System.Drawing.Color.Black;
            this.RightChannelChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.RightChannelChart.BorderlineWidth = 3;
            this.RightChannelChart.BorderSkin.BackColor = System.Drawing.Color.Black;
            this.RightChannelChart.BorderSkin.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            this.RightChannelChart.BorderSkin.PageColor = System.Drawing.Color.Black;
            this.RightChannelChart.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Sunken;
            chartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisX.InterlacedColor = System.Drawing.Color.White;
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.BackColor = System.Drawing.Color.Black;
            chartArea1.BackImage = "C:\\Users\\brend\\OneDrive - BCIT\\Pictures\\Saved Pictures\\vaporWaveBG.jpg";
            chartArea1.CursorX.LineColor = System.Drawing.Color.Black;
            chartArea1.CursorX.SelectionColor = System.Drawing.Color.LightGreen;
            chartArea1.CursorY.LineColor = System.Drawing.Color.Black;
            chartArea1.IsSameFontSizeForAllAxes = true;
            chartArea1.Name = "LeftChannelChartArea";
            this.RightChannelChart.ChartAreas.Add(chartArea1);
            this.RightChannelChart.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.RightChannelChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left;
            legend1.Enabled = false;
            legend1.Font = new System.Drawing.Font("Constantia", 8F);
            legend1.ForeColor = System.Drawing.Color.WhiteSmoke;
            legend1.HeaderSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.Line;
            legend1.IsEquallySpacedItems = true;
            legend1.IsTextAutoFit = false;
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend1.MaximumAutoSize = 20F;
            legend1.Name = "Legend1";
            legend1.Title = "L";
            this.RightChannelChart.Legends.Add(legend1);
            this.RightChannelChart.Location = new System.Drawing.Point(0, 0);
            this.RightChannelChart.Margin = new System.Windows.Forms.Padding(4);
            this.RightChannelChart.Name = "RightChannelChart";
            series1.BackImage = "C:\\Users\\brend\\OneDrive - BCIT\\Pictures\\Saved Pictures\\vaporWaveBG.jpg";
            series1.ChartArea = "LeftChannelChartArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.WhiteSmoke;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.RightChannelChart.Series.Add(series1);
            this.RightChannelChart.Size = new System.Drawing.Size(1136, 222);
            this.RightChannelChart.TabIndex = 1;
            this.RightChannelChart.Text = "Left Channel";
            this.RightChannelChart.Click += new System.EventHandler(this.chart2_Click);
            // 
            // LeftChannelChart
            // 
            this.LeftChannelChart.AccessibleDescription = "Right Channel";
            this.LeftChannelChart.AccessibleName = "Right Channel";
            this.LeftChannelChart.AccessibleRole = System.Windows.Forms.AccessibleRole.Chart;
            this.LeftChannelChart.BackColor = System.Drawing.Color.Black;
            this.LeftChannelChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LeftChannelChart.BackSecondaryColor = System.Drawing.Color.Red;
            this.LeftChannelChart.BorderlineColor = System.Drawing.Color.Black;
            this.LeftChannelChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.LeftChannelChart.BorderlineWidth = 3;
            this.LeftChannelChart.BorderSkin.BackColor = System.Drawing.Color.Black;
            this.LeftChannelChart.BorderSkin.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            this.LeftChannelChart.BorderSkin.PageColor = System.Drawing.Color.Black;
            this.LeftChannelChart.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Sunken;
            chartArea2.AxisX.IsLabelAutoFit = false;
            chartArea2.AxisX.LabelStyle.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            chartArea2.AxisY.IsLabelAutoFit = false;
            chartArea2.AxisY.LabelStyle.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            chartArea2.BackColor = System.Drawing.Color.Black;
            chartArea2.BackImage = "C:\\Users\\brend\\OneDrive - BCIT\\Pictures\\Saved Pictures\\vaporWaveBG.jpg";
            chartArea2.IsSameFontSizeForAllAxes = true;
            chartArea2.Name = "ChartArea1";
            this.LeftChannelChart.ChartAreas.Add(chartArea2);
            this.LeftChannelChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeftChannelChart.Location = new System.Drawing.Point(0, 0);
            this.LeftChannelChart.Margin = new System.Windows.Forms.Padding(4);
            this.LeftChannelChart.Name = "LeftChannelChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Name = "Series1";
            this.LeftChannelChart.Series.Add(series2);
            this.LeftChannelChart.Size = new System.Drawing.Size(1136, 329);
            this.LeftChannelChart.TabIndex = 0;
            this.LeftChannelChart.Text = "Right Channel";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(-28, -83);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Size = new System.Drawing.Size(150, 100);
            this.splitContainer1.TabIndex = 9;
            // 
            // OptionsPanel
            // 
            this.OptionsPanel.AccessibleDescription = "Right options panel ";
            this.OptionsPanel.AccessibleName = "Options Panel";
            this.OptionsPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonMenu;
            this.OptionsPanel.BackColor = System.Drawing.Color.Black;
            this.OptionsPanel.Controls.Add(this.btnClear);
            this.OptionsPanel.Controls.Add(this.btnFilter);
            this.OptionsPanel.Controls.Add(this.btnThreading);
            this.OptionsPanel.Controls.Add(this.btnLength);
            this.OptionsPanel.Controls.Add(this.btnSamples);
            this.OptionsPanel.Controls.Add(this.btnDFT);
            this.OptionsPanel.Controls.Add(this.btnRecord);
            this.OptionsPanel.Controls.Add(this.btnPlay);
            this.OptionsPanel.Controls.Add(this.btnStop);
            this.OptionsPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.OptionsPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.OptionsPanel.Location = new System.Drawing.Point(1136, 0);
            this.OptionsPanel.Margin = new System.Windows.Forms.Padding(4);
            this.OptionsPanel.Name = "OptionsPanel";
            this.OptionsPanel.Size = new System.Drawing.Size(126, 552);
            this.OptionsPanel.TabIndex = 8;
            this.OptionsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.OptionsPanel_Paint);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderSize = 2;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Location = new System.Drawing.Point(3, 501);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 34);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilter.FlatAppearance.BorderSize = 2;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFilter.Location = new System.Drawing.Point(3, 405);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(120, 38);
            this.btnFilter.TabIndex = 9;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnThreading
            // 
            this.btnThreading.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnThreading.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThreading.FlatAppearance.BorderSize = 2;
            this.btnThreading.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThreading.Location = new System.Drawing.Point(3, 367);
            this.btnThreading.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThreading.Name = "btnThreading";
            this.btnThreading.Size = new System.Drawing.Size(120, 34);
            this.btnThreading.TabIndex = 8;
            this.btnThreading.Text = "Threading";
            this.btnThreading.UseVisualStyleBackColor = false;
            this.btnThreading.Click += new System.EventHandler(this.btnThreading_Click);
            // 
            // btnLength
            // 
            this.btnLength.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLength.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLength.FlatAppearance.BorderSize = 2;
            this.btnLength.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLength.Location = new System.Drawing.Point(3, 252);
            this.btnLength.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLength.Name = "btnLength";
            this.btnLength.Size = new System.Drawing.Size(120, 34);
            this.btnLength.TabIndex = 7;
            this.btnLength.Text = "Length";
            this.btnLength.UseVisualStyleBackColor = false;
            this.btnLength.Click += new System.EventHandler(this.btnLength_Click);
            // 
            // btnSamples
            // 
            this.btnSamples.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSamples.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSamples.FlatAppearance.BorderSize = 2;
            this.btnSamples.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSamples.Location = new System.Drawing.Point(3, 214);
            this.btnSamples.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSamples.Name = "btnSamples";
            this.btnSamples.Size = new System.Drawing.Size(120, 34);
            this.btnSamples.TabIndex = 6;
            this.btnSamples.Text = "Samples";
            this.btnSamples.UseVisualStyleBackColor = false;
            this.btnSamples.Click += new System.EventHandler(this.btnSamples_Click);
            // 
            // WaveAnalyzerForm
            // 
            this.AccessibleDescription = "Charts to analyze sound waves";
            this.AccessibleName = "Wave Analyzer";
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Application;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1262, 601);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BottomStatusStrip);
            this.Controls.Add(this.TopMenuStrip);
            this.Font = new System.Drawing.Font("Constantia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WaveAnalyzerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wave Analyzer";
            this.BottomStatusStrip.ResumeLayout(false);
            this.BottomStatusStrip.PerformLayout();
            this.TopMenuStrip.ResumeLayout(false);
            this.TopMenuStrip.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RightChannelChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftChannelChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.OptionsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip BottomStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.MenuStrip TopMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Button btnDFT;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel OptionsPanel;
        private System.Windows.Forms.ToolStripMenuItem newFileMenu;
        private System.Windows.Forms.ToolStripMenuItem openFileMenu;
        private System.Windows.Forms.ToolStripMenuItem saveFileMenu;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button btnLength;
        private System.Windows.Forms.Button btnSamples;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnThreading;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart LeftChannelChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart RightChannelChart;
    }
}