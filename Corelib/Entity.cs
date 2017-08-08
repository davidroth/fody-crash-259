
using System.ComponentModel;

namespace Corelib
{
    public abstract class Entity<T> : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public static bool operator ==(Entity<T> first, Entity<T> second)
        {
            return false;
        }

        public static bool operator !=(Entity<T> first, Entity<T> second)
        {
            return false;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}