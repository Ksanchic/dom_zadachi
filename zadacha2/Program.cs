{
int numberA;
int numberB;
Console.WriteLine ("Введите два числа: ");
numberA = Convert.ToInt32(Console.ReadLine());
numberB = Convert.ToInt32(Console.ReadLine());
    if (numberA > numberB)
   { 
    Console.WriteLine ("{0} max", numberA); 
    Console.WriteLine ("{0} min", numberB);
   }
    else
    {
        Console.WriteLine ("{0} max", numberB);
        Console.WriteLine ("{0} min", numberA);
    }
    Console.ReadLine();
}