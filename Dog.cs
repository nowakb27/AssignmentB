using System;

namespace MobileAppModule1
{
    class Dog : Pet, ITalkable
    {
        private bool friendly;

        public Dog(bool friendly, string name) : base(name)
        {
            this.friendly = friendly;
        }

        public bool IsFriendly()
        {
            return friendly;
        }

        public string Talk()
        {
            return "Bark";
        }
    }
}