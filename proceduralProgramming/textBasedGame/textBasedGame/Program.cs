using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textBasedGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rick Harrison's Pawn Shop. In a moment you'll meet the man himself, but you should know a few things before we begin. All your answers must be in lowercase letter(s) and remember not to get offened by anything because that's not cool.\nDisclaimer: there is nothing offensive in this game, and I don't own rights to any thing having to do with Rick Harrison's fricking pawn shop, okay.\nLet's begin!");
            int memeLord = 50;
            int knowledge = 25;
            Console.WriteLine("Welcome to my pawn shop, my name is Rick Harrison.");
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Welcome to the shop, " + name);
            Console.WriteLine("I work here with my old man and my son, Big Hoss. Everything in here has a story and a price. One thing I've learned after 21 years - you never know WHAT is gonna come through that door.");
            Console.WriteLine("\nLets go ahead and start the tour of the shop! What would you like to do first? \n Check out my merchandise \n Sell your junk \n Get in a fight with my old man\n");         
            string activity = Console.ReadLine();
            if (activity == "check out my merchandise")
            {
                knowledge = knowledge + 10;
                Console.WriteLine("\nSo you think you can just check out my MERCHANDISE, " + name + " , well you're right. Lets make a deal. You got a little smarter as well, \n'Knowledge is power', your knowledge is now: " + knowledge);
            }
            else if (activity == "sell your junk")
            {
                memeLord = memeLord + 25;
                Console.WriteLine("\nYou must be a fricking genius Gump, the best I can do is $0.25 though. Let me call in one of my guys \nYou're pretty edgy, your dankness level is now: " + memeLord);
            }
            else if (activity == "get in a fight with my old man")
            {
                knowledge = knowledge + 75;
                memeLord = memeLord + 8950;
                Console.WriteLine("Ya think you got it in ya, " + name + ", you're gonna get wrecked! FIGHT \nUse your new power levels to defeat OLD MAN: knowledge = " + knowledge + ", dankness = " + memeLord);
                Console.WriteLine("\n(yeah son/nah bruh) you think you can take em? \n");
                string activity2 = Console.ReadLine();
                if (activity2 == "yeah son")
                {
                    Console.WriteLine("Alright big fella, let's go then!!");
                    Console.WriteLine("Old man - 'So I hear you wanna fight me, bring it on you rascal!'\nOld man decides to punch you square in the throat... What will you do next?");
                    Console.WriteLine("Lets give him a good beating ;)\ndecide your next move\n Throw a trophy at his pacemaker\n Run him over with a red 1969 Corvette\n shank him in his only kidney");
                    string activity3 = Console.ReadLine();
                    if (activity3 == "throw a trophy at his pacemaker")
                    {
                        Console.WriteLine("The trophy broke the pacemaker in half and he died, Congrats! You killed a old man you animal. Also Rick kicked you out of his shop, forever.");
                    }
                    else if (activity3 == "run him over with a red 1969 corvette")
                    {
                        Console.WriteLine("The Corvette didn't kill him, well almost, but you're still a piece of crap. You've been kicked out... Forever!");
                    }
                    else if (activity3 == "shank him in his only kidney")
                    {
                        Console.WriteLine("Way to go, you bamboozled the heck outta that old man, you are actually garbage. You've been kicked out of the shop... Forever.");
                    }
                    else if (activity2 == "nah bruh")
                    {
                        Console.WriteLine("That's a good choice, he would've destoryed your life.");
                    }
                    else
                    {
                        knowledge = knowledge - 10;
                        Console.WriteLine("That's not an option, you played yourself. Your knowledge is lowered: " + knowledge);
                    }
                }
            }
        }
    }
}
