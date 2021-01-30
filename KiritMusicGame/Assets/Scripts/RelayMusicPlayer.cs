using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RelayMusicPlayer : MonoBehaviour
{
    public AudioSource audioSource;
    public float RelayTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (RelayTime > 0)
        {
            RelayTime -= 1 * Time.deltaTime;
        }
        else
        {
            audioSource.Play();
            Destroy(GetComponent<RelayMusicPlayer>());
        }
    }
}
