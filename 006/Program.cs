Console.WriteLine("Введите число A: ");
double A = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());
            

void Zadacha25()
{
     double S = 1;
     for (int i = 0; i < B; i++)
     {
         S *= A;   
     }
     Console.WriteLine(S);
 }
 Zadacha25();