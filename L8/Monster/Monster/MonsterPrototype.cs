using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monster
{
    [Serializable]
    public abstract class MonsterPrototype : MonsterSprite
    {
        public MonsterPrototype(in Monster settings) : base(settings)
        {

        }
        public abstract MonsterPrototype Clone();

        public MonsterSprite GetMonster(Monster settings)
        {
            MonsterPrototype clone = this.Clone();

            clone._image = new System.Drawing.Bitmap(settings.Image);
            clone._maxLives = Convert.ToInt32(settings.Lives);
            clone._lives = clone._maxLives;

            clone._color = clone.GetColor(settings.Color);

            return clone;
        }
    }
}
