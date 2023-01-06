using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    internal class CustomException_ : Exception
    {
        private string message;

        public CustomException_(string message)
        {
            this.message = message;
        }

        public void print()
        {
            Console.WriteLine(message);
        }
    }

    //////////////////////////////////////////

    internal class Human
    {
        protected string _name;
        protected string _surname;
        protected System.DateTime _birthDate;

        public Human(string name, string surname, DateTime birthDate)
        {
            Name = name;
            Surname = surname;
            BirthDate = birthDate;
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (value == "")
                    throw new CustomException("Name can't be empty.");
                _name = value;
            }
        }

        public string Surname
        {
            get { return _surname; }
            set
            {
                if (value == "")
                    throw new CustomException("Surame can't be empty.");
                _surname = value;
            }
        }

        public System.DateTime BirthDate
        {
            get;
            set;
        }

        public virtual void act()
        {
            Console.Write("Exists");
        }

        public void print()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Surname);
            Console.WriteLine(BirthDate);
        }
    }

    internal class Builder : Human
    {
        protected uint _experience;

        public Builder(string name, string surname, DateTime birthDate, uint experience) : base(name, surname, birthDate)
        {
            Experience = experience;
        }

        public UInt32 Experience
        {
            get;
            set;
        }

        public override void act()
        {
            base.act();
            Console.Write(" and builds");
        }
    }

    internal class Sailor : Human
    {
        protected string _rank;

        public Sailor(string name, string surname, DateTime birthDate, string rank) : base(name, surname, birthDate)
        {
            Rank = rank;
        }

        public string Rank
        {
            get { return _rank; }
            set
            {
                if (value == "")
                    throw new CustomException("Name can't be empty.");
                _rank = value;
            }
        }

        public override void act()
        {
            base.act();
            Console.Write(" and sails");
        }
    }

    internal class Pilot : Human
    {
        protected uint _hours;

        public Pilot(string name, string surname, DateTime birthDate, uint hours) : base(name, surname, birthDate)
        {
            Hours = hours;
        }

        public uint Hours
        {
            get;
            set;
        }

        public override void act()
        {
            base.act();
            Console.Write(" and flights");
        }
    }

    //////////////////////////////////////////

    internal class Passport
    {
        protected Human _human;
        protected string _birthPlace;
        protected uint _series;
        protected uint _number;

        public Passport(string name, string surname, DateTime birthDate, string birthPlace, uint series, uint number)
        {
            Human = new Human(name, surname, birthDate);
            BirthPlace = birthPlace;
            Series = series;
            Number = number;
        }

        public Human Human
        {
            get;
            set;
        }

        public string BirthPlace
        {
            get;
            set;
        }

        protected uint Series
        {
            get;
            set;
        }

        protected uint Number
        {
            get;
            set;
        }

        public virtual void print()
        {
            _human.print();
            Console.WriteLine(BirthPlace);
            Console.WriteLine(Series);
            Console.WriteLine(Number);
        }
    }

    internal class ForeignPassport : Passport
    {
        protected uint _foreignNumber;
        protected string[] _visas = null;

        public ForeignPassport(string name, string surname, DateTime birthDate, string birthPlace, uint series, uint number, uint foreignNumber, string[] visas = null)
            : base(name, surname, birthDate, birthPlace, series, number)
        {
            ForeignNumber = foreignNumber;
            if (!(visas is null))
            {
                Visas = visas;
            }
        }

        public uint ForeignNumber
        {
            get;
            set;
        }

        public string[] Visas
        {
            get;
            set;
        }

        public override void print()
        {
            base.print();
            Console.WriteLine(ForeignNumber);
            if (!(Visas is null))
            {
                foreach (var i in Visas)
                    Console.WriteLine(i);
            }
        }
    }
}
