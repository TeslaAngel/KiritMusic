using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SonicBloom.Koreo;

public class NoteManager : MonoBehaviour
{

    //public float Tempo;
    //public float Divide1BeatInto;
    //public Koreography koreography;

    public GameObject NoteBeat;
    public string NoteBeatEventID;

    [Space]
    public Transform[] Tracks;
    //public List<GameObject> Notes = new List<GameObject>();
    public GameObject[] NoteBeats;

    public float NoteSpeed;
    public float EndVertical;
    public float NoteDiameter;


    // Start is called before the first frame update
    void Start()
    {
        Koreographer.Instance.RegisterForEvents(NoteBeatEventID, NoteBeatEvent);

        
    }

    // Update is called once per frame
    void Update()
    {
        for(int I=0; I< NoteBeats.Length; I++)
        {
            NoteBeats[I].transform.Translate(0, 0, -NoteSpeed * Time.deltaTime);

            if (NoteBeats[I].transform.position.z < EndVertical - NoteDiameter)
            {
                Destroy(NoteBeats[I]);
                NoteBeats = GameObject.FindGameObjectsWithTag("BeatNote");
                
                
            }

        }
    }

    //NoteBeat Instantiate
    private void NoteBeatEvent(KoreographyEvent koreographyEvent)
    {
        
        //todo
        print("NoteBeat");
        //Destroy(gameObject);

        int Track = koreographyEvent.GetIntValue();
        Track -= 1;
        Instantiate(NoteBeat, Tracks[Track].transform.position, Tracks[Track].transform.rotation, Tracks[Track].transform);
        //Notes.Add(Tracks[Track].transform.Find("NoteBeat").gameObject);
        //Notes[Notes.Count - 1].transform.SetParent(null);
        NoteBeats = GameObject.FindGameObjectsWithTag("BeatNote");
    }
}
