

// برنامه ای بنویسید که یک عدد را از ورودی دریافت بکند و علامت آن را تعیین بکند

Console.Write("Please enter number: ");
int Number1 = Convert.ToInt32(Console.ReadLine());

if (Number1 >= 0)
	Console.WriteLine("Namber Is Positive");
else
	Console.WriteLine("Namber Is Negative");

Console.ReadKey();

// نوشتن این برنامه در این حالت بسیار بهینه و کوتاه است اما اگر بخواهید از
// else if
// استفاده بکنید میتوانید از کد زیر استفاده بکنید

Console.Write("Please enter number: ");
int Number2 = Convert.ToInt32(Console.ReadLine());

if (Number2 > 0)
	Console.WriteLine("Namber Is Positive");
else if (Number2 == 0)
	Console.WriteLine("Namber Is Zero");
else if (Number2 < 0)
	Console.WriteLine("Namber Is Negative");

Console.ReadKey();
