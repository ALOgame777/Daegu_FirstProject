using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;

public class ArrayTest : MonoBehaviour
{
    #region �迭(Array)
    // ���� �ڷ����� �ϳ��� ���� �� (1���� ������ �� ó��)
    // int[] ages; int �������� ���� �� ����
    // index ��ȣ�� �˸� ��
    // string[] names = new string[10];
    // int[] ages = new int[10]; o , int[] ages; x
    // ���� �� �� : �ݵ�� ��������� ��ĭ���� �����ϱ�
    // �迭 ������ ���� (�ݵ�� �� ������ ����)
    #endregion
    int[] ages = new int[10];


    
    void Start()
    {
        //ages[0] = 20;
        //ages[1] = 50;
        //ages[8] = 15;
        //ages[1] = 30;

        //print(ages[1]);

        for (int i = 0; i < ages.Length; i++)
        {
            ages[i] = i * 10;
        }
        for (int i = 0; i < ages.Length; i++)
        {
            print("index : " + i.ToString() + ". value: " + ages[i].ToString());    
        }

        // ages �迭 �������� ���� 50�� �Ѵ� ���� ������ ������
        int count = 0;
        for (int i = 0; i < ages.Length; i++)
        {
            if(ages[i] > 50)
            {
                count++;
            }
        }
        print("ages �迭���� 50�� �Ѵ� �ε����� �� ������ : " + count.ToString());


    }

    void Update()
    {
        
    }
}
