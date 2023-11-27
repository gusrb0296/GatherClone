using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Look : MonoBehaviour
{
    [SerializeField] private Transform aimRenderer;
    [SerializeField] private SpriteRenderer _characterRenderer;

    private CharacterController _controller;

    private void Awake()
    {
        _controller = GetComponent<CharacterController>();
    }

    private void Start()
    {
        _controller.OnLookEvent += OnAim;
    }

    private void OnAim(Vector2 newAimeDirection)
    {
        RotateAim(newAimeDirection);
    }

    private void RotateAim(Vector2 direction)
    {
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        _characterRenderer.flipX = Mathf.Abs(rotZ) > 90f;
    }

    
}
