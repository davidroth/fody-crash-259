using System.ComponentModel;
using Corelib;

namespace Fody_Test
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class ViewModel : INotifyPropertyChanged
    {
        public Entity<int> TargetEntity { get; set; } // THIS LETS FOODY CRASH

        public event PropertyChangedEventHandler PropertyChanged;
    }
}