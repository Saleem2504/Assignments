// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// question 1
        // Console.WriteLine("Enter a number");
        // int number1 = Convert.ToInt32(Console.ReadLine());
        // int number2 = Convert.ToInt32(Console.ReadLine());
        // int number3 = Convert.ToInt32(Console.ReadLine());

        // // Calculate the sum of the three numbers.
        // int sum = number1 + number2 + number3;

        // // Print the sum to the console.
        // Console.WriteLine("The sum of the three numbers is: " + sum);

        // question 2


        // Read the radius of the circle from the console.
        // Console.WriteLine("Enter the radius of the circle: ");
        // double radius = Convert.ToDouble(Console.ReadLine());

        // // Calculate the perimeter and area of the circle.
        // double perimeter = 2 * Math.PI * radius;
        // double area = Math.PI * radius * radius;

        // // Print the perimeter and area to the console.
        // Console.WriteLine("The perimeter of the circle is: " + perimeter);
        // Console.WriteLine("The area of the circle is: " + area);

        // question 3

        //   Console.WriteLine("Enter company name: ");
        //     string companyName = Console.ReadLine();

        //     Console.WriteLine("Enter company address: ");
        //     string companyAddress = Console.ReadLine();

        //     Console.WriteLine("Enter company phone number: ");
        //     string companyPhoneNumber = Console.ReadLine();

        //     Console.WriteLine("Enter company fax number: ");
        //     string companyFaxNumber = Console.ReadLine();

        //     Console.WriteLine("Enter company website: ");
        //     string companyWebsite = Console.ReadLine();

        //     // Read manager information
        //     Console.WriteLine("Enter manager name: ");
        //     string managerName = Console.ReadLine();

        //     Console.WriteLine("Enter manager surname: ");
        //     string managerSurname = Console.ReadLine();

        //     Console.WriteLine("Enter manager phone number: ");
        //     string managerPhoneNumber = Console.ReadLine();

        //     // Print company and manager information
        //     Console.WriteLine("Company information:");
        //     Console.WriteLine($"Name: {companyName}");
        //     Console.WriteLine($"Address: {companyAddress}");
        //     Console.WriteLine($"Phone number: {companyPhoneNumber}");
        //     Console.WriteLine($"Fax number: {companyFaxNumber}");
        //     Console.WriteLine($"Website: {companyWebsite}");

        //     Console.WriteLine("Manager information:");
        //     Console.WriteLine($"Name: {managerName}");
        //     Console.WriteLine($"Surname: {managerSurname}");
        //     Console.WriteLine($"Phone number: {managerPhoneNumber}");

        // question 5

         // Read three numbers
        //     Console.WriteLine("Enter first number (hexadecimal): ");
        //     string hexNumber = Console.ReadLine();

        //     Console.WriteLine("Enter second number (fractional positive): ");
        //     double fractionalPositiveNumber = Convert.ToDouble(Console.ReadLine());

        //     Console.WriteLine("Enter third number (fractional negative): ");
        //     double fractionalNegativeNumber = Convert.ToDouble(Console.ReadLine());

        //     // Round the fractional numbers to the second decimal place
        //     fractionalPositiveNumber = Math.Round(fractionalPositiveNumber, 2);
        //     fractionalNegativeNumber = Math.Round(fractionalNegativeNumber, 2);

        //     // Print the three numbers in three virtual columns on the console
        //     Console.WriteLine($" {hexNumber:10} {fractionalPositiveNumber:10.2f} {fractionalNegativeNumber:10.2f}");

        // question 6

//  Console.WriteLine("Enter first number: ");
//             int firstNumber = Convert.ToInt32(Console.ReadLine());

//             Console.WriteLine("Enter second number: ");
//             int secondNumber = Convert.ToInt32(Console.ReadLine());

//             // Print the greater of the two numbers
//             Console.WriteLine($"The greater of {firstNumber} and {secondNumber} is {Math.Max(firstNumber, secondNumber)}.");

// question 7
//  int sum = 0;

//         // Read the five numbers
//         for (int i = 0; i < 5; i++)
//         {
//             // Prompt the user to enter a number
//             Console.WriteLine("Enter a number: ");

//             // Read the user's input
//             string input = Console.ReadLine();

            // Try to parse the user's input as an integer
        //     int number;
        //     if (int.TryParse(input, out number))
        //     {
        //         // If the input is a valid integer, add it to the sum
        //         sum += number;
        //     }
        //     else
        //     {
        //         // If the input is not a valid integer, prompt the user to enter another number
        //         Console.WriteLine("Invalid input. Please enter an integer.");
        //         i--;
        //     }
        // }

        // // Print the sum of the five numbers
        // Console.WriteLine($"The sum of the five numbers is {sum}.");
        // question 8
       



// try
// {
    

//         Console.WriteLine("Enter first number: ");
//             int firstNumber = Convert.ToInt32(Console.ReadLine());

//             Console.WriteLine("Enter second number: ");
//             int secondNumber = Convert.ToInt32(Console.ReadLine());

//             Console.WriteLine("Enter third number: ");
//             int thirdNumber = Convert.ToInt32(Console.ReadLine());


//             Console.WriteLine("Enter fourth number: ");
//             int fourthNumber = Convert.ToInt32(Console.ReadLine());

//             Console.WriteLine("Enter fourth number: ");
//             int fifthNumber = Convert.ToInt32(Console.ReadLine());
//  int greatestNumber = Math.Max(firstNumber, Math.Max(secondNumber, Math.Max(thirdNumber, Math.Max(fourthNumber, fifthNumber))));
//             // Print the greater of the two numbers
//             Console.WriteLine($"The greater of the numbers is {greatestNumber}.");
//             }
// catch (System.Exception ex)
// {
//       Console.WriteLine("Enter an integer: ");



//     }
// question 9
// Console.WriteLine("Enter numbers to read");
// int a =int.Parse(Console.ReadLine());
// int sum = 0;
// for (int i = 0; i < a; i++)
// {
    
// Console.WriteLine($"enter number {i + 1}: ");
// int num = int.Parse(Console.ReadLine());

// sum += num;

// }

// Console.WriteLine($"the sum is {sum}");
// question 10


    // Console.WriteLine("enter your number");
    // int num = int.Parse(Console.ReadLine());
    // for (int i = 0; i <= num; i++)
    // {
    //     Console.WriteLine($"{i}");
        
    // }
    // question 11
      // Initialize the first two numbers in the Fibonacci sequence
        // int firstNumber = 0;
        // int secondNumber = 1;

        // // Print the first two numbers in the Fibonacci sequence
        // Console.WriteLine(firstNumber);
        // Console.WriteLine(secondNumber);

        // // Calculate and print the next 98 numbers in the Fibonacci sequence
        // for (int i = 0; i < 98; i++)
        // {
        //     int nextNumber = firstNumber + secondNumber;

        //     // Print the next number in the Fibonacci sequence
        //     Console.WriteLine(nextNumber);

        //     // Update the first and second numbers
        //     firstNumber = secondNumber;
        //     secondNumber = nextNumber;
        // }

 // Initialize the sum of the series
        decimal sum = 1;

        // Calculate and add the next number in the series
        for (int i = 2; i < 100000; i++)
        {
            sum += 1m / i;

            // If the next number in the series is less than 0.001, stop the calculation
            if (1m / i < 0.001m)
            {
                break;
            }
        }

        // Print the sum of the series with precision of 0.001
        Console.WriteLine($"The sum of the series is {sum:F3}"); 

