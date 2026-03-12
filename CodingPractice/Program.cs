using System;

//## 1. 익명 타입 생성
{
    var student = new { Name = "김철수", Grade = 3, Score = 95.5 };

    Console.WriteLine($"이름: {student.Name}");
    Console.WriteLine($"학년: {student.Grade}");
    Console.WriteLine($"점수: {student.Score}");
}
Console.WriteLine();

//### 2-1. 명시적 이름 지정
string name = "이영희";
int age = 28;

var person1 = new { Name = name, Age = age };


Console.WriteLine($"person1: {person1.Name}, {person1.Age}");
Console.WriteLine();

//### 2-2. 변수명으로 자동 추론
var person2 = new { name, age };
Console.WriteLine($"person2: {person2.name}, {person2.age}");
Console.WriteLine();
//## 3. 표현식에서 속성 이름 추론
string text = "Hello";

var info = new { text, text.Length };

Console.WriteLine($"텍스트: {info.text}");
Console.WriteLine($"길이: {info.Length}");
Console.WriteLine();

//## 4. 복합 속성 이름 추론 예제
{
    int productId = 100;
    string ProductName = "마우스";
    double price = 25000.0;

    var product = new
    {
        productId,
        Name = ProductName,
        price,
        FormattedPrice = price.ToString("NO")
    };
    Console.WriteLine($"ID: {product.productId}");
    Console.WriteLine($"상품명: {product.Name}");
    Console.WriteLine($"가격: {product.price}");
    Console.WriteLine($"포맷된 가격: {product.FormattedPrice}원");
}
Console.WriteLine();

//## 5. 타입 동일성
var point1 = new { X = 10, Y = 20 };
var point2 = new { X = 30, Y = 40 };

bool isSameType = point1.GetType() == point2.GetType();
Console.WriteLine($"같은 타입: {isSameType}");

point1 = point2;
Console.WriteLine($"point1: ({point1.X}, {point1.Y})");
Console.WriteLine();

//## 6. 값 동등성 (Equals)
{
    var a = new { X = 2, Y = 4 };
    var b = new { X = 2, Y = 4 };
    var c = new { X = 2, Y = 5 };

    Console.WriteLine($"a.Equals(b): {a.Equals(b)}");
    Console.WriteLine($"a.Equals(b): {a.Equals(c)}");
}
Console.WriteLine();
//## 7. 참조 동등성 (==)
{
    var a = new { X = 2, Y = 4 };
    var b = new { X = 2, Y = 4 };

    Console.WriteLine($"a == b: {a == b}");

    var c = a;

    Console.WriteLine($"a == c: {a == c}");
}
Console.WriteLine();
//## 8. 익명 타입 배열
{
    var students = new[]
    {
    new {Name = "김철수", Score = 85},
    new {Name = "이영희", Score = 92},
    new {Name = "박민수", Score = 78}
};
    Console.WriteLine("=== 학생 점수 목록 ===");
    foreach (var student in students)
    {
        Console.WriteLine($"{student.Name}: {student.Score}점");
    }
}
Console.WriteLine();

//## 9. 배열 요소 접근
{
    var products = new[]
    {
    new {Id = 1, Name = "키보드", Price = 50000},
    new {Id = 2, Name = "마우스", Price = 25000},
    new {Id = 3, Name = "모니터", Price = 300000},
};
    Console.WriteLine($"첫 번째 상품: {products[0].Name}");

    Console.WriteLine($"상품 개수: {products.Length}");

    int total = 0;
    foreach (var product in products)
    {
        total += product.Price;
    }
    Console.WriteLine($"총 가격; {total:N0}원");
}
Console.WriteLine();
//## 10. 구조 기반 타입 동일성
var obj = new { Id = 1, Name = "Object 1" };
Console.WriteLine($"{obj.Id} - {obj.Name}");

obj = new { Id = 2, Name = "Object 2" };
Console.WriteLine($"{obj.Id} - {obj.Name}");
Console.WriteLine();
//## 11. 익명 타입 vs 튜플
var anonymousPerson = new { Name = "홍길동", Age = 30 };

var tuplePerson = (Name: "홍길동", Age: 30);

Console.WriteLine($"익명 타입: {anonymousPerson.Name}, {anonymousPerson.Age}");
Console.WriteLine($"튜플: {tuplePerson.Name}, {tuplePerson.Age}");
Console.WriteLine();

//## 12. ToString() 메서드
var person = new { Name = "김영희", Age = 25, City = "서울" };
Console.WriteLine(person.ToString());
Console.WriteLine(person);
Console.WriteLine();
//## 13. 데이터 그룹화
var employees = new[]
{
    new { Name = "김철수", Department = "개발팀", Salary = 5000 },
    new { Name = "이영희", Department = "기획팀", Salary = 4500 },
    new { Name = "박민수", Department = "개발팀", Salary = 5500 }
};

Console.WriteLine("=== 직원 정보 ===");
foreach (var emp in employees)
{
    Console.WriteLine($"{emp.Name} ({emp.Department}) - {emp.Salary:N0}만원");
}
Console.WriteLine();
//## 14. 임시 데이터 변환
string[] names = { "사과", "바나나", "오렌지" };
int[] prices = { 1000, 1500, 2000 };

var fruits = new[]
{
    new { Name = names[0], Price = prices[0] },
    new { Name = names[1], Price = prices[1] },
    new { Name = names[2], Price = prices[2] }
};

Console.WriteLine("=== 과일 가격표 ===");
foreach (var fruit in fruits)
{
    Console.WriteLine($"{fruit.Name}: {fruit.Price}원");
}



