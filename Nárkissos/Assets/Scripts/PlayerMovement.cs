using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;

    
    public float speed = 12f;
    public float gravity = -9.81f;

    public Transform groundCheck; //referencia ao objeto groundcheck
    public float groundDistance = 0.4f; //raio da esfera que usamos para checar se esta no ch ao
    public LayerMask groundMask; //que objetos a esfera vai detectar

    Vector3 velocity;
    bool isGrounded; //verifica se esta no chao ou nao

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {


        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if(isGrounded && velocity.y < 0) //checa se esta no chao e se a velocidade e 0, reescreve a velocidade para forcar o player a estar no chao
        {
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
    }
}
