using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    private int score=0;
    void Start()
    {
        
        
    }

    private void OnCollisionEnter2D(Collision2D collision){
    	if (collision.gameObject.tag=="Food"){
    		Destroy(collision.gameObject);
            score++;
            print (score);
    	}
    }

    void Update()
    {
        
    }
}
