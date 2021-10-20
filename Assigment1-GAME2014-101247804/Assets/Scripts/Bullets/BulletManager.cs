using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class BulletManager : MonoBehaviour
{

    private static BulletManager instance = null;
    // Start is called before the first frame update
    private BulletManager()
    {
        Initialize();
    }
    // Update is called once per frame

    public static BulletManager Instance()
    {
        if (instance == null)
        {
            instance = new BulletManager();
        }

        return instance;
    }

    public List<Queue<GameObject>> bulletPools;

    private void Initialize()
    {
        bulletPools = new List<Queue<GameObject>>();

        for (int count = 0; count < (int)BulletType.NUMBER_OF_BULLET_TYPES; count++)
        {
            bulletPools.Add(new Queue<GameObject>());
        }
    }

    private void AddBullet(BulletType type = BulletType.ENEMY)
    {
        var temp_bullet = BulletFactory.Instance().createBullet(type);
        bulletPools[(int)type].Enqueue(temp_bullet);
    }

    public GameObject GetBullet(Vector2 spawnPosition, BulletType type = BulletType.ENEMY)
    {
        GameObject temp_bullet = null;

        if (bulletPools[(int)type].Count < 1)
        {
            AddBullet(type);
        }

        temp_bullet = bulletPools[(int)type].Dequeue();
        temp_bullet.transform.position = spawnPosition;
        temp_bullet.SetActive(true);
        return temp_bullet;
    }

    public void ReturnBullet(GameObject returnedBullet, BulletType type = BulletType.ENEMY)
    {
        returnedBullet.SetActive(false);
        bulletPools[(int)type].Enqueue(returnedBullet);
    }
}
