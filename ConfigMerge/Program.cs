using System;

var nomal = new { ResolutionWidth = 1920, ResolutionHeight = 1080, Volume = 50, Difficulty = "보통" };
var user = new { ResolutionWidth = 1920, ResolutionHeight = 1080, Volume = 80, Difficulty = "어려움" };

Console.WriteLine($"[기본 설정]");
Console.WriteLine($"{nomal}\n");
Console.WriteLine($"[사용자 설정]");
Console.WriteLine($"{user}\n");

bool same = nomal.GetType() == user.GetType();
Console.WriteLine($"[타입 비교]");
Console.WriteLine($"같은 타입: {same} (속성 구조가 동일)\n");
Console.WriteLine($"[값 비교]");
Console.WriteLine($"Equals 결과: {nomal.Equals(user)}(Volume, Difficulty 값이 다름)\n");

var backup = new { ResolutionWidth = 1920, ResolutionHeight = 1080, Volume = 50, Difficulty = "보통" };
Console.WriteLine($"[백업 설정]");
Console.WriteLine($"{backup}");
Console.WriteLine($"기본 설정과 Equals: {nomal.Equals(backup)}(모든 값이 동일)\n");

var optionList = new[]
{
    new {ResolutionWidth = 1920, ResolutionHeight = 1080, Volume = 50, Difficulty = "보통"},
    new { ResolutionWidth = 1920, ResolutionHeight = 1080, Volume = 80, Difficulty = "어려움" },
    new {ResolutionWidth = 1920, ResolutionHeight = 1080, Volume = 50, Difficulty = "보통"}
};
Console.WriteLine("=== 설정 목록 (배열) ===");
Console.WriteLine($"설정 1: {optionList[0].ResolutionWidth} x {optionList[0].ResolutionHeight}, 볼륨 {optionList[0].Volume}, 난이도: {optionList[0].Difficulty}");
Console.WriteLine($"설정 2: {optionList[1].ResolutionWidth} x {optionList[1].ResolutionHeight}, 볼륨 {optionList[1].Volume}, 난이도: {optionList[1].Difficulty}");
Console.WriteLine($"설정 3: {optionList[2].ResolutionWidth} x {optionList[2].ResolutionHeight}, 볼륨 {optionList[2].Volume}, 난이도: {optionList[2].Difficulty}\n");

var diff = new { Volume = 50, Difficulty = "보통", ResolutionWidth = 1920, ResolutionHeight = 1080 };
bool samesame = nomal.GetType() == diff.GetType();
Console.WriteLine("=== 속성 순서가 다른 설정 ===");
Console.WriteLine($"{diff}");
Console.WriteLine($"기본 설정과 같은 타입: {samesame} (속성 순서가 달라 다른 타입]");


