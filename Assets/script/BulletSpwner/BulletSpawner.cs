using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject BulletPrefab;
    public Transform Player;
    private float turn = 0.05f;
    private float rand = 0f;
    private float timer = 0f;
    public bool HasDetectedPlayer = false;
    
    

    void Start()
    {
        rand = Random.Range(0.5f, 3.0f);
    }

    void Update()
    {
        if (HasDetectedPlayer)
        {
            timer += Time.deltaTime;
            transform.LookAt(Player);

            if (timer >= rand)
            {
                timer = 0f;
                rand = Random.Range(0.5f, 3.0f);
                GameObject bullet = Instantiate(BulletPrefab, transform.position, Quaternion.identity);
                bullet.transform.LookAt(Player);
            }

        }
        else
        {
            transform.Rotate(0f, turn, 0f);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            HasDetectedPlayer = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
             HasDetectedPlayer = false;
        }
    }
}
