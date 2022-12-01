using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VacpakNozzle : MonoBehaviour
{

    Scene01Script _level01Ctrlr;
    Vacpack _vacpack;
    // Start is called before the first frame update
    void Start()
    {

        _level01Ctrlr = FindObjectOfType<Scene01Script>();
        _vacpack = FindObjectOfType<Vacpack>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "slime")
        {
            /*_level01Ctrlr.ItemIntake("slime");*/
            if (_level01Ctrlr.ItemIntake("slime") == true) {
                _level01Ctrlr.listCheck();
                Destroy(other.gameObject);
                _vacpack.AccpetedSound();
            }

            else if (_level01Ctrlr.ItemIntake("slime") == false)
            {
                _vacpack.Playdenied();
            }
            _level01Ctrlr.listCheck();

        }
        else if (other.tag == "beat")
        {

            
            if (_level01Ctrlr.ItemIntake("beat") == true)
            {
                _level01Ctrlr.listCheck();
                Destroy(other.gameObject);
                _vacpack.AccpetedSound();
            }
            else if (_level01Ctrlr.ItemIntake("beat") == false)
            {
                _vacpack.Playdenied();
            }
            _level01Ctrlr.listCheck();
        }
        else if (other.tag == "berry")
        {

            
            if (_level01Ctrlr.ItemIntake("berry") == true)
            {
                _level01Ctrlr.listCheck();
                Destroy(other.gameObject);
                _vacpack.AccpetedSound();
            }
            else if (_level01Ctrlr.ItemIntake("berry") == false)
            {
                _vacpack.Playdenied();
            }
            _level01Ctrlr.listCheck();
        }
        else if (other.tag == "chicken")
        {

           
            if (_level01Ctrlr.ItemIntake("chicken") == true)
            {
                _level01Ctrlr.listCheck();
                Destroy(other.gameObject);
                _vacpack.AccpetedSound();
            }
            else if (_level01Ctrlr.ItemIntake("chicken") == false)
            {
                _vacpack.Playdenied();
            }
            _level01Ctrlr.listCheck();
        }
        else if (other.tag == "gem")
        {
           
            if (_level01Ctrlr.ItemIntake("gem") == true)
            {
                _level01Ctrlr.listCheck();
                Destroy(other.gameObject);
                _vacpack.AccpetedSound();
            }
            if (_level01Ctrlr.ItemIntake("gem") == false)
            {
                _vacpack.Playdenied();
            }
            _level01Ctrlr.listCheck();
        }
        else
        {
           /* Debug.Log("should be playing");*/
            _vacpack.Playdenied();
            //we wont accept this item so lets play the denied effects now!
        }

    }
}
