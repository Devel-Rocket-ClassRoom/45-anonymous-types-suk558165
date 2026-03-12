using System;

string title = "인터스텔라";
string genre = "SF";
double rating = 9.2;
int releaseYear = 2014; ;

var movieInfo = new { title, genre, rating, releaseYear };

Console.WriteLine("=== 영화 정보 === ");
Console.WriteLine($"제목: {movieInfo.title}");
Console.WriteLine($"장르: {movieInfo.genre}");
Console.WriteLine($"평점: {movieInfo.rating}");
Console.WriteLine($"개봉연도: {movieInfo.releaseYear}년\n");
Console.WriteLine("ToString 결과:");
Console.WriteLine(movieInfo.ToString());

