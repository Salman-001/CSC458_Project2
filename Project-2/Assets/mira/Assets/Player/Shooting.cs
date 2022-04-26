
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {

    public GameObject theBullet;

    public int bulletSpeed;
    public float despawnTime = 3.0f;

    public bool shootAble = true;
    public float waitBeforeNextShot = 0.1f;

    [SerializeField] private Transform bulletPosition;

    private void Update ()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            if (shootAble)
            {
                shootAble = false;
                //Debug.Log("Calling shoot function");
                Shoot();
                StartCoroutine(ShootingYield());
            }
        }
    }

    IEnumerator ShootingYield ()
    {
        yield return new WaitForSeconds (waitBeforeNextShot);
        shootAble = true;
    }
    void Shoot ()
    {
        // var bullet = Instantiate(theBullet, barrelEnd.position, barrelEnd.rotation);
        // bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * bulletSpeed;
        // Destroy (bullet, despawnTime);
        GameObject bullet = ObjectPool.instance.GetPooledObject();
        if (bullet != null)
        {
            bullet.transform.position = bulletPosition.position;
            bullet.transform.rotation = bulletPosition.rotation;
            bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * bulletSpeed;
            //Debug.Log("Shooting 1");
            bullet.SetActive(true);
        }   
    }
}