using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace PlayTest_data_builder._5E_DND
{
    [Serializable()]
    public struct Player : ISerializable
    {
        int STR;
        int DEX;
        int CON;
        int INT;
        int WIS;
        int CHA;

        int Level;

        Classes CharClass;
        Feats[] CharFeats;
        

        public Player (int[] attributes, int level, Classes charClass, Feats[] feats)
        {
            STR = attributes[0];
            DEX = attributes[1];
            CON = attributes[2];
            INT = attributes[3];
            WIS = attributes[4];
            CHA = attributes[5];

            Level = level;
            CharClass = charClass;
            CharFeats = feats;

            // TODO: Add Enum references for Weapons, Items, and Armor.
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("STR", STR);
            info.AddValue("DEX", DEX);
            info.AddValue("CON", CON);
            info.AddValue("INT", INT);
            info.AddValue("WIS", WIS);
            info.AddValue("CHA", CHA);

            info.AddValue("Level", Level);

            info.AddValue("Class", CharClass);
        }
    }

    [Serializable()]
    public struct Monster : ISerializable
    {
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }

    [Serializable()]
    public struct Class : ISerializable
    {
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }

    [Serializable()]
    public struct Race : ISerializable
    {
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }

    [Serializable()]
    public struct Weapon : ISerializable
    {
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }

    [Serializable()]
    public struct Armor : ISerializable
    {
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }

    [Serializable()]
    public struct Item : ISerializable
    {
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }

    [Serializable()]
    public struct Feat : ISerializable
    {
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }

    [Serializable()]
    public struct Spell : ISerializable
    {
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }

    [Serializable()]
    public enum DieType { d4 = 4, d6 = 6, d8 = 8, d10 = 10, d12 = 12, d20 = 20, percentile = 100 };

    [Serializable()]
    public enum CreatureType { Aberration, Beast, Celestial, Construct, Dragon, Elemental, Fey, Fiend, Giant, Humanoid, Monster, Ooze, Plant, Undead };

    [Serializable()]
    public enum CreatureSize { Tiny, Small, Medium, Large, Huge, Gargantuan };

    [Serializable()]
    public enum AlignmentAxiom { Lawful, Neutral, Chaotic };

    [Serializable()]
    public enum AlignmentMoral { Evil, Neutral, Good };

    [Serializable()]
    public enum AbilityStat { STR, DEX, CON, INT, WIS, CHA };

    [Serializable()]
    public enum Senses { Normal, Blindsight, Darkvision, Tremorsense, Truesight }

    [Serializable()]
    public enum SpecialTraits { InnateSpell, Spell, Psionics };

    [Serializable()]
    public enum Classes { Artificer, Barbarian, Bard, Cleric, Druid, Fighter, Monk, Mystic, Paladin, Ranger, Rogue, Sorcerer, Warlock, Wizard }

    [Serializable()]
    public enum Feats { Athlete, Alert, Charger, DefensiveDualist, DualWielder, Durable, ElementalAdept, Grappler, GreatWeaponMaster, Healer, KeenMind, Linguist, MageSlayer, MartialAdept, Mobile,
        Observant, Resilient, SavageAttacker, Sentinel, Sharpshooter, Skulker, SpellSniper, Tough, WarCaster, BladeMaster, CrossbowExpert, FellHanded, FlailMastery, PolearmMaster, ShieldMaster,
        SpearMastery, TavernBrawler, WeaponMaster, LightlyArmored, ModeratelyArmored, MediumArmorMaster, HeavilyArmored, HeavyArmorMaster, SkillAcrobat, SkillAnimalHandler, SkillArcanist, SkillBrawny,
        SkillDiplomat, SkillEmpathic, SkillHistorian, SkillInvestigator, SkillMedic, SkillMenacing, SkillNaturalist, SkillPerceptive, SkillPerformer, SkillQuickFingered, SkillSilverTongued, SkillStealthy,
        SkillSurvivalist, SkillTheologian, Alchemist, Burglar, Gourmand, MasterOfDisguise, RacialBarbedHide, RacialBountifulLuck, RacialCritterFiend, RacialDragonFear, RacialDragonHide, RacialDragonWinds,
        RacialDrowHighMagic, RacialDwarvenFortitude, RacialElvenAccuracy, RacialEverybodysFriend, RacialFadeAway, RacialFeyTeleportation, RacialFlamesOfPhlegethos, RacialGrudgeBearer, RacialHumanDetermination,
        RacialInfernalConstitution, RacialOrcishAggression, RacialOrcishFury, RacialProdigy, RacialSecondChance, RacialSquatNimbleness, RacialSvirfneblinMagic, RacialVampiricExultation, RacialWonderMaker,
        RacialWoodElfMagic }

    [Serializable()]
    public enum Races { }

    // TODO: Add enum lists for Races, Items, Weapons, and Armor. 

    public static class LoadData
    {

    }
}
