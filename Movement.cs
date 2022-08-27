using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.LWRP;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    public Rigidbody2D rigidBody;
    public bool isJumping = false;
    public UnityEngine.Experimental.Rendering.Universal.Light2D PointLight;
    public float timer = 0;
    public GameObject player;

    public float force = 70f;
    private float moveSpeed = 1.25f;
    public float DirectionX;

    public bool facingright = true;

    void Flip()
    {
        facingright = !facingright;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1f;
        transform.localScale = Scaler;
    }

    void Start()
    {
        ispaused = false;
        rigidBody = GetComponent<Rigidbody2D>();
    }

    public static int crystalscore;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground" || collision.collider.tag == "Ground2")
        {
            isJumping = false;
        }

        if(collision.gameObject.tag == "ScoreCrystal")
        {
            Destroy(collision.gameObject);
            crystalscore += 1;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground" || collision.collider.tag == "Ground2")
        {
            isJumping = true;
        }
    }

    public void Jump()
    {
        if(isJumping == false)
        {
            rigidBody.AddForce(new Vector2(0, force), ForceMode2D.Force);
        }
    }

    private void FixedUpdate()
    {
        /*if(facingright == false && DirectionX > 1.25f)
        {
            Flip();
        }
        if (facingright == true && DirectionX < 2.5f)
        {
            Flip();
        }*/
        rigidBody.velocity = new Vector2(DirectionX * moveSpeed, rigidBody.velocity.y);
    }

    //public Sprite amfacingright;
    //public Sprite amfacingleft;
    public SpriteRenderer spriterend;
    public GameObject pausemenu;
    public GameObject playerUI;

    public static bool ispaused;

    public static float decreasespeed = 0.01f;

    public Text display_Text;

    void Update()
    {
        display_Text.text = "Score: " + crystalscore.ToString();

        if (PointLight.pointLightOuterRadius < 0)
        {
            SceneManager.LoadScene(4);
        }

        if (rigidBody.gravityScale < 0)
        {
            force = -210;
        }
        if (rigidBody.gravityScale > 0)
        {
            force = 210;
        }

        /*if (Input.GetKeyDown(KeyCode.E))
        {
           player.transform.Rotate(180, 0, 0);
            rigidBody.gravityScale = -0.5f;
        }*/

        /*if(Input.GetKeyDown(KeyCode.Q))
        {
            //player.layer = LayerMask.NameToLayer("Background");
        }*/

        DirectionX = CrossPlatformInputManager.GetAxis("Horizontal") * moveSpeed;
        if (DirectionX == 2.5 || DirectionX == -2.5)
        {
            PointLight.pointLightOuterRadius = PointLight.pointLightOuterRadius + 0.02f;
        }
        if(DirectionX == 2.5)
        {
            spriterend.flipX = false;
        }
        if (DirectionX == -2.5)
        {
            spriterend.flipX = true;
        }
        //rigidBody.velocity = new Vector2(DirectionX * 0.25f, 0);

        if (CrossPlatformInputManager.GetButtonDown("Jump"))
        {
            Jump();
        }


        if (CrossPlatformInputManager.GetButtonDown("Pause"))
        {
            ispaused = true;
            CrossPlatformInputManager.SetButtonUp("Pause");
        }

        if(ispaused == true)
        {
            Time.timeScale = 0;
            pausemenu.SetActive(true);
            playerUI.SetActive(false);
        }

        if(ispaused == false)
        {
            Time.timeScale = 1;
            pausemenu.SetActive(false);
            playerUI.SetActive(true);
        }

        if (CrossPlatformInputManager.GetButtonDown("Resume"))
        {
            ispaused = false;
            CrossPlatformInputManager.SetButtonUp("Resume");
        }

        if (CrossPlatformInputManager.GetButtonDown("B2M"))
        {
            SceneManager.LoadScene(0);
            CrossPlatformInputManager.SetButtonUp("B2M");
        }

        if (CrossPlatformInputManager.GetButtonDown("Restart"))
        {
            SceneManager.LoadScene(2);
            crystalscore = 0;
            CrossPlatformInputManager.SetButtonUp("Restart");
        }

        /*if (CrossPlatformInputManager.GetButtonDown("Play"))
        {
            Time.timeScale = 1;
        }*/

        timer += Time.deltaTime;
        if(timer >= 0.01f)
        {
            PointLight.pointLightOuterRadius = PointLight.pointLightOuterRadius - decreasespeed;
            timer = 0;
        }

        if(PointLight.pointLightOuterRadius <= 0)
        {
            Destroy(PointLight);
        }

        if(Input.GetKey(KeyCode.D) ^ Input.GetKey(KeyCode.A))
        {
            PointLight.pointLightOuterRadius = PointLight.pointLightOuterRadius + 0.01f;
        }
          if (Input.GetKey(KeyCode.D))
         {
             transform.position = new Vector3(transform.position.x + 0.01f, transform.position.y);
         }
         if (Input.GetKey(KeyCode.A))
         {
             transform.position = new Vector3(transform.position.x - 0.01f, transform.position.y);

         }
        if (Input.GetKey(KeyCode.Space) && isJumping == false)
        {
            rigidBody.AddForce(new Vector2(0, -60));
        }
    }
}
