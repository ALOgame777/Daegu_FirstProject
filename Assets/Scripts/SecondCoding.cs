using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondCoding : MonoBehaviour
{
    public int age1 = 15;
    public int age2 = 7;
    public bool isMan = true;
    public bool runState;
    public bool walkState;

    void Start()
    {

        // ���ǹ� 
        // if(���ǽ�)
        // {
        //  ������ ���� �� �ؾ� �� ��
        // }
        // else if(���ǽ�)
        // {
        //  �ι�° ���ǽ��� ���� �� �ؾ��� ��
        // }
        // else
        // {
        //  �տ� �ִ� ��� ���ǵ��� �� �������� ���� �� �ؾ��� ��
        // }




        #region Example 1
        //if (age1 > age2)
        //{
        //    print("age1 �� age2 ���� ���̰� �� �����ϴ�.");
        //}
        //if (age1 < age2)
        //{
        //    print("age1 �� age2 ���� ���̰� �����ϴ�..");
        //}
        //if (age1 <= age2)
        //{
        //    print("age1 �� age2 ���� ���̰� ���ų� �����ϴ�.");
        //}
        //if (age1 >= age2)
        //{
        //    print("age1 �� age2 ���� ���̰� ���ų� �����ϴ�.");
        //}
        //if (age1 == age2)
        //{
        //    print("age1 �� age2 �� ���̰� �����ϴ�.");
        //}
        //if (age1 != age2)
        //{
        //    print("age1 �� age2 �� ���̰� ���� �ʽ��ϴ�.");
        //}

        // age1�� ���̸� �������� 10�� ���� 40������� ��� ���� �ش��ϴ����� ����Ѵ�.
        // ��)"age1�� 30�� �Դϴ�.
        // [if]���� ~~��� A�ϰ�, [else]�׷��� ������ B�ϰڴ�.
        //if (age1 < 20)
        //{
        //    print("age1�� 10�� �Դϴ�");
        //}
        //else if (age1 < 30)
        //{
        //    print("age1�� 20�� �Դϴ�");
        //}
        //else if (age1 < 40)
        //{
        //    print("age1�� 30�� �Դϴ�");
        //}
        //else if (age1 < 50)
        //{
        //    print("age1�� 40�� �Դϴ�");
        //}
        //else
        //{
        //    print("age1�� 50�� �̻� �Դϴ�");
        //}

        //if(age1 >= 20)
        //{
        //    print("age1�� ���̴� 20�� �̻��Դϴ�");
        //}
        //else
        //{
        //    print("age1�� ���̴� 20�� �̸��Դϴ�.");
        //}

        // ���� ~~��� ~~�ϰ�, 
        // [else]�׷��� �ʰ� [if]���� ~~��� ~~�ϰ�
        // ... 
        // �׷��� �ʰ� ���� else if �̰��� ���̸� �ؿ� �ִ� else�� ���� �ʴ´�.
        // 


        // �� ������
        // And ������
        // A ���ǽİ� B ���ǽ��� �� �� ���� ��� True , �� �� �ϳ��� �����̸� False [if(A ���ǽ� && B ���ǽ�)]

        // or ������
        // A ���ǽİ� B ���ǽ��� �ϳ��� True�̸� True �� �� false �ϰ�� false [if(A ���ǽ� || B ���ǽ�)]

        // if(����[T]&& 30��[T]&& �繫��[F]) = false
        //  
        // ���� [�޸���-Ű�� ���� ������ ��, �ȱ�-Ű�� �ϳ��� ������ ��, ����-Ű�� �� ������ ��]
        // shiftŰ�� ����T / �ȴ��� F , W ���� T, �ȴ��� F 
        // TT = �޸���
        // FT = �ȱ�
        // FF = ����


        // ������ ���� ~~ �ϰڴ�. //����ǥ �˻�
        // �ϳ��� T�� T
        // T or T-T
        // F or T - T
        // F or F - F
        #endregion


        #region Example 2
        // 1. And ����
        // ����, ������ �����̰� ���̰� 20�� �̻��� ���
        // "���� �����Դϴ�" ��� ����Ѵ�.
        //if (isMan == false && age1 >= 20)
        //{
        //    print("���� �����Դϴ�.");
        //}
        //else
        //{
        //    print("�̼������̰ų�, �����Դϴ�.");
        //}

        // 2. Or ����
        // ����, �����̴� ����� "�̵� ���Դϴ�."��� ����ϰ�,
        // �׷��� ������, "������ �����Դϴ�. " ��� ����Ѵ�.
        if (runState == true || walkState == true)
        {
            print("�̵� ���Դϴ�");
        }
        else
        {
            print("������ �����Դϴ�. ");
        }


        //@ bool ������ ���ǹ��� �������� �־��� �� ���� ���
        //�� �Ʒ��� ���� ǥ���̴�.
        // if (runState == true)
        // if(runState)

        // if(runState == false)
        // if(!runState)
       

       

        #endregion
        void Update()
        {

        }
    }
}