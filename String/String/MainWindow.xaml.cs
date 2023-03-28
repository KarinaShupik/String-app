using System;
using System.Collections.Generic;
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

namespace String
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_res_Click(object sender, RoutedEventArgs e)
        {
            string input = txt_input.Text;

            /*Створюється порожній словник charCount, який буде містити кількість
             * входжень кожного символу у заданому рядку.*/
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            /*Ми проходимо по кожному символу у заданому рядку (input), перевіряємо,
             * чи вже додали ми цей символ до словника. Якщо так, то збільшуємо
             * кількість його входжень на 1, якщо ні - то додаємо символ до словника 
             * з початковою кількістю 1.*/
            foreach (char c in input)
            {
                if (charCount.ContainsKey(c))
                {
                    charCount[c]++;
                }
                else
                {
                    charCount.Add(c, 1);
                }
            }
            /*використовуємо цикл foreach для перебору всіх ключів та значень в 
             * словнику charCount і виводимо кожен символ та його кількість входжень у рядок.*/
            string txt = "";
            foreach (KeyValuePair<char, int> kvp in charCount)
            {
                txt += $"Символ {kvp.Key} з'являється {kvp.Value} разів у рядку \n";
            }

            MessageBox.Show(txt);
        }
    }
}
