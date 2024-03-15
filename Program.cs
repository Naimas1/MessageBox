using System.Runtime.InteropServices;

namespace MessageBox
{
    internal class Program
    {
        // Подключение внешней функции MessageBox из библиотеки User32.dll
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern int MessageBox(IntPtr hWnd, string text, string caption, uint type);

        static void Main()
        {
            // Вывод информации о себе с использованием MessageBox
            MessageBox(IntPtr.Zero, "Мене звати Денис. Я програміст з досвідом розробки веб-застосунків.", "Інформація", 0);
            MessageBox(IntPtr.Zero, "Я працюю в області штучного інтелекту та машинного навчання.", "Інформація", 0);
            MessageBox(IntPtr.Zero, "Мої мови програмування: Python, JavaScript, C#, HTML CSS.", "Інформація", 0);
            MessageBox(IntPtr.Zero, "Зацікавлений у розвитку нових технологій та роботі над складними проектами.", "Інформація", 0);
        }
    }
}