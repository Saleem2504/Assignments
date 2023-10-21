// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!")

//  Console.Write("Enter a number (N): ");
//         if (int.TryParse(Console.ReadLine(), out int n))
//         {
//             if (n > 0)
//             {
//                 for (int i = 1; i <= n; i++)
//                 {
//                     Console.WriteLine(i);
//                 }
//             }
//             else
//             {
//                 Console.WriteLine("Please enter a positive number.");
//             }
//         }
//         else
//         {
//             Console.WriteLine("Invalid input. Please enter a valid number.");
//         }

// question 2
// Console.Write("Enter a number (N): ");
//         if (int.TryParse(Console.ReadLine(), out int n))
//         {
//             if (n > 0)
//             {
//                 for (int i = 1; i <= n; i++)
//                 {
//                     if (i % 3 != 0 || i % 7 != 0)
//                     {
//                         Console.WriteLine(i);
//                     }
//                 }
//             }
//             else
//             {
//                 Console.WriteLine("Please enter a positive number.");
//             }
//         }
//         else
//         {
//             Console.WriteLine("Invalid input. Please enter a valid number.");
//         }

// question 3
// int smallest = int.MaxValue;
//         int largest = int.MinValue;

//         Console.WriteLine("Enter a series of integers, separated by spaces: ");
//         string input = Console.ReadLine();

//         string[] numbers = input.Split(' ');

//         foreach (string number in numbers)
//         {
//             int value = Convert.ToInt32(number);

//             if (value < smallest)
//             {
//                 smallest = value;
//             }

//             if (value > largest)
//             {
//                 largest = value;
//             }
//         }

//         Console.WriteLine("The smallest integer is: {0}", smallest);
//         Console.WriteLine("The largest integer is: {0}", largest);
    
    // question 4 

    //   string[] suits = { "Hearts", "Diamonds", "Spades", "Clubs" };
    //     string[] ranks = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };

    //     foreach (string suit in suits)
    //     {
    //         foreach (string rank in ranks)
    //         {
    //             Console.WriteLine("{0} of {1}", rank, suit);
    //         }
    //     }

    // question 5
    // int n;

    //     Console.WriteLine("Enter a number: ");
    //     n = Convert.ToInt32(Console.ReadLine());

    //     int sum = 0;
    //     int a = 0;
    //     int b = 1;

    //     for (int i = 0; i < n; i++)
    //     {
    //         sum += a;
    //         int temp = a;
    //         a = b;
    //         b = temp + b;
    //     }

    //     Console.WriteLine("The sum of the first {0} Fibonacci numbers is: {1}", n, sum);
    
    // question 6
    //  Console.Write("Enter N (N > 1): ");
    //     if (int.TryParse(Console.ReadLine(), out int n) && n > 1)
    //     {
    //         Console.Write("Enter K (1 < K < N): ");
    //         if (int.TryParse(Console.ReadLine(), out int k) && k > 1 && k < n)
    //         {
    //             long nFactorial = 1;
    //             long kFactorial = 1;

    //             // Calculate N!
    //             for (int i = 1; i <= n; i++)
    //             {
    //                 nFactorial *= i;
    //             }

    //             // Calculate K!
    //             for (int i = 1; i <= k; i++)
    //             {
    //                 kFactorial *= i;
    //             }

    //             long result = nFactorial / kFactorial;
    //             Console.WriteLine($"N! / K! = {result}");
    //         }
    //         else
    //         {
    //             Console.WriteLine("Invalid value for K. It must be 1 < K < N.");
    //         }
    //     }
    //     else
    //     {
    //         Console.WriteLine("Invalid value for N. It must be greater than 1.");
    //     }
    // question 7
    // Console.Write("Enter N (N > 1): ");
    //     if (int.TryParse(Console.ReadLine(), out int n) && n > 1)
    //     {
    //         Console.Write("Enter K (1 < K < N): ");
    //         if (int.TryParse(Console.ReadLine(), out int k) && k > 1 && k < n)
    //         {
    //             long nFactorial = 1;
    //             long kFactorial = 1;

    //             // Calculate N!
    //             for (int i = 1; i <= n; i++)
    //             {
    //                 nFactorial *= i;
    //             }

    //             // Calculate K!
    //             for (int i = 1; i <= k; i++)
    //             {
    //                 kFactorial *= i;
    //             }

    //             long result = nFactorial / kFactorial;
    //             Console.WriteLine($"N! / K! = {result}");
    //         }
    //         else
    //         {
    //             Console.WriteLine("Invalid value for K. It must be 1 < K < N.");
    //         }
    //     }
    //     else
    //     {
    //         Console.WriteLine("Invalid value for N. It must be greater than 1.");
    //     }

// question 12
// Console.Write("Enter a decimal number: ");
//         if (int.TryParse(Console.ReadLine(), out int decimalNumber))
//         {
//             Console.Write("Binary representation: ");

//             int binaryBase = 2;
//             string binaryResult = "";

//             // Handle the case of 0 separately
//             if (decimalNumber == 0)
//             {
//                 Console.WriteLine("0");
//             }
//             else
//             {
//                 while (decimalNumber > 0)
//                 {
//                     int remainder = decimalNumber % binaryBase;
//                     binaryResult = remainder + binaryResult;
//                     decimalNumber /= binaryBase;
//                 }

