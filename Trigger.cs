using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
public  GameObject collision;
    private void OnTriggerEnter(Collider collision)
    {
Debug.Log("The Уточка вошла в зону "+collision.gameObject.name);   
}
private void OnTriggerStay(Collider collision)
{
Debug.Log("The Уточка стоит в зоне "+collision.gameObject.name);



}
private void OnTriggerExit(Collider collision)
{
Debug.Log("The Уточка выходит из зоны "+collision.gameObject.name);
MeshRenderer pop = collision.GetComponent<MeshRenderer>();
pop.enabled = true;
}

}

