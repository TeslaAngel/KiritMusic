using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SonicBloom.Koreo;

public class TextSong1Script : MonoBehaviour
{
    public string eventID;

    // Start is called before the first frame update
    void Start()
    {
        Koreographer.Instance.RegisterForEvents(eventID, cubess);
        print("ready");
    }

    private void cubess(KoreographyEvent koreographyEvent)
    {
        //todo
        print("cubess");
        //Destroy(gameObject);
    }
}
