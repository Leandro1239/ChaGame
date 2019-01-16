using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimentacao : MonoBehaviour {

    Rigidbody2D rigd = new Rigidbody2D();
    float VelocidadeAceleração = 10;

    public int moedas = 0;
    public TextMesh total;

    float forca = 20f;
    public Rigidbody2D player;
    public bool tocachao = false;

    public Transform checachao;
    float chaograu = 0.2f;
    public LayerMask piso;

    void Start ()
    {
        player = GetComponent<Rigidbody2D>();
        rigd = gameObject.GetComponent <Rigidbody2D>();
	}

    void FixedUpdate()               
    {
        rigd.velocity =  new Vector2 (VelocidadeAceleração, rigd.velocity.y);
        tocachao = Physics2D.OverlapCircle(checachao.position, chaograu, piso);     //CONTATO COM O CHAO
    }

    public void Pula()
    {
        if (tocachao)                            //PULA com o botão
        {
            player.AddForce(new Vector2(0, forca));
            VelocidadeAceleração = VelocidadeAceleração * 1.1f;
        }
    }

    public void OnTriggerEnter2D(Collider2D ativar)          
    {
        if (ativar.gameObject.CompareTag("coin"))
        {
            Destroy(ativar.gameObject);
            moedas += 1;
            total.text = moedas.ToString();
        }
    }
}     
