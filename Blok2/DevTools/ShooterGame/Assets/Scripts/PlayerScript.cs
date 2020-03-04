using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerScript : MonoBehaviour
{
    private void Start()
    {
        animator = GetComponent<Animator>();
        StartCoroutine(PlayerRegeneration());
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        //Every system that is being used non-stop will be called here.
        Move();
        AimingAnimation();
        MouseMovement();
        PlayerHealthSystem();
    }

    //
    //AimingAnimation system voor het animeren van de aiming animation -> normale animatie -> aiming + normale animatie
    //
    private Animator animator;

    public GameObject gun;
    public float change = 10.0f;

    public bool positionchanged = false;
    public bool moving = false;

    public void AimingAnimation()
    {
        if (Input.GetKey(KeyCode.Mouse0) || Input.GetKey(KeyCode.Mouse1))
        {
            animator.SetBool("Aiming", true);
            gun.SetActive(true);
            if (positionchanged == false && moving == true)
            {
                gun.transform.position = new Vector3(gun.transform.position.x, gun.transform.position.y + change, gun.transform.position.z);
                positionchanged = true;
            }
            else if (positionchanged == true && moving == false)
            {
                gun.transform.position = new Vector3(gun.transform.position.x, gun.transform.position.y - change, gun.transform.position.z);
                positionchanged = false;
            }
        }
        else
        {
            animator.SetBool("Aiming", false);
            gun.SetActive(false);
            if (positionchanged == true && moving == false)
            {
                gun.transform.position = new Vector3(gun.transform.position.x, gun.transform.position.y - change, gun.transform.position.z);
                positionchanged = false;
            }
        }
    }

    //
    //Mousemovent system and variables
    //
    public Transform PlayerTransform;

    public Transform Gun;

    public float speedY = 0.05f;
    public float speedX = 0.05f;
    private float yaw = 0.0f;
    private float pitch = 0.0f;

    public void MouseMovement()
    {
        yaw += speedX * Input.GetAxis("Mouse X");
        pitch -= speedY * Input.GetAxis("Mouse Y");

        pitch = Mathf.Clamp(pitch, -20f, 28f);

        transform.eulerAngles = new Vector3(0.0f, yaw, 0.0f);
        PlayerTransform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
        Gun.eulerAngles = new Vector3(pitch, yaw, 0.0f);
    }

    //
    //Movement system and variables
    //
    public float currentSpeed;

    public float strafeDir;
    public bool sprinting = false;

    public void Move()
    {
        moving = false;

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            currentSpeed = 11.5f;
            moving = true;
            this.transform.Translate(new Vector3(0, 0, currentSpeed) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.LeftControl))
        {
            currentSpeed = 13.5f;
            moving = true;
            this.transform.Translate(new Vector3(0, 0, currentSpeed) * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            currentSpeed = 10f;
            moving = true;
            this.transform.Translate(new Vector3(0, 0, -currentSpeed) * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            strafeDir = -1;
            this.transform.Translate(new Vector3(-9, 0, 0) * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            strafeDir = 1;
            this.transform.Translate(new Vector3(9, 0, 0) * Time.deltaTime);
        }

        //Move the player according to input.
        sprinting = false;
        animator.SetFloat("StrafeDir", strafeDir);
        animator.SetFloat("Speed", currentSpeed);
        strafeDir = 0;
        currentSpeed = 0;
    }

    //
    //Player system and variables
    //
    private float _health = 100;

    public float health
    {
        get
        {
            return _health;
        }
        set
        {
            if (value <= 0)
            {
                value = 0;
                _health = value;
                Updatebars();
                Die();
                return;
            }
            if (value >= 100)
            {
                value = 100;
            }

            _health = value;
            Updatebars();
        }
    }

    public int healthMax = 100;
    private float _shield = 100;

    public float shield
    {
        get
        {
            return _shield;
        }
        set
        {
            if (value >= 100)
            {
                value = 100;
            }
            if (value <= 0)
            {
                value = 0;
            }

            _shield = value;
            Updatebars();
        }
    }

    public Image currentShieldbar;
    public Text shieldRatioText;
    public Image currentHealthbar;
    public Text RatioText;

    public void PlayerHealthSystem()
    {
        if (Input.GetKey(KeyCode.P))
        {
            TakeDamage(0.1f);
        }
        if (Input.GetKey(KeyCode.L))
        {
            health += 0.1f;
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            shield = 100;
            Updatebars();
        }

        if (Input.GetKeyDown(KeyCode.O))
        {
            TakeDamage(0.1f);
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            health -= 0.1f;
        }
    }

    //if player takes damage this functie will be used to check if the player got shield or not.
    //it didn't work in the setter / getter

    public void TakeDamage(float damage)
    {
        if (_shield > 0)
        {
            shield -= damage;
        }
        else
        {
            health -= damage;
        }
    }

    public void Takedamage(int damage)
    {
        if (_shield > 0)
        {
            shield -= damage;
        }
        else
        {
            health -= damage;
        }
    }

    //
    //If player dies functie it will acitve this function
    //
    public void Die()
    {
        Debug.Log("YOU DIED");
    }

    //updatebars for de playerUI health and shield an ammo
    public void Updatebars()
    {
        //buggfix is made so retio is working right if I just use / 100 it is going to make it a round number (dont know why)
        float buggfix = 100;

        float healthratio = health / buggfix;
        currentHealthbar.rectTransform.localScale = new Vector3(healthratio, 1, 1);
        RatioText.text = (healthratio * 100).ToString("0") + "%";

        float shieldratio = shield / buggfix;
        currentShieldbar.rectTransform.localScale = new Vector3(shieldratio, 1, 1);
        shieldRatioText.text = (shieldratio * 100).ToString("0") + "%";
    }

    private IEnumerator PlayerRegeneration()
    {
        yield return new WaitForSeconds(60);
        health += 10;
        StartCoroutine(PlayerRegeneration());
    }
}

//
//
//