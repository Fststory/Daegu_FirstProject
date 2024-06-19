using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstCoding : MonoBehaviour
{
    // 정수형 변수 선언하기
    public int numberInt1 = 5;
    public int numberInt2 = 3;
    int numberSum;
    int numberRemainder;
    int numberSubtract;
    int numberMultiply;
    float numberDivide;

    // 실수형 변수 선언하기
    public float numberFloat1;
    public float numberFloat2;
    float numberResult;

    // 문자열 변수 선언하기
    public string name = "김영호 ";
    string job = "개인사업자";

    // 논리형 변수 선언하기
    public bool isMan;

    // Start is called before the first frame update
    void Start()
    {
        // 변수의 사용법
        // 변수 이름 = 값;
        //numberSum = numberInt1 / numberInt2;
        //numberRemainder = numberInt1 % numberInt2;
        //number = 50;
        //number2 = 3.141592f;
        //name = "김영호 킹왕짱";
        //isMan = false;

        //numberResult = (float)numberInt1 + (float)numberInt2;
        // 사칙 연산자: + - * ? %

        // 문자열 + 문자열 -> 두 문자열이 연결된다.
        // 정수 또는 실수를 문자열로 형변환하고 싶을 때 : 변수명.ToString()
        //string result = name + numberInt1.ToString();
        //print(result);
        //print(numberRemainder);

        // numberInt1과 numberInt2 변수의 합계 값을 출력한다.
        //numberSum = Sum(10, 20);
        numberSum = Sum(numberInt1, numberInt2);
        print(numberSum);

        numberSubtract = Subtract(numberInt1, numberInt2);
        print(numberSubtract);

        numberMultiply = Multiply(numberInt1, numberInt2);
        print(numberMultiply);

        numberDivide = Divide(numberInt1, numberInt2);
        print(numberDivide);        

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // 함수 선언
    // 반환_자료형 함수_이름 (매개변수1, 매개변수2, ...)
    // {
    //      할 일
    // }

    // 두 정수를 입력 받아서 그 두 수의 합계 값을 정수 형태로 반환하는 함수를 만들고 싶다!
    int Sum(int num1, int num2)
    {
        return num1 + num2;
    }

    // 뺄셈, 곱셈, 나눗셈(몫 반환)
    // Subtract, Multiply, Divide

    // 두 정수를 입력 받아서 그 두 수의 차를 정수 형태로 반환하는 함수를 만들고 싶다!
    int Subtract(int num1, int num2)
    {
        return num1 - num2;
    }
    
    // 두 정수를 입력 받아서 그 두 수의 곱을 정수 형태로 반환하는 함수를 만들고 싶다!
    int Multiply(int num1, int num2)
    {
        return num1 * num2;
    }
    
    // 두 정수를 입력 받아서 그 두 수를 나눴을 때의 몫을 실수 형태로 반환하는 함수를 만들고 싶다!
    // 입력받은 정수를 실수로 임시 형변환을 한다.
    float Divide(int num1, int num2)
    {
        return (float)num1 / (float)num2;
    }


}
