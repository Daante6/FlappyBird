using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ER_State_Jump : ER_Istate
{
    private float mSpeed = 6f;
    ER_Player player;
    float jumpSpeed = 10f;

    public ER_State_Jump(ER_Player player)
    {
        this.player = player;
    }
    public void Enter()
    {
        Debug.Log("JUMP!");
        player.ChangeVelocity(mSpeed);

        Vector2 jumpingForce = new Vector2(0, jumpSpeed);
        player.AddForces(jumpingForce);
    }

    public void Execute()
    {
        
    }

    public void Exit()
    {
        
    }
}
