using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody2D playerRb;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(transform.localPosition.x, 0.0F, 0.0F);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
