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
        #region 조건문 작성법
        // 조건문
        // if(조건식)
        //{
        //  조건이 참일 때 해야할 일
        //}
        // else if(조건식)
        //{
        // 두 번째 조건식이 참일 때 해야할 일
        //}
        //else
        //{
        // 앞에 있는 모든 조건들이 다 성립하지 않을 때 해야할 일
        //}
        #endregion

        #region Example 1
        //if (age1 == age2)
        //{
        //    print("age1이 age2와 나이가 같습니다.");
        //}

        //if (age1 > age2)
        //{
        //    print("age1이 age2보다 나이가 많습니다.");
        //}

        //if (age1 < age2)
        //{
        //    print("age1이 age2보다 나이가 어립니다.");
        //}

        //if (age1 != age2)
        //{
        //    print("age1이 age2와 나이가 서로 다릅니다.");
        //}

        // age1의 나이를 기준으로 10대부터 40대까지로 어느 곳에 해당하는지를 출력한다.
        // 예) "age1은 30대 입니다."
        //if (age1 < 20)
        //{
        //    print("age1은 10대입니다.");
        //}
        //else if (age1 < 30)
        //{
        //    print("age1은 20대입니다.");
        //}
        //else if (age1 < 40)
        //{
        //    print("age1은 30대입니다.");
        //}
        //else if (age1 < 50)
        //{
        //    print("age1은 40대입니다.");
        //}
        //else
        //{
        //    print("age1의 나이는 50세 이상입니다.");
        //}

        //if (age1 >= 20)
        //{
        //    print("age1의 나이는 20살 이상입니다.");
        //}
        //else
        //{
        //    print("age1의 나이는 20살 미만입니다.");
        //}
        // else문은 if문에 종속적이다. (else는 조건을 갖지 않기에)
        #endregion

        #region Example 2
        // 1. And 조건
        // 만일, 성별이 여성이고 나이가 20살 이상일 경우
        // "성인 여성입니다."라고 출력한다.
        //if (isMan == false && age1 >= 20)
        //{
        //    print("성인 여성입니다.");
        //}
        //else
        //{
        //    print("미성년자이거나 남성입니다.");
        //}

        // 2, Or 조건
        // 만일, 움직이는 경우라면 "이동 중입니다."라고 출력하고,
        // 그렇지 않으면, "정지한 상태입니다."라고 출력한다.
        //if (runState == true || walkState == true)// == if (runState||walkState)
        //{
        //    print("이동 중입니다.");
        //}
        //else
        //{
        //    print("정지한 상태입니다.");
        //}

        // bool 변수를 조건문의 조건으로 넣었을 때 생략 방법
        // if (runState == true)
        // == if (runState)

        // == if (runState == false)
        // if (!runState)

        //if (runState == true || walkState == true)
        // == if (runState||walkState)

        #endregion

        #region 반복문 작성법
        // 반복문
        // for ( 시작 변수 선언 및 초기화; 종료 조건식; 증감식 )
        // {
        //      반복해서 수행할 내용
        // }

        // 1부터 10까지 모든 정수를 출력한다.
        //for(int i = 0; i < 20; i = i + 1)
        //{
        //    print(i + 1);
        //}

        // 1부터 100까지 다 더한 값을 sum이라는 변수에 저장해서 출력한다.
        //for(int i = 0; i < endCount; i++)
        //{
        //    sum += i + 1;
        //}
        //print(sum);

        // 누적식
        //int num = 0;
        // num = num + 1;
        // num += 1;
        //num++;
        //num--;
        // 초기값이 없는 변수에서는 사용불가


        // 1부터 20까지 중에 짝수만 출력한다.

        // 20번 반복한다.
        //for(int i = 0; i < endCount; i++)
        //{
        //    int number = i + 1;
        //    // 만일, number의 값을 2로 나눈 나머지가 0이라면...
        //    if (number % 2 == 0)
        //    {
        //        // 해당 number를 출력한다.
        //        print(number);
        //    }

        //}
        #endregion
        // 예제
        // 0부터 endCount 전까지 짝수만 출력한다. 그런데 출력된 짝수의 수가 10개에 도달하면 반복을 종료한다.
        #region MyAnswer
        //// endCount번 반복한다.
        //for (int i = 0; i < endCount; i++)
        //{
        //    // 만일, i의 값을 2로 나눈 나머지가 0이라면...
        //    if (i % 2 == 0)
        //    {
        //        // 해당 i를 출력한다.
        //        print(i);
        //        if (i / 2 == 9)
        //        {
        //            break;
        //        }
        //    }            
        //}
        #endregion
        #region TeacherAnswer
        //// 0부터 endCount 전까지 반복한다.
        //for (int i=0; i < endCount; i++)
        //{
        //    // 증가되는 값에서 2로 나눈 나머지가 0인 경우에는 출력한다.
        //    if (i % 2 == 0)
        //    {
        //        print(i);
        //        // printCount 변수에 출력한 횟수를 증가시킨다.
        //        printCount++;
        //        // 만일, printCount의 값이 10에 도달하면 반복을 종료한다.
        //        if (printCount >= printMax)
        //        {
        //            break;
        //        }
        //    }
        //}
        #endregion

        #region 중첩
        // for문과 if문은 서로 중첩해서 사용할 수 있다.

        // 만일, 성별이 남성이면서, 나이가 20세 이상인 경우
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

        #region 별 찍기 문제
        // *
        // **
        // ***
        // ****
        // *****
        #endregion
        #region 내가 풀다 만 것
        // 아래층으로 갈 수록 별이 하나씩 추가되어 출력된다.
        //for(int i = 0; i < 5; i++)
        //{
        //    for(int j = 0; j <= i; j++)
        //    {
        //        print("");
        //    }
        //}
        #endregion
        #region 쌤 풀이
        // <풀이 1번>
        //string star = "";
        //for(int i = 0; i < 5; i++)
        //{
        //    star += "*";
        //    print(star);
        //}

        // <풀이 2번>
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
