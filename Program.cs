// CRUD   1 PhoneNumber

// public class CRUD
// {
//     public static void ListAdd(List<string> numbers)
//     {
//         numbers.Add("+998912345678");
//         numbers.Add("+998919261348");
//         numbers.Add("+998778089900");
//         numbers.Add("+998905553344");
//         numbers.Add("+998943830313");
//         numbers.Add("+998333833909");
//     }
//
//     public static List<string> numbers = new List<string>();
//
//     public static void Main(string[] args)
//     {
//         ListAdd(numbers);
//         Display(numbers);
//     }
//
//     public static void Display(List<string> numbers)
//     {
//         while (true)
//         {
//             Console.WriteLine("1.Create new telephone number: ");
//             Console.WriteLine("2.Read telephone number: ");
//             Console.WriteLine("3.Update telephone number: ");
//             Console.WriteLine("4.Delete telephone number: ");
//             Console.Write("Enter number: " );
//             var digit = int.Parse(Console.ReadLine());
//             if (digit == 1)
//             {
//                 CreateTelephoneNumber(numbers);
//             }
//
//             else if (digit == 2)
//             {
//                 ReadTelephoneNumber(numbers);
//                 
//             }
//
//             else if (digit == 3)
//             {
//                 UpdateTelephoneNumber(numbers);
//                 
//             }
//
//             else if (digit == 4)
//             {
//                 DeleteTelephoneNumber(numbers);
//             }
//             else
//             {
//                 Console.WriteLine("Invalid number");
//             }
//
//             Console.ReadKey();
//             Console.Clear();
//         }
//     }
//
//
//     public static void CreateTelephoneNumber(List<string> numbers)
//     {
//         Console.Write("Enter telephone number: ");
//         var number = (Console.ReadLine());
//         var check = CheckTelephoneNumbers(number);
//         if (check is false)
//         {
//             Console.WriteLine("Invalid number");
//         }
//
//         else if (numbers.Contains(number))
//         {
//             Console.WriteLine("Telephone number already exists");
//         }
//         else
//         {
//             
//             numbers.Add(number);
//             Console.WriteLine("Telephone number created successfully");
//         }
//     }
//
//     public static void ReadTelephoneNumber(List<string> numbers)
//     {
//         foreach (var element in numbers)
//         {
//             Console.WriteLine(element);
//         }
//     }
//
//     public static void UpdateTelephoneNumber(List<string> numbers)
//     {
//         Console.Write("Enter telephone number: ");
//         var number = (Console.ReadLine());
//         var check = CheckTelephoneNumbers(number);
//         if (check is false)
//         {
//             Console.Write("Invalid number");
//         }
//         else
//         {
//             var index = numbers.IndexOf(number);
//             numbers.Remove(number);
//             Console.Write("Enter new telephone number: ");
//             var newNumber = Console.ReadLine();
//             numbers[index] = newNumber;
//             Console.WriteLine("Telephone number updated");
//         }
//     }
//
//
//     public static void DeleteTelephoneNumber(List<string> numbers)
//     {
//         Console.Write("Enter telephone number: ");
//         var number = Console.ReadLine();
//         var check = CheckTelephoneNumbers(number);
//         if (check is false)
//         {
//             Console.WriteLine("Invalid number");
//         }
//         else
//         {
//             numbers.Remove(number);
//             Console.WriteLine("Telephone number deleted");
//         }
//     }
//
//     public static bool CheckTelephoneNumbers(string number)
//     {
//         return (number.Length == 13 && number[0] == '+' && number[1] == '9' && number[2] == '9' && number[3] == '8');
//     }
// }