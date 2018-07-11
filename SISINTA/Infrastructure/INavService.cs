using System;
using System.Threading.Tasks;
using SISINTA.ViewModel;
using System.Reflection;
using System.ComponentModel;
namespace SISINTA.Infrastructure
{
    public interface INavService
    {
        event PropertyChangedEventHandler CanGoBackChanged;

        bool CanGoBack { get; }
        Task GoBack();
        Task NavigateTo<T>() where T : BaseModelView;
        Task NavigateTo<T, TParam>(TParam parameter) where T : BaseModelView;
        Task RemoveLastView();
        Task ClearBackStack();
        Task NavigateToUri(Uri url);

    }
}
