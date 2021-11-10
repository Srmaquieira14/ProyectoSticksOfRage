using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public Rigidbody2D enemyRb;
    public float speed = 3f;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(transform.localPosition.x, 0.0F, 0.0F);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x + speed * Time.deltaTime, transform.position.y);
    }
}
