using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace PlayTest_data_builder._5E_DND
{
    public struct Player : ISerializable
    {
        string Label;

        int STR;
        int DEX;
        int CON;
        int INT;
        int WIS;
        int CHA;

        int Level;

        Races CharRace;
        Classes CharClass;
        AlignmentAxiom AlignAxiom;
        AlignmentMoral AlignMoral;
        Feats[] CharFeats;
        Armors[] CharArmors;
        Weapons[] CharWeapons;
        Spells[] CharSpells;

        public Player(string label, int[] attributes, int level, Races charRace, Classes charClass, Feats[] charFeats, Armors[] charArmors, 
            Weapons[] charWeapons, Spells[] charSpells, AlignmentAxiom alignAxiom, AlignmentMoral alignMoral)
        {
            Label = label;

            STR = attributes[0];
            DEX = attributes[1];
            CON = attributes[2];
            INT = attributes[3];
            WIS = attributes[4];
            CHA = attributes[5];

            Level = level;
            CharRace = charRace;
            CharClass = charClass;
            AlignAxiom = alignAxiom;
            AlignMoral = alignMoral;
            CharFeats = charFeats;
            CharArmors = charArmors;
            CharWeapons = charWeapons;
            CharSpells = charSpells;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Label", Label);

            info.AddValue("STR", STR);
            info.AddValue("DEX", DEX);
            info.AddValue("CON", CON);
            info.AddValue("INT", INT);
            info.AddValue("WIS", WIS);
            info.AddValue("CHA", CHA);

            info.AddValue("Level", Level);

            info.AddValue("CharRace", CharRace);
            info.AddValue("CharClass", CharClass);
            info.AddValue("CharFeats", CharFeats);
            info.AddValue("CharArmors", CharArmors);
            info.AddValue("CharWeapons", CharWeapons);
            info.AddValue("CharSpells", CharSpells);
        }
    }

    [Serializable()]
    public enum Feats
    {
        Athlete, Alert, Charger, DefensiveDualist, DualWielder, Durable, ElementalAdept, Grappler, GreatWeaponMaster, Healer, KeenMind, Linguist, MageSlayer, MartialAdept, Mobile,
        Observant, Resilient, SavageAttacker, Sentinel, Sharpshooter, Skulker, SpellSniper, Tough, WarCaster, BladeMaster, CrossbowExpert, FellHanded, FlailMastery, PolearmMaster, ShieldMaster,
        SpearMastery, TavernBrawler, WeaponMaster, LightlyArmored, ModeratelyArmored, MediumArmorMaster, HeavilyArmored, HeavyArmorMaster, SkillAcrobat, SkillAnimalHandler, SkillArcanist, SkillBrawny,
        SkillDiplomat, SkillEmpathic, SkillHistorian, SkillInvestigator, SkillMedic, SkillMenacing, SkillNaturalist, SkillPerceptive, SkillPerformer, SkillQuickFingered, SkillSilverTongued, SkillStealthy,
        SkillSurvivalist, SkillTheologian, Alchemist, Burglar, Gourmand, MasterOfDisguise, RacialBarbedHide, RacialBountifulLuck, RacialCritterFiend, RacialDragonFear, RacialDragonHide, RacialDragonWinds,
        RacialDrowHighMagic, RacialDwarvenFortitude, RacialElvenAccuracy, RacialEverybodysFriend, RacialFadeAway, RacialFeyTeleportation, RacialFlamesOfPhlegethos, RacialGrudgeBearer, RacialHumanDetermination,
        RacialInfernalConstitution, RacialOrcishAggression, RacialOrcishFury, RacialProdigy, RacialSecondChance, RacialSquatNimbleness, RacialSvirfneblinMagic, RacialVampiricExultation, RacialWonderMaker,
        RacialWoodElfMagic
    }

    [Serializable()]
    public enum Stats
    {
        STR, DEX, CON, INT, WIS, CHA
    }

    [Serializable()]
    public enum AlignmentAxiom
    {
        Lawful, Neutral, Chaotic
    }

    [Serializable()]
    public enum AlignmentMoral
    {
        Evil, Neutral, Good
    }
}
