// 1) либо так:
using static ArrayCreator;
using static ArrayMath;
using System.Diagnostics;

// var array = Create(10);

// 2) либо так:
// int[] array = ArrayCreator.Create(10); // до добавления this в методе

// 3) либо так:

int[] array = 1000000.Create()//после добавления this в методе
                .Fill(1, 15);//после добавления this в методе

//array.ConvertToStringAndPrint();

int m = 10000;
Stopwatch sw = new Stopwatch();
sw.Start();

int max = array.BadGetSum(m);
sw.Stop();

Console.WriteLine($"BadGetSum: {max} => {sw.ElapsedMilliseconds}");


sw.Reset();
sw.Start();
m = array.GoodGetSum(m);
sw.Stop();

Console.WriteLine($"GoodGetSum: {max} => {sw.ElapsedMilliseconds}");


// int[] a = Fill(array,5,6); // до добавления this в методе


// Console.WriteLine(array.ConvertToStr());
