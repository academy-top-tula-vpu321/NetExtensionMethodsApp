using NetExtensionMethodsApp;

string str = "Hello world";
//Console.WriteLine(StringAdvansed.CountChar(str, 'l'));
Console.WriteLine(str.CountChar('l'));

Employee bob = new Employee("Bobby");
bob.Print();
Employee tom = new Employee("Tommy", 32);
tom.Print();


namespace NetExtensionMethodsApp
{
    public static class StringExtension
    {
        public static int CountChar(this string str, char ch)
        {
            int count = 0;
            foreach (char c in str)
                if (c == ch) count++;
            return count;
        }
    }

    public partial class Employee
    {
        public int Age { get; set; } = 0;
        public Employee(string name, int age) : this(name)
        {
            this.Age = age;
        }

        public partial void Print()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }



    //static class StringAdvansed
    //{
    //    public static int CountChar(string str, char ch)
    //    {
    //        int count = 0;
    //        foreach (char c in str)
    //            if (c == ch) count++;
    //        return count;
    //    }
    //}

}