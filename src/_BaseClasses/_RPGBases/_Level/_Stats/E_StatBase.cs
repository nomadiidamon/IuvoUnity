using IuvoUnity._DataStructs;
using IuvoUnity._Interfaces;
namespace IuvoUnity
{
    namespace _BaseClasses
    {
        namespace _RPG
        {
            [System.Serializable]
            public class StatBase : AttributeLevel
            {
                public DataName _statName; 
                public LevelValueComponent _levelValue;
                private ExperienceData _expValue;
                public ExperienceGaugeComponent _experienceGauge;

                public Range<int> softCap;
                public Range<int> hardCap;
            }

            [System.Serializable]
            public class StatModifier : RPGComponentBase
            {
                public enum ModifierType { FLAT, PERCENTAGE }
                public ModifierType type;
                public float value;
                public IConditional conditionForModification;
            }

            [System.Serializable]
            public class RewardPoint : RPGComponentBase
            {
                public int reward;
                public IConditional useCaseCondition; // Optional: for timed effects.
            }


        }
    }
}