using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExChart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            bool invalido = true;
            string var_x = valX.Text;
            string var_y = valY.Text;
            string f0inicio = textBox1.Text;
            string f0fim = textBox2.Text;

            if (Validacao.validaDados(var_x, var_y, f0inicio, f0fim, invalido) == false)
            {
                chart1.Series[0].Points.Clear();
                for (sbyte i = Convert.ToSByte(f0inicio); i < Convert.ToSByte(f0fim); i++)
                {
                    chart1.Series[0].Points.AddXY(Convert.ToSByte(f0inicio) + i, Equacao.getY(var_x, var_y, (sbyte)(Convert.ToSByte(f0inicio) + i)));
                }
            }
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.ChartAreas[0].AxisX.LineWidth = 2;
            chart1.ChartAreas[0].AxisY.LineWidth = 2;
            chart1.ChartAreas[0].AxisX.Crossing = 0;
            chart1.ChartAreas[0].AxisY.Crossing = 0;
            chart1.Series[0].IsValueShownAsLabel = true;
            chart1.Series[0].MarkerColor = Color.Red;
            chart1.Series[0].Color = System.Drawing.Color.Red;
            chart1.Series[0].MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            chart1.Series[0].MarkerSize = 7;
        }

        private void buttonBDVendas_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            BDVendasBLL.conecta();

            while (!Erro.getErro())
            {
                BDVendasBLL.getProximo();
                chart1.Series[0].Points.AddXY(BDVendasBLL.getBDX(), BDVendasBLL.getBDY());
            }

            BDVendasBLL.desconecta();
        }
    }
}
