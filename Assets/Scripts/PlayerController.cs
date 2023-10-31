using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

/*********************************************
 * Th goal of the PLayer Controller is to allow
 * the player to move and jump while playing the
 * game. it detects when the player's rigidbody is
 * on the ground and if it is, it allows the player
 * to jump.
 * 
 * Logan Rudsenske
 * PLayer Controller Versiom 1.0
 ********************************************/


public class PlayerController : MonoBehaviour
{
    [SerializeField] private float jumpForce, gravityModifier;
    [SerializeField] private ParticleSystem explosionParticle, dirtParticle;
    [SerializeField] private AudioClip jumpSound, crashSound;
    private Animator playerAnimation;
    private AudioSource playerAudio;
    private Rigidbody playerRb;
    private bool isOnGround;
    public bool gameOver {get; private set;}

    // Start is called before the first frame update
    private void Start()
    {
         
        isOnGround = true;
        Physics.gravity *= gravityModifier;
        playerRb = GetComponent<Rigidbody>();
        
    }

    // If the player is on the ground then this force is applied when the input for jump is pressed
    // and the player jumps
    private void OnJump(InputValue input)
    {
        if (isOnGround)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    // Detects whether the players rigibody is on the ground and if it is the player can jump
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Ground")
        {
            isOnGround = true;
        }
        GameObject.Find("Player").GetComponent<PlayerController>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Obstacles")
        {
            gameOver = true;
        }    
    }


}
