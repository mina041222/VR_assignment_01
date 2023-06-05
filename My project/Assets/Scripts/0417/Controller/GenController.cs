using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenController : MonoBehaviour
{

    public GameObject MonsterTemp;          //���� �������� �־��ش�. 

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1)) //���콺 ��ư �������� �������� 
        {
            Ray cast = Camera.main.ScreenPointToRay(Input.mousePosition);   //2D ����� ī�޶󿡼� 3D ���� ��ǥ�� ���ؼ� Ray�� ����

            RaycastHit hit;                         //Hit �������� ���� ����

            if (Physics.Raycast(cast, out hit))      //out �μ��� hit�� Ray�� ����� ���� �־��ش�. 
            {
                if (hit.collider.tag == "Ground")            //hit�Ѱ��� Tag �� Ground �϶�
                {
                    GameObject temp = (GameObject)Instantiate(MonsterTemp);         //���� ����
                    temp.transform.position = hit.point + new Vector3(0.0f, 1.0f, 0.0f); //���� ���� ��ġ ��ǥ�� ����
                }

                Debug.DrawLine(cast.origin, hit.point, Color.red, 2.0f); //����� ���� ������ 2�� ���� �׷��ش�. 

                Debug.Log("HIT => " + hit.collider.name);        //hit �� ��ü�� name�� ������ 
            }

        }
    }
}
