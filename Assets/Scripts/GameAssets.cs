using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameAssets : MonoBehaviour
{

    public static GameAssets i;
    public static GameAssets b;

    private void Awake()
    {
        i = this;
        b = this;
    }

    public Sprite snakeHeadSprite;
    public Sprite snakeBodySprite;
    public Sprite foodSprite;
    public Sprite foodSpriteB;
   
}
