using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Toque : MonoBehaviour {

    public Text txt;
    public Touch toque;
	
	// Update is called once per frame
	void Update () {

        if(Input.touchCount > 0)
        {
            toque = Input.GetTouch(0);
            switch (toque.phase)
            {
                case TouchPhase.Began:
                    
                        transform.Translate(new Vector3(0, 1, 0));
                    
                    
                    break;

                case TouchPhase.Moved:
                    //CORRE
                    break;
            }
        }
		
	}
}
