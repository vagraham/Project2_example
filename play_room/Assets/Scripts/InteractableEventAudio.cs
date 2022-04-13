using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class InteractableEventAudio : MonoBehaviour
{
public AudioClip hoverSound;
public AudioClip selectSound;

public void PlayHoverSound()
    {
        if (hoverSound != null)
            AudioSource.PlayClipAtPoint(hoverSound, transform.position);
    }

    public void PlaySelectSound()
    {
        if (selectSound != null)
            AudioSource.PlayClipAtPoint(selectSound, transform.position);
    }
}
