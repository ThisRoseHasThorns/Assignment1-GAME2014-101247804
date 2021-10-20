using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour
{

    public BulletType type;

    public float speed;

    public Vector3 bulletVel;

    // Start is called before the first frame update
    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        transform.position += new Vector3(speed, 0.0f, 0.0f);
    }
}


