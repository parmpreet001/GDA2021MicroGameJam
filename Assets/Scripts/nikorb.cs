using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nikorb : MonoBehaviour
{
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {

        float xCord = Random.Range(2.6f, 3.5f);

        if (Random.Range(0,10) % 2 == 0) {
            xCord = xCord * -1;
        }

        transform.position = new Vector3(xCord, 5, 0);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
