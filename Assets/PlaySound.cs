using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] soundObjects;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playSounds()
    {
        for ( int i = 0; i < soundObjects.Length; i ++)
        {
            soundObjects[i].GetComponent<StartSound>().startMusic();
        }
    }
}
