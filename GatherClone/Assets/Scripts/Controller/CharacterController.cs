using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterController : MonoBehaviour
{
    public event Action<Vector2> OnMoveEvent;
    public event Action<Vector2> OnLookEvent;
    public void CallMoveEvent(Vector2 directon)
    {
        OnMoveEvent?.Invoke(directon);
    }
    public void CallLookEvent(Vector2 directon)
    {
        OnLookEvent?.Invoke(directon);
    }

    
}
