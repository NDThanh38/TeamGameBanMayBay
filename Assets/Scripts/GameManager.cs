using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class GameManager : MonoBehaviour
{
    public GameObject enemyShip;
    private float timerSpawnEnemy = 2;
    public GameObject AetroidGO;
    private float timerSpawnAetroid = 5;

    public static float screenHeight;
    public static float screenWidth;

    private void Start()
    {
        screenHeight = Camera.main.orthographicSize * 2;
        screenWidth = screenHeight * (Screen.width * 1f / Screen.height);
    }
    
    
    private void Update()
    {
        timerSpawnEnemy -= Time.deltaTime;
        if (timerSpawnEnemy <= 0)
        {
            Vector3 positonSpawn = new Vector3();
            positonSpawn.y = screenHeight/2 + 3f;
            positonSpawn.x = Random.Range(-screenWidth/2, screenWidth/2);
            Instantiate(enemyShip, positonSpawn, quaternion.identity);
            timerSpawnEnemy = 2;
        }
        
        timerSpawnAetroid -= Time.deltaTime;
        if (timerSpawnAetroid <= 0)
        {
            Vector3 positonSpawn = new Vector3();
            positonSpawn.y = screenHeight/2 + 3f;
            positonSpawn.x = Random.Range(-screenWidth/2, screenWidth/2);
            Instantiate(AetroidGO, positonSpawn, quaternion.identity);
            timerSpawnAetroid = 2;
        }
        

    }
}
