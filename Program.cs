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


// 2 .  CardNumber

// public class CRUD
// {
//     public static void AddList(List<string> list)
//     {
//         list.Add("9860777711115555");
//         list.Add("9860888822223333");
//         list.Add("9860555511116666");
//         list.Add("9860030106244491");
//     }
//
//     public static List<string> list = new List<string>();
//
//     public static void Main(string[] args)
//     {
//         AddList(list);
//         Display(list);
//         
//     }
//
//     public static void Display(List<string> list)
//     {
//         while (true)
//         {
//             Console.WriteLine("1.Creat  card number.");
//             Console.WriteLine("2.Read card number.");
//             Console.WriteLine("3.Update card number.");
//             Console.WriteLine("4.Delete card number.");
//             var digit = int.Parse(Console.ReadLine());
//             if (digit == 1)
//             {
//                 CreateCardNumber(list);
//             }
//             else if (digit == 2)
//             {
//                 ReadCardNumber(list);
//             }
//             else if (digit == 3)
//             {
//                 UpdateCardNumber(list);
//             }
//             else if (digit == 4)
//             {
//                 DeleteCardNumber(list);
//             }
//             else
//             {
//                 Console.WriteLine("Invalid input");
//             }
//
//             Console.ReadKey();
//             Console.Clear();
//         }
//     }
//
//     public static void CreateCardNumber(List<string> list)
//     {
//         Console.Write("Enter card number: ");
//         var cardNumber = Console.ReadLine();
//         var check = ChekCardNumber(cardNumber);
//         if (check == false)
//         {
//             Console.WriteLine("Invalid card number");
//         }
//         else
//         {
//             list.Add(cardNumber);
//             Console.WriteLine("Card number created");
//         }
//     }
//
//     public static void ReadCardNumber(List<string> list)
//     {
//         Console.WriteLine("Your card number: ");
//         foreach (var element in list)
//         {
//             Console.WriteLine(element);
//         }
//     }
//
//     public static void UpdateCardNumber(List<string> list)
//     {
//         Console.Write("Enter old card number: ");
//         var cardNumber = Console.ReadLine();
//         var contain = list.Contains(cardNumber);
//         if (contain==false)
//         {
//             Console.WriteLine("Card number not found");
//         }
//         else if (list.Contains(cardNumber))
//         {
//             var index = list.IndexOf(cardNumber);
//             list.Remove(cardNumber);
//             Console.Write("Enter new card number: ");
//             var newCardNumber = Console.ReadLine();
//             var check = ChekCardNumber(newCardNumber);
//             if (check == false)
//             {
//                 Console.WriteLine("Invalid card number");
//             }
//             else
//             {
//                 list.Insert(index, newCardNumber);
//                 Console.WriteLine("Card number updated");   
//             }
//         }
//     }
//
//     public static void DeleteCardNumber(List<string> list)
//     {
//         Console.Write("Enter delete card number: ");
//         var cardNumber = Console.ReadLine();
//         var check = ChekCardNumber(cardNumber);
//         var booll = list.Contains(cardNumber);
//         if (check == false )
//         {
//             Console.WriteLine("Invalid card number");
//         }
//         else if (booll == false)
//         {
//             Console.WriteLine("Card number not found");
//         }
//         else
//         {
//             list.Remove(cardNumber);
//             Console.WriteLine("Card number deleted");
//         }
//         
//     }
//
//     public static bool ChekCardNumber(string cardNumber)
//     {
//         var booll = false;
//         if (cardNumber.Length == 16 && cardNumber[0] == '9' && cardNumber[1] == '8' && cardNumber[2] == '6' &&
//             cardNumber[3] == '0')
//         {
//             booll = true;
//         }
//         else
//         {
//             return booll;
//         }
//
//         return booll;
//     }
// }

// 3. CarNumber.

