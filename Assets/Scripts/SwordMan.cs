using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordMan : MonoBehaviour
{
    #region getsetProperty
    //public int healthPoint
    //{
    //    get // 읽어오기
    //    {
    //        return hp;
    //    }
    //    set // 설정
    //    {
    //        hp = value;
    //    }

    //}

    //public int healthPoint
    //{
    //    get;
    //    set;
    //}

    public int healthPoint { get; set; }
    #endregion

    protected int hp = 100;
    public float attackPower = 5.5f;
    public string myname = "검객";

    // 생성자(Constructor) 함수
    public SwordMan(int health, float atk, string nickName)
    {
        hp = health;
        attackPower = atk;
        myname = nickName;
    }


    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public virtual void Move()
    {
        print(myname + "(이)가 이동합니다!");
    }

    public float Attack(string targetName)
    {
        print(targetName + "에게 " + attackPower.ToString() + "만큼 피해를 줍니다!");
        return attackPower;
    }

    void Die()
    {
        print("사망했습니다.");
    }

    public int GetHP()
    {
        return hp;
    }

    public void SetHP(int health)
    {
        hp = health;
    }
}
