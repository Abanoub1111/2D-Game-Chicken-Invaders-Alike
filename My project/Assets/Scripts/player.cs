using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float moveSpeed = 4;
    public float horizontalInput;
    public float verticalInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");

        transform.Translate(Vector2.right * horizontalInput * moveSpeed * Time.deltaTime); 

        //verticalInput = Input.GetAxisRaw("Vertical");

        //transform.Translate(Vector2.up * verticalInput * moveSpeed * Time.deltaTime);
    }
}
