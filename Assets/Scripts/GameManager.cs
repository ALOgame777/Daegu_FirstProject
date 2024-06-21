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

        fighter1 = new SwordMan(50, 5.5f, "약한 검사");
        fighter2 = new SwordMan(100, 8.0f, "조금 강한 검사");
        fighter3 = new SwordMan(250, 13.7f, "완전 쎈 검사");

        //fighter1.name = "약한 검사";
        //fighter1.Move();

        //fighter2.name = "조금 강한 검사";
        fighter2.Move();

        //fighter3.name = "완전 쎈 검사";
        //fighter3.Move();
        
        #region 상속, 변수를 가짐
        // 자식 A is a 부모 B  A=B이다 (상속)
        // A has a B A는 B를 가지고 있다.
        // Police has a Gun(변수로 가지고 있음)
        #endregion
    }

    void Update()
    {
        
    }
}
