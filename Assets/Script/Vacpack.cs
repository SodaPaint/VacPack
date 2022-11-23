using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vacpack : MonoBehaviour
{
    //ammo types
    /*[SerializeField] GameObject _testBullet;*/
    [SerializeField] GameObject _slime;
    [SerializeField] GameObject _beat;
    [SerializeField] GameObject _chicken;
    [SerializeField] GameObject _berry;
    [SerializeField] GameObject _gem;

    //gun settings 
    [SerializeField] int upwardForce, shootForce;
    [SerializeField] Camera fpsCam;
    [SerializeField] Transform attackPoint;
    [SerializeField] float spread = 1;

    //reffrances
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
            
            //first we need to know what slot we are pulling our ammo out of 
            if (_level01Ctrlr._InventoryAmount[_level01Ctrlr.SelectedSlot] > 0)//this line of code will check if our chosen slot has any ammo in it, if it does we will call the fireItem function
            {
                
                fireItem(_level01Ctrlr._InventoryName[_level01Ctrlr.SelectedSlot]);
            }
            _level01Ctrlr.shootItem(_level01Ctrlr.SelectedSlot);
            //selection is now the fourth invenotry slot

        }
    }

    private void fireItem(string itemType)
    {
        //item type is the name of the item we want to fire

        //Find the exact hit position using a raycast
        Ray ray = fpsCam.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0)); //Just a ray through the middle of your current view
        RaycastHit hit;

        //check if ray hits something
        Vector3 targetPoint;
        if (Physics.Raycast(ray, out hit))
            targetPoint = hit.point;
        else
            targetPoint = ray.GetPoint(75); //Just a point far away from the player

        //Calculate direction from attackPoint to targetPoint
        Vector3 directionWithoutSpread = targetPoint - attackPoint.position;

        //Calculate spread
        float x = Random.Range(-spread, spread);
        float y = Random.Range(-spread, spread);

        //Calculate new direction with spread
        Vector3 directionWithSpread = directionWithoutSpread + new Vector3(x, y, 0); //Just add spread to last direction

        //Instantiate bullet/projectile

        if(itemType == "beat")
        {
            GameObject currentBullet = Instantiate(_beat, attackPoint.position, Quaternion.identity); //store instantiated bullet in currentBullet

            //Rotate bullet to shoot direction
            currentBullet.transform.forward = directionWithSpread.normalized;

            //Add forces to bullet
            currentBullet.GetComponent<Rigidbody>().AddForce(directionWithSpread.normalized * shootForce, ForceMode.Impulse);
            currentBullet.GetComponent<Rigidbody>().AddForce(fpsCam.transform.up * upwardForce, ForceMode.Impulse);
        }
        else if (itemType == "slime")
        {
            GameObject currentBullet = Instantiate(_slime, attackPoint.position, Quaternion.identity); //store instantiated bullet in currentBullet

            //Rotate bullet to shoot direction
            currentBullet.transform.forward = directionWithSpread.normalized;

            //Add forces to bullet
            currentBullet.GetComponent<Rigidbody>().AddForce(directionWithSpread.normalized * shootForce, ForceMode.Impulse);
            currentBullet.GetComponent<Rigidbody>().AddForce(fpsCam.transform.up * upwardForce, ForceMode.Impulse);

        }
        else if (itemType == "berry")
        {
            GameObject currentBullet = Instantiate(_berry, attackPoint.position, Quaternion.identity); //store instantiated bullet in currentBullet

            //Rotate bullet to shoot direction
            currentBullet.transform.forward = directionWithSpread.normalized;

            //Add forces to bullet
            currentBullet.GetComponent<Rigidbody>().AddForce(directionWithSpread.normalized * shootForce, ForceMode.Impulse);
            currentBullet.GetComponent<Rigidbody>().AddForce(fpsCam.transform.up * upwardForce, ForceMode.Impulse);

        }
        else if (itemType == "chicken")
        {
            GameObject currentBullet = Instantiate(_chicken, attackPoint.position, Quaternion.identity); //store instantiated bullet in currentBullet

            //Rotate bullet to shoot direction
            currentBullet.transform.forward = directionWithSpread.normalized;

            //Add forces to bullet
            currentBullet.GetComponent<Rigidbody>().AddForce(directionWithSpread.normalized * shootForce, ForceMode.Impulse);
            currentBullet.GetComponent<Rigidbody>().AddForce(fpsCam.transform.up * upwardForce, ForceMode.Impulse);

        }
        else if (itemType == "gem")
        {
            GameObject currentBullet = Instantiate(_gem, attackPoint.position, Quaternion.identity); //store instantiated bullet in currentBullet

            //Rotate bullet to shoot direction
            currentBullet.transform.forward = directionWithSpread.normalized;

            //Add forces to bullet
            currentBullet.GetComponent<Rigidbody>().AddForce(directionWithSpread.normalized * shootForce, ForceMode.Impulse);
            currentBullet.GetComponent<Rigidbody>().AddForce(fpsCam.transform.up * upwardForce, ForceMode.Impulse);

        }
        else
        {
            Debug.Log("item not found");
        }






    }
}
