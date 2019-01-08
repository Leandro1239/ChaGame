using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movimentacao : MonoBehaviour {

    Rigidbody2D rigd = new Rigidbody2D();
    public int VelocidadeAceleração = 5;
    public bool ativaPulo = false;
    public int moedas = 0;
    public Text txt;
    public Touch toque;

    void Start () {
        rigd = gameObject.GetComponent <Rigidbody2D>();
	}

    public void OnCollisionEnter2D(Collision2D ativar)          //PULAR SOMENTE TOCANDO NO CHÃO
    {
        if (ativar.gameObject.CompareTag("Chão"))
        {
            ativaPulo = true;
        }
    }

    void Update()
    {
        rigd.velocity = transform.right * VelocidadeAceleração;

        if (Input.touchCount > 0)                               //TOQUE NA TELA
        {
            toque = Input.GetTouch(0);
            switch (toque.phase)
            {
                case TouchPhase.Began:
                    if (ativaPulo)
                    {
                        transform.Translate(new Vector3(0, 1, 0));
                        ativaPulo = false;
                    }
                break;

                case TouchPhase.Moved:
                    //CORRE
                break;
            }

        }
    }

   /* public void Jump()
    {
        if (ativaPulo)
        {
            transform.Translate(new Vector3(0, 1, 0));
            ativaPulo = false;
        }
    }*/

    private void OnTriggerEnter2D(Collider2D Pegou)                 //PEGA MOEDAS
    {
        if (Pegou.gameObject.CompareTag("Moeda"))
        {
            moedas++;
            Destroy(Pegou.gameObject);
        }
    }
}
