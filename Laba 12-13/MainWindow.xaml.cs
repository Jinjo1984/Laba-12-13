using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using контрольная_2;

namespace Laba_12_13
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
           // InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

            string num;
            Utilites utilites = new Utilites();
            using (StreamWriter writerFile = new StreamWriter("C:\\Users\\Georgiy\\Documents\\Лаба\\Laba 12-13\\Laba 12-13\\Files\\Исходный файл.txt", false))
            {
                writerFile.Write(utilites.CompleteRandomStr(1000));
                writerFile.Close();
                using (StreamReader file = new StreamReader("C:\\Users\\Georgiy\\Documents\\Лаба\\Laba 12-13\\Laba 12-13\\Files\\Исходный файл.txt"))
                {
                    num = file.ReadToEnd();
                }
            }
            string chet = "";
            string nechet = "";
            string str = "";
            for(int i = 0; i < num.Length; i++)
            {
                if (char.IsNumber(num[i]))
                {
                    if(Convert.ToInt32(num[i]) % 2 == 0)
                    {
                        chet += num[i];
                    }
                    else
                    {
                        nechet += num[i];
                    }
                }
                else
                {
                    str += num[i];
                }
            }
            using(StreamWriter files = new StreamWriter("C:\\Users\\Georgiy\\Documents\\Лаба\\Laba 12-13\\Laba 12-13\\Files\\chet.txt", false))
            {
                files.Write(chet);
            }
            using (StreamWriter files = new StreamWriter("C:\\Users\\Georgiy\\Documents\\Лаба\\Laba 12-13\\Laba 12-13\\Files\\nechet.txt", false))
            {
                files.Write(nechet);
            }
            using (StreamWriter files = new StreamWriter("C:\\Users\\Georgiy\\Documents\\Лаба\\Laba 12-13\\Laba 12-13\\Files\\str.txt", false))
            {
                files.Write(str);
            }
        }
    }
}
