using RRQMMVVM;
using RRQMMVVMDemo.ViewModels;
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

namespace RRQMMVVMDemo.Views.Windows
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Messenger.Default.RegistAll();
            SimpleIoc.Default.Register(this, new MainViewModel());

        }

        [RegistMethod("mes")]
        public void Message(string mes)
        {
            MessageBox.Show(mes);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send("ReturnMessage");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            RRQMMVVM.Messenger.Default.Send("ShowWindow");
        }
    }
}
