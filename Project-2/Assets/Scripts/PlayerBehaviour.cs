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

    Rigidbody rb;
    Vector3 originalPos, movement;
    Quaternion turnRotation;

    //Audio
    public AudioSource movementAudio;
    public AudioClip idle;
    public AudioClip moving;
    public float pitchRange = 1f;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        originalPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
    }

    // Update is called once per frame
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

        if(Input.GetKeyDown("w") || Input.GetKeyDown("a") || Input.GetKeyDown("s") || Input.GetKeyDown("d") || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.LeftArrow)){

            if(movementAudio.clip == idle){
                movementAudio.clip = moving;
               // movementAudio.pitch = Random.Range(movementAudio.pitch - pitchRange, movementAudio.pitch + pitchRange);
                movementAudio.Play();
            }

        }else{
            movementAudio.clip = idle;
            movementAudio.Play();
        }

    }
}
