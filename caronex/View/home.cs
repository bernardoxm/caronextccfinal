using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET;
using GoogleMaps.LocationServices;
using Microsoft.JScript;
using Convert = Microsoft.JScript.Convert;

namespace caronex
{
    public partial class Form1 : Form
    {
        

        private List<PointLatLng> _points;
      
        public Form1()
        {
            InitializeComponent();

            map.ShowCenter = false;
            local.Visible = false;
            ir.Visible = false;
            buscar.Visible = false;
            buscar1.Visible = false;
            mover.Visible = false;
            sim.Visible = false;
            conf.Visible = false;
               nao.Visible = false;
            confim.Visible = false;
            conf1.Visible = false;
            _points = new List<PointLatLng>();
            motorista.Visible = false;
            perfil1.Visible = false;
            
            perfil3.Visible = false;
            perfil4.Visible = false;
            perfil5.Visible = false;
            perfil6.Visible = false;
            
            perfil8.Visible = false;
            perfil9.Visible = false;
            perfil10.Visible = false;
            perfil11.Visible = false;
            
            perfil13.Visible = false;
            perfil14.Visible = false;
            confirmar.Visible = false;
            perfil2.Visible = false;
            valor2.Visible = false;
        }



        private void moverpainel(Control c)
        {
            mover.Height = c.Height;
            mover.Top = c.Top;

        }
        private void unaAimores_Click(object sender, EventArgs e)
        {


            map.MapProvider = GMapProviders.GoogleMap;
            GMapProviders.GoogleMap.ApiKey = @"AIzaSyB3ynVU6JzIg_Az9760eAa5LA1Rg5Icgiw";
            GMaps.Instance.Mode = AccessMode.ServerAndCache;
            map.DragButton = MouseButtons.Left;
            map.CacheLocation = @"cache";


           
            map.MinZoom = 8;
            map.MaxZoom = 30;
            map.Zoom = 17.6;
            double lat = (-19.9284485);

            double lng = (-43.937837);


            map.Position = new PointLatLng(lat, lng);
            PointLatLng point = new PointLatLng(lat, lng);
            GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.black_small);
            GMapOverlay markers = new GMapOverlay("markers");
            markers.Markers.Add(marker);
            map.Overlays.Add(markers);
            local.Visible = true;
            ir.Visible = true;
            buscar.Visible = true;
            una.Visible = false;
            texto.Visible = false;
            buscar1.Visible = true;
            mover.Visible = true;
            moverpainel(unaAimores);
            _points.Add(point);
            unaLiberdade.Visible = false;
            unaJoaoPinheiroI.Visible = false;
            
            unaGuajajaras.Visible = false;



        }

        private void unaGuajajaras_Click(object sender, EventArgs e)
        {
            map.MapProvider = GMapProviders.GoogleMap;
            GMapProviders.GoogleMap.ApiKey = @"AIzaSyB3ynVU6JzIg_Az9760eAa5LA1Rg5Icgiw";
            GMaps.Instance.Mode = AccessMode.ServerAndCache;
            map.DragButton = MouseButtons.Left;
            map.CacheLocation = @"cache";



            map.MinZoom = 8;
            map.MaxZoom = 30;
            map.Zoom = 17.6;
            double lat = (-19.9264584);

            double lng = (-43.9378824);


            map.Position = new PointLatLng(lat, lng);
            PointLatLng point = new PointLatLng(lat, lng);
            GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.black_small);
            GMapOverlay markers = new GMapOverlay("markers");
            markers.Markers.Add(marker);
            map.Overlays.Add(markers);
            local.Visible = true;
            ir.Visible = true;
            buscar.Visible = true;
            una.Visible = false;
            texto.Visible = false;
            buscar1.Visible = true;
            mover.Visible = true;

