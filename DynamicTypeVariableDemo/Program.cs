// See https://aka.ms/new-console-template for more information

void dynamicMethodDemo(dynamic d1, dynamic d2, dynamic d3)
{
    Console.WriteLine("Dynamic values :" + d1 + d2 + d3);
    Console.Read();
}

dynamic value1 = "Welcome to bootcamp learning";
dynamic value2 = 1234.356;
dynamic value3 = false;
dynamic value4 = 43434.45d;

Console.WriteLine("The actual type of value1 :{0}", value1.GetType().ToString());
Console.WriteLine("Get the actual type of value2 :{0}", value2.GetType().ToString());
Console.WriteLine("The actual type of value3 :{0}", value3.GetType().ToString());
Console.WriteLine("The actual type of value4 :{0}", value4.GetType().ToString());

dynamicMethodDemo(100, 300, 250);