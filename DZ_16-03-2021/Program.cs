using System;
using System.Linq;

namespace DZ_16_03_2021
{
	class Program
	{
		static void Main(string[] args)
		{
			{
				Console.WriteLine("ДЗ 1");
				// Дан текст тип string. Заменить все строчные гласные в данной строке
				// числами в соответствии со следующим шаблоном:
				// a -> 1
				// e -> 2
				// i -> 3
				// o -> 4
				// u -> 5
				string str = "hello";
				Console.WriteLine(str);
				var strArr = str
					.Select(c => c == 'a' ? '1' : c)
					.Select(c => c == 'e' ? '2' : c)
					.Select(c => c == 'i' ? '3' : c)
					.Select(c => c == 'o' ? '4' : c)
					.Select(c => c == 'u' ? '5' : c).ToArray();
				Console.WriteLine(new String(strArr));
			}
			Console.WriteLine("");
			{
				Console.WriteLine("ДЗ 2");
				// Продолжение предыдущие задачи. Заменить все цифры в тексте в
				// соответствии со следующим шаблоном:
				// 1 -> a
				// 2 -> e
				// 3 -> i
				// 4 -> o
				// 5 -> u
				string str = "h2ll4";
				Console.WriteLine(str);
				var strArr = str
					.Select(c => c == '1' ? 'a' : c)
					.Select(c => c == '2' ? 'e' : c)
					.Select(c => c == '3' ? 'i' : c)
					.Select(c => c == '4' ? 'o' : c)
					.Select(c => c == '5' ? 'u' : c).ToArray();
				Console.WriteLine(new String(strArr));
			}
			Console.WriteLine("");

			{
				Console.WriteLine("ДЗ 3");
				// Дан текст тип string, которая состоит из двух положительных чисел
				// (двойных) и ровно одного оператора, такого как +, -, *, /, всегда между
				// этими числами. Строка грязная, что означает, что внутри тоже есть
				// разные символы, не только цифры и оператор. Вы должны объединить
				// все цифры влево и вправо для вычисления результата, который должен
				// быть округлен до целого числа и преобразован в строку в конце.
				string str = "gdfgdf234dg54gf*23oP42";
				string oper = new String(str.Where(x => char.IsPunctuation(x)).ToArray());

				var charsArr = str.Where(x => char.IsPunctuation(x) || char.IsNumber(x)).ToArray();
				var operands = (new String(charsArr)).Split(char.Parse(oper));
				int num1 = int.Parse(operands[0]);
				int num2 = int.Parse(operands[1]);
				Console.WriteLine(num1 + " " + oper + " " + num2);
				int rez = oper switch
				{
					"*" => num1 * num2,
					"/" => num1 / num2,
					"+" => num1 + num2,
					"-" => num1 - num2,
					_ => 0
				};
				Console.WriteLine(rez);
			}
			Console.WriteLine("");
			{
				Console.WriteLine("ДЗ 4");
				// Дан текст формата camel text (“camelText” – предложение пишется без
				// пробела, а каждая слово начинается с большой буквой
				// типаЭтогоПредложения) необходимо разделить, используя пробел
				// между словами.
				string str = "textCamelExample";
				Console.WriteLine(str);
				var strArr = str
								.Select(x => x.ToString())
								.Select(x => char.IsUpper(char.Parse(x)) ? " " + x : x);
				string joinedStr = string.Join("", strArr);
				System.Console.WriteLine(joinedStr);
			}
		}
	}
}
