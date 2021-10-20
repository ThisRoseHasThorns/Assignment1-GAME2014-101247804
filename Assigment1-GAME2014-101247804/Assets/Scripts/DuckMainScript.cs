using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckMainScript : MonoBehaviour
{

    public Transform bulletSpawn;
    public int frameDelay;

    private float startPoint;
    private float randomSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        if (Time.frameCount % frameDelay == 0)
        {
            BulletManager.Instance().GetBullet(bulletSpawn.position);
        }
    }
}
