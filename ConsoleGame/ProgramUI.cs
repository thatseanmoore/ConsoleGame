using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    public class ProgramUI
    {
        private void TunnelEnding()
        {
            Console.Clear();
            Console.WriteLine("You emerge from the darkened tunnel to the light beaming in from the other end. \n" +
                "As the light begins to illuminate your surrounding area you see three destinct Caves directly in front of you.\n" +
                "To the left is a dimly lit cave, directly ahead is a slightly large cave opening, and to the right is a cave with barely enough space to crawl into. \n" +
                "What will it be?");
            Console.WriteLine("Please type your answer: (Hint: Left, center, or right");

            string tunnelAnswer = Console.ReadLine();

            if (tunnelAnswer == "left")
            {

                Console.WriteLine("You veer off to the left heading towards the dimly lit cavern.");
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
                LeftCave();

            }

            else
            {
                TunnelEnding();
            }
            if (tunnelAnswer == "center")
            {
                Console.WriteLine("You head straight forward towards the largest of the three caves.\n" +
                    "You scurry inside the cave safely");
                Console.Clear();
                Console.WriteLine("Wow this cave sure is large. The ceilings must be at least 20 feet.");
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
                OldRustyReef();
            }
            if (tunnelAnswer == "right")
            {
                Console.WriteLine("You run off to the right towards the smallest of the three caves.\n" +
                    "You squeeze your little Octopus body into the small cave enterance");
                Console.Clear();
                Console.WriteLine("You squeeze through the opening until you find yourself firmly inside the cave with a path forward.");
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
                OldRustyReef();
            }
        }
        private void OldRustyReef()
        {
            Console.Clear();

            Console.WriteLine("You swim over to the old rusty reef in the background. \n" +
                "Immediately upon entering the reef you sense that something just isn't right. You feel as if you are being watched. \n" +
                " You swim forward and immediately see something dart across the coral just past your view straight ahead.\n" +
                "You assess the situation and realize you have three solid options. You can run after what you saw directly ahead of you, you can just high tail it out of there, or just dive your ocotopus body behind a rock.\n" +
                "What would you like to do?");

            Console.WriteLine("Follow, Run, or Hide?");

            string reefAnswer = Console.ReadLine().ToLower();

            if (reefAnswer == "Follow")
            {
                SeaHorseFight();

            }
            else if (reefAnswer == "Run")
            {
                SeaHorseFight();
            }
            else if (reefAnswer == "Hide")
            {
                SeaHorseFight();
            }
            else
            {
                OldRustyReef();
            }

        }

        private void SeaHorseFight()
        {
            Console.Clear();
            Console.WriteLine("You run forward chasing after the mysterious dashing object. You push forward past a coral opening. \n" +
                "As you hit the open water you realize you're almost face to face with a very large and very angry seahorse. \n" +
                "He is at least twice your size. You fear running might not be an option.");
            Console.WriteLine("Should you FIGHT the SeaHorse, or swim BACK to the previous area?");
            Console.WriteLine("FIGHT or BACK");
            string seaHFight = Console.ReadLine().ToLower();
            if (seaHFight == "fight")
            {
                Console.Clear();
                Console.WriteLine("You dash after the seahorse in the hopes of startling it and getting a surprise upper edge\n" +
                    "The seahorse is taken off guard and is whacked with your tentacle. Confused and scared the giant Seahorse flees");
                Console.WriteLine($"Health: {playerHealth}/100 ");
                Console.ReadKey();
                KrabRoom();
            }
            else if (seaHFight == "back")
            {
                Console.Clear();
                Console.WriteLine("You immediately turn around and try to run away. The freakishly large seahorse sees this weakness and snaps its tail landing a glancing blow as you narrowly escape");
                playerHealth = playerHealth - 30;
                Console.WriteLine($"Health: {playerHealth}/100 ");
                KrabRoom();


            }
            else
            {
                SeaHorseFight();
            }
        }
        private void KrabRoom()
        {
            Console.Clear();
            Console.WriteLine("You enter the room with a giant crab on the door.\n" +
                "As you enter the door behind you slams shut.It is locked shut from this end. \n" +
                "You begin to hear steam noises begin to whistle around you. The noise appears to be getting closer\n" +
                "From the darkness on the opposite side of the room appears a monstrous creature.\n" +
                " 'It seems you have finally stumbled into my trap.' the giant Crab before you says before fully revealing itself. " +
                "I am going to give you one chance to make it out of here alive. You must answer 3 very specific trivia questions.\n" +
                "How many Amigos are there?");
            Console.WriteLine("Please type your answer: (Hint: Honestly not that many amigos)");

            string krabRiddle = Console.ReadLine();

            if (krabRiddle == "3")
            {
                Console.WriteLine("You hear the steam begin to swirl around you...\n" +
                    "\"That is correct. Question 1 of 3 answered\"");
                Console.Clear();
                Console.WriteLine("The krab seems pleased with your random trivia skills and allows you to continue");
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
                KrabRoom2();

            }

            else
            {
                Console.WriteLine("The darkness begins to surround you\n" +
                    "\"You seem to lack a very basic understanding of amigos trivia unfortunately\"");
                Console.Clear();
                Console.WriteLine("The steam begins to fill the chamber. You are surrounded.\n" +
                    "You begin to feel a sharp pain in your lungs as you breathe in the toxic fumes");
                playerHealth = playerHealth - 20;
                Console.WriteLine($"Health: {playerHealth}/100 ");
                Console.ReadKey();
                KrabRoom2();
            }
        }
        private void KrabRoom2()
        {
            Console.Clear();
            Console.WriteLine("One of the large misnomers of the sea is that sea creatures don't love 90's music.\n" +
                "In order to accumulate such impressive size I've had to spend so much time eating literally everything.\n" +
                "The only way I was able \n" +
                "How many solo albums did 2pac release during his life?");
            Console.WriteLine("Please type your answer: (Hint: Stop counting the 75 albums that came out after he died please)");

            string krabRiddle1 = Console.ReadLine();

            if (krabRiddle1 == "4")
            {
                Console.WriteLine("You hear the steam begin to swirl around you...\n" +
                    "\"That is correct. Question 2 of 3 answered\"");
                Console.Clear();
                Console.WriteLine("The krab seems pleased with your random trivia skills and allows you to continue");
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
                KrabRoom3();

            }

            else
            {
                Console.WriteLine("The darkness begins to surround you\n" +
                    "\"You seem to lack a very basic understanding of 2pac trivia unfortunately\"");
                Console.Clear();
                Console.WriteLine("The steam begins to fill the chamber. You are surrounded.\n" +
                    "You begin to feel a sharp pain in your lungs as you breathe in the toxic fumes");
                playerHealth = playerHealth - 20;
                Console.WriteLine($"Health: {playerHealth}/100 ");
                Console.ReadKey();
                KrabRoom3();
            }
        }
        private void KrabRoom3()
        {
            Console.Clear();
            Console.WriteLine("You have reached the third and final trivia question. Your freedom awaits.\n" +
                "With all this freetime us Aquatic creatures often yearn for more entertainment.\n" +
                "Specifically late 90's era professional wrestling. We hope you came prepared.\n" +
                "How many times was Booker T a WCW World Heavyweight Champion?");
            Console.WriteLine("Please type your answer: (Hint:More then 2 less than 6 )");

            string krabRiddle2 = Console.ReadLine();

            if (krabRiddle2 == "5")
            {
                Console.WriteLine("You hear the steam begin to swirl around you...\n" +
                    "\"That is correct. All Questions answered. You are free to go. Long live Booker T...\"");
                Console.Clear();
                Console.WriteLine("The krab seems pleased with your random trivia skills and allows you to continue");
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
                TigerShark();

            }

            else
            {
                Console.WriteLine("The darkness begins to surround you\n" +
                    "\"You seem to lack a very basic understanding of wrestling trivia unfortunately\"");
                Console.Clear();
                Console.WriteLine("The steam begins to fill the chamber. You are surrounded.\n" +
                    "You begin to feel a sharp pain in your lungs as you breathe in the toxic fumes");
                playerHealth = playerHealth - 20;
                Console.WriteLine($"Health: {playerHealth}/100 ");
                Console.ReadKey();
                TigerShark();
            }
        }
        private void TigerShark()
        {
            Console.Clear();
            Console.WriteLine("You emerge pass the room with the giant crab in it and find yourself in an open reef.\n" +
                "There are a few coral around and ocean life seems to be moving but something just feels out of place.\n" +
                "Out of the corner of your left eye you see it. A giant 300 foot Tiger Shark. \n" +
                "The choice is simple. And it is yours to make. Run or Fight");
            Console.WriteLine("Please type your answer: (Hint: Its a really big shark imma be honest");

            string tigerSharkFight = Console.ReadLine();

            if (tigerSharkFight == "Run")
            {
                Console.WriteLine("You begin to run sprint away from the tiger.\n" +
                    "The tiger shark never even looked at you. Got away safely");
                Console.Clear();
                Console.WriteLine("You had a run in with a tiger shark and got to tell the tale. Lucky.");
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
                KrabRoom3();

            }

            else
            {
                Console.WriteLine("You make a mad dash at the tail of the tiger shark.\n" +
                    "Right before you near the shark it snaps around and that's all she wrote");
                Console.Clear();
                Console.WriteLine("You are chomped up in a single bite.\n" +
                    "Please stop fighting things that big without some help.");
                playerHealth = playerHealth - 100;
                Console.WriteLine($"Health: {playerHealth}/100 ");
                Console.ReadKey();
                KrabRoom3();
            }
        }
       
        private void LeftCave()
        {
            Console.Clear();
            Console.WriteLine("You squint your eyes in an attempt to see in the darkness. \n" +
                "There is still almost no visibility. You know you're not the only thing in the room.\n" +
                "Something quickly swims across the room making a distinct and fast noise.\n" +
                "Should you follow the noise or stay put?");
            Console.WriteLine("Please type your answer: (Hint: FOLLOW or Stay");

            string leftCaveAnswer = Console.ReadLine();

            if (leftCaveAnswer == "Follow")
            {
                Console.WriteLine("You begin to swim after the noise as it begins to dart again.\n" +
                    "You race after the noise even faster this time and can sense whatever it is must be close");
                Console.Clear();
                Console.WriteLine("Gotcha.");
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
                SpookyRoom();

            }

            else
            {
                Console.WriteLine("Instead of just blindly following the random noise you choose to stay put.\n" +
                    "You sense the noise swimming off in the distance and before long it is out of earshot.");
                Console.Clear();
                Console.WriteLine("You swim forward in the now empty dimly lit cave until you reach an exit.\n" +
                    "Alongside the exit you pick up a tasty little snack as you exit");
                playerHealth = playerHealth + 35;
                Console.WriteLine($"Health: {playerHealth}/100 ");
                Console.ReadKey();
                SnailTrail();
            }
        }
        private void CenterCave()
        {
            Console.Clear();
            Console.WriteLine("You swim forward and enter the largest of the three caves.\n" +
                "There is enough space in this cave for you an Octopus and an entire Chevy Movie Theater. If that helps understand the sheer size.\n" +
                "However just as you would expect the giant huge mega cave is mostly empty. There is a tiny little hole in the back.\n" +
                "Will you crawl through or run back?");
            Console.WriteLine("Please type your answer: (Hint: Crawl; or Leave");

            string centerCaveAnswer = Console.ReadLine();

            if (centerCaveAnswer == "Crawl")
            {
                Console.WriteLine("You find a nifty little exit.\n" +
                    "Wow this big empty cave sure was easy to traverse");
                Console.Clear();
                Console.WriteLine("Wow! So close to the end!");
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
                SnailTrail();

            }

            else
            {
                Console.WriteLine("You begin to turn around and skidaddle out of there.\n" +
                    "Thats really a fun word isn't it?");
                Console.Clear();
                Console.WriteLine("You return to the cave selection portion of this fun little excersion\n" +
                    "Very excited for you.");
                Console.ReadKey();
                TunnelEnding();
            }
        }
        private void RightCave()
        {
            Console.Clear();
            Console.WriteLine("You swim forward and enter the largest of the three caves.\n" +
                "There is enough space in this cave for you an Octopus and an entire Chevy Movie Theater. If that helps understand the sheer size.\n" +
                "However just as you would expect the giant huge mega cave is mostly empty. There is a tiny little hole in the back.\n" +
                "Will you crawl through or run back?");
            Console.WriteLine("Please type your answer: (Hint: Crawl; or Leave");

            string centerCaveAnswer = Console.ReadLine();

            if (centerCaveAnswer == "Crawl")
            {
                Console.WriteLine("You find a nifty little exit.\n" +
                    "Wow this big empty cave sure was easy to traverse");
                Console.Clear();
                Console.WriteLine("Wow! So close to the end!");
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
                SnailTrail();

            }

            else
            {
                Console.WriteLine("You begin to turn around and skidaddle out of there.\n" +
                    "Thats really a fun word isn't it?");
                Console.Clear();
                Console.WriteLine("You return to the cave selection portion of this fun little excersion\n" +
                    "Very excited for you.");
                Console.ReadKey();
                TunnelEnding();
            }
        }
        private void SnailTrail()
        {
            Console.Clear();
            Console.WriteLine("You enter a dark and dingy cavern with two distinct slime trails on the floor. \n" +
                "The slime trails are thick and protruding from the ground. ");
            Console.WriteLine("The two trails run to opposite ends of the room. \n" +
                "What will it be? Will you go left or right?");
            string snailAnswer = Console.ReadLine().ToLower();
            if (snailAnswer == "left")
            {
                Console.WriteLine("You follow the left  snail trail");
                Console.WriteLine("You eventually reach a room where the trail ends abruptly.\n" +
                    "The snail appears to have back tracked and is not here. You should be free to exit through the back of the room");
                Console.ReadKey();
                SnailExit();
            }
            else if (snailAnswer == "right")
            {
                Console.WriteLine("You follow the right snail path and it leads you to the room to the right. " +
                    "You are now face to face with a snail roughly your size. He appears to be friendly");
                playerHealth = playerHealth + 100;
                Console.WriteLine($"Health: {playerHealth}/100 ");
                Console.ReadKey();
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
                SnailExit();

            }
            else
            {
                Console.WriteLine("You need to make a decision.\n" +
                    "You can't run from snails forever.");
                SnailTrail();
            }
        }
        private void SnailExit()
        {
            Console.Clear();
            Console.WriteLine("You are nearing the exit. The only thing standing between you and home is one last question. \n" +
                "For some reason seacreatures designers are really heavy on the trivia. As a result in order to pass the final little barrier you will have to answer a final question correctly. ");
            Console.WriteLine("Rey Mysterio grew up in what three digit area code?  \n" +
                "What will it be? Hint:1,6,9 are used");
            string snailAnswer = Console.ReadLine().ToLower();
            if (snailAnswer == "619")
            {
                Console.WriteLine("Who knew geographically based wrestling knowledge would be so practically useful.");
                Console.WriteLine("You're a hero. A champion. Wow. The best. \n" +
                    "I've never been so proud of someone in my entire life. And you're not even a someone. Just an Octopus. ");
                Console.ReadKey();
                GameWin();
            }          
            else
            {
                Console.WriteLine("You need to make a decision.\n" +
                    "You can't run from the end forever");
                SnailTrail();
            }
        }

    }
}
