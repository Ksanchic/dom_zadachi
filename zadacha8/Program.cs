{
int N;
int i;
Console.WriteLine ("Введите число N: ");
N = Convert.ToInt32(Console.ReadLine());
i = 1;

if (N == 1)
    {
   Console.WriteLine("нет четных чисел"); 
    }

while (i <= N)
   if (i % 2 == 0)
   {
    Console.WriteLine (i);
    i = i + 1;
   }
    else
   {
    i = i + 1;
   }
   
Console.ReadLine();
}
