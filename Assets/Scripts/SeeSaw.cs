using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeeSaw : MonoBehaviour
{
    private int winRange = 15; //The absolute value of the seesaw's z rotation has to be within this value for the win condition
    private float winTime = 1f; //How long the see saw has to be within the winrange to satisfy the win condition

    public float velocity;
    public float Velocity
    {
        get { return velocity; }
        set
        {
            if (value <= -5)
                velocity = -5;
            else if (value >= 5)
                velocity = 5;
            else
                velocity = value;
        }
    }
    public bool isPressingButtons = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(transform.localEulerAngles.z > 45 && transform.localEulerAngles.z < 90)
        {
            velocity = 0;
            transform.localEulerAngles = new Vector3(0, 0, 45);
        }
        else if (transform.localEulerAngles.z < 315 && transform.localEulerAngles.z > 270)
        {
            velocity = 0;
           transform.localEulerAngles = new Vector3(0, 0, 315);
        }



    }

    private void FixedUpdate()
    {
        Velocity += Input.GetAxisRaw("Horizontal") * Time.deltaTime * 2f;
        if(Input.GetAxisRaw("Horizontal") == 0)
        {
            if (Velocity <= 0.1 && Velocity >= -0.1)
                Velocity = 0;
            else if (Velocity < 0)
                Velocity += 0.03f;
            else if (Velocity > 0)
                Velocity -= 0.03f;
        }

        transform.localEulerAngles = new Vector3(0, 0, transform.localEulerAngles.z - Velocity);

    }


}
