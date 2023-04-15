using System.Collections;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

namespace ConsoleProgramming0408
{
    class GameObject  // 얘는 힙 영역에있고 객체는 스택
    {
        public int scale;


        public void Attack(int a)
        {
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("공격");
            }
        }
    }


    internal class Program
    {
       
        static void Attack_V2()
        {
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("공격");
            }
        }
        
        static int Damage()  // 반환형 함수는 반환하는 값이 있어야 한다.
        {
            // 값을 반환할 때 반환형에 알맞는 자료형의 값을 반환해야 한다.
            
            return 47;
        }

        static void Stat(int x)
        {
            Console.WriteLine("\n매개변수 x의 값은? : " + x);
        }

        static int Calculator(int x, int y)
        {
            return x + y;
        }

        static void ItemData(ref int count)
        {
            count += 100;
        }

        static void RaycastHit(out float ray)
        {
            // out : 함수 내부에서 값을 무조건 초기화해주어야 한다.
            ray = 99.9f;
        }

        //in키워드 -> const 참조자
        static void ItemInformation(in int data)
        {
            //읽기 전용
            Console.WriteLine("data의 값 : " + data);
        }
        
        static void Process(int count)
        {
            Console.WriteLine("작업 처리");

            if (count == 1)
                return;
            
            Process(count-1);


        }

        static void Main(string[] args) // 메인루틴 , 함수들을 서브루틴
        {
            // 코드 영역 = 함수의 주소, 리터럴이 저장
            // data영역 (.rodata, .data) = 초기화가 이루어진 전역변수랑 정적변수   char * name = "Game"; rodata 영역으로 들어감 char array[10] = {"Game"}; .data영역인듯?
            // bss = 초기화가 이루어지지않은 전역변수랑 정적변수 
            // heap = 사용자가 직접 할당한 메모리/ C#에서는 사용자가 메모리를 해제하지 않아도 됩니다.
            // stack = 함수 내부에 선언된 변수로 내부에서만 사용가능하며, 종료되면 메모리에서 해제되는 영역 = 지역변수 ,매개변수

            //지역변수 함수 내부에 선언된 변수로 함수를 벗어나면 더이상 변수가 유효하지 않는 변수입니다.
            //정적변수 프로그램이 실행될 때 메모리에 올라가게 되며 프로그램이 종료될 때 메모리에서 사라지는 변수
            //함수 = 하나의 특별한 목적의 작업을 수행하기 위해 독립적으로 설게된 코드의 집합
            //void = 값을 반환하지 않는 반환형
            //매개변수 = 함수의 정의에서 전달받은 인수를 함수 내부로 전달하기 위해 사용하는 변수

            #region 메소드
            GameObject gameObject = new GameObject(); // 동적 변수
            gameObject.scale = 10;

            //void 함수
            Attack_V2();
            //int 함수
            Console.WriteLine("\n" + Damage());
            //void 함수(int)
            //인수란 함수가 호출될 때 매개 변수에 실제로 전달되는 값입니다.
            Stat(10);
            // int 함수 (int)
            Console.WriteLine("\n" + Calculator(1, 2));

            /*Console.WriteLine("\n공격을 몇번 할까요?");
            string data = Console.ReadLine();
            gameObject.Attack(int.Parse(data));*/

            #endregion

            #region 매개변수 한정자

            // ref 참조 = 함수 매개변수랑 호출할때 값 둘다 ref로 수정 -> 하나의 공간에 두개의 이름을 써서 같은 메모리
            // * 애스터리스크 연산자(포인터)  x86 -> 32비트 4바이트, x64 = 64비트 8바이트  메모리 크기
            // out 키워드 (참조) 외부에 있는 변수를 초기화하지않아도 인수로 전달할 수 있다.

            //float ray;//같은 이름이지만 서로 지역이 다르기때문에 이름이 같아도 에러안뜸
            //RaycastHit(out ray);
            //Console.WriteLine("ray의 값 : " + ray);

            /*  int item = 100;
              ItemData(ref item);
              Console.WriteLine("\nitem의 값은? : " + item);*/

            //int dataBase = 30;
            //ItemInformation(dataBase);



            #endregion

            //재귀함수 = 어떤 함수에서 자신을 다시 호출하여 작업을 수행하는 함수

            #region 재귀함수
            Process(5);
            #endregion


        }

        //유니티 솔리드 https://velog.io/@gooeynewts/SOLID-Design-Patterns-Unity

    }
}