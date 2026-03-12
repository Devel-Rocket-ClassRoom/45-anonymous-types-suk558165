using System;

var weather = new[]
{
    new { Day = "월요일", High = 12, Low = 3, Rain = 20 },
    new { Day = "화요일", High = 8, Low = -1, Rain = 60 },
    new { Day = "수요일", High = 5, Low = -3, Rain = 80 },
    new { Day = "목요일", High = 10, Low = 2, Rain = 40 },
    new { Day = "금요일", High = 15, Low = 5, Rain = 10 }
};

Console.WriteLine("=== 5일간 날씨 예보 ===");
Console.WriteLine($"{"요일",-6} {"최고기온",6} {"최저기온",6} {"강수확률",6}");
Console.WriteLine("------------------------------------");

foreach (var w in weather)
{
    Console.WriteLine($"{w.Day,-6} {w.High + "도",6} {w.Low + "도",6} {w.Rain + "%",6}");
}

Console.WriteLine("------------------------------------");

double avgHigh = 0;
int rainyDays = 0;

foreach (var w in weather)
{
    avgHigh += w.High;
    if (w.Rain >= 50) rainyDays++;
}

avgHigh /= weather.Length;

Console.WriteLine($"최고기온 평균: {avgHigh:F1}도");
Console.WriteLine($"비 올 가능성 높은 날(50% 이상): {rainyDays}일");

