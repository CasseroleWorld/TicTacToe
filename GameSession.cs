using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTac
{
    public class GameSession
    {
        public void ComputerAI(ref String one, ref String two, ref String three, ref String four, ref String five,
            ref String six, ref String seven, ref String eight, ref String nine)
        {


        }

        //Draws and updates program screen while game is being played.
        public void DrawScreen(ref String one, ref String two, ref String three, ref String four, ref String five,
            ref String six, ref String seven, ref String eight, ref String nine, ref String difficulty, ref Boolean GameRunning, ref int turn)
        {
            Console.Clear();
            //Draw Program Area
            Console.WriteLine("");
            Console.WriteLine("   **************************************************");
            Console.WriteLine("   **                                              **");
            Console.WriteLine("   **               Welcome to Console             **");
            Console.WriteLine("   **                * Tic-Tac-Toe *               **");
            Console.WriteLine("   ** -------------------------------------------- **");
            Console.WriteLine("   **   Difficulty: {0}                    Turn: {1}   **", difficulty, turn);
            Console.WriteLine("   **                                              **");
            Console.WriteLine("   **                    {0} | {1} | {2}                 **", one, two, three);
            Console.WriteLine("   **                   -----------                **");
            Console.WriteLine("   **                    {0} | {1} | {2}                 **", four, five, six);
            Console.WriteLine("   **                   -----------                **");
            Console.WriteLine("   **                    {0} | {1} | {2}                 **", seven, eight, nine);
            Console.WriteLine("   **                                              **");
            Console.WriteLine("   **                                              **");
            Console.WriteLine("   **                                              **");
            Console.WriteLine("   **                                              **");
            Console.WriteLine("   **                                              **");
            Console.WriteLine("   **                                              **");
            Console.WriteLine("   **      Please input a letter to select an      **");
            Console.WriteLine("   **      option:                                 **");
            Console.WriteLine("   **                                              **");
            Console.WriteLine("   **                                              **");
            Console.WriteLine("   **                                              **");
            Console.WriteLine("   **                                              **");
            Console.WriteLine("   **************************************************");
        }

        public void CheckWinner(ref String one, ref String two, ref String three, ref String four, ref String five,
            ref String six, ref String seven, ref String eight, ref String nine, ref Boolean GameRunning, ref Boolean firstplayer, ref int turn)
        {
            string difficulty = "?";//fix this later. Draw Screen needs to reference outside difficulty string variable.

            //Declares the player winner. The game returns to the main menu by setting GameRunning to false and redraws the menu options.
            if (one == "X" && two == "X" && three == "X" ||
                (one == "X" && four == "X" && seven == "X") ||
                (one == "X" && five == "X" && nine == "X") ||
                (two == "X" && five == "X" && eight == "X") ||
                (four == "X" && five == "X" && six == "X") ||
                (seven == "X" && eight == "X" && nine == "X") ||
                (three == "X" && six == "X" && nine == "X") ||
                (seven == "X" && five == "X" && three == "X"))
            {
                DrawScreen(ref one, ref two, ref three, ref four, ref five, ref six, ref seven, ref eight, ref nine, ref difficulty, ref GameRunning, ref turn);
                Console.SetCursorPosition(11, 22);
                Console.WriteLine("You Win. Press any key to return       ");
                Console.Write("   **      to the main menu.");
                Console.ReadKey();
                GameRunning = false;
                Console.SetCursorPosition(11, 14);
                Console.WriteLine("New Game:   A.");
                Console.SetCursorPosition(11, 15);
                Console.WriteLine("Difficulty: B.");
                Console.SetCursorPosition(11, 16);
                Console.WriteLine("Exit:       C.");
                Console.SetCursorPosition(11, 22);
                Console.WriteLine("                                     ");
                Console.WriteLine("   **                                            ");

            }
            //Declares the Computer the Winner.
            else if (one == "O" && two == "O" && three == "O" ||
                (one == "O" && four == "O" && seven == "O") ||
                (one == "O" && five == "O" && nine == "O") ||
                (two == "O" && five == "O" && eight == "O") ||
                (four == "O" && five == "O" && six == "O") ||
                (seven == "O" && eight == "O" && nine == "O") ||
                (three == "O" && six == "O" && nine == "O") ||
                (seven == "O" && five == "O" && three == "O"))
            {
                DrawScreen(ref one, ref two, ref three, ref four, ref five, ref six, ref seven, ref eight, ref nine, ref difficulty, ref GameRunning, ref turn);
                Console.SetCursorPosition(11, 22);
                Console.WriteLine("The Computer Wins.");
                Console.ReadKey();
                GameRunning = false;
            }
            //Declares a Draw.
            else if ((one == "X" || one == "O") &&
                (two == "X" || two == "O") &&
                (three == "X" || three == "O") &&
                (four == "X" || four == "O") &&
                (five == "X" || five == "O") &&
                (six == "X" || six == "O") &&
                (seven == "X" || seven == "O") &&
                (eight == "X" || eight == "O") &&
                (nine == "X" || nine == "O"))
            {
                DrawScreen(ref one, ref two, ref three, ref four, ref five, ref six, ref seven, ref eight, ref nine, ref difficulty, ref GameRunning, ref turn);
                Console.SetCursorPosition(11, 22);
                Console.WriteLine("The Game is a Draw.");
                Console.ReadKey();
                GameRunning = false;
            }
            else
            {
                GameRunning = true;
            }
        }

        public void CreateGame(ref Boolean firstplayer, string difficulty, ref Boolean GameRunning)
        {
            String one = "1";
            String two = "2";
            String three = "3";
            String four = "4";
            String five = "5";
            String six = "6";
            String seven = "7";
            String eight = "8";
            String nine = "9";
            int turn = 0;

            while (GameRunning == true)
            {
                ++turn;
                //Manage's the player's turn.
                while (firstplayer == true)
                {
                    var ScreenUpdater = new GameSession();
                    ScreenUpdater.DrawScreen(ref one, ref two, ref three, ref four, ref five, ref six, ref seven, ref eight, ref nine, ref difficulty, ref GameRunning, ref turn);
                    Boolean MoveMenu = true;
                    while (MoveMenu == true)
                    {
                        Console.SetCursorPosition(11, 19);
                        Console.WriteLine("Select a number to make your move: ");
                        Console.WriteLine("   **                             ");
                        Console.SetCursorPosition(46, 19);
                        ConsoleKeyInfo input = Console.ReadKey();
                        if (char.IsDigit(input.KeyChar))
                        {
                            String PlayerMoveString = Convert.ToString(input.KeyChar);
                            if (PlayerMoveString == "1" && one != "X" && one != "O")
                            {
                                one = "X";
                                Console.SetCursorPosition(11, 20);
                                firstplayer = false;
                                MoveMenu = false;
                                var test = new GameSession();
                                test.CheckWinner(ref one, ref two, ref three, ref four, ref five, ref six, ref seven, ref eight, ref nine, ref GameRunning, ref firstplayer, ref turn);
                            }
                            else if (PlayerMoveString == "2" && two != "X" && two != "O")
                            {
                                two = "X";
                                Console.SetCursorPosition(11, 20);
                                firstplayer = false;
                                MoveMenu = false;
                                var test = new GameSession();
                                test.CheckWinner(ref one, ref two, ref three, ref four, ref five, ref six, ref seven, ref eight, ref nine, ref GameRunning, ref firstplayer, ref turn);
                            }
                            else if (PlayerMoveString == "3" && three != "X" && three != "O")
                            {
                                three = "X";
                                Console.SetCursorPosition(11, 20);
                                firstplayer = false;
                                MoveMenu = false;
                                var test = new GameSession();
                                test.CheckWinner(ref one, ref two, ref three, ref four, ref five, ref six, ref seven, ref eight, ref nine, ref GameRunning, ref firstplayer, ref turn);
                            }
                            else if (PlayerMoveString == "4" && four != "X" && four != "O")
                            {
                                four = "X";
                                Console.SetCursorPosition(11, 20);
                                firstplayer = false;
                                MoveMenu = false;
                                var test = new GameSession();
                                test.CheckWinner(ref one, ref two, ref three, ref four, ref five, ref six, ref seven, ref eight, ref nine, ref GameRunning, ref firstplayer, ref turn);
                            }
                            else if (PlayerMoveString == "5" && five != "X" && five != "O")
                            {
                                five = "X";
                                Console.SetCursorPosition(11, 20);
                                firstplayer = false;
                                MoveMenu = false;
                                var test = new GameSession();
                                test.CheckWinner(ref one, ref two, ref three, ref four, ref five, ref six, ref seven, ref eight, ref nine, ref GameRunning, ref firstplayer, ref turn);
                            }
                            else if (PlayerMoveString == "6" && six != "X" && six != "O")
                            {
                                six = "X";
                                Console.SetCursorPosition(11, 20);
                                firstplayer = false;
                                MoveMenu = false;
                                var test = new GameSession();
                                test.CheckWinner(ref one, ref two, ref three, ref four, ref five, ref six, ref seven, ref eight, ref nine, ref GameRunning, ref firstplayer, ref turn);
                            }
                            else if (PlayerMoveString == "7" && seven != "X" && seven != "O")
                            {
                                seven = "X";
                                Console.SetCursorPosition(11, 20);
                                firstplayer = false;
                                MoveMenu = false;
                                var test = new GameSession();
                                test.CheckWinner(ref one, ref two, ref three, ref four, ref five, ref six, ref seven, ref eight, ref nine, ref GameRunning, ref firstplayer,ref turn);
                            }
                            else if (PlayerMoveString == "8" && eight != "X" && eight != "O")
                            {
                                eight = "X";
                                Console.SetCursorPosition(11, 20);
                                firstplayer = false;
                                MoveMenu = false;
                                var test = new GameSession();
                                test.CheckWinner(ref one, ref two, ref three, ref four, ref five, ref six, ref seven, ref eight, ref nine, ref GameRunning, ref firstplayer, ref turn);
                            }
                            else if (PlayerMoveString == "9" && nine != "X" && nine != "O")
                            {
                                nine = "X";
                                Console.SetCursorPosition(11, 20);
                                firstplayer = false;
                                MoveMenu = false;
                                var test = new GameSession();
                                test.CheckWinner(ref one, ref two, ref three, ref four, ref five, ref six, ref seven, ref eight, ref nine, ref GameRunning, ref firstplayer, ref turn);
                            }
                        }
                    }
                }



                //Manage's the Computer's turn.
                while (firstplayer == false && GameRunning == true)
                {
                    var ScreenUpdater2 = new GameSession();
                    ScreenUpdater2.DrawScreen(ref one, ref two, ref three, ref four, ref five, ref six, ref seven, ref eight, ref nine, ref difficulty, ref GameRunning, ref turn);
                    Console.SetCursorPosition(11, 19);
                    Console.WriteLine("Press any key to show the AI move.");
                    Console.WriteLine("   **                             ");
                    Console.SetCursorPosition(11, 22);
                    Console.ReadKey();

                    while (firstplayer == false)
                    {
                        Random rnd = new Random();
                        int RandomMove = rnd.Next(1, 10);
                        String ComputerMove = Convert.ToString(RandomMove);

                        if (ComputerMove == "1" && one != "X" && one != "O")
                        {
                            one = "O";
                            Console.SetCursorPosition(11, 20);
                            firstplayer = true;
                        }
                        else if (ComputerMove == "2" && two != "X" && two != "O")
                        {
                            two = "O";
                            Console.SetCursorPosition(11, 20);
                            firstplayer = true;
                        }
                        else if (ComputerMove == "3" && three != "X" && three != "O")
                        {
                            three = "O";
                            Console.SetCursorPosition(11, 20);
                            firstplayer = true;
                        }
                        else if (ComputerMove == "4" && four != "X" && four != "O")
                        {
                            four = "O";
                            Console.SetCursorPosition(11, 20);
                            firstplayer = true;
                        }
                        else if (ComputerMove == "5" && five != "X" && five != "O")
                        {
                            five = "O";
                            Console.SetCursorPosition(11, 20);
                            firstplayer = true;
                        }
                        else if (ComputerMove == "6" && six != "X" && six != "O")
                        {
                            six = "O";
                            Console.SetCursorPosition(11, 20);
                            firstplayer = true;
                        }
                        else if (ComputerMove == "7" && seven != "X" && seven != "O")
                        {
                            seven = "O";
                            Console.SetCursorPosition(11, 20);
                            firstplayer = true;
                        }
                        else if (ComputerMove == "8" && eight != "X" && eight != "O")
                        {
                            eight = "O";
                            Console.SetCursorPosition(11, 20);
                            firstplayer = true;
                        }
                        else if (ComputerMove == "9" && nine != "X" && nine != "O")
                        {
                            nine = "O";
                            Console.SetCursorPosition(11, 20);
                            firstplayer = true;
                        }
                        else
                        {
                            firstplayer = false;
                        }
                        var test = new GameSession();
                        test.CheckWinner(ref one, ref two, ref three, ref four, ref five, ref six, ref seven, ref eight, ref nine, ref GameRunning, ref firstplayer, ref turn);
                    }
                }
            }
        }
    }
}
