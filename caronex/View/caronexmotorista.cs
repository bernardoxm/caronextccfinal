using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET;
using GoogleMaps.LocationServices;
using Microsoft.JScript;
using Convert = Microsoft.JScript.Convert;

namespace caronex.View
{
    public partial class caronexmotorista : Form
    {


        public caronexmotorista()
        {
            InitializeComponent();





            motomap.MapProvider = GMapProviders.GoogleMap;
            GMapProviders.GoogleMap.ApiKey = @"AIzaSyB3ynVU6JzIg_Az9760eAa5LA1Rg5Icgiw";
            GMaps.Instance.Mode = AccessMode.ServerAndCache;
            motomap.DragButton = MouseButtons.Left;
            motomap.CacheLocation = @"cache";



            motomap.MinZoom = 8;
            motomap.MaxZoom = 30;
            motomap.Zoom = 15;

           


            motomap.SetPositionByKeywords("Belo Horizonte, centro");
            PointLatLng point3 = new PointLatLng(motomap.Position.Lat, motomap.Position.Lng);
            GMapMarker marker = new GMarkerGoogle(point3, GMarkerGoogleType.black_small);
            GMapOverlay markers = new GMapOverlay("markers");
            markers.Markers.Add(marker);
            motomap.Overlays.Add(markers);







        }
     
    
     
        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            perfil.Visible = true;
            perfil1.Visible = true;
            perfil2.Visible = true;
            perfil3.Visible = true;
            perfil4.Visible = true;
            ok.Visible = true;




        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
           Close();


        }

        private void ok_Click(object sender, EventArgs e)
        {
            perfil.Visible = false;
            perfil1.Visible = false;
            perfil2.Visible = false;
            perfil3.Visible = false;
            perfil4.Visible = false;
            ok.Visible = false;
        }
    }
}
