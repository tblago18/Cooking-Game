using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotBound : MonoBehaviour
{
    private float minX, maxX;
    void Start()
    {
    	
    	minX=-12.68f;
    	maxX=6.52f;
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 temp= transform.position;
        print(temp);
        if (temp.x>maxX)
        	temp.x=maxX;
        if (temp.x<minX)
        	temp.x=minX;
        transform.position=temp;

    }
}
