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

namespace genshinsim
{

    public partial class CharactersList : Page
    {
        public CharactersList()
        {
            InitializeComponent();
        }

        Char newChar = new Char();
        int charNum = 1;

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            newChar = new Char { Height = 26, Width = 159 };
            newChar.Name = "Char" + charNum;
            charNum = charNum + 1;
        }
    }
}
