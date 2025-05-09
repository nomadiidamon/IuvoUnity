using IuvoUnity._DataStructs;
namespace IuvoUnity
{
    namespace _BaseClasses
    {
        namespace _RPG
        {
            public class StatBase : AttributeLevel
            {
                public Name _statName; 
                public LevelValueComponent _levelValue;
                public ExperienceValueComponent _expValue;
                public ExperienceLevelMultiplier _expMultiplayer;
                public ExperienceGaugeComponent _experienceGauge;

                public Range<int> softCap;
                public Range<int> hardCap;
            }
        }
    }
}