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

namespace WpfApp_Task3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            cbGalaxies.Items.Add("Milky Way");
            cbGalaxies.Items.Add("Andromeda");
            cbGalaxies.Items.Add("Magellanic Clouds");
            cbGalaxies.Items.Add("Whirlpool");
            cbGalaxies.Items.Add("Sombrero");
            cbGalaxies.SelectedIndex = 0;

            lbStarSystems.Items.Add("Solar System");
            lbStarSystems.Items.Add("Alpha Cenrauri");            
            lbStarSystems.Items.Add("Sirius");
            lbStarSystems.Items.Add("Barnard's Star");
            lbStarSystems.Items.Add("Epsilon Eridani");
            lbStarSystems.Items.Add("Procyon");
            lbStarSystems.SelectedIndex = 0;

            rbEarth.IsChecked = true;

            mainImage.Source = new BitmapImage(new Uri("Images/Earth.png", UriKind.Relative));
            tbDescr.Text = earthDescr;
        }

        private void rb_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton rbSender = (RadioButton)e.Source;
            string planet = (string)rbSender.Content;
            if (planet == "Mercury")
            {
                mainImage.Source = new BitmapImage(new Uri("Images/Mercury.png", UriKind.Relative));
                tbDescr.Text = mercuryDescr;
                return;
            }
            if (planet == "Venus")
            {
                mainImage.Source = new BitmapImage(new Uri("Images/Venus.png", UriKind.Relative));
                tbDescr.Text = venusDescr;
                return;
            }
            if (planet == "Earth")
            {
                mainImage.Source = new BitmapImage(new Uri("Images/Earth.png", UriKind.Relative));
                tbDescr.Text = earthDescr;
                return;
            }
            if (planet == "Mars")
            {
                mainImage.Source = new BitmapImage(new Uri("Images/Mars.png", UriKind.Relative));
                tbDescr.Text = marsDescr;
                return;
            }
            if (planet == "Jupiter")
            {
                mainImage.Source = new BitmapImage(new Uri("Images/Jupiter.png", UriKind.Relative));
                tbDescr.Text = jupiterDescr;
                return;
            }
            if (planet == "Saturn")
            {
                mainImage.Source = new BitmapImage(new Uri("Images/Saturn.png", UriKind.Relative));
                tbDescr.Text = saturnDescr;
                return;
            }
            if (planet == "Uranus")
            {
                mainImage.Source = new BitmapImage(new Uri("Images/Uranus.png", UriKind.Relative));
                tbDescr.Text = uranusDescr;
                return;
            }
            if (planet == "Neptune")
            {
                mainImage.Source = new BitmapImage(new Uri("Images/Neptune.png", UriKind.Relative));
                tbDescr.Text = neptuneDescr;
                return;
            }
        }

        string mercuryDescr = "\n Mean radius: 2,439.7km\n (0.3829 Earths)\n\n" +
            " Surface area: 7.48×10^7km\n (0.147 Earths)\n\n" +
            " Volume: 6.083×10^10km\n (0.056 Earths)\n\n" +
            " Mass: 3.3011×10^23 kg\n (0.055 Earths)";

        string venusDescr = "\n Mean radius: 6,051.8km\n (0.9499 Earths)\n\n" +
            " Surface area: 4.6023×10^8km\n (0.902 Earths)\n\n" +
            " Volume: 9.2843×10^11km\n (0.866 Earths)\n\n" +
            " Mass: 4.8675×10^24 kg\n (0.815 Earths)";

        string earthDescr = "\n Mean radius: 6,371.0km\n\n" +
            " Surface area: 5.101×10^8km\n\n" +
            " Volume: 1.0832×10^12km\n\n" +
            " Mass: 5.972×10^24 kg";

        string marsDescr = "\n Mean radius: 3,389.5km\n (0.533 Earths)\n\n" +
            " Surface area: 1.448×10^8km\n (0.284 Earths)\n\n" +
            " Volume: 1.6318×10^11km\n (0.151 Earths)\n\n" +
            " Mass: 6.4171×10^23 kg\n (0.107 Earths)";

        string jupiterDescr = "\n Mean radius: 69,911km\n (11.209 Earths)\n\n" +
            " Surface area: 6.142×10^10km\n (121.9 Earths)\n\n" +
            " Volume: 1.4313×10^15km\n (1,321 Earths)\n\n" +
            " Mass: 1.8986×10^27 kg\n (317.8 Earths)";

        string saturnDescr = "\n Mean radius: 58,232km\n (9.4492 Earths)\n\n" +
            " Surface area: 4.27×10^10km\n (83.703 Earths)\n\n" +
            " Volume: 8.2713×10^14km\n (763.59 Earths)\n\n" +
            " Mass: 5.6836×10^26 kg\n (95.159 Earths)";

        string uranusDescr = "\n Mean radius: 25,362km\n (4.007 Earths)\n\n" +
            " Surface area: 8.1156×10^9km\n (15.91 Earths)\n\n" +
            " Volume: 6.833×10^13km\n (63.086 Earths)\n\n" +
            " Mass: 8.6810×10^25 kg\n (14.536 Earths)";

        string neptuneDescr = "\n Mean radius: 24,622km\n (3.883 Earths)\n\n" +
            " Surface area: 7.6183×10^9km\n (14.98 Earths)\n\n" +
            " Volume: 6.254×10^13km\n (57.74 Earths)\n\n" +
            " Mass: 1.0243×10^26 kg\n (17.147 Earths)";

    }
}
