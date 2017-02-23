using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textBasedRPG_Project_Gump_
{
    class Program
    {
        #region variable initializations and declartions
        //Array used to help generate characters
        static string[] characters = new string[] { "Forest Gump ", "Man-Bear-Pig", "Big Al", "James Earl Jones", "Bi-Polar Bear" };
        //Array(s) for base stats of characters
        static int[] characterArmor = new int[] { 7, 21, 69, 24, 13 };
        static int[] characterAttack = new int[] { 5, 23, 15, 27, 12 };
        //Global variables used in game
        static int characterHealth = 25; // base health of Lv. 1 character
        static int baseArmor = 10; // players base armor at Lv. 1
        static int baseAttack = 15; // players base attack at Lv. 1
        static int mula = 0; // currency used in the game 
        static int baseArmorCost = 25; // intial cost for Lv. 2 armor upgrade
        static int baseWeaponCost = 20; // intial cost for Lv. 2 weapon upgrade
        static int weaponAttack = 20; // intial bonus attack for Lv. 1 weapon
        static int armorDef = 20; // intial bonus defense for Lv. 1 armor
        static int weaponLv1 = 1; // player's current weapon level
        static int armorLv1 = 1; // player's current armor level
        static int experiance = 0; // player's XP gained so far
        static int level = 1; // player's current level 
        static int health = 100; // intial health
        static int actionPts = 50; // intial action points
        static int maxAP = 50; // max amount of action points based on player's current level
        static int maxHealth = 100; //max amount of health bases on player's current level
        static Random rand = new Random();
        #endregion

        static void Main(string[] args)
        {
        }
    }
}
