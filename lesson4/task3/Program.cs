

void ArrayReverse (int [] array, int size)
{  
    if (size < 0)
    return;
   
   Console.Write($"{array[size]} ");
    ArrayReverse(array,size -1);
}
int [] ArrayNumbers = [1, 2, 5, 0, 10, 34];
ArrayReverse(ArrayNumbers,5);



void ShowNumbers (int M, int N)
{
   
  if (M <= 0 || M-1 == N)
    return;

     
  ShowNumbers(M,N-1);
  Console.Write($"{N} ");
   
}

 ShowNumbers(4,8);


int AckermanFn (int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }
    if (m == 0)
    {
        return AckermanFn(n-1,1);
    }
    return AckermanFn(n-1, AckermanFn(n,m-1));
    
}

Console.Write(AckermanFn(3,5));