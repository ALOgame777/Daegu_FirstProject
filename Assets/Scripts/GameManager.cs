using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    SwordMan fighter1;
    SwordMan fighter2;
    SwordMan fighter3;
    int number = 10;
    Transform trans;

    void Start()
    {
        #region 클래스 인스턴스(객체) 생성
        //fighter.Move();
        //fighter.hp = 200;
        //fighter.attackPower = 10;
        //fighter.Attack("플레이어");
        #endregion

        #region 생성자(Constructor) 연습 new 키워드
        //fighter1 = new SwordMan(50, 5.5f, "약한 검사");
        //fighter2 = new SwordMan(100, 8.0f, "조금 강한 검사");
        //SwordMan fighter3 = new SwordMan(250, 13.7f, "완전 쎈 검사");

        //get이 없으면 새로운 데이터를 추가하지 못한다.
        //Property를 사용하여 변수에 접근
        //fighter3.healthPoint = 599;
        //print(fighter3.healthPoint);

        // get, set 함수로 사용하여 변수에 접근하기
        //fighter3.SetHP(500);
        //int hp = fighter3.GetHP();
        //print(hp);

        //fighter1.name = "약한 검사";
        //fighter1.Move();

        //fighter2.name = "조금 강한 검사";
        //fighter2.Move();

        //fighter3.name = "완전 쎈 검사";
        //fighter3.Move();
        #endregion

        #region 상속, 변수를 가짐
        // 자식 A is a 부모 B  A=B이다 (상속)
        // A has a B A는 B를 가지고 있다.
        // Police has a Gun(변수로 가지고 있음)
        //부모 클래스<-> 자식클래스
        #endregion

        #region 전역 변수, 지역 변수
        // 전체에서 쓰는 전역 변수
        // 전역 변수 : 메모리에서 지우기 전까지는 살아있음
        // 한 함수 안에서 쓰는 지역 변수
        // 지역 변수 : 잠시 쓰고 메모리에서 없어짐

        //전역 변수
        //print(number);

        //TestFunction();
        #endregion

        #region OOP(캡슐화, 추상화, 다형성??????)
        //객체 지향형 프로그래밍(Object Oriented Programming )

        // 캡슐화(은닉성)
        // readonly (읽을 수만있음), 속성(property)
        // 

        // 추상화
        // 추상화 원칙 : virtual , 상속 받는 override 멀티플레이 구현때 사용

        // **다형성**
        // ??

        #endregion
    }

    void Update()
    {
        
    }
    void TestFunction()
    {
        ////지역 변수
        //for (int i = 0; i < 3; i++)
        //{
        //    int number = 0;
        //    //int number = 50;
        //    number += 10;
        //    print(number);
        //}
        ////지역 변수
        //int number1 = 0;
        //for (int i = 0; i < 3; i++)
        //{
        //    number1 = 0;
        //    number1 += 10;
        //    print(number1);
        //    //전역 변수
        //    //this.number = number1;
        //}
        

    }
}
