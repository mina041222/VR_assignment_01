using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class ProjectileMove : MonoBehaviour
{
    public enum PROJECTILETYPE              //�Ѿ� Ÿ�� ������ ���� Enum ����
    {
        PLAYER,
        ENEMY
    }

    public Vector3 launchDirection;
    public PROJECTILETYPE projectileType = PROJECTILETYPE.PLAYER;   //�Ѿ� Ÿ�� ����

    private void OnCollisionEnter(Collision collision)
    {   //���� �浹�� �ı�
        if (collision.gameObject.tag == "Wall")
        {
            Destroy(this.gameObject);
        }
        //���Ϳ� �浹��
        if (collision.gameObject.tag == "Monster")
        {
            //���Ϳ��� �������� �ְ� �������. 
            collision.gameObject.GetComponent<MonsterController>().Damanged(1);
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)         //Trigger �Լ� 
    {   //���� �浹�� �ı�
        if (other.gameObject.tag == "Wall")             //Name -> Tag �� ��ȯ 
        {
            Destroy(this.gameObject);
        }
        //���Ϳ� �浹��
        if (other.gameObject.tag == "Monster" && projectileType == PROJECTILETYPE.PLAYER)
        {
            //���Ϳ��� �������� �ְ� �������. 
            other.gameObject.GetComponent<MonsterController>().Damanged(1);
            other.transform.DOPunchScale(new Vector3(0.5f, 0.5f, 0.5f), 0.1f, 10, 1);
            Destroy(this.gameObject);
        }

        if (other.gameObject.tag == "Player" && projectileType == PROJECTILETYPE.ENEMY)
        {
            //�÷��̾�� �������� �ְ� �������. 
            other.gameObject.GetComponent<PlayerController>().Damanged(1);
            Destroy(this.gameObject);
        }
    }

    private void FixedUpdate()
    {
        //�ð���� �̵� �� float ������ ����
        float moveAmount = 3 * Time.fixedDeltaTime;
        //launchDirection �������� �߻�ü �̵� (Translate) �̵� ��Ű�� �Լ�
        transform.Translate(launchDirection * moveAmount);
    }
}