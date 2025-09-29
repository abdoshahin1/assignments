using System;

namespace assignThree
{
    internal class Program
    {
        /* خاص بالسؤال الاول
        //public static void swap (int a , int b)
        //{
        //    int c = a;
        //    a = b;
        //    b = c;
        //}
        //public static void swap(ref int a, ref int b)
        //{
        //    int c = a;
        //    a = b;
        //    b = c;
        //}
        */
        /*خاص بالسؤال الثاتى
        //public static int sum(ref int[] arr)
        //{
        //    int sum = 0;
        //    arr[0] = 30;
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        sum += arr[i];
        //    }
        //    return sum;
        //}
        */

        /* question three        
         public static void sumsub(int a, int b, out int c, out int d)
        {
            c = a + b;
            d = a - b;
        }
*/
        /*q4
        public static int sumdigitalnum(string num)
        {
            int sum = 0;
            foreach (char i in num)
                sum += i - '0';
            return sum;
        }
 

         */

        /*q5
                 public static string isprime(int x)
        {
            if(x % x== 0 && x % 1== 0 && Math.Sqrt(x) - Math.Floor(Math.Sqrt(x)) != 0)
                return "number is prime";
            else
                return "number is not prime";
        }

         */

        /*q6
                 public static string MinMaxArray(int[] arr)
                {
                    int max = arr[0];
                    int min = arr[0];

                    for (int i = 1; i < arr.Length; i++)
                    {
                        if (arr[i] > max)
                            max = arr[i];
                        if (arr[i] < min)
                            min = arr[i];
                    }
                    return $"max number is {max} and min number is {min}";
                }


         */
        /*q7
                 public static string factorial(int n)
                {
                    int sum = 1;
                    for(int i =1; i <= n; i++)
                    {
                        sum *=i;
                    }
                    return $"factorial is {sum}";
                }

         */
        /*q8
                 public static string ChangeChar(string s,char new_letter, int pos)
                {
                    if (s.Length == 0)
                        return "there is not a string";
                    else
                        return s.Substring(0, pos) + new_letter + s.Substring(pos + 1);
                }

         */
        static void Main(string[] args)
        {
            #region q1
            /*
               هنا عمالنا دالة وممررنا ليها مغير من نوع value فا بالتالى لما اتعامل مع المتغيرات جوا الدالة بتعامل مع نسخة منها مش قيمتها الاصل 
            فا عشان كده لما بطبع بعد ما استخدم الدالة النتيجة هى هى متتغيرش عشان اللى اننا عملته انى بعت القيمة كنسجة مش الاصل
                          int a = 2, b = 3;
                          Console.WriteLine(a + "\t" + b);
                          swap (a , b);
                          Console.WriteLine(a + "\t" + b);         
             */
            /*
                                                    هنا انا عملت حاجة مختلفة وانا بمرر المتغيرات وهى انى مررتها بالقيمة الاصلية بتعتها وقبل ما نكمل احب اوضح حاجة مهمة وفى
                                                        ان المتغيرات اللى بعرفها فى الparameter عبارة عن متغيرات جديدة خالص ملهاش علاقة بالمتغيرات اللى بمررها 
                                                                                نرجع تانى لكلمنا بم انى بعت القيمة الاصلية للدالة فا انا كده بقول للمتغيرات اللى فى الparameter روحى شاورى على اماكن المتغيرات اللى مبعوته وغيرى فى القيمة الاصلية 


             int a = 2, b = 3;
             Console.WriteLine(a + "\t" + b);
             swap(ref a, ref b);
             Console.WriteLine(a + "\t" + b);

             */
            #endregion
            #region q2
            /*
             فى الحالة دى لما يكون نوع البيانات اللى هبعتها اصلا مرجعى بس بمرر بطريقة ال value انا هنا بتعامل مع المتغير اللى بمرره مباشرة من غير ما اخد نسخة اة اى حاجة 
            وفى حالة انا بعت بطريقة ال reference هيطبع نفس الناتج وكل حاجة عشان بتعامل مع القيمة الاصلية بس فى اختلاق بسيط
            لو فاكرين فى المثال اللى فات وضحنا ان الparameter انه متغير جديد خالص ملوش دعة بى اللى بمرره 
            بس فى حالة انى بعت نوع البيانات مرجعية انا ببعت العنوان والقيم 
            هتقول ازاى ببعت القيم واحنا قولنا انى البرام متغير جديد هقولك انت بتبعت العنوان صح العنوان بيشاور على القيم الخاصى بالمتغير اللى مررته فا بالتالى اكنى بعت القيم
            فا الرام بيتعامل مع العنوان المتغير اللى مررته بس لو عملتله تعريف هو بيسيب عنوان المتغير القديم ويورح على الجديد بس لما ابعت بطريقة المرجعية هنا انا مش بخلى البرام 
                    يشاور على العنوان المتغير اللى بمرره بس لا ده انا بخليه لما اعمل قيمة جديدة يغير قيمة المتغير اللى بمرره كمان بمعنى ادق انا مش بعمل واحد جديد لا انا اكنى بخلى البرام و المتغير كانهم متغير واحد
           pass by value and pass by reference or value and reference in generaly وده اصلا االاختلاف بين
            
                        int[] arr = { 1, 2, 3, 4, 5 };
                        Console.WriteLine(sum(ref arr));
                        Console.WriteLine(arr[0]);

             */
            #endregion
            #region q3
            //int a = 5, b = 6, c, d;
            //sumsub(a, b, out c, out d);
            //Console.WriteLine(c + "\t" + d);
            #endregion
            #region q4
            //Console.WriteLine("enter the number : ");
            //string? num = Console.ReadLine();
            //Console.WriteLine($"The sum of the digits of the number {num} is {sumdigitalnum(num)}");
            #endregion
            #region q5
            //Console.Write("enter the number : ");
            //int num = int.Parse(Console.ReadLine());
            //Console.WriteLine(isprime(num));
            #endregion
            #region q6
            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Console.WriteLine(MinMaxArray(arr));

            #endregion
            #region q7
            //Console.WriteLine("enter the number : ");
            //int num = int.Parse(Console.ReadLine());
            //Console.WriteLine(factorial(num));
            #endregion
            #region q8
            //Console.Write("enter the string : ");
            //string? sty = Console.ReadLine();
            //Console.Write("enter the letter : ");
            //char letter = char.Parse(Console.ReadLine());
            //Console.Write("enter the position : ");
            //int pos = int.Parse(Console.ReadLine());
            //Console.WriteLine(ChangeChar(sty,letter,pos));
            #endregion
            #region q9
            //Console.WriteLine("enter size of number and numbers: ");
            //int size =int.Parse(Console.ReadLine());
            //int[] numbers = new int[size];
            //int reslut = 0;
            //for (int i = 0; i < size; i++)
            //{
            //    numbers[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < size; i++)
            //{
            //    reslut += numbers[i];
            //}
            //Console.WriteLine($"total number: {reslut}");

            #endregion
            #region q10
            //Console.Write("Enter size of the arrays: ");
            //int n = int.Parse(Console.ReadLine());

            //int[] arr1 = new int[n];
            //int[] arr2 = new int[n];
            //int[] merged = new int[2 * n];

            //Console.WriteLine("Enter elements of first array:");
            //for (int i = 0; i < n; i++)
            //{
            //    arr1[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("Enter elements of second array:");
            //for (int i = 0; i < n; i++)
            //{
            //    arr2[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < n; i++)
            //{
            //    merged[i] = arr1[i];
            //    merged[i + n] = arr2[i];
            //}

            //Array.Sort(merged);
            //for (int i = 0; i < merged.Length; i++)
            //{
            //    Console.Write(merged[i] + " ");
            //}
            //Console.WriteLine();
            #endregion
            #region q11
            //Console.WriteLine("enter size of array");
            //int num = int.Parse(Console.ReadLine());
            //int[] arr = new int[num];
            //Console.WriteLine("enter element to array");
            //for (int i = 0; i < num; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //int count = 0;
            //string counter = "";
            //bool[] visited = new bool[num];
            //for (int i = 0; i < num; i++)
            //{
            //    if (visited[i]) continue;

            //    for (int j = 0; j < num; j++)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            count += 1;
            //            visited[j] = true; 
            //        }
            //    }
            //    counter += count + ","; 
            //    count = 0; 
            //}
            //Console.WriteLine(counter);
            #endregion
            #region q12
            //Console.Write("Enter number of elements in the array: ");
            //int n = int.Parse(Console.ReadLine());

            //int[] arr = new int[n];

            //Console.WriteLine("Enter elements of the array:");
            //for (int i = 0; i < n; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //int max = arr[0];
            //int min = arr[0];

            //for (int i = 1; i < n; i++)
            //{
            //    if (arr[i] > max)
            //        max = arr[i];
            //    if (arr[i] < min)
            //        min = arr[i];
            //}

            //Console.WriteLine($"\nMaximum element: {max}");
            //Console.WriteLine($"Minimum element: {min}");
            #endregion
            #region q13
            //Console.Write("Enter number of elements in the array: ");
            //int n = int.Parse(Console.ReadLine());

            //int[] arr = new int[n];

            //Console.WriteLine("Enter elements of array:");
            //for (int i = 0; i < n; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //if (n < 2)
            //{
            //    Console.WriteLine("Array must contain at least two elements.");
            //    return;
            //}

            //int firstMax = int.MinValue;
            //int secondMax = int.MinValue;

            //for (int i = 0; i < n; i++)
            //{
            //    if (arr[i] > firstMax)
            //    {
            //        secondMax = firstMax;
            //        firstMax = arr[i];
            //    }
            //    else if (arr[i] > secondMax && arr[i] != firstMax)
            //    {
            //        secondMax = arr[i];
            //    }
            //}
            //Console.WriteLine($"The second largest element is: {secondMax}");
            #endregion
            #region q14
            //Console.Write("Enter size of array: ");
            //int n = int.Parse(Console.ReadLine());

            //int[] arr = new int[n];
            //Console.WriteLine("Enter elements of array:");
            //for (int i = 0; i < n; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //int maxDistance = -1;
            //int valueWithMaxDistance = -1;
            //int firstIndex = -1, lastIndex = -1;

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = n - 1; j > i; j--) 
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            int distance = j - i - 1;
            //            if (distance > maxDistance)
            //            {
            //                maxDistance = distance;
            //                valueWithMaxDistance = arr[i];
            //                firstIndex = i;
            //                lastIndex = j;
            //            }
            //            break; 
            //        }
            //    }
            //}
            //Console.WriteLine($"the max distance is {maxDistance}.");
            #endregion
            #region q15
            //Console.WriteLine("enter a string: ");
            //string tst = Console.ReadLine();
            //string [] result = tst.Split(" ");
            //foreach(string s in result.Reverse())
            //    Console.Write(s + " ");

            #endregion
            #region q16
            //Console.Write("Enter number of rows: ");
            //int row = int.Parse(Console.ReadLine());
            //Console.Write("enter number of columns: ");
            //int cols = int.Parse(Console.ReadLine());
            //int[,] arr = new int[row,cols];
            //int[,] arr2= new int[row,cols];
            //for (int i = 0; i < row; i++)
            //{
            //    Console.WriteLine($"enter the values to {i+1} row: ");
            //    for (int j =0; j<cols; j++)
            //    {
            //        arr[i,j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //Console.WriteLine("copy first to second");
            //for (int i = 0; i < row; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        arr2[i, j] = arr[i, j]; 
            //    }
            //}
            //foreach(int i in arr2)
            //    Console.WriteLine($"the values are :{i}");
            #endregion
            #region q17
            //Console.Write("Enter number of elements in the array: ");
            //int n = int.Parse(Console.ReadLine());

            //int[] arr = new int[n];

            //Console.WriteLine("Enter elements of array:");
            //for (int i = 0; i < n; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //foreach (int i in arr.Reverse())
            //    Console.WriteLine(i);
            #endregion

        }
    }
}