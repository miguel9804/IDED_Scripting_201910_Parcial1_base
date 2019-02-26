using System;
namespace Scripting_201910_Parcial1_base.Logic
{
    public abstract class Part
    {
        protected float speedBonus;
        public float speedLimit = 0.5f;
            
        

        public int Level { get; protected set; }
        public abstract VehicleType Type { get; }

        public float SpeedBonus
        {
            get { return 0F; }
            protected set { speedBonus = value; }
        }

        public Part()
        {
        }

        public Part(float speedBonus)
        {
            SpeedBonus = speedBonus * speedLimit;
           
        }

        public void Upgrade()
        {
            float speed;
            
            
            if(Level>=0 && Level<=3)
            {
                
                if (Level == 1)
                {
                    speed = SpeedBonus * 0.03f;
                    SpeedBonus = SpeedBonus + speed;
                }
                if(Level==2)
                {
                    speed = SpeedBonus * 0.03F;
                    SpeedBonus = SpeedBonus + speed;
                }
                if(Level == 3)
                {
                    speed = SpeedBonus * 0.03f;
                    SpeedBonus = SpeedBonus + speed;
                }
            }
           
        }
    }
}