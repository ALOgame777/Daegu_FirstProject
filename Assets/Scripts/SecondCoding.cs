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




        #region Example 1
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


        #region Example 2
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
        if (runState == true || walkState == true)
        {
            print("이동 중입니다");
        }
        else
        {
            print("정지한 상태입니다. ");
        }


        //@ bool 변수를 조건문의 조건으로 넣었을 때 생략 방법
        //위 아래는 같은 표현이다.
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