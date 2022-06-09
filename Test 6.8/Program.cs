// See https://aka.ms/new-console-template for more information

// variable declaration
char[,] board = { { '#', '#', '#' }, { '#', '#', '#' }, { '#', '#', '#' } };
int userInputX = 1;
int userInputY = 1;
char turn = 'X';
char winner = '@';
Boolean gameCompleted = false;
Boolean isValid = true;


Console.WriteLine("Welcome to Simon's TicTacToe game!");

//loops until the game is over
while (!gameCompleted)
{
    //Printing the current board and whos turn is it
    Console.WriteLine("It is " + turn + "'s turn!");
    Console.WriteLine(" ------------");
    Console.WriteLine("| " + board[0, 0] + " | " + board[0, 1] + " | " + board[0, 2] + " |");
    Console.WriteLine(" ------------");
    Console.WriteLine("| " + board[1, 0] + " | " + board[1, 1] + " | " + board[1, 2] + " |");
    Console.WriteLine(" ------------");
    Console.WriteLine("| " + board[2, 0] + " | " + board[2, 1] + " | " + board[2, 2] + " |");
    Console.WriteLine(" ------------");
    gameCompleted = false;

    //Getting the users turn
    while (isValid)
    {
        Console.WriteLine("Please input an x coordinate (1-3)");
        userInputX = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine("Please input an y coordinate (1-3)");
        userInputY = Convert.ToInt32(Console.ReadLine());
        
        isValid = false;
    }
    isValid = true;

    board[userInputY - 1, userInputX - 1] = turn;

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
}

Console.WriteLine(" ------------");
Console.WriteLine("| " + board[0, 0] + " | " + board[0, 1] + " | " + board[0, 2] + " |");
Console.WriteLine(" ------------");
Console.WriteLine("| " + board[1, 0] + " | " + board[1, 1] + " | " + board[1, 2] + " |");
Console.WriteLine(" ------------");
Console.WriteLine("| " + board[2, 0] + " | " + board[2, 1] + " | " + board[2, 2] + " |");
Console.WriteLine(" ------------");
Console.WriteLine("\nThe winner is " + winner + "!");



