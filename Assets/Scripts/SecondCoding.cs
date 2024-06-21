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
        #region 조건문 작성법
        // 조건문 
        // if(조건식)
        // {
        //  조건이 참일 때 해야 할 일
        // }
        // else if(조건식)
        // {
        //  두번째 조건식이 참일 때 해야할 일
        // }
        // else
        // {
        //  앞에 있는 모든 조건들이 다 성립하지 않을 때 해야할 일
        // }
        #endregion

        #region 논리 연산자  Example 1
        //if (age1 > age2)
        //{
        //    print("age1 이 age2 보다 나이가 더 많습니다.");
        //}
        //if (age1 < age2)
        //{
        //    print("age1 이 age2 보다 나이가 적습니다..");
        //}
        //if (age1 <= age2)
        //{
        //    print("age1 이 age2 보다 나이가 같거나 많습니다.");
        //}
        //if (age1 >= age2)
        //{
        //    print("age1 이 age2 보다 나이가 같거나 적습니다.");
        //}
        //if (age1 == age2)
        //{
        //    print("age1 이 age2 와 나이가 같습니다.");
        //}
        //if (age1 != age2)
        //{
        //    print("age1 이 age2 와 나이가 같지 않습니다.");
        //}

        // age1의 나이를 기준으로 10대 부터 40대까지로 어느 곳에 해당하는지를 출력한다.
        // 예)"age1은 30대 입니다.
        // [if]만약 ~~라면 A하고, [else]그렇지 않으면 B하겠다.
        //if (age1 < 20)
        //{
        //    print("age1은 10대 입니다");
        //}
        //else if (age1 < 30)
        //{
        //    print("age1은 20대 입니다");
        //}
        //else if (age1 < 40)
        //{
        //    print("age1은 30대 입니다");
        //}
        //else if (age1 < 50)
        //{
        //    print("age1은 40대 입니다");
        //}
        //else
        //{
        //    print("age1은 50세 이상 입니다");
        //}

        //if(age1 >= 20)
        //{
        //    print("age1의 나이는 20살 이상입니다");
        //}
        //else
        //{
        //    print("age1의 나이는 20살 미만입니다.");
        //}

        // 만약 ~~라면 ~~하고, 
        // [else]그렇지 않고 [if]만일 ~~라면 ~~하고
        // ... 
        // 그렇지 않고 만일 else if 이것이 참이면 밑에 있는 else는 하지 않는다.
        // 


        // 논리 연산자
        // And 연산자
        // A 조건식과 B 조건식이 둘 다 참일 경우 True , 둘 중 하나라도 거짓이면 False [if(A 조건식 && B 조건식)]

        // or 연산자
        // A 조건식과 B 조건식이 하나라도 True이면 True 둘 다 false 일경우 false [if(A 조건식 || B 조건식)]

        // if(남성[T]&& 30대[T]&& 사무직[F]) = false
        //  
        // 상태 [달리기-키를 같이 눌렀을 때, 걷기-키를 하나만 눌렀을 때, 정지-키를 안 눌렀을 때]
        // shift키를 눌렀T / 안눌렀 F , W 눌렀 T, 안눌렀 F 
        // TT = 달리기
        // FT = 걷기
        // FF = 정지


        // 움직일 때는 ~~ 하겠다. //진리표 검색
        // 하나라도 T면 T
        // T or T-T
        // F or T - T
        // F or F - F
        #endregion

        #region And, Or 조건  Example 2
        // 1. And 조건
        // 만일, 성별이 여성이고 나이가 20살 이상일 경우
        // "성인 여성입니다" 라고 출력한다.
        //if (isMan == false && age1 >= 20)
        //{
        //    print("성인 여성입니다.");
        //}
        //else
        //{
        //    print("미성년자이거나, 남성입니다.");
        //}

        // 2. Or 조건
        // 만일, 움직이는 경우라면 "이동 중입니다."라고 출력하고,
        // 그렇지 않으면, "정지한 상태입니다. " 라고 출력한다.
        //if (runState == true || walkState == true)
        //{
        //    print("이동 중입니다");
        //}
        //else
        //{
        //    print("정지한 상태입니다. ");
        //}


        //@ bool 변수를 조건문의 조건으로 넣었을 때 생략 방법
        //위 아래는 같은 표현이다.
        // if (runState == true)
        // if(runState)

        // if(runState == false)
        // if(!runState)




        #endregion

        #region 반복문 작성법
        // 반복문
        // for문, while문
        // 1. 같은 기능을 몇 회 반복할 경우
        // 2. 대량의 데이터를 관리, 검색등의 처리를 할 때
        // for(시작변수 선언및 초기화 [0번으로 시작하는 것을 일반적] ; 종료 조건식[카운트를 언제까지 할 것인지]; 증감식[+,-])
        // {
        // 반복할 수행할 내용
        // }
        // 함수 안에서 사용, 조건문도 마찬가지
        // 상수 보다는 변수로 하기

        #endregion

        #region 예제 1 누적식
        // 1 부터 10 까지 모든 정수를 출력한다. 
        //for (int i = 0; i < 20; i = i+1)
        //{
        //    print(i + 1);
        //}

        // 1 부터 100까지 다 더한 값을 sum이라는 변수에 저장해서 출력한다. 답 : 5,050
        //for (int i = 1; i <= endcount 또는 100; i++)
        //{
        //    sum += i;
        //}
        //print(sum);

        //for (int i = 0; i <= endcount 또는 100; i = i + 1)
        //{
        //    sum += i;
        //}
        //print(sum);

        //for (int i = 0; i < endcount; i++)
        //{
        //    sum += i + 1;
        //}
        //print(sum);

        // 누적식
        //int num = 0;
        //num = num + 1;
        //num += 1;
        //num++;
        //num--;

        // 1부터 100까지 중에 짝수만 출력한다.

        //// 20번 반복한다.
        //for(int i = 0; i < endcount; i++)
        //{
        //    int number = i + 1;
        //    //만약 number에 값을 2로 나눈 나머지가 0이라면,,, 
        //    if(number % 2 == 0)
        //    {
        //        // 그 넘버를 출력한다.
        //        print(number);
        //    }
        //}

        //for (int i = 0; i < endcount; i++)
        //{
        //    int number = i + 1;
        //    //만약 number에 값을 2로 나눈 나머지가 1이라면,,,
        //    if (number % 2 == 1)
        //    {
        //        // 그 넘버를 출력한다.
        //        print(number);
        //    }
        //}
        #endregion

        #region 예제 2

        //나의 답
        // 0부터 endCount 전까지 짝수만 출력한다. 그런데 출력된 짝수의 수가 10개에 도달하면 반복을 종료한다.  
        //for (int i = 0; i < endcount; i++)
        //{
        //    int count = 0;
        //    // numbers가 짝수인지 확인
        //    if (i % 2 == 0 && i < 20)
        //    {
        //        print(i);
        //        if (count > 10)
        //        {
        //            count++;
        //            //짝수의 수가 10개에 도달하면 반복을 종료
        //            break;
        //        }
        //    }    
        //}

        // 강사님 답
        // 0부터 endCount 전 까지 반복한다.
        //for (int i = 0; i < endcount; i++)
        //{
        //    // 증가되는 값에서 2로 나눈 나머지가 0인 경우에는 출력한다.
        //    if(i % 2 == 0)
        //    {
        //        print(i);
        //        // printcount 변수에 출력한 횟수를 증가 시킨다.
        //        printCount++;
        //        // 만약, printcount의 값이 10에 도달하면 반복을 종료한다.
        //        if(printCount >= printMax)
        //        {
        //            break;
        //        }
        //    }
        //}



        #endregion

        #region for문과 for(이중중첩까지만), if문은 서로 중첩해서 사용가능

        // 만일, 성별이 남성이면서, 나이가 20세 이상인 경우
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

        #region 문제1 * 피라미드 만들기

        // *
        // **
        // ***
        // ****
        // *****

        // 풀이1
        //int n = 5;
        //for (int i = 1; i <= n; i++)
        //{
        //    print(new string('*', i));
        //}

        // 풀이 2 
        //string star = "";
        //for(int i = 0; i < 5; i++)
        //{
        //    star += "*";
        //    print(star);
        //}

        // 풀이 3 개행추가
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

        #region 로그 찍기
        //print("Hello World!");
        //Debug.Log("Hello World!"); //확인
        //Debug.LogWarning("Hello World!"); //조건문 안에 쓰지 말아야할 것
        //Debug.LogError("Hello World!");

        #endregion
        
        void Update()
        {

        }
    }
}