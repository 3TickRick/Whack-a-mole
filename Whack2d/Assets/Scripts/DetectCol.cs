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

    public void OnTriggerEnter2D(Collider other)
    {
        
        Destroy(gameObject);
        score += 1;
        scoreText.text = score.ToString();
        s.Spawn();

    }
}
