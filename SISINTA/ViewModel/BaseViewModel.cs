using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Threading;
using System.Net.Sockets;

namespace SISINTA.ViewModel
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        public BaseViewModel()
        {
        }

        protected void OnChanged([CallerMemberName]string property = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

        public event PropertyChangedEventHandler PropertyChanged;


        public abstract Task Init();
    }


    public abstract class BaseViewModel<T>: BaseViewModel
    {
        protected BaseViewModel() :base()
        {
            
        }

        public override async Task Init()
        {
            await Init(default(T));
        }

        public abstract Task Init(T parameter);

    }
}
