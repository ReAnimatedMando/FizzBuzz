string FizzBuzz(int number)
{
    var buzzWord = "";
    
    if (number % 3 == 0 && number % 5 == 0)
    {
        buzzWord = "fizzbuzz";
    }
    else if (number % 3 == 0)
    {
        buzzWord = "fizz";
    }
    else if (number % 5 == 0)
    {
        buzzWord = "buzz";
    }
    else
    {
        buzzWord = "Not Divisible";
    }

    return buzzWord;
}

Console.WriteLine(FizzBuzz(9));
Console.WriteLine(FizzBuzz(10));
Console.WriteLine(FizzBuzz(15));
Console.WriteLine(FizzBuzz(7));