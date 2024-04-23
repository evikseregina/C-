void Number (int num) {

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