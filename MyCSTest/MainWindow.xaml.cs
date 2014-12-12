using System.Collections.Generic;
using System.Windows;
using System.Windows.Documents;

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

            List<ProductPrice> prices = new List<ProductPrice>();

            // This data will be received from a database in the future...

            Brand b0 = new Brand("Nescafé", "Nestlé");
            Brand b1 = new Brand("Milka", "Mondelez");
            Brand b2 = new Brand("Club-Mate", "Loscher");


            GeoLocation gl0 = new GeoLocation(55.686968, 12.490976);
            Store s0 = new Store("Føtex, Vanløse", "Føtex", "Jernbane Allé 44, 2720 Vanløse, Denmark", gl0);

            Store s1 = new Store("Netto, Vanløse", "Netto", "Jernbane Allé 19, 2720 Vanløse, Denmark");
            Store s2 = new Store("Døgn Netto, Vanløse (1)", "Døgn Netto", "Jernbane Allé 54, 2720 Vanløse, Denmark");
            Store s3 = new Store("Døgn Netto, Vanløse (2)", "Døgn Netto", "Jydeholmen 53, 2720 Vanløse, Denmark");

            Product p0 = new Product("Nescafé Original", b0, 7613032872731, new MeasuringUnit(MeasuringUnitType.Gram), 100);
            Product p1 = new Product("Milka Weihnachtsmischung", b1, 7622300199227, new MeasuringUnit(MeasuringUnitType.Gram), 175);
            Product p2 = new Product("Club-Mate, original, groß", b2, 4029764001807, new MeasuringUnit(MeasuringUnitType.Milliliter), 500);

            
            prices.Add(new ProductPrice(p0, s0, 80, new System.DateTime(2014, 12, 12, 21, 13, 55)));

            LogList.ItemsSource = prices;

            LogBox.AppendText("Init finished.");

        }
    }
}
