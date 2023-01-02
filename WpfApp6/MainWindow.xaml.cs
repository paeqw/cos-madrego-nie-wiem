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

namespace WpfApp6
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
        public string odwroc(string doOdwrocenia)
        {
            char[] a = doOdwrocenia.ToCharArray();
            char[] wyjscie = new char[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                wyjscie[a.Length-1 - i] = a[i];
            }
            return new string(wyjscie);
        }
        private void aa_Click(object sender, RoutedEventArgs e)
        {
            if (big.IsChecked == true)
            {
                textOut.Text = textIn.Text.ToUpper();
            }
            if (small.IsChecked == true)
            {
                textOut.Text = textIn.Text.ToLower();
            }
            if (naLiczby.IsChecked == true)
            {
                var znaki = new Dictionary<char, char>()
                {
                    {'a','4'},
                    {'b','5'},
                    {'s','$'},
                    {'e','3'},
                    {'o','0'},
                    {'i','1'},
                    {'l','7'}
                };
                char[] tab = textIn.Text.ToLower().ToCharArray();
                for(int i = 0; i < tab.Length; i++)
                {
                    foreach(KeyValuePair<char,char> ele in znaki)
                    {
                        if (ele.Key == tab[i]) tab[i] = ele.Value;
                    }
                }
                textOut.Text = new string(tab);
            }
            if(palindrom.IsChecked == true)
            {
                string bezSpacji = textIn.Text.Replace(" ", "");
                if (odwroc(bezSpacji).SequenceEqual(bezSpacji))
                {
                    textOut.Text = "tak";
                }
                else textOut.Text = "nie";
            }
            if (ile.IsChecked == true)
            {
                string a = textIn.Text.Replace(" ", "");
                textOut.Text = Convert.ToString(a.Length);
            }

            if (naPrzemian.IsChecked == true) {
                char[] tab = textIn.Text.ToCharArray();
                for (int i = 0; i < tab.Length; i++) {
                    if (tab[i] == ' ') { continue; }
                    else if (i % 2 != 0) { tab[i] = Convert.ToChar(Convert.ToString(tab[i]).ToUpper()); }
                    else { tab[i] = Convert.ToChar(Convert.ToString(tab[i]).ToLower()); }
                }
                textOut.Text = new string(tab);
            }
        }
    }
}
