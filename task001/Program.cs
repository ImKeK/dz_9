System.Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine()!);

System.Console.WriteLine(PrintNumbers(N, 1));

// Метод

string PrintNumbers(int start, int end)
{
  if (start == end) return start.ToString();
  return (start + " " + PrintNumbers(start - 1, end));
}


