using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Controller : MonoBehaviour
{
    // Variables
    public Text scoreText;
    public int score;
    public float horizontalInput;
    public float verticalInput;
    public float speed = 2.0f;
    

    private Spawner s;

    // Keeping track of the score
    void Start()
    {
        score = 0;
        s = GetComponent<Spawner>();

    }

    // Update is called once per frame

    void Update()

    {

        void OnTriggerEnter(Collider player)
        {
            Destroy(gameObject);
            score += 1;
            scoreText.text = score.ToString();
            s.Spawn();
        }
          
        // Makes the player able to move with arrow keys
        if (Input.GetKey(KeyCode.UpArrow))
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.DownArrow))
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.RightArrow))
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Translate(Vector2.left * speed * Time.deltaTime);

        
       

        

    }
}
