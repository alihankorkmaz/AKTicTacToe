
string f1 = " ", f2 = " ", f3 = " ", f4 = " ", f5 = " ", f6 = " ", f7 = " ", f8 = " ", f9 = " ";
string choices = "X";
string user, playername;
int usernumber = 0;
int choicenumber = 0;
Console.WriteLine("Welcome to the tic-tac-toe!");
Console.WriteLine("Please Enter Player Names");
Console.Write("Player X: ");
string playerX = Console.ReadLine();
Console.Write("Player O: ");
string playerO = Console.ReadLine();
Console.WriteLine("Let The Game Begin!");

for (int a = 0; a < 9; a++)
{
    Console.WriteLine($" {f1} | {f2} | {f3}");
    Console.WriteLine("---+---+---");
    Console.WriteLine($" {f4} | {f5} | {f6}");
    Console.WriteLine("---+---+---");
    Console.WriteLine($" {f7} | {f8} | {f9}");

    if (a % 2 == 0)
    {
        playername = playerX;
        choices = "X";
    }
       
            else
    {

        playername = playerO;
        choices = "O";
    }

    while (choicenumber < 9)
    {
        Console.Write($"{choices}'s move ({playername}) > ");
        user = Console.ReadLine();
        if (!int.TryParse(user, out usernumber)) continue;

        if (usernumber == 1)
        {
            if (f1 != " ")
            {
                Console.WriteLine("Illegal Move TRY AGAIN");
                continue;
            }
            else
            {
                f1 = choices;
            }
            
        }

        else if (usernumber == 2)
        {
            if (f2 != " ")
            {
                Console.WriteLine("Illegal Move TRY AGAIN");
                continue;
            }
            else
            {
                f2 = choices;
            }
        }

        else if (usernumber == 3)
        {
            if (f3 != " ")
            {
                Console.WriteLine("Illegal Move TRY AGAIN");
                continue;
            }
            else
            {
                f3 = choices;
            }
        }

        else if (usernumber == 4)
        {
            if (f4 != " ")
            {
                Console.WriteLine("Illegal Move TRY AGAIN");
                continue;
            }
            else
            {
                f3 = choices;
            }
        }

        else if (usernumber == 5)
        {
            if (f5 != " ")
            {
                Console.WriteLine("Illegal Move TRY AGAIN");
                continue;
            }
            else
            {
                f5 = choices;
            }
        }

        else if (usernumber == 6)
        {
            if (f6 != " ")
            {
                Console.WriteLine("Illegal Move TRY AGAIN");
                continue;
            }
            else
            {
                f6 = choices;
            }
        }

        else if (usernumber == 7)
        {
            if (f7 != " ")
            {
                Console.WriteLine("Illegal Move TRY AGAIN");
                continue;
            }
            else
            {
                f7 = choices;
            }
        }

        else if (usernumber == 8)
        {
            if (f8 != " ")
            {
                Console.WriteLine("Illegal Move TRY AGAIN");
                continue;
            }
            else
            {
                f8 = choices;
            }
        }

        else if (usernumber == 9)
        {
            if (f9 != " ")
            {
                Console.WriteLine("Illegal Move TRY AGAIN");
                continue;
            }
            else
            {
                f9 = choices;
            }
        }


        else
        {
            Console.WriteLine("Illegal Move TRY AGAIN");
            continue;
        }

        usernumber++;
        break;
    }


}
{
    // GAME IS OVER, SHOW THE FINAL VERSION OF TABLE
    Console.WriteLine("");
    Console.WriteLine($" {f1} | {f2} | {f3}");
    Console.WriteLine("---+---+---");
    Console.WriteLine($" {f4} | {f5} | {f6}");
    Console.WriteLine("---+---+---");
    Console.WriteLine($" {f7} | {f8} | {f9}");
}
Console.WriteLine();
Console.WriteLine("Game Over!");
