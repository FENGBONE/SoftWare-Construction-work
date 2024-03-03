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

namespace calculator
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        int sum=0;
        int a, b,flag;
        //Label label = new Label();
        public MainWindow()
        {
            InitializeComponent();
            Console.WriteLine(6666);
            char c;
            while (true)
            {

            }
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            sum += sum * 10 + 1;
        }
        private void Button_Click2(object sender, RoutedEventArgs e) {
            sum += sum * 10 + 2;
        }
        private void Button_Click3(object sender, RoutedEventArgs e) {
            sum += sum * 10 + 3;
        }
        private void Button_Click4(object sender, RoutedEventArgs e) {
            sum += sum * 10 + 4;
        }
        private void Button_Click5(object sender, RoutedEventArgs e) {
            sum += sum * 10 + 5;
        }
        private void Button_Click6(object sender, RoutedEventArgs e) {
            sum += sum * 10 + 6;
        }
        private void Button_Click7(object sender, RoutedEventArgs e) {
            sum += sum * 10 + 7;
        }
        private void Button_Click8(object sender, RoutedEventArgs e) {
            sum += sum * 10 + 8;
        }
        private void Button_Click9(object sender, RoutedEventArgs e) {
            sum += sum * 10 + 9;
        }
        private void Button_Click0(object sender, RoutedEventArgs e) {
            sum += sum * 10 + 0;
        }
        private void Button_ClickAdd(object sender, RoutedEventArgs e) {
            a = sum;
            flag = 1;
            sum = 0;
        }
        private void Button_ClickSub(object sender, RoutedEventArgs e) {
            a = sum;
            flag = 2;
            sum = 0;
        }
        private void Button_ClickMul(object sender, RoutedEventArgs e) {
            a = sum;
            flag = 3;
            sum = 0;
        }
        private void Button_ClickDiv(object sender, RoutedEventArgs e) {
            a = sum;
            flag = 4;
            sum = 0;
        }
        private void Button_ClickSure(object sender, RoutedEventArgs e) {
            switch (flag)
            {
                case 1:
                    Console.WriteLine(6666);
                    break;
            }
        }
    }
}
