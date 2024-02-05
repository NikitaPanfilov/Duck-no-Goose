using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{public Image[] inventory;
public Sprite[] sprit;
public GameObject cubek;
public GameObject capsuleka;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider abama)
    {
 if(abama.tag=="Green") {
    inventory[0].sprite=sprit[0];
 }
 if(abama.tag=="Red")
 {
inventory[1].sprite=sprit[1];   
 }       
    }
    private void OnTriggerExit(Collider abama)
    {
if(abama.tag=="Green"){
Destroy(cubek);
}
if(abama.tag=="Red") {
 Destroy(capsuleka);  
}

    }
}


