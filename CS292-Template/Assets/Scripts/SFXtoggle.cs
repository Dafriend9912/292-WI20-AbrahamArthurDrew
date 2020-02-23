using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SFXtoggle : MonoBehaviour
{
    public Button spriteChange;
    public Sprite first;
    public Sprite second;

    void Start()
    {
        spriteChange = gameObject.GetComponent<Button>(); 
    }

    public void change(Sprite differentSprite)
    {
        if (spriteChange.image.sprite == first)
        {
            spriteChange.image.sprite = second;
        }
        else
        {
            spriteChange.image.sprite = first;
        }
    }
}
