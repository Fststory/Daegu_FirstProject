using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    SwordMan fighter1;
    SwordMan fighter2;
    SwordMan fighter3;
    int number = 10;
    Transform trans;

    void Start()
    {
        #region 클래스 인스턴스(객체) 생성
        //fighter = new SwordMan();
        //fighter.Move();
        //fighter.hp = 200;
        //fighter.attackPower = 10;
        //fighter.Attack("플레이어");
        #endregion
        //string numberText = number.ToString();

        #region 생성자(Constructor) 함수 연습
        fighter1 = new SwordMan(50, 5.5f, "약한 검사");
        fighter2 = new SwordMan(100, 8.0f, "조금 강한 검사");
        fighter3 = new SwordMan(250, 13.7f, "완전 쎈 검사");

        //fighter1.name = "약한 검사";
        //fighter1.Move();

        //fighter2.name = "조금 강한 검사";
        //fighter2.Move();

        //fighter3.name = "완전 쎈 검사";
        //fighter3.Move();
        //fighter3.Attack("플레이어");
        #endregion


        SwordMan fighter = new SwordMan(200, 10, "최고");

        // Property를 사용하여 변수에 접근하기
        fighter.healthPoint = 500;
        print(fighter.healthPoint);

        // 함수를 사용하여 변수에 접근하기
        fighter.SetHP(500);
        int hp = fighter.GetHP();
        print(hp);

        

        //Maze maze = new Maze();

        //fighter.Move();
        //maze.Move();

        print(number);  // 10
    }

    void Update()
    {
        
    }

    void TestFunction()
    {
        for (int i = 0; i < 3; i++)
        {
            int number1 = 0;
            number1 += 10;
            print(number1);
        }

        int number = 0;
        for (int i = 0; i < 3; i++)
        {
            number = 0;
            number += 10;
            print(number);

            // 전역 변수를 부르기
            //this.number = 100;
        }
    }
}
