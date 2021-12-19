// See https://aka.ms/new-console-template for more information



using System.Diagnostics;
using System.Timers;

int[] NumInput = new int[10];
int[] NumOutput = new int[10];
int Time = 60;
System.Console.SetCursorPosition(0, 0);
System.Console.WriteLine($"剩余时间：{Time}");
System.Console.SetCursorPosition(0, 3);
int rightNum = 0;
for (int j = 0; j < NumOutput.Length; j++)
{
    while (true)
    {
        Random ran = new Random();
        int num = ran.Next(10, 99);
        if (Array.IndexOf(NumOutput, num) == -1)
        {
            NumOutput[j] = num;

            Console.Write(NumOutput[j] +" ");
            break;
        }
    }
}
Stopwatch stopwatch = null;
while (true)
{
    if (stopwatch == null)
    {
        stopwatch = Stopwatch.StartNew();
    }

    // 时间到
    if (stopwatch != null && stopwatch.Elapsed.TotalSeconds > Time)
    {
        stopwatch.Stop();
        stopwatch = null;
        break;

    }
    else
    {
        System.Console.SetCursorPosition(0, 0);

        System.Console.WriteLine($"剩余时间：{Convert.ToInt32(Time - stopwatch.Elapsed.TotalSeconds):d2}");
    }


}

Console.Clear();
Console.Write("请输入数字，以\" \"分隔");


string[] array1 = Console.ReadLine().Split();

while (array1.Length > 10)
{
    Console.Write("你输入的数字个数大于10，请重新输入数字，以\" \"分隔");

    array1 = Console.ReadLine().Split();
}

for(int i = 0; i< array1.Length; i++)
{
    NumInput[i] = Convert.ToInt32(array1[i]);

}

foreach (int num in NumInput)
{
    if (Array.IndexOf(NumOutput, num) != -1)
    {
        rightNum ++;
    }
}

Console.Write("程序生成的数字为：");
foreach (int num in NumOutput)
{
    Console.Write(num + " ");

}
Console.WriteLine();
Console.Write("你输入的数字为：");
foreach (int num in NumInput)
{
    Console.Write(num + " ");

}
Console.WriteLine();

double rightNumfloat = Convert.ToDouble(rightNum);
double rightNumdouble = Convert.ToDouble(10);

Console.WriteLine($"正确数目：{rightNum} 错误数目{10 - rightNum}，正答率{rightNumfloat / rightNumdouble}");
Console.Write("按任意键以退出");
Console.ReadLine();
