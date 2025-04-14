using System.Collections.Generic;

namespace IuvoUnity
{
    public interface IObservable
    {
        List<IObserver> Observers { get; }
        void AddObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObservers();
    }
}