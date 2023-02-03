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

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int player;
        public MainWindow()
        {
            InitializeComponent();
            this.Height = 700;
            this.Width = 900;
            player = 1;
           // Label.Text = "Текущий ход: игрок 1";

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            switch(player)
            {
                case 1:
                    sender.GetType().GetProperty("Content").SetValue(sender, "х");
                    player = 0;
                    break;
                case 0:
                    sender.GetType().GetProperty("Content").SetValue(sender, "о");
                    player = 1;
                    break;
            }
            //MessageBox.Show(sender.GetType().GetProperty("Name").GetValue(sender).ToString());
            sender.GetType().GetProperty("Content").SetValue(sender, "x");
        }
    }
}
