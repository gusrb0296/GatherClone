using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    //[SerializeField] private CharacterController _controller;
    [SerializeField] private float smoothing = 0.1f;
    [SerializeField] private Transform player;

    //private Vector2 _moveDirection = Vector2.zero;
    //private void Awake()
    //{
    //    _controller = GetComponent<CharacterController>();
    //}
    //private void Start()
    //{
    //    _controller.OnMoveEvent += CameraMove;
    //}

    //private void Move(Vector2 direction)
    //{
    //    _moveDirection = direction;
    //}

    private void FixedUpdate()
    {
        //CameraMove(_moveDirection);
        Vector3 targetPos = new Vector3(player.position.x, player.position.y, this.transform.position.z);
        transform.position = Vector3.Lerp(transform.position, targetPos, smoothing);
    }

 
    private void CameraMove(Vector2 direction)
    {
        //Vector3 newVector = new Vector3(direction.x, direction.y, this.transform.position.z);
        //transform.position = Vector3.Lerp(transform.position, newVector, smoothing);
        //Vector3 targetPos = new Vector3(player.position.x, player.position.y, this.transform.position.z);
        ///transform.position = Vector3.Lerp(transform.position, targetPos, smoothing);
    }
}