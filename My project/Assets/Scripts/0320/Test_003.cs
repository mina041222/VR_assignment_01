using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_003 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string str1 = "happy";           //string 형 str1 선언 후 happy 값 입력
        string str2 = "birtheday";       //string 형 str2 선언 후 birthday 값 입력
        string message;                  //string 형 message 선언

        message = str1 + str2;           //message에 str1 , str2 문자열들 더함
        Debug.Log(message);              //console.log 창에 message 출력

        str1 += str2;                    //str1 = str1 + str2 의 축약
        Debug.Log(str1);                 //console.log 창에 str1 출력 
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
