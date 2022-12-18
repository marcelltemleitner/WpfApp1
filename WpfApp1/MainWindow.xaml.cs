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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<int> osszes1 = new List<int>();
        public MainWindow()
        {
            InitializeComponent();
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void csutortok_Click(object sender, RoutedEventArgs e)
        {
            int egyes = Convert.ToInt32(textbox1.Text);
            int egyes1 = Convert.ToInt32(textbox1db.Text);
            int kettes = Convert.ToInt32(textbox2.Text);
            int kettes2 = Convert.ToInt32(textbox2db.Text);
            int harmas = Convert.ToInt32(textbox3.Text);
            int harmas3 = Convert.ToInt32(textbox3db.Text);
            int negyes = Convert.ToInt32(textbox4.Text);
            int negyes4 = Convert.ToInt32(textbox4db.Text);

            int chips = egyes * egyes1;
            int kola = kettes * kettes2;
            int csoki = harmas * harmas3;
            int fank = negyes * negyes4;


            int osszes = chips + kola + csoki + fank;
            label1.Content = "Csütörtökön ennyit költöttél összesen " + osszes + "FT";
            osszes1.Add(osszes);
        }

        private void hetfo_Click(object sender, RoutedEventArgs e)
        {
            int egyes = Convert.ToInt32(textbox1.Text);
            int egyes1 = Convert.ToInt32(textbox1db.Text);
            int kettes = Convert.ToInt32(textbox2.Text);
            int kettes2 = Convert.ToInt32(textbox2db.Text);
            int harmas = Convert.ToInt32(textbox3.Text);
            int harmas3 = Convert.ToInt32(textbox3db.Text);
            int negyes = Convert.ToInt32(textbox4.Text);
            int negyes4 = Convert.ToInt32(textbox4db.Text);

            int chips = egyes * egyes1;
            int kola = kettes * kettes2;
            int csoki = harmas * harmas3;
            int fank = negyes * negyes4;

            
            int osszes = chips + kola + csoki + fank;
            label1.Content = "Hétfőn ennyit költöttél összesen "+osszes+"FT";
            osszes1.Add(osszes);
            



        }

        private void Kedd_Click(object sender, RoutedEventArgs e)
        {
            int egyes = Convert.ToInt32(textbox1.Text);
            int egyes1 = Convert.ToInt32(textbox1db.Text);
            int kettes = Convert.ToInt32(textbox2.Text);
            int kettes2 = Convert.ToInt32(textbox2db.Text);
            int harmas = Convert.ToInt32(textbox3.Text);
            int harmas3 = Convert.ToInt32(textbox3db.Text);
            int negyes = Convert.ToInt32(textbox4.Text);
            int negyes4 = Convert.ToInt32(textbox4db.Text);

            int chips = egyes * egyes1;
            int kola = kettes * kettes2;
            int csoki = harmas * harmas3;
            int fank = negyes * negyes4;


            int osszes = chips + kola + csoki + fank;
            label1.Content = "Kedden ennyit költöttél összesen " + osszes + "FT";
            osszes1.Add(osszes);
        }

        private void Szerda_Click(object sender, RoutedEventArgs e)
        {
            int egyes = Convert.ToInt32(textbox1.Text);
            int egyes1 = Convert.ToInt32(textbox1db.Text);
            int kettes = Convert.ToInt32(textbox2.Text);
            int kettes2 = Convert.ToInt32(textbox2db.Text);
            int harmas = Convert.ToInt32(textbox3.Text);
            int harmas3 = Convert.ToInt32(textbox3db.Text);
            int negyes = Convert.ToInt32(textbox4.Text);
            int negyes4 = Convert.ToInt32(textbox4db.Text);

            int chips = egyes * egyes1;
            int kola = kettes * kettes2;
            int csoki = harmas * harmas3;
            int fank = negyes * negyes4;


            int osszes = chips + kola + csoki + fank;
            label1.Content = "Szerdán ennyit költöttél összesen " + osszes + "FT";
            osszes1.Add(osszes);
        }
    

 
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int egyes = Convert.ToInt32(textbox1.Text);
            int egyes1 = Convert.ToInt32(textbox1db.Text);
            int kettes = Convert.ToInt32(textbox2.Text);
            int kettes2 = Convert.ToInt32(textbox2db.Text);
            int harmas = Convert.ToInt32(textbox3.Text);
            int harmas3 = Convert.ToInt32(textbox3db.Text);
            int negyes = Convert.ToInt32(textbox4.Text);
            int negyes4 = Convert.ToInt32(textbox4db.Text);

            int chips = egyes * egyes1;
            int kola = kettes * kettes2;
            int csoki = harmas * harmas3;
            int fank = negyes * negyes4;


            int osszes = chips + kola + csoki + fank;
            label1.Content = "Pénteken ennyit költöttél összesen " + osszes + "FT";
            osszes1.Add(osszes);
            int vegosszes = osszes1.Sum();
            veges.Content = vegosszes.ToString()+"FT";
        }
    }
}