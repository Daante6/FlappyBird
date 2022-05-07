using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ER_Player : MonoBehaviour
{
    public ER_StateMachine stateMachine = new ER_StateMachine();
    public ER_Player_Appearance appearance;
    public ER_GameManager gameManager;
    public Rigidbody2D rb;
    public CapsuleCollider2D capsuleCollider;
    public SpriteRenderer sprite;
    [HideInInspector]
    public float mSpeed = 0f;
    private float fallMultiplier = 2.5f;
    private float fallMultiplierLow = 2f;
    public bool isGrounded = true;

    void Start()
    {
        this.stateMachine.ChangeState(new ER_State_Start(this));
    }

    void Update()
    {
        this.stateMachine.ExecuteStateUpdate();
        if (Input.GetKeyDown(KeyCode.R))
        {
            gameManager.ResetLevel();
        }
    }
    private void FixedUpdate()
    {
        Vector2 velocity = new Vector2(mSpeed, rb.velocity.y);
        rb.velocity = velocity;
        CalcGravity();
    }
    public void ChangeVelocity(float v)
    {
        mSpeed = v;
    }
    public void AddForces(Vector2 vector)
    {
        rb.AddForce(vector, ForceMode2D.Impulse);
    }
    public void AddVelocity(Vector2 vector)
    {
        rb.velocity += vector;
    }
    public void ResetVelocityY()
    {
        rb.velocity = new Vector2(rb.velocity.x, 0);
    }
    public void CalcGravity()
    {
        if(rb.velocity.y < 0)
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
        }
        else if(rb.velocity.y > 0 && !Input.GetKey(KeyCode.UpArrow))
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplierLow - 1) * Time.deltaTime;
        }
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Floor")
        {
            isGrounded = true;
        }
        else if(col.gameObject.tag == "Death")
        {
            Debug.Log("GAME OVER!");
            mSpeed = 0f;
        }
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Wallrun")
        {
            stateMachine.ChangeState(new ER_State_Wallrun(this));
        }
        if(col.gameObject.tag == "Death")
        {
            gameManager.ResetLevel();
        }
    }
    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "Wallrun" && stateMachine.currentlyRunningState.ToString() == "ER_State_Wallrun")
        {
            Debug.Log(stateMachine.currentlyRunningState);
            stateMachine.ChangeState(new ER_State_Jump(this));
        }
    }
    private void OnCollisionExit2D(Collision2D col)
    {
        if(col.gameObject.tag == "Floor")
        {
            isGrounded = false;
        }
    }
}