// public class CRUD
// {
//     public static List<string> list = new List<string>();
//
//     public static void AddList(List<string> list)
//     {
//         list.Add("A001AA");
//         list.Add("A100AA");
//         list.Add("A111AA");
//         list.Add("777ZZZ");
//         list.Add("007XXX");
//         list.Add("X023XX");
//         list.Add("888OOO");
//     }
//
//     public static void Main(string[] args)
//     {
//         AddList(list);
//         Display(list);
//     }
//
//     public static void Display(List<string> list)
//     {
//         while (true)
//         {
//             Console.WriteLine("1.Creat  car number.");
//             Console.WriteLine("2.Read car number.");
//             Console.WriteLine("3.Update car number.");
//             Console.WriteLine("4.Delete car number.");
//             var digit = int.Parse(Console.ReadLine());
//             if (digit == 1)
//             {
//                 CreateCarNumber(list);
//             }
//             else if (digit == 2)
//             {
//                 ReadCarNumber(list);
//             }
//             else if (digit == 3)
//             {
//                 UpdateCarNumber(list);
//             }
//             else if (digit == 4)
//             {
//                 DeleteCarNumber(list);
//             }
//             else
//             {
//                 Console.WriteLine("Invalid input");
//             }
//
//             Console.ReadKey();
//             Console.Clear();
//         }
//     }
//
//     public static void CreateCarNumber(List<string> list)
//     {
//         Console.Write("Enter card number: ");
//         var carNumberConsole = Console.ReadLine();
//         var carNumber = carNumberConsole.ToUpper();
//         var check = ChekCarNumber(carNumber);
//         if (check == false)
//         {
//             Console.WriteLine("Invalid card number");
//         }
//         else
//         {
//             list.Add(carNumber);
//             Console.WriteLine("Card number created");
//         }
//     }
//
//     public static void ReadCarNumber(List<string> list)
//     {
//         Console.WriteLine("Your car number: ");
//         foreach (var element in list)
//         {
//             Console.WriteLine(element);
//         }
//     }
//
//     public static void UpdateCarNumber(List<string> list)
//     {
//         Console.Write("Enter old car number: ");
//         var carNumberConsole = Console.ReadLine();
//         var carNumber = carNumberConsole.ToUpper();
//         var contain = list.Contains(carNumber);
//         if (contain == false)
//         {
//             Console.WriteLine("Car number not found");
//         }
//         else if (list.Contains(carNumber))
//         {
//             var index = list.IndexOf(carNumber);
//             list.Remove(carNumber);
//             Console.Write("Enter new car number: ");
//             var carNumberConsole2 = Console.ReadLine();
//             var newCarNumber = carNumberConsole2.ToUpper();
//             var check = ChekCarNumber(newCarNumber);
//             if (check == false)
//             {
//                 Console.WriteLine("Invalid car number");
//             }
//             else
//             {
//                 list.Insert(index, newCarNumber);
//                 Console.WriteLine("Car number updated");
//             }
//         }
//     }
//
//     public static void DeleteCarNumber(List<string> list)
//     {
//         Console.Write("Enter delete car number: ");
//         var carNumberConsole = Console.ReadLine();
//         var carNumber = carNumberConsole.ToUpper();
//         var check = ChekCarNumber(carNumber);
//         var booll = list.Contains(carNumber);
//         if (check == false)
//         {
//             Console.WriteLine("Invalid car number");
//         }
//         else if (booll == false)
//         {
//             Console.WriteLine("Car number not found");
//         }
//         else
//         {
//             list.Remove(carNumber);
//             Console.WriteLine("Car number deleted");
//         }
//     }
//
//     public static bool ChekCarNumber(string carNumber)
//     {
//         var booll = false;
//         if (carNumber.Length == 6 && char.IsDigit(carNumber[0]) && char.IsDigit(carNumber[1])
//             && char.IsDigit(carNumber[2])
//             && char.IsLetter(carNumber[3]) && char.IsLetter(carNumber[4]) && char.IsLetter(carNumber[5]))
//         {
//             booll = true;
//         }
//         else if (carNumber.Length == 6 && char.IsLetter(carNumber[0]) && char.IsDigit(carNumber[1])
//                  && char.IsDigit(carNumber[2])
//                  && char.IsDigit(carNumber[3]) && char.IsLetter(carNumber[4]) && char.IsLetter(carNumber[5]))
//         {
//             booll = true;
//         }
//
//         return booll;
//     }
// }