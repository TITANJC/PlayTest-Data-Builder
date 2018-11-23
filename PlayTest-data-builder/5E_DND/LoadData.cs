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
        Feats[] CharFeats;
        Armors[] CharArmors;
        Weapons[] CharWeapons;
        Spells[] CharSpells;

        public Player (string label, int[] attributes, int level, Races charRace, Classes charClass, Feats[] charFeats, Armors[] charArmors, Weapons[] charWeapons, Spells[] charSpells)
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
    public struct Monster : ISerializable
    {
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }

    [Serializable()]
    public struct Weapon : ISerializable
    {
        string Label;
        DieType DamageDie;
        DamageTypes DamageType;
        int DieNum;
        int RangeMin;
        int RangeMax;
        WeaponProperties[] WeaponProps;

        public Weapon (string label, DieType damageDie, DamageTypes damageType, int dieNum, int rangeMin, int rangeMax, WeaponProperties[] weaponProps)
        {
            Label = label;
            DamageDie = damageDie;
            DamageType = damageType;
            DieNum = dieNum;
            RangeMin = rangeMin;
            RangeMax = rangeMax;
            WeaponProps = weaponProps;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Label", Label);
            info.AddValue("DieType", DamageDie);
            info.AddValue("DamageType", DamageType);
            info.AddValue("DieNum", DieNum);
            info.AddValue("RangeMin", RangeMin);
            info.AddValue("RangeMax", RangeMax);
            info.AddValue("WeaponProps", WeaponProps);
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
    public enum DamageTypes { Acid, Bludgeoning, Cold, Fire, Force, Lightning, Necrotic, Piercing, Poison, Psychic, Radiant, Slashing, Thunder }

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
    public enum WeaponProperties { Ammunition, Finesse, Heavy, Light, Loading, Reach, Special, Thrown, TwoHanded, Versatile }

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
    public enum Races { Dragonborn, Dwarf, Elf, Gnome, HalfElf, Halfing, HalfOrc, Human, Tiefling }

    [Serializable()]
    public enum Weapons { Battleaxe, Blowgun, Boomerang, Club, CrossbowHand, CrossbowHeavy, CrossbowLight, Dagger, Dart, DoubleBladdedScimitar, Flail, Glaive, Greataxe, Greatclub, Greatsword, Halberd, Handaxe,
        Javeline, Lance, LightHammer, Longbow, Longsword, Mace, Maul, Morningstar, Net, Pike, Quarterstaff, Rapier, Scimitar, Shortbow, Shortsword, Sickle, Sling, Spear, Trident, WarPick, Warhammer, Whip, Yklwa }

    [Serializable()]
    public enum Armors { Breastplate, ChainMail, ChainShirt, HalfPlate, Hide, Leather, Padded, Plate, RingMail, ScaleMail, SpikedArmor, Splint, StuddedLeather }

    [Serializable()]
    public enum Spells
    {
        AcidSplash, Aid, Alarm, AlterSelf, AnimalFriendship, AnimalMessenger, AnimalShapes, AnimateDead, AnimateObjects, AntilifeShell, AntimagicField, Antipathy, Sympathy, ArcaneEye, ArcaneGate,
        ArcaneLock, ArmorofAgathys, ArmsofHadar, AstralProjection, Augury, AuraofLife, AuraofPurity, AuraofVitality, Awaken, Bane, BanishingSmite, Banishment, Barkskin, BeaconofHope, BeastSense, BestowCurse, BigbysHand,
        BladeBarrier, BladeWard, Bless, Blight, BlindingSmite, Blindness, Deafness, Blink, Blur, BrandingSmite, BurningHands, CallLightning, CalmEmotions, ChainLightning, CharmPerson, ChillTouch, ChromaticOrb,
        CircleofDeath, CircleofPower, Clairvoyance, Clone, CloudofDaggers, Cloudkill, ColorSpray, Command, Commune, CommunewithNature, CompelledDuel, ComprehendLanguages, Compulsion, ConeofCold, Confusion, ConjureAnimals,
        ConjureBarrage, ConjureCelestial, ConjureElemental, ConjureFey, ConjureMinorElementals, ConjureVolley, ConjureWoodlandBeings, ContactOtherPlane, Contagion, Contingency, ContinualFlame, ControlWater, ControlWeather,
        CordonofArrows, Counterspell, CreateFoodandWater, CreateorDestroyWater, CreateUndead, Creation, CrownofMadness, CrusadersMantle, CureWounds, DancingLights, Darkness, Darkvision, Daylight, DeathWard, DelayedBlastFireball,
        Demiplane, DestructiveWave, DetectEvilandGood, DetectMagic, DetectPoisonandDisease, DetectThoughts, DimensionDoor, DisguiseSelf, Disintegrate, DispelEvilandGood, DispelMagic, DissonantWhispers, Divination, DivineFavor,
        DivineWord, DominateBeast, DominateMonster, DominatePerson, DrawmijsInstantSummons, Dream, Druidcraft, Earthquake, EldritchBlast, ElementalWeapon, EnhanceAbility, Enlarge, Reduce, EnsnaringStrike, Entangle, Enthrall,
        Etherealness, EvardsBlackTentacles, ExpeditiousRetreat, Eyebite, Fabricate, FaerieFire, FalseLife, Fear, Feather, Feeblemind, FeignDeath, FindFamiliar, FindSteed, FindthePath, FindTraps, FingerofDeath, FireBolt,
        FireShield, FireStorm, Fireball, FlameBlade, FlameStrike, FlamingSphere, FleshtoStone, Fly, FogCloud, Forbiddance, Forcecage, Foresight, FreedomofMovement, Friends, GaseousForm, Gate, Geas, GentleRepose, GiantInsect,
        Glibness, GlobeofInvulnerability, GlyphofWarding, Goodberry, GraspingVine, Grease, GreaterInvisibility, GreaterRestoration, GuardianofFaith, GuardsandWards, Guidance, GuidingBolt, GustofWind, HailofThorns, Hallow,
        HallucinatoryTerrain, Harm, Haste, Heal, HealingWord, HeatMetal, Hellish, HeroesFeast, Heroism, Hex, HoldMonster, HoldPerson, HolyAura, HungerofHadar, HuntersMark, HypnoticPattern, IceStorm, Identify, IllusoryScript,
        Imprisonment, IncendiaryCloud, InflictWounds, InsectPlague, Invisibility, Jump, Knock, LegendLore, LeomundsSecretChest, LeomundsTinyHut, LesserRestoration, Levitate, Light, LightningArrow, LightningBolt,
        LocateAnimalsorPlants, LocateCreature, LocateObject, Longstrider, MageArmor, MageHand, MagicCircle, MagicJar, MagicMissile, MagicMouth, MagicWeapon, MajorImage, MassCureWounds, MassHeal, MassHealingWord, MassSuggestion,
        Maze, MeldintoStone, MelfsAcidArrow, Mending, Message, MeteorSwarm, MindBlank, MinorIllusion, MirageArcane, MirrorImage, Mislead, MistyStep, ModifyMemory, Moonbeam, MordenkainensFaithfulHound, MordenkainensMagnificentMansion,
        MordenkainensPrivateSanctum, MordenkainensSword, MoveEarth, Nondetection, NystulsMagicAura, OtilukesFreezingSphere, OtilukesResilientSphere, OttosIrresistibleDance, PassWithoutTrace, Passwall, PhantasmalForce,
        PhantasmalKiller, PhantomSteed, PlanarAlly, PlanarBinding, PlaneShift, Plant, PoisonSpray, Polymorph, PowerWordHeal, PowerWordKill, PowerWordStun, PrayerofHealing, Prestidigitation, PrismaticSpray, PrismaticWall,
        ProduceFlame, ProgrammedIllusion, ProjectImage, ProtectionfromEnergy, ProtectionfromEvilandGood, ProtectionfromPoison, PurifyFoodandDrink, RaiseDead, RarysTelepathicBond, RayofEnfeeblement, RayofFrost, RayofSickness,
        Regenerate, Reincarnate, RemoveCurse, Resistance, Resurrection, ReverseGravity, Revivify, RopeTrick, SacredFlame, Sanctuary, ScorchingRay, Scrying, SearingSmite, Seeinvisibility, Seeming, Sending, Sequester, Shapechange,
        Shatter, Shield, ShieldofFaith, Shillelagh, ShockingGrasp, Silence, SilentImage, Simulacrum, Sleep, SleetStorm, Slow, SparetheDying, SpeakwithAnimals, SpeakwithDead, SpeakwithPlants, SpiderClimb, SpikeGrowth,
        SpiritGuardians, SpiritualWeapon, StaggeringSmite, StinkingCloud, StoneShape, Stoneskin, StormofVengeance, Suggestion, Sunbeam, Sunburst, SwiftQuiver, Symbol, TashasHideousLaughter, Telekinesis, Telepathy, Teleport,
        TeleportationCircle, TensersFloatingDisk, Thaumaturgy, ThornWhip, ThunderousSmite, Thunderwave, TimeStop, Tongues, TransportviaPlants, TraptheSoul, TreeStride, TruePolymorph, TrueResurrection, TrueSeeing, TrueStrike,
        Tsunami, UnseenServant, VampiricTouch, ViciousMockery, WallofFire, WallofForce, WallofIce, WallofStone, WallofThorns, WardingBond, WaterBreathing, WaterWalk, Web, Weird, WindWalk, WindWall, Wish, WitchBolt, WordofRecall,
        WrathfulSmite, ZoneofTruth
    }

    public static class LoadData
    {

    }
}
