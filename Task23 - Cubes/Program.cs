// 3 -> 1, 8, 27; 5 -> 1, 8, 27, 64, 125
Console.Clear();
Console.Write("From 1 to "); int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Cubes are:");
int cube = n*n*n;
Console.WriteLine(cube);

while (n > 1)
{   
    int a = n-1;
    Console.WriteLine(a*a*a);
    n = n-1;
}