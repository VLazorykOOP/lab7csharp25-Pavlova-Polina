using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Lab7CSharp
{
    public partial class Form1 : Form
    {
        private float angle = 0;
        private float radius = 120;
        private Random random = new Random();
        private Pen drawingPen;

        public Form1()
        {
            InitializeComponent();
            SetupAnimation();
        }

        private void SetupAnimation()
        {
            // Основні налаштування форми - класичні пастельні тони
            this.Text = "Lab 7. C# - Анімація";
            this.BackColor = Color.FromArgb(245, 245, 240); // Світлий бежевий фон
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // Налаштування центральної кнопки
            centerButton.Location = new Point(
                this.ClientSize.Width / 2 - centerButton.Width / 2,
                this.ClientSize.Height / 2 - centerButton.Height / 2);
            centerButton.BackColor = Color.FromArgb(215, 210, 205); // Світло-сірий з бежевим відтінком
            centerButton.ForeColor = Color.FromArgb(70, 70, 80); // Темно-сірий текст
            centerButton.FlatStyle = FlatStyle.Standard; // Класичний стиль кнопки
            centerButton.Font = new Font("Garamond", 10, FontStyle.Regular);
            centerButton.Text = "Центр";
            centerButton.Size = new Size(110, 40);

            // Налаштування панелі, що обертається
            rotatingPanel.Size = new Size(80, 55);
            rotatingPanel.BackColor = Color.FromArgb(200, 210, 215); // Світло-блакитний пастельний
            rotatingPanel.BorderStyle = BorderStyle.FixedSingle;
            UpdatePanelPosition();

            // Створення пера для малювання
            drawingPen = new Pen(Color.FromArgb(150, 150, 160), 2); // Сірий з середньою прозорістю

            // Налаштування таймера
            animationTimer.Interval = 50; // Трохи повільніше для класичного вигляду
            animationTimer.Tick += AnimationTimer_Tick;
            animationTimer.Start();

            // Налаштування кнопки контролю
            controlButton.Text = "Старт/Стоп";
            controlButton.Location = new Point(25, 25);
            controlButton.Size = new Size(120, 35);
            controlButton.BackColor = Color.FromArgb(230, 225, 220); // Світло-бежевий
            controlButton.ForeColor = Color.FromArgb(70, 70, 80); // Темно-сірий
            controlButton.FlatStyle = FlatStyle.Standard; // Класичний стиль
            controlButton.Font = new Font("Garamond", 10, FontStyle.Regular);
            controlButton.Click += ControlButton_Click;

            // Налаштування кнопки закриття
            closeButton.Text = "Закрити";
            closeButton.Location = new Point(this.ClientSize.Width / 2 - 60, this.ClientSize.Height - 70);
            closeButton.Size = new Size(120, 35);
            closeButton.BackColor = Color.FromArgb(215, 215, 210); // Світло-сірий
            closeButton.ForeColor = Color.FromArgb(70, 70, 80); // Темно-сірий
            closeButton.FlatStyle = FlatStyle.Standard; // Класичний стиль
            closeButton.Font = new Font("Garamond", 10, FontStyle.Regular);
            closeButton.Click += CloseButton_Click;

            // Налаштування заголовку
            titleLabel.Text = "Lab 7. C#";
            titleLabel.AutoSize = false;
            titleLabel.Size = new Size(150, 35);
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            titleLabel.Font = new Font("Garamond", 12, FontStyle.Bold);
            titleLabel.ForeColor = Color.FromArgb(80, 80, 90); // Темно-сірий
            titleLabel.BackColor = Color.FromArgb(225, 220, 215); // Світло-бежевий
            titleLabel.BorderStyle = BorderStyle.FixedSingle; // Класичний вигляд з рамкою
            titleLabel.Location = new Point(this.ClientSize.Width - 170, 25);
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            // Оновлення кута обертання
            angle += 0.04f; // Трохи повільніше для класичного вигляду
            if (angle > 2 * Math.PI)
                angle = 0;

            // Оновлення позиції панелі
            UpdatePanelPosition();

            // Випадкова зміна властивостей
            ChangeRandomProperties();

            // Перемальовуємо форму для оновлення лінії
            this.Invalidate();
        }

        private void UpdatePanelPosition()
        {
            // Розрахунок нової позиції панелі
            int centerX = centerButton.Location.X + centerButton.Width / 2;
            int centerY = centerButton.Location.Y + centerButton.Height / 2;

            int newX = (int)(centerX + radius * Math.Cos(angle) - rotatingPanel.Width / 2);
            int newY = (int)(centerY + radius * Math.Sin(angle) - rotatingPanel.Height / 2);

            rotatingPanel.Location = new Point(newX, newY);
        }

        private void ChangeRandomProperties()
        {
            // Випадкова зміна кольору панелі з приємними пастельними кольорами
            if (random.Next(10) < 3) // 30% шанс
            {
                // Вибираємо пастельні кольори для класичного вигляду
                Color[] pastels = new Color[] {
                    Color.FromArgb(215, 220, 210),  // Сіро-зелений
                    Color.FromArgb(220, 210, 205),  // Бежевий
                    Color.FromArgb(210, 215, 220),  // Сіро-блакитний
                    Color.FromArgb(225, 210, 215),  // Світло-рожевий
                    Color.FromArgb(220, 220, 200),  // Сіро-жовтий
                    Color.FromArgb(210, 205, 215),  // Сіро-бузковий
                    Color.FromArgb(225, 225, 215)   // Світло-кремовий
                };

                rotatingPanel.BackColor = pastels[random.Next(pastels.Length)];
            }

            // Випадкова зміна кольору і товщини пера
            if (random.Next(10) < 3) // 30% шанс
            {
                int alpha = random.Next(100, 180); // Напівпрозорість для пера у стриманому діапазоні

                Color[] penColors = new Color[] {
                    Color.FromArgb(alpha, 100, 100, 110),  // Сірий
                    Color.FromArgb(alpha, 120, 110, 100),  // Коричневий
                    Color.FromArgb(alpha, 110, 120, 130),  // Сіро-блакитний
                    Color.FromArgb(alpha, 120, 120, 100),  // Оливковий
                    Color.FromArgb(alpha, 110, 100, 120)   // Пурпурно-сірий
                };

                drawingPen.Color = penColors[random.Next(penColors.Length)];
                drawingPen.Width = random.Next(1, 4); // Товщина від 1 до 3 пікселів (більш стримано)
            }
        }

        private void ControlButton_Click(object sender, EventArgs e)
        {
            // Зупинка або запуск анімації
            if (animationTimer.Enabled)
            {
                animationTimer.Stop();
                controlButton.Text = "Старт";
            }
            else
            {
                animationTimer.Start();
                controlButton.Text = "Старт/Стоп";
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            // Закриття програми
            this.Close();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Включаємо згладжування для кращої якості малювання
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Малювання градієнтного фону у пастельних тонах
            using (LinearGradientBrush bgBrush = new LinearGradientBrush(
                this.ClientRectangle,
                Color.FromArgb(245, 245, 240),  // Світлий бежевий
                Color.FromArgb(235, 235, 230),  // Трохи темніший бежевий
                LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(bgBrush, this.ClientRectangle);
            }

            // Додаємо тонку рамку навколо форми для класичного вигляду
            using (Pen borderPen = new Pen(Color.FromArgb(200, 195, 190), 1))
            {
                Rectangle borderRect = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
                e.Graphics.DrawRectangle(borderPen, borderRect);
            }

            // Малювання лінії від центра кнопки до центра панелі
            if (centerButton != null && rotatingPanel != null)
            {
                Point startPoint = new Point(
                    centerButton.Location.X + centerButton.Width / 2,
                    centerButton.Location.Y + centerButton.Height / 2);

                Point endPoint = new Point(
                    rotatingPanel.Location.X + rotatingPanel.Width / 2,
                    rotatingPanel.Location.Y + rotatingPanel.Height / 2);

                // Використання градієнтного пера у приглушених тонах
                using (LinearGradientBrush penBrush = new LinearGradientBrush(
                    startPoint,
                    endPoint,
                    Color.FromArgb(160, drawingPen.Color),
                    Color.FromArgb(120, drawingPen.Color)))
                {
                    using (Pen gradientPen = new Pen(penBrush, drawingPen.Width))
                    {
                        e.Graphics.DrawLine(gradientPen, startPoint, endPoint);
                    }
                }

                // Додаємо делікатний ефект свічення на кінцях лінії
                int glowSize = 6; // Менший розмір для стриманого ефекту

                // Для стартової точки
                using (SolidBrush startGlow = new SolidBrush(Color.FromArgb(100, drawingPen.Color)))
                {
                    e.Graphics.FillEllipse(startGlow,
                        startPoint.X - glowSize / 2,
                        startPoint.Y - glowSize / 2,
                        glowSize, glowSize);
                }

                // Для кінцевої точки
                using (SolidBrush endGlow = new SolidBrush(Color.FromArgb(100, drawingPen.Color)))
                {
                    e.Graphics.FillEllipse(endGlow,
                        endPoint.X - glowSize / 2,
                        endPoint.Y - glowSize / 2,
                        glowSize, glowSize);
                }
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            // При зміні розміру форми перерозміщуємо елементи
            if (centerButton != null)
            {
                centerButton.Location = new Point(
                    this.ClientSize.Width / 2 - centerButton.Width / 2,
                    this.ClientSize.Height / 2 - centerButton.Height / 2);

                closeButton.Location = new Point(
                    this.ClientSize.Width / 2 - closeButton.Width / 2,
                    this.ClientSize.Height - 70);

                titleLabel.Location = new Point(
                    this.ClientSize.Width - 170, 25);

                UpdatePanelPosition();
            }
        }
    }
}