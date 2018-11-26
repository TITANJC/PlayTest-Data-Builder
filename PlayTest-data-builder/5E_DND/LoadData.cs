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
    public struct Item : ISerializable
    {
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }

    [Serializable()]
    public enum DieType
    {
        d4 = 4, d6 = 6, d8 = 8, d10 = 10, d12 = 12, d20 = 20, percentile = 100
    }

    [Serializable()]
    public enum DurationType
    {
        seconds, rounds, minutes, days, weeks, months, standardAction
    }

    [Serializable()]
    public enum Actions
    {
        MeleeAttack, RangedAttack, Save, Check, TakeDamage
    }
    

    public static class LoadData
    {

    }
}
