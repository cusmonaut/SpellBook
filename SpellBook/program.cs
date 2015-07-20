using System;
using System.Windows.Forms;

namespace MysticReference
{
    internal class program
    {
        public static Form mainForm = new Book();

        [STAThread]
        public static void Main()
        {
            mainForm.ShowDialog();
        }
    }
}