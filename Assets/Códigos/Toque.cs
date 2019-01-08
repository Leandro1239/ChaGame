using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Toque : MonoBehaviour {

    public Rigidbody2D player;
    public float impulso = 50f;
    public Touch toque;
    public bool ativaPulo = false;

    public void OnCollisionEnter2D(Collision2D ativar)          //PULAR SOMENTE TOCANDO NO CHÃO
    {
        /*if (ativar.gameObject.CompareTag("Chão"))
        {
            ativaPulo = true;
        }*/
    }

    void Update () {

        if (Input.touchCount > 0)                               //TOQUE NA TELA
        {
            toque = Input.GetTouch(0);
            switch (toque.phase)
            {
                case TouchPhase.Began:
                    //if (ativaPulo)
                    //{
                        player.AddForce(new Vector2(0, impulso * Time.deltaTime), ForceMode2D.Impulse);
                        ativaPulo = false;
                    //}
                break;

                case TouchPhase.Moved:
                    //CORRE
                break;
            }

        }

    }
}
