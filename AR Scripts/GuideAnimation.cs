using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuideAnimation : MonoBehaviour
{
    public Animator animator;
    public AudioSource introAudio;
    public AudioSource boatAudio;
    public AudioSource planeAudio;

    void Update()
    {
        // Check if audio sources have finished playing
        if (!introAudio.isPlaying && !boatAudio.isPlaying && !planeAudio.isPlaying)
        {
            // Return to idle animation
            animator.SetTrigger("Idle");
        }
    }

    public void Introduce() {
        // Trigger the talking animation and play intro audio
        animator.SetTrigger("Talk");
        introAudio.Play();

    }

    // Function uses box collider to identify the object being collided with
    void OnTriggerEnter(Collider collider) {

        // Check tag of object collided with, trigger animation and play audio
        if(collider.tag == "Boat") {
            animator.SetTrigger("Talk");
            introAudio.Stop();
            boatAudio.Play();
        }

        if(collider.tag == "Plane") {
            animator.SetTrigger("Talk");
            introAudio.Stop();
            planeAudio.Play();
        }
    }
}
