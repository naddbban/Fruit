using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using UTS.Controller;
using UTS.Model;

namespace UTS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, BucketEventListener
    {
        Seller nad;
        public MainWindow()
        {
            InitializeComponent();
            Bucket keranjang = new Bucket(2);
            BucketController bucketController = new BucketController(keranjang, this);

            nad = new Seller("Nad", bucketController);

            listBoxBucket.ItemsSource = keranjang.findAll();
        }

        public void onFailed(string message)
        {
            MessageBox.Show(message, "warning");
        }

        public void onSucced(string message)
        {
            listBoxBucket.Items.Refresh();
        }

        private void OnButtonAnggurClicked(object sender, RoutedEventArgs e)
        {
            Fruit anggur = new Fruit("Anggur");
            nad.addFruit(anggur);
        }

        private void OnButtonAppleClicked(object sender, RoutedEventArgs e)
        {
            Fruit apple = new Fruit("Apel");
            nad.addFruit(apple);
        }

        private void OnButtonBananaClicked(object sender, RoutedEventArgs e)
        {
            Fruit banana = new Fruit("Banana");
            nad.addFruit(banana);
        }

        private void OnButtonOrangeClicked(object sender, RoutedEventArgs e)
        {
            Fruit orange = new Fruit("Orange");
            nad.addFruit(orange);
        }
    }
}
