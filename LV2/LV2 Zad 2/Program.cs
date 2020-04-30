using System;

namespace LV2
{
    class Die
    {
        private int sidesCount;
        private static Random random = new Random();
        public Die(int sidesCount)
        {
            this.sidesCount = sidesCount;
        }
        public static int RandomGenerate()
        {
            return random.Next(32);
        }
        public int Roll(int sidesCount)
        {
            return random.Next(1, sidesCount + 1);
        }
        static void Main(string[] args)
        {
            DiceRoller roller = new DiceRoller();
            Die dice = new Die(6);
            for (int i = 0; i < 20; i++)
            {
                roller.InsertDie(dice);
                dice.Roll(6);
                Console.Write(dice.Roll(6) + " ");
            }
        }
    }
}