//                 Console.WriteLine(binaryResult);
//             }
//         }
//         else
//         {
//             Console.WriteLine("Invalid input. Please enter a valid decimal number.");
//         }


// question 13
// question 14
//  int decimalNumber;

//         Console.WriteLine("Enter a decimal number: ");
//         decimalNumber = Convert.ToInt32(Console.ReadLine());

//         string hexadecimalNumber = "";

//         while (decimalNumber > 0)
//         {
//             int remainder = decimalNumber % 16;

//             if (remainder < 10)
//             {
//                 hexadecimalNumber = remainder + hexadecimalNumber;
//             }
//             else
//             {
//                 hexadecimalNumber = (char)(remainder + 55) + hexadecimalNumber;
//             }

//             decimalNumber /= 16;
//         }

//         Console.WriteLine("The hexadecimal representation of {0} is: {1}", decimalNumber, hexadecimalNumber);
    
    // question 15
    //  string hexadecimalNumber;

    //     Console.WriteLine("Enter a hexadecimal number: ");
    //     hexadecimalNumber = Console.ReadLine();

    //     int decimalNumber = 0;
    //     int power = 0;

    //     for (int i = hexadecimalNumber.Length - 1; i >= 0; i--)
    //     {
    //         char hexDigit = hexadecimalNumber[i];

    //         // Convert the hexadecimal digit to its decimal value.
    //         int digitValue;
    //         if (hexDigit >= '0' && hexDigit <= '9')
    //         {
    //             digitValue = hexDigit - '0';
    //         }
    //         else if (hexDigit >= 'A' && hexDigit <= 'F')
    //         {
    //             digitValue = hexDigit - 'A' + 10;
    //         }
    //         else
    //         {
    //             throw new ArgumentOutOfRangeException("hexDigit", "Invalid hexadecimal digit.");
    //         }

    //         // Add the decimal value of the digit to the total decimal number, multiplied by the corresponding power of 16.
    //         decimalNumber += digitValue * (1 << (power * 4));
    //         power++;
    //     }

    //     Console.WriteLine("The decimal representation of {0} is: {1}", hexadecimalNumber, decimalNumber);
    

// question 16
// int n;

//         Console.WriteLine("Enter a number: ");
//         n = Convert.ToInt32(Console.ReadLine());

//         // Create an array to store the numbers from 1 to n.
//         int[] numbers = new int[n];
//         for (int i = 0; i < n; i++)
//         {
//             numbers[i] = i + 1;
//         }

//         // Shuffle the array of numbers.
//         for (int i = 0; i < n; i++)
//         {
//             int randomIndex = new Random().Next(i, n);
//             int temp = numbers[i];
//             numbers[i] = numbers[randomIndex];
//             numbers[randomIndex] = temp;
//         }

//         // Print the numbers in the shuffled array.
//         foreach (int number in numbers)
//         {
//             Console.WriteLine(number);
//         }
// question 17
// public class GCDAndLCM
// {
//     public static void Main(string[] args)
//     {
//         int a, b;

//         Console.WriteLine("Enter two numbers: ");
//         a = Convert.ToInt32(Console.ReadLine());
//         b = Convert.ToInt32(Console.ReadLine());

//         // Calculate the GCD of a and b.
//         int gcd = CalculateGCD(a, b);

//         // Calculate the LCM of a and b.
//         int lcm = (a * b) / gcd;

//         Console.WriteLine("The GCD of {0} and {1} is: {2}", a, b, gcd);
//         Console.WriteLine("The LCM of {0} and {1} is: {2}", a, b, lcm);
//     }

//     private static int CalculateGCD(int a, int b)
//     {
//         while (b != 0)
//         {
//             int remainder = a % b;
//             a = b;
//             b = remainder;
//         }

//         return a;
//     }
// }

// question 18

// public class SpiralMatrix
// {
//     public static void Main(string[] args)
//     {
//         int n;

//         Console.WriteLine("Enter the size of the matrix: ");
//         n = Convert.ToInt32(Console.ReadLine());

//         int[,] matrix = new int[n, n];

//         // Initialize the matrix to 0.
//         for (int i = 0; i < n; i++)
//         {
//             for (int j = 0; j < n; j++)
//             {
//                 matrix[i, j] = 0;
//             }
//         }

//         // Fill the matrix in a spiral pattern.
//         int k = 0;
//         int l = 0;
//         int m = n - 1;
//         int p = n - 1;
//         int count = 1;

//         while (count <= n * n)
//         {
//             // Right direction.
//             for (int i = k; i <= p; i++)
//             {
//                 matrix[k, i] = count++;
//             }

//             // Down direction.
//             for (int i = k + 1; i <= m; i++)
//             {
//                 matrix[i, p] = count++;
//             }

//             // Left direction.
//             for (int i = p - 1; i >= l; i--)
//             {
//                 matrix[m, i] = count++;
//             }

//             // Up direction.
//             for (int i = m - 1; i > k; i--)
//             {
//                 matrix[i, l] = count++;
//             }

//             k++;
//             l++;
//             m--;
//             p--;
//         }

//         // Print the matrix to the console.
//         for (int i = 0; i < n; i++)
//         {
//             for (int j = 0; j < n; j++)
//             {
//                 Console.Write(matrix[i, j] + " ");
//             }
//             Console.WriteLine();
//         }
//     }
// }







    



