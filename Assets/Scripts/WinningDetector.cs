using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinningDetector : MonoBehaviour
{
    private SpriteRenderer sprite;
    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col) {

        if (col.gameObject.name == "Circle") {
            sprite.color = new Color(0.0f, 1.0f, 0.0f, 1.0f);
        }

    }

    void OnTriggerExit2D(Collider2D col) {

        if (col.gameObject.name == "Circle") {
            sprite.color = new Color(1.0f, 0.0f, 0.0f, 1.0f);
        }

    }
}
