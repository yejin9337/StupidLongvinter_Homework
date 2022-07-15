using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float Speed = 1f;
    public bool UseSpeed = false;
    private PlayerInput _input;
    public Rigidbody _rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        // _input�� ���� �Ҵ��Ѵ�
        _input = GetComponent<PlayerInput>();
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float xSpeed = _input.X * Speed;
        float zSpeed = _input.Y * Speed;

        if(UseSpeed)
        {
            _rigidbody.velocity = new Vector3(xSpeed, 0f, zSpeed);
        }
        else
        _rigidbody.AddForce(xSpeed, 0f, zSpeed);

    }
}
