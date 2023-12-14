int a = 5;
int b = 6;


Add(a, b);
Add(10, 100);
Add(56583, 658686);


Multiply(a, b);
Multiply(10, 100);
Multiply(156583, 1);


static void Add(int x, int y)
{
    Console.WriteLine($"{x} + {y} = {x + y}");
}

static void Multiply(int x, int y)
{
    Console.WriteLine($"{x} * {y} = {x * y}");
}

static void Substract(int x, int y) // x - y
{
    //your code
}

static void Drivide(int x, int y) //x / y
{
    //your code
}