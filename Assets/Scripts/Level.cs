using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    AudioSource audioSource;
    void Start()
    {
        GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Audio/inabakumori-Lagtrain/Cover");
        GetComponent<SpriteRenderer>().color = new Color(75f/255f,75f/255f,75f/255f);
        audioSource = GetComponentInChildren<AudioSource>(true);
        audioSource.clip = Resources.Load<AudioClip>("Audio/inabakumori-Lagtrain/song");
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
