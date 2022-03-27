using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour
{
    Rigidbody2D rb;
    Transform StartingTransform;
    public Text text;
    public float JumpForce;
    public float grav;
    public float rotateBackSpeed;
    bool FirstClickBool = true;

    // Start is called before the first frame update
    void Start()
    {
        StartingTransform = transform;
        Time.timeScale = 0;
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = grav;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow)){
            if (FirstClickBool)
            {
                FirstClick();
                rb.AddForce(new Vector2(0, JumpForce-2), ForceMode2D.Impulse);
                FirstClickBool = false;
                return;
            }
            rb.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
        }

    }
    public void FirstClick()
    {
        Time.timeScale = 1;
        text.gameObject.SetActive(false);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Death")
        {
            SceneManager.LoadScene("FlappyBird");
        }
    }
}
