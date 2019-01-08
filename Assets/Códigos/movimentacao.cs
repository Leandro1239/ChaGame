using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movimentacao : MonoBehaviour {

    Rigidbody2D rigd = new Rigidbody2D();
    public int VelocidadeAceleração = 5;
    public int moedas = 0;

   /* public bool ativaPulo = false;
    public Rigidbody2D player;
    public float impulso = 50f;*/

    void Start () {
        rigd = gameObject.GetComponent <Rigidbody2D>();
	}

    void Update()               //MOVE PARA PRENTE
    {
        rigd.velocity = transform.right * VelocidadeAceleração;

        /*                                                      PULAR PELO TECLADO
        if (ativaPulo)                            
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                player.AddForce(new Vector2(0, impulso * Time.deltaTime), ForceMode2D.Impulse);
                ativaPulo = false;
            }

        }
        
        public void OnCollisionEnter2D(Collision2D ativar)          //PULAR SOMENTE TOCANDO NO CHÃO
        {
            if (ativar.gameObject.CompareTag("Chão"))
            {
                ativaPulo = true;
            }
        } 


         */
    }

    private void OnTriggerEnter2D(Collider2D Pegou)                 //PEGA MOEDAS
    {
        if (Pegou.gameObject.CompareTag("Moeda"))
        {
            moedas++;
            Destroy(Pegou.gameObject);
        }
    }
       
}
