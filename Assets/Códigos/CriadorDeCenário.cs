using System;
using System.Collections;
using UnityEngine;

public class CriadorDeCenário : MonoBehaviour
{
    public Transform obj;
    public Transform obj2;
    public Rigidbody2D player;
    public float contador = 1;
    public float controlador = 0;

    void OnTriggerExit2D(Collider2D criar)          //PULAR SOMENTE TOCANDO NO CHÃO
    {
        
        if (criar.gameObject.CompareTag("Player"))
        {
            if (contador > 2)
            {
                controlador = 1;
            }

            if (contador < 3 && controlador == 0)              //CRIA PRIMEIRA CENARIO
            {
                contador = contador + 1;
                Instantiate(obj, new Vector3(player.position.x + 70.85f, -1, 1), Quaternion.identity);
            } 

            if (controlador == 1)                               //CRIA SEGUNDO CENARIO
            {
                Instantiate(obj2, new Vector3(player.position.x + 70.85f, -1, 1), Quaternion.identity);
            }
            
        }
    }
}