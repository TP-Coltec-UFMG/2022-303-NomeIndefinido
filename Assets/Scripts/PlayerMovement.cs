using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Variáveis para referenciar elementos do player
    public CharacterController _controller;
    public Animator _animator;
    public Transform _model;

    //Variáveis para controle da física do personagem
    [SerializeField] private float speed = 5f;
    [SerializeField] private float jumpHeight = 10f;
    [SerializeField] private float gravity = 1.0f;

    //Outras
    private bool isWalking = false;
    private float _yVelocity;
    private float _xVelocity;
    private Vector3 _velocity;

    //Recolhe os componentes que serão usados a cada vez que uma instância do player é criada
    void Awake()
    {
        _controller = gameObject.GetComponent<CharacterController>();
        _animator = gameObject.GetComponent<Animator>();
        _model = gameObject.GetComponent<Transform>();
    }

    //Recolhe o input do usuário e executa o comportamento esperado
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

        if(_xVelocity != 0 && _controller.isGrounded)
        {
            Quaternion newRotation = Quaternion.LookRotation(new Vector3(_xVelocity, 0f, 0f));
            _model.rotation = newRotation;
            isWalking = true;
        }
        else
        {
            isWalking = false;
        }

        _velocity.y = _yVelocity;

        if (_velocity.magnitude > 0.1f)
        {
            _controller.Move(_velocity * Time.deltaTime);
            _animator.SetBool("isWalking", isWalking);
        }
    }
}
