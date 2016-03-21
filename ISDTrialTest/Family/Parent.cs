using ISDTrialTest.Enum;
using System;

namespace ISDTrialTest
{
    internal class Parent : Family
    {
        public Parent(string name, int age, Gender gender) : base(name, age, gender)
        {
        }

        public override void Work()
        {
            Console.WriteLine("{0} совершил{1} дейсвтие.", Name, Gender == Gender.Female ? "а" : "");
        }
    }
}
