using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : CharacterController
{
    public Animator Anim;
    private Camera _camera;

    
    private void Awake()
    {
        _camera = Camera.main;
        //Anim = GetComponent<Animator>();
    }
    public void OnMove(InputValue value)
    {
        Vector2 moveInput = value.Get<Vector2>().normalized;
        CallMoveEvent(moveInput);
        
        if (moveInput.x == 0 && moveInput.y ==0)
            Anim.SetBool("IsWalk", false);
        else
            Anim.SetBool("IsWalk", true);
    }

    public void OnLook(InputValue value)
    {
        Vector2 newAim = value.Get<Vector2>();
        Vector2 worldPos = _camera.ScreenToWorldPoint(newAim);
        newAim = (worldPos - (Vector2)transform.position).normalized;
        
        if(newAim.magnitude >= .9f)
        {
            CallLookEvent(newAim);
        }
    }
}
