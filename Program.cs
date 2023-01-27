Console.Clear();
Console.WriteLine("Введите первое число");
int first = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int second = int.Parse(Console.ReadLine());
if (first > second){
    Console.WriteLine($"Первое число {first} больше второго числа {second}");
}
else if (first == second){
    Console.WriteLine($"Первое число {first} равно числу {second}");
}
else{
    Console.WriteLine($"Первое число {first} меньше второго числа {second}");
}