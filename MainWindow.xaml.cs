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

namespace Tema2_Imagen
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
        private void Opacidad_Click(object sender, RoutedEventArgs e)
        {
            RadioButton opTipo = (RadioButton)sender;

            if (opTipo.Tag.ToString() == "opAlta")
                imagenStarWars.Opacity = 1;
            else if (opTipo.Tag.ToString() == "opMedia")
                imagenStarWars.Opacity = 0.5;
            else 
                imagenStarWars.Opacity = 0.2; ;

        }

        private void TamanoFill_Click(object sender, RoutedEventArgs e)
        {
            RadioButton tamTipo = (RadioButton)sender;

            if (tamTipo.Tag.ToString() == "tamFill")
                imagenStarWars.Stretch = Stretch.Fill;
            else if (tamTipo.Tag.ToString() == "tamUniform")
                imagenStarWars.Stretch = Stretch.Uniform;
            else if (tamTipo.Tag.ToString() == "tamUniToFill")
                imagenStarWars.Stretch = Stretch.UniformToFill;
            else
                imagenStarWars.Stretch = Stretch.None;

        }
    }
}
