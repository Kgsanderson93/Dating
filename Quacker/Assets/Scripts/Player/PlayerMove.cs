using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMove : MonoBehaviour
{
    public float moveSpeed;
    public float leftRightSpeed=2;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 2.0f;
    }

    // Update is called once per frame
    void Update()
    {
       
        if(Input.GetKey(KeyCode.W)||Input.GetKey(KeyCode.UpArrow))
        {
            if(this.gameObject.transform.position.x > LevelBoundary.leftSide){
                    transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed, Space.World);
            }
        }
        if(Input.GetKey(KeyCode.S)||Input.GetKey(KeyCode.DownArrow))
        {
            if(this.gameObject.transform.position.x < LevelBoundary.rightSide){

                    transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed *-1, Space.World);
            }
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed * 2, Space.World);

        }
        if(Input.GetKey(KeyCode.A)||Input.GetKey(KeyCode.LeftArrow))
        {
                    transform.Translate(Vector3.forward * Time.deltaTime * leftRightSpeed/2*-1, Space.World);

        }
    }
}
