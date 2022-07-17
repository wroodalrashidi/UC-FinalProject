using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
   public float fireRate = 0.2f;
   public Transform firingPoint;
   public GameObject bulletPrefab;
   float timeUntiFire;
   PlayerMovement pm;

   private void Start()
   {
    pm = gameObject.GetComponent<PlayerMovement>();
   }

   private void Update() 
   {
        if (Input.GetMouseButtonDown(0) && timeUntiFire < Time.time);{
        Shoot();
        timeUntiFire = Time.time + fireRate;
        }
   }

   void Shoot()
   {
    float angle = pm.isFacingRight ? 0f : 10f;
    Instantiate(bulletPrefab, firingPoint.position, Quaternion.Euler(new Vector3(0f, 0f, angle)));
   }

}
