// A (3,6,8); B (2,1,-7), -> 15.84; A (7,-5, 0); B (1,-1,9) -> 11.53
Console.Clear();
Console.WriteLine("Enter First point coordinates:");
Console.Write("a - "); int a = Convert.ToInt32(Console.ReadLine());
Console.Write("b - "); int b = Convert.ToInt32(Console.ReadLine());
Console.Write("c - "); int c = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Second point coordinates:");
Console.Write("x - "); int x = Convert.ToInt32(Console.ReadLine());
Console.Write("y - "); int y = Convert.ToInt32(Console.ReadLine());
Console.Write("z - "); int z = Convert.ToInt32(Console.ReadLine());
double d = Math.Round(Math. Sqrt ((x-a)*(x-a)+(y-b)*(y-b)+(z-c)*(z-c)),2);

Console.WriteLine($"Distance between the points equals to {d}.");