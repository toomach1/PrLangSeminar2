Console.WriteLine("Введите число 1");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2");
int num2 = Convert.ToInt32(Console.ReadLine());
int result = num*num;
int result2 = num2*num2;

if(result == num2){
    
    Console.WriteLine("Число 1 является квадратом числа 2");
 
}

else{
    Console.WriteLine($"Число 1 не является квадратом числа 2");
}

if(result2 == num){
    
    Console.WriteLine("Число 2 является квадратом числа 1");
 
}

else{
    Console.WriteLine($"Число 2 не является квадратом числа 1");
}
