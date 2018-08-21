using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joven.DesignPattern.TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            KaoJuan kj=new StudentAnswer1();
            kj.Question1();
            kj.Question2();
            kj.Question3();

            KaoJuan kj2=new StudentAnswer2();
            kj2.Question1();
            kj2.Question2();
            kj2.Question3();



            Console.ReadKey();
        }
    }

    public class KaoJuan
    {
        public void Question1()
        {
            Console.WriteLine("问题1：我的名字？a.李杰 b.小杰杰  c.杰哥 d.杰爷");
            Console.WriteLine("答案：{0}", Answer1());
        }
        public void Question2()
        {
            Console.WriteLine("问题1：我的年龄？a.18 b.20  c.21 d.22");
            Console.WriteLine("答案：{0}", Answer2());
        }
        public void Question3()
        {
            Console.WriteLine("问题1：我的住址？a.上海 b.北京  c.南京 d.重庆");
            Console.WriteLine("答案：{0}", Answer3());

            Console.WriteLine("************************************");
        }

        public virtual string Answer1()
        {
            return "";
        }
        public virtual string Answer2()
        {
            return "";
        }
        public virtual string Answer3()
        {
            return "";
        }
    }

    public class StudentAnswer1 : KaoJuan
    {
        public override string Answer1()
        {
            return "a";
        }

        public override string Answer2()
        {
            return "b";
        }

        public override string Answer3()
        {
            return "c";
        }
    }

    public class StudentAnswer2 : KaoJuan
    {
        public override string Answer1()
        {
            return "d";
        }

        public override string Answer2()
        {
            return "a";
        }

        public override string Answer3()
        {
            return "b";
        }
    }
}
