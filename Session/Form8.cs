using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelDataReader;

namespace Session
{
    public partial class Form8 : Form
    {
        private String fileName = string.Empty;
        private DataTableCollection tableCollection = null;

        public Form8()
        {
            InitializeComponent();
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            this.Text = "Метод наименьших квадратов";
        }

        public struct Dots
        {
            public double x;
            public double y;
            public Dots(double myX, double myY)
            {
                x = myX;
                y = myY;
            }
        }
        List<Dots> dots = new List<Dots>();


        void DrowDots()
        {
            for (int turn = 0; turn < dots.Count; ++turn)
            {
                this.chart1.Series[1].Points.AddXY(dots[turn].x, dots[turn].y);
            }
        }

        double FindMin()
        {
            double min = double.MaxValue;
            for (int turn = 0; turn < dots.Count; ++turn)
            {
                if (dots[turn].x < min) min = dots[turn].x;
            }
            return min;
        }
        double FindMax()
        {
            double max = double.MinValue;
            for (int turn = 0; turn < dots.Count; ++turn)
            {
                if (dots[turn].x > max) max = dots[turn].x;
            }
            return max;
        }

        string Func2()
        {
            double sumXY = 0;
            double sumX = 0;
            double sumY = 0;
            double sumPowX = 0;
            for (int turn = 0; turn < dots.Count; ++turn)
            {
                sumXY += dots[turn].x * dots[turn].y;
                sumX += dots[turn].x;
                sumY += dots[turn].y;
                sumPowX += dots[turn].x * dots[turn].x;
            }
            double a = (dots.Count * sumXY - sumX * sumY) / (dots.Count * sumPowX - sumX * sumX);
            double b = (sumY - a * sumX) / dots.Count;
            for (int turn = Convert.ToInt32(FindMin()); turn <= Convert.ToInt32(FindMax()); ++turn)
            {
                double thisY = a * turn + b;
                this.chart1.Series[0].Points.AddXY(turn, thisY);
            }
            String answer = "";
            if (b >= 0)
            {
                answer = "A = " + Convert.ToString(Math.Round(a, 3)) + "\n" + "B = " + Convert.ToString(Math.Round(b, 3)) + "\n" +
                    "Y = " + Convert.ToString(Math.Round(a, 3)) + "X + " + Convert.ToString(Math.Round(b, 3)) + "\n";
            }
            else
            {
                answer = "A = " + Convert.ToString(Math.Round(a, 3)) + "\n" + "B = " + Convert.ToString(Math.Round(b, 3)) + "\n" +
                    "Y = " + Convert.ToString(Math.Round(a, 3)) + "X " + Convert.ToString(Math.Round(b, 3)) + "\n";
            }
            return answer;
        }

