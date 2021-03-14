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
    public partial class Char : Page
    {
        public Char()
        {
            InitializeComponent();
        }
        
        List<String> filesname = Directory.GetFiles(@"Saves").ToList<string>();
        public string fileN;

        Uri uriImageSource;

        public string CharN;
        public string Build;
        public string b_lvl;
        public string b_DMG;
        public string b_crDMG;
        public string b_clDMG;

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (string i in filesname)
            {
                fileN += i + ";";
            }
            string[] mass = fileN.Split(';');

            if (Name == "Char1")
            {
                loadbuild(mass[0]);
                lbl_Char.Content = CharN + " " + b_lvl + " lvl";
                lbl_Build.Content = Build;
                DMG.Content = b_DMG;
                crDMG.Content = b_crDMG;
                clDMG.Content = b_clDMG;
            }
            if (Name == "Char2")
            {
                loadbuild(mass[1]);
                lbl_Char.Content = CharN + " " + b_lvl + " lvl";
                lbl_Build.Content = Build;
                DMG.Content = b_DMG;
                crDMG.Content = b_crDMG;
                clDMG.Content = b_clDMG;
            }
            if (Name == "Char3")
            {
                loadbuild(mass[2]);
                lbl_Char.Content = CharN + " " + b_lvl + " lvl";
                lbl_Build.Content = Build;
                DMG.Content = b_DMG;
                crDMG.Content = b_crDMG;
                clDMG.Content = b_clDMG;
            }
            if (Name == "Char4")
            {
                loadbuild(mass[3]);
                lbl_Char.Content = CharN + " " + b_lvl + " lvl";
                lbl_Build.Content = Build;
                DMG.Content = b_DMG;
                crDMG.Content = b_crDMG;
                clDMG.Content = b_clDMG;
            }
            if (Name == "Char5")
            {
                loadbuild(mass[4]);
                lbl_Char.Content = CharN + " " + b_lvl + " lvl";
                lbl_Build.Content = Build;
                DMG.Content = b_DMG;
                crDMG.Content = b_crDMG;
                clDMG.Content = b_clDMG;
            }
            if (Name == "Char6")
            {
                loadbuild(mass[5]);
                lbl_Char.Content = CharN + " " + b_lvl + " lvl";
                lbl_Build.Content = Build;
                DMG.Content = b_DMG;
                crDMG.Content = b_crDMG;
                clDMG.Content = b_clDMG;
            }
            if (Name == "Char7")
            {
                loadbuild(mass[6]);
                lbl_Char.Content = CharN + " " + b_lvl + " lvl"; ;
                lbl_Build.Content = Build;
                DMG.Content = b_DMG;
                crDMG.Content = b_crDMG;
                clDMG.Content = b_clDMG;
            }
            if (Name == "Char8")
            {
                loadbuild(mass[7]);
                lbl_Char.Content = CharN + " " + b_lvl + " lvl";
                lbl_Build.Content = Build;
                DMG.Content = b_DMG;
                crDMG.Content = b_crDMG;
                clDMG.Content = b_clDMG;
            }
            if (Name == "Char9")
            {
                loadbuild(mass[8]);
                lbl_Char.Content = CharN + " " + b_lvl + " lvl";
                lbl_Build.Content = Build;
                DMG.Content = b_DMG;
                crDMG.Content = b_crDMG;
                clDMG.Content = b_clDMG;
            }
            if (Name == "Char10")
            {
                loadbuild(mass[9]);
                lbl_Char.Content = CharN + " " + b_lvl + " lvl";
                lbl_Build.Content = Build;
                DMG.Content = b_DMG;
                crDMG.Content = b_crDMG;
                clDMG.Content = b_clDMG;
            }

            infoChar.Text = CharN;

            switch (CharN)
            {
                case "Albedo":
                    uriImageSource = new Uri(@"design/characters/Albedo.png", UriKind.RelativeOrAbsolute);
                    img_Char.Source = new BitmapImage(uriImageSource);
                    break;
                case "Amber":
                    uriImageSource = new Uri(@"design/characters/Amber.png", UriKind.RelativeOrAbsolute);
                    img_Char.Source = new BitmapImage(uriImageSource);
                    break;
                case "Ayaka(Unreleased)":
                    uriImageSource = new Uri(@"design/characters/Ayaka.png", UriKind.RelativeOrAbsolute);
                    img_Char.Source = new BitmapImage(uriImageSource);
                    break;
                case "Barbara":
                    uriImageSource = new Uri(@"design/characters/Barbara.png", UriKind.RelativeOrAbsolute);
                    img_Char.Source = new BitmapImage(uriImageSource);
                    break;
                case "Beidou":
                    uriImageSource = new Uri(@"design/characters/Beidou.png", UriKind.RelativeOrAbsolute);
                    img_Char.Source = new BitmapImage(uriImageSource);
                    break;
                case "Bennett":
                    uriImageSource = new Uri(@"design/characters/Bennett.png", UriKind.RelativeOrAbsolute);
                    img_Char.Source = new BitmapImage(uriImageSource);
                    break;
                case "Chongyun":
                    uriImageSource = new Uri(@"design/characters/Chongyun.png", UriKind.RelativeOrAbsolute);
                    img_Char.Source = new BitmapImage(uriImageSource);
                    break;
                case "Diluc":
                    uriImageSource = new Uri(@"design/characters/Diluc.png", UriKind.RelativeOrAbsolute);
                    img_Char.Source = new BitmapImage(uriImageSource);
                    break;
                case "Diona":
                    uriImageSource = new Uri(@"design/characters/Diona.png", UriKind.RelativeOrAbsolute);
                    img_Char.Source = new BitmapImage(uriImageSource);
                    break;
                case "Fischl":
                    uriImageSource = new Uri(@"design/characters/Fischl.png", UriKind.RelativeOrAbsolute);
                    img_Char.Source = new BitmapImage(uriImageSource);
                    break;
                case "Ganyu":
                    uriImageSource = new Uri(@"design/characters/Ganyu.png", UriKind.RelativeOrAbsolute);
                    img_Char.Source = new BitmapImage(uriImageSource);
                    break;
                case "Jean":
                    uriImageSource = new Uri(@"design/characters/Jean.png", UriKind.RelativeOrAbsolute);
                    img_Char.Source = new BitmapImage(uriImageSource);
                    break;
                case "Kaeya":
                    uriImageSource = new Uri(@"design/characters/Kaeya.png", UriKind.RelativeOrAbsolute);
                    img_Char.Source = new BitmapImage(uriImageSource);
                    break;
                case "Keqing":
                    uriImageSource = new Uri(@"design/characters/Keqing.png", UriKind.RelativeOrAbsolute);
                    img_Char.Source = new BitmapImage(uriImageSource);
                    break;
                case "Klee":
                    uriImageSource = new Uri(@"design/characters/Klee.png", UriKind.RelativeOrAbsolute);
                    img_Char.Source = new BitmapImage(uriImageSource);
                    break;
                case "Lisa":
                    uriImageSource = new Uri(@"design/characters/Lisa.png", UriKind.RelativeOrAbsolute);
                    img_Char.Source = new BitmapImage(uriImageSource);
                    break;
                case "Mona":
                    uriImageSource = new Uri(@"design/characters/Mona.png", UriKind.RelativeOrAbsolute);
                    img_Char.Source = new BitmapImage(uriImageSource);
                    break;
                case "Ningguang":
                    uriImageSource = new Uri(@"design/characters/Ningguang.png", UriKind.RelativeOrAbsolute);
                    img_Char.Source = new BitmapImage(uriImageSource);
                    break;
                case "Noelle":
                    uriImageSource = new Uri(@"design/characters/Noelle.png", UriKind.RelativeOrAbsolute);
                    img_Char.Source = new BitmapImage(uriImageSource);
                    break;
                case "Qiqi":
                    uriImageSource = new Uri(@"design/characters/Qiqi.png", UriKind.RelativeOrAbsolute);
                    img_Char.Source = new BitmapImage(uriImageSource);
                    break;
                case "Razor":
                    uriImageSource = new Uri(@"design/characters/Razor.png", UriKind.RelativeOrAbsolute);
                    img_Char.Source = new BitmapImage(uriImageSource);
                    break;
                case "Rosaria(Unreleased)":
                    uriImageSource = new Uri(@"design/characters/Rosaria.png", UriKind.RelativeOrAbsolute);
                    img_Char.Source = new BitmapImage(uriImageSource);
                    break;
                case "Sucrose":
                    uriImageSource = new Uri(@"design/characters/Sucrose.png", UriKind.RelativeOrAbsolute);
                    img_Char.Source = new BitmapImage(uriImageSource);
                    break;
                case "Tartaglia":
                    uriImageSource = new Uri(@"design/characters/Tartaglia.png", UriKind.RelativeOrAbsolute);
                    img_Char.Source = new BitmapImage(uriImageSource);
                    break;
                case "Traveler":
                    uriImageSource = new Uri(@"design/characters/Traveler.png", UriKind.RelativeOrAbsolute);
                    img_Char.Source = new BitmapImage(uriImageSource);
                    break;
                case "Venti":
                    uriImageSource = new Uri(@"design/characters/Venti.png", UriKind.RelativeOrAbsolute);
                    img_Char.Source = new BitmapImage(uriImageSource);
                    break;
                case "Xiangling":
                    uriImageSource = new Uri(@"design/characters/Xiangling.png", UriKind.RelativeOrAbsolute);
                    img_Char.Source = new BitmapImage(uriImageSource);
                    break;
                case "Xiao":
                    uriImageSource = new Uri(@"design/characters/Xiao.png", UriKind.RelativeOrAbsolute);
                    img_Char.Source = new BitmapImage(uriImageSource);
                    break;
                case "Xingqiu":
                    uriImageSource = new Uri(@"design/characters/Xingqiu.png", UriKind.RelativeOrAbsolute);
                    img_Char.Source = new BitmapImage(uriImageSource);
                    break;
                case "Xinyan":
                    uriImageSource = new Uri(@"design/characters/Xinyan.png", UriKind.RelativeOrAbsolute);
                    img_Char.Source = new BitmapImage(uriImageSource);
                    break;
                case "Zhongli":
                    uriImageSource = new Uri(@"design/characters/Zhongli.png", UriKind.RelativeOrAbsolute);
                    img_Char.Source = new BitmapImage(uriImageSource);
                    break;
            }
        }



        private void loadbuild(string buildname)
        {
            try
            {
                StreamReader sr = File.OpenText(buildname);
                Build = sr.ReadLine();
                CharN = sr.ReadLine();
                b_lvl = sr.ReadLine();
                b_DMG = sr.ReadLine();
                b_crDMG = sr.ReadLine();
                b_clDMG = sr.ReadLine();
                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show
                ("Error: " + ex.Message);
            }
        }

        private void btn_del_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult mbr = MessageBox.Show("Are you sure?", "Delete Confirmation", MessageBoxButton.YesNo);
            if (mbr == MessageBoxResult.Yes)
            {
                string fPath = @"Saves\" + Build + "";
                File.Delete(fPath);
                del_frame.Visibility = Visibility.Visible;
                del_lbl.Content = "Build deleted";
                del_lbl.Visibility = Visibility.Visible;
            }
        }

        private void btn_edit_Click(object sender, RoutedEventArgs e)
        {
            CharEdit ce = new CharEdit
            {
                BuildName = Build,
                CharName = CharN,
                CharLvl = b_lvl
            };
            ce.ShowDialog();

            del_frame.Visibility = Visibility.Visible;
            del_lbl.Content = "Build edited";
            del_lbl.Visibility = Visibility.Visible;
        }
    }
}
