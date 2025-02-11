namespace Tic_Tac_Toe_game
{
    internal class Program
    {
        // My Functions
   
        // 1_ To print playing board.
        static void Print_X_o(string x_o)
        {
            Console.WriteLine();
            for (int i = 0; i < x_o.Length; i++)
            {
                if (i == 2 || i == 5)
                {
                    Console.WriteLine(" | " + x_o[i]);
                }
                else if (i == 0 || i == 3 || i == 6)
                {
                    Console.Write(x_o[i]);
                }
                else
                {
                    Console.Write(" | " + x_o[i]);
                }
            }
            Console.WriteLine();
        }
        // 2_ When they playing X O.
        static string Playing_X_O(int p, char X_or_O, string playing)
        {
            string playing_X_O = "";
            for (int sp = 0; sp < playing.Length; sp++)
            {
                if (sp == p)
                {
                    playing_X_O += X_or_O;
                }
                else { playing_X_O += playing[sp]; }
            }
            playing = playing_X_O;
            return playing;
        }
        // 3_ Take acorrect input( Only from 1 To 9).
        static int Check_input(string check, string X_O, int player)
        {
            int numPosition_p1 = 0;
            if (check.Length > 1)
            {
                for (; ; )
                {
                    Console.Write("P(" + player + ")...Plz Enter  Position from 1 to 9: ");
                    string numl = Console.ReadLine();
                    if (numl.Length == 1 && (numl[0] - '0' >= 1 && numl[0] - '0' <= 9) && X_O[(numl[0] - '0') - 1] == '-')
                    {
                        numPosition_p1 = numl[0] - '0';
                        break;
                    }
                    else { continue; }
                }
            }
            else
            {
                if (check[0] - '0' >= 1 && check[0] - '0' <= 9 && X_O[(check[0] - '0') - 1] == '-')
                {
                    numPosition_p1 = check[0] - '0';
                }
                else
                {
                    for (; ; )
                    {
                        Console.Write("P(" + player + ")...Plz Enter  Position from 1 to 9: ");
                        string numl = Console.ReadLine();
                        if (numl.Length == 1 && (numl[0] - '0' >= 1 && numl[0] - '0' <= 9) && X_O[(numl[0] - '0') - 1] == '-')
                        {
                            numPosition_p1 = numl[0] - '0';
                            break;
                        }
                        else { continue; }
                    }
                }
            }
            return numPosition_p1 - 1;
        }
        // 4_ Give us the winner.
        static char The_wins(string game, char x_or_o)
        {
            string Cases = "012,345,678,036,147,258,048,246";
            char wins = 'm';
            int con_x_r_o = 0;
            foreach (char i in Cases)
            {
                if (i == ',')
                {
                    con_x_r_o = 0;
                }
                else
                {
                    if (game[i - '0'] == x_or_o)
                    {
                        con_x_r_o++;
                        if (con_x_r_o == 3)
                        {
                            wins = x_or_o;
                            break;
                        }
                    }
                }
            }
            if (con_x_r_o != 3)
            {
                wins = 'n';
            }
            return wins;
        }
        // Gives us The first player in next game.
        static int The_first_play(int num_player)
        {
            if (num_player == 1)
            {
                num_player = 2;
            }
            else
            {
                num_player = 1;
            }
            return num_player;
        }


        static void Main(string[] args)
        {
            int who_play_first = 1;
            for (; ; )
            {
                Console.WriteLine("Welecome To Tic Tac Toe Game!.\n");
                Console.WriteLine("Player 1 is O and Player 2 is X.\n");
                string X_O = "";
                for (int i = 0; i < 9; i++)
                {
                    X_O += "-";
                }
                Print_X_o(X_O);
                for (int i = 0; i < 5; i++)
                {
                    if (who_play_first == 1)
                    {
                        Console.Write("\nPlayer " + 1 + "...Enter  Position from 1 to 9: ");
                        string Position_1 = Console.ReadLine();
                        int numPosition_1 = Check_input(Position_1, X_O, 1);
                        X_O = Playing_X_O(numPosition_1, 'O', X_O);
                        Print_X_o(X_O);
                        char the_wins = The_wins(X_O, 'O');
                        if (the_wins == 'O')
                        {
                            Console.WriteLine("\nPlayer " + 1 + " wins!");
                            who_play_first = 2;
                            break;
                        }
                        else
                        {
                            if (i == 5 - 1)
                            {
                                Console.WriteLine("\nIt's a Draw..");
                                who_play_first = The_first_play(who_play_first);
                                break;
                            }
                        }
                        Console.Write("\nPlayer " + 2 + "...Enter  Position from 1 to 9: ");
                        string Position_2 = Console.ReadLine();
                        int numPosition_2 = Check_input(Position_2, X_O, 2);
                        X_O = Playing_X_O(numPosition_2, 'X', X_O);
                        Print_X_o(X_O);
                        char the_wins_2 = The_wins(X_O, 'X');
                        if (the_wins_2 == 'X')
                        {
                            Console.WriteLine("\nPlayer " + 2 + " wins!");
                            who_play_first = 1;
                            break;
                        }
                        else
                        {
                            if (i == 5 - 1)
                            {
                                Console.WriteLine("\nIt's a Draw..");
                                who_play_first = The_first_play(who_play_first);
                                break;
                            }
                        }
                    }
                    else
                    {
                        Console.Write("\nPlayer " + 2 + "...Enter  Position from 1 to 9: ");
                        string Position_2 = Console.ReadLine();
                        int numPosition_2 = Check_input(Position_2, X_O, 2);
                        X_O = Playing_X_O(numPosition_2, 'X', X_O);
                        Print_X_o(X_O);
                        char the_wins_2 = The_wins(X_O, 'X');
                        if (the_wins_2 == 'X')
                        {
                            Console.WriteLine("\nPlayer " + 2 + " wins!");
                            who_play_first = 1;
                            break;
                        }
                        else
                        {
                            if (i == 5 - 1)
                            {
                                Console.WriteLine("\nIt's a Draw..");
                                who_play_first = The_first_play(who_play_first);
                                break;
                            }
                        }
                        Console.Write("\nPlayer " + 1 + "...Enter  Position from 1 to 9: ");
                        string Position_1 = Console.ReadLine();
                        int numPosition_1 = Check_input(Position_1, X_O, 1);
                        X_O = Playing_X_O(numPosition_1, 'O', X_O);
                        Print_X_o(X_O);
                        char the_wins = The_wins(X_O, 'O');
                        if (the_wins == 'O')
                        {
                            Console.WriteLine("\nPlayer " + 1 + " wins!");
                            who_play_first = 2;
                            break;
                        }
                        else
                        {
                            if (i == 5 - 1)
                            {
                                Console.WriteLine("\nIt's a Draw..");
                                who_play_first = The_first_play(who_play_first);
                                break;
                            }
                        }
                    }
                }
                Console.Write("\nDo You Want To Play again?");
                char y_n = char.ToLower(Console.ReadLine()[0]);
                if (y_n == 'n')
                {
                    who_play_first = 1;
                    Console.WriteLine("  GOOD BAY..\n");
                    break;
                }
                else
                {
                    Console.WriteLine("\n"); continue;
                }
            }
        }
    }
}
