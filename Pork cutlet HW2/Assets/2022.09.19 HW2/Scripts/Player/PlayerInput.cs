using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public float ForwardBack { get; private set; } // ������ ������ �Է°�
    public float LeftRight { get; private set; } // ������ ȸ�� �Է°�

    // �������� ����� �Է��� ����
    private void Update()
    {
        ForwardBack = Input.GetAxis("Vertical");
        LeftRight = Input.GetAxis("Horizontal");
    }
}