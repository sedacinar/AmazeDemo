using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
   
    public float force=100;

 
    float count = 0;
    public int pathNumber;
    Rigidbody rigidbody;
    public Transform initial;
    public Material material;
    

    void Start()
    {
        rigidbody=gameObject.GetComponent<Rigidbody>();
        
    }

    
    void FixedUpdate()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, 0);
        transform.rotation = initial.rotation;
        if (Directions.selectedDirection == Directions.direction.up.ToString())
        {
            rigidbody.velocity = new Vector3(0, 0, 0);
           
            rigidbody.AddRelativeForce(transform.up*force);
        }
        else if (Directions.selectedDirection == Directions.direction.down.ToString())
        {
            rigidbody.velocity = new Vector3(0, 0, 0);
           
            rigidbody.AddRelativeForce(-transform.up*force);
        }
        else if (Directions.selectedDirection == Directions.direction.right.ToString())
        {
            rigidbody.velocity = new Vector3(0, 0, 0);
           
            rigidbody.AddRelativeForce(transform.right*force);
        }
        else if (Directions.selectedDirection == Directions.direction.left.ToString())
        {
            rigidbody.velocity = new Vector3(0,0,0);
            
            rigidbody.AddRelativeForce(-transform.right*force);
        }
      
    }
    private void OnCollisionEnter(Collision collision)
    {
       if(collision.transform.tag=="path")
        {
           
            if (collision.gameObject.GetComponent<Renderer>().material.name!=material.name+" (Instance)")
            {
                count++;
                Debug.Log("count:" + count);
            }
                collision.gameObject.GetComponent<Renderer>().material = material;
           
            if(count==pathNumber)
            {
                ManageScreen.Instance.WinScreen();
            }
        }
    }
}
