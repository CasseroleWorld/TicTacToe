/* Program: Tic Tac Toe
 * By: Marshall Strong
 * Modified: 9/17/2016
 * 
 * This is a simple console window Tic-Tac Toe game. The AI
 * is incomplete and currently only makes random moves.  
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTac
{

    class Program
    {

        static void Main(string[] args)
        {
            Console.SetWindowSize(57, 28);

            String difficulty = "?";
            String one = "1";
            String two = "2";
            String three = "3";
            String four = "4";
            String five = "5";
            String six = "6";
            String seven = "7";
            String eight = "8";
            String nine = "9";

            //Draw Program Area
            Console.WriteLine("");
            Console.WriteLine("   **************************************************");
            Console.WriteLine("   **                                              **");
            Console.WriteLine("   **               Welcome to Console             **");
            Console.WriteLine("   **                * Tic-Tac-Toe *               **");
            Console.WriteLine("   ** -------------------------------------------- **");
            Console.WriteLine("   **   Difficulty: {0}                              **", difficulty);
            Console.WriteLine("   **                                              **");
            Console.WriteLine("   **                    {0} | {1} | {2}                 **", one, two, three);
            Console.WriteLine("   **                   -----------                **");
            Console.WriteLine("   **                    {0} | {1} | {2}                 **", four, five, six);
            Console.WriteLine("   **                   -----------                **");
            Console.WriteLine("   **                    {0} | {1} | {2}                 **", seven, eight, nine);
            Console.WriteLine("   **                                              **");
            Console.WriteLine("   **      New Game:   A.                          **");
            Console.WriteLine("   **      Difficulty: B.                          **");
            Console.WriteLine("   **      Exit:       C.                          **");
            Console.WriteLine("   **                                              **");
            Console.WriteLine("   **                                              **");
            Console.WriteLine("   **      Please input a letter to select an      **");
            Console.WriteLine("   **      option:                                 **");
            Console.WriteLine("   **                                              **");
            Console.WriteLine("   **                                              **");
            Console.WriteLine("   **                                              **");
            Console.WriteLine("   **                                              **");
            Console.WriteLine("   **************************************************");

            //Manage user input.
            Console.SetCursorPosition(19, 20);
            Boolean MenuOn = true;
            while (MenuOn == true)
            {
                Console.SetCursorPosition(19, 20);
                ConsoleKeyInfo input = Console.ReadKey();
                if (char.IsLetter(input.KeyChar))
                {
                    String MenuInput = Convert.ToString(input.KeyChar);
                    //Runs the game.
                    Boolean GameRunning = true;
                    if (MenuInput == "A" || MenuInput == "a")
                    {
                        Boolean firstplayer; 
                        Boolean playermovedfirst; //the AI relies on this.
                        Boolean MenuOn_02 = true;
                        while (MenuOn_02 == true)
                        {
                            //Prompt for first player.
                            Console.SetCursorPosition(11, 14);
                            Console.WriteLine("Go first or second?");
                            Console.SetCursorPosition(11, 15);
                            Console.WriteLine("Go First:  A. ");
                            Console.SetCursorPosition(11, 16);
                            Console.WriteLine("Go Second: B. ");

                            Console.SetCursorPosition(19, 20);
                            ConsoleKeyInfo input_2 = Console.ReadKey();
                            if (char.IsLetter(input.KeyChar))
                            {
                                String MenuInput_player = Convert.ToString(input_2.KeyChar);
                                //player moves first.
                                if (MenuInput_player == "A" || MenuInput_player == "a")
                                {
                                    firstplayer = true;
                                    playermovedfirst = true;
                                    Console.SetCursorPosition(11, 22);
                                    var SinglePlayer = new GameSession();
                                    SinglePlayer.CreateGame(ref firstplayer, difficulty, ref GameRunning);
                                    MenuOn_02 = false;
                                }
                                //computer moves first.
                                else if (MenuInput_player == "B" || MenuInput_player == "b")
                                {
                                    firstplayer = false;
                                    playermovedfirst = false;
                                    Console.SetCursorPosition(11, 22);
                                    var SinglePlayer = new GameSession();
                                    SinglePlayer.CreateGame(ref firstplayer, difficulty, ref GameRunning);
                                    MenuOn_02 = false;
                                }
                                //Exception handling in case where char is not A, a, B, or b.
                                else
                                {
                                    Console.SetCursorPosition(11, 22);
                                    Console.Write("Error: try again.");
                                }
                            }
                            /* Exception handling in case where user does not enter a letter
                             *  in first turn choice.
                             */
                            else
                            {
                                Console.Write("Error: Try Again.");
                            }
                        }
                    }
                    /* Allows the user to change the difficulty variable. Difficulty
                     * works by increasing the chance that the AI will deviate from
                     * making perfect moves and will instead make a random move.
                     */
                    else if (MenuInput == "B" || MenuInput == "b")
                    {
                        Console.SetCursorPosition(11, 23);
                        Console.WriteLine("DEBUG: CONFIRM B.");
                    }
                    //Exits the program.
                    else if (MenuInput == "C" || MenuInput == "c")
                    {
                        Console.SetCursorPosition(11, 22);
                        Console.WriteLine("Thank you for playing.    ");
                        Console.SetCursorPosition(11, 23);
                        Console.Write("Press any key to exit.");
                        MenuOn = false;
                        Console.SetCursorPosition(33, 23);
                    }
                    //Exception handling in cases where char is not a valid choice.
                    else
                    {
                        Console.SetCursorPosition(11, 22);
                        Console.Write("Error: try again.");
                    }
                }
                //Exception handling in cases where user does not enter a letter.
                else
                {
                    Console.SetCursorPosition(11, 22);
                    Console.Write("Error: try again.");
                }
            }
            Console.ReadKey();
        }
    }
}