        /*string Func3()
        {
            double sumPow4X = 0;
            double sumPow3X = 0;
            double sumPow2X = 0;
            double sumX = 0;
            double sumPow2XY = 0;
            double sumXY = 0;
            double sumY = 0;
            for (int turn = 0; turn < dots.Count; ++turn)
            {
                sumPow4X += Math.Pow(dots[turn].x, 4);
                sumPow3X += Math.Pow(dots[turn].x, 3);
                sumPow2X += Math.Pow(dots[turn].x, 2);
                sumX += dots[turn].x;
                sumPow2XY += Math.Pow(dots[turn].x, 2) * dots[turn].y;
                sumXY += dots[turn].x * dots[turn].y;
                sumY += dots[turn].y;
            }
            double del = sumPow4X * sumPow2X * dots.Count + sumPow3X * sumX * sumPow2X + sumPow3X * sumX * sumPow2X - Math.Pow(sumPow2X, 3) - sumPow3X * sumPow3X * dots.Count - sumX * sumX * sumPow4X;
            double del1 = sumPow2XY * sumPow2X * dots.Count + sumPow3X * sumX * sumY + sumXY * sumX * sumPow2X - sumY * sumPow2X * sumPow2X - sumXY * sumPow3X * dots.Count - sumX * sumX * sumPow2XY;
            double del2 = sumPow4X * sumXY * dots.Count + sumPow3X * sumY * sumPow2X + sumPow2XY * sumX * sumPow2X - sumPow2X * sumPow2X * sumXY - sumPow2XY * sumPow3X * dots.Count - sumY * sumX * sumPow4X;
            double del3 = sumPow4X * sumPow2X * sumY + sumPow3X * sumX * sumPow2XY + sumPow3X * sumXY * sumPow2X - sumPow2X * sumPow2X * sumPow2XY - sumPow3X * sumPow3X * sumY - sumX * sumXY * sumPow4X;
            double a = del1 / del;
            double b = del2 / del;
            double c = del3 / del;
            for (int turn = Convert.ToInt32(FindMin()); turn <= Convert.ToInt32(FindMax()); ++turn)
            {
                double thisY = a * turn * turn + b * turn + c;
                this.chart1.Series[2].Points.AddXY(turn, thisY);
            }
            String myB = "";
            String myC = "";
            string myA = Convert.ToString(Math.Round(a, 3)) + " * x^2 ";
            if (b < 0)
            {
                myB = Convert.ToString(Math.Round(b, 3)) + " * x ";
            }
            else
            {
                myB = "+ " + Convert.ToString(Math.Round(b, 3)) + " * x ";
            }
            if (c < 0)
            {
                myC = Convert.ToString(Math.Round(c, 3));
            }
            else
            {
                myC = "+ " + Convert.ToString(Math.Round(c, 3));
            }
            String answer = "y = " + myA + myB + myC;
            return answer;
        }*/

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void calculateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.chart1.Series[0].Points.Clear();
                this.chart1.Series[1].Points.Clear();
                this.chart1.Series[2].Points.Clear();
                for (int turn = 0; turn < dataGridView1.RowCount - 1; ++turn)
                {
                    dots.Add(new Dots(Convert.ToDouble(dataGridView1[0, turn].Value), Convert.ToDouble(dataGridView1[1, turn].Value)));
                }
                DrowDots();
                label1.Text = "Линейная регрессия:\n";
                label1.Text += Func2();
                //label2.Text += Func3();
            }
            catch
            {
                Mistake();
            }
        }

        private void randomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            string userInput = randBox.Text;

            if (int.TryParse(userInput, out int number) && number > 0)
            {
                for (int turn = 0; turn < number; ++turn)
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                    row.Cells[0].Value = Convert.ToDouble(rand.Next(-100, 100));
                    row.Cells[1].Value = Convert.ToDouble(rand.Next(-100, 100));
                    dataGridView1.Rows.Add(row);
                }
            }
            else
            {
                MessageBox.Show("Некорректный ввод! Пожалуйста, введите положительное целое число.");
            }
        }


        void Mistake()
        {
            label1.Text = "Ошибка";
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            this.chart1.Series[0].Points.Clear();
            this.chart1.Series[1].Points.Clear();
            this.chart1.Series[2].Points.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dots.Clear();
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            randomToolStripMenuItem.Visible = false;
            dataGridView1.Columns.Clear();
            try { 
          
                DialogResult res = openFileDialog1.ShowDialog();
                if (res == DialogResult.OK)
                {
                    fileName = openFileDialog1.FileName;
                    Text = fileName;
                    OpenExcelFile(fileName);
                }
                else
                {
                    throw new Exception("Файл не выбран");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OpenExcelFile(string path)
        {
            double cellValue;
            int rCnt;
            int cCnt;

            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Excel (*.XLSX)|*.XLSX";
            opf.ShowDialog();
            System.Data.DataTable tb = new System.Data.DataTable();
            string filename = opf.FileName;

            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook ExcelWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;
            Microsoft.Office.Interop.Excel.Range ExcelRange;

            ExcelWorkBook = ExcelApp.Workbooks.Open(filename, 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false,
                false, 0, true, 1, 0);
            ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);

            ExcelRange = ExcelWorkSheet.UsedRange;
            dataGridView1.ColumnCount = 2; // Установите количество столбцов равным 2
            dataGridView1.RowCount = ExcelRange.Rows.Count; // Установите количество строк в соответствии с количеством строк в Excel

            for (rCnt = 1; rCnt <= ExcelRange.Rows.Count; rCnt++)
            {
                for (cCnt = 1; cCnt <= 2; cCnt++) // Цикл теперь идет до 2, чтобы считывать два столбца
                {
                    object cellValueObject = ExcelRange.Cells[rCnt, cCnt].Value2;

                    if (cellValueObject != null && cellValueObject != DBNull.Value)
                    {
                        cellValue = (double)(ExcelRange.Cells[rCnt, cCnt] as Microsoft.Office.Interop.Excel.Range).Value2;
                        dataGridView1.Rows[rCnt - 1].Cells[cCnt - 1].Value = cellValue;
                    }
                    else
                    {
                        dataGridView1.Rows[rCnt - 1].Cells[cCnt - 1].Value = 0;
                    }
                }
            }
            ExcelWorkBook.Close(true, null, null);
            ExcelApp.Quit();

            releaseObject(ExcelWorkSheet);
            releaseObject(ExcelWorkBook);
            releaseObject(ExcelApp);
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Unable to release the object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}