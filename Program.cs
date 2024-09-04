// See https://aka.ms/new-console-template for more information
/*
   • Establish the game’s starting state: the Manticore begins with 10 health points and the city with 15. //DONE
   The game starts at round 1.

   • Ask the first player to choose the Manticore’s distance from the city (0 to 100). Clear the screen //DONE
   afterward.

   • Run the game in a loop until either the Manticore’s or city’s health reaches 0. //DONE

   • Before the second player’s turn, display the round number, the city’s health, and the Manticore’s //DONE
   health.

   • Compute how much damage the cannon will deal this round: 10 points if the round number is a
   multiple of both 3 and 5, 3 if it is a multiple of 3 or 5 (but not both), and 1 otherwise. Display this to //DONE
   the player.

   • Get a target range from the second player, and resolve its effect. Tell the user if they overshot (too //DONE
   far), fell short, or hit the Manticore. If it was a hit, reduce the Manticore’s health by the expected
   amount.

   • If the Manticore is still alive, reduce the city’s health by 1. //DONE

   • Advance to the next round. //DONE

   • When the Manticore or the city’s health reaches 0, end the game and display the outcome. //DONE

   • Use different colors for different types of messages. //DONE
-----------------------------------------------------------------------------------------------------------------------------------
   • Note: This is the largest program you have made so far. Expect it to take some time!

   • Note: Use methods to focus on solving one problem at a time.

   • Note: This version requires two players, but in the future, we will modify it to allow the computer
   to randomly place the Manticore so that it can be a single-player game.
-----------------------------------------------------------------------------------------------------------------------------------
 */



//Establish the game’s starting state: the Manticore begins with 10 health points and the city with 15. The game starts at round 1.

using System.ComponentModel.Design;

Console.ForegroundColor = ConsoleColor.DarkGreen;

