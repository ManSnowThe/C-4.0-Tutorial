// Использовать свойство в качестве именованного параметра атрибута.
using System;
using System.Reflection;
namespace ca2
{
    [AttributeUsage(AttributeTargets.All)]
    public class RemarkAttribute : Attribute
    {
        string pri_remark; // базовое поле свойства Remark
        public string Supplement; // это именованный параметр

        public RemarkAttribute(string comment)
        {
            pri_remark = comment;
            Supplement = "Отсутствует";
            Priority = 1;
        }
        public string Remark
        {
            get
            {
                return pri_remark;
            }
        }
        // Использовать свойство Priority в качестве именованного аргумента
        public int Priority
        {
            get;
            set;
        }
    }
    [RemarkAttribute("В этом классе используется атрибут",
        Supplement ="Это дополнительная информация.",
        Priority = 10)]
    class UseAttrib
    {
        //...
    }
    class NamedParamDemo
    {
        static void Main()
        {
            Type t = typeof(UseAttrib);

            Console.Write("Атрибуты в классе " + t.Name + ": ");
            object[] attribs = t.GetCustomAttributes(false);
            foreach(object o in attribs)
            {
                Console.WriteLine(o);
            }
            // Извлечь атрибут RemarkAttribute.
            Type tRemAtt = typeof(RemarkAttribute);
            RemarkAttribute ra = (RemarkAttribute)Attribute.GetCustomAttribute(t, tRemAtt);

            Console.Write("Примечание: ");
            Console.WriteLine(ra.Remark);

            Console.Write("Дополнительно: ");
            Console.WriteLine(ra.Supplement);

            Console.WriteLine("Приоритет: " + ra.Priority);
        }
    }
}
