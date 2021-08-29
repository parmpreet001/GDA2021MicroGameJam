using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeeSaw : MonoBehaviour
{
    private int winRange = 15; //The absolute value of the seesaw's z rotation has to be within this value for the win condition
    private float winTime = 1f; //How long the see saw has to be within the winrange to satisfy the win condition
    public float eularAngle = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        eularAngle = transform.localEulerAngles.z;


        if(transform.localEulerAngles.z > 45 && transform.localEulerAngles.z < 90)
        {
            transform.localEulerAngles = new Vector3(0, 0, 45);
        }
        else if (transform.localEulerAngles.z < 315 && transform.localEulerAngles.z > 270)
        {
           transform.localEulerAngles = new Vector3(0, 0, 315);
        }
    }
}
