using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2D_graphics
{
    public partial class Form1 : Form
    {
        List<Matrix2D> Figure;
        int height, width;
        static int scale = 25; // масштаб
        float x0, y0; // координаты точки поворота
        bool FigureColor = false;
        Color figureClr;

        public Form1()
        {
            InitializeComponent();
            // координаты фигуры
            Figure = new List<Matrix2D>
            {
                new Matrix2D(1, 1),
                new Matrix2D(2, 4),
                new Matrix2D(5, 4),
                new Matrix2D(8, 1)
            };
            // рамка для pictureBox1
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;

            height = pictureBox1.Height / 2;
            width = pictureBox1.Width / 2;
            // начальные значение матрицы
            matrix.Rows.Add(1, 0, 0);
            matrix.Rows.Add(0, 1, 0);
            matrix.Rows.Add(0, 0, 1);
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            height = pictureBox1.Height / 2;
            width = pictureBox1.Width / 2;

            Graphics gr = e.Graphics;
            gr.SmoothingMode = SmoothingMode.HighQuality;

            // перенос центра координат
            gr.TranslateTransform(width, height);
            // масштаб
            if (trackBarScale.Value != 0)
                scale = trackBarScale.Value;

            Pen arrowPen = new Pen(Color.Brown);
            arrowPen.CustomEndCap = new AdjustableArrowCap(4, 4);

            Font AxesFont = new Font("Times New Roman", 8);
            SolidBrush brush = new SolidBrush(Color.Black);
            Pen pen = new Pen(Color.LightGray, 1);
            pen.DashStyle = DashStyle.DashDotDot;

            // сетка
            for (int i = scale; i <= width; i += scale) // сетка
            {
                gr.DrawLine(pen, i, 50 * scale, i, -50 * scale);
                gr.DrawLine(pen, -i, 50 * scale, -i, -50 * scale);
                gr.DrawLine(pen, 50 * scale, -i, 50 * -scale, -i);
                gr.DrawLine(pen, 50 * scale, i, 50 * -scale, i);
            }

            // оси
            gr.DrawLine(arrowPen, -width + 5, 0, width - 5, 0); //ось х
            gr.DrawLine(arrowPen, 0, height - 5, 0, -height + 5); // ось у
            gr.DrawString("X", AxesFont, brush, new PointF(width - 15, 5));
            gr.DrawString("Y", AxesFont, brush, new PointF(5, -height + 5));

            pen = new Pen(Color.Brown, 0.5f);
            // разметка на осях
            for (int i = scale; i < width - 20; i += scale)
            {
                gr.DrawEllipse(pen, i, -2.5f, 0.2f, 5);
                gr.DrawEllipse(pen, -i, -2.5f, 0.2f, 5);
                gr.DrawEllipse(pen, -2.5f, i, 5, 0.2f);
                gr.DrawEllipse(pen, -2.5f, -i, 5, 0.2f);
            }

            // подписи осей
            if (scale >= 25)
            {
                Font numbers = new Font("Times New Roman", 8);
                for (int i = 1; i < width / scale; i++)
                {
                    gr.DrawString(i.ToString(), numbers, brush, i * scale - 4, 8);
                    gr.DrawString(i.ToString(), numbers, brush, 8, -i * scale - 5);
                }
                for (int i = -1; i > -width / scale; i--)
                {
                    gr.DrawString(i.ToString(), numbers, brush, i * scale - 7, 8);
                    gr.DrawString(i.ToString(), numbers, brush, 8, -i * scale - 8);
                }
            }
            // закрашивание фигуры
            SolidBrush FigureBrush = new SolidBrush(Color.Blue);
            if (FigureColor)
                FigureBrush = new SolidBrush(figureClr);
            // перенос по матрице
            TranslateFigure();
            // прорисовка фигуры
            DrawFigure(gr, Figure, FigureBrush);
            // точка поворота
            if (checkBoxShowPoint.Checked)
                DrawPoint(gr, x0, y0);
        }
        public void RotationXY()
        {
            // повороты
            // вокруг произвольной точки
            if (radioButtonPoint.Checked)
            {
                if (textBoxX0.Text == "") x0 = 0;
                else x0 = float.Parse(textBoxX0.Text);
                if (textBoxY0.Text == "") y0 = 0;
                else y0 = float.Parse(textBoxY0.Text);
            }
            // вокруг собственного центра
            float sumx = 0, sumy = 0;
            if (radioButtonOwnCenter.Checked)
            {
                for (int i = 0; i < Figure.Count; i++)
                {
                    sumx += Figure[i].GetX();
                    sumy += Figure[i].GetY();
                }
                x0 = sumx / Figure.Count;
                y0 = sumy / Figure.Count;
            }
            // вокруг центра координат
            if (radioButtonCenter.Checked)
            {
                x0 = 0; textBoxX0.Text = "0";
                y0 = 0; textBoxY0.Text = "0";
            }
        }
        private void TranslateFigure()
        {
            // перенос фигуры с помощью матрицы
            float[,] matrixTrans = new float[3, 3];
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    matrixTrans[i, j] = float.Parse(matrix[j, i].Value.ToString());
            foreach (Matrix2D point in Figure)
                point.Mul(matrixTrans, 0, 0);
        }
        public void DrawPoint(Graphics gr, float x0, float y0)
        {
            // прорисовка точки поворота
            SolidBrush pen = new SolidBrush(Color.Black);
            gr.FillEllipse(pen, x0 * scale - 1f, -y0 * scale - 2.5f, 5, 5);
        }
        public float A_to_R(float angle)
        {
            // перевод из градусов в радианы
            return (float)((angle * Math.PI) / 180); // перевод в радианы
        }
        private void DrawFigure(Graphics g, List<Matrix2D> figure, Brush brush)
        {
            // прорисовка фигуры
            Pen p = new Pen(Color.Black, 1);

            PointF start, end;
            PointF[] points = new PointF[figure.Count];

            for (int i = 0; i < figure.Count; i += 4)
            {
                start = figure[i].screenPoint2D(scale);
                points[i] = start;
                for (int j = i + 1; j < figure.Count; j++)
                {
                    end = figure[j].screenPoint2D(scale);
                    g.DrawLine(p, start, end);
                    start = end;
                    points[j] = start;
                }
                g.DrawLine(p, start, figure[i].screenPoint2D(scale));
            }
            g.FillPolygon(brush, points);

            if (checkBoxFigurePoints.Checked)
            {
                // цифры на углах фигуры
                string[] alfabet = { "A", "B", "C", "D" };
                for (int i = 0; i < Figure.Count; i++)
                    g.DrawString(alfabet[i], new Font("Arial", scale / 3),
                        new SolidBrush(Color.Black), Figure[i].screenPoint2D(scale));
            }
        }
        private void Invalidate(object sender, EventArgs e)
        {
            // процедура перерисовки pictureBox1
            pictureBox1.Invalidate();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            // кнопка поворота
            float[,] matrixRotation = new float[3, 3];
            float angle;
            Array.Clear(matrixRotation, 0, 4);

            if (textBoxAngle.Text == "" || textBoxAngle.Text == "-") angle = 0;

            else angle = -float.Parse(textBoxAngle.Text);
            matrixRotation[0, 0] = (float)Math.Cos(A_to_R(angle));
            matrixRotation[0, 1] = (float)Math.Sin(A_to_R(angle));
            matrixRotation[1, 0] = -(float)Math.Sin(A_to_R(angle));
            matrixRotation[1, 1] = (float)Math.Cos(A_to_R(angle));
            matrixRotation[2, 2] = 1f;
            // выбор текущего поворота
            RotationXY();

            foreach (Matrix2D point in Figure)
                point.Mul(matrixRotation, x0, y0);
            pictureBox1.Invalidate();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            // анимация вращения
            if (checkBoxAnimation.Checked)
                button2_Click(sender, e);
            pictureBox1.Invalidate();
        }
        private void checkBoxAnimation_CheckedChanged(object sender, EventArgs e)
        {
            // таймер анимации
            // старт
            if (checkBoxAnimation.Checked)
            {
                timer1.Start();
                timer1.Enabled = true;
                timer1.Interval = 1;
            }
            // стоп
            else
            {
                timer1.Stop();
                timer1.Enabled = false;
            }
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            // кнопка очистить
            // приведение всех значений к начальным
            scale = 25;
            trackBarScale.Value = scale;
            textBoxScale.Text = 25.ToString();
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                {
                    if (i == j)
                        matrix[i, j].Value = 1;
                    else
                        matrix[i, j].Value = 0;
                }
            figureClr = Color.Blue;
            // координаты фигуры
            Figure = new List<Matrix2D>
            {
                new Matrix2D(1, 1),
                new Matrix2D(2, 4),
                new Matrix2D(5, 4),
                new Matrix2D(8, 1)
            };
            textBoxAngle.Text = "0";
            radioButtonCenter.Checked = false;

            radioButtonPoint.Checked = false;
            textBoxX0.Text = "0";
            textBoxY0.Text = "0";

            radioButtonOwnCenter.Checked = false;
            checkBoxAnimation.Checked = false;
            checkBoxFigurePoints.Checked = false;

            checkBoxShowPoint.Checked = false;

            pictureBox1.Invalidate();
        }
        private void colorPickerFig_Click(object sender, EventArgs e)
        {
            // выбор цвета фигуры
            colorDialogFigure.ShowDialog();
            figureClr = colorDialogFigure.Color;
            FigureColor = true;
            pictureBox1.Invalidate();
        }
        private void trackBarScale_Scroll(object sender, EventArgs e)
        {
            // изменения trackBar для масштаба
            scale = trackBarScale.Value;
            textBoxScale.Text = scale.ToString();
            pictureBox1.Invalidate();
        }
        private void textBoxScale_TextChanged(object sender, EventArgs e)
        {
            // изменения textBox для масштаба
            textBoxScale.Invalidate();
            if (textBoxScale.Text == "") trackBarScale.Value = 0;
            else trackBarScale.Value = Convert.ToInt32(textBoxScale.Text);
            scale = trackBarScale.Value;

            pictureBox1.Invalidate();
        }
    }
}
