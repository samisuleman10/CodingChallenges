using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Text;

using System.Linq;

namespace CodingChallengeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            //BinarySearch();
            //FindMinimumElement();
            //FindMaxElement();
            //nextGreatestLetter();
            //SearchFirstAndLastIndex();
            InfiniteArraySearch();
            //ContainsDuplicate();
            //StockBuyAndSellProfit();
            //NumberIsPrime();
            //FindSecondLargestInArray();
            //FactorialPrint();
            //FibonacciPrint();
            //TwoNumbersAddToTargetNumberAndReturnsIndexShifa();
            //TwoNumbersAddToTargetNumberAndReturnsIndex();
            //StringContainsSequenceOfCharacters();
            //VowelsAndConsonantCounter();
            //PalindromeOccurencesString();
            //StringIsAPalindrome();
            //PlainDromeWordRecursive();
            //StringConversion();
            //StringAsArray();
            //EscapeString();
            //AppendingStrings();
            //InterpolationAndLiteral();
            //StringBuilderDemo();
            //WorkingWithArrays();
            //PadAndTrim();
            //SearchingStrings();
            //OrderingStrings();
            //TestingEquality();
            //GettingASubstring();
            //ReplacingText();
            //InsertingText();
            //RemovingText();
            //TemperatureClosetToZero();
            //FindClosestNumberToZero();
        }

        static void BinarySearch()
        {
            int[] arr = { -18, -12, -4, 0, 2, 3, 4, 15, 16, 18, 22, 45, 89 };
            int target = 22;

            int start = 0;
            int end = arr.Length - 1;

            while (start <= end)
            {
                // find the middle element
                // int mid = (start + end) / 2; // might be possible that (start + end) exceeds the range of int in java
                int mid = start + (end - start) / 2; // (end - start) will give the new length
                                                     // (/2) Now divide that length by half and
                                                     // add it into start to get mid 
                if (target < arr[mid])
                {
                    end = mid - 1;
                }
                else if (target > arr[mid])
                {
                    start = mid + 1;
                }
                else
                {
                    Console.WriteLine("Found at index " + mid);
                    return;
                }
            }

            Console.WriteLine("Target not found");

        }

        // Floor
        static void FindMinimumElement()
        {
            int[] arr = { -18, -12, -4, 0, 2, 3, 4, 15, 16, 18, 22, 45, 89 };
            int target = -19;

            int start = 0;
            int end = arr.Length - 1;

            while (start <= end)
            {
                // find the middle element
                // int mid = (start + end) / 2; // might be possible that (start + end) exceeds the range of int in java
                int mid = start + (end - start) / 2; // (end - start) will give the new length
                                                     // (/2) Now divide that length by half and
                                                     // add it into start to get mid 
                if (target < arr[mid])
                {
                    end = mid - 1;
                }
                else if (target > arr[mid])
                {
                    start = mid + 1;
                }
                else
                {
                    Console.WriteLine("Found at index " + mid);
                    return;
                }
            }

            Console.WriteLine("Target found "+ end);

        }

        //Ceiling
        static void FindMaxElement()
        {
            int[] arr = { -18, -12, -4, 0, 2, 3, 4, 15, 16, 18, 22, 45, 89 };
            int target = 90;

            int start = 0;
            int end = arr.Length - 1;

            if (target > arr[arr.Length - 1])
            {
                Console.WriteLine("Not Found " + -1);
                return;
            }

            while (start <= end)
            {
                // find the middle element
                // int mid = (start + end) / 2; // might be possible that (start + end) exceeds the range of int in java
                int mid = start + (end - start) / 2; // (end - start) will give the new length
                                                     // (/2) Now divide that length by half and
                                                     // add it into start to get mid 
                if (target < arr[mid])
                {
                    end = mid - 1;
                }
                else if (target > arr[mid])
                {
                    start = mid + 1;
                }
                else
                {
                    Console.WriteLine("Found at index " + mid);
                    return;
                }
            }

            Console.WriteLine("Target found " + start);
        }

        // ceiling
        static void nextGreatestLetter()
        {
            char[] arr = { 'a', 'v', 'z'};
            char target = 'z';

            int start = 0;
            int end = arr.Length - 1;

            while (start <= end)
            {
                // find the middle element
                // int mid = (start + end) / 2; // might be possible that (start + end) exceeds the range of int in java
                int mid = start + (end - start) / 2; // (end - start) will give the new length
                                                     // (/2) Now divide that length by half and
                                                     // add it into start to get mid 
                if (target < arr[mid])
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                } 
            }
            Console.WriteLine("Target found " + arr[start % arr.Length]); // when condtion fails wrap around.
                                                                          // modulus will only work when start = arr.length
        }

        static void SearchFirstAndLastIndex()
        {
            // Search for the lower half and then search for the upper half
            int[] answer = {-1, -1};

            int[] nums = {5,7,7,8,8,10};
            int target = 7;

            answer[0] = BinarySearchFirstLast(nums, target, true);
            answer[1] = BinarySearchFirstLast(nums, target, false);

            Array.ForEach(answer, Console.WriteLine);
        }

        static int BinarySearchFirstLast(int[] nums, int target, bool isFirst)
        {
            int answer = -1;

            int start = 0;
            int end = nums.Length - 1;

            while (start <= end)
            {
                int mid = start + (end - start) / 2;

                if (target < nums[mid])
                {
                    end = mid - 1;
                }
                else if (target > nums[mid])
                {
                    start = mid + 1;
                }
                else
                {
                    // This is our possible answer
                    answer = mid;
                    if (isFirst)
                    {
                        end = mid - 1;
                    }
                    else
                    {
                        start = mid + 1;
                    }
                }
            }
            return answer;
        }

        static void InfiniteArraySearch()
        {
            // suppose arr is infinite. We will process it in chunks
            int[] arr = { -18, -12, -4, 0, 2, 3, 4, 15, 16, 18, 22, 45, 89, 90 };
            int target = 89;

            int start = 0;
            int end = 1;

            // doubling the window size and increasing the chunk
            while (target > arr[end])
            {
                int temp = end + 1;
                // double the chunk size value and adding one because index starts with zero. for length add 1
                end = end + (end - start + 1) * 2;
                start = temp;
            }

            while (start <= end)
            {
                // find the middle element
                // int mid = (start + end) / 2; // might be possible that (start + end) exceeds the range of int in java
                int mid = start + (end - start) / 2; // (end - start) will give the new length
                                                     // (/2) Now divide that length by half and
                                                     // add it into start to get mid 
                                                     // here we are finding the index so no -1
                if (target < arr[mid])
                {
                    end = mid - 1;
                }
                else if (target > arr[mid])
                {
                    start = mid + 1;
                }
                else
                {
                    Console.WriteLine("Found at index " + mid);
                    return;
                }
            }

            Console.WriteLine("Not found index -1");
        }
        static void ContainsDuplicate()
        {
            int []nums = { 1, 2, 3, 1 }; // true
            //int[] nums = { 1, 2, 3}; // false
            int[] distinct = nums.Distinct().ToArray();

            if (nums.Length == distinct.Length) Console.WriteLine("False");
            else Console.WriteLine("True");
        }
        
        static void StockBuyAndSellProfit()
        {
            int[] prices = {7, 1, 5, 3, 6, 4}; // 5
            //int[] prices = { 7, 6, 4, 3, 1 }; // 0

            int minValue = prices.Min();
            int minIndex = Array.IndexOf(prices, minValue);

            int maxProfit = 0;

            for (int i = minIndex; i < prices.Length; i++)
            {
                if (maxProfit < prices[i] - minValue) maxProfit = prices[i] - minValue;
            }
            Console.Write("Profit  " + maxProfit);
        }

        static void NumberIsPrime()
        {
            int number = 1;
            bool IsPrime = true;
            if(number < 2) IsPrime = false;

            //Numbers start repeating 
            for (int i = 2; i < Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    IsPrime = false;
                    break;
                }
            }
            if (IsPrime)
            {
                Console.Write("Number is Prime.");
            }
            else
            {
                Console.Write("Number is not Prime.");
            }

        }
        static void FindSecondLargestInArray()
        {
            int[] array = {1,45,4563,345,321,2,3};
            int length = array.Length;
            
            int i, first, second;
            //There should be atleast two elements in the array
            if (length < 2)
            {
                Console.WriteLine(" Invalid Input ");
                return;
            }

            // Starting point for largest and second largest values
            first = second = int.MinValue;

            //Go through the array and update the largest and second largest number
            for (i = 0; i < length; i++)
            {
                if (array[i] > first)
                {
                    second = first;
                    first = array[i];
                }
            }

            if (second == int.MinValue)
            {
                Console.Write("There is no second largest element");
            }
            else
            {
                Console.Write("Second largest number is "+ second);
            }

        }


        static void FactorialPrint()
        {
            //f(n) = n * (n-1) * (n-2) ....
            //f(n) = n * (n-1)!
            int factorial = 3;
            Console.WriteLine(FactorialRecursion(factorial));
        }

        static int FactorialRecursion(int n)
        {
            if (n == 0) return 1; // this is the base condition
            return n * FactorialRecursion ((n - 1));
        }

        static void FibonacciPrint()
        {
            
            int fibonacciLength = 5;
            // for printing series we loop through
            for (int i = 0; i < fibonacciLength; i++)
            {
                Console.Write("{0} ", FibonacciRecursionPrint(i));
            }
        }
        //F(n) = F(n-1) + F(n-2)
        static int FibonacciRecursionPrint(int n)
        {
            if (n == 0 || n == 1) return n; // this is the base condition
            return FibonacciRecursionPrint(n-1) + FibonacciRecursionPrint(n-2);        
        }

        static void TwoNumbersAddToTargetNumberAndReturnsIndexShifa()
        {
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;
            int[] answer = { -1, -1 };

            for (int i = 0; i < nums.Length; i++)
            {
                int difference = target - nums[i];

                // Working with Key becuse we are able to acces index.
                int index = Array.IndexOf(nums, difference);
                
                if(index!=-1)
                {
                    answer = new int[] { index, i };
                    break;
                }
 
            }

            Array.ForEach(answer, Console.WriteLine);
        }

        private static void TwoNumbersAddToTargetNumberAndReturnsIndex()
        {
            int[] nums = { 1, 3, 4, 5 };
            int target = 6;
            int[] answer = { -1 , -1 };

            Dictionary<int, int> tableHash = new();

            for(int i = 0; i<nums.Length; i++)
            {
                int difference = target - nums[i];

                // Working with Key becuse we are able to acces index.
                if (tableHash.ContainsKey(difference))
                {
                    answer = new int [] {tableHash[difference], i} ;
                    break;
                }
                else
                {
                    tableHash[nums[i]] = i;
                }
            }

            Array.ForEach(answer, Console.WriteLine);
        }

        private static void StringContainsSequenceOfCharacters()
        {
            string randomString = "asfdfkjnskldfdf";
            string target = "ns";

            Console.WriteLine(randomString.Contains(target));
            Console.WriteLine(randomString[randomString.IndexOf(target)-1]);
        }

        // barbarabar has 7 (b, a, r, barab, a, r)
        private static void PalindromeOccurencesString()
        {
            string textPalindrome = "barbarabar";
            
            string answer = new string (textPalindrome.Distinct().ToArray());
        }

        private static void StringIsAPalindrome()
        {
            //Reverse word is same as normal word
            string plaindromWord = new string(Console.ReadLine());
            plaindromWord = plaindromWord.ToLower();

            //Removes special characters.
            StringBuilder sb = new StringBuilder();
            foreach (char c in plaindromWord)
            {
                if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || c == '.' || c == '_')
                {
                    sb.Append(c);  
                }
            }
            plaindromWord = sb.ToString();

            //Reverses the word
            char[] charArray = plaindromWord.ToCharArray();            
            Array.Reverse(charArray);
            string reversedPlaindrom = new string (charArray);

            if (reversedPlaindrom == plaindromWord)
            {
                Console.WriteLine("is plaindrome");
            }

            Console.WriteLine(charArray);
            Console.WriteLine(plaindromWord);
        }

        public static void PlainDromeWordRecursive()
        {
            string plaindromWord = new string(Console.ReadLine());
            int n = plaindromWord.Length;

            // An empty string is considered
            // as palindrome
            if (n == 0)
            {
                Console.WriteLine("is plaindrome");
            }
            
            if (isPalRec(plaindromWord, 0, n-1))
                Console.Write("Yes");
            else
                Console.Write("No");

        }

        private static void VowelsAndConsonantCounter()
        {
            int vCount = 0, cCount = 0;
            string str = "This is a really simple sentence";
            str = str.ToLower();

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u')
                {
                    vCount++;
                }
                //Checks whether a character is a consonant. other than vowel is a consonant
                else if (str[i] >= 'a' && str[i] <= 'z')
                {
                    cCount++;
                }
            }
            Console.WriteLine("Number of vowels : " + vCount);
            Console.WriteLine("Number of consonant : " + cCount);
        }

        // A recursive function that
        // check a str(s..e)
        // is palindrome or not.
        static bool isPalRec(String str,
                             int s,
                             int e)
        {

            // If there is only one character
            if (s == e)
                return true;

            // If first and last character
            // do not match
            if ((str[s]) != (str[e]))
                return false;

            // If there are more than two
            // characters, check if middle
            // substring is also
            // palindrome or not.
            if (s < e + 1)
                return isPalRec(str, s + 1,
                                e - 1);
            return true;
        }

        private static void StringConversion()
        {
            string testString = "tHis iS tHe FBI Calling!";
            TextInfo currentTextInfo = CultureInfo.CurrentCulture.TextInfo;
            TextInfo englishTextInfo = new CultureInfo("en-US", false).TextInfo;
            string result;

            result = testString.ToLower();
            Console.WriteLine(result);

            result = testString.ToUpper();
            Console.WriteLine(result);

            result = englishTextInfo.ToTitleCase(testString);
            Console.WriteLine(result);
        }

        private static void StringAsArray()
        {
            string testString = "Timothy";

            for (int i = 0; i < testString.Length; i++)
            {
                Console.WriteLine(testString[i]);
            }
        }

        private static void EscapeString()
        {
            string results;

            results = "This is my \"test\" solution.";
            Console.WriteLine(results);

            results = "C:\\Demo\\Test.txt";
            Console.WriteLine(results);

            results = @"C:\Demo\Test.txt";
            Console.WriteLine(results);
        }

        private static void AppendingStrings()
        {
            string firstName = "Tim";
            string lastName = "Corey";
            string results;

            results = firstName + ", my name is " + firstName + " " + lastName;
            Console.WriteLine(results);

            results = string.Format("{0}, my name is {0} {1}", firstName, lastName);
            Console.WriteLine("{0}, my name is {0} {1}", firstName, lastName);
            Console.WriteLine(results);

            results = $"{firstName}, my name is {firstName} {lastName}";
            Console.WriteLine(results);
        }

        private static void InterpolationAndLiteral()
        {
            string testString = "Tim Corey";
            //string results = $@"C:\Demo\{testString}\{"\""}Test{"\""}.txt";
            string results = $@"C:\Demo\{testString}\Test\.txt";
            Console.WriteLine(results);
        }

        private static void StringBuilderDemo()
        {
            Stopwatch regularStopwatch = new Stopwatch();
            regularStopwatch.Start();

            string test = "";

            for (int i = 0; i < 100000; i++)
            {
                test += i;
            }

            regularStopwatch.Stop();
            Console.WriteLine($"Regular Stopwatch: { regularStopwatch.ElapsedMilliseconds }ms");

            Stopwatch builderStopwatch = new Stopwatch();
            builderStopwatch.Start();

            StringBuilder sb = new();

            for (int i = 0; i < 100000; i++)
            {
                sb.Append(i);
            }
            
            builderStopwatch.Stop();
            Console.WriteLine($"String Builder Stopwatch: { builderStopwatch.ElapsedMilliseconds }ms");
        }

        private static void WorkingWithArrays()
        {
            int[] ages = new int[] { 6, 7, 8, 3, 5 };
            string results;

            results = String.Concat(ages);
            Console.WriteLine(results);

            results = String.Join(",", ages);
            Console.WriteLine(results);

            Console.WriteLine();

            string testString = "Jon,Tim,Mary,Sue,Bob,Jane";
            string[] resultsArray = testString.Split(',');

            Array.ForEach(resultsArray, x => Console.WriteLine(x));

            Console.WriteLine();

            testString = "Jon, Tim, Mary, Sue, Bob, Jane";
            resultsArray = testString.Split(", ");


            Array.ForEach(resultsArray, x => Console.WriteLine(x));

            Action<string> greet = inputAction => Console.WriteLine(inputAction);
            Array.ForEach(resultsArray, greet);
        }

        private static void PadAndTrim()
        {
            string testString = "     Hello World      ";
            string results;

            results = testString.TrimStart();
            Console.WriteLine($"'{results}'");

            results = testString.TrimEnd();
            Console.WriteLine($"'{results}'");

            results = testString.Trim();
            Console.WriteLine($"'{results}'");

            testString = "1.15";

            results = testString.PadLeft(10, '0');
            Console.WriteLine(results);

            results = testString.PadRight(10, '0');
            Console.WriteLine(results);
        }

        private static void SearchingStrings()
        {
            //string testString = "Thisisatestofthesearch. Let's see how its testing works out.";
            string testString = "Thisisatestofthesearch";
            bool resultsBoolean;
            int resultsInt;

           /* resultsBoolean = testString.StartsWith("This is");
            Console.WriteLine($"Starts with \"This is\": {resultsBoolean}");

            resultsBoolean = testString.StartsWith("ThIs is");
            Console.WriteLine($"Starts with \"ThIs is\": {resultsBoolean}");

            resultsBoolean = testString.EndsWith("works out.");
            Console.WriteLine($"Ends with \"works out.\": {resultsBoolean}");

            resultsBoolean = testString.EndsWith("work out.");
            Console.WriteLine($"Ends with \"work out.\": {resultsBoolean}");

            resultsBoolean = testString.Contains("test");
            Console.WriteLine($"Contains \"test\": {resultsBoolean}");

            resultsBoolean = testString.Contains("tests");
            Console.WriteLine($"Contains \"tests\": {resultsBoolean}");
           */
           
            resultsInt = testString.IndexOf("test");
            Console.WriteLine($"Index of \"test\": {resultsInt}");
            /*
            resultsInt = testString.IndexOf("test", 11);
            Console.WriteLine($"Index of \"test\" after character 10: {resultsInt}");

            resultsInt = testString.IndexOf("test", 49);
            Console.WriteLine($"Index of \"test\" after character 48: {resultsInt}");

            resultsInt = testString.LastIndexOf("test");
            Console.WriteLine($"Last Index of \"test\": {resultsInt}");

            resultsInt = testString.LastIndexOf("test", 48);
            Console.WriteLine($"Last Index of \"test\" before character 48: {resultsInt}");

            resultsInt = testString.LastIndexOf("test", 10);
            Console.WriteLine($"Last Index of \"test\" before character 10: {resultsInt}");
        */
        }

        private static void OrderingStrings()
        {
            CompareToHelper("Mary", "Bob");
            CompareToHelper("Mary", null);
            CompareToHelper("Adam", "Bob");
            CompareToHelper("Bob", "Bob");
            CompareToHelper("Bob", "Bobby");

            Console.WriteLine();

            CompareHelper("Mary", "Bob");
            CompareHelper("Mary", null);
            CompareHelper(null, "Bob");
            CompareHelper("Adam", "Bob");
            CompareHelper("Bob", "Bob");
            CompareHelper("Bob", "Bobby");
            CompareHelper(null, null);
        }

        private static void CompareToHelper(string testA, string? testB)
        {
            int resultsInt = testA.CompareTo(testB);
            switch (resultsInt)
            {
                case > 0:
                    Console.WriteLine($"CompareTo: { testB ?? "null" } comes before { testA }");
                    break;
                case < 0:
                    Console.WriteLine($"CompareTo: { testA } comes before { testB }");
                    break;
                case 0:
                    Console.WriteLine($"CompareTo: { testA } is the same as { testB }");
                    break;
            }
        }

        private static void CompareHelper(string? testA, string? testB)
        {
            int resultsInt = String.Compare(testA, testB);

            switch (resultsInt)
            {
                case > 0:
                    Console.WriteLine($"Compare: { testB ?? "null" } comes before { testA }");
                    break;
                case < 0:
                    Console.WriteLine($"Compare: { testA ?? "null" } comes before { testB }");
                    break;
                case 0:
                    Console.WriteLine($"Compare: { testA ?? "null" } is the same as { testB ?? "null" }");
                    break;
            }
        }

        private static void TestingEquality()
        {
            EqualityHelper("Bob", "Mary");
            EqualityHelper(null, "");
            EqualityHelper("", " ");
            EqualityHelper("Bob", "bob");
        }

        private static void EqualityHelper(string? testA, string? testB)
        {
            bool resultsBoolean;

            resultsBoolean = String.Equals(testA, testB);
            if (resultsBoolean)
            {
                Console.WriteLine($"Equals: '{ testA ?? "null" }' equals '{ testB ?? "null" }'");
            }
            else
            {
                Console.WriteLine($"Equals: '{ testA ?? "null" }' does not equal '{ testB ?? "null" }'");
            }

            resultsBoolean = String.Equals(testA, testB, StringComparison.InvariantCultureIgnoreCase);
            if (resultsBoolean)
            {
                Console.WriteLine($"Equals (ignore case): '{ testA ?? "null" }' equals '{ testB ?? "null" }'");
            }
            else
            {
                Console.WriteLine($"Equals (ignore case): '{ testA ?? "null" }' does not equal '{ testB ?? "null" }'");
            }

            resultsBoolean = testA == testB;
            if (resultsBoolean)
            {
                Console.WriteLine($"==: '{ testA ?? "null" }' equals '{ testB ?? "null" }'");
            }
            else
            {
                Console.WriteLine($"==: '{ testA ?? "null" }' does not equal '{ testB ?? "null" }'");
            }

            Console.WriteLine();
        }

        private static void GettingASubstring()
        {
            string testString = "This is a test of substring. Let's see how its testing works out.";
            string results;

            results = testString.Substring(5);
            Console.WriteLine(results);

            results = testString.Substring(5, 4);
            Console.WriteLine(results);
        }

        private static void ReplacingText()
        {
            string testString = "This is a test of replace. Let's see how its testing Works out for test.";
            string results;

            results = testString.Replace("test", "trial");
            Console.WriteLine(results);

            results = testString.Replace(" test ", " trial ");
            Console.WriteLine(results);

            results = testString.Replace("works", "makes", StringComparison.InvariantCultureIgnoreCase);
            Console.WriteLine(results);
        }

        private static void InsertingText()
        {
            string testString = "This is a test of insert. Let's see how its testing Works out for test.";
            string results;

            results = testString.Insert(5, "(test) ");
            Console.WriteLine(results);
        }

        private static void RemovingText()
        {
            string testString = "This is a test of remove. Let's see how its testing Works out for test.";
            string results;

            results = testString.Remove(25);
            Console.WriteLine(results);

            results = testString.Remove(14, 10);
            Console.WriteLine(results);
        }

        private static void TemperatureClosetToZero()
        {
            int N = int.Parse(Console.ReadLine());

            int min = 0;
            int result= 0;
            int finalResult = 0;

            if (N != 0)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                for (int i = 0; i < N; i++)
                {
                    int t = int.Parse(inputs[i]);

                    // take difference from 1 of input
                    min = t - 1;

                    if (i == 0)
                    {
                        result = min;
                        finalResult = t;
                    }
                    if (Math.Abs(result) > Math.Abs(min))
                    {
                        result = min;
                        finalResult = t;
                    }
                }
            }
            else
            {
                finalResult = N;
            }

            // Write an answer using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");

            Console.WriteLine(finalResult);

        }

        private static void FindClosestNumberToZero()
        {
            int N = int.Parse(Console.ReadLine());

            if (N == 0)
            {
                Console.WriteLine(0);
                return;
            }
            
            string[] inputs = Console.ReadLine().Split(' ');
            int[] intArray = Array.ConvertAll(inputs, s => int.Parse(s));
            int closest = 0;

            for (int i = 0; i < N; i++)
            {
                // If it is the first loop
                if (closest == 0)
                {
                    closest = intArray[i];
                }
                //  All conditions are applied on the positive values.
                //  We check if the incomming value is less than closest we update closest.
                else if (intArray[i] > 0 && intArray[i] <= Math.Abs(closest))
                {
                    closest = intArray[i];
                }
                // Only less than sign in closest. To avoid equal negative number
                else if (intArray[i] < 0 &&  - intArray[i] < Math.Abs(closest))
                {
                    closest = intArray[i];
                }
            }
            Console.WriteLine(closest);
        }
    }
}
