using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class pmove : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float speed = 0.1f;
    public bool gameStart = true;
    public float timer = 0;
    public LogicScript logic;
    public AudioScript audio;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        audio = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioScript>();
    }

    // Update is called once per frame
    void Update()
    {
        float speed = 0.025f;

        if (gameStart == true)
        {
            if (Input.GetKey(KeyCode.W))
            {
                Vector2 position = this.transform.position;
                position.y += 1 * speed;
                this.transform.position = position;
            }
            if (Input.GetKey(KeyCode.A))
            {
                Vector2 position = this.transform.position;
                position.x -= 1 * speed;
                this.transform.position = position;
            }
            if (Input.GetKey(KeyCode.S))
            {
                Vector2 position = this.transform.position;
                position.y -= 1 * speed;
                this.transform.position = position;
            }
            if (Input.GetKey(KeyCode.D))
            {
                Vector2 position = this.transform.position;
                position.x += 1 * speed;
                this.transform.position = position;
            }

            if (timer < 1)
            {
                timer += Time.deltaTime;
            }
            else
            {
                logic.addScore(1);
                timer = 0;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 1)
        {
            Vector3 normal = collision.contacts[0].normal;
            transform.up = Vector2.Reflect(transform.up, normal);
        }
        if (collision.gameObject.layer == 2)
        {
            if(gameStart == true)
            {
                gameStart = false;
                logic.gameover();
                audio.die();
                Destroy(gameObject);
            }
        }
    }

}