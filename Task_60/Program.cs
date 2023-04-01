class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите размерность массива");
            int[] arr =new int[int.Parse(Console.ReadLine())];

            Console.WriteLine("Введите минимальное число диапазона чисел");
            int min = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите максимальное число диапазона чисел");
            int max = int.Parse(Console.ReadLine());

            if ((max - min)< arr.Length)
            {
                Console.WriteLine("Диапазон чисел меньше чем, размерность массива");
                return;
            }

            GetRandomArr(ref arr,min,max);

            Console.WriteLine(String.Join(" ", arr));
            Console.ReadKey();
        }

        public static void GetRandomArr(ref int[] arr, int min, int max)
        {
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                var num = random.Next(min, max);

                if (arr.Contains(num))
                {
                    i--;
                }
                else
                {
                    arr[i] = num;
                }
            }
        }
    }