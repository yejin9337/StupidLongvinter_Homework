using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    //������Ƽ�� Bool Ÿ���� Up, Down, Left, Right �����

    public float X { get; private set; }
    public float Y { get; private set; }
    // Update is called once per frame
    void Update()
    {
        // ���� ���� ������, �⺻ ������ �ʱ�ȭ
        X = Y = 0f;

        //if(�÷��̾ ��� ���� ��)
        X = Input.GetAxis("Horizontal");
        Y = Input.GetAxis("Vertical");

        //Down = Input.GetKey(KeyCode.DownArrow);
        //Left = Input.GetKey(KeyCode.LeftArrow);
        //Right = Input.GetKey(KeyCode.RightArrow);
    }
}
