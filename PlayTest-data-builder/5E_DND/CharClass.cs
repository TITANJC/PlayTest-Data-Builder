﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace PlayTest_data_builder._5E_DND
{
    public struct CharClass : ISerializable
    {
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }

    [Serializable()]
    public enum Classes
    {
        Artificer, Barbarian, Bard, Cleric, Druid, Fighter, Monk, Mystic, Paladin, Ranger, Rogue, Sorcerer, Warlock, Wizard
    }
}
