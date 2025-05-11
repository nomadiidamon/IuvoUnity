using IuvoUnity._DataStructs;

namespace IuvoUnity
{
    namespace _BaseClasses
    {
        namespace _RPG
        {
            [System.Serializable]
            public class Level : RPGComponentBase {  }

            [System.Serializable]
            public class GameLevel : Level {  }

            [System.Serializable]
            public class AttributeLevel : Level{   }

            [System.Serializable]
            public class LevelValueComponent : AttributeLevel {  public int _levelValue; }



            [System.Serializable]
            public class ValueMultiplier : RPGComponentBase {  public float _valueMultiplier; }

            [System.Serializable]
            public class ExperienceValueComponent : RPGComponentBase {  public int _experience; }
            [System.Serializable]
            public class ExperienceLevelMultiplier : ValueMultiplier { }

            [System.Serializable]
            public class ExperienceGaugeComponent : RPGComponentBase
            {
                public ExperienceValueComponent _exp;
                public Range<int> _minMax;
            }

            [System.Serializable]
            public class ExperienceData : RPGComponentBase
            {
                public ClampedValue<int> _exp; // value and range access
                public ExperienceLevelMultiplier _mult;
            }

            [System.Serializable]
            public class ExperienceGiftComponent : RPGComponentBase
            {
                public ExperienceValueComponent experience;
            }
        }
    }
}