using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public CharacterController controller;
    public float PlayerHealth = 100;
    public float speed = 12f;
    public float gravity = -9.81f;
    public float jumpHeight = 3f;
    public float SprintAddSpeed = 2f;
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    private bool _PlayerIAlive = true;//if this is false we are dead and our movement script will stop working
    [SerializeField] int ExtraJumpsleft = 2;
    private int _setJumpAmount;

    [SerializeField] AudioSource _deathAudio;
    [SerializeField] AudioSource _jumpAudio;
    [SerializeField] AudioSource _hurtAudio;
    /*[SerializeField] ParticleSystem _HpParticles;*/
    Vector3 velocity;
    public LayerMask groundMask;

    bool isGrounded;
    bool notGrounded;

    PlayerHud playerHud;
    Scene01Script _level01Ctrlr;

    private void Awake()
    {
        _setJumpAmount = ExtraJumpsleft;
        _PlayerIAlive = true;//just make sure we are still alive
        playerHud = FindObjectOfType<PlayerHud>();
        _level01Ctrlr = FindObjectOfType<Scene01Script>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_PlayerIAlive == true)
        {
            isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
            //checks if player is grounded and stop momentum if this is true.
            if (isGrounded && velocity.y < 0)
            {
                ExtraJumpsleft = _setJumpAmount;//sets the Extra jump count back to the standard amount upon hitting the ground.
                velocity.y = -2f;
               
            }




            float x = Input.GetAxis("Horizontal");
            float z = Input.GetAxis("Vertical");

            Vector3 move = transform.right * x + transform.forward * z;


            //movment if we are pressing sprint we move at sprint speed if not we move at walking speed
            if (Input.GetKey(KeyCode.LeftShift) && _PlayerIAlive != false)// sprint speed
            {



                controller.Move(move * speed * SprintAddSpeed * Time.deltaTime);
            }
            else//walking speed
            {
                if (_PlayerIAlive == true)
                {
                    controller.Move(move * speed * Time.deltaTime);
                }
            }

            //damage testing
            if (Input.GetKeyDown(KeyCode.E))// sprint speed
            {

                PlayerWasDamaged(10);


            }


            //when player presses the spacepar and is not on the ground we jump


            if (Input.GetButtonDown("Jump") && isGrounded && _PlayerIAlive != false)
            {
                _jumpAudio.Play();
                velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
                
            }
            if (Input.GetButtonDown("Jump") && ExtraJumpsleft > 0)
            {
                _jumpAudio.Play();
                velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
                ExtraJumpsleft -= 1;
                
            }


            velocity.y += gravity * Time.deltaTime;

            controller.Move(velocity * Time.deltaTime);
        }
    }

    public void PlayerWasDamaged(float damageAmount)
    {

        _hurtAudio.Play();
        PlayerHealth -= damageAmount;
        playerHud.UpdateHp();
        Debug.Log("ouch i took " + damageAmount + " damage");
        if (PlayerHealth == 0)
        {
            PlayerIsDead();
        }


    }

    private void PlayerIsDead()
    {
        _deathAudio.Play();
        
        _PlayerIAlive = false;
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
    }


    /*public void RegenHp(float _hpToRegen)
    {
        PlayerHealth += _hpToRegen;
        _HpParticles.Play();
        playerHud.UpdateHp();
    }*/

}
