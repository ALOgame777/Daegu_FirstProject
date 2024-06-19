using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;

public class FirstCoding : MonoBehaviour
{
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
    void Start()
    {
        // 변수의 사용법
        // 변수 이름 = 값;
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
    // 변수 = 함수이름(변수1, 변수2,...)

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
