using IuvoUnity._ECS;

namespace IuvoUnity
{
    namespace _BaseClasses
    {
        namespace _RPG
        {
            public class Level : RPGComponentBase {  }

            public class GameLevel : Level {  }

            public class AttributeLevel : Level{   }
            
            public class LevelValueComponent : AttributeLevel {  public int _levelValue; }

            


            public class ValueMultiplier : RPGComponentBase {  public float _valueMultiplier; }

            
            public class ExperienceValueComponent : RPGComponentBase {  public int _experience; }
            public class ExperienceLevelMultiplier : ValueMultiplier { }

            public class ExperienceGaugeComponent : RPGComponentBase
            {
                public ExperienceValueComponent exp;
                public IuvoMinMax_INT_Component minMax;
            }


            public class ExperienceGiftComponent : RPGComponentBase
            {
                public ExperienceValueComponent experience;
            }
        }
    }
}