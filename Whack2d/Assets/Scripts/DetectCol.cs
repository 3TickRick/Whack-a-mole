using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class DetectCol : MonoBehaviour

{
    public Text scoreText;
    public int score;
    private Spawner s;

    void Start()
    {
        score = 0;
        s = GetComponent<Spawner>();

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        
        Destroy(gameObject);
        Debug.Log("test");
        s.Spawn();

    }
}
