using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordMan : MonoBehaviour
{
    #region getsetProperty
    //public int healthPoint
    //{
    //    get // �о����
    //    {
    //        return hp;
    //    }
    //    set // ����
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
    public string myname = "�˰�";

    // ������(Constructor) �Լ�
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
        print(myname + "(��)�� �̵��մϴ�!");
    }

    public float Attack(string targetName)
    {
        print(targetName + "���� " + attackPower.ToString() + "��ŭ ���ظ� �ݴϴ�!");
        return attackPower;
    }

    void Die()
    {
        print("����߽��ϴ�.");
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
