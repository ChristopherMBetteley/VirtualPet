using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;


namespace VirtualPet
{
    class Program
    {
        //public static object playerPet { get; private set; }

        static void Main(string[] args)
        {
            //setting up the console
            Console.SetWindowSize(48, 26);
            Console.Title = "                                 My Virtual Pet";

            
            //creating variables
            User currentUser;
            Pet currentPet;

            ProgramStartingProcedure();
            StartingMenu();
            

            while (true)
            {
                Console.Clear();
                currentUser = CreateUser();
                Console.WriteLine("\nHello, " + currentUser.Name);
                currentPet = CreatePet();

                Console.Clear();
                Console.WriteLine("\n\n\n\n\n\nAwesome.  You and " + currentPet.Name + " \nare going to have so much fun together.");
                Console.WriteLine("\nJust be sure you don't neglect \nyour new responsibilities.");
                Console.WriteLine("\n\n\nPress any key to start your game.");
                Console.Clear();
                
                Tick(currentPet, currentUser);
                playAgainMenu();



    }
        }
        static void ProgramStartingProcedure()//shows welcome screen. only runs on initial start
        {
            Console.WriteLine("\n\n\n   #################       /\\__/\\");
            Console.WriteLine("   #               #      /`    '\\");
            Console.WriteLine("   #    WELCOME    #    === 0  0 ===");
            Console.WriteLine("   #               #      \\  --  /");
            Console.WriteLine("   #    TO YOUR    #     /        \\");
            Console.WriteLine("   #               #    /          \\");
            Console.WriteLine("   #  VIRTUAL PET  #   |            |");
            Console.WriteLine("   #               #    \\  ||  ||  /");
            Console.WriteLine("   #################     \\_oo__oo_/#######o");
            
        }
        static User CreateUser()
        {
            string userInput;

            Console.WriteLine("\nPlease enter your Name.");
            userInput = Console.ReadLine();
            User newUser = new User(userInput);
            
            return newUser;
        }//creates the current user
        static Pet CreatePet()
        {
            string userInput;

            Console.WriteLine("Please enter your new pet's Name.");
            userInput = Console.ReadLine();

            Pet newPet = new Pet(userInput);

            return newPet;
        }//creates the current pet
        static void StartingMenu()
        {
            int menuOption;
            Console.WriteLine("\n     Literally Minutes and Minutes of Fun.");
            Console.WriteLine("\n\n\n\tWould you like to play a game?\n");

            while (true)
            {
                
                Console.WriteLine("\t1. Play\n\t2. Learn How to Play\n\t3. About\n\t4. Quit");
                menuOption = int.Parse(Console.ReadLine());

                if (menuOption == 1)
                {
                    Console.Clear();
                    return;
                }
                else if (menuOption == 2)
                {
                    Console.Clear();
                    learnPage();
                    Console.Clear();
                    Console.WriteLine("\n\n\n   #################       /\\__/\\");
                    Console.WriteLine("   #               #      /`    '\\");
                    Console.WriteLine("   #    Welcome    #    === 0  0 ===");
                    Console.WriteLine("   #               #      \\  --  /");
                    Console.WriteLine("   #    TO YOUR    #     /        \\");
                    Console.WriteLine("   #               #    /          \\");
                    Console.WriteLine("   #  VIRTUAL PET  #   |            |");
                    Console.WriteLine("   #               #    \\  ||  ||  /");
                    Console.WriteLine("   #################     \\_oo__oo_/#######o\n\n");
                    Console.WriteLine("What would you like to do?");
                    continue;
                }
                else if (menuOption == 3)
                {
                    Console.Clear();
                    aboutPage();
                    Console.Clear();
                    Console.WriteLine("\n\n\n   #################       /\\__/\\");
                    Console.WriteLine("   #               #      /`    '\\");
                    Console.WriteLine("   #    Welcome    #    === 0  0 ===");
                    Console.WriteLine("   #               #      \\  --  /");
                    Console.WriteLine("   #    TO YOUR    #     /        \\");
                    Console.WriteLine("   #               #    /          \\");
                    Console.WriteLine("   #  VIRTUAL PET  #   |            |");
                    Console.WriteLine("   #               #    \\  ||  ||  /");
                    Console.WriteLine("   #################     \\_oo__oo_/#######o\n\n");
                    Console.WriteLine("What would you like to do?");
                    continue;
                }
                else if (menuOption == 4)
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\nI'm sorry, that was an invalid option.\nPlease try again.\n\n");
                    Console.WriteLine("What would you like to do?");
                    
                } 
            }
        }
        static void GamePlayValues(Pet playerPet)
        {
            
            Console.WriteLine("\n   #################       /\\__/\\");
            Console.WriteLine("   #               #      /`    '\\");
            Console.WriteLine("   #   Life with   #    === 0  0 ===");
            Console.WriteLine("   #               #      \\  --  /");
            Console.WriteLine("   #   your pet.   #     /        \\");
            Console.WriteLine("   #               #    /          \\");
            Console.WriteLine("   #   Have Fun!   #   |            |");
            Console.WriteLine("   #               #    \\  ||  ||  /");
            Console.WriteLine("   #################     \\_oo__oo_/#######o");
            

            Console.WriteLine("\n\t    CURRENT HEALTH STATS");
            Console.Write("\tHunger =  " + playerPet.Hunger);
            Console.WriteLine("\tThirst =  " + playerPet.Thirst);
            Console.Write("\tBladder = " + playerPet.Waste);
            Console.WriteLine("\tBoredom = " + playerPet.Boredom);
            Console.Write("\tLove =    " + playerPet.Love);
            Console.WriteLine("\tOverall = " + playerPet.OverallHealth);
            Console.WriteLine("\nKeep your overall health above 2");
        }//shows pet's current health stats
        static void GamePlayMenu(Pet playerPet)
        {
            Console.WriteLine("\nHow would you like to interact with " + playerPet.Name);
            Console.WriteLine("\t1. Feed\t\t 4. Water");
            Console.WriteLine("\t2. Love\t\t 5. Potty");
            Console.WriteLine("\t3. Play ");
        }//shows user interactions with pet
        static void Tick(Pet playerPet,User Player)
        {
            int gamePlayMenuOption;
            //Creates Timer

            while (playerPet.OverallHealth >2)
            {
                GamePlayValues(playerPet);
                GamePlayMenu(playerPet);
                gamePlayMenuOption = int.Parse(Console.ReadLine());
                if (gamePlayMenuOption == 1)
                {
                    playerPet.PetFeed();
                    playerPet.PetOverall();
                    Console.Clear();
                }
                else if (gamePlayMenuOption == 2)
                {
                    playerPet.PetLove();
                    playerPet.PetOverall();
                    Console.Clear();
                }
                else if (gamePlayMenuOption == 3)
                {
                    playerPet.PetPlay();
                    playerPet.PetOverall();
                    Console.Clear();
                }
                else if (gamePlayMenuOption == 4)
                {
                    playerPet.PetWater();
                    playerPet.PetOverall();
                    Console.Clear();
                }
                else if (gamePlayMenuOption == 5)
                {
                    playerPet.PetPotty();
                    playerPet.PetOverall();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("I'm sorry, that was an invalid option.\nPress any key to try again.");
                    Console.ReadKey();
                    Console.Clear();
                }

                
                
            }
        }//takes user through the gameplay
        static void aboutPage()
        {
            Console.Clear();
            Console.WriteLine("\n\n\n   #################       /\\__/\\");
            Console.WriteLine("   #               #      /`    '\\");
            Console.WriteLine("   #     ABOUT     #    === 0  0 ===");
            Console.WriteLine("   #               #      \\  --  /");
            Console.WriteLine("   #      THE      #     /        \\");
            Console.WriteLine("   #               #    /          \\");
            Console.WriteLine("   #  VIRTUAL PET  #   |            |");
            Console.WriteLine("   #               #    \\  ||  ||  /");
            Console.WriteLine("   #################     \\_oo__oo_/#######o\n\n");

            Console.WriteLine("Developed and Programed by:\n\n\t\t\tChristopher Betteley");
            Console.WriteLine("\t\t\t\t\t2016");
            Console.WriteLine("\n\n\nPress any key to return to the main menu.");
            Console.ReadKey();
            Console.Clear();
        }
        static void learnPage()
        {
            Console.Clear();
            Console.WriteLine("\n\n\n   #################       /\\__/\\");
            Console.WriteLine("   #               #      /`    '\\");
            Console.WriteLine("   #     LEARN     #    === 0  0 ===");
            Console.WriteLine("   #               #      \\  --  /");
            Console.WriteLine("   #    TO PLAY    #     /        \\");
            Console.WriteLine("   #               #    /          \\");
            Console.WriteLine("   #  VIRTUAL PET  #   |            |");
            Console.WriteLine("   #               #    \\  ||  ||  /");
            Console.WriteLine("   #################     \\_oo__oo_/#######o\n\n");

            Console.WriteLine("Your goal is to keep your pet happy and healthy.");
            Console.WriteLine("Interact with your pet to take care of them.");
            Console.WriteLine("Overall Health must stay above \"2\"");
            Console.WriteLine("Will you share a long and happy life?");
            Console.WriteLine("Play and find out.");
            Console.WriteLine("\n\n\nPress any key to return to the main menu.");
            Console.ReadKey();
            Console.Clear();
        }
        static void playAgainMenu()
        {
            int userInput;
            Console.WriteLine("You lose");
            while (true)
            {
                Console.WriteLine("\n\nWould you like to play again?");
                Console.WriteLine("\t1. Play again\n\t2.Quit");
                userInput = int.Parse(Console.ReadLine());
                if (userInput == 1)
                {
                    return;
                }
                else if (userInput == 2)
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("I'm sorry, that was an invalid option.\nPress any key to try again.");
                    Console.ReadKey();
                }
            }
            
        }
        public static void myTimer(object source, ElapsedEventArgs e)
        {
            int a = 1;
            Console.WriteLine(a++);
        }

    }
}
