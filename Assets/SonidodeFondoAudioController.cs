using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidodeFondoAudioController : MonoBehaviour
{
    AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
        source.Play();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
