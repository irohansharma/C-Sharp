using System;


namespace Day2
{
    class Immobile : Equipment
    {

        protected float Weight;

        public Immobile(float Weight, string name, string description, string typeofEquipment) : base(name, description, typeofEquipment)
        {
            this.Weight = Weight;
        }

        public override void MoveBy(float distance)
        {
            this.distancemoved+= distance;

            this.MaintainanceCost+=(Weight * distance);
        }

        
    }
}
