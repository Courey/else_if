using System;
namespace VideoGame
{

   class Character
   {
      private string mCharacterType;
      private int mCharacterLevel;
      private double mCharacterHP;

      // getters: pCharacterType, pCharacterLevel, pCharacterHP.
      public string getCharacterType()
      {
         return mCharacterType;
      }

      public int getCharacterLevel()
      {
         return mCharacterLevel;
      }

      public double getCharacterHP()
      {
         return mCharacterHP;
      }


      // setters: pCharacterType, pCharacterLevel, pCharacterHP.
      public void setCharacterType(string type)
      {
         mCharacterType = type;
         // if statements can go in here, but was requested in main method.
      }

      public void setCharacterLevel(int level)
      {
         mCharacterLevel = level;
      }

      public void setCharacterHP(double HP)
      {
         mCharacterHP = HP;
      }


      // ToString method
      public override string ToString()
      {
         return getCharacterType() + "(Level: " + getCharacterLevel() + ") \n" + getCharacterHP();
      }


      //Constructor: Character
      public Character(string characterType, int characterLevel, double characterHP)
      {
         characterType = Mutant; //Default type error code. If your character is a mutant, you screwed up. Return to 1301.
         characterLevel = -100; //Default Level error code. Impossible to have a negative level.
         characterHP = -12345.6; //Default HP error code. I made it impossibly low for the scope, but not ridiculously low.
         //I made it 12345 because I'm lazy and it's easy to remember, but to remind me to condider
         //it as a double, I tacked on the .6.
      }



      public class TestCharacter
      {
         public static void Main(string[] args)
         {

            Character character1 = new Character("hero", 5, 7);
            //************ignore till you're ready to let fly**************

            //Type options, default, and error handling.
            if (characterType == hero) // 1st player
            {
               character1.setCharacterType("Brave Hero");
            }
            else if (characterType == monster) // The bad guy. Really bad. Scary bad. 
            {
               character1.setCharacterType("Monster");
            }
            else if (characterType == NCP) // Non-controller player. Any computer driven character that joins the party.
            {
               character1.setCharacterType("2 player-NCP");
            }
            else if (characterType == plotCharacter) // Peasants. Can't esacape them, they're everywhere. 
            {
               character1.setCharacterType("Towns Person");
            }
            else if (characterType == mutant) // default setting for error handling.
            {
               Console.WriteLine("GAME OVER /n You have already lost because you couldn't even pick a character right.");
               Console.WriteLine("Press any key after seriously considering whether or not you're gaming material.");
               Console.ReadLine();

            }
            else // Pure, unabashed superstition. I don't think this is possible, but if I don't put it in, it will be.
            {
               Console.WriteLind("The cake is a lie.");
               Console.ReadLine();
            }

            // level options, test, and methods.
            



            // HP options, test, and methods.



         }

      }
   }
}
