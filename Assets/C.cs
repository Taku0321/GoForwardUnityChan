using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C : MonoBehaviour
{

    public AudioClip block;
    AudioSource audioSource;

    private GameObject ground;
    private string Touch = "TouchTag";

    void Start()
    {
        //Componentを取得
        audioSource = GetComponent<AudioSource>();

        this.ground = GameObject.Find("ground");
    }

    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == Touch)
        {
            audioSource.PlayOneShot(block);
        }
    }
}