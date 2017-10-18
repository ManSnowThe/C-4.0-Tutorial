/* Обнаружить сборку, определить типы и создать объект
с помощью рефлексии. */
using System;
using System.Reflection;

namespace ca2
{
    class ReflectAssemblyDemo
    {
        static void Main()
        {
            int val;

            // Загрузить сборку MyClasses.exe.
            Assembly asm = Assembly.LoadFrom("Class17.8(1).exe");

            // Обнаружить типы, содержащиеся в сборке MyClasses.exe.
            Type[] alltypes = asm.GetTypes();
            foreach (Type temp in alltypes)
                Console.WriteLine("Найдено " + temp.Name);

            Console.WriteLine();

            // Использовать первый тип, в данном случае - класс MyClass.
            Type t = alltypes[0]; // использовать первый найденный класс
            Console.WriteLine("Использовано " + t.Name);

            // Получить сведения о конструкторе.
            ConstructorInfo[] ci = t.GetConstructors();

            Console.WriteLine("\nДоступные конструкторы: ");
            foreach (ConstructorInfo c in ci)
            {
                // Вывести возвращаемый тип и имя
                Console.Write(" " + t.Name + "( ");

                // Вывести параметры.
                ParameterInfo[] pi = c.GetParameters();
                for (int i = 0; i < pi.Length; i++)
                {
                    Console.Write(pi[i].ParameterType.Name + " " + pi[i].Name);
                    if (i + 1 < pi.Length) Console.Write(", ");
                }
                Console.WriteLine(")");
            }
            Console.WriteLine();

            // Найти подходящий конструктор
            int x;
            for (x = 0; x < ci.Length; x++)
            {
                ParameterInfo[] pi = ci[x].GetParameters();
                if (pi.Length == 2) break;
            }
            if (x == ci.Length)
            {
                Console.WriteLine("Подходящий конструктор не найден.");
                return;
            }
            else
                Console.WriteLine("Найден конструктор с двумя параметрами.\n");

            // Сконструировать объект.
            object[] consargs = new object[2];
            consargs[0] = 10;
            consargs[1] = 20;
            object reflectOb = ci[x].Invoke(consargs);

            Console.WriteLine("\nВызов методов для объекта reflectOb.");

            Console.WriteLine();

            MethodInfo[] mi = t.GetMethods();

            // Вызвать каждый метод.
            foreach (MethodInfo m in mi)
            {
                // Получить параметры
                ParameterInfo[] pi = m.GetParameters();

                if (m.Name.CompareTo("Set") == 0 && pi[0].ParameterType == typeof(int))
                {
                    // Это метод Set(int, int).
                    object[] args = new object[2];
                    args[0] = 9;
                    args[1] = 18;
                    m.Invoke(reflectOb, args);
                }
                else if (m.Name.CompareTo("Set") == 0 && pi[0].ParameterType == typeof(double))
                {
                    // Это метод Set(double, double).
                    object[] args = new object[2];
                    args[0] = 1.12;
                    args[1] = 23.4;
                    m.Invoke(reflectOb, args);
                }
                else if (m.Name.CompareTo("Sum") == 0)
                {
                    val = (int)m.Invoke(reflectOb, null);
                    Console.WriteLine("Сумма равна " + val);
                }
                else if (m.Name.CompareTo("IsBetween") == 0)
                {
                    object[] args = new object[1];
                    args[0] = 14;
                    if ((bool)m.Invoke(reflectOb, args))
                        Console.WriteLine("Значение 14 находится между x и у");
                }
                else if (m.Name.CompareTo("Show") == 0)
                {
                    m.Invoke(reflectOb, null);
                }
            }
        }
    }
}
