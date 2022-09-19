using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public float ForwardBack { get; private set; } // 감지된 움직임 입력값
    public float LeftRight { get; private set; } // 감지된 회전 입력값

    // 매프레임 사용자 입력을 감지
    private void Update()
    {
        ForwardBack = Input.GetAxis("Vertical");
        LeftRight = Input.GetAxis("Horizontal");
    }
}