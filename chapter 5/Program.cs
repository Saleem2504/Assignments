// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// question 1
// int firstNum = 20;
// int secondNum = 10;

// if (firstNum > secondNum){
// int temp = firstNum;
// firstNum = secondNum;
// secondNum = temp;

// }

// Console.WriteLine($"After swapping");
// Console.WriteLine($"firstNum = {firstNum}");
// Console.WriteLine($"secondNum = {secondNum}");
// question 2
// Console.WriteLine("Enter first number: ");
//         double firstNumber = Convert.ToDouble(Console.ReadLine());

//         Console.WriteLine("Enter second number: ");
//         double secondNumber = Convert.ToDouble(Console.ReadLine());

//         Console.WriteLine("Enter third number: ");
//         double thirdNumber = Convert.ToDouble(Console.ReadLine());

//         // Determine the sign of the product of the three real numbers
//         string sign = "+";
//         if (firstNumber < 0)
//         {
//             sign = "-";
//         }

//         if (secondNumber < 0)
//         {
//             sign = sign == "+" ? "-" : "+";
//         }

//         if (thirdNumber < 0)
//         {
//             sign = sign == "+" ? "-" : "+";
//         }

//         // Print the sign of the product of the three real numbers
//         Console.WriteLine($"The sign of the product of the three real numbers is {sign}.");
// question 3
  // Read the three integers
        // Console.WriteLine("Enter first integer: ");
        // int firstInteger = Convert.ToInt32(Console.ReadLine());

        // Console.WriteLine("Enter second integer: ");
        // int secondInteger = Convert.ToInt32(Console.ReadLine());

        // Console.WriteLine("Enter third integer: ");
        // int thirdInteger = Convert.ToInt32(Console.ReadLine());

        // // Find the biggest of the three integers using nested if statements
        // int biggestInteger = firstInteger;

        // if (secondInteger > biggestInteger)
        // {
        //     biggestInteger = secondInteger;
        // }

        // if (thirdInteger > biggestInteger)
        // {
        //     biggestInteger = thirdInteger;
        // }

        // // Print the biggest integer
        // Console.WriteLine($"The biggest of the three integers is {biggestInteger}.");
        // Read the three real numbers
        // question 4
        // Console.WriteLine("Enter first number: ");
        // double firstNumber = Convert.ToDouble(Console.ReadLine());

        // Console.WriteLine("Enter second number: ");
        // double secondNumber = Convert.ToDouble(Console.ReadLine());

        // Console.WriteLine("Enter third number: ");
        // double thirdNumber = Convert.ToDouble(Console.ReadLine());

        // // Sort the three real numbers in descending order using nested if statements
        // if (firstNumber < secondNumber)
        // {
        //     double temp = firstNumber;
        //     firstNumber = secondNumber;
        //     secondNumber = temp;
        // }

        // if (firstNumber < thirdNumber)
        // {
        //     double temp = firstNumber;
        //     firstNumber = thirdNumber;
        //     thirdNumber = temp;
        // }

        // if (secondNumber < thirdNumber)
        // {
        //     double temp = secondNumber;
        //     secondNumber = thirdNumber;
        //     thirdNumber = temp;
        // }

        // // Print the three real numbers in descending order
        // Console.WriteLine($"The three real numbers in descending order are {firstNumber}, {secondNumber}, and {thirdNumber}.");
        // question 5
        // Ask for a digit
        // Console.WriteLine("Enter a digit: ");
        // int digit = Convert.ToInt32(Console.ReadLine());

        // // Show the digit as a word using a switch statement
        // string word = "";
        // switch (digit)
        // {
        //     case 0:
        //         word = "zero";
        //         break;
        //     case 1:
        //         word = "one";
        //         break;
        //     case 2:
        //         word = "two";
        //         break;
        //     case 3:
        //         word = "three";
        //         break;
        //     case 4:
        //         word = "four";
        //         break;
        //     case 5:
        //         word = "five";
        //         break;
        //     case 6:
        //         word = "six";
        //         break;
        //     case 7:
        //         word = "seven";
        //         break;
        //     case 8:
        //         word = "eight";
        //         break;
        //     case 9:
        //         word = "nine";
        //         break;
        //     default:
        //         word = "Invalid digit";
        //         break;
        // }

        // // Print the digit as a word
        // Console.WriteLine($"The digit {digit} in words is {word}.");
        // question 6
        // Get the coefficients a, b and c of the quadratic equation
        // Console.WriteLine("Enter the coefficient a: ");
        // double a = Convert.ToDouble(Console.ReadLine());

        // Console.WriteLine("Enter the coefficient b: ");
        // double b = Convert.ToDouble(Console.ReadLine());

        // Console.WriteLine("Enter the coefficient c: ");
        // double c = Convert.ToDouble(Console.ReadLine());

        // // Calculate the discriminant of the quadratic equation
        // double discriminant = b * b - 4 * a * c;

        // // If the discriminant is greater than zero, then the quadratic equation has two real roots
        // if (discriminant > 0)
        // {
        //     double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
        //     double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);

        //     Console.WriteLine($"The two real roots of the quadratic equation are {root1} and {root2}.");
        // }

        // // If the discriminant is equal to zero, then the quadratic equation has one real root
        // else if (discriminant == 0)
        // {
        //     double root = -b / (2 * a);

        //     Console.WriteLine($"The quadratic equation has one real root, which is {root}.");
        // }

        // // If the discriminant is less than zero, then the quadratic equation has no real roots
        // else
        // {
        //     Console.WriteLine("The quadratic equation has no real roots.");
        // }
        //question 7
        // Read the five numbers
        // Console.WriteLine("Enter first number: ");
        // int firstNumber = Convert.ToInt32(Console.ReadLine());

        // Console.WriteLine("Enter second number: ");
        // int secondNumber = Convert.ToInt32(Console.ReadLine());

        // Console.WriteLine("Enter third number: ");
        // int thirdNumber = Convert.ToInt32(Console.ReadLine());

        // Console.WriteLine("Enter fourth number: ");
        // int fourthNumber = Convert.ToInt32(Console.ReadLine());

        // Console.WriteLine("Enter fifth number: ");
        // int fifthNumber = Convert.ToInt32(Console.ReadLine());

        // // Find the greatest of the five numbers
        // int greatestNumber = firstNumber;

        // if (secondNumber > greatestNumber)
        // {
        //     greatestNumber = secondNumber;
        // }

        // if (thirdNumber > greatestNumber)
        // {
        //     greatestNumber = thirdNumber;
        // }

        // if (fourthNumber > greatestNumber)
        // {
        //     greatestNumber = fourthNumber;
        // }

        // if (fifthNumber > greatestNumber)
        // {
        //     greatestNumber = fifthNumber;
        // }

        // // Print the greatest of the five numbers
        // Console.WriteLine($"The greatest of the five numbers is {greatestNumber}.");

        // question 8
        // Console.Write("Enter a variable (int, double, or string): ");
        // string input = Console.ReadLine();

        // switch (Type.GetTypeCode(input.GetType()))
        // {
        //     case TypeCode.Int32:
        //         int intValue = int.Parse(input);
        //         intValue++;
        //         Console.WriteLine("Result: " + intValue);
        //         break;

        //     case TypeCode.Double:
        //         double doubleValue = double.Parse(input);
        //         doubleValue++;
        //         Console.WriteLine("Result: " + doubleValue);
        //         break;

        //     case TypeCode.String:
        //         string stringValue = input + "*";
        //         Console.WriteLine("Result: " + stringValue);
        //         break;

        //     default:
        //         Console.WriteLine("Unsupported data type. Please enter int, double, or string.");
        //         break;
        // }
        //question 9
int[] nums = new int[5] { 1, 2, 3, -4, 5 };

        // Find all subsets of the array
        List<List<int>> subsets = new List<List<int>>();
        for (int i = 0; i < (1 << nums.Length); i++)
        {
            List<int> subset = new List<int>();
            for (int j = 0; j < nums.Length; j++)
            {
                if ((i & (1 << j)) > 0)
                {
                    subset.Add(nums[j]);
                }
            }

            subsets.Add(subset);
        }

        // Find all subsets with sum 0
        List<List<int>> zeroSumSubsets = new List<List<int>>();
        foreach (List<int> subset in subsets)
        {
            if (subset.Sum() == 0)
            {
                zeroSumSubsets.Add(subset);
            }
        }

        // Print all subsets with sum 0
        foreach (List<int> subset in zeroSumSubsets)
        {
            Console.WriteLine(subset);
        }
    
    
     // question 10
     




        