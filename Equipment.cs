using System;


namespace Day2
{
    abstract class Equipment
    {
        protected string name;
        protected string description;
        protected float distancemoved = 0;
        protected string typeofEquipment;
        protected float MaintainanceCost = 0;
        public abstract void MoveBy(float distance);

        protected Equipment(string name, string description, string typeofEquipment)
        {
            this.name = name;
            this.description = description;
            this.typeofEquipment = typeofEquipment;
        }

        public float GetDistanceMoved()
        {
            return this.distancemoved;
        }

        public float GetMaintainanceCost()
        {
            return this.MaintainanceCost;
        }

        public string GetName()
        {
            return this.name;
        }

        public string Gettype()
        {
            return this.typeofEquipment;
        }

        public string GetDescription()
        {
            return this.description;
        }
    }

}
