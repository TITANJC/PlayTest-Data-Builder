using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace PlayTest_data_builder._5E_DND
{
    public struct Armor : ISerializable
    {
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }

    [Serializable()]
    public enum Armors
    {
        Breastplate, ChainMail, ChainShirt, HalfPlate, Hide, Leather, Padded, Plate, RingMail, ScaleMail, SpikedArmor, Splint, StuddedLeather
    }
}
