using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;

namespace Clima.ModelView
{
    public class NotificableViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this. new PropertyChangedEventArgs(propertyName = null)


        }

        protected void SetValue<T>(ref T backingField, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingField, value))

            {
                return;
            }

            backingField = value;
            OnPropertyChanged(propertyName);
        }

    }
}
