using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float speedX, speedY;
    private Rigidbody rb;
    public float playerSpeed;

    // Start is called before the first frame update
    private void Start(){
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void FixedUpdate(){
      speedX = Input.GetAxisRaw("Horizontal") * playerSpeed;
      speedY = Input.GetAxisRaw("Vertical") * playerSpeed;

      rb.velocity = new Vector3(speedX, 0, speedY);
    }

    
}
