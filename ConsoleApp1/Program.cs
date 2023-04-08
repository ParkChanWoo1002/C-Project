using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            char grade = 'S';
            int health = 100;
            float attack = 36.5f;

            Console.WriteLine("grade 변수의 값 : " + grade); // 특정한 문자열을 출력하는 함수
            Console.WriteLine("health의 값 : " + health);
            Console.Write("attack변수의 값 : "+ attack +" / ");
            Console.Write("/ 은 무슨 기능일까"); // 특정한 문자열을 출력하는 함수 띄어쓰기 X
        }
    }
}
