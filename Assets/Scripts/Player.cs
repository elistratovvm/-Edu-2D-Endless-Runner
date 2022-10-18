using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float yIncrement;
    public float speed;
    private float maxHeight;
    private float minHeight;
    public int health;

    private Vector2 targetPos;

    // Start is called before the first frame update
    void Start()
    {
        maxHeight = yIncrement;
        minHeight = -yIncrement;
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        if ((Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
            && (transform.position.y < maxHeight))
        {
            targetPos = new Vector2(transform.position.x, transform.position.y + yIncrement);
        }
        if ((Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
            && (transform.position.y > minHeight))
        {
            targetPos = new Vector2(transform.position.x, transform.position.y - yIncrement);
        }
    }
}
