using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimentacao : MonoBehaviour {
       
    public int moedas = 0;                      //MOEDA
    public TextMesh total;

    float forca = 20;                           //JOGADOR
    public Rigidbody2D player;
    private bool tocachao = false;
    Rigidbody2D rigd = new Rigidbody2D();           
    float VelocidadeAceleração = 10;

    public Transform checachao;                     //CHÃO
    float chaograu = 0.2f;
    public LayerMask piso;

    public GameObject Largada;                      //RECORDE
    public GameObject jogador;
    private float distancia = 0;
    private int recorde = 0;
    public TextMesh total_Distancia;
    Animator anim;

    void Start ()                                               //Jogador
    {
        player = GetComponent<Rigidbody2D>();
        rigd = gameObject.GetComponent <Rigidbody2D>();

        anim = GetComponent<Animator>();
    
	}

    private void Update()                                                       // MEDE A DISTANCIA E COLOCA EM 'RECORDE'
    {
        distancia = Vector2.Distance(Largada.transform.position, jogador.transform.position);
        //Debug.Log(distancia);
        recorde = (int)distancia;
        total_Distancia.text = recorde.ToString();

        rigd.velocity = new Vector2(VelocidadeAceleração, rigd.velocity.y);               //FAZ CORRER SOZINHO
        tocachao = Physics2D.OverlapCircle(checachao.position, chaograu, piso);             //CONTATO COM O CHAO
    }

    public void Pula()
    {
        if (tocachao)                            //PULA com o botão
        {
            player.AddForce(new Vector2(0, forca));                                         //SAI DO CHÃO
            anim.SetBool("Pular", true);
            anim.SetBool("Correr", false);
            VelocidadeAceleração = VelocidadeAceleração * 1.02f;                            //ATRIBUI O AUMENTO DA VELOCIDADE A CADA PULO
        }
    }

    public void OnCollisionEnter2D(Collision2D Chao)
    {
        if (Chao.gameObject.CompareTag("Chão"))
        {
            anim.SetBool("Pular", false);
            anim.SetBool("Correr", true);
        }
    }

    public void OnTriggerEnter2D(Collider2D ativar)                         //COLETA E CONTA MOEDA
    {
        if (ativar.gameObject.CompareTag("coin"))
        {
            Destroy(ativar.gameObject);
            moedas += 1;
            total.text = moedas.ToString();
        }
    }
}     
