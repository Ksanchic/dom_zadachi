{
int numberA;
int numberB;
int numberE;

Console.WriteLine ("Введите три числа: ");

numberA = Convert.ToInt32(Console.ReadLine());
numberB = Convert.ToInt32(Console.ReadLine());
numberE = Convert.ToInt32(Console.ReadLine());

    if (numberA > numberB)
        if (numberA > numberE)
        {
            Console.WriteLine ("{0} max", numberA);
        }
        else
        {
            Console.WriteLine ("{0} max", numberE);
        }
    else
        if (numberB > numberE)
        {
            Console.WriteLine ("{0} max", numberB);
        }
        else
        {
            Console.WriteLine ("{0} max", numberE);
        }
    Console.ReadLine();
}