using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    AudioSource audioSource;
    SpriteRenderer spriteRenderer;
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = Resources.Load<Sprite>("Audio/inabakumori-Lagtrain/Cover");
        spriteRenderer.color = new Color(75f/255f,75f/255f,75f/255f);
        audioSource = GetComponentInChildren<AudioSource>();
        audioSource.clip = Resources.Load<AudioClip>("Audio/inabakumori-Lagtrain/song");
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
