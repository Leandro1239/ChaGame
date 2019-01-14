using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CriadorDeCenário : MonoBehaviour
{
    public Transform obj;
    public Rigidbody2D player;

    public void OnCollisionEnter2D(Collision2D criar)          //PULAR SOMENTE TOCANDO NO CHÃO
    {
        if (criar.gameObject.CompareTag("Sensor"))
        {
            Destroy(criar.gameObject);
            Instantiate(obj, new Vector3(player.position.x * 1.2f, -1, 1), Quaternion.identity);

        }
    }
}