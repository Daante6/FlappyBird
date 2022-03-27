using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ER_Player : MonoBehaviour
{
    public ER_StateMachine stateMachine = new ER_StateMachine();
    public Rigidbody2D rb;
    public BoxCollider2D boxCollider;
    public SpriteRenderer sprite;
    public float mSpeed = 0f;

    void Start()
    {
        this.stateMachine.ChangeState(new ER_State_Start(this));
    }

    void Update()
    {
        this.stateMachine.ExecuteStateUpdate();
    }
    private void FixedUpdate()
    {
        Vector2 velocity = new Vector2(mSpeed, 0);
        //rb.AddForce(velocity, ForceMode2D.Force);
        rb.velocity = velocity;
        Debug.Log(mSpeed);
    }
    public void ChangeVelocity(float v)
    {
        mSpeed = v;
    }
    public void AddForces(Vector2 vector)
    {
        rb.AddForce(vector, ForceMode2D.Impulse);
    }
}
