namespace GpxHeatmap
{
    partial class Form1
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
            this.gmap = new GMap.NET.WindowsForms.GMapControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.loadGPXFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.openStreetMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.czechMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openCycleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arcGisTopoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gmap
            // 
            this.gmap.AutoSize = true;
            this.gmap.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gmap.Bearing = 0F;
            this.gmap.CanDragMap = true;
            this.gmap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gmap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmap.GrayScaleMode = false;
            this.gmap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmap.LevelsKeepInMemmory = 5;
            this.gmap.Location = new System.Drawing.Point(0, 0);
            this.gmap.MarkersEnabled = true;
            this.gmap.MaxZoom = 18;
            this.gmap.MinZoom = 2;
            this.gmap.MouseWheelZoomEnabled = true;
            this.gmap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gmap.Name = "gmap";
            this.gmap.NegativeMode = false;
            this.gmap.PolygonsEnabled = true;
            this.gmap.RetryLoadTile = 0;
            this.gmap.RoutesEnabled = true;
            this.gmap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmap.ShowTileGridLines = false;
            this.gmap.Size = new System.Drawing.Size(1255, 758);
            this.gmap.TabIndex = 0;
            this.gmap.Zoom = 2D;
            this.gmap.Load += new System.EventHandler(this.gMapControl1_Load);
            this.gmap.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gmap_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadGPXFilesToolStripMenuItem,
            this.toolStripMenuItem3,
            this.toolStripSeparator2,
            this.toolStripMenuItem1,
            this.toolStripSeparator1,
            this.toolStripMenuItem2});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(233, 136);
            // 
            // loadGPXFilesToolStripMenuItem
            // 
            this.loadGPXFilesToolStripMenuItem.Image = global::GpxHeatmap.Properties.Resources.icons8_place_marker_100;
            this.loadGPXFilesToolStripMenuItem.Name = "loadGPXFilesToolStripMenuItem";
            this.loadGPXFilesToolStripMenuItem.Size = new System.Drawing.Size(232, 30);
            this.loadGPXFilesToolStripMenuItem.Text = "&Load GPX file(s) ...";
            this.loadGPXFilesToolStripMenuItem.Click += new System.EventHandler(this.loadGPXFilesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openStreetMapToolStripMenuItem,
            this.czechMapToolStripMenuItem,
            this.openCycleToolStripMenuItem,
            this.arcGisTopoToolStripMenuItem});
            this.toolStripMenuItem3.Image = global::GpxHeatmap.Properties.Resources.icons8_map_100;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(232, 30);
            this.toolStripMenuItem3.Text = "Map Base";
            // 
            // openStreetMapToolStripMenuItem
            // 
            this.openStreetMapToolStripMenuItem.CheckOnClick = true;
            this.openStreetMapToolStripMenuItem.Image = global::GpxHeatmap.Properties.Resources.Openstreetmap;
            this.openStreetMapToolStripMenuItem.Name = "openStreetMapToolStripMenuItem";
            this.openStreetMapToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.openStreetMapToolStripMenuItem.Text = "OpenStreetMap";
            this.openStreetMapToolStripMenuItem.Click += new System.EventHandler(this.openStreetMapToolStripMenuItem_Click);
            // 
            // czechMapToolStripMenuItem
            // 
            this.czechMapToolStripMenuItem.Image = global::GpxHeatmap.Properties.Resources.CzechMaps;
            this.czechMapToolStripMenuItem.Name = "czechMapToolStripMenuItem";
            this.czechMapToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.czechMapToolStripMenuItem.Text = "CzechMap";
            this.czechMapToolStripMenuItem.Click += new System.EventHandler(this.czechMapToolStripMenuItem_Click);
            // 
            // openCycleToolStripMenuItem
            // 
            this.openCycleToolStripMenuItem.Image = global::GpxHeatmap.Properties.Resources.OpenCycle;
            this.openCycleToolStripMenuItem.Name = "openCycleToolStripMenuItem";
            this.openCycleToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.openCycleToolStripMenuItem.Text = "OpenCycle";
            this.openCycleToolStripMenuItem.Click += new System.EventHandler(this.openCycleToolStripMenuItem_Click);
            // 
            // arcGisTopoToolStripMenuItem
            // 
            this.arcGisTopoToolStripMenuItem.Image = global::GpxHeatmap.Properties.Resources.ArcGIS;
            this.arcGisTopoToolStripMenuItem.Name = "arcGisTopoToolStripMenuItem";
            this.arcGisTopoToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.arcGisTopoToolStripMenuItem.Text = "ArcGisTopo";
            this.arcGisTopoToolStripMenuItem.Click += new System.EventHandler(this.arcGisTopoToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(229, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = global::GpxHeatmap.Properties.Resources.icons8_file_100;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(232, 30);
            this.toolStripMenuItem1.Text = "Lo&g window";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(229, 6);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Image = global::GpxHeatmap.Properties.Resources.icons8_exit_100;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(232, 30);
            this.toolStripMenuItem2.Text = "&Quit";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "*.GPX";
            this.openFileDialog1.Filter = "GPX Exchange Format Files (*.GPX)|*.GPX";
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.Title = "Open GPX files ";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 758);
            this.Controls.Add(this.gmap);
            this.Name = "Form1";
            this.Text = "GPX Heatmap";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gmap;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loadGPXFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem openStreetMapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem czechMapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openCycleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arcGisTopoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}

