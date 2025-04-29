namespace IuvoUnity
{
    namespace IuvoECS
    {
        namespace IuvoEntity
        {
            public class IuvoTimer
            {
                public IuvoEntity _myIuvoEntity { get; set; }

                public IuvoTimer()
                {
                    var timer = IuvoEntityRegistry.CreateTimerEntity(true);
                    timer._ComponentManager.TryGetComponent<IuvoComponents.IuvoWorldID>(out var id);
                    _myIuvoEntity = id._entity;
                }


            }
        }
    }
}
