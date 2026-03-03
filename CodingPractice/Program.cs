using System;

// 1
{
    object obj1 = 42;
    object obj2 = 3.14;
    object obj3 = "Hello";
    object obj4 = true;

    Console.WriteLine(obj1);
    Console.WriteLine(obj2);
    Console.WriteLine(obj3);
    Console.WriteLine(obj4);
    Console.WriteLine();
}

// 2
{
    Stack stack = new Stack();
    stack.Push(3);
    stack.Push("sausage");
    Console.WriteLine(stack.Pop());
    Console.WriteLine(stack.Pop());
    Console.WriteLine();
}

// 3-1
{
    int i = 1234;
    object o = i;
    Console.WriteLine(o);
    Console.WriteLine();
}

// 3-2
{
    object o = 1234;
    Console.WriteLine((int)o);
    Console.WriteLine();
}

// 4-1
{
    int i = 42;
    object o = i;
    Console.WriteLine(o);
    Console.WriteLine();
}

// 4-2
{
    Point p = new Point { x = 3, y = 2 };
    IDisplayable id = p;
    Console.WriteLine(id.GetType().Name);
    Console.WriteLine();
}

// 5
{
    int i = 3;
    object o = i;
    i = 5;
    Console.WriteLine($"원본: {i}");
    Console.WriteLine($"박싱된 값: {o}");
    Console.WriteLine();
}

// 6
{
    int i = 42;
    object o = i;
    int num = (int)o;
    Console.WriteLine($"언박싱 성공: {o}");

    try
    {
        long l1 = (long)o;
    }
    catch (Exception e) { Console.WriteLine("잘못된 타입으로 언박싱 시도"); }

    long l2 = (long)num;
    Console.WriteLine($"바른 변환: {l2}");
}

// 7-1
{
    int sum = 0;
    for (int i = 0; i< 1000; i++)
    {
        object o = i;
        sum += (int)o;
    }
    Console.WriteLine($"박싱 사용: {sum}");
    sum = 0;
    for (int i = 0; i < 1000; i++)
    {
        sum += i;
    }
    Console.WriteLine($"직접 처리: {sum}");
}

// 7-2
{
    GenericStack<int> stack = new GenericStack<int>();
    stack.Push(42);
    Console.WriteLine(stack.Pop());
    Console.WriteLine();

}

// 8-1
{
    int a = 3;
    string b = "h";
    char c = 'a';
    double d = 3.14;
    object o = a;
    Console.WriteLine(a.GetType());
    Console.WriteLine(b.GetType());
    Console.WriteLine(c.GetType());
    Console.WriteLine(d.GetType());
    Console.WriteLine(o.GetType());
    Console.WriteLine();
}

// 8-2
{
    Console.WriteLine(typeof(int));
    Console.WriteLine(typeof(string));
    Console.WriteLine(typeof(double));
    Console.WriteLine();
}

// 8-3
{
    Point1 point1 = new Point1();
    Console.WriteLine(point1.GetType().Name);
    Console.WriteLine(typeof(Point1).Name);
    Console.WriteLine(point1.GetType() == typeof(Point1));
    Console.WriteLine(point1.X.GetType().Name);
    Console.WriteLine(point1.Y.GetType().FullName);
    Console.WriteLine();

}

// 9-1
{
    int a = 3;
    double b = 3.14;
    bool c = true;
    Console.WriteLine(a.ToString());
    Console.WriteLine(b.ToString());
    Console.WriteLine(c.ToString());
    Console.WriteLine();
}

// 9-2
{
    Panda panda = new Panda { Name = "Petey" };
    Console.WriteLine(panda);
    Console.WriteLine();
}

// 9-3
{
    Player player = new Player { Name = "Hero", Level = 10, Health = 100 };
    Console.WriteLine(player);
    Console.WriteLine();
}

// 10
{
    string s1 = "Hello";
    string s2 = "Hello";
    string s3 = s1;
    object o1 = new object();
    object o2 = new object();
    object o3 = o1;

    Console.WriteLine($"s1.Equals(s2): {s1.Equals(s2)}");
    Console.WriteLine($"ReferenceEquals(s1, s2): {ReferenceEquals(s1, s2)}");
    Console.WriteLine($"ReferenceEquals(s1, s3): {ReferenceEquals(s1, s3)}");
    Console.WriteLine($"o1.Equals(o2): {o1.Equals(o2)}");
    Console.WriteLine($"ReferenceEquals(o1, o2): {ReferenceEquals(o1, o2)}");
    Console.WriteLine($"ReferenceEquals(s1, s3): {ReferenceEquals(o1, o3)}");


}


// 2
class Stack
{
    object[] objArr = new object[10];
    private int index = 0;

    public void Push(object obj)
    {
        objArr[index++] = obj; 
    }
    public object Pop()
    {
        return objArr[--index];
    }

}

// 4-2
interface IDisplayable { }
struct Point : IDisplayable
{
    public int x;
    public int y;
}

// 7-2
class GenericStack<T>
{
    private T[] arr = new T[10];
    private int _top = 0;

    public void Push(T obj)
    {
        arr[_top++] = obj;  
    }
    public T Pop()
    {
        return arr[--_top];
    }
}

// 8-3
class Point1
{
    public int X;
    public int Y;
}

// 9-2
class Panda
{
    public string Name;
    public override string ToString()
    {
        return Name;
    }
}

// 9-3
class Player
{
    public string Name;
    public int Level;
    public int Health;

    public override string ToString()
    {
        return $"Player {{ Name = {Name}, Level = {Level}, Health = {Health} }}";
    }
}