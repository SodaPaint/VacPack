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
    [SerializeField] GameObject _Funnel; 


    //gun settings 
    [SerializeField] int upwardForce, shootForce;
    [SerializeField] Camera fpsCam;
    [SerializeField] Transform attackPoint;
    [SerializeField] float spread = 1;
    [SerializeField] float cooldownTime = 5f;

    //reffrances
    Scene01Script _level01Ctrlr;
    [SerializeField] ParticleSystem _airBurst;
    [SerializeField] ParticleSystem _Burst;
    [SerializeField] ParticleSystem _airSuck;
    [SerializeField] AudioSource _shootAudio;
    [SerializeField] AudioSource _suckAudio;
    [SerializeField] AudioSource _emptyAudio;
    [SerializeField] AudioSource _rejectAudio;
    [SerializeField] AudioSource _AcceptedAudio;
    bool soundActive = false;// a bool that tells the code that vacumme sound is active or not


    //states
    public int VacPackState = 0;
    private bool cool = true;

    private Vector3 scaleChange, scaleZero;
    // Start is called before the first frame update
    private void Awake()
    {
        
        _level01Ctrlr = FindObjectOfType<Scene01Script>();
    }

    // Update is called once per frame
    void Update()
    {
        scaleChange = new Vector3(3, -3, 5);//this is the normal scale of the objectchain
        scaleZero = new Vector3(0, 0, 0);//this is the zero scale of the objectchain 

        if (Input.GetKey(KeyCode.Mouse0))
        {

            if (VacPackState == 0 || VacPackState == 1)
            {
                if (cool) { //if our gun is cool we can shoot
                    VacPackState = 1;
                    //first we need to know what slot we are pulling our ammo out of 
                    if (_level01Ctrlr._InventoryAmount[_level01Ctrlr.SelectedSlot] > 0)//this line of code will check if our chosen slot has any ammo in it, if it does we will call the fireItem function
                    {

                        fireItem(_level01Ctrlr._InventoryName[_level01Ctrlr.SelectedSlot]);
                        StartCoroutine(CooldownCoroutine(cooldownTime));//starts the cooldown function using the cooldown time as a paramter
                        _level01Ctrlr.shootItem(_level01Ctrlr.SelectedSlot);
                    }
                    else
                    {
                        StartCoroutine(CooldownCoroutine(cooldownTime));//starts the cooldown function using the cooldown time as a paramter
                        _emptyAudio.Play();
                    }
                   
                    //selection is now the fourth invenotry slot
                }
            }

        }
        else if (Input.GetKey(KeyCode.Mouse1))//this code will activate the suck feature of the gun.
        {
            
            if (VacPackState == 0 || VacPackState == 2)
            {

                VacPackState = 2;
                _Funnel.transform.localScale = scaleChange;//the collider gets big so it can collide with items
                _Funnel.SetActive(true);
                StartSuckSound();

                //selection is now the fourth invenotry slot
            }
        }
        else
        {
            EndSuckSound();
            VacPackState = 0;
            _Funnel.transform.localScale = scaleZero;//the collider gets small so the items can safely enter triggerExit. and stop their code
            /*_Funnel.SetActive(false);*/
        }

    }


    IEnumerator CooldownCoroutine( float cooldown)
    {

        cool = false;
        yield return new WaitForSeconds(cooldownTime);
        cool = true;

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

        playBurst();// plays the particle system for the air blast

        if (itemType == "beat")
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






    private void playBurst()
    {
        _airBurst.Play();
        _shootAudio.Play();
    }

    private void StartSuckSound()
    {
        
        if (!soundActive) 
        {
            Debug.Log("audipPlaying");
            _suckAudio.Play();
            _airSuck.Play();
            soundActive = true;
        }
    }

    public void Playdenied()
    {
        _rejectAudio.Play();
        _Burst.Play();
    }


    private void EndSuckSound()
    {
        _airSuck.Stop();
        _suckAudio.Stop();
        soundActive = false;
    }

    private void StartEmptySound()
    {
        _emptyAudio.Play();
    }
    
    public void AccpetedSound()
    {
        _AcceptedAudio.Play();
    }

}
