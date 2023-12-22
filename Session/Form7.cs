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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using org.matheval;
using MathNet.Numerics;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.Differentiation;
using System.Net;
using MathNet.Numerics.Differentiation;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Windows.Forms.DataVisualization.Charting;
using Session;

namespace Session
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        double F(double X)
        {
            org.matheval.Expression expression = new org.matheval.Expression(textBox7.Text.ToLower());
            expression.Bind("x", X);
            decimal value = expression.Eval<decimal>();
            return (double)value;
        }
        double Func(double X)
        {
            return -F(X);
        }
        public double CoordinateDescentMin(double interval1, double interval2, int accuracy)
        {
            double a = interval1, b = interval2;
            double x = (a + b) / 2; // Инициализация начального значения x
            double delta = 1 / Math.Pow(10, accuracy); // Вычисление дельты по точности n

            while (b - a > delta) // Условие остановки
            {
                if (F(a) > F(b))
                    a = x; // Если значение функции в точке a больше, обновляем начальную границу
                else
                    b = x; // Иначе обновляем конечную границу

                x = (a + b) / 2; // Вычисление нового значения x
            }

            return Math.Round(x, accuracy); // Возвращаем значение x с заданной точностью n
        }
        public double AntiCoordinateDescent(double interval1, double interval2, int accuracy)
        {
            double a = interval1, b = interval2;
            double x = (a + b) / 2; // Инициализация начального значения x
            double delta = 1 / Math.Pow(10, accuracy); // Вычисление дельты по точности n

            while (b - a > delta) // Условие остановки
            {
                if (-F(a) > -F(b))
                    a = x; // Если значение функции в точке a больше, обновляем начальную границу
                else
                    b = x; // Иначе обновляем конечную границу

                x = (a + b) / 2; // Вычисление нового значения x
            }

            return Math.Round(x, accuracy); // Возвращаем значение x с заданной точностью n
        }

        public void рассчитатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                double a, b, Xi, n;
                if (!double.TryParse(textBox1.Text, out a) || !double.TryParse(textBox2.Text, out b) || !double.TryParse(textBox3.Text, out Xi))
                {
                    throw new ArgumentException("Некорректные значения входных данных");
                }
                if (a >= b)
                {
                    throw new ArgumentException("Некорректные границы интервала");
                }
                this.chart1.Series[0].Points.Clear();
                // Dictionary <double, double>  f1 = new Dictionary<double, double>();
                this.chart1.Series[0].ChartType = SeriesChartType.Line;
                this.chart1.Series[0].MarkerStyle = MarkerStyle.Circle;


                double y;
                double c = 1;
                for (double x = a; x <= b; x += 0.1)
                {
                    y = F(x);
                    if (x == 0)
                        y = 0;
                    this.chart1.Series[0].Points.AddXY(x, y);

                    //  y = F(x);
                    //  this.chart1.Series[0].Points.AddXY(x,y);
                    //  x += 0.1;
                }
                this.chart1.Series[0].Color = Color.Green;
                this.chart1.Series[0].BorderWidth = 2;
                //  DescentMethodRoot(a, b, Xi);

                double resultMin = CoordinateDescentMin(a, b, (int)-Math.Log10(Xi));
                double resultMax = AntiCoordinateDescent(a, b, (int)-Math.Log10(Xi));
                textBox5.Text = resultMin.ToString();
                textBox6.Text = resultMax.ToString();
                if (resultMin == a || resultMin == b)
                {
                    throw new ArgumentException("Точки минимум нет на данном интервале");
                }
                else
                {
                    textBox5.Text = resultMin.ToString();
                }
                if (resultMax == a || resultMax == b)
                {
                    throw new ArgumentException("Точки максимум нет на данном интервале");
                }
                else
                {
                    textBox6.Text = resultMax.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }


        }

        private void очиститьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox5.Clear();
            textBox6.Clear();
            this.chart1.Series[0].Points.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}