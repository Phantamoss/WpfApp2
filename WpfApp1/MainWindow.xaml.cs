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
        VectorMbTilesProvider MapProvider;
        public MainWindow()
        {
            InitializeComponent();

            var mainDir = "C:/FieldInventoryFiles/";
            MapProvider = new VectorMbTilesProvider(@"tiles/unitedStates.mbtiles", mainDir + @"styles/basic-style.json", mainDir + @"tile-cache/");


            MainMap.MapProvider = MapProvider;

        }
    }
}
