// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
#region task1

//int num1 = 34;
//int num2 = 66;


//num1+=num2 ;
//num2 = num1 - num2;
//num1 -= num2;
//Console.WriteLine(num1);
//Console.WriteLine(num2);
#endregion
#region task2



int [] operation = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

foreach (var item in operation)
{
    string result = item switch
    {
        1 => "qis",
        2 => "qis",
        3 => "yaz",
        4 => "yaz",
        5 => "yaz",
        6 => "yay" ,
        7 =>"yay",
        8 =>"yay",
        9 => "payiz",
        10 =>"payiz",
        11 => "payiz",
        12 => "qis"
      
    };
    Console.WriteLine(result);
}




#endregion