using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
        private string[] orders = {"Order1","Order2", "Order3","Order4","Order5","Order6" } ;
    public Text[] order_text;
    public GameObject[] order_pad;
    private int last_active_pad;

    
    void Start()
    {
        last_active_pad=0;
        StartCoroutine(SetOrder(1f));
        
        

    }

    IEnumerator SetOrder(float sec) {

    	yield return new WaitForSeconds(sec);

    	
        int random=Random.Range(0,orders.Length);
        
        order_text[last_active_pad].text=(orders[random]);
        print(last_active_pad);

        order_pad[last_active_pad].SetActive(true);
        
        if (last_active_pad<2)
            last_active_pad++;

    	
        StartCoroutine(SetOrder(Random.Range(10f,20f)));
    }
}
