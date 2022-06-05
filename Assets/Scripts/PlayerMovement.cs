using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController _controller;
    public Animator _animator;
    [SerializeField] private float speed = 5f;
    [SerializeField] private float jumpHeight = 10f;
    [SerializeField] private float gravity = 1.0f;

    private float _yVelocity;
    private float _xVelocity;
    private Vector3 _velocity;
    void Awake()
    {
        _controller = gameObject.GetComponent<CharacterController>();
        _animator = gameObject.GetComponent<Animator>();
    }
    void Update()
    {
        _xVelocity = Input.GetAxisRaw("Horizontal");
        if (_controller.isGrounded)
        {
            _velocity.x = _xVelocity * speed;
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
            {
                _yVelocity = 0f;
                _yVelocity = jumpHeight;
            }
        }
        else
        {
            _yVelocity -= gravity;
        }

        _velocity.y = _yVelocity;
        if (_velocity.magnitude > 0.1f)
        {
            _controller.Move(_velocity * Time.deltaTime);
            if (_xVelocity != 0)
            {
                _animator.SetFloat("Speed", _velocity.x);
            }
            else
            {
                _animator.SetFloat("Speed", 0f);
            }
        }
    }
}
