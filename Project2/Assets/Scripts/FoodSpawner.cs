using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpawner : MonoBehaviour
{
    [SerializeField]
    public GameObject[] food;
    
    float x1,x2;
    
    void Awake(){
    	
    	x1= -11.24f;
    	x2= 4.09f;


    }
    void Start()
    {
        StartCoroutine(SpawnFood(1f));
    }
    IEnumerator SpawnFood(float sec) {

    	yield return new WaitForSeconds(sec);

    	Vector3 temp=transform.position;
    	temp.x=Random.Range(x1,x2);
        int random=Random.Range(0,food.Length);
        print (random);

    	Instantiate (food[random],temp,Quaternion.identity);

    	
        StartCoroutine(SpawnFood(Random.Range(0.5f,1f)));
    }

    void Update()
    {
        
    }
}
