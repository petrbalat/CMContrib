using System.Collections.Generic;

namespace Caliburn.Micro.Contrib.Demo
{
    public interface IShell : IConductActiveItem
    {
        IObservableCollection<CategorySamples> SamplesByCategory { get; }
            IObservableCollection<string> LogItems { get; }

        void Log(string message);
    }
}

