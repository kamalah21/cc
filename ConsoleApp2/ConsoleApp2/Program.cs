// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
#region #1
//int number   = 10;
//int[] numbers = { 100, 200, 300, 400 };

//for (int i = 0; i < numbers.Length; i++)
//{
//    Console.WriteLine(numbers[i]);  
//}
#endregion
#region #2
//int[] numbers = { 100, 200, 300 };
//int sum = 0;
//for (int i = 0; i < numbers.Length; i++)
//{
//    sum += numbers[i];
//};
//Console.WriteLine(sum);
#endregion
#region # 3 
//int[] numbers = { 100, 200, 300 };
//for (int i = numbers.Length - 1; i >= 0; i--)
//{
//    Console.WriteLine(numbers[i]);
//}
#endregion
#region # 4
//int[] numbers = { 100, 200, 300 };
//for (int i = 0; i < numbers.Length / 2; i++)
//{
//    int temp = numbers[i];
//    numbers[i] = numbers[numbers.Length - i - 1];
//    numbers[numbers.Length - i - 1] = temp;
//}
//for (int i = 0; i < numbers.Length; i++)
//{
//    Console.WriteLine(numbers[i]);
//}
#endregion
#region # 5 

//int max = 0;
//int[] numbers = { 100, 200, 300 };
//for (int i = 0; i < numbers.Length; i++)
//{
//        if (numbers[i] > max)
//          max = numbers[i];
//}
//Console.WriteLine(max);
#endregion
#region # 6
//int count = 0;
//int[] numbers = { 100, 200, 300 };
//for (int i = 0; i < numbers.Length; i++)
//{
//    count++;
//}
//Console.WriteLine(count);
#endregion
#region # 7
//selection Sort

//int[] arr = { 1, 2, 3, 4,34,1,765,12,76, 5, 6 };
//int n = arr.Length; 
//Console.WriteLine("Selection sort");
//Console.Write("Initial array is: ");
//for (int i = 0; i < n; i++)
//{
//    Console.Write(arr[i] + " ");
//}
//int temp, smallest;
//for (int i = 0; i < n - 1; i++)
//{
//    smallest = i;
//    for (int j = i + 1; j < n; j++)
//    {
//        if (arr[j] < arr[smallest])
//        {
//            smallest = j;
//        }
//    }
//    temp = arr[smallest];
//    arr[smallest] = arr[i];
//    arr[i] = temp;
//}
//Console.WriteLine();
//Console.Write("Sorted array is: ");
//for (int i = 0; i < n; i++)
//{
//    Console.Write(arr[i] + " ");
//}
#endregion
#region # 8
//int count = 0 ;
//int[] numbers = { 100, 200, 300, 400 };
//for (int i = 0; i < numbers.Length; i++)
//{
//    if (numbers[i] == 0)
//    {
//        count++;
//    }
//}
//Console.WriteLine(count);
#endregion
#region # 9
//int count = 0;
//int[] number = { 1, 2, 3, 4, 5, 7, 9 };
//for (int i = 0; i < number.Length; i++)
//{
//    if (number[i] < 0)
//    {
//        count++;
//    }

//}
//Console.WriteLine(count);
#endregion
#region # 10
//int sum = 0;
//int[] number = { 1, 2, 3, 4, 5, 6, 7 };
//for (int i = 0; i < number.Length; i++)
//{
//    if (number[i] > 0)
//    {
//        sum+= number[i];
//    }
//}
//Console.WriteLine(sum);
#endregion
#region # 11
//int[] number = { 1, 2, 4, 5 };
//for (int i = 0; i <number.Length; i++)
//{
//    Console.WriteLine(number[i] * number[i]);
//}
#endregion
#region # 12
//int[] arr = { 56, 1, 99, 67, 89, 23, 44, 12, 78, 34 };
//int n = arr.Length; ;

//int  smallest;
//for (int i = 0; i < n - 1; i++)
//{
//    smallest = i;
//    for (int j = i + 1; j < n; j++)
//    {
//        if (arr[j] < arr[smallest])
//        {
//            smallest = j;
//        }
//    }
//    int temp = arr[smallest];
//    arr[smallest] = arr[i];
//    arr[i] = temp;
//}
//for (int i = 0; i < arr.Length / 2; i++)
//{
//    int temp = arr[i];
//    arr[i] = arr[arr.Length - i - 1];
//    arr[arr.Length - i - 1] = temp;
//}
//for (int i = 0; i < arr.Length; i++)
//{
//    Console.WriteLine(arr[i]);
//}
#endregion