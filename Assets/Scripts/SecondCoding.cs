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
    public int endCount = 100;
    public int printMax = 10;
    int sum = 0;
    int printCount = 0;
    void Start()
    {
        #region ���ǹ� �ۼ���
        // ���ǹ�
        // if(���ǽ�)
        //{
        //  ������ ���� �� �ؾ��� ��
        //}
        // else if(���ǽ�)
        //{
        // �� ��° ���ǽ��� ���� �� �ؾ��� ��
        //}
        //else
        //{
        // �տ� �ִ� ��� ���ǵ��� �� �������� ���� �� �ؾ��� ��
        //}
        #endregion

        #region Example 1
        //if (age1 == age2)
        //{
        //    print("age1�� age2�� ���̰� �����ϴ�.");
        //}

        //if (age1 > age2)
        //{
        //    print("age1�� age2���� ���̰� �����ϴ�.");
        //}

        //if (age1 < age2)
        //{
        //    print("age1�� age2���� ���̰� ��ϴ�.");
        //}

        //if (age1 != age2)
        //{
        //    print("age1�� age2�� ���̰� ���� �ٸ��ϴ�.");
        //}

        // age1�� ���̸� �������� 10����� 40������� ��� ���� �ش��ϴ����� ����Ѵ�.
        // ��) "age1�� 30�� �Դϴ�."
        //if (age1 < 20)
        //{
        //    print("age1�� 10���Դϴ�.");
        //}
        //else if (age1 < 30)
        //{
        //    print("age1�� 20���Դϴ�.");
        //}
        //else if (age1 < 40)
        //{
        //    print("age1�� 30���Դϴ�.");
        //}
        //else if (age1 < 50)
        //{
        //    print("age1�� 40���Դϴ�.");
        //}
        //else
        //{
        //    print("age1�� ���̴� 50�� �̻��Դϴ�.");
        //}

        //if (age1 >= 20)
        //{
        //    print("age1�� ���̴� 20�� �̻��Դϴ�.");
        //}
        //else
        //{
        //    print("age1�� ���̴� 20�� �̸��Դϴ�.");
        //}
        // else���� if���� �������̴�. (else�� ������ ���� �ʱ⿡)
        #endregion

        #region Example 2
        // 1. And ����
        // ����, ������ �����̰� ���̰� 20�� �̻��� ���
        // "���� �����Դϴ�."��� ����Ѵ�.
        //if (isMan == false && age1 >= 20)
        //{
        //    print("���� �����Դϴ�.");
        //}
        //else
        //{
        //    print("�̼������̰ų� �����Դϴ�.");
        //}

        // 2, Or ����
        // ����, �����̴� ����� "�̵� ���Դϴ�."��� ����ϰ�,
        // �׷��� ������, "������ �����Դϴ�."��� ����Ѵ�.
        //if (runState == true || walkState == true)// == if (runState||walkState)
        //{
        //    print("�̵� ���Դϴ�.");
        //}
        //else
        //{
        //    print("������ �����Դϴ�.");
        //}

        // bool ������ ���ǹ��� �������� �־��� �� ���� ���
        // if (runState == true)
        // == if (runState)

        // == if (runState == false)
        // if (!runState)

        //if (runState == true || walkState == true)
        // == if (runState||walkState)

        #endregion

        #region �ݺ��� �ۼ���
        // �ݺ���
        // for ( ���� ���� ���� �� �ʱ�ȭ; ���� ���ǽ�; ������ )
        // {
        //      �ݺ��ؼ� ������ ����
        // }

        // 1���� 10���� ��� ������ ����Ѵ�.
        //for(int i = 0; i < 20; i = i + 1)
        //{
        //    print(i + 1);
        //}

        // 1���� 100���� �� ���� ���� sum�̶�� ������ �����ؼ� ����Ѵ�.
        //for(int i = 0; i < endCount; i++)
        //{
        //    sum += i + 1;
        //}
        //print(sum);

        // ������
        //int num = 0;
        // num = num + 1;
        // num += 1;
        //num++;
        //num--;
        // �ʱⰪ�� ���� ���������� ���Ұ�


        // 1���� 20���� �߿� ¦���� ����Ѵ�.

        // 20�� �ݺ��Ѵ�.
        //for(int i = 0; i < endCount; i++)
        //{
        //    int number = i + 1;
        //    // ����, number�� ���� 2�� ���� �������� 0�̶��...
        //    if (number % 2 == 0)
        //    {
        //        // �ش� number�� ����Ѵ�.
        //        print(number);
        //    }

        //}
        #endregion
        // ����
        // 0���� endCount ������ ¦���� ����Ѵ�. �׷��� ��µ� ¦���� ���� 10���� �����ϸ� �ݺ��� �����Ѵ�.
        #region MyAnswer
        //// endCount�� �ݺ��Ѵ�.
        //for (int i = 0; i < endCount; i++)
        //{
        //    // ����, i�� ���� 2�� ���� �������� 0�̶��...
        //    if (i % 2 == 0)
        //    {
        //        // �ش� i�� ����Ѵ�.
        //        print(i);
        //        if (i / 2 == 9)
        //        {
        //            break;
        //        }
        //    }            
        //}
        #endregion
        #region TeacherAnswer
        //// 0���� endCount ������ �ݺ��Ѵ�.
        //for (int i=0; i < endCount; i++)
        //{
        //    // �����Ǵ� ������ 2�� ���� �������� 0�� ��쿡�� ����Ѵ�.
        //    if (i % 2 == 0)
        //    {
        //        print(i);
        //        // printCount ������ ����� Ƚ���� ������Ų��.
        //        printCount++;
        //        // ����, printCount�� ���� 10�� �����ϸ� �ݺ��� �����Ѵ�.
        //        if (printCount >= printMax)
        //        {
        //            break;
        //        }
        //    }
        //}
        #endregion

        #region ��ø
        // for���� if���� ���� ��ø�ؼ� ����� �� �ִ�.

        // ����, ������ �����̸鼭, ���̰� 20�� �̻��� ���
        //if(isMan && age1 >= 20)
        //{

        //}
        //else
        //{

        //}

        //if (isMan)
        //{
        //    if (age1 >= 20)
        //    {

        //    }
        //    else
        //    {

        //    }
        //}

        //for (int i = 2; i < 10; i++)
        //{
        //    for(int j = 1; j < 10; j++)
        //    {
        //        print(i.ToString() + " x " + j.ToString() + " = " + (i * j).ToString());
        //    }
        //}
        #endregion

        #region �� ��� ����
        // *
        // **
        // ***
        // ****
        // *****
        #endregion
        #region ���� Ǯ�� �� ��
        // �Ʒ������� �� ���� ���� �ϳ��� �߰��Ǿ� ��µȴ�.
        //for(int i = 0; i < 5; i++)
        //{
        //    for(int j = 0; j <= i; j++)
        //    {
        //        print("");
        //    }
        //}
        #endregion
        #region �� Ǯ��
        // <Ǯ�� 1��>
        //string star = "";
        //for(int i = 0; i < 5; i++)
        //{
        //    star += "*";
        //    print(star);
        //}

        // <Ǯ�� 2��>
        //for(int i = 0; i < 5; i++)
        //{
        //    string star = "";
        //    for(int j = 0; j < i + 1; j++)
        //    {
        //        star += "*";
        //    }
        //    print(star);
        //}
        #endregion

        //print("Hello World!");
        //Debug.Log("Hello World!");
        //Debug.LogWarning("Hello World!");
        //Debug.LogError("Hello World!");
    }

    void Update()
    {
        
    }
}
