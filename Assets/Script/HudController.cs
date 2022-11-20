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

    [SerializeField] RawImage _nothingSlot02;
    [SerializeField] RawImage _slimeSlot02;
    [SerializeField] RawImage _gemSlot02;
    [SerializeField] RawImage _berrySlot02;
    [SerializeField] RawImage _beatSlot02;
    [SerializeField] RawImage _chickenSlot02;

    [SerializeField] RawImage _nothingSlot03;
    [SerializeField] RawImage _slimeSlot03;
    [SerializeField] RawImage _gemSlot03;
    [SerializeField] RawImage _berrySlot03;
    [SerializeField] RawImage _beatSlot03;
    [SerializeField] RawImage _chickenSlot03;

    [SerializeField] RawImage _nothingSlot04;
    [SerializeField] RawImage _slimeSlot04;
    [SerializeField] RawImage _gemSlot04;
    [SerializeField] RawImage _berrySlot04;
    [SerializeField] RawImage _beatSlot04;
    [SerializeField] RawImage _chickenSlot04;


    [SerializeField] Text _AmoutSlot01;
    [SerializeField] Text _AmoutSlot02;
    [SerializeField] Text _AmoutSlot03;
    [SerializeField] Text _AmoutSlot04;


    Scene01Script _level01Ctrlr;//reference our level o1 script
    private void Awake()
    {

        _level01Ctrlr = FindObjectOfType<Scene01Script>();

    }

    private void Start()
    {


        //PRIOTRITY/// please listen!

        //make these check calls only work after something has been added or taken away. 


        DisplayInventorySlot01(_level01Ctrlr._InventoryName[0]);//we run this once to get the proper set up, we then fill the parameter with the first slots string
        DisplayInventorySlot02(_level01Ctrlr._InventoryName[1]);
        DisplayInventorySlot03(_level01Ctrlr._InventoryName[2]);
        DisplayInventorySlot04(_level01Ctrlr._InventoryName[3]);
        DisplayAmounts(_level01Ctrlr._InventoryAmount[0], _level01Ctrlr._InventoryAmount[1], _level01Ctrlr._InventoryAmount[2], _level01Ctrlr._InventoryAmount[3]);
    }

    // Update is called once per frame
    void Update()
    {
        DisplayInventorySlot01(_level01Ctrlr._InventoryName[0]);//we run this once to get the proper set up, we then fill the parameter with the first slots string
        DisplayInventorySlot02(_level01Ctrlr._InventoryName[1]);
        DisplayInventorySlot03(_level01Ctrlr._InventoryName[2]);
        DisplayInventorySlot04(_level01Ctrlr._InventoryName[3]);
        DisplayAmounts(_level01Ctrlr._InventoryAmount[0], _level01Ctrlr._InventoryAmount[1], _level01Ctrlr._InventoryAmount[2], _level01Ctrlr._InventoryAmount[3]);
    }

    //these are public becuase other programs will be calling the update code

    //i seperated this code becuase i didnt want one giant function
    //definatlly a better more expandable way to create this idea but there is no way im making that right now
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

    public void DisplayInventorySlot02(string item)//this code checks the first slot and turns on the first image that is set.
    {
        string itemType = item;
        switch (itemType)
        {
            case "empty":

                _nothingSlot02.enabled = true;//set the first state as true

                //now everything else becomes false
                _slimeSlot02.enabled = false;
                _gemSlot02.enabled = false;
                _berrySlot02.enabled = false;
                _beatSlot02.enabled = false;
                _chickenSlot02.enabled = false;
                break;
            case "slime":
                _slimeSlot02.enabled = true;//set the first state as true

                //now everything else becomes false
                _gemSlot02.enabled = false;
                _berrySlot02.enabled = false;
                _beatSlot02.enabled = false;
                _chickenSlot02.enabled = false;
                _nothingSlot02.enabled = false;
                break;
            case "berry":
                _berrySlot01.enabled = true;//set the first state as true

                //now everything else becomes false
                _slimeSlot02.enabled = false;
                _gemSlot02.enabled = false;
                _beatSlot02.enabled = false;
                _chickenSlot02.enabled = false;
                _nothingSlot02.enabled = false;
                break;
            case "chicken":
                _chickenSlot02.enabled = true;//set the first state as true

                //now everything else becomes false
                _slimeSlot02.enabled = false;
                _gemSlot02.enabled = false;
                _berrySlot02.enabled = false;
                _beatSlot02.enabled = false;
                _nothingSlot02.enabled = false;
                break;
            case "beat":
                _beatSlot02.enabled = true;//set the first state as true

                //now everything else becomes false
                _slimeSlot02.enabled = false;
                _gemSlot02.enabled = false;
                _berrySlot02.enabled = false;
                _chickenSlot02.enabled = false;
                _nothingSlot02.enabled = false;
                break;
            case "gem":
                _gemSlot02.enabled = true;//set the first state as true

                //now everything else becomes false
                _slimeSlot02.enabled = false;
                _berrySlot02.enabled = false;
                _beatSlot02.enabled = false;
                _chickenSlot02.enabled = false;
                _nothingSlot02.enabled = false;
                break;











        }







    }

    public void DisplayInventorySlot03(string item)//this code checks the first slot and turns on the first image that is set.
    {
        string itemType = item;
        switch (itemType)
        {
            case "empty":
                
                _nothingSlot03.enabled = true;//set the first state as true

                //now everything else becomes false
                _slimeSlot03.enabled = false;
                _gemSlot03.enabled = false;
                _berrySlot03.enabled = false;
                _beatSlot03.enabled = false;
                _chickenSlot03.enabled = false;
                break;
            case "slime":
                _slimeSlot03.enabled = true;//set the first state as true

                //now everything else becomes false
                _gemSlot03.enabled = false;
                _berrySlot03.enabled = false;
                _beatSlot03.enabled = false;
                _chickenSlot03.enabled = false;
                _nothingSlot03.enabled = false;
                break;
            case "berry":
                _berrySlot03.enabled = true;//set the first state as true

                //now everything else becomes false
                _slimeSlot03.enabled = false;
                _gemSlot03.enabled = false;
                _beatSlot03.enabled = false;
                _chickenSlot03.enabled = false;
                _nothingSlot03.enabled = false;
                break;
            case "chicken":
                _chickenSlot03.enabled = true;//set the first state as true

                //now everything else becomes false
                _slimeSlot03.enabled = false;
                _gemSlot03.enabled = false;
                _berrySlot03.enabled = false;
                _beatSlot03.enabled = false;
                _nothingSlot03.enabled = false;
                break;
            case "beat":
                _beatSlot03.enabled = true;//set the first state as true

                //now everything else becomes false
                _slimeSlot03.enabled = false;
                _gemSlot03.enabled = false;
                _berrySlot03.enabled = false;
                _chickenSlot03.enabled = false;
                _nothingSlot03.enabled = false;
                break;
            case "gem":
                _gemSlot03.enabled = true;//set the first state as true

                //now everything else becomes false
                _slimeSlot03.enabled = false;
                _berrySlot03.enabled = false;
                _beatSlot03.enabled = false;
                _chickenSlot03.enabled = false;
                _nothingSlot03.enabled = false;
                break;











        }







    }

    public void DisplayInventorySlot04(string item)//this code checks the first slot and turns on the first image that is set.
    {
        string itemType = item;
        switch (itemType)
        {
            case "empty":

                _nothingSlot04.enabled = true;//set the first state as true

                //now everything else becomes false
                _slimeSlot04.enabled = false;
                _gemSlot04.enabled = false;
                _berrySlot04.enabled = false;
                _beatSlot04.enabled = false;
                _chickenSlot04.enabled = false;
                break;
            case "slime":
                _slimeSlot04.enabled = true;//set the first state as true

                //now everything else becomes false
                _gemSlot04.enabled = false;
                _berrySlot04.enabled = false;
                _beatSlot04.enabled = false;
                _chickenSlot04.enabled = false;
                _nothingSlot04.enabled = false;
                break;
            case "berry":
                _berrySlot04.enabled = true;//set the first state as true

                //now everything else becomes false
                _slimeSlot04.enabled = false;
                _gemSlot04.enabled = false;
                _beatSlot04.enabled = false;
                _chickenSlot04.enabled = false;
                _nothingSlot04.enabled = false;
                break;
            case "chicken":
                _chickenSlot04.enabled = true;//set the first state as true

                //now everything else becomes false
                _slimeSlot04.enabled = false;
                _gemSlot04.enabled = false;
                _berrySlot04.enabled = false;
                _beatSlot04.enabled = false;
                _nothingSlot04.enabled = false;
                break;
            case "beat":
                _beatSlot04.enabled = true;//set the first state as true

                //now everything else becomes false
                _slimeSlot04.enabled = false;
                _gemSlot04.enabled = false;
                _berrySlot04.enabled = false;
                _chickenSlot04.enabled = false;
                _nothingSlot04.enabled = false;
                break;
            case "gem":
                _gemSlot02.enabled = true;//set the first state as true

                //now everything else becomes false
                _slimeSlot04.enabled = false;
                _berrySlot04.enabled = false;
                _beatSlot04.enabled = false;
                _chickenSlot04.enabled = false;
                _nothingSlot04.enabled = false;
                break;











        }







    }

    public void DisplayAmounts(int item01, int item02, int item03, int item04)
    {
        
        _AmoutSlot01.text = item01.ToString();
        _AmoutSlot02.text = item02.ToString();
        _AmoutSlot03.text = item03.ToString();
        _AmoutSlot04.text = item04.ToString();
    }
}
