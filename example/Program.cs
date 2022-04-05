// Методы.

//Вид 1. ничего не принимает и не возвращает.
void Method1()
{
    Console.WriteLine("Автор...");
}
//Method1();


//Вид 2. принимает, но не возвращает.
void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2("Текст сообщения");
//или
//Method2(msg: "Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method21("Текст сообщения", 4);
//или
//Method21(count: 2, msg: "Новый текст");


//Вид 3. ничего не принимает, возвращает.

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
//Console.WriteLine(year);



//Вид 4. принимает и возвращает.
// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;

//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
// string res = Method4(10, "Zz");
// Console.WriteLine(res);



//цикл For.

string Method4(int count, string text)
{
    string result = String.Empty;

    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, "Zz");
//Console.WriteLine(res);


//цикл в цикле.

Console.Clear();

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}
