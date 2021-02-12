using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RelayMusicPlayer : MonoBehaviour
{
    public AudioSource audioSource;
    public float RelayTime;
    public float extraRelay;
    [Space]
    public Transform Initiator;
    public Transform EndVerticle;
    public NoteManager noteManager;

    // Start is called before the first frame update
    void Start()
    {
        RelayTime = (Initiator.position.z - EndVerticle.position.z)/noteManager.NoteSpeed+extraRelay;
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
