using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class SecondCoding : MonoBehaviour
{
    public int age1 = 15;
    public int age2 = 7;
    public bool isMan = true;
    public bool runState;
    public bool walkState;
    public int endcount = 100;
    public int printMax = 10;

    int sum = 0;
    int printCount = 0;

    void Start()
    {
        #region ���ǹ� �ۼ���
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
        #endregion

        #region �� ������  Example 1
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

        #region And, Or ����  Example 2
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
        //if (runState == true || walkState == true)
        //{
        //    print("�̵� ���Դϴ�");
        //}
        //else
        //{
        //    print("������ �����Դϴ�. ");
        //}


        //@ bool ������ ���ǹ��� �������� �־��� �� ���� ���
        //�� �Ʒ��� ���� ǥ���̴�.
        // if (runState == true)
        // if(runState)

        // if(runState == false)
        // if(!runState)




        #endregion

        #region �ݺ��� �ۼ���
        // �ݺ���
        // for��, while��
        // 1. ���� ����� �� ȸ �ݺ��� ���
        // 2. �뷮�� �����͸� ����, �˻����� ó���� �� ��
        // for(���ۺ��� ����� �ʱ�ȭ [0������ �����ϴ� ���� �Ϲ���] ; ���� ���ǽ�[ī��Ʈ�� �������� �� ������]; ������[+,-])
        // {
        // �ݺ��� ������ ����
        // }
        // �Լ� �ȿ��� ���, ���ǹ��� ��������
        // ��� ���ٴ� ������ �ϱ�

        #endregion

        #region ���� 1 ������
        // 1 ���� 10 ���� ��� ������ ����Ѵ�. 
        //for (int i = 0; i < 20; i = i+1)
        //{
        //    print(i + 1);
        //}

        // 1 ���� 100���� �� ���� ���� sum�̶�� ������ �����ؼ� ����Ѵ�. �� : 5,050
        //for (int i = 1; i <= endcount �Ǵ� 100; i++)
        //{
        //    sum += i;
        //}
        //print(sum);

        //for (int i = 0; i <= endcount �Ǵ� 100; i = i + 1)
        //{
        //    sum += i;
        //}
        //print(sum);

        //for (int i = 0; i < endcount; i++)
        //{
        //    sum += i + 1;
        //}
        //print(sum);

        // ������
        //int num = 0;
        //num = num + 1;
        //num += 1;
        //num++;
        //num--;

        // 1���� 100���� �߿� ¦���� ����Ѵ�.

        //// 20�� �ݺ��Ѵ�.
        //for(int i = 0; i < endcount; i++)
        //{
        //    int number = i + 1;
        //    //���� number�� ���� 2�� ���� �������� 0�̶��,,, 
        //    if(number % 2 == 0)
        //    {
        //        // �� �ѹ��� ����Ѵ�.
        //        print(number);
        //    }
        //}

        //for (int i = 0; i < endcount; i++)
        //{
        //    int number = i + 1;
        //    //���� number�� ���� 2�� ���� �������� 1�̶��,,,
        //    if (number % 2 == 1)
        //    {
        //        // �� �ѹ��� ����Ѵ�.
        //        print(number);
        //    }
        //}
        #endregion

        #region ���� 2

        //���� ��
        // 0���� endCount ������ ¦���� ����Ѵ�. �׷��� ��µ� ¦���� ���� 10���� �����ϸ� �ݺ��� �����Ѵ�.  
        //for (int i = 0; i < endcount; i++)
        //{
        //    int count = 0;
        //    // numbers�� ¦������ Ȯ��
        //    if (i % 2 == 0 && i < 20)
        //    {
        //        print(i);
        //        if (count > 10)
        //        {
        //            count++;
        //            //¦���� ���� 10���� �����ϸ� �ݺ��� ����
        //            break;
        //        }
        //    }    
        //}

        // ����� ��
        // 0���� endCount �� ���� �ݺ��Ѵ�.
        //for (int i = 0; i < endcount; i++)
        //{
        //    // �����Ǵ� ������ 2�� ���� �������� 0�� ��쿡�� ����Ѵ�.
        //    if(i % 2 == 0)
        //    {
        //        print(i);
        //        // printcount ������ ����� Ƚ���� ���� ��Ų��.
        //        printCount++;
        //        // ����, printcount�� ���� 10�� �����ϸ� �ݺ��� �����Ѵ�.
        //        if(printCount >= printMax)
        //        {
        //            break;
        //        }
        //    }
        //}



        #endregion

        #region for���� for(������ø������), if���� ���� ��ø�ؼ� ��밡��

        // ����, ������ �����̸鼭, ���̰� 20�� �̻��� ���
        //if(isMan && age1 >= 20)

        //if (isMan)
        //{
        //    if(age1 >= 20)
        //    {

        //    }
        //    else
        //    {

        //    }
        //}     
        //for (int i = 2; i < 10; i++)
        //{
        //    for (int j = 1; j < 10; j++)
        //    {
        //        print(i.ToString() + " x " + j.ToString() + "=" + (i * j).ToString());
        //    }

        //}
        #endregion

        #region ����1 * �Ƕ�̵� �����

        // *
        // **
        // ***
        // ****
        // *****

        // Ǯ��1
        //int n = 5;
        //for (int i = 1; i <= n; i++)
        //{
        //    print(new string('*', i));
        //}

        // Ǯ�� 2 
        //string star = "";
        //for(int i = 0; i < 5; i++)
        //{
        //    star += "*";
        //    print(star);
        //}

        // Ǯ�� 3 �����߰�
        //string stars = "";
        //for (int i = 0; i < 5; i++)
        //{            
        //    for (int j = 0; j < i+1; j++)
        //    {
        //        stars += "*";
        //    }
        //    stars += "\n";
        //}
        //print(stars);
        #endregion

        #region �α� ���
        //print("Hello World!");
        //Debug.Log("Hello World!"); //Ȯ��
        //Debug.LogWarning("Hello World!"); //���ǹ� �ȿ� ���� ���ƾ��� ��
        //Debug.LogError("Hello World!");

        #endregion
        
        void Update()
        {

        }
    }
}