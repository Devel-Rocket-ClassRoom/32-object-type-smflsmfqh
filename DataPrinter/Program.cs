using System;

object[] data = { 42, 3.14, "Hello", true, 100, "World", false, 2.718 };

int intCount = 0;
int doubleCount = 0;
int stringCount = 0;
int boolCount = 0;

Console.WriteLine("=== 데이터 출력기 ===");
Console.WriteLine();
Console.WriteLine("[전체 데이터 출력]");
PrintAll(data);
Console.WriteLine();
Console.WriteLine("[타입별 통계]");
Console.WriteLine($"정수: {intCount}개");
Console.WriteLine($"실수: {doubleCount}개");
Console.WriteLine($"문자열: {stringCount}개");
Console.WriteLine($"논리값: {boolCount}개");

void PrintData(object  data)
{

    switch (data.GetType().Name)
    {
        case "Int32":
            {
                intCount++;
                Console.WriteLine($"정수 : {data}");
            }
            break;
        case "Double":
            {
                doubleCount++;
                Console.WriteLine($"실수: {data:F2}");
            }
            break;
        case "String":
            {
                stringCount++;
                Console.WriteLine($"문자열: \"{data}\" (길이: {data.ToString().Length})");
            }
            break;
        case "Boolean":
            {
                boolCount++;
                Console.Write($"논리값: {data} -> ");
                if (Convert.ToBoolean(data) == true) { Console.WriteLine("참"); }
                else { Console.WriteLine("거짓"); }
            }
            break;
        default:
            {
                Console.WriteLine($"알 수 없는 타입 {data.GetType().Name} - {data}");
            }
            break;
    }

}

void PrintAll(object[] data)
{
    foreach (object obj in data)
    {
        PrintData(obj);
    }
}


