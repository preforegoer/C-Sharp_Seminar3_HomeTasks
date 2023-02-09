// 14212 -> нет; 12821 -> да; 23432 -> да
Console.Clear();
Console.WriteLine("Enter a 5-digit number");
int a = Convert.ToInt32(Console.ReadLine());

int b = (a/10000);
int c = (a-(a-a/1000)-b*10);
int d = (a-b*10000-c*1000-(c*10+1))/100;
int e = (a-b*10000-c*1000-d*100-b)/10;
int f = (a-(a-a%10));


if (a < 10000 || a > 99999)
    Console.WriteLine($"{a} is not a 5-digit number");

else if (b-f==0 & c-e==0)
    Console.WriteLine($"{a} is Polydrone");
else
    Console.WriteLine($"{a} is NOT Polydrone");