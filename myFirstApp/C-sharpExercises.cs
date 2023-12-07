
using System.Xml.Linq;
void sum (int numOne, int numTwo)
{
    int result = numOne + numTwo;
    Console.WriteLine($"The sum of {numOne} and {numTwo} is: {result}");
}
void greetings()
{
    Console.WriteLine("Please give me your name: ");
    string name = Console.ReadLine();
    Console.WriteLine($"Hello {name}, nice to meet you!");
}
void personalInformation()
{
    Console.WriteLine("Please give me your FULL name: ");
    string name = Console.ReadLine();
    Console.WriteLine("How old are you? ");
    string age = Console.ReadLine();
    Console.WriteLine("Please give me your phone number: ");
    int number = int.Parse(Console.ReadLine());
    Console.WriteLine("Please give me your email address: ");
    string email = Console.ReadLine();


    Console.WriteLine($"-------------\nName: {name}\nAge: {age}\nPhone Number: {number}\nEmail: {email}\n-------------");
}
void arithmeticOperation(int numOne, int numTwo, int numThree, int numFour)
{
    int sum = numOne * numTwo;
    Console.WriteLine($"The multiplication of {numOne} and {numTwo} is: {sum}");
    int sub = numThree - sum;
    Console.WriteLine($"The subtraction of {sum} and {numThree} is: {sub}");
    int divition = numFour / sub;
    Console.WriteLine($"The divition of {numFour} and {sub} is: {divition}");
}
void Save()
{
    Console.WriteLine("Do you want to save the recent changes?");
    string yesOrNo = Console.ReadLine().ToUpper(); 

    if (yesOrNo == "Y" || yesOrNo == "N")
    {
        if (yesOrNo == "Y")
        {
            Console.WriteLine("Saving changes...");
        }
        else
        {
            Console.WriteLine("Discarding changes...");
        }
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter 'Y' or 'N'.");
    }
}
void IsAnAdult ()
{
    Console.WriteLine("Please give me your age");
    int age = int.Parse(Console.ReadLine());
    if (age >= 18 )
    {
        Console.WriteLine("You are an adult!");
    } 
    else
    {
        Console.WriteLine("You are not an adult!");
    }
}
void Operations()
{
    Console.WriteLine("Give me the first number: ");
    int numOne = int.Parse (Console.ReadLine());
    Console.WriteLine("Give me the second number: ");
    int numTwo = int.Parse(Console.ReadLine());
    Console.WriteLine("Give me the third number: ");
    int numThree = int.Parse(Console.ReadLine());

    int firstResult;
    if (numOne > numTwo)
    {
        firstResult = numOne + numTwo;
    }
    else
    {
        firstResult = numOne - numTwo;
    }

    int secondResult;
    if (numThree < firstResult)
    {
        secondResult = firstResult * numThree;
    }
    else
    {
        if (numThree == 0)
        {
            secondResult = firstResult;
        }
        else 
        {
            secondResult = firstResult / numThree;
        }
    }

    Console.WriteLine($"First result: {firstResult}\nSecond result: {secondResult}");

}
void Menu ()
{

    Console.WriteLine("1- Main Menu\n2- Profile\n3- Security Settings\n4-Privacy Settings\n0- Exit");
    Console.WriteLine("\n----Select an option [0-4]: ");
    string option  = Console.ReadLine();

    if (option == "1")
    {
        Console.WriteLine("Showing this 1 option...");
    }
    else if (option == "2")
    {
        Console.WriteLine("Showing this 2 option...");
    }
    else if (option == "3")
    {
        Console.WriteLine("Showing this 3 option...");
    }
    else if (option == "4")
    {
        Console.WriteLine("Showing this 4 option...");
    }
    else
    {
        Console.WriteLine("Try again: Only the numbers between 0 and 4 are allowed");    
    }
}
void Maths ()
{
    Console.WriteLine("Give me the first number: ");
    int numOne = int.Parse(Console.ReadLine());
    Console.WriteLine("Give me the second number: ");
    int numTwo = int.Parse(Console.ReadLine());
    Console.WriteLine("\nNow, select an option to execute...\n1- Add\n2- Substract\n3- Multiply\n4- Divide");
    string option = Console.ReadLine();

    if (option == "1")
    {
        int result = numOne + numTwo;
        Console.WriteLine($"The sum of {numOne} and {numTwo} is: {result}");
    }
    else if (option == "2")
    {
        int result = numOne - numTwo;
        Console.WriteLine($"The substraction of {numOne} and {numTwo} is: {result}");
    }
    else if (option == "3") 
    {
        int result = numOne * numTwo;
        Console.WriteLine($"The multiplication of {numOne} and {numTwo} is: {result}");
    }
    else if (option == "4")
    {
        if (numTwo == 0) 
        { 
            Console.WriteLine("We cannot divide a number by 0");
        } else
        {
            int result = numOne / numTwo;
            Console.WriteLine($"The divition of {numOne} and {numTwo} is: {result}");
        }
    }
}
void Counter(int number)
{
    for (int i = 0; i < number; i++)
    {
        if (number < 1 )
        {
            Console.WriteLine("This is not a valid number. Try again later...");
        }else
        {
            Console.WriteLine(i+1);
        }
    }
        
}
void ReverseCounter (int number)
{
    if (number <= 0)
    {
        for (int i = number; i <= 0; i++) { Console.WriteLine(i); }
    }
    
    if (number >= 0)
    {
        for (int i = number; i >= 0; i--) { Console.WriteLine(i); }
    }
}
void ExitLoop ()
{
    bool exit = false;
    while (!exit)
    {
        Console.WriteLine("Do you wanna exit this program? Y/N: ");
        string response = Console.ReadLine().ToUpper();
        if (response == "Y")
        {
            exit = true;
        }

    }

}
void ReverseMessage ()
{
    Console.WriteLine("How many messages do you wanna save?: ");
    int messagesCount = int.Parse(Console.ReadLine());
    List<string> messages = new List<string>();

    for (int i = 0; i < messagesCount; i++)
    {
        Console.WriteLine($"Message number {i+1}: ");
        messages.Add(Console.ReadLine());
    }

    Console.WriteLine("\n");

    for (int i = messagesCount - 1;  i >= 0; i--)
    {
        Console.WriteLine(messages[i]);
    }
}
void SortNumbers ()
{
    Console.WriteLine("How many numbers do you wanna save?: ");
    int numbersCount = int.Parse(Console.ReadLine());
    List<int> numbers = new List<int>();

    for (int i = 0; i < numbersCount; i++)
    {
        Console.WriteLine($"Number {i + 1}: ");
        numbers.Add(int.Parse(Console.ReadLine()));
    }
    numbers.Sort();
    Console.WriteLine("\n"); 
    
    for (int i = 0; i < numbers.Count; i++)
    {
        Console.WriteLine(numbers[i]);
    }
}
void Calculator()
{
    bool exit = false;
    int result = 0;
    int providedNumber;
    while (!exit)
    {
        Console.WriteLine($"---------\nCurrent initial number: {result}\nPlease provide a random number to work with: ");
        providedNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("\nNow, select an option to execute...\n1- Add\n2- Substract\n3- Multiply\n4- Divide\n0- Exit");
        string option = Console.ReadLine();

        if (option == "1")
        {
            result = result + providedNumber;
            Console.WriteLine($"The result is: {result}");
        }
        else if (option == "2")
        {
            result = result - providedNumber;
            Console.WriteLine($"The result is: {result}");
        }
        else if (option == "3")
        {
            result = result * providedNumber;
            Console.WriteLine($"The result is: {result}");
        }
        else if (option == "4")
        {
            if (providedNumber == 0)
            {
                Console.WriteLine("We cannot divide a number by 0");
            }
            else
            {
                result = result / providedNumber;
                Console.WriteLine($"The result is: {result}");
            }
        }
        else if (option == "0")
        {
            Console.WriteLine("See you later. Bye...");
            exit = true;
        }
    }
}
void Names()
{
    List<string> names = new List<string>();
    bool exit = false;
    Console.WriteLine("Welcome to the Names Manager");

    while (!exit)
    {
        Console.WriteLine("\nWhat do you want to do?: \n1- Add a name\n2- Check if a name already exists\n3- Remove a name\n4- List all names\n0- Exit\n");
        string option = Console.ReadLine();  
        if (option == "1")
        {
            Console.WriteLine("Give me a name: ");
            string name = Console.ReadLine();
            if (!names.Contains(name))
            {
                names.Add(name);
                Console.WriteLine($"{name} was added to the list");
            } else
            {
                Console.WriteLine("This name already exists in the list. You cannot add it.");
            }
            
        }
        else if (option == "2")
        {
            Console.WriteLine("Give me a name: ");
            string name = Console.ReadLine();
            if (names.Contains(name)) { Console.WriteLine("This name already exsists in the list."); }
            else { Console.WriteLine("This name does not exists in the list"); }
        }
        else if (option == "3")
        {
            Console.WriteLine("Give me a name: ");
            string name = Console.ReadLine();
            if (names.Contains(name)) 
            { 
                names.Remove(name);
                Console.WriteLine($"{name} was removed from the list");
            }
            else { Console.WriteLine("This name does not exists in the list"); }
        }
        else if (option == "4")
        {
            if (names.Count == 0) { Console.WriteLine("List is empty..."); }
            else
            {
                for (int i = 0; i < names.Count; i++)
                {
                    Console.WriteLine(names[i]);
                }
            }
        }
        else if (option == "0")
        {
            Console.WriteLine("See you later. Bye...");
            exit = true;
        }
    }
}

//---EJERCICIOS 6.1
//sum(5, 5);
//greetings();
//personalInformation();
//arithmeticOperation(5, 10, 20, 30);

//---EJERCICIOS 6.2
//Save();
//IsAnAdult();
//Operations();
//Menu();
//Maths();

//---EJERCICIOS 7.1
//Counter(5);
//ReverseCounter(-5);
//ExitLoop();
//ReverseMessage();

//---EJERCICIOS 8.1
//SortNumbers();
//Calculator();
//Names();  