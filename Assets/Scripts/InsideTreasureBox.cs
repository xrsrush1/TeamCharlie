using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class InsideTreasureBox : MonoBehaviour
{
    //this script is to detect whether the solar panel entered its respective box
    private AudioSource TreasureAudio;

    public GameObject SolarPanel;
    public Image SolarPanelBg;
    public bool SolarPanelCollected=false;
    // Start is called before the first frame update
    private void Start()
    {
        GetComponent<TriggerCollection>().OnEnterEvent.AddListener(InsideCollector);
        //call this function when on trigger function is called

        // This returns the GameObject named SolarPanel.
        SolarPanel = GameObject.Find("SolarPanel");
        Debug.Log("Solar Panel found");

        //SolarPanelBg = GameObject.Find("SolarimageBg").GetComponent<Image>(); //taking a ref of the objects image component to access it color property
        //Debug.Log("Solar Panel BG found");
        //Debug.Log(SolarPanelBg.tintColor.ToString());

        TreasureAudio = GetComponent<AudioSource>();//to get the audio source on this component
    }

    public void InsideCollector(GameObject Obj)
    {
        //to check if the object going the box is the same as the picture above
        //we has this script for 1 particular script, so we will compare with that set obj only, here with solarpanel

        if (GameObject.ReferenceEquals(Obj, SolarPanel))
        {
            Debug.Log("first and second are the same");
            Obj.SetActive(false);   //making the object disappear when it is in the box
            TreasureAudio.Play(); //to play the audio on collision
            SolarPanelCollected=true;
            Debug.Log(SolarPanelCollected);
        }
        else
            Debug.Log("objects dont match");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