            moverpainel(unaGuajajaras);
            _points.Add(point);
            unaLiberdade.Visible = false;
            unaJoaoPinheiroI.Visible = false;
            unaAimores.Visible = false;
            

        }

        private void unaJoaoPinheiroI_Click(object sender, EventArgs e)
        {
            map.MapProvider = GMapProviders.GoogleMap;
            GMapProviders.GoogleMap.ApiKey = @"AIzaSyB3ynVU6JzIg_Az9760eAa5LA1Rg5Icgiw";
            GMaps.Instance.Mode = AccessMode.ServerAndCache;
            map.DragButton = MouseButtons.Left;
            map.CacheLocation = @"cache";



            map.MinZoom = 8;
            map.MaxZoom = 30;
            map.Zoom = 17.6;
            double lat = (-19.9297431);
            
            double lng = (-43.9393458);


            map.Position = new PointLatLng(lat, lng);
            PointLatLng point1 = new PointLatLng(lat, lng);
            GMapMarker marker = new GMarkerGoogle(point1, GMarkerGoogleType.black_small);
            GMapOverlay markers = new GMapOverlay("markers");
            markers.Markers.Add(marker);
            map.Overlays.Add(markers);
            local.Visible = true;
            ir.Visible = true;
            buscar.Visible = true;
            una.Visible = false;
            texto.Visible = false;
            buscar1.Visible = true;
            mover.Visible = true;
            moverpainel(unaJoaoPinheiroI);
            _points.Add(point1);
            unaLiberdade.Visible = false;
            unaAimores.Visible = false;
            unaGuajajaras.Visible = false;

        }


        private void unaLiberdade_Click(object sender, EventArgs e)
        {
            map.MapProvider = GMapProviders.GoogleMap;
            GMapProviders.GoogleMap.ApiKey = @"AIzaSyB3ynVU6JzIg_Az9760eAa5LA1Rg5Icgiw";
            GMaps.Instance.Mode = AccessMode.ServerAndCache;
            map.DragButton = MouseButtons.Left;
            map.CacheLocation = @"cache";



            map.MinZoom = 8;
            map.MaxZoom = 30;
            map.Zoom = 17.6;
            double lat = (-19.9304498);

            double lng = (-43.9413162);


            map.Position = new PointLatLng(lat, lng);
            PointLatLng point2 = new PointLatLng(lat, lng);
            GMapMarker marker = new GMarkerGoogle(point2, GMarkerGoogleType.black_small);
            GMapOverlay markers = new GMapOverlay("markers");
            markers.Markers.Add(marker);
            map.Overlays.Add(markers);
            local.Visible = true;
            ir.Visible = true;
            buscar.Visible = true;
            una.Visible = false;
            texto.Visible = false;
            buscar1.Visible = true;
            mover.Visible = true;
            moverpainel(unaLiberdade);
            _points.Add(point2);
            
            unaJoaoPinheiroI.Visible = false;
            unaAimores.Visible = false;
            unaGuajajaras.Visible = false;

        }

        public void ir_Click(object sender, EventArgs e)
        {
           

            map.ShowCenter = false;

            map.MapProvider = GMapProviders.GoogleMap;
            GMapProviders.GoogleMap.ApiKey = @"AIzaSyB3ynVU6JzIg_Az9760eAa5LA1Rg5Icgiw";
            GMaps.Instance.Mode = AccessMode.ServerAndCache;
            map.DragButton = MouseButtons.Left;
            map.CacheLocation = @"cache";



            map.MinZoom = 8;
            map.MaxZoom = 30;
            map.Zoom = 17.6;


            map.SetPositionByKeywords(local.Text);
            PointLatLng point3 = new PointLatLng(map.Position.Lat, map.Position.Lng);
            GMapMarker marker = new GMarkerGoogle(point3, GMarkerGoogleType.black_small);
            GMapOverlay markers = new GMapOverlay("markers");
            markers.Markers.Add(marker);
            map.Overlays.Add(markers);


            



            sim.Visible = true;
            conf.Visible = true;
            nao.Visible = true;
            confim.Visible = true;
            conf1.Visible = true;
            _points.Add(point3);

            




        }
        


        private void nao_Click(object sender, EventArgs e)
        {

            sim.Visible = false;
            conf.Visible = false;
            nao.Visible = false;
            confim.Visible = false;
            conf1.Visible = false;
        }
        
        public void sim_Click(object sender, EventArgs e)
        {
            
            
            sim.Visible = false;
            conf.Visible = false;
            nao.Visible = false;
            confim.Visible = false;
            conf1.Visible = false;

            var route = GoogleMapProvider.Instance
             .GetRoute(_points[1], _points[0], false, false, 14);
            var r = new GMapRoute(route.Points, "Minha Rota")
            {
                Stroke = new Pen(Color.Black, 3)

            };


            var routes = new GMapOverlay("routes");
            routes.Routes.Add(r);
            map.Overlays.Add(routes);
            perfil14.Text = "KM: " + route.Distance;
            string v = route.Distance.ToString();
           
            
                motorista.Visible = true;
            perfil1.Visible = true;
            
            perfil3.Visible = true;
            perfil4.Visible = true;
            perfil5.Visible = true;
            perfil6.Visible = true;
           
            perfil8.Visible = true;
            perfil9.Visible = true;
            perfil10.Visible = true;
            perfil11.Visible = true;
            perfil13.Visible = true;
            perfil14.Visible = true;
            confirmar.Visible = true;

            valor2.Visible = true;



            try
            {
                if (unaai.Checked == true )
                {
                    map.MapProvider = GMapProviders.GoogleMap;
                    GMapProviders.GoogleMap.ApiKey = @"AIzaSyB3ynVU6JzIg_Az9760eAa5LA1Rg5Icgiw";
                    GMaps.Instance.Mode = AccessMode.ServerAndCache;
                    map.DragButton = MouseButtons.Left;
                    map.CacheLocation = @"cache";



                    map.MinZoom = 8;
                    map.MaxZoom = 30;
                    map.Zoom = 17.6;
                    double lat = (-19.9284485);

                    double lng = (-43.937837);


                    map.Position = new PointLatLng(lat, lng);
                    PointLatLng point = new PointLatLng(lat, lng);
                    GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.black_small);
                    GMapOverlay markers = new GMapOverlay("markers");
                    markers.Markers.Add(marker);
                    map.Overlays.Add(markers);
                    local.Visible = true;
                    ir.Visible = true;
                    buscar.Visible = true;
                    una.Visible = false;
                    texto.Visible = false;
                    buscar1.Visible = true;
                    mover.Visible = true;
                    moverpainel(unaAimores);
                    _points.Add(point);
                }
                else if (unagua.Checked == true)
                {
                    map.MapProvider = GMapProviders.GoogleMap;
                    GMapProviders.GoogleMap.ApiKey = @"AIzaSyB3ynVU6JzIg_Az9760eAa5LA1Rg5Icgiw";
                    GMaps.Instance.Mode = AccessMode.ServerAndCache;
                    map.DragButton = MouseButtons.Left;
                    map.CacheLocation = @"cache";



                    map.MinZoom = 8;
                    map.MaxZoom = 30;
                    map.Zoom = 17.6;
                    double lat = (-19.9264584);

                    double lng = (-43.9378824);


                    map.Position = new PointLatLng(lat, lng);
                    PointLatLng point = new PointLatLng(lat, lng);
                    GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.black_small);
                    GMapOverlay markers = new GMapOverlay("markers");
                    markers.Markers.Add(marker);
                    map.Overlays.Add(markers);
                    local.Visible = true;
                    ir.Visible = true;
                    buscar.Visible = true;
                    una.Visible = false;
                    texto.Visible = false;
                    buscar1.Visible = true;
                    mover.Visible = true;

                    moverpainel(unaGuajajaras);
                    _points.Add(point);
                    unaLiberdade.Visible = false;
                    unaJoaoPinheiroI.Visible = false;
                    unaAimores.Visible = false;

                }
                else if (unajoao.Checked == true)
                {
                    map.MapProvider = GMapProviders.GoogleMap;
                    GMapProviders.GoogleMap.ApiKey = @"AIzaSyB3ynVU6JzIg_Az9760eAa5LA1Rg5Icgiw";
                    GMaps.Instance.Mode = AccessMode.ServerAndCache;
                    map.DragButton = MouseButtons.Left;
                    map.CacheLocation = @"cache";



                    map.MinZoom = 8;
                    map.MaxZoom = 30;
                    map.Zoom = 17.6;
                    double lat = (-19.9297431);

                    double lng = (-43.9393458);


                    map.Position = new PointLatLng(lat, lng);
                    PointLatLng point1 = new PointLatLng(lat, lng);
                    GMapMarker marker = new GMarkerGoogle(point1, GMarkerGoogleType.black_small);
                    GMapOverlay markers = new GMapOverlay("markers");
                    markers.Markers.Add(marker);
                    map.Overlays.Add(markers);
                    local.Visible = true;
                    ir.Visible = true;
                    buscar.Visible = true;
                    una.Visible = false;
                    texto.Visible = false;
                    buscar1.Visible = true;
                    mover.Visible = true;
                    moverpainel(unaJoaoPinheiroI);
                    _points.Add(point1);
                }
                else if (unaliba.Checked == true)
                {
                    map.MapProvider = GMapProviders.GoogleMap;
                    GMapProviders.GoogleMap.ApiKey = @"AIzaSyB3ynVU6JzIg_Az9760eAa5LA1Rg5Icgiw";
                    GMaps.Instance.Mode = AccessMode.ServerAndCache;
                    map.DragButton = MouseButtons.Left;
                    map.CacheLocation = @"cache";



                    map.MinZoom = 8;
                    map.MaxZoom = 30;
                    map.Zoom = 17.6;
                    double lat = (-19.9304498);

                    double lng = (-43.9413162);


                    map.Position = new PointLatLng(lat, lng);
                    PointLatLng point2 = new PointLatLng(lat, lng);
                    GMapMarker marker = new GMarkerGoogle(point2, GMarkerGoogleType.black_small);
                    GMapOverlay markers = new GMapOverlay("markers");
                    markers.Markers.Add(marker);
                    map.Overlays.Add(markers);
                    local.Visible = true;
                    ir.Visible = true;
                    buscar.Visible = true;
                    una.Visible = false;
                    texto.Visible = false;
                    buscar1.Visible = true;
                    mover.Visible = true;
                    moverpainel(unaLiberdade);
                    _points.Add(point2);

                    unaJoaoPinheiroI.Visible = false;
                    unaAimores.Visible = false;
                    unaGuajajaras.Visible = false;



                }










            }
            catch (Exception)
            {

                MessageBox.Show("Error de confirmação");
            }





        }

        private void una_Click(object sender, EventArgs e)
        {
            map.MapProvider = GMapProviders.GoogleMap;
            GMapProviders.GoogleMap.ApiKey = @"AIzaSyB3ynVU6JzIg_Az9760eAa5LA1Rg5Icgiw";
            GMaps.Instance.Mode = AccessMode.ServerAndCache;
            map.DragButton = MouseButtons.Left;
            map.CacheLocation = @"cache";



            map.MinZoom = 8;
            map.MaxZoom = 30;
            map.Zoom = 12;
            map.SetPositionByKeywords("Belo Horizonte, centro");
            
            local.Visible = true;
            ir.Visible = true;
            buscar.Visible = true;
            una.Visible = false;
            texto.Visible = false;
            buscar1.Visible = true;
            mover.Visible = true;


        }

        public void confirmar_Click(object sender, EventArgs e)

        {


          
            View.caronexmotorista motorista = new View.caronexmotorista();
            motorista.ShowDialog();
            local.Visible = true;
            ir.Visible = true;
            buscar.Visible = true;
            una.Visible = false;
            texto.Visible = false;
            buscar1.Visible = true;
            mover.Visible = true;
            confirmar.Visible = false;
            perfil2.Visible = true;
            unaLiberdade.Visible = false;
            unaJoaoPinheiroI.Visible = false;
           unaGuajajaras.Visible = false;
           

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            unaLiberdade.Visible = true;
            unaJoaoPinheiroI.Visible = true;
            unaAimores.Visible = true;
            unaGuajajaras.Visible = true;
            _points.Clear();
            

        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            map.ShowCenter = false;
            local.Visible = false;
            ir.Visible = false;
            buscar.Visible = false;
            buscar1.Visible = false;
            mover.Visible = false;
            sim.Visible = false;
            conf.Visible = false;
            nao.Visible = false;
            confim.Visible = false;
            conf1.Visible = false;
            motorista.Visible = false;
            perfil1.Visible = false;

            perfil3.Visible = false;
            perfil4.Visible = false;
            perfil5.Visible = false;
            perfil6.Visible = false;

            perfil8.Visible = false;
            perfil9.Visible = false;
            perfil10.Visible = false;
            perfil11.Visible = false;

            perfil13.Visible = false;
            perfil14.Visible = false;
            confirmar.Visible = false;
            perfil2.Visible = false;
            valor2.Visible = false;
            unaLiberdade.Visible = true;
            unaJoaoPinheiroI.Visible = true;
            unaAimores.Visible = true;
            unaGuajajaras.Visible = true;
            _points.Clear();

        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            meuperfil.Visible = true;
            meuperfil1.Visible = true;
            meuperfil2.Visible = true;
            meuperfil3.Visible = true;
            meuperfil5.Visible = true;
            ok.Visible = true;

        }

        private void ok_Click(object sender, EventArgs e)
        {
            meuperfil.Visible = false;
            meuperfil1.Visible = false;
            meuperfil2.Visible = false;
            meuperfil3.Visible = false;
            meuperfil5.Visible = false;
            ok.Visible = false;
        }
    }
}
