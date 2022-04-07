using System;

public class PrimeOrNot
{
	public PrimeOrNot()
	{

	}
	public Boolean isPrime(int n)
	{
		Boolean flag = true;
		if (n == 0 || n == 1)
		{
			return flag;
		}
		for (int i = 2; i < n / 2; i++)
		{
			if (n % i == 0)
			{
				flag = false;
			}
		}
		return flag;
	}

	//public static void Main(string[] args)
	//{
	//	PrimeOrNot primeOrNot = new PrimeOrNot();
	//	Console.WriteLine("Enter any number for checking prime or not = ");
	//	int n = 13;
	//	Boolean flag = primeOrNot.isPrime(n);
	//	if (flag)
	//	{
	//		Console.WriteLine("Number is prime");
	//	}
	//	else
	//	{
	//		Console.WriteLine("Number is not prime");
	//	}

	//}
}

