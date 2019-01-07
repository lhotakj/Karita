using GMap.NET;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using GMap.NET.WindowsForms;
using System.Security;

namespace GpxHeatmap
{
    public partial class Form1 : Form
    {

        GMapOverlay mainOverlay;
        String log = "";
        public ProgressForm f = null;


        public Form1()
        {
            InitializeComponent();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            f = new ProgressForm();
        }

        // http://www.independent-software.com/gmap-net-beginners-tutorial-maps-markers-polygons-routes-updated-for-vs2015-and-gmap1-7.html
        // http://presentation427.rssing.com/chan-4175058/all_p70.html


        private void LoadGpxFile(String filename)
        {

            try
            {
                string gpx = File.ReadAllText(filename);

                gpxType r = gmap.Manager.DeserializeGPX(gpx);
                if (r != null)
                {
                    if (r.trk.Length > 0)
                    {
                        foreach (var trk in r.trk)
                        {
                            List<PointLatLng> points = new List<PointLatLng>();

                            foreach (var seg in trk.trkseg)
                            {
                                foreach (var p in seg.trkpt)
                                {
                                    points.Add(new PointLatLng((double)p.lat, (double)p.lon));
                                }
                            }

                            GMapRoute rt = new GMapRoute(points, string.Empty);
                            {
                                rt.Stroke.MiterLimit = 0;
                                rt.Stroke = new Pen(Color.FromArgb(255, Color.Red));
                                rt.Stroke.Width = 3;
                                rt.Stroke.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                            }
                            mainOverlay.Routes.Add(rt);
                        }

                        // gmap.ZoomAndCenterRoutes(null);

                        // add
                        gmap.Overlays.Add(mainOverlay);
                        log += Environment.NewLine + Path.GetFileName(filename) + " loaded successfully";
                        f.logtext.Text = log;
                        f.logtext.Refresh();


                    }
                }
            }
            catch (Exception ex)
            {
                log += Environment.NewLine + Path.GetFileName(filename) + " error (" + ex.ToString() + ")";
                f.logtext.Text = log;
                f.logtext.Refresh();

                //Debug.WriteLine("GPX import: " + ex.ToString());
                //MessageBox.Show("Error importing gpx: " + ex.Message, "GMap.NET", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void LoadMap(String provider)
        {
            if (provider == "OpenStreetMap")
            {
                gmap.MapProvider = GMap.NET.MapProviders.OpenStreetMapProvider.Instance;
                openStreetMapToolStripMenuItem.Checked = true;
                czechMapToolStripMenuItem.Checked = false;
                openCycleToolStripMenuItem.Checked = false;
                arcGisTopoToolStripMenuItem.Checked = false;
            }

            if (provider == "CzechMap")
            {
                gmap.MapProvider = GMap.NET.MapProviders.CzechMapProvider.Instance;
                openStreetMapToolStripMenuItem.Checked = false;
                czechMapToolStripMenuItem.Checked = true;
                openCycleToolStripMenuItem.Checked = false;
                arcGisTopoToolStripMenuItem.Checked = false;
            }

            if (provider == "OpenCycle")
            {
                gmap.MapProvider = GMap.NET.MapProviders.OpenCycleLandscapeMapProvider.Instance;
                openStreetMapToolStripMenuItem.Checked = false;
                czechMapToolStripMenuItem.Checked = false;
                openCycleToolStripMenuItem.Checked = true;
                arcGisTopoToolStripMenuItem.Checked = false;
            }

            if (provider == "ArcGisTopo")
            {
                gmap.MapProvider = GMap.NET.MapProviders.ArcGIS_World_Topo_MapProvider.Instance;
                openStreetMapToolStripMenuItem.Checked = false;
                czechMapToolStripMenuItem.Checked = false;
                openCycleToolStripMenuItem.Checked = false;
                arcGisTopoToolStripMenuItem.Checked = true;
            }

            log += "Loaded " + gmap.MapProvider.ToString();
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {
            // hide first
            LoadMap("CzechMap");
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gmap.ShowCenter = false;
            gmap.Visible = true;
            gmap.SetPositionByKeywords("Prague, Czech Republic");
            gmap.Zoom = 8;
            mainOverlay = new GMapOverlay();

            return;



            string[] gpx_files = Directory.GetFiles(@"H:\WORKING\strava-map\data\fixed\", "*.gpx", SearchOption.TopDirectoryOnly);

            foreach (String gpx_file in gpx_files)
            {
                LoadGpxFile(gpx_file);
            }

            gmap.SetPositionByKeywords("Prague, Czech Republic");
            gmap.Zoom = 10;

            this.Show();
            this.Refresh();
            gmap.Visible = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void gmap_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(this, gmap.PointToClient(Cursor.Position));
            }
            else//left or middle click
            {
                //do something here
            }

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loadGPXFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = this.openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {

                // TODO: move to Signgleton
                if (Singleton.Instance.ExistsLogForm())
                {
                    f.Visible = true;
                }
                else
                {
                    Singleton.Instance.CreateLogForm();
                    f = new ProgressForm();
                    f.Visible = true;
                }


                gmap.Visible = false;

                // Read the files
                foreach (String file in openFileDialog1.FileNames)
                {                    
                    LoadGpxFile(file);
                }

                gmap.SetPositionByKeywords("Prague, Czech Republic");
                gmap.Zoom = 10;

                this.Show();
                this.Refresh();
                gmap.Visible = true;

            }


        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // TODO: move to Signgleton
            if (Singleton.Instance.ExistsLogForm())
            {
                f.Visible = true;
            }
            else
            {
                Singleton.Instance.CreateLogForm();
                f = new ProgressForm();
                f.logtext.Text = log;
                f.Visible = true;
            }


        }

        private void openStreetMapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadMap("OpenStreetMap");
        }

        private void czechMapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadMap("CzechMap");
        }

        private void openCycleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadMap("OpenCycle");
        }

        private void arcGisTopoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadMap("ArcGisTopo"); 
        }
    }
}
