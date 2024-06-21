using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayTest : MonoBehaviour
{
    // 배열 변수의 선언(반드시 총 갯수를 지정)
    int[] ages = new int[10];


    void Start()
    {
        //ages[0] = 20;
        //ages[1] = 50;
        //ages[8] = 15;
        //ages[1] = 30;

        //print(ages[1]);

        for(int i = 0; i < ages.Length; i++)
        {
            ages[i] = i * 10;
        }

        for(int i = 0; i < ages.Length; i++)
        {
            print("index: " + i.ToString() + ", value: " + ages[i].ToString());
        }

        // ages 배열 변수에서 값이 50이 넘는 값의 갯수를 구하자.
        int count = 0;

        for(int i = 0; i < ages.Length; i++)
        {
            if (ages[i] > 50)
            {
                count++;
            }
        }

        print("ages 배열에서 50이 넘는 인덱스의 총 개수 : " + count.ToString());
    }

    void Update()
    {
        
    }
}
