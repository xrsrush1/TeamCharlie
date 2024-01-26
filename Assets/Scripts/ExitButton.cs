using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitButton : MonoBehaviour
{
    GameObject aitriggerBike;
    InsideBikeBox insideBikeBox;

    GameObject aitriggerSolar;
    InsideTreasureBox insideTreasureBox;

    GameObject aitriggerTurbine;
    InsideTurbineBox insideTurbineBox;

    GameObject aitriggerSapling;
    InsideSaplingBox insideSaplingBox;

    GameObject aitriggerBin;
    InsideBinBox insideBinBox;

    public GameObject NextUI;
    // Start is called before the first frame update
    void Start()
    {
        aitriggerBike = GameObject.Find("aitriggerBike"); //find collider
        insideBikeBox = aitriggerBike.GetComponent<InsideBikeBox>(); //find script on the collider

        aitriggerSolar = GameObject.Find("aitriggerSolar");
        insideTreasureBox = aitriggerSolar.GetComponent<InsideTreasureBox>();

        aitriggerTurbine = GameObject.Find("aitriggerTurbine");
        insideTurbineBox = aitriggerTurbine.GetComponent<InsideTurbineBox>();

        aitriggerSapling = GameObject.Find("aitriggerSapling");
        insideSaplingBox = aitriggerSapling.GetComponent<InsideSaplingBox>();

        aitriggerBin = GameObject.Find("aitriggerBin");
        insideBinBox = aitriggerBin.GetComponent<InsideBinBox>();

        NextUI = GameObject.FindWithTag("ExitBtn");
        Debug.Log("next UI found");
    }

    // Update is called once per frame
    void Update()
    {
        if (insideBikeBox.BikeCollected && insideTreasureBox.SolarPanelCollected 
                && insideTurbineBox.TurbineCollected && insideSaplingBox.SaplingCollected && insideBinBox.BinCollected) 
                //checking if all the item are collected
        {
            //if all items are collected, we enable the next button
            //now, after 5 items are collected, we have to make the exit button visible
            
            NextUI.SetActive(true);
        }

    }
}
