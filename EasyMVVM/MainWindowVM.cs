using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace EasyMVVM
{
    public class MainWindowVM : DependencyObject, INotifyPropertyChanged
    {
        public MainWindowVM()
        {
            Model m = new Model();
            BoundProperty = m.GetData();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        //property that holds the value of the _Backing Property
        private ObservableCollection<string> _BackingProperty;

        public ObservableCollection<string> BoundProperty
        {
            get { return _BackingProperty; }
            set { _BackingProperty = value; PropChanged("BoundProperty"); }
        }

        public void PropChanged(String propertyName)
        {
            //Did WPF registerd to listen to this event
            if (PropertyChanged != null)
            {
                //Tell WPF that this property changed
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
