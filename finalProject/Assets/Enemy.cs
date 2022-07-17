using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
   public GameObject bullet;
    public float fireRate;
    public float nextFire;



    void Start()
        {
            fireRate = 1f;
            nextFire = Time.time;

        }


    private void Update()
        {
            CheckIfTimeTOFire();
        }

    private void CheckIfTimeTOFire()
        {
            if(Time.time > nextFire)
                {
                    Instantiate(bullet, transform.position, Quaternion.identity);
                    nextFire = Time.time + fireRate;
                }
        }



        
    
    }

       


