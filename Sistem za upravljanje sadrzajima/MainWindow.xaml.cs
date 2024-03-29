using Notification.Wpf;
using Sistem_za_upravljanje_sadrzajima.Classes;
using Sistem_za_upravljanje_sadrzajima.Helpers;
using Sistem_za_upravljanje_sadrzajima.Windows;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Sistem_za_upravljanje_sadrzajima
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private NotificationManager notificationManager;

        private DataIO serializer = new DataIO();

        private ObservableCollection<User> Users;

        public MainWindow()
        {
            InitializeComponent();

            Username_tb.Text = "Input username";
            Username_tb.Foreground = Brushes.LightSlateGray;
            Password_tb.Password = "Input password";
            Password_tb.Foreground = Brushes.LightSlateGray;

            notificationManager = new NotificationManager();

            Users = serializer.DeSerializeObject<ObservableCollection<User>>("Users.xml");
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        public void ShowToastNotification(ToastNotification toastNotification)
        {
            notificationManager.Show(toastNotification.Title, toastNotification.Message, toastNotification.Type, "WindowNotificationArea");
        }

        private void Username_tb_GotFocus(object sender, RoutedEventArgs e)
        {
            if (Username_tb.Text.Trim().Equals("Input username"))
            {
                Username_tb.Text = "";
                Username_tb.Foreground = Brushes.Black;
            }
        }

        private void Username_tb_LostFocus(object sender, RoutedEventArgs e)
        {
            if (Username_tb.Text.Trim().Equals(string.Empty))
            {
                Username_tb.Text = "Input username";
                Username_tb.Foreground = Brushes.LightSlateGray;
            }
        }

        private void Password_tb_GotFocus(object sender, RoutedEventArgs e)
        {
            if (Password_tb.Password.Trim().Equals("Input password"))
            {
                Password_tb.Password = "";
                Password_tb.Foreground = Brushes.Black;
            }
        }

        private void Password_tb_LostFocus(object sender, RoutedEventArgs e)
        {
            if (Password_tb.Password.Trim().Equals(string.Empty))
            {
                Password_tb.Password = "Input password";
                Password_tb.Foreground = Brushes.LightSlateGray;
            }
        }

        private void Exit_btn_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult messageBox = MessageBox.Show("Are you sure?", "Exiting", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (messageBox == MessageBoxResult.Yes)
            {
                this.Close();
                Application.Current.Shutdown();
            }
        }

        private void Login_btn_Click(object sender, RoutedEventArgs e)
        {
            if (ValidateFormData())
            {
                foreach (User u in Users)
                {
                    if (Username_tb.Text == u.Username && Password_tb.Password == u.Password)
                    {
                        if (u.UserRole == UserRole.ADMIN)
                        {
                            DataGridTable dgt = new DataGridTable();
                            dgt.Show();
                            Close();
                        }
                        else
                        {
                            DataGridTable dgt = new DataGridTable();
                            dgt.Add_btn.Visibility = Visibility.Hidden;
                            dgt.Delete_btn.Visibility = Visibility.Hidden;
                            dgt.Show();
                            Close();
                        }
                    }
                }
            }
        }

        public bool ValidateFormData()
        {
            bool isValid = true;
            int i = -1;

            if (Username_tb.Text.Trim().Equals(string.Empty))
            {
                isValid = false;
                Username_error.Content = "Form field can't be left empty!";
                Username_tb.BorderBrush = Brushes.Red;
            }
            else if(Username_tb.Text.Trim().Equals("Input username"))
            {
                isValid = false;
                Username_error.Content = "Form field can't be 'Input username'!";
                Username_tb.BorderBrush = Brushes.Red;
            }
            else
            {
                Username_error.Content = string.Empty;
                Username_tb.BorderBrush = Brushes.Gray;
            }

            if (Password_tb.Password.Trim().Equals(string.Empty))
            {
                isValid = false;
                Password_error.Content = "Form field can't be left empty!";
                Password_tb.BorderBrush = Brushes.Red;
            }
            else if (Password_tb.Password.Trim().Equals("Input password"))
            {
                isValid = false;
                Password_error.Content = "Form field can't be 'Input password'!";
                Password_tb.BorderBrush = Brushes.Red;
            }
            else
            {
                Password_error.Content = string.Empty;
                Password_tb.BorderBrush = Brushes.Gray;
            }

            foreach (User u in Users)
            {
                if (Username_tb.Text == u.Username && Password_tb.Password == u.Password)
                {
                    i = 0;
                }
            }

            if (i == -1)
            {
                NoAccount_error.Content = "Nonexistent user";

                this.ShowToastNotification(new ToastNotification("Error", "Nonexistent user", NotificationType.Error));
            }

            return isValid;
        }
    }
}
