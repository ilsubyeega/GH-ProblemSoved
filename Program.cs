
using System;
using System.Linq;

// 입력 핸들기: 입력 파싱하기 귀찮아서 일부로 만듬
// (string[] 여러개의 readline, int[] 반환값)
Func<string[], int[]> input_multiple_line = x => x.Select(a => int.Parse(a)).ToArray();
// (string 한개의 readline에서 (1/1) (1 1) 같은 값 파싱, int[] 반환값)
Func<string, string, int[]> input_one_line = (x, y) => x.Split(y ?? " ").Select(a => int.Parse(a)).ToArray();

// 문제 번호, 백준 문제 번호: 백준 문제 이름

// A, 2557: Hello World!
Console.WriteLine("Hello World!");

// B, 10171: 고양이
Console.WriteLine("\\    /\\\n )  ( ')\n(  /  )\n \\(__)|");

// C, 1008: A/B
{
	var input = input_one_line(Console.ReadLine(), null);
	Console.WriteLine((float)input[0] / input[1]);
}
// D, 10869: 사칙연산
{
	var input = input_one_line(Console.ReadLine(), null);
	Console.WriteLine(input[0] + input[1]);
	Console.WriteLine(input[0] - input[1]);
	Console.WriteLine(input[0] * input[1]);
	Console.WriteLine(input[0] / input[1]);
	Console.WriteLine(input[0] % input[1]);
	
}

// E, 1330: 두 수 비교하기
{
	var input = input_one_line(Console.ReadLine(), null);
	if (input[0] == input[1]) Console.WriteLine("==");
	else Console.WriteLine(input[0] > input[1] ? ">" : "<");
}

// F, 2753: 윤년
{
	var input = int.Parse(Console.ReadLine());
	Console.WriteLine(input % 400 == 0 || (input % 100 != 0 && input % 4 == 0) ? "1" : "0"); 
}

// G, 9498: 시험 성적
{
	var input = int.Parse(Console.ReadLine());
	if (input > 90) Console.WriteLine("A");
	else if (input > 80) Console.WriteLine("B");
	else if (input > 70) Console.WriteLine("C");
	else if (input > 60) Console.WriteLine("D");
	else Console.WriteLine("F");
}

// H, 14681: 사분면 고르기
{
	var input = input_multiple_line(new string[] { Console.ReadLine(), Console.ReadLine() });
	bool positivex = input[0] > 0;
	bool positivey = input[1] > 0;
	if (positivex)
	{
		if (positivey) Console.WriteLine("1");
		else Console.WriteLine("4");
	} else
	{
		if (positivey) Console.WriteLine("2");
		else Console.WriteLine("3");
	}
}

// I, 20499: Darius님 한타 안 함?
{
	var input = input_one_line(Console.ReadLine(), "/");
	Console.WriteLine(input[0] + input[2] < input[1] || input[1] == 0 ? "hasu" : "gosu");
}

// J, 2588: 곱셈 (세자리 조건)
{
	var input = input_multiple_line(new string[] { Console.ReadLine(), Console.ReadLine() });
	var splittedtwo = input[1].ToString().ToCharArray().Select(a => int.Parse(a.ToString())).ToArray();
	Console.WriteLine(input[0] * splittedtwo[2]);
	Console.WriteLine(input[0] * splittedtwo[1]);
	Console.WriteLine(input[0] * splittedtwo[0]);
	Console.WriteLine(input[0] * input[1]);
}

// K, 2884: 알람 시계
// 버전 1 (라이브러리 짱짱)
{
	var input = input_one_line(Console.ReadLine(), null);
	var datetime = new DateTime(2000, 1, 1, input[0], input[1], 0).AddMinutes(-45);
	Console.WriteLine($"{datetime.Hour} {datetime.Minute}");
}
// 버전 2
{
	var input = input_one_line(Console.ReadLine(), null);
	var hours = input[0];
	var minutes = input[1];
	minutes = minutes - 45;
	if (minutes < 0)
	{
		minutes = minutes + 60;
		hours--;
	}
	if (hours < 0)
		hours = hours + 24;

	Console.WriteLine($"{hours} {minutes}");
}