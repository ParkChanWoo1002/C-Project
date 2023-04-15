using System.Collections;
using System.Diagnostics.CodeAnalysis;

namespace ConsoleProgram4
{
    //클래스  사용자 정의 데이터 유형으로 속성과 함수가 포함되어
    //있으며, 클래스를 통해 객체를 생성하여 접근하고 사용할 수 있는
    // 집합체입니다.

    //기본 접근지정자 private
    //접근지정자 public : 클래스의 속성을 어디에서든지 접근할 수 있는 접근 지정자 입니다.
    //private : 클래스의 속성을 내부에서만 사용할 수 있으며, 외부와 자기가 상속하고잇는 클래스에서는 접근이 불가능합니다.
    //protected: 클래스의 속성을 내부와 자기가 상속하고 있는 클래스에서만 접근이 가능하며 외부에서는 접근이 불가능한  
    // 접근 지정자 입니다.

    //internal 은 개인공부필요

    class Monster
    {
        //바이트 패딩이란? : 멤버 변수를 메모리에서 CPU로 읽을때 한번에 읽을 수 있도록 컴파일러가 
        //레지스터블럭에 맞춰서 바이트를 패딩 해주는 최적화 작업
        public char grade; // 1byte
        public int health; // 4byte
        public double defense; // 8byte    -> 힙 영역에서 클래스는 16바이트(double배수)로 나옴 (제일큰 변수 자료형의 배수)
                                           // 바이트 패딩 -> CPU가 메모리를 더 쓰더라도 한번에 할수있도록함
                                           // 8의 배수를 맞추기위해서 3byte의 padding을 넣음
                                           // 클래스 오프셋
        public void Attack()  // 매개변수를 안넣었지만 this가 들어있다. static메서드는 this를 반환하지않음
        {
            Console.WriteLine("공격");
        }
    }

   class Unit
    {
        // 상속이란?
        // 상위 클래스의 속성을 하위 클래스가 사용할 수 있도록 설정해주는 기능
        public string name;
        protected int health;
        private float killScore;

       // 생성자
       // 클래스의 인스턴스가 생성되는 시점에서
       // 자동으로 호출되는 특수한 멤버 함수입니다.
       public Unit()
        {
            // 생성자의 경우 객체가 생성될 때 단 한번만 호출되며,
            // 생성자는 반환형이 존재하지 않습니다.
            Console.WriteLine("Unit Class가 생성되었습니다.");
        }
    }

     class Marine : Unit
    {
        public Marine()
        {
            Console.WriteLine("Marine 클래스가 생성되었습니다.");
        }

        // 함수의 오버로딩
        // 같은 이름의 함수를 매개 변수의 자료형과 매개변수의 갯수로
        // 구분하여 어러 개를 선언할 수 있는 기능입니다.
     
        public void Skill()
        {
            Console.WriteLine("Steam Pack");
        }

        public void Skill(int damage)
        {
            Console.WriteLine("damage : " + damage);
        }

        public void Skill(string name)
        {
            Console.WriteLine("skill name : " + name);
        }
    }

    //집가서 

    internal class Program
    {
        static void Main(string[] args)
        {
            // ALt누르고 드래그 주석
            #region 클래스
            /* Monster monster1 = new Monster(); //Monster monster1; -> 스택,  new Monster().grade, .health -> 힙 영역
             monster1.grade = 'A';                     // 코드영역 -> void attack
             monster1.health = 10;
             monster1.Attack();

             Monster monster2 = new Monster();
             monster2.grade = 'B';
             monster2.health = 5;
             monster2.Attack();*/

            #endregion
            #region 배열
            // 같은 자료형의 변수들로 이루어진 유한 집합
            // 배열의 선언
            /*int [] itemList = new int[5];
            itemList[0] = 10;
            itemList[1] = 20;
            itemList[2] = 30;
            itemList[3] = 40;
            itemList[4] = 50;

            //배열은 원하는 원소에 값을 저장할 수 있으며,
            //배열의 크기는 컴파일 되는 시점부터 고정된 메모리 공간을 가지게 된다.
            for (int i = 0; i < itemList.Length; i++)
            {
                Console.WriteLine("item = " + itemList[i]);
            }*/

            //배열은 런타임 시점에 배열의 크기를 변경할 수 없다.
            // 리스트 -> List : arraylist,/ LinkedList
            // LinkedList는 인덱스 접근이 안된다. 삽입과 삭제가 용이하다





            #endregion
            #region 박싱과 언박싱
            // 값 타입 : bool, char, byte, short, int, long , float ,double, decimal, struct
            // 참조 타입 : class , array , delegate, object   
            // object 모든 자료형을 저장할 수 있는 최상위 자료형


            // 박싱이란?
            // 값 형식을 참조 형식으로 변환해주는 과정.
            //int data = 100; //값 타입   -> 스택
            //object obj = data;  // 힙에  int data 100이라는 박스를 저장한다.  
            //
            //// 언박싱이란?
            //// 참조형식을 값 형식으로 변환하는 과정
            //int result = (int)obj; // 명시적 형변환 
            //// msdn에 박싱20배 언박싱4배의 성능을 더 쓴다.
            //Console.WriteLine(obj);
            //Console.WriteLine(result);
            //
            //ArrayList arrayList = new ArrayList(); // 어레이 리스트를 쓸때 박싱 언박싱을쓴다.
            //arrayList[0] = 10;
            //arrayList[1] = "Park";  //이 과정에서 박싱과정이 진행되는 것
            #endregion
            #region 상속

            Marine marine1 = new Marine();   // 생성될때는 부모클래스부터 생성  소멸될때는 자식부터 소멸
            //Unit unit = new Unit();
            marine1.Skill();
            marine1.Skill(10);
            marine1.Skill("Steam Pack");
            #endregion
            // 네이밍 컨벤션
            // camel case 카멜 표기법 <- 변수, 매개변수
            //ex) int countDown; int count 첫번째 단어를 제외하고 첫글짜를 대문자로 표기하는 표기법

            // pascal case 파스칼 표기법 -< 함수, 클래스명, 구조체이름에 사용
            // 단어의 첫글자를 대문자로 표기하는 방법
            // int PlayerHealth;

            // snake case 스네이크표기법
            // 전부소문자로표기하고 단어사이에 _를 표기하는 표기법입니다.
            // data_player player_health
        }
    }       
}           
            