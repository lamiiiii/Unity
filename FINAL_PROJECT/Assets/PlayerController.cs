using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public AudioClip presentSE;
    public AudioClip appleSE;
    public AudioClip snowSE;
    AudioSource aud;
    GameObject director;

    Animator animator;

    void Start()
    {
        this.director = GameObject.Find("GameDirector");
        animator = GetComponent<Animator>();
        this.aud = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Present")
        {
            this.director.GetComponent<GameDirector>().GetPresent();
            this.aud.PlayOneShot(this.presentSE);
        }
        else if (other.gameObject.tag == "Apple")
        {
            this.director.GetComponent<GameDirector>().GetApple();
            this.aud.PlayOneShot(this.appleSE);
        }
        else
        {
            this.director.GetComponent<GameDirector>().GetSnow();
            this.aud.PlayOneShot(this.snowSE);
        }
        Destroy(other.gameObject);
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) == true) // Left
        {
            animator.SetFloat("Direction", -1f, 0.1f, Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.RightArrow) == true) // Right
        {
            animator.SetFloat("Direction", 1f, 0.1f, Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.UpArrow) == true) // Front
        {
            animator.SetFloat("Move", 1f, 0.1f, Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.DownArrow) == true) // Back
        {
            animator.SetFloat("Move", 1f, -0.1f, Time.deltaTime);
        }
        else
        {
            animator.SetFloat("Direction", 0f, 0.1f, Time.deltaTime);
            animator.SetFloat("Move", 0f, 0.1f, Time.deltaTime);
        }
    }
}