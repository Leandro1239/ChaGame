using System;
using System.Collections;
using UnityEngine;

public class CriadorDeCenário : MonoBehaviour
{
    public Transform obj;
    public Rigidbody2D player;
    void OnTriggerExit2D(Collider2D criar)          //PULAR SOMENTE TOCANDO NO CHÃO
    {
        if (criar.gameObject.CompareTag("Player"))
        {
            Instantiate(obj, new Vector3(player.position.x + 70 , -1, 1), Quaternion.identity);
        }
    }
}