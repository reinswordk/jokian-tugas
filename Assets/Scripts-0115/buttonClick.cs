using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonClick : MonoBehaviour
{

    public AudioSource aSound;
    public AudioClip hoverSound;
    public AudioClip clickSound;

    public void HoverSound()
    {
        aSound.PlayOneShot(hoverSound);
    }
    public void ClickSound()
    {
        aSound.PlayOneShot(clickSound);
    }
}
