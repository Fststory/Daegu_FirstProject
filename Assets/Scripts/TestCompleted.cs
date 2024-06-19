using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestComplited : MonoBehaviour
{
    // Unity 내에서 C# Script 생성 및 주의사항을 테스트 해보았습니다.

    // Start is called before the first frame update
    void Start()
    {
        int a = 1;
        int b = 2;
        float result = (float)a / (float)b;
        print(result);
        // int a,b & float result => 0
        // (float)a,b & float result => 0.5

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
