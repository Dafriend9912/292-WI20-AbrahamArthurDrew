using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static Correct;

public class MusicToggle : MonoBehaviour
{
    public Button spriteChange;
    public Sprite first;
    public Sprite second;

    void Start()
    {
        spriteChange = gameObject.GetComponent<Button>();
    }

    private void Update()
    {
        if (Global.isMuted)
        {
            spriteChange.image.sprite = second;
        }
        else
        {
            spriteChange.image.sprite = first;
        }
    }

    public void change(Sprite differentSprite)
    {
        if (spriteChange.image.sprite == first )
        {
            spriteChange.image.sprite = second;
        }
    
        else
        {
            spriteChange.image.sprite = first;
        }
    }
}
