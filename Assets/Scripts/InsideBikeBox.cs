using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InsideBikeBox : MonoBehaviour
{
    //this script is to detect whether the solar panel entered its respective box
    private AudioSource TreasureAudio;

    public GameObject Bike;
    public bool BikeCollected = false;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<TriggerCollection>().OnEnterEvent.AddListener(InsideCollector);
        //call this function when on trigger function is called

        // This returns the GameObject named SolarPanel.
        Bike = GameObject.Find("Bicycle");
        Debug.Log("Bicycle found");

        TreasureAudio = GetComponent<AudioSource>();//to get the audio source on this component
    }
    public void InsideCollector(GameObject Obj)
    {
        //to check if the object going the box is the same as the picture above
        //we has this script for 1 particular script, so we will compare with that set obj only, here with solar panel

        if (GameObject.ReferenceEquals(Obj, Bike))
        {
            Debug.Log("first and second are the same");
            Obj.SetActive(false);   //making the object disappear when it is in the box
            TreasureAudio.Play(); //to play the audio on collision
            BikeCollected = true;
            Debug.Log(BikeCollected);
        }
        else
            Debug.Log("objects dont match");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
