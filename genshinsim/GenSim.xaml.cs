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

namespace genshinsim
{
    public partial class GenSim : Window
    {
        public GenSim()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        int SavesNum;
        public int charNum = 1;
        Frame newFrame = new Frame() { Height = 160, Width = 110 };

        private void addFrame()
        {
            if (charNum <= 6)
            {
                newFrame = new Frame() { Height = 160, Width = 110 };
                newFrame.Content = new Char() { Name = "Char" + charNum};
                dp.Children.Add(newFrame);
            }
            if (charNum >= 6 & dp2.Children.Count < 5)
            {
                newFrame = new Frame() { Height = 160, Width = 110 };
                newFrame.Content = new Char() {Name = "Char" + charNum };
                dp2.Children.Add(newFrame);
            }
            charNum = charNum + 1;
        }

        private void btn_charl_Click(object sender, RoutedEventArgs e)
        {
            SavesNum = Convert.ToInt32(new DirectoryInfo(@"Saves").GetFiles().Length.ToString());
            frame.Visibility = Visibility.Hidden;
            btn_charl.IsEnabled = false;
            btn_charc.IsEnabled = true;
            btn_Main.IsEnabled = true;
            btn_dc.IsEnabled = true;
            dp.Visibility = Visibility.Visible;
            dp2.Visibility = Visibility.Visible;
            for (; SavesNum > 0; SavesNum--)
            {
                addFrame();
            }
        }

        private void btn_charc_Click(object sender, RoutedEventArgs e)
        {
            frame.Visibility = Visibility.Visible;
            btn_charc.IsEnabled = false;
            btn_charl.IsEnabled = true;
            btn_Main.IsEnabled = true;
            btn_dc.IsEnabled = true;
            dp.Visibility = Visibility.Hidden;
            dp2.Visibility = Visibility.Hidden;
            dp.Children.Clear();
            dp2.Children.Clear();
            charNum = 1;
            SavesNum = 0;
            frame.Content = new CharCreate();
        }

        private void btn_Main_Click(object sender, RoutedEventArgs e)
        {
            frame.Visibility = Visibility.Visible;
            btn_Main.IsEnabled = false;
            btn_charc.IsEnabled = true;
            btn_charl.IsEnabled = true;
            btn_dc.IsEnabled = true;
            dp.Visibility = Visibility.Hidden;
            dp2.Visibility = Visibility.Hidden;
            dp.Children.Clear();
            dp2.Children.Clear();
            charNum = 1;
            SavesNum = 0;
            frame.Content = new MainFrame();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            frame.Content = new MainFrame();
        }

        private void btn_dc_Click(object sender, RoutedEventArgs e)
        {
            frame.Visibility = Visibility.Visible;
            btn_Main.IsEnabled = true;
            btn_charc.IsEnabled = true;
            btn_charl.IsEnabled = true;
            btn_dc.IsEnabled = false;
            dp.Visibility = Visibility.Hidden;
            dp2.Visibility = Visibility.Hidden;
            dp.Children.Clear();
            dp2.Children.Clear();
            charNum = 1;
            SavesNum = 0;
            frame.Content = new DamageCalc();
        }

        private void cz_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                DragMove();
            }
        }
    }
}
