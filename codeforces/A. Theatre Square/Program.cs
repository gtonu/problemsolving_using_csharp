
string[] values = Console.ReadLine().Split(' ');
double n = double.Parse(values[0]);
double m = double.Parse(values[1]);
double a = double.Parse(values[2]);

long ans = (long)(Math.Ceiling(n / a) * Math.Ceiling(m / a));
Console.WriteLine(ans);


