using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TokenGrab : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "Player")
        {
            Score.scoreCount += 10;
            Destroy(gameObject);
        }
    }
}
