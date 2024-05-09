using OOPOnLesson.Exeptions;
using System.Reflection.Metadata;

namespace OOPOnLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // logic
            } catch (Exception exc)
            {
                Dictionary
                new TopilmadiExseption(exc.Message);
            }
        }
    }

    public class Fruit
    {
        // public, private, internal, protected
        public string Name { get; set; }
    }

    public class Meva : Fruit
    {
        public string Name { get; set;}
        public string Davay;



        public Meva()
        {
            
        }

        ~Meva()
        {
            
        }
    }

    public class Document
    {
        private string SecretKey { get; set; } = "2022:09:18 password: 909033";

        public string MyHitrKey { get; set; } = "nidsa66";

        public string GetName()
        {
            return SecretKey + MyHitrKey;
        }

        public string SetKey(string key)
        {
            SecretKey = key + MyHitrKey;
            return SecretKey ;
        }
    }

    public abstract class Shape
    {
        public abstract string Corners();
        public abstract string Perimeters();
        public abstract string Area();
        public virtual string Radius() 
        {
            return "Davayte";
        }

        public string Rating()
        {
            return "Davayte 5 *****";
        }
    }

    public class Uchburchak : Shape
    {
        // polymorphism ni overriding
        public override string Area()
        {
            return "hhgfdsf";
        }

        public override string Corners()
        {
            // logic
            // kirovchi
            // chiquvchi hech qanday type va boshqa qo'shimchalar kiritish mumkin emas
            return "3ohiueruierogbwogbowieb";
        }

        public override string Perimeters()
        {
            return "500 m";
        }

        public override string Radius()
        {
            return base.Radius();
        }
    }

    public class PolumorphismOverloading
    {
        // overloadingda shunday hususiyati borki
        // qachonki methodni nomi o'zgarmasa bo'ldi

        // polymorphism 
        // overload, compile, dynamic
        // override, runtime, static

        public int Add(int a, int b)
        {
            a += 23;
            return a + b;
        }

        public int Add(int a, int b, int c)
        {
            b *= 23;
            return a + b + c;
        }

        public float Add(int a, int b, int c, float d)
        {
            c /= 23;    
            return a + b + c + d;
        }
    }



    public class Person 
    {
        public void Leg()
        {


            Console.WriteLine("Yurib kelish");
        }
        public void Baqirish()
        {
            Console.WriteLine("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");
        }

        // abstract, sealed class, oddiy class
    }

    public static class Dog
    {


        public static string Tishlash(this string item, string nimadur)
        {
            Console.WriteLine("Hayvon quturdi");

            item = item.Replace("X", "Y");

            return item + nimadur;
        }


    }
}
