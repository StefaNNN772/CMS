using Microsoft.Win32;
using Notification.Wpf;
using Sistem_za_upravljanje_sadrzajima.Classes;
using Sistem_za_upravljanje_sadrzajima.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for AddFootballClub.xaml
    /// </summary>
    public partial class AddFootballClub : Window
    {
        public ObservableCollection<Club> Clubs { get; set; }

        int i;

        public Club club = new Club();

        private DataIO serializer = new DataIO();

        private string path = "";

        private NotificationManager notificationManager;

        public AddFootballClub(int index = -1)
        {
            InitializeComponent();

            if (index != -1)
            {
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

                path = club.Picture;
            }
            else
            {
                Id_tb.Text = "Input ID";
                Id_tb.Foreground = Brushes.LightSlateGray;
                Name_tb.Text = "Input name";
                Name_tb.Foreground = Brushes.LightSlateGray;
            }

            notificationManager = new NotificationManager();

            Clubs = serializer.DeSerializeObject<ObservableCollection<Club>>("Clubs.xml");

            if (Clubs == null)
            {
                Clubs = new ObservableCollection<Club>();
            }

            FontFamily_cb.ItemsSource = Fonts.SystemFontFamilies.OrderBy(f => f.Source);

            for (double i = 7; i <= 70; i++)
            {
                FontSize_cb.Items.Add(i);
            }

            foreach (var property in typeof(Colors).GetProperties())
            {
                string colorName = property.Name;
                Color colorValue = (Color)property.GetValue(null);

                ComboBoxItem comboBoxItem = new ComboBoxItem();
                comboBoxItem.Content = colorName;
                comboBoxItem.Background = new SolidColorBrush(colorValue);

                FontColor_cb.Items.Add(comboBoxItem);
            }

            DataContext = this;

            i = index;
        }

        public void ShowToastNotification(ToastNotification toastNotification)
        {
            notificationManager.Show(toastNotification.Title, toastNotification.Message, toastNotification.Type, "WindowNotificationAreaAddingError");
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void ExitAdding_btn_Click(object sender, RoutedEventArgs e)
        {
            var dataGridtable = new DataGridTable();
            dataGridtable.Show();
            Close();
        }

        private void AddNew_btn_Click(object sender, RoutedEventArgs e)
        {
            if (i == -1)
            {
                if (Validation())
                {
                    var dgt = new DataGridTable();
                    string details = Name_tb.Text + ".rtf";
                    string pic = "../../Image/Football clubs/" + System.IO.Path.GetFileName(path);
                    DataGridTable.Clubs.Add(new Club(Int32.Parse(Id_tb.Text), Name_tb.Text, pic, details));

                    TextRange textRange;
                    FileStream fileStream;

                    textRange = new TextRange(AddRtf_rtf.Document.ContentStart, AddRtf_rtf.Document.ContentEnd);
                    fileStream = new FileStream(details, FileMode.Create);
                    textRange.Save(fileStream, DataFormats.Rtf);

                    serializer.SerializeObject<ObservableCollection<Club>>(DataGridTable.Clubs, "Clubs.xml");
                    fileStream.Close();

                    this.Close();
                    dgt.Show();
                    dgt.ShowToastNotification(new ToastNotification("Succes", "Football club added", NotificationType.Success));
                }
            }
            else
            {
                if (Validation())
                {
                    var dgt = new DataGridTable();
                    string details = Name_tb.Text + ".rtf";
                    string pic = "../../Image/Football clubs/" + System.IO.Path.GetFileName(path);
                    DataGridTable.Clubs[i] = new Club(Int32.Parse(Id_tb.Text), Name_tb.Text, pic, details);

                    TextRange textRange;
                    FileStream fileStream;

                    textRange = new TextRange(AddRtf_rtf.Document.ContentStart, AddRtf_rtf.Document.ContentEnd);
                    fileStream = new FileStream(details, FileMode.Create);
                    textRange.Save(fileStream, DataFormats.Rtf);

                    serializer.SerializeObject<ObservableCollection<Club>>(DataGridTable.Clubs, "Clubs.xml");
                    fileStream.Close();

                    this.Close();
                    dgt.Show();
                    dgt.ShowToastNotification(new ToastNotification("Succes", "Football club updated", NotificationType.Success));
                }
            }
        }

        public bool Validation()
        {
            bool isValid = true;

            if (Id_tb.Text.Trim().Equals(string.Empty))
            {
                isValid = false;
                Id_error.Content = "Form field can't be left empty!";
                Id_tb.BorderBrush = Brushes.Red;
            }
            else if (Id_tb.Text.Trim().Equals("Input ID"))
            {
                isValid = false;
                Id_error.Content = "Form field can't be 'Input ID'!";
                Id_tb.BorderBrush = Brushes.Red;
            }
            else
            {
                Id_error.Content = string.Empty;
                Id_tb.BorderBrush = Brushes.Gray;
            }

            if (Name_tb.Text.Trim().Equals(string.Empty))
            {
                isValid = false;
                Name_error.Content = "Form field can't be left empty!";
                Name_tb.BorderBrush = Brushes.Red;
            }
            else if (Name_tb.Text.Trim().Equals("Input name"))
            {
                isValid = false;
                Name_error.Content = "Form field can't be 'Input name'!";
                Name_tb.BorderBrush = Brushes.Red;
            }
            else
            {
                Name_error.Content = string.Empty;
                Name_tb.BorderBrush = Brushes.Gray;
            }

            if (i == -1)
            {
                foreach (Club club in Clubs)
                {
                    if (Id_tb.Text == club.Id.ToString())
                    {
                        isValid = false;

                        Id_error.Content = "ID already exists";
                        Id_tb.BorderBrush = Brushes.Red;
                    }
                }

                if (isValid == false)
                {
                    this.ShowToastNotification(new ToastNotification("Error", "Football club can't be added", NotificationType.Error));
                }
            }
            else
            {
                if (isValid == false)
                {
                    this.ShowToastNotification(new ToastNotification("Error", "Football club can't be updated", NotificationType.Error));
                }
            }

            return isValid;
        }

        private void AddRtf_rtf_SelectionChanged(object sender, RoutedEventArgs e)
        {
            object fontBold = AddRtf_rtf.Selection.GetPropertyValue(Inline.FontWeightProperty);
            Bold_btn.IsChecked = (fontBold != DependencyProperty.UnsetValue) && (fontBold.Equals(FontWeights.Bold));

            object fontItalic = AddRtf_rtf.Selection.GetPropertyValue(Inline.FontStyleProperty);
            Italic_btn.IsChecked = (fontItalic != DependencyProperty.UnsetValue) && (fontItalic.Equals(FontStyles.Italic));

            object fontUnderline = AddRtf_rtf.Selection.GetPropertyValue(Inline.TextDecorationsProperty);
            Underline_btn.IsChecked = (fontUnderline != DependencyProperty.UnsetValue) && (fontUnderline.Equals(TextDecorations.Underline));

            object fontFamily = AddRtf_rtf.Selection.GetPropertyValue(Inline.FontFamilyProperty);
            FontFamily_cb.SelectedItem = fontFamily;

            fontFamily = AddRtf_rtf.Selection.GetPropertyValue(Inline.ForegroundProperty);
        }

        private void FontFamily_cb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (FontFamily_cb.SelectedItem != null && !AddRtf_rtf.Selection.IsEmpty)
            {
                AddRtf_rtf.Selection.ApplyPropertyValue(Inline.FontFamilyProperty, FontFamily_cb.SelectedItem);
            }
        }

        private void FontSize_cb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (FontSize_cb.SelectedValue != null && !AddRtf_rtf.Selection.IsEmpty)
            {
                AddRtf_rtf.Selection.ApplyPropertyValue(Inline.FontSizeProperty, FontSize_cb.SelectedValue);
            }
        }

        private void FontColor_cb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (FontColor_cb.SelectedItem != null)
            {
                AddRtf_rtf.Selection.ApplyPropertyValue(Inline.ForegroundProperty, (SolidColorBrush)(new BrushConverter().ConvertFrom(((ComboBoxItem)FontColor_cb.SelectedItem).Content.ToString())));
            }
        }

        private void Id_tb_GotFocus(object sender, RoutedEventArgs e)
        {
            if (Id_tb.Text.Trim().Equals("Input ID"))
            {
                Id_tb.Text = "";
                Id_tb.Foreground = Brushes.Black;
            }
        }

        private void Id_tb_LostFocus(object sender, RoutedEventArgs e)
        {
            if (Id_tb.Text.Trim().Equals(string.Empty))
            {
                Id_tb.Text = "Input ID";
                Id_tb.Foreground = Brushes.LightSlateGray;
            }
        }

        private void Name_tb_GotFocus(object sender, RoutedEventArgs e)
        {
            if (Name_tb.Text.Trim().Equals("Input name"))
            {
                Name_tb.Text = "";
                Name_tb.Foreground = Brushes.Black;
            }
        }

        private void Name_tb_LostFocus(object sender, RoutedEventArgs e)
        {
            if (Name_tb.Text.Trim().Equals(string.Empty))
            {
                Name_tb.Text = "Input name";
                Name_tb.Foreground = Brushes.LightSlateGray;
            }
        }

        private void Id_tb_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex rg = new Regex("[^0-9]+");
            e.Handled = rg.IsMatch(e.Text);
        }

        private void ChoosePicture_btn_Click(object sender, RoutedEventArgs e)
        {
            string directory = "Football clubs";

            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = directory;

            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif)|*.jpg; *.jpeg; *.png; *.gif";

            if (openFileDialog.ShowDialog() == true)
            {
                try
                {
                    BitmapImage bitmap = new BitmapImage(new Uri(openFileDialog.FileName));
                    path = openFileDialog.FileName;
                    AddImage_img.Source = bitmap;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Can't load picture: " + ex.Message);
                }
            }
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
