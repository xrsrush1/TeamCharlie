using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InsideTrashCollector : MonoBehaviour
{
    private AudioSource CollectionAudio;
    private int CollectCount = 0;
    //public GameObject ExitUI;
    //private bool swordVisible = false;
    // This script is used to disable any obj that enters the collector

    private void Start()
    {
        GetComponent<TriggerCollection>().OnEnterEvent.AddListener(InsideCollector);
        //call this function when on trigger function is called

        CollectionAudio = GetComponent<AudioSource>();//to get the audio source on this component
    }
    public void InsideCollector(GameObject Obj)
    {
        Obj.SetActive(false);
        CollectionAudio.Play(); //to play the audio on collision
        this.CollectCount++; //to count the no of items collected by the player
        Debug.Log("Item Collected");

        if (CollectCount == 5) //if count is 5, we ask the player to stop collection by audio feedback
        {
            Debug.Log("Collected items: 5");

            //now, after 5 items are collected, we have to make the exit button visible
            //ExitUI = GameObject.FindWithTag("ExitBtn");
            //ExitUI.SetActive(true);
        }
        
    }

    public void Update()
    {
       
    }
}
