using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;

public class FirstCoding : MonoBehaviour
{
    // ������ ���� �����ϱ� 
    public int numberInt1;
    public int numberInt2;
    int numberSum = 0;
    int numberRemainder = 0;

    // �Ǽ��� ���� �����ϱ�
    public float numberFloat1;
    public float numberFloat2;
    float numberResult;

    // ���ڿ� ���� �����ϱ�
    public string name = "���ؼ�";
    string job = " ���λ����";


    // ���� ���� �����ϱ� //���ǹ��� ���� ���
    private bool isMan;

    // Start is called before the first frame update
    void Start()
    {
        // ������ ����
        // ���� �̸� = ��;
        //numberSum = numberInt1 + numberInt2;
        //numberRemainder = numberInt1 % numberInt2;
        /*number = 50;
        number2 = 3.141592f;
        name = "���ؼ�";
        isMan = false;
        
        print(number);
        print(number2);
        print(name);
        */

        //numberResult = numberInt1 + numberFloat1;

        //number = 50;
        //name = "õ��";

        //numberResult = (float)numberInt1 + (float)numberInt2;
        // ��Ģ ������ : + - * / %

        // ���ڿ� + ���ڿ� -> �� ���ڿ��� ����ȴ�.
        // ���� �Ǵ� �Ǽ��� ���ڿ��� ����ȯ�ϰ� ���� �� : ������.ToString()
        //string result = name + numberInt1.ToString();
        //print(result);
        //print(numberSum);
        //print(numberRemainder);


        //numberInt1�� numberInt2 ������ �հ� ���� ����Ѵ�.
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

    //�Լ� ����
    // ��ȯ �ڷ��� �Լ� �̸� (�Ű�����1, �Ű�����2, ...)
    //{
    //    �� ��
    //}

    // �� ������ �Է� �޾Ƽ� �� �� ���� �հ� ���� ��ȯ�ϴ� �Լ��� ����� �ʹ�.
    // ª�� ������
    int Sum(int num1, int num2)
    {
        return num1 + num2;
    }

    // �Լ� ���(ȣ��)��(Call Function)
    // ���� = �Լ��̸�(����1, ����2,...)

    // �� ������ �Է� �޾Ƽ� �� �μ��� ���� ��ȯ�ϴ� �Լ�
    int Subtract(int num1, int num2) 
    {
        return num1 - num2;
    }

    // �� ������ �Է� �޾Ƽ� �� �μ��� ������ ��ȯ�ϴ� �Լ�
    int Multiply(int num1, int num2)
    {
        return num1 * num2;
    }

    // �� ������ �Է� �޾Ƽ� �� �μ��� �������� ����� ��ȯ�ϴ� �Լ�
    int Divide(int num1, int num2)
    {
        return num1 / num2; 
    }

    //�� ������ �Է� �޾Ƽ� �� �μ��� �������� ��ȯ�ϴ� �Լ�
    int DivideShare(int num1, int num2)
    {
        return num1 % num2;
    }

    //�� ������ ���� �Է� �޾Ƽ�, �� ������ ������ ����� �Ǽ� ���·� ��ȯ�Ѵ�.
    // �Է� ���� ������ �Ǽ��� �ӽ� ����ȯ�� �Ѵ�.
    // ������ �Ȱ����� �ʴ�.
    float Dividef(int num1, int num2)
    {
        return (float)num1 / (float)num2;
    }




}
