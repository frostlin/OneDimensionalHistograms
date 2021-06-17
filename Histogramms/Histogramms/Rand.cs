using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Histogramms
{
    public partial class Rand : Form
    {
        public Rand()
        {
            InitializeComponent();
            numericUpDownCount.Maximum = 1000000;
            numericUpDownLeft.Minimum = int.MinValue;
            numericUpDownRight.Maximum = int.MaxValue;
        }

        
        private void buttonPlot_Click_1(object sender, EventArgs e)
        {
            int size = (int)numericUpDownCount.Value;
            int left = (int)numericUpDownLeft.Value;
            int right = (int)numericUpDownRight.Value;
            int[] array = new int[size];
            for (int it = 0; it < numericUpDownIterations.Value; ++it)
            {
                var rng = new Random(DateTime.Now.Millisecond);
                for (int i = 0; i < array.Length; ++i)
                    array[i] = rng.Next(left, right + 1);

                HistogramDataProcessor proc = new HistogramDataProcessor();
                List<HistogramDataProcessor.Element> list = proc.Process(array);
                if (chart.Series.Count != 0
                    && chart.Series[chart.Series.Count - 1].ChartArea == chart.ChartAreas[1].Name)
                    chart.Series.RemoveAt(chart.Series.Count - 1);

                chart.Series.Add("Случайная выборка " + chart.Series.Count);
                chart.Series[chart.Series.Count - 1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                chart.Series[chart.Series.Count - 1].BorderWidth = 3;

                chart.Series.Add("Случайная выборка " + chart.Series.Count);
                chart.Series[chart.Series.Count - 1].ChartArea = chart.ChartAreas[1].Name;
                chart.Series[chart.Series.Count - 1].IsValueShownAsLabel = true;
                chart.Series[chart.Series.Count - 1].IsXValueIndexed = true;

                for (int i = 0; i < list.Count; ++i)
                {
                    chart.Series[chart.Series.Count - 1].Points.AddXY(list[i].value, list[i].count);
                    chart.Series[chart.Series.Count - 2].Points.AddXY(list[i].value, list[i].count);
                }

                chart.Update();
            }
        }

        private void buttonClear_Click_1(object sender, EventArgs e)
        {
            chart.Series.Clear();
        }

        private void buttonBack_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }

}
