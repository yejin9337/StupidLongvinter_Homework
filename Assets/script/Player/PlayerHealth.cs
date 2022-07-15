using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    public void Die()
    {
        gameObject.SetActive(false); //비활성화 되는 순간 모든 업데이트 중지
    }

    private void OnTriggerEnter(Collider other)
    {
        if (null != other.GetComponent<Bullet>())
        {
           Die();
        }
    }
}
