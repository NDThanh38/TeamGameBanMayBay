using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShipMovement : MonoBehaviour
{
    //Awake, Start, Update, FixUpdate, LateUpdate
    // Start is called before the first frame update
    public float speed;
    public GameObject playerBullet;
    

    void Update()
    {
        #region KeyInput

        Vector3 temp = new Vector3();
        
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            temp.x = -1;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            temp.x = 1;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            temp.y = 1;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            temp.y = -1;
        }
        temp.Normalize();
        gameObject.transform.position += speed * Time.deltaTime * temp;

        #endregion

        #region MouseInput

        // Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        // mousePos.z = 0;
        //
        // Vector3 direction = (mousePos - gameObject.transform.position).normalized;
        //
        // gameObject.transform.position += direction * speed * Time.deltaTime;
        //

        #endregion

        #region LimitPos
        
        if (gameObject.transform.position.x < -GameManager.screenWidth/2)
        {
            gameObject.transform.position =
                new Vector3(-GameManager.screenWidth/2, gameObject.transform.position.y, gameObject.transform.position.z);
        }
        if (gameObject.transform.position.x > GameManager.screenWidth/2)
        {
            gameObject.transform.position =
                new Vector3(GameManager.screenWidth/2, gameObject.transform.position.y, gameObject.transform.position.z);
        }
        
        if (gameObject.transform.position.y < -GameManager.screenHeight/2)
        {
            gameObject.transform.position =
                new Vector3(gameObject.transform.position.x, -GameManager.screenHeight/2, gameObject.transform.position.z);
        }
        if (gameObject.transform.position.y > GameManager.screenHeight/2)
        {
            gameObject.transform.position =
                new Vector3(gameObject.transform.position.x, GameManager.screenHeight/2, gameObject.transform.position.z);
        }
        #endregion
        
        
        
        

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(playerBullet, gameObject.transform.position + Vector3.up, Quaternion.identity);
            //Ban
        }
        
    }

   

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "EnemyBullet")
        {
            //tru mau
            Destroy(other.gameObject);
        }
    }
}
