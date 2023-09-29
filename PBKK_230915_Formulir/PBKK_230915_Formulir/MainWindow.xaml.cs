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
using System.Xml.Linq;

namespace PBKK_230915_Formulir
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TombolTambahNama_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(teksNama.Text) && !dftrNama.Items.Contains(teksNama.Text))
            {
                dftrNama.Items.Add(teksNama.Text);
                teksNama.Clear();
                pesan.Content = "Nama tersimpan";
            }
            else
            {
                pesan.Content = "Tidak boleh kosong atau duplikat";
            }
        }
    }
}
