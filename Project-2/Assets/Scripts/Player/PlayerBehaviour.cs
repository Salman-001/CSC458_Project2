using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{

    [Tooltip("Tank's current speed")]
    [SerializeField] private float movementSpeed = 10f;

    [Tooltip("Tank's current rotation speed")]
    [SerializeField] private float rotationSpeed = 55f;

    float translation, rotation;

    bool isMoving, isIdle, isMuted;

    Rigidbody rb;
    Vector3 originalPos, movement;
    Quaternion turnRotation;
    

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        originalPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
    }


    void Update()
    {

        Move();
        Rotate();
        resetPos();
        movementSound();
        
    }

    private void Move(){

        translation = Input.GetAxis("Vertical");

        movement = transform.forward * translation * movementSpeed * Time.deltaTime;

        rb.MovePosition(rb.position + movement);

    }

    private void Rotate(){

        rotation = Input.GetAxis("Horizontal");

        float turn = rotation * rotationSpeed * Time.deltaTime;

        turnRotation = Quaternion.Euler(0, turn, 0);

        rb.MoveRotation(rb.rotation * turnRotation);

    }

    private void resetPos(){

        if(Input.GetKeyDown(KeyCode.R)){
        gameObject.transform.position = originalPos;
        gameObject.transform.rotation = Quaternion.Euler(0,0,0);

        }

    }

    private void movementSound(){

        // if(Input.GetKey("w") || Input.GetKey("a") || Input.GetKey("s") || Input.GetKey("d") || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow)){

        if(Input.GetKey("w") || Input.GetKey("s") || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow)){


            if(isMoving == false){
                FindObjectOfType<AudioManager>().Play("Driving");
                isMoving = true;
            }
            FindObjectOfType<AudioManager>().Stop("Idle");
            isIdle = false;

        }else{
            FindObjectOfType<AudioManager>().Stop("Driving");
            isMoving = false;
            
            if(isIdle == false){
                FindObjectOfType<AudioManager>().Play("Idle");
                isIdle = true;
            }
     
        }

        //Starts and stops the music by pressing m
        if(Input.GetKeyDown("m")){
            
            if(isMuted == false){
                FindObjectOfType<AudioManager>().Stop("Background");
                isMuted = true;
            }else{
                FindObjectOfType<AudioManager>().Play("Background");
                isMuted = false;
            }
        }

    }
}
