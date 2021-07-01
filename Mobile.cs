using System;

namespace Day2
{
    class Mobile : Equipment
    {
        protected int NoOfWheels;

        public Mobile(int NoOfWheels, string name, string description, string typeofEquipment) : base(name, description, typeofEquipment)
        {
            this.NoOfWheels = NoOfWheels;
        }
        public override void MoveBy(float distance)
        {
            this.distancemoved+= distance;

            this.MaintainanceCost+=(NoOfWheels * distance);
        }

    }
}
