using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Players
{
    class Player
    {
        private string firstname;
        private string lastname;
        private double weight;
        private int age;

        public Player(string firstname, string lastname, double weight, int age)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.weight = weight;
            this.age = age;

        }

        public Player(string firstname, string lastname) : this(firstname, lastname, 80, 30) { }
        public override string ToString()
        {
            return $"{firstname} {lastname}, waga: {weight} kg, wiek: {age} lat";
        }

        public static Player CreateFromString(string strplayer)
        {
            string firstname, lastname;
            int age;
            double weight;
            var ar = strplayer.Split('|');
            if (ar.Length == 4)
            {
                firstname = ar[0];
                lastname = ar[1];
                weight = double.Parse(ar[2]);
                age = int.Parse(ar[3]);
                
                return new Player(firstname, lastname, weight, age);
            }
            throw new Exception("Błędny format danych z pliku");
        }

        public string Firstname { get { return firstname; } set { firstname = value; } }
        public string Lastname { get { return lastname; } set { lastname = value; } }
        public double Weight { get { return weight; } set { weight = value; } }
        public int Age { get { return age; } set { age = value; } }

        public string ToFileFormat()
        {
            return $"{Firstname}|{Lastname}|{Weight}|{Age}";
        }


    }
}
