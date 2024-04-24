void Number(int num)
{

    if (num % 7 == 0 && num % 23 == 0)
    {
        Console.WriteLine($"число {num} кратно 7 и 23 одновременно");
    }
    else
    {
        Console.WriteLine($"число {num} не кратно 7 и 23 одновременно");
    }
}
Number(161);

void Function(int a, int b)
{
    if (a > 0 && b > 0)

    {
        Console.WriteLine("Координаты находятся в 1 четверти");
    }

    if (a > 0 && b < 0)
    {
        Console.WriteLine("Координаты находятся во 2 четверти");
    }
    if (a < 0 && b < 0)
    {
        Console.WriteLine("Координаты находятся в 3 четверти");
    }
    if (a < 0 && b > 0)
    {
        Console.WriteLine("Координаты находятся в 4 четверти");
    }

}

Function(5, -6);

void maxNum(int number)
{
    int firstNumber = number / 10;
    int secondNumber = number % 10;

    if (firstNumber > secondNumber)
    {
        Console.WriteLine(firstNumber);
    }
    if (firstNumber == secondNumber)
    {
        Console.WriteLine("Цифры равны");
    }
    if (firstNumber < secondNumber)
    {
        Console.WriteLine(secondNumber);
    }

}
maxNum(10);

void numberFn(int number)
{
    if (number < 10)
    {
        Console.WriteLine(number);
    }
    while (number > 0)

    {
        int currentNum = number % 10;
        number /= 10;

        if (number > 0)
        {
            Console.Write($"{currentNum},");
        }
        else
        {
            Console.Write(currentNum);
        }
    }
   

}

numberFn(756);