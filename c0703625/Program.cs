using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c0703625
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new TestQuestion2();
            //a.PlayingWithForLoops();

            var b = new birthday_party();
            b.setupPartyList();
          Console.WriteLine( b.printPartyList());
            Console.WriteLine(b.printPartyList_reverse());

        }
    }

    class TestQuestion2
    {
        public int myFavoriteVariable = 0;

        public void PlayingWithForLoops()
        {
            // write a For Loop to Add 10 Numbers
            while (MyMethod())
            {
                if (myFavoriteVariable > 10)
                {
                    Console.WriteLine("i am so out of here!");
                    break;
                }
                Console.WriteLine("oh no I have to go through this stupid loop again...");
            }
        }
        public bool MyMethod()
        {
            myFavoriteVariable++;
            return true;
        }
    }

    class dog
    {
        public dog(string name, string breed)
        {
            dog_name = name;
            dog_breed = breed;
        }

        public dog()
        {
        }

        public string dog_name;
        public string dog_breed;
        public dog next_dog;
        public dog prev_dog;

    }

    class birthday_party
    {
        public dog peanut;
        public dog fifi;
        public dog clarence;
        public dog giselle;
        public dog lulu;
        public dog roy;

        public dog head;
        public dog tail;
        public dog temporary;

        public void setupPartyList()
        {
            peanut = new dog("Peanut", "Bichon");
            fifi = new dog("Fifi", "Poodle");
            clarence = new dog("Clarence", "German Sheppard");
            giselle = new dog("giselle", "borker colllie");
            lulu = new dog("lulu", "shitzu");
            roy = new dog("Roy", "Beagle");

            peanut.prev_dog = null;
            peanut.next_dog = fifi;

            fifi.prev_dog = peanut;
            fifi.next_dog = clarence;

            clarence.prev_dog = fifi;
            clarence.next_dog = giselle;

            giselle.prev_dog = clarence;
            giselle.next_dog = lulu;

            lulu.prev_dog = giselle;
            lulu.next_dog = roy;


            roy.prev_dog = lulu;
            roy.next_dog = null;
            head = peanut;
            tail = roy;
        }

        public string printPartyList()
        {
            string inviteList = "*--";
            temporary = head;
            inviteList += temporary.dog_name + " * --- * ";
            while (temporary.next_dog != null)
            {
                // Console.WriteLine(temporary.next_dog.dog_name);
                temporary = temporary.next_dog;
                inviteList += temporary.dog_name + " * --- * ";
               
            }
           
            return inviteList;
        }

        public string printPartyList_reverse()
        {
            string inviteList = "*--";
            temporary = tail;
            inviteList += temporary.dog_name + " * --- * ";
            while (temporary.prev_dog != null)
            {
                // Console.WriteLine(temporary.next_dog.dog_name);
                temporary = temporary.prev_dog;
                inviteList += temporary.dog_name + " * --- * ";
                
            }

            return inviteList;
        }
    }
}