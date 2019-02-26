using System;
namespace Scripting_201910_Parcial1_base.Logic
{
    public abstract class Vehicle
    {
        protected float baseMaxSpeed;

        protected int Level { get; set; }

        protected abstract VehicleType Type { get; }

        protected Part CurrentPart { get; set; }

        public float MaxSpeed
        {
            get
            {
                return baseMaxSpeed;
            }
        }

        public Vehicle()
        {
        }

        public Vehicle(float _baseMaxSpeed)
        {
            baseMaxSpeed = _baseMaxSpeed;
            Level = 0;
            CurrentPart = null;
        }

        public bool Equip(Part part)
        {
            bool result = false;

            if (part.Type == VehicleType.Any || part.Type==VehicleType.Car|| part.Type==VehicleType.Bike)
            {
                
                baseMaxSpeed = baseMaxSpeed * part.SpeedBonus;

            }
           
            

            return result;
        }

        public void Upgrade()
        {
            float baseSpeed;
            if (Level > 0 && Level <= 3)
            {

                if (Level == 1)
                {
                   
                    baseSpeed = baseMaxSpeed * 0.05f;
                    baseMaxSpeed = baseMaxSpeed + baseSpeed;
                }
                if (Level == 2)
                {
                    baseSpeed = baseMaxSpeed * 0.05f;
                    baseMaxSpeed = baseMaxSpeed + baseSpeed;
                }
                if (Level == 3)
                {
                    
                    baseSpeed = baseMaxSpeed * 0.05f;
                    baseMaxSpeed = baseMaxSpeed + baseSpeed;
                }
            }
        }
    }
}