using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace PlayTest_data_builder._5E_DND
{
    public struct Race : ISerializable
    {
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }

    [Serializable()]
    public enum Races
    {
        Dragonborn, Dwarf, Elf, Gnome, HalfElf, Halfing, HalfOrc, Human, Tiefling
    }

    [Serializable()]
    public enum CreatureType
    {
        Aberration, Beast, Celestial, Construct, Dragon, Elemental, Fey, Fiend, Giant, Humanoid, Monster, Ooze, Plant, Undead
    }

    [Serializable()]
    public enum CreatureSize
    {
        Tiny, Small, Medium, Large, Huge, Gargantuan
    }

    [Serializable()]
    public enum Senses
    {
        Normal, Blindsight, Darkvision, Tremorsense, Truesight
    }

    [Serializable()]
    public enum SpecialTraits
    {
        InnateSpell, Spell, Psionics
    }
}
