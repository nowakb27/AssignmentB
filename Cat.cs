using System;

namespace MobileAppModule1
{
    class Cat : Pet, ITalkable
    {
        private int mousesKilled;

        public Cat(int mousesKilled, string name) : base(name)
        {
            this.mousesKilled = mousesKilled;
        }

        public int GetMousesKilled()
        {
            return mousesKilled;
        }

        public void AddMouse()
        {
            mousesKilled++;
        }

        public string Talk()
        {
            return "Meow";
        }
    }
}