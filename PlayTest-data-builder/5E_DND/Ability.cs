using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace PlayTest_data_builder._5E_DND
{
    public struct Ability : ISerializable
    {
        // TODO: Need to figure out what values need to be defined to be able to create a general implementation of all abilities.
        string Label;
        ushort TimesPerDay;
        ushort Duration;
        short Bonus;
        short Negative;
        DurationType DurType;
        Actions[] ActionTriggers;
        Stats[] StatTriggers;
        Actions[] ActionDenies;

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }

    [Serializable()]
    public enum Abilities
    {
        Rage, UnarmoredDefense, RecklessAttack, DangerSense, PrimalPath, FastMovement, FeralInstinct, BrutalCritical, IndomitableMight, PrimalChampion, BardicInspiration, Spellcasting,
        JackOfAllTrades, SongOfRest, BardCollege, Expertise, FontOfInspiration, CounterCharm, MagicalSecrets, SuperiorInspiration, DivinDomain, ChannelDivinity, DestroyUndead, DivineIntervention,
        Druidic, WildShape, DruidCircle, TimelessBody, BeastSpells, ArchDruid, FightingStyle, SecondWind, ActionSurge, MartialArchetype, Indomitable, MartialArts, Ki, UnarmoredMovement, MonasticTradition,
        DeflectMissiles, SlowFall, StunningStrike, KiEmpoweredStrikes, Evasion, StillnessOfMind, PurityOfBody, TongueOfTheSunAndMoon, DiamondSoul, EmptyBody, PerfectSelf
    }
}
