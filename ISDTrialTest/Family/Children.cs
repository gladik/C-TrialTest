using ISDTrialTest.Enum;
using System;

namespace ISDTrialTest
{
    internal class Children : Family
    {
        public Children(string name, int age, Gender gender) : base(name, age, gender)
        {
        }

        public override void Move()
        {
            Console.WriteLine("{0} совершила{1} движение.", Name, Gender == Gender.Female ? "а" : "");
        }
    }
}
