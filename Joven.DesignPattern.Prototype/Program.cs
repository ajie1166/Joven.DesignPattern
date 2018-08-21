using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joven.DesignPattern.Prototype
{
    class Program
    {
        //原型
        static void Main(string[] args)
        {
            /*****浅表开始*****/
            JianLi jl = new JianLi("小ai");
            jl.SetPersonalInfo(18);
            jl.SetWorkExperienceInfo("2016-1-1", "SH");

            JianLi jl1 = (JianLi)jl.Clone();
            jl1.SetWorkExperienceInfo("2017-1-1", "SZ");
            jl.Display();
            jl1.Display();
            /******浅表结束********/


            Resume r = new Resume("小杰哥");
            r.SetPersonalInfo(20);
            r.SetWorkExperienceInfo("2001-1-1", "CQ");

            Resume r1 = (Resume)r.Clone();
            r1.SetWorkExperienceInfo("2002-1-1", "CD");

            r.Display();
            r1.Display();


            Console.ReadKey();
        }
    }

    //浅表
    public class JianLi : ICloneable
    {
        private string name = string.Empty;
        private int age = 0;
        private GongZuoJingLi gzjl = null;

        public JianLi(string name)
        {
            this.name = name;
            gzjl = new GongZuoJingLi();
        }

        public void SetPersonalInfo(int age)
        {
            this.age = age; ;
        }

        public void SetWorkExperienceInfo(string workDate, string place)
        {
            gzjl.WorkDate = workDate;
            gzjl.WorkPlace = place;
        }

        public void Display()
        {
            Console.WriteLine("姓名：{0}，年纪：{1}", this.name, this.age);
            Console.WriteLine("工作时间：{0}，工作地点：{1}", gzjl.WorkDate, gzjl.WorkPlace);

        }
        public object Clone()
        {
            return this.MemberwiseClone();//此方法用于浅表复制
        }


    }
    //经历
    public class GongZuoJingLi
    {
        public string WorkDate { get; set; }
        public string WorkPlace { get; set; }
    }



    //深表 fuck
    public class Resume
    {
        private string name = string.Empty;
        private int age = 0;
        private WorkExperience gzjl = null;

        public Resume(string name)
        {
            this.name = name;
            gzjl = new WorkExperience();
        }

        Resume(WorkExperience work)
        {
            this.gzjl = (WorkExperience)work.Clone();
        }

        public void SetPersonalInfo(int age)
        {
            this.age = age; ;
        }

        public void SetWorkExperienceInfo(string workDate, string place)
        {
            gzjl.WorkDate = workDate;
            gzjl.WorkPlace = place;
        }

        public void Display()
        {
            Console.WriteLine("姓名：{0}，年纪：{1}", this.name, this.age);
            Console.WriteLine("工作时间：{0}，工作地点：{1}", gzjl.WorkDate, gzjl.WorkPlace);

        }
        public object Clone()
        {
            Resume r = new Resume(gzjl);
            r.name = name;
            r.age = age;
            return r;

        }
    }


    //经验
    public class WorkExperience
    {
        public string WorkDate { get; set; }
        public string WorkPlace { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
