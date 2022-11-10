using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Scene01Script : MonoBehaviour
{
    
    
    
    [SerializeField] Canvas _InventoryCanvas;

    string[] _InventoryName = new string[] { "empty", "empty", "empty", "empty" };
    int[] _inventoryAmount = new int[] { 0, 0, 0, 0 };


    private void Start()
    {
        _InventoryCanvas.gameObject.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

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
            //Add a slime to invetory
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            //Remove a slime to invetory
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
