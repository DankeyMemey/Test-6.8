// See https://aka.ms/new-console-template for more information

// variable declaration
Random rng = new Random();
char[,] board = { { '#', '#', '#' }, { '#', '#', '#' }, { '#', '#', '#' } };
String userInput = "";
int userInputX = 0;
int userInputY = 0;
int chance1 = 0;
int chance2 = 0;
int turns = 1;
char turn = 'X';
char artyI = '@';
char winner = '@';
Boolean gameCompleted = false;
Boolean isValid = false;
Boolean isIntX = false;
Boolean isIntY = false;
Boolean cpuPlayer = false;

Console.WriteLine("Welcome to Simon's TicTacToe game!\n");

while (!isValid)
{
    Console.WriteLine("Would you like to play with a CPU? (Yes/No)");
    userInput = Console.ReadLine().ToLower();
    if (userInput.Equals("yes"))
    {
        cpuPlayer = true;
        isValid = true;
    }

    else if (!(userInput.Equals("no")))
    {
        isValid = false;
    }

    else
        isValid = true;
}

isValid = false;

while (!isValid && cpuPlayer == true)
{
    Console.WriteLine("\nWhat shape should the AI play as (X/O)");
    userInput = Console.ReadLine().ToUpper();

    if (userInput.Equals("X"))
    {
        artyI = 'X';
        isValid = true;
    }

    else if (userInput.Equals("O"))
    {
        artyI = 'O';
        isValid = true;
    }

    else
        Console.WriteLine("Invalid Input");
}


isValid = false;


