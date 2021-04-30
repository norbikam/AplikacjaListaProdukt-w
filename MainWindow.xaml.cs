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
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace AplikacjaListaProduktów
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Produkt> ListaProduktow = null;
        public MainWindow()
        {
            InitializeComponent();
            PrzygotujWiazanie();
        }
        private void PrzygotujWiazanie()
        {
            ListaProduktow = new ObservableCollection<Produkt>();
            ListaProduktow.Add(new Produkt("01-11", "ołowek", 8, "Słupsk"));
            ListaProduktow.Add(new Produkt("PW-20", "pióro wieczne", 75, "Gdańsk"));
            ListaProduktow.Add(new Produkt("W-20", "zeszyt 32kart", 200, "Warszawa"));
            ListaProduktow.Add(new Produkt("W-10", "zeszyt 16kart", 100, "Słupsk2"));
            ListaProduktow.Add(new Produkt("W-30", "zeszyt 64kart", 400, "Słupsk2"));
            ListaProduktow.Add(new Produkt("W-15", "blok techniczny", 100, "Słupsk"));
            ListaProduktow.Add(new Produkt("W-05", "blok rysunkowy", 150, "Słupsk2"));
            lstProdukty.ItemsSource = ListaProduktow;
            CollectionView widok = (CollectionView)CollectionViewSource.GetDefaultView(lstProdukty.ItemsSource);
            widok.SortDescriptions.Add(new SortDescription("Magazyn", ListSortDirection.Ascending));
            widok.SortDescriptions.Add(new SortDescription("Nazwa", ListSortDirection.Ascending));
        }
    }
}
