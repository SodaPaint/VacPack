using UnityEngine;
using System.Collections;

public class Interactable : MonoBehaviour 
{
	// Script for managing coin movements.

	// Public Variables
	public float magnetStrength = 5f;//the power of the magnets strength
	public float distanceStretch = 10f;	// Strength, based on the distance
	public int magnetDirection = 1;	// 1 = attact, -1 = repel
	public bool looseMagnet = true;
	public float SuperMagnetStrength = 5f;//holds the defualt value that will reset when the object exits the collider

	// Private Variables
	private Transform trans;
	private Rigidbody thisRd;
	private Transform magnetTrans;
	private bool magnetInZone,SuperMagnetInZone;
	private Vector3 positionToMoveTo;
	void Awake()
	{
		trans = transform;
		thisRd = trans.GetComponent<Rigidbody>();
		
	}

	void FixedUpdate()
	{
		if (magnetInZone)
		{
			
			//this code controls the magitnization to the colliders we set to magnet
			Vector3 directionToMagnet = magnetTrans.position - trans.position;
			float distance = Vector3.Distance(magnetTrans.position, trans.position);
			float magnetDistanceStr = (distanceStretch / distance) * magnetStrength;

			thisRd.AddForce(magnetDistanceStr * (directionToMagnet * magnetDirection), ForceMode.Force);
		}
		if (SuperMagnetInZone)
		{

			//this code controls the magitnization to the colliders we set to magnet
			Vector3 directionToMagnet = magnetTrans.position - trans.position;
			float distance = Vector3.Distance(magnetTrans.position, trans.position);
			float magnetDistanceStr = (distanceStretch / distance) * SuperMagnetStrength;

			thisRd.AddForce(magnetDistanceStr * (directionToMagnet * magnetDirection), ForceMode.Force);
		}
	}

    /*void OnTriggerStay(Collider other)
    {
        if (other.tag == "magnet")
        {

            magnetTrans = other.transform;
            magnetInZone = true;
            thisRd.useGravity = false;

        }

    }*/

    void OnTriggerExit (Collider other)
	{
		if (other.tag == "magnet" && looseMagnet)
		{
			Debug.Log("left magnetzone");
			magnetInZone = false;
			thisRd.useGravity = true;
			
		}

		if (other.tag == "SuperMagnet" && looseMagnet)
		{
			Debug.Log("left magnetzone");
			SuperMagnetInZone = false;
			thisRd.useGravity = true;
			
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "magnet")
		{
			Debug.Log("entered magnetzone");
			magnetTrans = other.transform;
			magnetInZone = true;
			thisRd.useGravity = false;
			
		}

	}

    private void OnTriggerStay(Collider other)
    {
		if (other.tag == "SuperMagnet")
		{
			Debug.Log("entered magnetzone");
			magnetTrans = other.transform;
			SuperMagnetInZone = true;
			thisRd.useGravity = false;

		}
	}


}






