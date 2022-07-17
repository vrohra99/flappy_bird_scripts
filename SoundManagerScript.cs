using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip playerHitSound, pointSound, jumpSound ;
    static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        playerHitSound = Resources.Load<AudioClip>("hit");
        jumpSound = Resources.Load<AudioClip>("swoosh");
       

        audioSrc = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound (string clip)
    {
        switch (clip) {
            case "playerHit":
                audioSrc.PlayOneShot(playerHitSound);
                break;
            case "jump":
                audioSrc.PlayOneShot(jumpSound);
                break;
            
            
        }
    }
}
