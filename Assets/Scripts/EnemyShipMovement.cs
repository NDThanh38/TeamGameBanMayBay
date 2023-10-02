using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShipMovement : MonoBehaviour
{
   public float speed;
   public float fireRate;
   public GameObject enemyBullet;
   private float timeFire;

   private void Start()
   {
      timeFire = 0;
   }

   private void Update()
   {
      timeFire -= Time.deltaTime;
      if (timeFire < 0)
      {
         //ban
         Instantiate(enemyBullet, gameObject.transform.position - Vector3.up, Quaternion.identity);
         timeFire = fireRate;
      }
      
      
      gameObject.transform.position += Vector3.down * speed * Time.deltaTime;
   }


   private void OnTriggerEnter2D(Collider2D other)
   {
      if (other.gameObject.tag == "Player")
      {
         //Tru mau player
         Destroy(gameObject);
      }
      else if (other.gameObject.tag == "PlayerBullet")
      {
         Destroy(gameObject);
      }
   }
}
