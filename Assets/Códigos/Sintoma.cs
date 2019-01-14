using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Sintoma : MonoBehaviour {

    public Image BarraVida;
    public Text Quantidade;
    public int ValorAtual = 100;
    public int Dano = 25;
    public int Energia = 25;

    public void OnCollisionEnter2D(Collision2D Dano)          //PULAR SOMENTE TOCANDO NO CHÃO
    {
        if (Dano.gameObject.CompareTag("Inimigo"))
        {
            Destroy(Dano.gameObject);
            VidaPerde();
        }
    }


    public void VidaPerde()
    {
        if (ValorAtual > -1)
        {
            ValorAtual -= Dano;
            BarraVida.fillAmount = (float)ValorAtual/100;
            string temp = ValorAtual.ToString();
            Quantidade.text = temp;
            if (ValorAtual == 0)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
    }

    public void VidaGanha()
    {
        if (ValorAtual < 1)
        {
            ValorAtual += Energia;
            BarraVida.fillAmount = (float)ValorAtual / 100;
            string temp = ValorAtual.ToString();
            Quantidade.text = temp;
        }
    }

    void MaxVida()
    {
        if (ValorAtual >= 1)
        {
            ValorAtual = 1;
        }
        

    }
}
