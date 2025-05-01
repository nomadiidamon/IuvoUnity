using System.Collections.Generic;

namespace IuvoUnity
{
    namespace _BaseClasses
    {
        namespace _ECS
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
}