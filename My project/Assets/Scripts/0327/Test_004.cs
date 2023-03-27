using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class Test_004 : MonoBehaviour
{
    public int hp = 180;         //변수 hp 선언 180 값 입력 (public은 인스팩터 창에서 보이게 하기 위하여 사용)
    public Text hpText;
    public Text hpStatus;           //hp 숫자 표시 UI

    // Update is called once per frame
    void Update()
    {
        hpStatus.text = hp.ToString();     //hp 숫자 표시 toString은 정수를 문자열로 변환
        if(Input.GetMouseButtonDown(0))    //0은 왼쪽 클릭 
        {
            hp += 10;
        }
        if(Input.GetMouseButtonDown(1))    //1은 오른쪽 클릭 
        {
            hp -= 10;
        }



        if (hp <= 50)            //변수 hp가 50 이하일때
        {
            //Debug.Log("도망 !!"); //consle.log 창에 도망 이라고 나오게 한다
            hpText.text = "도망 !!";
        }
        else if (hp >= 200)      //변수 hp가 200 이상일 때
        {
            //Debug.Log("공격 !!"); //consle.log 창에 공격이라고 나오게한다
            hpText.text = "공격 !!";
        }
        else                     //위의 두 조건이 아닐때
        {
            //Debug.Log("방어 !!"); //consle.log 창에 방어라고 나오게 한다
            hpText.text = "방어 !!"; 
        }
    }
}
