using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathNet.Numerics.LinearAlgebra;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Session
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private double[] ConvertTextboxTextToDoubleArray(System.Windows.Forms.TextBox textBox)
        {
            string text = textBox.Text;
            string[] parts = text.Split(new char[] { ' ', ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
            double[] numbers = new double[parts.Length];

            for (int i = 0; i < parts.Length; i++)
            {
                double number;
                if (!double.TryParse(parts[i], out number))
                {
                    MessageBox.Show("Ввод должен содержать только числа.");
                }
                numbers[i] = number;
            }

            return numbers;
        }

        public class LeastSquares
        {
            public double A { get; private set; } // Коэффициент a
            public double B { get; private set; } // Коэффициент b

            public void CalculateLeastSquares(double[] x, double[] y)
            {
                if (x.Length != y.Length)
                {
                    throw new ArgumentException("Массивы x и y должны быть одинаковой длины.");
                }

                var n = x.Length;
                var X = Matrix<double>.Build.Dense(n, 2);
                var Y = Vector<double>.Build.Dense(y);

                for (int i = 0; i < n; i++)
                {
                    X[i, 0] = 1; // Для коэффициента B
                    X[i, 1] = x[i]; // Для коэффициента A
                }

                var p = X.TransposeThisAndMultiply(X).Inverse() * X.TransposeThisAndMultiply(Y);
                B = p[0];
                A = p[1];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double[] a = ConvertTextboxTextToDoubleArray(textBox1);
                double[] b = ConvertTextboxTextToDoubleArray(textBox2);

                var leastSquares = new LeastSquares();
                leastSquares.CalculateLeastSquares(a, b);

                aBox.Text = leastSquares.A.ToString();
                bBox.Text = leastSquares.B.ToString();
            }
            /*catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка формата", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
