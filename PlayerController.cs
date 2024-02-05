using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float x;
    float z;
 //Vector3 move;
 public float speed = 10f;
 public Transform oritale;
 Vector3 direction; 
    public CharacterController chare;
    // Start is called before the first frame update
    void Start()
    {
 chare = GetComponent<CharacterController>();      
    }
private void InputPos()
{
x = Input.GetAxis("Horizontal");    
z = Input.GetAxis("Vertical");

}
    // Update is called once per frame
    void Update()
    {

//move = transform.right*x+transform.forward*z;
//chare.Move(move*speed*Time.deltaTime);

InputPos();

    }
 void FixedUpdate()
 {
PlayerMove();

 }   
 void PlayerMove()
 {
direction = oritale.right*x+oritale.forward*z;
chare.Move(direction*speed*Time.deltaTime);

 }

}
