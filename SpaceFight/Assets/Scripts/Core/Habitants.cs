using UnityEngine;
using System.Collections;
using ErIntGlobal.Core;

namespace ErIntGlobal.Core
{
    enum HabitantsType
    {
        Null,
        Citizen,
        Gatherer,
        Hunter,
        Scout,
        Soldier,
        Scientist,
        HeavySoldier,
        Engineer,
        Pilot
    }

    enum VillagersType
    {
        Null,
        Chief,
        Villager,
        Hunter,
        Scout,
        Warrior
    }

    public class Habitants : BasicHabitants
    {
        
    }

    public abstract class BasicHabitants
    {
        private int _amount;
        public int Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }

        [Range(30, 185)]
        private int IQAverage;
        public int IQ
        {
            get { return IQAverage; }
            set
            {
                if (value <= 180 || value >= 35)
                    IQAverage = value;
                else
                    IQAverage = 80;
            }
        }

        [Range(0, 100)]
        public float[] PerReproGender;
        [Range(0, 100)]
        public float[] PerNonRepGender;

        public BasicHabitants()
        {
            _amount = 0;
            IQAverage = 100;
            PerReproGender = new float[2];
            PerReproGender[0] = 100;
            PerReproGender[1] = 100;
            PerNonRepGender = new float[2];
            PerNonRepGender[0] = 100;
            PerNonRepGender[1] = 100;
        }
        public BasicHabitants(int a, int i, float[] pg, float[]png)
        {
            _amount = a;
            IQAverage = i;
            PerReproGender = pg;
            PerNonRepGender = png;
        }
    }
}
