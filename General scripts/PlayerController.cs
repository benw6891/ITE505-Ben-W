using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    
    //references the rigidbody of the player, the player, and the respawn object 
    public Rigidbody rb;
    public Transform Player;
    public Transform respawn;

    //Controls player move speed
    public float moveSpeed = 20f;

    //variables for WASD movement 
    private float xInput;
    private float zInput;

    //variables for health bar
    public int maxHealth = 20;
    static int currentHealth;
    //references health bar
    public HealthBar healthBar;
 
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        //movement
        Move();
    }

    //listens to see if player is inputting movement (horizontal an vertical are built in Unity functions)
    private void ProcessInputs()
    {
        xInput = Input.GetAxis("Horizontal");
        zInput = Input.GetAxis("Vertical");

    }

    private void Move()
    {
        rb.AddForce(new Vector3(xInput, 0f, zInput) * moveSpeed);
    }
    
    void Start()
    {
        //for health bar, when game is started, current health is set to max health. Second line updates the bar.
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

      //Checks for inputs/movement
    void Update()
    {
        ProcessInputs();


        //respawn stuff
        //if the position of the ball is less than the threshold set above
        if(transform.position.y < threshold)
        {
            RespawnPlayer();
        }

        bool restart = Input.GetKeyDown(KeyCode.R);


        //sends player back to the beginning of the current level
        if (restart)
        {
            currentHealth = maxHealth;
            healthBar.SetMaxHealth(maxHealth);
            healthBar.SetHealth(currentHealth);
            RespawnPlayer();
        } 

        bool reset = Input.GetKeyDown(KeyCode.P);

        //sends player to beginning of the game (level 1)
        if (reset) 
        {
            SceneManager.LoadScene(1);
        }

        bool menu = Input.GetKeyDown(KeyCode.M);

        //sends player to the main menu
        if (menu)
        {
            SceneManager.LoadScene(0);
        }
    } 

    //when damage is taken, damage is subtracted from current health 
    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        //updates health bar
        healthBar.SetHealth(currentHealth);

        if (currentHealth <= 0)
            {   
                //respawns player once health is gone 
                RespawnPlayer();
            }
    }


//Fall Damage section

    public Vector3 enterPos;
    public Vector3 exitPos;
    public AudioClip falldamagesound;

    //when the player hits a collider with the terrain tag
    void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Terrain")
        {
            print("enter");
            enterPos = transform.position;

            //next 3 if statements are for fall damage (if player falls this far, do this much dmg). ALso a sound effect plays. 
            if(exitPos.y - enterPos.y > 5) 
            {
                print("falling dmg");

                TakeDamage(5);
                AudioSource.PlayClipAtPoint(falldamagesound, transform.position);
            }
            
            if(exitPos.y - enterPos.y > 6)
            {
                print("falling dmg");

                TakeDamage(6);
                AudioSource.PlayClipAtPoint(falldamagesound, transform.position);
            }

            if(exitPos.y - enterPos.y > 8)
            {
                print("falling dmg");

                TakeDamage(10);
                AudioSource.PlayClipAtPoint(falldamagesound, transform.position);
            }
        }

        //if player lands on a spring object
        else if (col.tag == "Absorb") {
            TakeDamage(0);

            enterPos = transform.position;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if(col.tag == "Terrain")
        {
            exitPos = transform.position;
        }

        //when the player leaves the spring object 
        else if (col.tag == "Absorb") {
            TakeDamage(0);

            exitPos = transform.position;
        }
    }

//Respawn section
    
    //when this method is called, it will move the player back to the 'respawn' empty object 

    public void RespawnPlayer()
    {
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        rb.Sleep();
        Player.position = respawn.position;

        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        healthBar.SetHealth(currentHealth);
    }

     //threshold for reset (can be set per level in the scene)
    public float threshold = -10f;

    //rest of the code is in the void Update section 

}