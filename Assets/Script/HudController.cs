using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HudController : MonoBehaviour
{

    [SerializeField] RawImage _nothingSlot01;
    [SerializeField] RawImage _slimeSlot01;
    [SerializeField] RawImage _gemSlot01;
    [SerializeField] RawImage _berrySlot01;
    [SerializeField] RawImage _beatSlot01;
    [SerializeField] RawImage _chickenSlot01;

    /*[SerializeField] GameObject _nothingSlot02;
    [SerializeField] GameObject _slimeSlot02;
    [SerializeField] GameObject _gemSlot02;
    [SerializeField] GameObject _berrySlot02;
    [SerializeField] GameObject _beatSlot02;
    [SerializeField] GameObject _chickenSlot02;

    [SerializeField] GameObject _nothingSlot03;
    [SerializeField] GameObject _slimeSlot03;
    [SerializeField] GameObject _gemSlot03;
    [SerializeField] GameObject _berrySlot03;
    [SerializeField] GameObject _beatSlot03;
    [SerializeField] GameObject _chickenSlot03;

    [SerializeField] GameObject _nothingSlot04;
    [SerializeField] GameObject _slimeSlot04;
    [SerializeField] GameObject _gemSlot04;
    [SerializeField] GameObject _berrySlot04;
    [SerializeField] GameObject _beatSlot04;
    [SerializeField] GameObject _chickenSlot04;*/


    Scene01Script _level01Ctrlr;//reference our level o1 script
    private void Awake()
    {

        _level01Ctrlr = FindObjectOfType<Scene01Script>();

    }

    private void Start()
    {
        DisplayInventorySlot01(_level01Ctrlr._InventoryName[0]);//we run this once to get the proper set up, we then fill the parameter with the first slots string
    }

    // Update is called once per frame
    void Update()
    {
        DisplayInventorySlot01(_level01Ctrlr._InventoryName[0]);
    }

    public void DisplayInventorySlot01(string item)//this code checks the first slot and turns on the first image that is set.
    {
        string itemType = item;
        switch (itemType)
        {
            case "empty":
                
                _nothingSlot01.enabled = true;//set the first state as true

                //now everything else becomes false
                _slimeSlot01.enabled = false;
                _gemSlot01.enabled = false;
                _berrySlot01.enabled = false;
                _beatSlot01.enabled = false;
                _chickenSlot01.enabled = false;
                break;
            case "slime":
                _slimeSlot01.enabled = true;//set the first state as true

                //now everything else becomes false
                _gemSlot01.enabled = false;
                _berrySlot01.enabled = false;
                _beatSlot01.enabled = false;
                _chickenSlot01.enabled = false;
                _nothingSlot01.enabled = false;
                break;
            case "berry":
                _berrySlot01.enabled = true;//set the first state as true

                //now everything else becomes false
                _slimeSlot01.enabled = false;
                _gemSlot01.enabled = false;
                _beatSlot01.enabled = false;
                _chickenSlot01.enabled = false;
                _nothingSlot01.enabled = false;
                break;
            case "chicken":
                _chickenSlot01.enabled = true;//set the first state as true

                //now everything else becomes false
                _slimeSlot01.enabled = false;
                _gemSlot01.enabled = false;
                _berrySlot01.enabled = false;
                _beatSlot01.enabled = false;
                _nothingSlot01.enabled = false;
                break;
            case "beat":
                _beatSlot01.enabled = true;//set the first state as true

                //now everything else becomes false
                _slimeSlot01.enabled = false;
                _gemSlot01.enabled = false;
                _berrySlot01.enabled = false;
                _chickenSlot01.enabled = false;
                _nothingSlot01.enabled = false;
                break;
            case "gem":
                _gemSlot01.enabled = true;//set the first state as true

                //now everything else becomes false
                _slimeSlot01.enabled = false;
                _berrySlot01.enabled = false;
                _beatSlot01.enabled = false;
                _chickenSlot01.enabled = false;
                _nothingSlot01.enabled = false;
                break;











        }


    }



}
