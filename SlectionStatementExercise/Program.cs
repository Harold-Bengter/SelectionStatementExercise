//*Exercise one*\\
    var r = new Random();
    var myNumber = r.Next(1, 500);

    int userInput;

    Console.Write("Pick a number between 1 and 500.");

    do
    {
        userInput = int.Parse(Console.ReadLine());

        if (myNumber < userInput)
        {
            Console.WriteLine("That's a good guess but too high! Try again! ");
        }
        else if (myNumber > userInput)
        {
            Console.WriteLine("That's a little low. Try Again! ");
        }
        else
        {
            Console.WriteLine("That's the one! Great job! ");
        }

        Console.Write("Take another guess: ");
    }

    while (userInput != myNumber);
