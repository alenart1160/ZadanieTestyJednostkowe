using System;

class Program
{
	static void Main()
	{
		Console.WriteLine("Obliczanie pierwiastków równania kwadratowego ax^2 + bx + c = 0.");

		Console.Write("Podaj współczynnik a: ");
		double a = Convert.ToDouble(Console.ReadLine());

		Console.Write("Podaj współczynnik b: ");
		double b = Convert.ToDouble(Console.ReadLine());

		Console.Write("Podaj współczynnik c: ");
		double c = Convert.ToDouble(Console.ReadLine());

		double delta = b * b - 4 * a * c;
		double x1, x2;

		if (delta > 0)
		{
			x1 = (-b - Math.Sqrt(delta)) / (2 * a);
			x2 = (-b + Math.Sqrt(delta)) / (2 * a);
			Console.WriteLine("Równanie ma dwa pierwiastki rzeczywiste: x1 = {0}, x2 = {1}", x1, x2);
		}
		else if (delta == 0)
		{
			x1 = -b / (2 * a);
			Console.WriteLine("Równanie ma jeden pierwiastek rzeczywisty (podwójny): x = {0}", x1);
		}
		else
		{
			Console.WriteLine("Równanie nie ma pierwiastków rzeczywistych.");
		}
	}
}
