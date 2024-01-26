using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InsideTreasureBox : MonoBehaviour
{
    private AudioSource TreasureAudio;
    // Start is called before the first frame update
    private void Start()
    {
        GetComponent<TriggerCollection>().OnEnterEvent.AddListener(InsideCollector);
        //call this function when on trigger function is called

        TreasureAudio = GetComponent<AudioSource>();//to get the audio source on this component
    }

    public void InsideCollector(GameObject Obj)
    {
        Obj.SetActive(false);   //making the object disappear when it is in the box
        TreasureAudio.Play(); //to play the audio on collision
        
        Debug.Log("Item Collected");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
