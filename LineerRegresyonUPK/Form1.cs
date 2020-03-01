using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Diagnostics;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Collections;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing.Drawing2D;

namespace LineerRegresyonUPK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double[] ch;
        double[] xdegerler;
        double[] ydegerler;
        double intercept11;
        double egim;
        private void RegresyonModeliOlustur(out double rdegisken, out double adegisken, out double bdegisken)
        {
            
            List<string> yValTemp = new List<string>();
            yValTemp.AddRange(txt_yval.Lines);
            string ty = String.Join(",", yValTemp);
            ydegerler = Array.ConvertAll(ty.Split(','), Double.Parse);

            List<string> xValTemp = new List<string>();
            xValTemp.AddRange(txt_xval.Lines);
            string tx = String.Join(",", xValTemp);
            xdegerler = Array.ConvertAll(tx.Split(','), Double.Parse);
            
            var uzunluk = xdegerler.Length;
            if (uzunluk != ydegerler.Length)
            {
                throw new Exception("Uzunluklar Aynı Olmalı");
            }

            var xOrtalama = xdegerler.Average();
            
            txt_avgx.Text = Math.Round(xOrtalama, 3).ToString();
            var yOrtalama = ydegerler.Average();
            txt_avgy.Text = Math.Round(yOrtalama, 3).ToString();

            var xKareUzakliklarToplami = 0D;
            var yKareUzakliklarToplami = 0D;
            var xyUzakliklarCarpimiToplami = 0D;

            for (int i = 0; i < uzunluk; i++)
            {
                var x = xdegerler[i];
                var y = ydegerler[i];

                var xUzaklik = xOrtalama - x;
                var yUzaklik = yOrtalama - y;

                xKareUzakliklarToplami += Math.Pow(xUzaklik, 2);
                yKareUzakliklarToplami += Math.Pow(yUzaklik, 2);
                xyUzakliklarCarpimiToplami += xUzaklik * yUzaklik;
            }

            var xStandartSapma = Math.Sqrt(xKareUzakliklarToplami / (uzunluk - 1D));
            txt_stdx.Text = Math.Round(xStandartSapma, 3).ToString();
            xsvariance.Text = Math.Round(Math.Pow(xStandartSapma, 2), 3).ToString();
            var yStandartSapma = Math.Sqrt(yKareUzakliklarToplami / (uzunluk - 1D));
            txt_stdy.Text = Math.Round(yStandartSapma, 3).ToString();
            ysvariance.Text = Math.Round(Math.Pow(yStandartSapma, 2), 3).ToString();
            var kovaryans = xyUzakliklarCarpimiToplami / (uzunluk - 1D);

            rdegisken = (kovaryans / (xStandartSapma * yStandartSapma));
            bdegisken = rdegisken * (yStandartSapma / xStandartSapma);
            slope1.Text = Math.Round(bdegisken, 3).ToString();
            adegisken = yOrtalama - bdegisken * xOrtalama;
            intercept.Text = Math.Round(adegisken, 3).ToString();
            
        }
            private void btn_lrhesapla_Click(object sender, EventArgs e)
        {
            
            txt_sumy.Text = "";
            txt_sumx.Text = "";
            txt_avgx.Text = "";
            txt_avgy.Text = "";

            RegresyonModeliOlustur( out double rdegisken, out double adegisken, out double bdegisken);
            egim= bdegisken;
            intercept11 = adegisken;
            ch = new double[] { egim, intercept11 };

            chart1.Series.Clear();
            Chart1Code(4, egim, intercept11);
        }
        private void Chart1Code(double interval, double egim, double intercept11)
        {
            double[] x=xdegerler;
            double[] y=ydegerler;

            chart1.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
            chart1.ChartAreas[0].Axes[0].Title = xvalname.Text; //"x";
            chart1.ChartAreas[0].Axes[1].Title = yvalname.Text; //"y";
            chart1.BackColor = System.Drawing.Color.LightGray;
            chart1.ChartAreas[0].AxisY.Minimum = ydegerler.Min()-1;


            chart1.ChartAreas[0].AxisX.Minimum = xdegerler.Min()-1;          
            Series s1 = new Series("egim");
            chart1.Series.Add(s1);
            chart1.Series[0].ChartType = SeriesChartType.Point;
            chart1.Palette = ChartColorPalette.None;
            chart1.PaletteCustomColors = new Color[] { Color.DarkRed };
            chart1.Series[0].MarkerStyle = MarkerStyle.Circle;

            for (int i = 0; i < y.Length; i++)
            {
                chart1.Series[0].Points.AddXY(x[i], y[i]);
            }

            double x1_t = xdegerler[0];
            double y1_t = (egim + intercept11);
            double x2_t = xdegerler[xdegerler.Length - 1];
            double y2_t = (egim * xdegerler.Length) + intercept11;

            chart1.Series.Add("Line");
            chart1.Series["Line"].Points.Add(new DataPoint(x1_t, y1_t));
            chart1.Series["Line"].Points.Add(new DataPoint(x2_t, y2_t));
            chart1.Series["Line"].Color = Color.Green;
            chart1.Series["Line"].ChartType = SeriesChartType.Line;
        }

        private void btnl_lrtemizle_Click(object sender, EventArgs e)
        {
            txt_yval.Text = "";
            txt_xval.Text = "";
            txt_sumy.Text = "";
            txt_sumx.Text = "";
            txt_avgx.Text = "";
            txt_avgy.Text = "";
            slope1.Text = "";
            intercept.Text = "";
            yvalname.Text = "";
            xvalname.Text = "";
            ysvariance.Text = "";
            xsvariance.Text = "";
            txt_stdx.Text = "";
            txt_stdy.Text = "";
            yvallabel.Text = "";
            chart1.Series.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
