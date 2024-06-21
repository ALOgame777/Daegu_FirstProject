using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;

public class ArrayTest : MonoBehaviour
{
    #region 배열(Array)
    // 같은 자료형을 하나로 묶은 것 (1개의 변수인 양 처리)
    // int[] ages; int 여러개를 넣을 수 있음
    // index 번호만 알면 됨
    // string[] names = new string[10];
    // int[] ages = new int[10]; o , int[] ages; x
    // 주의 할 것 : 반드시 명시적으로 몇칸인지 선언하기
    // 배열 변수의 선언 (반드시 총 갯수를 지정)
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

        // ages 배열 변수에서 값이 50이 넘는 값의 갯수를 구하자
        int count = 0;
        for (int i = 0; i < ages.Length; i++)
        {
            if(ages[i] > 50)
            {
                count++;
            }
        }
        print("ages 배열에서 50이 넘는 인덱스의 총 갯수는 : " + count.ToString());


    }

    void Update()
    {
        
    }
}
