using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayDinoSound : MonoBehaviour
{
    
    public AudioClip spinoSound;
    public void PlaySpinoSound(){
      
    AudioSource audioSource = GetComponent<AudioSource>();
    
    if(!audioSource.isPlaying)
        audioSource.PlayOneShot(spinoSound);   
    }
}
