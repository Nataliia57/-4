void Zadacha27()
        {
            Console.WriteLine("Введите число: ");
            int numberA = Convert.ToInt32(Console.ReadLine());

            int i = 0;
            while (numberA > 0)
            {
                i = i + numberA%10;
                numberA = numberA/10;
                i++;
            }
            Console.WriteLine(i);
        }
         Zadacha27(); 
