using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckMoved : MonoBehaviour
{private float x;
private float z;
private float y;
CharacterController charcontr;
Vector3 move;
public float speed = 10;
public float jumpspeed = 10;
public float gravity = -20;
    // Start is called before the first frame update
    void Start()
    {
charcontr=GetComponent<CharacterController>();        
    }

    // Update is called once per frame
    void Update()
    {
 x=Input.GetAxis("Horizontal");
 z=Input.GetAxis("Vertical");
 
 
  if(charcontr.isGrounded)
        {
           move=transform.forward*z*speed+transform.right*x*speed; 
            if(Input.GetButtonDown("Jump"))
            {
                move.y = jumpspeed;
            }
        } 
        move.y += gravity * Time.deltaTime;
        charcontr.Move(move*Time.deltaTime);     
    }
    private void OnTriggerEnter(Collider collision)
    {
Debug.Log(" The Уточка вошла в зону");




    }
}
