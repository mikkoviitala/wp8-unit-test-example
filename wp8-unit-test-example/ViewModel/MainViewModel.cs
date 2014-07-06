using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace wp8_unit_test_example.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string _myProperty;

        public MainViewModel()
        {
            MyProperty = "MyProperty";   
        }

        public string MyProperty
        {
            get { return _myProperty; }
            set { _myProperty = value; OnPropertyChanged(); }
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
