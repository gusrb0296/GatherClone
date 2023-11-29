using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateController : MonoBehaviour
{
    private PlayerInputController _controller;

    [SerializeField] private Animator _anim;

    private void Awake()
    {
        _controller = GetComponent<PlayerInputController>();
    }

    private void Start()
    {
        _controller.OnMoveEvent += AnimWalk;
    }

     void AnimWalk(Vector2 direction)
    {
        _anim.SetBool("IsWalk", direction.magnitude > 0f);
    }
}
