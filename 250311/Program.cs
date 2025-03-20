using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250311
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            float height;

            name = "김경태";
            age = 32;
            height = 178;

            Console.WriteLine("이름 : {0}\n나이 : {1}살\n키 : {2}cm", name, age, height);
            Console.WriteLine("원래는 웹개발쪽에서 일했었지만\n게임이 만들고 싶다는 꿈을 포기하지 못해서\n" +
                "하던 일을 관두고 게임프로그래밍을 배우러 왔습니다.\n잘 부탁드립니다.");
        }
    }
}
