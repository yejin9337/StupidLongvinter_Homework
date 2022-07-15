using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBulletSpawner : MonoBehaviour
{
    public GameObject BulletPrefab;
    public Transform Player;
    private float rand = 0f;
    private float timer = 0f;
    private float dotValue = 0f;
    public float angleRange = 60f;
    public bool HasDetectedPlayer = false;

    private float distance = 28f;
    private Vector3 direction;

    void Start()
    {
        rand = Random.Range(0.5f, 3.0f);
    }

    void Update()
    {
        dotValue = Mathf.Cos(Mathf.Deg2Rad * angleRange);
        direction = Player.position - transform.position;
        if (direction.magnitude < distance)
        {
            if (Vector3.Dot(direction.normalized, transform.right * -1) > dotValue)
                HasDetectedPlayer = true;

            else
                HasDetectedPlayer = false;
        }
        else
            HasDetectedPlayer = false;

        if (HasDetectedPlayer)
        {
            timer += Time.deltaTime;        

            if (timer >= rand)
            {
                timer = 0f;
                rand = Random.Range(0.5f, 3.0f);
                GameObject bullet = Instantiate(BulletPrefab, transform.position, Quaternion.identity);
                bullet.transform.LookAt(Player);
            }

        }
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.tag == "Player")
    //    {
    //        HasDetectedPlayer = true;
    //    }
    //}

    //void OnTriggerExit(Collider other)
    //{
    //    if (other.tag == "Player")
    //    {
    //        HasDetectedPlayer = false;
    //    }
    //}
}
