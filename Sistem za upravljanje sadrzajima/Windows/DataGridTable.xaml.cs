using Notification.Wpf;
using Sistem_za_upravljanje_sadrzajima.Classes;
using Sistem_za_upravljanje_sadrzajima.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Shapes;

namespace Sistem_za_upravljanje_sadrzajima.Windows
{
    /// <summary>
    /// Interaction logic for DataGridTable.xaml
    /// </summary>
    public partial class DataGridTable : Window
    {
        public static ObservableCollection<Club> Clubs { get; set; }

        private DataIO serializer = new DataIO();

        MainWindow mainWindow = new MainWindow();

        private NotificationManager notificationManager;

        public DataGridTable()
        {
            InitializeComponent();

            Clubs = serializer.DeSerializeObject<ObservableCollection<Club>>("Clubs.xml");

            if (Clubs == null)
            {
                Clubs = new ObservableCollection<Club>();
            }

            if (Clubs != null)
            {
                foreach (Club club in Clubs)
                {
                    club.Selected = false;
                }
            }

            DataContext = this;

            notificationManager = new NotificationManager();
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            if (Add_btn.Visibility == Visibility.Visible)
            {
                var change = new AddFootballClub(Table.SelectedIndex);
                change.AddNew_btn.Content = "Update";
                change.AddNew_btn.ToolTip = "Update selected club";
                change.Id_tb.IsReadOnly = true;
                change.Show();
                Close();
            }
            else
            {
                var preview = new PreviewData(Table.SelectedIndex);
                preview.Show();
                Close();
            }
        }

        public void ShowToastNotification(ToastNotification toastNotification)
        {
            notificationManager.Show(toastNotification.Title, toastNotification.Message, toastNotification.Type, "WindowNotificationAreaAdding");
        }

        private void Add_btn_Click(object sender, RoutedEventArgs e)
        {
            AddFootballClub addFootball = new AddFootballClub();
            addFootball.Show();
            Close();
        }

        private void Delete_btn_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult messageBox = MessageBox.Show("Are you sure?", "Deleting", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (messageBox == MessageBoxResult.Yes)
            {
                if (Clubs.Count > 0)
                {
                    for (int i = Clubs.Count - 1; i >= 0; i--)
                    {
                        var item = Clubs[i];
                        if (item.Selected)
                        {
                            Clubs.RemoveAt(i);
                            File.Delete($"{item.Name}.rtf");

                        }
                    }
                }

                serializer.SerializeObject<ObservableCollection<Club>>(Clubs, "Clubs.xml");
            }
        }

        private void ExitDGT_btn_Click(object sender, RoutedEventArgs e)
        {
            serializer.SerializeObject<ObservableCollection<Club>>(Clubs, "Clubs.xml");
            mainWindow.Show();
            this.Close();
        }
    }
}
