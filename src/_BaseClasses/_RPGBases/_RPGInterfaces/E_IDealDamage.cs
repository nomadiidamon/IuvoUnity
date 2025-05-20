using IuvoUnity._BaseClasses._ECS;
using IuvoUnity._BaseClasses._RPG;
using IuvoUnity._RPG;
using System.Collections.Generic;

namespace IuvoUnity
{
    namespace _Interfaces
    {
        namespace _RPG
        {
            public interface IDealDamage
            {
                public List<DamageValueComponent> totalDamage { get; set; }
                void DealDamage(IuvoEntity damagable);
            }
        }
    }
}
