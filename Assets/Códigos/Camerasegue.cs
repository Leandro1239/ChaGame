using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerasegue : MonoBehaviour {

    public GameObject player;
    public float camVel = 0.25f;
    private bool seguePlayer;
    public Vector3 ultimolocal;
    public Vector3 velAtual;
    
    void Start () {
        seguePlayer = true;
        ultimolocal = player.transform.position;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (seguePlayer)
        {
            if(player.transform.position.x >= transform.position.x)
            {
                Vector3 localnovo = Vector3.SmoothDamp(transform.position, player.transform.position, ref velAtual, camVel);

                transform.position = new Vector3(localnovo.x, 0 , transform.position.z);

                ultimolocal = player.transform.position;
            }
        }
	}
}
