using System.Collections.Generic;
using UnityEngine;
using IuvoUnity._Interfaces;


namespace IuvoUnity
{
    namespace _BaseClasses
    {
        namespace _RPG
        {
            public class AbilityController : MonoBehaviour
            {
                private Dictionary<string, IAbility> abilities = new Dictionary<string, IAbility>();

                public void AddAbility(IAbility ability)
                {
                    if (!abilities.ContainsKey(ability.AbilityName))
                    {
                        abilities.Add(ability.AbilityName, ability);
                    }
                }

                public void RemoveAbility(string abilityName)
                {
                    if (abilities.ContainsKey(abilityName))
                    {
                        abilities.Remove(abilityName);
                    }
                }

                public void ActivateAbility(string abilityName)
                {
                    if (abilities.TryGetValue(abilityName, out var ability))
                    {
                        ability.Activate();
                    }
                }
            }
        }
    }
}