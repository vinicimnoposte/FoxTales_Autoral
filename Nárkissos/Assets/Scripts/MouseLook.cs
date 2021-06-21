using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensitivity = 100f; //sensibilidade do mouse


    public Transform playerBody; //corpo do jogador no Inspector para girar a camera

    float xRotation = 0f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; //quando clicar na tela, o mouse fica travado no meio, para nao clicar fora sem querer
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime; //controle do mouse no eixo X
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime; //controle do mouse no eixo Y

        xRotation -= mouseY; //a cada frame, a variavel diminui com base no mouseY, para a rotacao nao flipar
        xRotation = Mathf.Clamp(xRotation, -90f, 90f); //clamp para o jogador nao flipar a camera de cabeca para baixo caso olhe pra cima

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f); //controla a rotacao da camera com angulos de euler

        playerBody.Rotate(Vector3.up * mouseX); //rotacao do mouse no eixo X
    }
}
