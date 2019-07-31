using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;
using System.ComponentModel;

namespace MobileApp
{
    [Table("Contributors")]
    class ContributorModel : INotifyPropertyChanged
    {
        private int _id;
        [PrimaryKey, AutoIncrement]

        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                this._id = value;
                OnPropertyChanged(nameof(Id));
            }
        }

        private string _Name;
        [NotNull]
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                this._Name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        private string _physicalAddress;
        [MaxLength(50)]

        public string PhysicalAddress
        {
            get
            {
                return _physicalAddress;
            }
            set
            {
                this._physicalAddress = value;
                OnPropertyChanged(nameof(PhysicalAddress));
            }
        }

        private string _email;

        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        private string _phone;

        public string PhoneNumber
        {
            get
            {
                return _phone;
            }
            set
            {
                _phone = value;
                OnPropertyChanged(nameof(PhoneNumber));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
