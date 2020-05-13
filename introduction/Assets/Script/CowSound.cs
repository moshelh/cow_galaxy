using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CowSound : MonoBehaviour
{
    [SerializeField]
    AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("PlaySound", UnityEngine.Random.Range(5, 200)*Time.deltaTime);
    }
    
    void PlaySound()
    {
        if (!source.isPlaying)
        {
            source.Play();
        }
        Invoke("PlaySound", UnityEngine.Random.Range(500, 1000)* Time.deltaTime);
    }

}
