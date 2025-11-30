using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Person
{
    internal class Person
    {
        string name;
        string surname;
        DateTime date;
        public Person()
        {
            name = "Noname";
            surname = "Nosurname";
            date = new DateTime(2008, 1, 28);
        }
        public Person(string name, string surname, DateTime date)
        {
            this.name = name;
            this.surname = surname;
            this.date = date;
        }
        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length < 1) throw new Exception("Неподходящее имя");
                this.name = value;
            }
        }
        public string Surname
        {
            get { return surname; }
            set
            {
                if (value.Length < 1) throw new Exception("Неподходящая фамилия");
            }
        }
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        public int Year
        {
            get => date.Year;
            set
            {
                if(value>0)
                {
                    date = new DateTime(value, date.Month, date.Day);
                }
            }
        }
        public override string ToString()
        {
            return $"Имя: {name}, фамилия: {surname}, год рождения: {date.ToString()}";
        }
        public virtual string ToShortString()
        {
            return $"Имя: {name}, фамилия: {surname}";
        }
    }
}