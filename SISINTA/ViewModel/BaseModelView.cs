using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
namespace SISINTA.ViewModel
{
    public class BaseModelView : INotifyPropertyChanged
    {
        public BaseModelView()
        {
        }

        protected void OnChanged([CallerMemberName]string property=null)
        {
            PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(property));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
