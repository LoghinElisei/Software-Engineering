using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Monster
{
    [Serializable]
    public class MonsterConcretePrototype : MonsterPrototype
    {
        public MonsterConcretePrototype(Monster settings) : base(settings)
        {
        }

        public override MonsterPrototype Clone()
        {
            MonsterPrototype objClone = null;

            MemoryStream memory = new MemoryStream();
            BinaryFormatter binForm = new BinaryFormatter();

            binForm.Serialize(memory, this);
            memory.Position = 0;
            objClone = (MonsterPrototype)binForm.Deserialize(memory);

            return objClone;
        }
    }
}
