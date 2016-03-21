
using ISDTrialTest.Enum;
using ISDTrialTest.Interface;

namespace ISDTrialTest
{
    public abstract class Family : IMove, IWork
    {
        private string _name;
        private int _age;
        private Gender _gender;

        protected string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        protected int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        protected Gender Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        protected Family(string name, int age, Gender gender)
        {
            _name = name;
            _age = age;
            _gender = gender;
        }

        public virtual void Move()
        {
        }

        public virtual void Work()
        {
        }
    }
}
