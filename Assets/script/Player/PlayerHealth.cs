using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    public void Die()
    {
        gameObject.SetActive(false); //��Ȱ��ȭ �Ǵ� ���� ��� ������Ʈ ����
    }

    private void OnTriggerEnter(Collider other)
    {
        if (null != other.GetComponent<Bullet>())
        {
           Die();
        }
    }
}
