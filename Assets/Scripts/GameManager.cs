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
        #region Ŭ���� �ν��Ͻ�(��ü) ����
        //fighter.Move();
        //fighter.hp = 200;
        //fighter.attackPower = 10;
        //fighter.Attack("�÷��̾�");
        #endregion

        #region ������(Constructor) ���� new Ű����
        //fighter1 = new SwordMan(50, 5.5f, "���� �˻�");
        //fighter2 = new SwordMan(100, 8.0f, "���� ���� �˻�");
        //SwordMan fighter3 = new SwordMan(250, 13.7f, "���� �� �˻�");

        //get�� ������ ���ο� �����͸� �߰����� ���Ѵ�.
        //Property�� ����Ͽ� ������ ����
        //fighter3.healthPoint = 599;
        //print(fighter3.healthPoint);

        // get, set �Լ��� ����Ͽ� ������ �����ϱ�
        //fighter3.SetHP(500);
        //int hp = fighter3.GetHP();
        //print(hp);

        //fighter1.name = "���� �˻�";
        //fighter1.Move();

        //fighter2.name = "���� ���� �˻�";
        //fighter2.Move();

        //fighter3.name = "���� �� �˻�";
        //fighter3.Move();
        #endregion

        #region ���, ������ ����
        // �ڽ� A is a �θ� B  A=B�̴� (���)
        // A has a B A�� B�� ������ �ִ�.
        // Police has a Gun(������ ������ ����)
        //�θ� Ŭ����<-> �ڽ�Ŭ����
        #endregion

        #region ���� ����, ���� ����
        // ��ü���� ���� ���� ����
        // ���� ���� : �޸𸮿��� ����� �������� �������
        // �� �Լ� �ȿ��� ���� ���� ����
        // ���� ���� : ��� ���� �޸𸮿��� ������

        //���� ����
        //print(number);

        //TestFunction();
        #endregion

        #region OOP(ĸ��ȭ, �߻�ȭ, ������??????)
        //��ü ������ ���α׷���(Object Oriented Programming )

        // ĸ��ȭ(���м�)
        // readonly (���� ��������), �Ӽ�(property)
        // 

        // �߻�ȭ
        // �߻�ȭ ��Ģ : virtual , ��� �޴� override ��Ƽ�÷��� ������ ���

        // **������**
        // ??

        #endregion
    }

    void Update()
    {
        
    }
    void TestFunction()
    {
        ////���� ����
        //for (int i = 0; i < 3; i++)
        //{
        //    int number = 0;
        //    //int number = 50;
        //    number += 10;
        //    print(number);
        //}
        ////���� ����
        //int number1 = 0;
        //for (int i = 0; i < 3; i++)
        //{
        //    number1 = 0;
        //    number1 += 10;
        //    print(number1);
        //    //���� ����
        //    //this.number = number1;
        //}
        

    }
}
