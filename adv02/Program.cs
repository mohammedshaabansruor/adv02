using System.Collections;

namespace adv02
{
    internal class Program
    {
        #region Q01
        public static int IsGreater(List<int> arr, int num)
        {
            int count = 0;
            foreach (int i in arr)
            {
                if (i > num)
                    count++;
            }
            return count;

        }
        #endregion

        #region Q02
        public static bool IsPalindrome(int[] arr)
        {
            int left = 0, right = arr.Length - 1;
            while (left < right)
            {
                if (arr[left] != arr[right])
                    return false;
                left++;
                right--;



            }
            return true;
        }
        #endregion

        #region Q03
        public static void ReverseQueue(Queue<int> queue)
        {
            Stack<int> stack = new Stack<int>();
            while (queue.Count > 0)
            {
                stack.Push(queue.Dequeue());
            }
            while (stack.Count > 0)
            {
                queue.Enqueue(stack.Pop());
            }

        }
        #endregion

        #region Q04
        public static bool IsBalanced(string str)
        {
            Stack<char> stack = new();

            foreach (char c in str)
            {
                if (c == '(' || c == '[' || c == '{')
                    stack.Push(c);
                else if (c == ']' && (stack.Count == 0 || stack.Pop() != '['))
                    return false;
                else if (c == ')' && (stack.Count == 0 || stack.Pop() != '('))
                    return false;
                else if (c == '}' && (stack.Count == 0 || stack.Pop() != '{'))
                    return false;
            }

            return stack.Count == 0;
        }
        #endregion

        #region Q05
        public static int[] RemoveDuplicates(int[] arr)
        {
            List<int> list = new List<int>();
            foreach (int i in arr)
            {
                if (!list.Contains(i))
                    list.Add(i);
            }
            return list.ToArray();
        }
        #endregion

        #region Q06
        public static void RemoveOddNumbers(ref ArrayList arr)
        {
            for (int i = 0; i < arr.Count; i++)
            {
                if ((int)arr[i] % 2 == 1)
                    arr.RemoveAt(i);
            }
        }
        #endregion

        #region Q08
        public static void FindElementInStack(Stack<int> stack, int element)
        {
            if (stack.Contains(element))
                Console.WriteLine($"Element {element} is found ");
            else
                Console.WriteLine($"Element {element} is not found");

        }
        #endregion

        #region Q09
        public static List<int> FindIntersection(int[] arr01, int[] arr02)
        {
            List<int> intersection = new List<int>();
            for (int i = 0; i < arr01.Length; i++)
            {
                for (int j = 0; j < arr02.Length; j++)
                {
                    if (arr01[i] == arr02[j])
                    {
                        intersection.Add(arr01[i]);
                        arr02[j] = -1;
                        break;
                    }

                }
            }
            return intersection;
        }
        #endregion

        #region Q11
        public static void ReverseKElements(Queue<int> queue, int K)
        {

            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < K; i++)
            {
                if (queue.Count > 0)
                    stack.Push(queue.Dequeue());
            }
            while (stack.Count > 0)
            {
                queue.Enqueue(stack.Pop());
            }
            int remaining = queue.Count - K;
            for (int i = 0; i < remaining; i++)
            {
                queue.Enqueue(queue.Dequeue());
            }
        }
        #endregion

        #region Q12
        public static void CountFrequency(int[] arr)
        {
            Dictionary<int, int> FreqDictionary = new Dictionary<int, int>();
            foreach (int num in arr)
            {
                if (FreqDictionary.ContainsKey(num))
                    FreqDictionary[num]++;
                else
                    FreqDictionary[num] = 1;
            }
            foreach (var pair in FreqDictionary)
                Console.WriteLine($"{pair.Key},{pair.Value}");
        }
        #endregion

        #region Q13
        public static object FindKeyWithHigestValue(Hashtable ht)
        {
            object MaxKey = null;
            int MaxValue = int.MinValue;
            foreach (DictionaryEntry entry in ht)
            {
                int value = (int)entry.Value;
                if (value > MaxValue)
                {
                    MaxValue = value;
                    MaxKey = entry;
                }
            }
            return MaxKey;
        }
        #endregion

        #region Q16
        public static bool CheckDoublecations(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                        return true;
                }
            }
            return false;
        }
        #endregion
        static void Main(string[] args)
        {
            #region Q01
            //List<int> Numbers = new List<int>() { 11, 5, 3 };

            //Console.WriteLine($"Numbers is grreater than num in list is {IsGreater(Numbers, 1)}");
            //Console.WriteLine($"Numbers is grreater than num in list is {IsGreater(Numbers, 7)}");


            #endregion

            #region Q02
            //int[] Numbers = { 1, 3, 2, 3, 1 };
            //Console.WriteLine(IsPalindrome(Numbers));
            #endregion

            #region Q03
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);

            Console.WriteLine("Original Queue: " + string.Join(", ", queue));

            ReverseQueue(queue);

            Console.WriteLine("Reversed Queue: " + string.Join(", ", queue));



            #endregion
        }
    }
}
