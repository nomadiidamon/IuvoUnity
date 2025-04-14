namespace IuvoUnity
{
    public interface IObserver
    {
        bool IsConditionMet(IObservable subject);
        void OnNotify(IObservable subject);

    }
}