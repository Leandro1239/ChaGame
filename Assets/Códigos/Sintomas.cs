using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Sintomas : MonoBehaviour
{

    public Image img;
    public Image img2;
    public Image img3;

    public bool bateu1 = false;
    public bool bateu2 = false;
    public bool bateu3 = false;
}

class Sintoma1 : Sintomas
{

    public void OnCollisionEnter2D(Collision2D morte)
    {
        if (morte.gameObject.CompareTag("Inimigo"))
        {
            base.img.fillAmount -= 1f;
            base.bateu1 = true;
        }
    }
    // Coisas para fazer no primeiro estágio da doença
}

class Sintoma2 : Sintomas
{  

    public void OnCollisionEnter2D(Collision2D morte)
    {
        if (morte.gameObject.CompareTag("Inimigo"))
        {
            if (bateu1)
            {
                base.img2.fillAmount -= 1f;
                base.bateu2 = true;
            }
        }
    }
    // Coisas para fazer no segundo estágio da doença
}

class Sintoma3 : Sintomas
{
    public void OnCollisionEnter2D(Collision2D morte)
    {
        if (morte.gameObject.CompareTag("Inimigo"))
        {
            if (bateu2)
            {
                base.img3.fillAmount -= 1f;
                base.bateu3 = true;
            }
            if (bateu3)
            {
                //MORTE
            }
        }
    }
    // Coisas para fazer no terceiro estágio da doença
}

    