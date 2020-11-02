using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotControl : MonoBehaviour {

    
    
    void Start()
    {

        
    }

   
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow)){
                
                transform.Translate(new Vector3(-10*Time.deltaTime,0,0));
            }

        if (Input.GetKey(KeyCode.RightArrow)){
               
        		transform.Translate(new Vector3(10*Time.deltaTime,0,0));
            }
    }
}
