using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterController : MonoBehaviour
{
    public int Monster_Hp = 5;          //���� HP ����
    public void Damanged(int Damage)    //������ �޴� �Լ� ����
    {
        Monster_Hp -= Damage;           //���� ������ HP�� �ݿ�

        if (Monster_Hp < 0)              //0 ���Ϸ� ��������
        {
            Destroy(this.gameObject);   //���� ������Ʈ �ı�
        }
    }
}
