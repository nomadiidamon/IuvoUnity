using IuvoUnity.IuvoECS.IuvoEntity;
using System.Collections.Generic;

namespace IuvoUnity
{
    namespace IuvoRPG.IuvoECS
    {
        public interface IDealDamage
        {
            public List<DamageValueComponent> totalDamage { get; set; }
            void DealDamage(IuvoEntity damagable);
        }
    }
}