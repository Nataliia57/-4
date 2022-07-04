//Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
//4 -> 24 
//5 -> 120

void Zadacha28()
        {
            Console.WriteLine("Введите число:");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(FindNamber(number));
        }

        int FindNamber(int number)
        {
            int sum = 1;
            for (int i = 1; i <= number; i++)
            {
                sum = sum * i; 
            }
             return sum;
        }
Zadacha28();
