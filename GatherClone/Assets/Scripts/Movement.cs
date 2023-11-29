using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private CharacterController _controller;
    [SerializeField] private int _moveSpeed = 250;
    
    private Vector2 _moveDirection = Vector2.zero;
    private Rigidbody2D _rigidbody2D;

    private void Awake()
    {
        _controller = GetComponent<CharacterController>();
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        _controller.OnMoveEvent += Move;
    }

    private void Move(Vector2 direction)
    {
        _moveDirection = direction;
    }

    private void FixedUpdate()
    {
        ApplyMovement(_moveDirection);
    }

    private void ApplyMovement(Vector2 direction)
    {
        direction = direction * _moveSpeed * Time.deltaTime;

        _rigidbody2D.velocity = direction;
    }
}
