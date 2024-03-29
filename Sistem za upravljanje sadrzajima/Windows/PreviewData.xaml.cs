using Sistem_za_upravljanje_sadrzajima.Classes;
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
using System.Windows.Shapes;

namespace Sistem_za_upravljanje_sadrzajima.Windows
{
    /// <summary>
    /// Interaction logic for PreviewData.xaml
    /// </summary>
    public partial class PreviewData : Window
    {
        public Club club = new Club();
        public PreviewData(int index)
        {
            InitializeComponent();

            club = DataGridTable.Clubs[index];
            Name_tb.Text = club.Name;
            Id_tb.Text = club.Id.ToString();
            AddImage_img.Source = new BitmapImage(new Uri(club.Picture, UriKind.RelativeOrAbsolute));

            TextRange textRange;
            System.IO.FileStream fileStream;
            if (System.IO.File.Exists(club.Rtf))
            {
                textRange = new TextRange(AddRtf_rtf.Document.ContentStart, AddRtf_rtf.Document.ContentEnd);
                using (fileStream = new System.IO.FileStream(club.Rtf, System.IO.FileMode.OpenOrCreate))
                {
                    textRange.Load(fileStream, System.Windows.DataFormats.Rtf);
                }
            }
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void ExitPreview_btn_Click(object sender, RoutedEventArgs e)
        {
            var dgt = new DataGridTable();
            dgt.Add_btn.Visibility = Visibility.Hidden;
            dgt.Delete_btn.Visibility = Visibility.Hidden;
            dgt.Show();
            Close();
        }

        private void UpdateStatusBar()
        {
            string text = new TextRange(AddRtf_rtf.Document.ContentStart, AddRtf_rtf.Document.ContentEnd).Text;

            string[] words = text.Split(new char[] { ' ', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            int wordCount = words.Length;

            NumberOfWords_rtf.Text = $"{wordCount}";
        }

        private void AddRtf_rtf_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateStatusBar();
        }
    }
}
