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

    public partial class CharCreate : Page
    {
        public CharCreate()
        {
            InitializeComponent();
        }

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


        private void savebuild(string filename)
        {
            if (!Directory.Exists("Saves"))
            {
                Directory.CreateDirectory("Saves");
            }
            try
            {
                StreamWriter sw = File.CreateText(filename);
                sw.WriteLine(tb_buildname.Text);
                sw.WriteLine(cb_char.Text);
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
           string fname = tb_buildname.Text;
           savebuild(fname);
           string path = fname;
           string newPath = @"Saves\"+fname+"";
           File.Move(path, newPath);
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
            clDMG = Convert.ToInt32(pskill)*(100+lvl)/((100+lvl)+100);
        }

        private void calc_btn_Click(object sender, RoutedEventArgs e)
        {
            DamageCalc();
            calc.Content = DMG;
            calc2.Content = crDMG;
            calc3.Content = clDMG;
        }
    }
}
