using System.Collections.Generic;

namespace IuvoUnity
{
    namespace IuvoECS
    {
        namespace IuvoEntity
        {
            public class ObservableClass : EntityView, IObservable
            {
                public List<IObserver> Observers { get; } = new List<IObserver>();

                public void AddObserver(IObserver observer)
                {
                    if (!Observers.Contains(observer)) { Observers.Add(observer); }
                }

                public void RemoveObserver(IObserver observer)
                {
                    if (Observers.Contains(observer)) { Observers.Remove(observer); }
                }

                public void NotifyObservers()
                {
                    foreach (IObserver visitor in Observers)
                    {

                        if (visitor != null && visitor.IsConditionMet(this))
                        {
                            visitor.OnNotify(this);
                        }
                    }
                }
            }
        }
    }
}