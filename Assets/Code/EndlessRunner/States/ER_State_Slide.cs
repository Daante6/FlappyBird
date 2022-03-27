using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ER_State_Slide : ER_Istate
{
    ER_Player player;
    float mSpeed = 4.5f;
    
    public ER_State_Slide(ER_Player player)
    {
        this.player = player;
    }
    public void Enter()
    {
        player.boxCollider.offset = new Vector2(player.boxCollider.offset.x, -0.25f);
        player.boxCollider.size = new Vector2(player.boxCollider.size.x, 0.5f);

        player.ChangeVelocity(mSpeed);

    }

    public void Execute()
    {
        
    }

    public void Exit()
    {
        player.boxCollider.offset = new Vector2(player.boxCollider.offset.x, 0);
        player.boxCollider.size = new Vector2(player.boxCollider.size.x, 1);
    }
}
