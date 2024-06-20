using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;

public class FirstCoding : MonoBehaviour
{

    // 접근 한정자, 제한자(Access Modifier)
    // public -> 공개된, 모두가 자유롭게 읽기와 쓰기 가능 , private -> 비공개, 해당 클래스내에서만 읽기/쓰기 가능
    // protected 
    // 변수 또는 함수, 클래스 앞에 작성 
    // 기본값 -> private

    // 자료형 정수형 int, 실수형 float, 문자열 string, 논리형 bool 
    // (float)변수를 잠시 ()안에 넣고 계산하는 것[임시]
    // 대입연산자의 우측에만 있어야 함 
    // (float)변수 > (int)변수 OverFlow : float을 임시변수 int에 넣을 때 흘러넘치는 것
    // 변수.ToString() 반환자료형이 있어서 String으로 반환

    // 리플렉션 : C#에서 처음 나옴, c++, C에도 도입됨
    // 함수이름, 클래스 이름을 앎 > 어디에 있는지, 변수도 모르겠고 아는 내용, public 만 검색
    // 유니티에서는 거꾸로 검색
    // 델리게이트, 리플렉션은 처음 나올 때는 놀람
    
    // 조건문
    // 만일 ~~라면, ~~ 하겠다.
    // 만약 스페이스바를 누르면 점프한다, 만약 닿으면 문을 열리게 하겠다.
    // if(조건식)
    //
    //{
        // 할 조건 참(True)일 경우에 해야할 것
    //}

    // 연산자 (사칙연산자, 대입연산자)
    // 비교 연산자
    // 6개 a > b , a >= b, a < b, a <= b, a == b , a != b
    


    // 정수형 변수 선언하기 
    public int numberInt1;
    public int numberInt2;
    int numberSum = 0;
    int numberRemainder = 0;

    // 실수형 변수 선언하기
    public float numberFloat1;
    public float numberFloat2;
    float numberResult;

    // 문자열 변수 선언하기
    public string name = "이준수";
    string job = " 개인사업자";


    // 논리형 변수 선언하기 //조건문과 같이 사용
    private bool isMan;

    // Start is called before the first frame update
    // Start 함수는 플레이 되면 처음 한 번만 실행되는 함수입니다.

    void Start()
    {
        // 변수의 선언
        // 변수 이름 = 값;
        // 자료형 변수명;
        // 변수의 호출
        // 변수이름 = 값;, 변수명;
        //numberSum = numberInt1 + numberInt2;
        //numberRemainder = numberInt1 % numberInt2;
        /*number = 50;
        number2 = 3.141592f;
        name = "이준수";
        isMan = false;
        
        print(number);
        print(number2);
        print(name);
        */

        //numberResult = numberInt1 + numberFloat1;

        //number = 50;
        //name = "천재";

        //numberResult = (float)numberInt1 + (float)numberInt2;
        // 사칙 연산자 : + - * / %

        // 문자열 + 문자열 -> 두 문자열이 연결된다.
        // 정수 또는 실수를 문자열로 형변환하고 싶을 때 : 변수명.ToString()
        //string result = name + numberInt1.ToString();
        //print(result);
        //print(numberSum);
        //print(numberRemainder);


        //numberInt1과 numberInt2 변수의 합계 값을 출력한다.
        //numberSum = Sum(10, 20);
        numberSum = Sum(numberInt1, numberInt2);
        print(numberSum);
        
        int numberSubtract = Subtract(numberInt1, numberInt2);
        print(numberSubtract);
        
        int numberMultiply = Multiply(numberInt1, numberInt2);
        print(numberMultiply);
        
        int numberDivide = Divide(numberInt1, numberInt2);
        print(numberDivide);
        
        int numberDivideShare = DivideShare(numberInt1, numberInt2);
        print(numberDivideShare);

        numberResult = Dividef(numberInt1,numberInt2);
        print(numberResult);

    }

    // Update is called once per frame
    void Update()
    {

    }

    //함수 선언
    // 반환 자료형 함수 이름 (매개변수1, 매개변수2, ...)
    //{
    //    할 일
    //}

    // 두 정수를 입력 받아서 그 두 수의 합계 값을 반환하는 함수를 만들고 싶다.
    // 짧게 순서로
    int Sum(int num1, int num2)
    {
        return num1 + num2;
    }

    // 함수 사용(호출)법(Call Function)
    // [반환자료형일 경우]변수 = 함수이름(변수1, 변수2,...)
    // 함수이름(); 

    // 두 정수를 입력 받아서 그 두수의 차를 반환하는 함수
    int Subtract(int num1, int num2) 
    {
        return num1 - num2;
    }

    // 두 정수를 입력 받아서 그 두수의 곱셈을 반환하는 함수
    int Multiply(int num1, int num2)
    {
        return num1 * num2;
    }

    // 두 정수를 입력 받아서 그 두수의 나누기의 결과를 반환하는 함수
    int Divide(int num1, int num2)
    {
        return num1 / num2; 
    }

    //두 정수를 입력 받아서 그 두수의 나머지를 반환하는 함수
    int DivideShare(int num1, int num2)
    {
        return num1 % num2;
    }

    //두 정수의 값을 입력 받아서, 두 정수의 나눗셈 결과를 실수 형태로 반환한다.
    // 입력 받은 정수를 실수로 임시 형병환을 한다.
    // 완전히 똑같지는 않다.
    float Dividef(int num1, int num2)
    {
        return (float)num1 / (float)num2;
    }




}
