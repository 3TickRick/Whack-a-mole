using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update

    // Variables
    public float gameTime;
    public Text gameText;
    public GameObject molePrefab;
    public Transform[] spawnPoints;
    
    // Call upon the mole spawn function
    void Start()
    {
        Spawn();
    }

    // Update is called once per frame
    // Makes the time text appear and countdown
    void Update()
    {
        gameTime -= Time.deltaTime;
            if(gameTime < 1)
        {
            gameTime = 0;
        }
        gameText.text = gameTime.ToString();
    }
    // Function to spawn the mole
    public void Spawn()
    {
        GameObject mole = Instantiate(molePrefab) as GameObject;
        mole.transform.position = spawnPoints[Random.Range(0, spawnPoints.Length)].transform.position;
    }
}
