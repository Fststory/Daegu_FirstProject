using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstCoding : MonoBehaviour
{
    // ������ ���� �����ϱ�
    public int numberInt1 = 5;
    public int numberInt2 = 3;
    int numberSum;
    int numberRemainder;
    int numberSubtract;
    int numberMultiply;
    float numberDivide;

    // �Ǽ��� ���� �����ϱ�
    public float numberFloat1;
    public float numberFloat2;
    float numberResult;

    // ���ڿ� ���� �����ϱ�
    public string name = "�迵ȣ ";
    string job = "���λ����";

    // ���� ���� �����ϱ�
    public bool isMan;

    // Start is called before the first frame update
    void Start()
    {
        // ������ ����
        // ���� �̸� = ��;
        //numberSum = numberInt1 / numberInt2;
        //numberRemainder = numberInt1 % numberInt2;
        //number = 50;
        //number2 = 3.141592f;
        //name = "�迵ȣ ŷ��¯";
        //isMan = false;

        //numberResult = (float)numberInt1 + (float)numberInt2;
        // ��Ģ ������: + - * ? %

        // ���ڿ� + ���ڿ� -> �� ���ڿ��� ����ȴ�.
        // ���� �Ǵ� �Ǽ��� ���ڿ��� ����ȯ�ϰ� ���� �� : ������.ToString()
        //string result = name + numberInt1.ToString();
        //print(result);
        //print(numberRemainder);

        // numberInt1�� numberInt2 ������ �հ� ���� ����Ѵ�.
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

    // �Լ� ����
    // ��ȯ_�ڷ��� �Լ�_�̸� (�Ű�����1, �Ű�����2, ...)
    // {
    //      �� ��
    // }

    // �� ������ �Է� �޾Ƽ� �� �� ���� �հ� ���� ���� ���·� ��ȯ�ϴ� �Լ��� ����� �ʹ�!
    int Sum(int num1, int num2)
    {
        return num1 + num2;
    }

    // ����, ����, ������(�� ��ȯ)
    // Subtract, Multiply, Divide

    // �� ������ �Է� �޾Ƽ� �� �� ���� ���� ���� ���·� ��ȯ�ϴ� �Լ��� ����� �ʹ�!
    int Subtract(int num1, int num2)
    {
        return num1 - num2;
    }
    
    // �� ������ �Է� �޾Ƽ� �� �� ���� ���� ���� ���·� ��ȯ�ϴ� �Լ��� ����� �ʹ�!
    int Multiply(int num1, int num2)
    {
        return num1 * num2;
    }
    
    // �� ������ �Է� �޾Ƽ� �� �� ���� ������ ���� ���� �Ǽ� ���·� ��ȯ�ϴ� �Լ��� ����� �ʹ�!
    // �Է¹��� ������ �Ǽ��� �ӽ� ����ȯ�� �Ѵ�.
    float Divide(int num1, int num2)
    {
        return (float)num1 / (float)num2;
    }


}
