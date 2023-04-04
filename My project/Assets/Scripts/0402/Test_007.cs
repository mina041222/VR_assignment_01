using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_007 : MonoBehaviour
{

    void SayHello()                    //SayHello 함수를 선언
    {
        Debug.Log("Hello");
    }
    void CallName(string name)         //callName 함수 선언 (string 변수의 인수(name)를 가짐)
    {
        Debug.Log("Hello" + name);
    }
    int Add(int a, int b)              //Add 함수 선언 (인수, 반환값) 반환값, 선언할때 (int)
    {
        int c = a + b;                 //c라 int 변수 생성 A + B 값을 입력
        return c;                      //값을 함수 반환 값으로 넘김 (return)
    }

    void Start()
    {
        SayHello();                    //함수를 실행
        SayHello();                    //함수를 실행
        CallName("TOM");               //함수를 실행 string 피라미터 TOM을 입력
        CallName("SAM");               //함수를 실행 string 피라미터 SAM을 입력
        int answer = Add(2, 5);        //변수를 int answer 선언하고 함수 의 반환값을 입력
        Debug.Log(answer);            
    }
}
