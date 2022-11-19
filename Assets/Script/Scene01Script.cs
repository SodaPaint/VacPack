using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Scene01Script : MonoBehaviour
{


    public int SelectedSlot = 0;
    [SerializeField] Canvas _InventoryCanvas;

    public string[] _InventoryName = { "empty", "empty", "empty", "empty" };
    public int[] _InventoryAmount = { 0, 0, 0, 0 };

    private void Start()
    {
        _InventoryCanvas.gameObject.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

    }

    void ItemIntake(string ObjectToTake)
    {
        int p = 0;
        int e = 0;
        foreach (string i in _InventoryName )// lets look and see if we have any slots that match!
        {
            
            if (_InventoryName[p] == ObjectToTake)
            {
                
                _InventoryAmount[p] += 1;//using p as our test to see what object we are checking in the loop we can now update the corsponding amount
                //tell the gun to destroy the sucked gameObject.
                
            }
            p += 1;
            if (p == 3 && _InventoryName[0] != ObjectToTake && _InventoryName[1] != ObjectToTake && _InventoryName[2] != ObjectToTake && _InventoryName[3] != ObjectToTake)//ALERT this code isnt tracking if the first lines found anything only if it found something in the last slot
            {
                
                foreach (string c in _InventoryName)
                {
                    if (_InventoryName[e] == "empty")//checks if thier is an empty slot in they inventory array
                    {//if yes then we 

                        _InventoryName[e] = ObjectToTake; //changes the empty slot to a filled slot with the new name.
                        _InventoryAmount[e] += 1;//using r as our test to see what object we are checking in the loop we can now update the corsponding amount
                                                 //tell the gun to destroy the sucked gameObject.
                        break;
                    }
                    e += 1;



                }
            }
        }
    }


    void Update()
    {
        // exit level
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ExitLevel();
        }

        // increase score

        if (Input.GetKeyDown(KeyCode.Q))
        {
            ItemIntake("slime");
            Debug.Log(_InventoryName[0] + "," + _InventoryName[1] + "," + _InventoryName[2] + "," + _InventoryName[3]);
            Debug.Log(_InventoryAmount[0] + "," + _InventoryAmount[1] + "," + _InventoryAmount[2] + "," + _InventoryAmount[3]);
            listCheck();
            //Add a slime to invetory
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            ItemIntake("gem");
            Debug.Log(_InventoryName[0] + "," + _InventoryName[1] + "," + _InventoryName[2] + "," + _InventoryName[3]);
            Debug.Log(_InventoryAmount[0] + "," + _InventoryAmount[1] + "," + _InventoryAmount[2] + "," + _InventoryAmount[3]);
            listCheck();
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            ItemIntake("chicken");
            Debug.Log(_InventoryName[0] + "," + _InventoryName[1] + "," + _InventoryName[2] + "," + _InventoryName[3]);
            Debug.Log(_InventoryAmount[0] + "," + _InventoryAmount[1] + "," + _InventoryAmount[2] + "," + _InventoryAmount[3]);
            listCheck();
            //Add a slime to invetory
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            ItemIntake("beat");
            Debug.Log(_InventoryName[0] + "," + _InventoryName[1] + "," + _InventoryName[2] + "," + _InventoryName[3]);
            Debug.Log(_InventoryAmount[0] + "," + _InventoryAmount[1] + "," + _InventoryAmount[2] + "," + _InventoryAmount[3]);
            listCheck();

        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            ItemIntake("berry");
            Debug.Log(_InventoryName[0] + "," + _InventoryName[1] + "," + _InventoryName[2] + "," + _InventoryName[3]);
            Debug.Log(_InventoryAmount[0] + "," + _InventoryAmount[1] + "," + _InventoryAmount[2] + "," + _InventoryAmount[3]);
            listCheck();
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            Debug.Log(_InventoryName[0] + "," + _InventoryName[1] + "," + _InventoryName[2] + "," + _InventoryName[3]);
            Debug.Log(_InventoryAmount[0]+ "," + _InventoryAmount[1] + "," + _InventoryAmount[2] + "," + _InventoryAmount[3] );
            listCheck();
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))//swaps the players selection by pressing 1
        {
            SelectedSlot = 0;//selection is now the first invenotry slot
            Debug.Log("slot is 1");
            listCheck();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))//swaps the players selection by pressing 2
        {
            SelectedSlot = 1;//selection is now the second invenotry slot
            Debug.Log("slot is 2");
            listCheck();
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))//swaps the players selection by pressing 3
        {
            SelectedSlot = 2;//selection is now the third invenotry slot
            Debug.Log("slot is 3");
            listCheck();
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))//swaps the players selection by pressing 4
        {
            Debug.Log("slot is 4");
            SelectedSlot = 3;//selection is now the fourth invenotry slot
            listCheck();
        }
        


    }

    public void shootItem(int slotChoice)
    {
        if (_InventoryName[slotChoice] != "empty")//were just asking if the selected slot has an item inside of it and isnt empty
        {
           if (_InventoryAmount[slotChoice] > 0)// now we check to make sure the item has an amount to pull from, in simple terms "Got Ammo?"
            {
                _InventoryAmount[slotChoice] -= 1;
                listCheck();//call the script that updates the inventory list.
                //call the vacpacks fire code with the chosen item as an argument
                Debug.Log(_InventoryName[0] + "," + _InventoryName[1] + "," + _InventoryName[2] + "," + _InventoryName[3]);
                Debug.Log(_InventoryAmount[0] + "," + _InventoryAmount[1] + "," + _InventoryAmount[2] + "," + _InventoryAmount[3]);
            }
            listCheck();
        }
        else
        {
            //call the vapacks non intake code
        }



    }


    private void listCheck()
    {
        int numberKeeper = 0;
        foreach (int c in _InventoryAmount)
        {
            if (_InventoryAmount[numberKeeper] == 0)//checks if thier is an empty slot in they inventory array
            {//if yes then we 

                _InventoryName[numberKeeper] = "empty";
                

            }
            numberKeeper++;
            


        }


    }

    public void addSlime()
    {
        //run a for loop that looks for an slot with the empty keyword
        // if a slot is open add a slime to the slot
        // if not return 
    }


    public void ExitLevel()
    {
        
        /*SceneManager.LoadScene("MainMenu");*/
    }

    public void Retry()
    {
        
        /*SceneManager.LoadScene("Level01");*/
    }

 
}