Console.WriteLine(@" 
                
                     
                    
                                                                    }/
                                                           }/      /,/
                                                          /,;    ,/ ,/
                                                         / `,  ,/  `,/
                                                        / ,`,,/  ,`,;
                                                   __  /  ,`/   ,`,;
                                                _,`, `{  `,{   `,`;`
                       /~\         .-:::-.     (--,   ;\ `,}  `,`;
                     /` , \      ,:::::::::,     `~;   \},/  `,`;     ,-=-
                    /. `  .\_   ;:::::::::::;  __,{     `/  `,`;     {
                   / , ~ . ^ `~`\:::::::::::<<~>-,,`,    `-,  ``,_    }
                /~~ . `  . ~  , .`~~\:::::::;    _-~  ;__,        `,-`
       /`\    /~,  . ~ , '  `  ,  .` \::::;`   <<<~```   ``-,,__   ;
      /` .`\ /` .  ^  ,  ~  ,  . ` . ~\~                       \\, `,__
     / ` , ,`\.  ` ~  ,  ^ ,  `  ~ . . ``~~~`,                   `-`--, \
    / , ~ . ~ \ , ` .  ^  `  , . ^   .   , ` .`-,___,---,__            ``
  /` ` . ~ . ` `\ `  ~  ,  .  ,  `  ,  . ~  ^  ,  .  ~  , .`~---,___
/` . `  ,  . ~ , \  `  ~  ,  .  ^  ,  ~  .  `  ,  ~  .  ^  ,  ~  .  `-,");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine(@" ███▄ ▄███▓ ▄▄▄       ███▄    █ ▄▄▄█████▓ ██▓ ▄████▄   ▒█████   ██▀███  ▓█████ 
▓██▒▀█▀ ██▒▒████▄     ██ ▀█   █ ▓  ██▒ ▓▒▓██▒▒██▀ ▀█  ▒██▒  ██▒▓██ ▒ ██▒▓█   ▀ 
▓██    ▓██░▒██  ▀█▄  ▓██  ▀█ ██▒▒ ▓██░ ▒░▒██▒▒▓█    ▄ ▒██░  ██▒▓██ ░▄█ ▒▒███   
▒██    ▒██ ░██▄▄▄▄██ ▓██▒  ▐▌██▒░ ▓██▓ ░ ░██░▒▓▓▄ ▄██▒▒██   ██░▒██▀▀█▄  ▒▓█  ▄ 
▒██▒   ░██▒ ▓█   ▓██▒▒██░   ▓██░  ▒██▒ ░ ░██░▒ ▓███▀ ░░ ████▓▒░░██▓ ▒██▒░▒████▒
░ ▒░   ░  ░ ▒▒   ▓▒█░░ ▒░   ▒ ▒   ▒ ░░   ░▓  ░ ░▒ ▒  ░░ ▒░▒░▒░ ░ ▒▓ ░▒▓░░░ ▒░ ░
░  ░      ░  ▒   ▒▒ ░░ ░░   ░ ▒░    ░     ▒ ░  ░  ▒     ░ ▒ ▒░   ░▒ ░ ▒░ ░ ░  ░
░      ░     ░   ▒      ░   ░ ░   ░       ▒ ░░        ░ ░ ░ ▒    ░░   ░    ░   
       ░         ░  ░         ░           ░  ░ ░          ░ ░     ░        ░  ░
                                             ░                                 ");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("Press any key to continue.");
Console.ResetColor();
Console.ReadKey();
Console.Clear();

Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write("BOSS BATTLE!\n\n");
Console.ResetColor();
Console.Write("You have to fight the Manticore: The Manticore begins with 10 health points and the city with 15.\nThe game starts at round 1.");

//Ask the first player to choose the Manticore’s distance from the city (0 to 100). Clear the screen afterward.

Console.Write("\n\nPLayer 1, how far away from the city do you want to station the Manticore? It must be a number between 0 - 100: ");


Console.ForegroundColor = ConsoleColor.DarkMagenta;
int playerOneNumber = Convert.ToInt32(Console.ReadLine());
Console.ResetColor();

while (playerOneNumber < 0 || playerOneNumber > 100)
{
    Console.Write("Number needs to be between 0 - 100: ");
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    playerOneNumber = Convert.ToInt32(Console.ReadLine());
    Console.ResetColor();
}

Console.Clear();

// Run the game in a loop until either the Manticore’s or city’s health reaches 0.
// Before the second player’s turn, display the round number, the city’s health, and the Manticore’s
// health.

/*EXAMPLE ON HOW IT SHOULD LOOK

-----------------------------------------------------------
STATUS: Round: 1 City: 15 / 15 Manticore: 10 / 10
The cannon is expected to deal 1 damage this round.
Enter desired cannon range: 50
That round OVERSHOT the target.
-----------------------------------------------------------

*/

// Compute how much damage the cannon will deal this round: 10 points if the round number is a
// multiple of both 3 and 5, 3 if it is a multiple of 3 or 5 (but not both), and 1 otherwise. Display this to
// the player.

Console.WriteLine("Player 2, it's your turn.");

int currentRound = 1;

int cityHealth = 15;

int manticoreHealth = 10;



while (cityHealth > 0 && manticoreHealth > 0)
{
    Console.WriteLine("-------------------------------------------------------");
    Console.WriteLine($"STATUS: Round {currentRound} City: {cityHealth}/15 Manticore {manticoreHealth}/10");
    if (currentRound % 3 == 0 && currentRound % 5 == 0)
    {
        Console.Write("The cannon is expected to deal 10 ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("ELECTRICAL ");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("FIREBLAST ");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write("DAMAGE ");
        Console.ResetColor();
        Console.Write("this round!\n");

    }
    else if (currentRound % 3 == 0)
    {
        Console.Write("The cannon is expected to deal 3 ");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("FIRE ");
        Console.ResetColor();
        Console.Write("damage this round.\n");

    }
    else if (currentRound % 5 == 0)
    {

        Console.Write("The cannon is expected to deal 3 ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("ELECTRICAL ");
        Console.ResetColor();
        Console.Write("damage this round.\n");
        


    }
    else
    {
        Console.WriteLine("The cannon is expected to deal 1 damage this round.");

    }


    // Get a target range from the second player, and resolve its effect. Tell the user if they overshot(too
    // far), fell short, or hit the Manticore.If it was a hit, reduce the Manticore’s health by the expected
    //amount.

    Console.Write("Enter the desired cannon range: ");
    Console.ForegroundColor = ConsoleColor.Cyan;
    int playerTwoNumber = Convert.ToInt32(Console.ReadLine());
    Console.ResetColor();


    if (playerTwoNumber == playerOneNumber && currentRound % 3 == 0 && currentRound % 5 == 0)
    {
        
        Console.WriteLine("That round is a DIRECT fire-electric blast on target, 10 points of damage!");
        manticoreHealth -= 10;
        cityHealth -= 1;

    }
    else if (playerTwoNumber == playerOneNumber && currentRound % 3 == 0)
    {
        Console.WriteLine("That round is a DIRECT fire hit on target, 3 points of damage!");
        manticoreHealth -= 3;
        cityHealth -= 1;

    }
    else if (playerTwoNumber == playerOneNumber && currentRound % 5 == 0)
    {
        Console.WriteLine("That round is a DIRECT electric hit on target, 3 points of damage!");
        manticoreHealth -= 3;
        cityHealth -= 1;

    }
    else if (playerTwoNumber == playerOneNumber)
    {
        Console.WriteLine("That round is a DIRECT normal hit, 1 point damage!");
        manticoreHealth -= 1;
        cityHealth -= 1;

    }
    else if(playerTwoNumber > playerOneNumber) 
    {
            Console.WriteLine("You OVERSHOT the target!");
            cityHealth -= 1;

    }
    else if (playerTwoNumber < playerOneNumber)
    {
        Console.WriteLine("You FELL SHORT of the target!");
        cityHealth -= 1;

    }

    currentRound++;

}

if (manticoreHealth <= 0 && cityHealth <=0)
{
    Console.WriteLine("-------------------------------------------------------");
    Console.WriteLine($"STATUS: Round {currentRound} City: {cityHealth}/15 Manticore {manticoreHealth}/10");
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("It is a DRAW, everything is destroyed, no one wins..");
    Console.ResetColor();
    Console.WriteLine("-------------------------------------------------------");
}
else if (manticoreHealth <= 0)
{
    Console.WriteLine("-------------------------------------------------------");
    Console.WriteLine($"STATUS: Round {currentRound} City: {cityHealth}/15 Manticore {manticoreHealth}/10");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("YOU HAVE WON!");
    Console.ResetColor();
    Console.WriteLine("-------------------------------------------------------");
}
else if (cityHealth <= 0)
{
    Console.WriteLine("-------------------------------------------------------");
    Console.WriteLine($"STATUS: Round {currentRound} City: {cityHealth}/15 Manticore {manticoreHealth}/10");
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("YOU HAVE LOST!");
    Console.ResetColor();
    Console.WriteLine("-------------------------------------------------------");
}









