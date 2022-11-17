using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vacpack : MonoBehaviour
{




    Scene01Script _level01Ctrlr;

    // Start is called before the first frame update
    private void Awake()
    {
        _level01Ctrlr = FindObjectOfType<Scene01Script>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))//swaps the players selection by pressing 4
        {
            _level01Ctrlr.shootItem(_level01Ctrlr.SelectedSlot);
            ;//selection is now the fourth invenotry slot

        }
    }


}
