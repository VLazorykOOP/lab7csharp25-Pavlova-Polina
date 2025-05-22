using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Lab7CSharp
{
    public partial class Form3 : Form
    {
        private Figure[] figures;
        private Random random;
        private int selectedFigureIndex = -1;
        private Color[] colors = { Color.Red, Color.Blue, Color.Green, Color.Orange, Color.Purple, Color.Brown, Color.Pink, Color.Cyan };

        public Form3()
        {
            InitializeComponent();
            random = new Random();
            figures = new Figure[0];
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int count = (int)numericUpDownCount.Value;
            figures = new Figure[count];

            for (int i = 0; i < count; i++)
            {
                figures[i] = GenerateRandomFigure();
            }

            UpdateFiguresList();
            pictureBoxCanvas.Invalidate(); // Перемалювання
        }

        private Figure GenerateRandomFigure()
        {
            // Випадкові параметри
            int x = random.Next(50, pictureBoxCanvas.Width - 50);
            int y = random.Next(50, pictureBoxCanvas.Height - 50);
            int size = random.Next(20, 50);
            Color color = colors[random.Next(colors.Length)];

            // Випадковий тип фігури
            int figureType = random.Next(4);

            switch (figureType)
            {
                case 0:
                    return new Hexagon(x, y, size, color);
                case 1:
                    return new Rhombus(x, y, size, color);
                case 2:
                    return new Triangle(x, y, size, color);
                case 3:
                    float startAngle = random.Next(0, 360);
                    float sweepAngle = random.Next(90, 270);
                    return new Arc(x, y, size, color, startAngle, sweepAngle);
                default:
                    return new Hexagon(x, y, size, color);
            }
        }

        private void UpdateFiguresList()
        {
            listBoxFigures.Items.Clear();

            for (int i = 0; i < figures.Length; i++)
            {
                if (figures[i] != null)
                {
                    string figureType = figures[i].GetType().Name;
                    listBoxFigures.Items.Add($"{i + 1}. {figureType}");
                }
            }
        }

        private void pictureBoxCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Малюємо всі фігури
            for (int i = 0; i < figures.Length; i++)
            {
                if (figures[i] != null)
                {
                    figures[i].Draw(g);

                    // Виділяємо вибрану фігуру
                    if (i == selectedFigureIndex)
                    {
                        using (Pen selectionPen = new Pen(Color.Black, 3))
                        {
                            selectionPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                            Rectangle selectionRect = new Rectangle(
                                figures[i].X - figures[i].Size - 5,
                                figures[i].Y - figures[i].Size - 5,
                                (figures[i].Size + 5) * 2,
                                (figures[i].Size + 5) * 2
                            );
                            g.DrawRectangle(selectionPen, selectionRect);
                        }
                    }
                }
            }
        }

        private void pictureBoxCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            selectedFigureIndex = -1;

            // Шукаємо фігуру під курсором (починаємо з останньої, щоб вибрати верхню)
            for (int i = figures.Length - 1; i >= 0; i--)
            {
                if (figures[i] != null && figures[i].Contains(e.X, e.Y))
                {
                    selectedFigureIndex = i;
                    break;
                }
            }

            // Оновлюємо інформацію
            if (selectedFigureIndex >= 0)
            {
                listBoxFigures.SelectedIndex = selectedFigureIndex;
                labelInfo.Text = figures[selectedFigureIndex].GetInfo();
            }
            else
            {
                listBoxFigures.SelectedIndex = -1;
                labelInfo.Text = "Клікніть на фігуру для вибору";
            }

            pictureBoxCanvas.Invalidate(); // Перемалювання для показу виділення
        }

        private void listBoxFigures_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxFigures.SelectedIndex >= 0 && listBoxFigures.SelectedIndex < figures.Length)
            {
                selectedFigureIndex = listBoxFigures.SelectedIndex;
                labelInfo.Text = figures[selectedFigureIndex].GetInfo();
                pictureBoxCanvas.Invalidate();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            figures = new Figure[0];
            selectedFigureIndex = -1;
            listBoxFigures.Items.Clear();
            labelInfo.Text = "Полотно очищено";
            pictureBoxCanvas.Invalidate();
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            if (figures.Length == 0)
            {
                MessageBox.Show("Немає фігур для переміщення!", "Інформація",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Переміщуємо всі фігури на випадкові відстані
            for (int i = 0; i < figures.Length; i++)
            {
                if (figures[i] != null)
                {
                    int deltaX = random.Next(-50, 51);
                    int deltaY = random.Next(-50, 51);

                    figures[i].Move(deltaX, deltaY);

                    // Перевіряємо, щоб фігура не вийшла за межі
                    if (figures[i].X < 50) figures[i].X = 50;
                    if (figures[i].Y < 50) figures[i].Y = 50;
                    if (figures[i].X > pictureBoxCanvas.Width - 50) figures[i].X = pictureBoxCanvas.Width - 50;
                    if (figures[i].Y > pictureBoxCanvas.Height - 50) figures[i].Y = pictureBoxCanvas.Height - 50;
                }
            }

            // Оновлюємо інформацію про вибрану фігуру
            if (selectedFigureIndex >= 0 && selectedFigureIndex < figures.Length)
            {
                labelInfo.Text = figures[selectedFigureIndex].GetInfo();
            }

            pictureBoxCanvas.Invalidate();
        }
    }
}