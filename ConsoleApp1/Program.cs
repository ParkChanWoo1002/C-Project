using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 변수 (Variable)
            char grade = 'S';
            int health = 100;
            float attack = 36.5f;

            Console.WriteLine("grade 변수의 값 : " + grade); // 특정한 문자열을 출력하는 함수
            Console.WriteLine("health의 값 : " + health);
            Console.Write("attack변수의 값 : "+ attack +" / ");
            Console.Write("/ 은 무슨 기능일까"); // 특정한 문자열을 출력하는 함수 띄어쓰기 X
            #endregion (Variable)

            #region 변수의 이름 규칙
            // 1. 변수의 이름은 숫자로 시작할 수 없다.
            // ex : int 1count = 0;

            // 2. 변수의 이름으로 키워드를 사용할 수 없다.
            // int int X , int float X

            // 3. 변수의 이름에 공백이 포함될 수 없습니다.
            // 4. 변수의 이름으로 특수문자 _ 만 사용가능합니다
            // 5. 변수의 대소문자를 구분합니다
            // 6. 변수의 이름은 중복될 수 없습니다.
            #endregion

            #region 프로그램 실행 순서
            
            
            #endregion
        }
    }
}
