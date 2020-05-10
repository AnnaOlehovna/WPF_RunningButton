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

namespace RunningButton
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RunningButton_MouseEnter(object sender, MouseEventArgs e)
        {
            Point p = Mouse.GetPosition(myCanvas);
            Random R = new Random();

            Canvas.SetTop(RunningButton, R.Next(0, (int)(myCanvas.Height - RunningButton.Height)));
            Canvas.SetLeft(RunningButton, R.Next(0, (int)(myCanvas.Width - RunningButton.Width)));
        }
    }
}
