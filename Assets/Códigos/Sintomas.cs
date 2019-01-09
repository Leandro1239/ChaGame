﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*public class Sintomas : MonoBehaviour
{
    Sintoma1 s1;
    Sintoma2 s2;
    Sintoma3 s3;

    void Start()
    {
        s1 = new Sintoma1();
        s2 = new Sintoma2();
        s3 = new Sintoma3();

        s1.Imagem();
        s2.Imagem();
        s3.Imagem();

    }
}*/




/*class PegaImagem : MonoBehaviour
{
    public void Imagem()
    {
        Image img;
    }  
}*/


public class Sintomas : MonoBehaviour
{

    public Image img;
    public bool bateu1 = false;

    public void OnCollisionEnter2D(Collision2D morte)
    {
        if (morte.gameObject.CompareTag("Inimigo"))
        {
            img.fillAmount -= 1f;
            bateu1 = true;
        }
    }
    // Coisas para fazer no primeiro estágio da doença
}





public class Sintoma2 : Sintomas
{
    public Image img2;
    public bool bateu2 = false;

    public new void OnCollisionEnter2D(Collision2D morte)
    {
        if (morte.gameObject.CompareTag("Inimigo"))
        {
            if (bateu1)
            {
                img2.fillAmount -= 1f;
                bateu2 = true;
            }
        }
    }
    // Coisas para fazer no segundo estágio da doença
}






public class Sintoma3 : Sintoma2
{
    public Image img3;
    public bool bateu3 = false;

    public new void OnCollisionEnter2D(Collision2D morte)
    {
        if (morte.gameObject.CompareTag("Inimigo"))
        {
            if (bateu2)
            {
                img3.fillAmount -= 1f;
                bateu3 = true;
            }
            if (bateu3)
            {
                //MORTE
            }
        }
    }
    // Coisas para fazer no terceiro estágio da doença
}

