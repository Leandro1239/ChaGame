using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Movimentacao : MonoBehaviour {

    Rigidbody2D rigd = new Rigidbody2D();
    float VelocidadeAceleração = 10;

    public float moedas = 0f;
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


        if (tocachao && Input.GetKeyDown(KeyCode.Space))                            //PULA
        {
            player.AddForce(new Vector2(0, forca));
            VelocidadeAceleração = VelocidadeAceleração * 1.1f;
        }


    }

    /*
    public void Jump()
    {
        if (ativaPulo)
        {
            player.AddForce(new Vector2(0, impulso * Time.deltaTime), ForceMode2D.Impulse);
            ativaPulo = false;
        }
    }*/

    public void OnCollisionEnter2D(Collision2D ativar)          //PULAR SOMENTE TOCANDO NO CHÃO
    {
        if (ativar.gameObject.CompareTag("coin"))
        {
            moedas = moedas + 1;
            Destroy(ativar.gameObject);
            total.text = moedas.ToString();
        }
    }

    public void Denovo()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}     
