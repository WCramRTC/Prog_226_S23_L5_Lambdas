using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_226_S23_L5_Lambdas
{
    public class Player
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Hp { get; set; }

        public Player(string firstName, string lastName, int hp)
        {
            FirstName = firstName;
            LastName = lastName;
            Hp = hp;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} {Hp}";
        }
    }
}
