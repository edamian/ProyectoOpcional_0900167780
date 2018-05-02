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
using Microsoft.Win32;
using System.IO;
using System.Media;
using System.Drawing.Imaging;
using System.Drawing;

namespace ProyectoOpcional_0900167780
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Cola cola;
        public MainWindow()
        {
            InitializeComponent();
            cola = new Cola();
        }

        private void btnOpenFileBrowse_Click(object sender, RoutedEventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image files (*.png;*.jpeg)|*.png;*.jpeg|All files (*.*)|*.*";
            ofd.Multiselect = true;
            
            if (ofd.ShowDialog() == true)
            {
                foreach(String filename in ofd.FileNames)
                {   
                    lstImages.Items.Add(filename);
                    cola.insertar(new Imagen(filename));
                }
            }
        }

        private void lstImages_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            String path = lstImages.SelectedItem.ToString();
            lblFilePath.Content = path;
            imgViewer.Source = new BitmapImage(new Uri(path));
        }
    }
}
