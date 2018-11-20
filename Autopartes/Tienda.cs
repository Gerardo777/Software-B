using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Autopartes
{
    public partial class Tienda : Form
    {
        public Tienda()
        {
            
            InitializeComponent();
            DrawPieChart(1, 2, 3, 4, 5);
            line_chart();
        }

        private void clientes_boton_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            this.Visible = false;
            cliente.ShowDialog();
            this.Visible = true;
        }

        private void DrawPieChart(int value1, int value2, int value3, int value4, int value5)
        {
            //reset your chart series and legends
            chart1.Series.Clear();
            chart1.Legends.Clear();

            //Add a new Legend(if needed) and do some formating

            chart1.Legends.Add("MyLegend");
            chart1.Legends[0].LegendStyle = LegendStyle.Table;
            chart1.Legends[0].Docking = Docking.Top;
            chart1.Legends[0].BackColor = Color.FromName("Control");
            chart1.Legends[0].Alignment = StringAlignment.Center;
            chart1.Legends[0].Title = "Más vendidos";
            chart1.Legends[0].BorderColor = Color.FromName("Control");
            
            string seriesname = "MySeriesName";
            chart1.Series.Add(seriesname);            
            chart1.Series[seriesname].ChartType = SeriesChartType.Pie;
            
            chart1.Series[seriesname].IsValueShownAsLabel=true;
            chart1.Series[seriesname].Points.AddXY("Luces de neón", 158);
            chart1.Series[seriesname].Points.AddXY("Retrovisor", 153);
            chart1.Series[seriesname].Points.AddXY("Motor", 25);
            chart1.Series[seriesname].Points.AddXY("Parabrisas", 62);
            chart1.Series[seriesname].Points.AddXY("Neumático",48);
        }

        private void line_chart()
        {

            chart2.Legends[0].Docking = Docking.Top;
            chart2.Legends.Add("MyLegend");
            chart2.Legends[0].LegendStyle = LegendStyle.Table;
            //chart2.Legends[0].Docking = Docking.Top;
            chart2.Legends[0].BackColor = Color.FromName("Control");
            chart2.Legends[0].Alignment = StringAlignment.Center;
            chart2.Legends[0].Title = "Ventas";
            chart2.Legends[0].BorderColor = Color.FromName("Control");

            chart2.ChartAreas[0].AxisY.ScaleView.Zoom(0, 10);
            chart2.ChartAreas[0].AxisX.ScaleView.Zoom(0, 10);
            chart2.ChartAreas[0].CursorX.IsUserEnabled = true;
            chart2.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            chart2.ChartAreas[0].AxisX.ScaleView.Zoomable = true;         

            //chart2.Series[0].IsValueShownAsLabel = true;
            chart2.Series[0].Points.AddXY(1, 2);
            chart2.Series[0].Points.AddXY(2, 6);
            chart2.Series[0].Points.AddXY(6, 3);
            chart2.Series[0].Points.AddXY(3, 8);
            chart2.Series[0].Points.AddXY(8, 8);
            
        }

        private void button_empleado_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado();
            this.Visible = false;
            empleado.ShowDialog();
            this.Visible = true;
        }
    }
}

