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

namespace PBKK_230915_Dashboard
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Diagram diagram = new Diagram();
            DataContext = new DiagramViewModel(diagram);
        }

        private void ButtonPower_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void GridBarTitle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private class DiagramViewModel
        {
            public List<Diagram> Diagram { get; private set; }

            public DiagramViewModel(Diagram diagram)
            {
                Diagram = new List<Diagram>();
                Diagram.Add(diagram);
            }
        }

        private class Diagram
        {
            public string Judul { get; private set; }
            public int Persentase {  get; private set; }

            public Diagram()
            {
                Judul = "Diagram Pai";
                Persentase = HitungPersentase();
            }

            private int HitungPersentase()
            {
                return 73;
            }
        }
    }
}
