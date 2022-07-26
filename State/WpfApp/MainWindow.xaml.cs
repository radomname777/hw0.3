
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
using WpfAnimatedGif;
using WpfApp.ViewModel;

namespace WpfApp
{

    public partial class MainWindow : Window
    {
        private MainViewModel MVM { get; set; }
        public MainWindow()
        {
           
            InitializeComponent();
            MVM = new MainViewModel(this);
            DataContext = MVM;

        }
    }
}
