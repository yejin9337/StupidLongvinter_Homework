using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    //프로퍼티로 Bool 타입의 Up, Down, Left, Right 만들기

    public float X { get; private set; }
    public float Y { get; private set; }
    // Update is called once per frame
    void Update()
    {
        // 이전 값을 날리고, 기본 값으로 초기화
        X = Y = 0f;

        //if(플레이어가 살아 있을 때)
        X = Input.GetAxis("Horizontal");
        Y = Input.GetAxis("Vertical");

        //Down = Input.GetKey(KeyCode.DownArrow);
        //Left = Input.GetKey(KeyCode.LeftArrow);
        //Right = Input.GetKey(KeyCode.RightArrow);
    }
}
