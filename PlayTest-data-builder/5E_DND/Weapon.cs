using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace PlayTest_data_builder._5E_DND
{
    public struct Weapon : ISerializable
    {
        string Label;
        DieType DamageDie;
        DamageTypes DamageType;
        int DieNum;
        int RangeMin;
        int RangeMax;
        WeaponProperties[] WeaponProps;

        public Weapon(string label, DieType damageDie, DamageTypes damageType, int dieNum, int rangeMin, int rangeMax, WeaponProperties[] weaponProps)
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
    public enum WeaponProperties
    {
        Ammunition, Finesse, Heavy, Light, Loading, Reach, Special, Thrown, TwoHanded, Versatile
    }

    [Serializable()]
    public enum DamageTypes
    {
        Acid, Bludgeoning, Cold, Fire, Force, Lightning, Necrotic, Piercing, Poison, Psychic, Radiant, Slashing, Thunder
    }

    [Serializable()]
    public enum Weapons
    {
        Battleaxe, Blowgun, Boomerang, Club, CrossbowHand, CrossbowHeavy, CrossbowLight, Dagger, Dart, DoubleBladdedScimitar, Flail, Glaive, Greataxe, Greatclub, Greatsword, Halberd, Handaxe,
        Javeline, Lance, LightHammer, Longbow, Longsword, Mace, Maul, Morningstar, Net, Pike, Quarterstaff, Rapier, Scimitar, Shortbow, Shortsword, Sickle, Sling, Spear, Trident, WarPick, Warhammer, Whip, Yklwa
    }
}
