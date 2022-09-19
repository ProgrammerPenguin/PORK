using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeReference]
    private float MoveSpeed = 5f;

    private PlayerInput _playerInput;

    private void Awake()
    {
        _playerInput = GetComponent<PlayerInput>();
    }

    private void Update()
    {
        move();
    }
    private void move()
    {
        float movementAmount = MoveSpeed * Time.deltaTime;
        float ForwardBackMove = _playerInput.ForwardBack;
        float LeftRightMove = _playerInput.LeftRight;

        transform.Translate(new Vector3(movementAmount * LeftRightMove, 0f, movementAmount * ForwardBackMove));
    }

}