//loops until the game is over
while (!gameCompleted)
{
    //Printing the current board and whos turn is it
    Console.WriteLine("\nIt is " + turn + "'s turn!\n" + turns + " turns have elapsed.\n");
    Console.WriteLine(" ------------");
    Console.WriteLine("| " + board[0, 0] + " | " + board[0, 1] + " | " + board[0, 2] + " |");
    Console.WriteLine(" ------------");
    Console.WriteLine("| " + board[1, 0] + " | " + board[1, 1] + " | " + board[1, 2] + " |");
    Console.WriteLine(" ------------");
    Console.WriteLine("| " + board[2, 0] + " | " + board[2, 1] + " | " + board[2, 2] + " |");
    Console.WriteLine(" ------------");

    //Getting the users turn and a metric f**kton of user validation
    while (!isValid && (turn != artyI))
    {
        Console.WriteLine("Please input an x coordinate (1-3)");
        isIntX = int.TryParse(Console.ReadLine(), out userInputX);
;
        Console.WriteLine("Please input an y coordinate (1-3)");
        isIntY = int.TryParse(Console.ReadLine(), out userInputY);

        if (isIntX && isIntY)
        {
            if ((userInputY == 1 || userInputY == 2 || userInputY == 3) && (userInputX == 1 || userInputX == 2 || userInputX == 3))
            {
                isValid = true;
            }
        }

        if (isValid && board[userInputY - 1, userInputX - 1] == '#')
        {
            board[userInputY - 1, userInputX - 1] = turn;
            turns++;
        }

        else
        {
            Console.WriteLine("\nIncorrect Input!\n");
            isValid = false;
        }

    }
    isValid = false;

    if (turn == artyI)
    {
        if (turns == 1)
        {
            if (rng.Next(0, 11) <= 7)
            {
                board[1, 1] = artyI;
                turns++;
            }

            else
            {
                board[rng.Next(0, 3), rng.Next(0, 3)] = artyI;
                turns++;
            }
        }

        else if (turns == 2)
        {
            if ((rng.Next(0, 21) > 2) && (board[1, 1] == '#'))
            {
                board[1, 1] = artyI;
                turns++;
            }

            else
            {
                while (!isValid)
                {
                    chance1 = rng.Next(0, 3);
                    chance2 = rng.Next(0, 3);
                    if (board[chance1, chance2] == '#')
                    {
                        board[chance1, chance2] = artyI;
                        isValid = true;
                        turns++;
                    }
                }
                isValid = false;
            }
        }

        else if (turns == 3 || turns == 4)
        {
            Console.WriteLine("In development");
            turns++;
        }

        else
            turns++;

    }

    //Mr. Metric F**ckton makes a return for checking if there is a winner for way too many lines
    if (board[0,0] == 'X' && board[0, 1] == 'X' && board[0, 2] == 'X')
    {
        winner = 'X';
        gameCompleted = true;
    }

    else if (board[0, 0] == 'O' && board[0, 1] == 'O' && board[0, 2] == 'O')
    {
        winner = 'O';
        gameCompleted = true;
    }

    else if (board[1, 0] == 'X' && board[1, 1] == 'X' && board[1, 2] == 'X')
    {
        winner = 'X';
        gameCompleted = true;
    }

    else if (board[1, 0] == 'O' && board[1, 1] == 'O' && board[1, 2] == 'O')
    {
        winner = 'O';
        gameCompleted = true;
    }

    else if (board[2, 0] == 'X' && board[2, 1] == 'X' && board[2, 2] == 'X')
    {
        winner = 'X';
        gameCompleted = true;
    }

    else if (board[2, 0] == 'O' && board[2, 1] == 'O' && board[2, 2] == 'O')
    {
        winner = 'O';
        gameCompleted = true;
    }

    else if (board[0, 0] == 'X' && board[1, 0] == 'X' && board[2, 0] == 'X')
    {
        winner = 'X';
        gameCompleted = true;
    }

    else if (board[0, 0] == 'O' && board[1, 0] == 'O' && board[2, 0] == 'O')
    {
        winner = 'O';
        gameCompleted = true;
    }

    else if (board[0, 1] == 'X' && board[1, 1] == 'X' && board[2, 1] == 'X')
    {
        winner = 'X';
        gameCompleted = true;
    }

    else if (board[0, 1] == 'O' && board[1, 1] == 'O' && board[2, 1] == 'O')
    {
        winner = 'O';
        gameCompleted = true;
    }

    else if (board[0, 2] == 'X' && board[1, 2] == 'X' && board[2, 2] == 'X')
    {
        winner = 'X';
        gameCompleted = true;
    }

    else if (board[0, 2] == 'O' && board[1, 2] == 'O' && board[2, 2] == 'O')
    {
        winner = 'O';
        gameCompleted = true;
    }

    else if (board[0, 0] == 'X' && board[1, 1] == 'X' && board[2, 2] == 'X')
    {
        winner = 'X';
        gameCompleted = true;
    }

    else if (board[0, 0] == 'O' && board[1, 1] == 'O' && board[2, 2] == 'O')
    {
        winner = 'O';
        gameCompleted = true;
    }

    else if (board[0, 2] == 'X' && board[1, 1] == 'X' && board[2, 0] == 'X')
    {
        winner = 'X';
        gameCompleted = true;
    }

    else if (board[0, 2] == 'O' && board[1, 1] == 'O' && board[2, 0] == 'O')
    {
        winner = 'O';
        gameCompleted = true;
    }

    if (turn == 'X')
        turn = 'O';
    else
        turn = 'X';

    if (turns == 10)
    {
        winner = 'T';
        break;
    }

}

Console.WriteLine(" ------------");
Console.WriteLine("| " + board[0, 0] + " | " + board[0, 1] + " | " + board[0, 2] + " |");
Console.WriteLine(" ------------");
Console.WriteLine("| " + board[1, 0] + " | " + board[1, 1] + " | " + board[1, 2] + " |");
Console.WriteLine(" ------------");
Console.WriteLine("| " + board[2, 0] + " | " + board[2, 1] + " | " + board[2, 2] + " |");
Console.WriteLine(" ------------");

if (winner == 'T')
    Console.WriteLine("\nThere is no winner. :(");   

else
    Console.WriteLine("\nIn " + turns + " turns. The winner is " + winner + "!");