// ViewModelBase

using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Messenger.UWP.ViewModels
{
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetProperty<T>(ref T target, T value, [CallerMemberName] string propertyName = null)
        {
            if (!Equals(target, value))
            {
                target = value;
                OnPropertyChanged(propertyName);
                return true;
            }

            return false;
        }
    }
}