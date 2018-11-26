using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace PlayTest_data_builder._5E_DND
{
    public struct Spell : ISerializable
    {
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }

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
}
