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

namespace MyCSTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Brand bNestle = new Brand("Nescafé", "Nestlé");



            Product pNCO = new Product("Nescafé Original", bNestle, 7613032872731, new MeasuringUnit(MeasuringUnitTypes.Gram), 100);

            LogBox.AppendText(pNCO.ToString());

        }
    }
}
