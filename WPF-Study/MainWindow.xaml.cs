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

namespace WPF_Study
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, Abstractions.IView
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public string TextBox { get => tbxValue.Text; set => tbxValue.Text = value; }
        public string ImgName { get; set; }
        public string ChangedImg { get; set; }

        public void HomeB()
        {
            var solorBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF042A42"));
            var changeBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF0E9CF5"));
            bHome.Background = changeBrush;
            bEmail.Background = solorBrush;
            bCloud.Background = solorBrush;
            bHome.BorderBrush = changeBrush;
            bEmail.BorderBrush = solorBrush;
            bCloud.BorderBrush = solorBrush;
        }
        public void HomeI()
        {
            string t = "https://cdn-icons-png.flaticon.com/512/1946/1946436.png";
            imgHome.Source = new ImageSourceConverter().ConvertFromString(t) as ImageSource;
            ChangedImg = "https://rocketuniform.ru/wp-content/uploads/2021/06/Mail-letter-icon-blue-1024x1024-1.png";
            imgEmail.Source = new ImageSourceConverter().ConvertFromString(ChangedImg) as ImageSource;
            ChangedImg = "https://cdn-icons-png.flaticon.com/512/1214/1214753.png";
            imgCloud.Source = new ImageSourceConverter().ConvertFromString(ChangedImg) as ImageSource;
        }
        public void EmailB()
        {
            var solorBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF042A42"));
            var changeBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF0E9CF5"));
            bEmail.Background = changeBrush;
            bHome.Background = solorBrush;
            bCloud.Background = solorBrush;
            bEmail.BorderBrush = changeBrush;
            bHome.BorderBrush = solorBrush;
            bCloud.BorderBrush = solorBrush;
        }
        public void EmailI()
        {
            string t = "https://cdn-icons-png.flaticon.com/512/646/646135.png";
            imgEmail.Source = new ImageSourceConverter().ConvertFromString(t) as ImageSource;
            ChangedImg = "https://cdn-icons-png.flaticon.com/512/1214/1214753.png";
            imgCloud.Source = new ImageSourceConverter().ConvertFromString(ChangedImg) as ImageSource;
            ChangedImg = "https://images.vexels.com/media/users/3/223204/isolated/preview/a603755020e70576e1f4a08b012835d4-design-plano-de-icone-de-casa.png";
            imgHome.Source = new ImageSourceConverter().ConvertFromString(ChangedImg) as ImageSource;
        }
        public void CloudB()
        {
            var solorBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF042A42"));
            var changeBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF0E9CF5"));
            bCloud.Background = changeBrush;
            bEmail.Background = solorBrush;
            bHome.Background = solorBrush;
            bCloud.BorderBrush = changeBrush;
            bEmail.BorderBrush = solorBrush;
            bHome.BorderBrush = solorBrush;
        }
        public void CloudI()
        {
            string t = "https://cdn-icons.flaticon.com/png/512/656/premium/656974.png?token=exp=1653756692~hmac=11190ac54500e54db000d7266757c1d1";
            imgCloud.Source = new ImageSourceConverter().ConvertFromString(t) as ImageSource;
            ChangedImg = "https://images.vexels.com/media/users/3/223204/isolated/preview/a603755020e70576e1f4a08b012835d4-design-plano-de-icone-de-casa.png";
            imgHome.Source = new ImageSourceConverter().ConvertFromString(ChangedImg) as ImageSource;
            ChangedImg = "https://rocketuniform.ru/wp-content/uploads/2021/06/Mail-letter-icon-blue-1024x1024-1.png";
            imgEmail.Source = new ImageSourceConverter().ConvertFromString(ChangedImg) as ImageSource;
        }
        private void Bhome_Click(object sender, RoutedEventArgs e)
        {
            tbxValue.Text = "Home";
            ImgName = "https://cdn-icons-png.flaticon.com/512/63/63633.png";
            mainImg.Source = new ImageSourceConverter().ConvertFromString(ImgName) as ImageSource;
            HomeB();
            HomeI();
        }

        private void Bmail_Click(object sender, RoutedEventArgs e)
        {
            tbxValue.Text = "Email";
            ImgName = "https://cdn-icons-png.flaticon.com/512/37/37572.png";
            mainImg.Source = new ImageSourceConverter().ConvertFromString(ImgName) as ImageSource;
            EmailB();
            EmailI();
        }

        private void Bcloud_Click(object sender, RoutedEventArgs e)
        {
            tbxValue.Text = "Cloud";
            ImgName = "https://cdn-icons-png.flaticon.com/512/1160/1160418.png";
            mainImg.Source = new ImageSourceConverter().ConvertFromString(ImgName) as ImageSource;
            CloudB();
            CloudI();
        }
    }
}
