using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Scene01Script : MonoBehaviour
{
    
    
    
    [SerializeField] Canvas _InventoryCanvas;

    string[] _InventoryName = { "empty", "empty", "empty", "empty" };
    int[] _InventoryAmount = { 0, 0, 0, 0 };

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
            
            if (i == ObjectToTake)
            {
                
                _InventoryAmount[p] += 1;//using p as our test to see what object we are checking in the loop we can now update the corsponding amount
                //tell the gun to destroy the sucked gameObject.
                break;//we stop running this script
            }
            p += 1;
            if (p == 3 && i != ObjectToTake)
            {
                
                foreach (string c in _InventoryName)
                {
                    if (c == "empty")//checks if thier is an empty slot in they inventory array
                    {//if yes then we 

                        _InventoryName[e] = ObjectToTake; //changes the empty slot to a filled slot with the new name.
                        _InventoryAmount[e] += 1;//using r as our test to see what object we are checking in the loop we can now update the corsponding amount
                                                 //tell the gun to destroy the sucked gameObject.
                        break;//we stop running this script
                    }
                    e += 1;



                }
            }
        }

        /*int e = 0;                       
        foreach (string i in _InventoryName)
        {
            if (i == "empty")//checks if thier is an empty slot in they inventory array
            {//if yes then we 

                _InventoryName[e] = ObjectToTake; //changes the empty slot to a filled slot with the new name.
                _InventoryAmount[e] += 1;//using r as our test to see what object we are checking in the loop we can now update the corsponding amount
                //tell the gun to destroy the sucked gameObject.
                break;//we stop running this script
            }
            e += 1;



        }*/

        //since we couldnt find a slot to fit it we will now tellt he gun to deny the object
        //deny object call


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
            ItemIntake("Slime");
            //Add a slime to invetory
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            ItemIntake("Gem");
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            ItemIntake("chiken");
            //Add a slime to invetory
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            ItemIntake("beat");
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            ItemIntake("Berry");
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            Debug.Log(_InventoryName[0] + "," + _InventoryName[1] + "," + _InventoryName[2] + "," + _InventoryName[3]);
            Debug.Log(_InventoryAmount[0]+ "," + _InventoryAmount[1] + "," + _InventoryAmount[2] + "," + _InventoryAmount[3] );
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
