
using System;

namespace _Eindresultaat
{
    class Program
    {

        // ------------------ ROCK/PAPER/SCISSORS RPG ------------------
        static void Main(string[] args)
        {
            start:
            int screenWidth = 75;
            int screenHeight = 25;


            // COMMAND VARIABLES:
            string commandAttack        = "attack";
            string commandDefend        = "defend";
            string commandMagic         = "magic";
            string commandRun           = "run";


            // PLAYER VARIABLES:
            int playerHealth = 40;
            int playerHealthMax = 100;
            int playerAttack = 10;
            int playerWins = 0;
            int playerWinsEnd = 10;
            int money = 0;

            // MONSTER VARIABLES:
            int monsterHealth  = 30;
            int monsterAttack  = 30;
            int demonlevel = 1;
            string monsterName = "";
            bool monsterInit   = true;  // Sets monster health before battle starts


            string message = "";



            string input;
            input = "";


            Console.Title = "MY SECOND CONSOLE GAME";

            Console.SetWindowSize(screenWidth, screenHeight);
            Console.SetBufferSize(screenWidth, screenHeight);


            // ---------- WELCOME SCREEN, DO ONCE -------------
            
            Console.Clear();
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.Cyan;

            int openingScreenX          = 0;
            int openingScreenY          = 0;
            int openingScreenWidth      = 72;
            int openingScreenHeight     = 9;

            Console.WriteLine("########################################################################");
            Console.WriteLine("########################################################################");
            Console.WriteLine("###########                                                  ###########");
            Console.WriteLine("###########          WELCOME TO:  'SLAY THE DEMON'!          ###########");
            Console.WriteLine("###########                                                  ###########");
            Console.WriteLine("###########            PRESS ANY KEY TO CONTINUE.            ###########");
            Console.WriteLine("###########                                                  ###########");
            Console.WriteLine("########################################################################");
            Console.WriteLine("########################################################################");
            
            Console.MoveBufferArea( 0, 0, openingScreenWidth, openingScreenHeight, openingScreenX, openingScreenY );

            Console.ReadKey(true);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("regels en uitleg");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1: gebruik geen hoofdletters!");
            Console.WriteLine("2: je wint als je alle 10 demonen verslaat");
            Console.WriteLine("3: je kunt met geld damage en lives kopen");
            Console.WriteLine("4: type run om te stoppen met het avondtuur");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("dit bericht verwijderd zichtzelf over 7 seconde");
            // -------------------------------------------------
            Restart:
            Console.Clear();
            if(playerHealth >= playerHealthMax){
                playerHealth = 100;
            }
            
            // UPDATE THE GAME:
            // #####################   DRAW GAME STATE   #####################

            // DRAW VISUAL OPPONENT:
            // L2 - Demon ENCOUNTERED:
            
            if(demonlevel == 1 || demonlevel == 2){
            monsterName = "Blue Demon";
            monsterHealth = 30;
            monsterAttack = 1;
            }
            else if(demonlevel == 3 || demonlevel == 4 || demonlevel == 5){
            monsterName = "Red Demon";
            monsterHealth = 40;
            monsterAttack = 2;
            }
            else if(demonlevel == 6 || demonlevel == 7 || demonlevel == 8){
            monsterName = "Gray Demon";
            monsterHealth = 50;
            monsterAttack = 5;
            }
            else if(demonlevel == 9 || demonlevel == 10){
            monsterName = "10 commandments";
            monsterHealth = 150;
            monsterAttack = 10;
            }           
            stage:
            if(monsterName == "Blue Demon"){
            Console.ForegroundColor = ConsoleColor.Blue;
            }
            else if(monsterName == "Red Demon"){
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if(monsterName == "Gray Demon"){
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else{
                Console.ForegroundColor = ConsoleColor.DarkYellow;
            }
            Console.Clear();
            Console.WriteLine("========= You have encountered a " + monsterName + ". =========");

            // Colour:
 
            // L3 - Show the graphic:
            Console.WriteLine("demonlevel: " + demonlevel);
            Console.WriteLine("                        ");
            Console.WriteLine("       |\\___/|  V       ");
            Console.WriteLine("     <( Ò   Ó )>|       ");
            Console.WriteLine("       \\  ^  /  |       ");
            Console.WriteLine("        V```V           ");
            Console.WriteLine("                        ");
        

            // MOVE 2 BLOCKS BELOW IMAGE:
            Console.CursorTop += 2;
            
            // SHOW MONSTER HEALTH:
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("ENEMY HEALTH:   " + monsterHealth + "HP");

            // SHOW PLAYER HEALTH:
            Console.WriteLine("PLAYER HEALTH:  " + playerHealth + "HP");
            Console.WriteLine("Money: " + money);

            // SHOW ACTIONS:
            Console.CursorTop += 1;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Type one of the following actions:");
            Console.WriteLine("[" + commandAttack + "]" + "  " + "[" + commandDefend + "]" + "  " + "[" + commandMagic + "]" + "  " + "[" + commandRun + "]");



            // #####################   REQUEST INPUT   #####################
            Console.CursorTop += 2;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            input = "";

            input = Console.ReadLine();
            // #####################   UPDATE GAME   #####################

            if ( input == commandAttack || input == commandDefend || input == commandMagic || input == commandRun)
            {
                // er is aangevallen
                Random randomNumberGenerator = new Random();
                int number = randomNumberGenerator.Next(3);

                string monsterCommand = "";
                if(number == 0)
                {
                    monsterCommand = commandAttack;
                }
                else if(number == 1)
                {
                    monsterCommand = commandDefend;
                }
                else
                {
                    monsterCommand = commandMagic;
                }

                
                // wie heeft er gewonnen? of is het gelijkspel
                if ( input == monsterCommand )
                {
                    //gelijkspel
                    message += "ITS A DRAW";
                }
                else
                {
                    //gewonnen of verloren
                    if ((input == commandAttack && monsterCommand == commandMagic) || 
                            (input == commandMagic && monsterCommand == commandDefend) || 
                            (input == commandDefend && monsterCommand == commandAttack) ||
                            (input == commandRun)) {
                        //gewonne
                    

                    
                    if(input == commandRun){
                     Console.ResetColor();
                     Console.Clear();
                     Console.ForegroundColor = ConsoleColor.Green;
                     Console.WriteLine("je gaat niet langer meer door met dit avondtuur jammer");
                     Console.ForegroundColor = ConsoleColor.Blue;
                     Console.WriteLine("your health = " + playerHealth);
                     Console.WriteLine("monter health = " + monsterHealth);
                     Console.WriteLine("je had een winstreak van: " + playerWins);
                     Console.ForegroundColor = ConsoleColor.White;
                     Console.WriteLine("Thank you for playing! Press any button to exit.");
                     Console.ReadKey(true);
                     return;
                    }
                        monsterHealth -= playerAttack;
                        message += "YOU WIN\n";
                        Random moneys = new Random();
                        int geld = moneys.Next(1,6);
                        money += geld;
                        message += "you gained: " + geld + "$ for your winning move";

                    } else {
                        //verloren
                        playerHealth -= monsterAttack;
                        message += "YOU LOST";
                    }
                }

                message += "\n";
                message += "You choose: " + input + "\n";
                message += "Monster choose: " + monsterCommand + "\n";

                message += "PLAYER HP: " + playerHealth + "\n";
                message += "MONSTER HP: " + monsterHealth + "\n";
                message += "totale wins: " + playerWins;


            }
            else
            {
                //geen geldige input
                message += "PLEASE GIVE VALID INPUT";
            }

            Console.Write(message);
            message = "";

            // L2 - GIVE THE PLAYER TIME TO READ THE MESSAGE:
            System.Threading.Thread.Sleep(2000);

            if (playerHealth >= 1 && monsterHealth >= 1){
                goto stage;
            }
            else{
            playerWins += 1;
            }
            if(playerWins == 10){
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("je hebt alle demons verslagen en hiermee het spel gewonnen");
            Console.WriteLine("je hebt nog: " + playerHealth + " hp over");
            Console.WriteLine("en je doet een totaal van: " + playerAttack + " damage");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("press any key om opnieuw te beginnen");
            Console.ReadKey(true);
            goto start;
            } else if(playerHealth <= 0) {
            // END GAME:
            Console.ResetColor();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("you died");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("your health = " + playerHealth);
            Console.WriteLine("monter health = " + monsterHealth);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("click any key to start again!");
            Console.ReadKey(true);
            goto start;
            }
            else if(monsterHealth <= 0){
            money += 10;
            choose: 
            Console.ResetColor();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("you won");
            Console.WriteLine("You got: " + money + "$");
            Console.WriteLine("10$ extra for defeating the demon");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("your health = " + playerHealth);
            Console.WriteLine("monter health = " + monsterHealth);
            Console.WriteLine("totale wins: " + playerWins);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Type: 'shop' to buy stuff or 'next' to fight the next demon");

            // na alles hierboven komt hij hier
            input = Console.ReadLine();
            if(input == "shop"){
                shop: 
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("you got: " + money + "$");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("price: 10$");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("type: 'buy lives' to buy the random lives");
                Console.WriteLine("buy lives 1 tot 25 (random)");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("price: 10$");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("type: 'buy damage' to buy the random damage");
                Console.WriteLine("buy damage 2 of 5 (random)\n" );
                Console.WriteLine("type next to fight the next demon");
                input = Console.ReadLine();
                if(input == "buy lives"){
                    if(money >= 10){
                        if(playerHealth >= playerHealthMax){
                            Console.Clear();
                            Console.WriteLine("je hebt al het max hp");
                            System.Threading.Thread.Sleep(2000);
                            goto shop;
                        }
                        else if(playerHealth < playerHealthMax){
                    Console.Clear();
                    money -= 10;
                    Random randomlives = new Random();
                    int lives = randomlives.Next(1,26);
                    playerHealth += lives;
                    Console.WriteLine("you bought lives an gained: " + lives + " lives" );
                    System.Threading.Thread.Sleep(2000);
                    goto shop;
                    }}
                    else if(input == "run"){
                        Console.Clear();
                        Console.WriteLine("jammer dat je stopt met dit avondtuur");
                        System.Threading.Thread.Sleep(2000);
                        return;
                    }
                    else{
                        Console.Clear();
                        demonlevel += 1;
                        Console.WriteLine("you dont have enough money so you where sended to the next stage");
                        System.Threading.Thread.Sleep(2000);
                        goto Restart;
                    }
                }
                else if(input == "buy damage"){
                    if(money >= 10){
                        Console.Clear();
                        money -= 10;
                Random randomdamage = new Random();   
                int damage = randomdamage.Next(2);
                if(damage == 0){
                    playerAttack += 2;
                    Console.WriteLine("you bought damage an gained: 2 damage");
                    System.Threading.Thread.Sleep(2000);
                    goto shop;
                }
                else{
                    playerAttack += 5;
                    Console.WriteLine("you bought damage an gained: 5 damage");
                    System.Threading.Thread.Sleep(2000);
                    goto shop;
                }
                    }
                    else if(input == "run"){
                        Console.Clear();
                        Console.WriteLine("jammer dat je stopt met dit avondtuur");
                        System.Threading.Thread.Sleep(2000);
                        return;
                    }
                    else{
                        Console.Clear();
                        demonlevel += 1;
                        Console.WriteLine("you dont have enough money so you where sended to the next stage");
                        System.Threading.Thread.Sleep(2000);
                        goto Restart;
                    }
                }
                else if(input == "next"){
                    demonlevel += 1;
                    goto Restart;
                }
                else if(input == "run"){
                        Console.Clear();
                        Console.WriteLine("jammer dat je bent gestopt met dit avondtuur");
                        System.Threading.Thread.Sleep(2000);
                        return;
                }
                else{
                   Console.WriteLine("PLEASE GIVE A VALID INPUT");
                   System.Threading.Thread.Sleep(1000);
                   goto shop;
                }
                
                } else if(input == "next"){
                    demonlevel += 1;
                goto Restart;
                }
                else if(input == "run"){
                        Console.Clear();
                        Console.WriteLine("jammer dat je bent gestopt met dit avondtuur");
                        System.Threading.Thread.Sleep(2000);
                        return;
            } else {
                Console.WriteLine("PLEASE GIVE A VALID INPUT");
                System.Threading.Thread.Sleep(2000);
                goto choose;
            }
            }
        }
    }
}