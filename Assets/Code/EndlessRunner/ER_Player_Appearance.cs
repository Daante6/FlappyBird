using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum StateEnum
{
    Run,
    Jump,
    Slide,
    Wallrun,
    TigerJump
};
public class ER_Player_Appearance : MonoBehaviour
{
    public Sprite[] sprites = new Sprite[0];
    public SpriteRenderer spriteRenderer;

    public void ChangeImage(StateEnum state)
    {
        spriteRenderer.sprite = sprites[(int)state];
    }
}
