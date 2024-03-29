using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_za_upravljanje_sadrzajima.Classes
{
    [Serializable]
    public class Club : INotifyPropertyChanged
    {
        public int id { get; set; }
        public string name { get; set; }
        public string picture { get; set; }
        public string rtf { get; set; }
        public DateTime date { get; set; }
        public bool selected { get; set; }

        public Club()
        {

        }

        public Club(int id, string name, string picture, string rtf)
        {
            this.Id = id;
            this.Name = name;
            this.Picture = picture;
            this.Rtf = rtf;
            this.Date = DateTime.Today;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public int Id
        {
            get { return id; }
            set
            {
                if (id != value)
                {
                    id = value;
                    OnPropertyChanged("Id");
                }
            }
        }
        public string Name
        {
            get { return name; }
            set
            {
                if (name != value)
                {
                    name = value;
                    OnPropertyChanged("Name");
                }
            }
        }
        public string Picture
        {
            get { return picture; }
            set
            {
                if (picture != value)
                {
                    picture = value;
                    OnPropertyChanged("Picture");
                }
            }
        }
        public string Rtf
        {
            get { return rtf; }
            set
            {
                if (rtf != value)
                {
                    rtf = value;
                    OnPropertyChanged("Rtf");
                }
            }
        }
        public DateTime Date
        {
            get { return date; }
            set
            {
                if (date != value)
                {
                    date = value;
                    OnPropertyChanged("Date");
                }
            }
        }
        public bool Selected
        {
            get { return selected; }
            set
            {
                if (selected != value)
                {
                    selected = value;
                    OnPropertyChanged("Selected");
                }
            }
        }
    }
}
