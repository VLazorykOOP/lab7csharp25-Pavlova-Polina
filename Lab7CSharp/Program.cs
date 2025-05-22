using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7CSharp
{
    internal static class Program
    {
        /// <summary>
        /// Головна точка входу для додатка.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Показуємо меню вибору
            ShowMainMenu();
        }

        private static void ShowMainMenu()
        {
            while (true)
            {
                string message = "🔹 Lab 7 C# - Головне меню 🔹\n\n" +
                    "Оберіть яку форму ви хочете запустити:\n\n" +
                    "✅ ТАК - Form1 (Перше завдання)\n" +
                    "🎨 НІ - Form2 (Інструмент піпетка)\n" +
                    "🔺 ПОВТОР - Form3 (Малювання фігур)\n" +
                    "❌ СКАСУВАТИ - Вийти з програми";

                DialogResult result = MessageBox.Show(message, "Lab 7 - Головне меню",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Application.Run(new Form1());
                }
                else if (result == DialogResult.No)
                {
                    Application.Run(new Form2());
                }
                else if (result == DialogResult.Cancel)
                {
                    // Показуємо додаткове меню для Form3
                    DialogResult form3Result = MessageBox.Show(
                        "Відкрити Form3 (Малювання фігур)?",
                        "Form3",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (form3Result == DialogResult.Yes)
                    {
                        Application.Run(new Form3());
                    }
                    else
                    {
                        return; // Вихід з програми
                    }
                }

                // Запитуємо чи хоче користувач відкрити іншу форму
                DialogResult continueResult = MessageBox.Show(
                    "Бажаєте відкрити іншу форму?",
                    "Продовжити?",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (continueResult == DialogResult.No)
                    break;
            }
        }
    }
}