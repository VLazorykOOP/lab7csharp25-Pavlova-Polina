using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Lab7CSharp
{
    public partial class Form2 : Form
    {
        private Color selectedColor;
        // Видалено дублювання - openFileDialog і saveFileDialog вже оголошені в Designer.cs

        public Form2()
        {
            InitializeComponent();
            InitializeControls();
        }

        private void InitializeControls()
        {
            // Налаштування базових параметрів форми
            this.Text = "Інструмент піпетка - Lab 7";
            this.Size = new Size(700, 500);
            this.BackColor = Color.FromArgb(245, 245, 240); // Світлий бежевий
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // Налаштування діалогів (вони вже створені в Designer.cs)
            openFileDialog.Filter = "Файли зображень|*.jpg;*.jpeg;*.png;*.bmp;*.gif|Всі файли|*.*";
            openFileDialog.Title = "Виберіть зображення";

            saveFileDialog.Filter = "Файли JPEG|*.jpg|Файли PNG|*.png|Файли BMP|*.bmp|Всі файли|*.*";
            saveFileDialog.Title = "Зберегти зображення як";
            saveFileDialog.DefaultExt = "jpg";
            saveFileDialog.AddExtension = true;

            // Початкові значення кольору
            selectedColor = Color.White;
            UpdateColorInfo(selectedColor);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Завантаження зображення у PictureBox
                    Image loadedImage = Image.FromFile(openFileDialog.FileName);
                    pictureBoxImage.Image = loadedImage;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка при завантаженні зображення: " + ex.Message,
                        "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (pictureBoxImage.Image != null)
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Отримання формату для збереження на основі розширення
                        string extension = Path.GetExtension(saveFileDialog.FileName).ToLower();
                        System.Drawing.Imaging.ImageFormat format;

                        switch (extension)
                        {
                            case ".png":
                                format = System.Drawing.Imaging.ImageFormat.Png;
                                break;
                            case ".bmp":
                                format = System.Drawing.Imaging.ImageFormat.Bmp;
                                break;
                            default:
                                format = System.Drawing.Imaging.ImageFormat.Jpeg;
                                break;
                        }

                        // Зберігаємо зображення
                        pictureBoxImage.Image.Save(saveFileDialog.FileName, format);
                        MessageBox.Show("Зображення успішно збережено!",
                            "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Помилка при збереженні зображення: " + ex.Message,
                            "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Немає зображення для збереження!",
                    "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pictureBoxImage_MouseClick(object sender, MouseEventArgs e)
        {
            if (pictureBoxImage.Image != null)
            {
                try
                {
                    // Конвертуємо координати кліку до координат зображення
                    int imageX, imageY;

                    // Розрахунок для PictureBoxSizeMode.Zoom
                    float imageRatio = (float)pictureBoxImage.Image.Width / pictureBoxImage.Image.Height;
                    float boxRatio = (float)pictureBoxImage.Width / pictureBoxImage.Height;

                    float scaleWidth, scaleHeight;
                    float scaleFactor;

                    if (imageRatio >= boxRatio)
                    {
                        // Зображення масштабується по ширині
                        scaleFactor = (float)pictureBoxImage.Width / pictureBoxImage.Image.Width;
                        scaleWidth = pictureBoxImage.Width;
                        scaleHeight = pictureBoxImage.Image.Height * scaleFactor;

                        // Координати з урахуванням відступів
                        float yOffset = (pictureBoxImage.Height - scaleHeight) / 2;

                        if (e.Y < yOffset || e.Y > (yOffset + scaleHeight))
                            return; // Клік поза зображенням

                        imageX = (int)(e.X / scaleFactor);
                        imageY = (int)((e.Y - yOffset) / scaleFactor);
                    }
                    else
                    {
                        // Зображення масштабується по висоті
                        scaleFactor = (float)pictureBoxImage.Height / pictureBoxImage.Image.Height;
                        scaleWidth = pictureBoxImage.Image.Width * scaleFactor;
                        scaleHeight = pictureBoxImage.Height;

                        // Координати з урахуванням відступів
                        float xOffset = (pictureBoxImage.Width - scaleWidth) / 2;

                        if (e.X < xOffset || e.X > (xOffset + scaleWidth))
                            return; // Клік поза зображенням

                        imageX = (int)((e.X - xOffset) / scaleFactor);
                        imageY = (int)(e.Y / scaleFactor);
                    }

                    // Перевірка, чи координати в межах зображення
                    if (imageX >= 0 && imageX < pictureBoxImage.Image.Width &&
                        imageY >= 0 && imageY < pictureBoxImage.Image.Height)
                    {
                        // Отримуємо колір пікселя
                        using (Bitmap bitmap = new Bitmap(pictureBoxImage.Image))
                        {
                            selectedColor = bitmap.GetPixel(imageX, imageY);
                            UpdateColorInfo(selectedColor);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка при отриманні кольору: " + ex.Message,
                        "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UpdateColorInfo(Color color)
        {
            // Оновлюємо зразок кольору
            pictureBoxColorSample.BackColor = color;

            // Оновлюємо значення RGB
            labelR.Text = $"R: {color.R}";
            labelG.Text = $"G: {color.G}";
            labelB.Text = $"B: {color.B}";
            labelHex.Text = $"Hex: #{color.R:X2}{color.G:X2}{color.B:X2}";
        }
    }
}