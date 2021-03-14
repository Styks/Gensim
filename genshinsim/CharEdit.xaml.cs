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
using System.Windows.Shapes;

namespace genshinsim
{
    public partial class CharEdit : Window
    {
        public CharEdit()
        {
            InitializeComponent();
        }

        Uri uriImageSource;
        public string BuildName;
        public string CharName;
        public string CharLvl;

        private string CharN; 
        private string Build; 
        private string b_lvl; //(=CharLvl)

        private string b_DMG; 
        private string b_crDMG; 
        private string b_clDMG;
        
        private string b_atkbase;
        private string b_atkp;
        private string b_atkflat;
        private string b_dt;
        private string b_critch;
        private string b_critdmg;
        private string b_skill;

        int DMG;
        int crDMG;
        int clDMG;
        int atkbase;
        double atkp;
        int atkflat;
        double dt;
        double critch;
        double critdmg;
        double skilldmg;
        int lvl;

        private void btn_close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lbl_build.Content = BuildName + " - " + CharName + " (" + CharLvl + ") lvl";
            lbl_buildname.Content = BuildName;
            lbl_charname.Content = CharName;
            loadbuild(@"Saves/"+ BuildName);

            tb_atkbase.Text = b_atkbase;
            tb_atkp.Text = b_atkp;
            tb_atkflat.Text = b_atkflat;
            tb_dt.Text = b_dt;
            tb_critch.Text = b_critch;
            tb_critdmg.Text = b_critdmg;
            tb_skill.Text = b_skill;
            tb_lvl.Text = b_lvl;

            switch (CharName)
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
                b_atkbase = sr.ReadLine();
                b_atkp = sr.ReadLine();
                b_atkflat = sr.ReadLine();
                b_dt = sr.ReadLine();
                b_critch = sr.ReadLine();
                b_critdmg = sr.ReadLine();
                b_skill = sr.ReadLine();               
                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show
                ("Error: " + ex.Message);
            }
        }

        private void savebuild(string filename)
        {
            if (!Directory.Exists("Saves"))
            {
                Directory.CreateDirectory("Saves");
            }
            try
            {
                StreamWriter sw = File.CreateText(filename);
                sw.WriteLine(BuildName);
                sw.WriteLine(CharName);
                sw.WriteLine(tb_lvl.Text);
                sw.WriteLine(DMG);
                sw.WriteLine(crDMG);
                sw.WriteLine(clDMG);
                sw.WriteLine(tb_atkbase.Text);
                sw.WriteLine(tb_atkp.Text);
                sw.WriteLine(tb_atkflat.Text);
                sw.WriteLine(tb_dt.Text);
                sw.WriteLine(tb_critch.Text);
                sw.WriteLine(tb_critdmg.Text);
                sw.WriteLine(tb_skill.Text);
                sw.Close();
                MessageBox.Show("Saved");
            }
            catch (Exception ex)
            {
                MessageBox.Show
                ("Error: " + ex.Message);
            }
        }
        private void btn_save_Click(object sender, RoutedEventArgs e)
        {
            DamageCalc();
            savebuild(@"Saves/" + BuildName);
            Close();
        }

        private void DamageCalc()
        {
            atkbase = Convert.ToInt32(tb_atkbase.Text);
            atkp = Convert.ToDouble(tb_atkp.Text);
            atkflat = Convert.ToInt32(tb_atkflat.Text);
            dt = Convert.ToDouble(tb_dt.Text);
            skilldmg = Convert.ToDouble(tb_skill.Text);
            lvl = Convert.ToInt32(tb_lvl.Text);
            critch = Convert.ToDouble(tb_critch.Text);
            critdmg = Convert.ToDouble(tb_critdmg.Text);

            double pa = atkbase / 100 * atkp;
            int alldmg = atkbase + Convert.ToInt32(pa) + atkflat;
            double pdt = alldmg + alldmg / 100 * dt;
            double pskill = pdt / 100 * skilldmg;

            double cratk = pskill / 100 * critdmg;
            double crchatk = pskill / 100 * critch / 100 * critdmg;

            DMG = Convert.ToInt32(pskill + crchatk) * (100 + lvl) / ((100 + lvl) + 100);
            crDMG = Convert.ToInt32(pskill + cratk) * (100 + lvl) / ((100 + lvl) + 100);
            clDMG = Convert.ToInt32(pskill) * (100 + lvl) / ((100 + lvl) + 100);
        }

        private void Rectangle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                DragMove();
            }
        }
    }  
}
