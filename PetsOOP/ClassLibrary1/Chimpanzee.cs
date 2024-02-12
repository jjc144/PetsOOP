using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Chimpanzee : Pet
    {
        public Chimpanzee(string name) : base(name)
        {

        }
        public override void MakeSound()
        {
            Console.WriteLine(Name + "hoots at you.");
        }

        public void Swings()
        {
            Console.WriteLine(Name + "swings at you.");
        }

        public void Meet(Turtle newFriend)
        {
            Console.WriteLine(Name + "plays at" + newFriend.Name);
        }

        public void Meet(Cat newFriend)
        {
            Console.WriteLine(Name + "throws at" + newFriend.Name);
        }
    }
}
