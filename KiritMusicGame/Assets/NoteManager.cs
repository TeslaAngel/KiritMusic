using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SonicBloom.Koreo;

public class NoteManager : MonoBehaviour
{

    //public float Tempo;
    //public float Divide1BeatInto;
    public Koreography koreography;

    public GameObject NoteBeat;
    public string eventID;

    // Start is called before the first frame update
    void Start()
    {
        Koreographer.Instance.RegisterForEvents(eventID, NoteEvent);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void NoteEvent(KoreographyEvent koreographyEvent)
    {
        //todo
        print("cubess");
        //Destroy(gameObject);
    }
}
