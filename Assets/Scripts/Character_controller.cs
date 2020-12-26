using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Character_controller : MonoBehaviour {

    public float speed = 0.1f;
    Rigidbody2D rigidbody2d;
    float horizontal;
    float vertical;

    public Animator animator;

    public int first_aid_kit_required = 4;
    public int counter_first_aid_kit = 0;

    public int maxHealth = 100;
    public int currentHealth;
    public HealthBarScript healthBar;

    public Text objectives;
    public Text rewards;
    public Canvas information;
    public Canvas details;
    public Canvas endScreen;

    public float timeInvincible = 1.0f;
    public float detailsTime;
    bool isInvincible = false;
    public bool goLevel2 = true;
    float invincibleTimer;
    public float level = 0;
    AudioSource damageSound;

    // Start is called before the first frame update
    void Start () {
        rigidbody2d = GetComponent<Rigidbody2D> ();
        damageSound = GetComponent<AudioSource>();
        currentHealth = maxHealth;
        healthBar.SetMaxHealth (maxHealth);
        endScreen.enabled = false;

        //objectives = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update () {
        if (currentHealth <= 0 && this.goLevel2) {
            this.restartLevel ();
        }
        horizontal = Input.GetAxis ("Horizontal");
        vertical = Input.GetAxis ("Vertical");
        //Debug.Log("Horizontal --> "+horizontal);
        //  Debug.Log("Vertical --> "+vertical);
        //looking
        //0 - > down
        //1 - > up
        //2 - > left
        //3 - > right
        if (horizontal > 0) {
            animator.SetInteger ("looking", 3);
            animator.SetBool ("moving", true);
        }
        if (horizontal < 0) {
            animator.SetInteger ("looking", 2);
            animator.SetBool ("moving", true);
        }
        if (vertical > 0) {
            animator.SetInteger ("looking", 1);
            animator.SetBool ("moving", true);
        }
        if (vertical < 0) {
            animator.SetInteger ("looking", 0);
            animator.SetBool ("moving", true);
        }

        // if(Mathf.Abs(horizontal) < )
        if (horizontal == 0 && vertical == 0) {
            animator.SetBool ("moving", false);
        }
        if (isInvincible) {
            invincibleTimer -= Time.deltaTime;
            if (invincibleTimer < 0) {
                isInvincible = false;
                Color tmp = GetComponent<SpriteRenderer> ().color;
                tmp.a = 1f;
                GetComponent<SpriteRenderer> ().color = tmp;
            }
        }
        if (this.counter_first_aid_kit == this.first_aid_kit_required) {
            this.rewards.text = "- Acceso al almacen? (1/1)";
            if (this.level == 1) this.rewards.text = "- Acceso al Hospital (1/1)";
            this.objectives.color = Color.green;
            this.rewards.color = Color.green;
        } else if (this.level == 1) {
            this.rewards.text = "- Acceso al Hospital (0/1)";
            this.objectives.text = "- Consigue las llaves (" + this.counter_first_aid_kit + "/" + this.first_aid_kit_required + ")";
        }
        if (this.damageSound != null)
        {
            this.damageSound.volume = MusicController.effectsVolume;
        }
    }
    void FixedUpdate () {
        Vector2 position = transform.position;
        position.x = position.x + speed * horizontal * Time.deltaTime;
        position.y = position.y + speed * vertical * Time.deltaTime;

        rigidbody2d.MovePosition (position);

    }
    public void restartLevel () {
        // Application.LoadLevel("Level 2");
        currentHealth = maxHealth;
        SceneManager.LoadScene ("Level " + this.level, LoadSceneMode.Single);
    }
    public void nextLevel () {
        if (counter_first_aid_kit == first_aid_kit_required) {
            //nextlvl
            //SceneManager.LoadScene("SampleScene");
            //restartLevel();
            endScreen.enabled = true;
            information.enabled = false;
            details.enabled = false;

            if (level == 1) {
                SceneManager.LoadScene ("Level 2", LoadSceneMode.Single);
            }
            if (level == 2) {
                SceneManager.LoadScene ("Level 21", LoadSceneMode.Single);
            }
            if (level == 21){
                SceneManager.LoadScene ("Level 22", LoadSceneMode.Single);
            }
            if (level == 22){
                SceneManager.LoadScene ("Level 3", LoadSceneMode.Single);
                

            }

        } else {
            Debug.Log ("there is missing " + (first_aid_kit_required - counter_first_aid_kit) + "first aid kits!");
        }
    }
    public void addFirstAidKit () {
        this.counter_first_aid_kit++;
        this.objectives.text = "- Consigue los botiquienes (" + this.counter_first_aid_kit + "/" + this.first_aid_kit_required + ")";
        if (this.level == 1) this.objectives.text = "- Consigue las llaves (" + this.counter_first_aid_kit + "/" + this.first_aid_kit_required + ")";

    }
    public void gotDamaged (int damage) {
        if (isInvincible) {
            return;
        }
        isInvincible = true;
        invincibleTimer = timeInvincible;

        damageSound.Play();
        //changing sprite opacity
        Color tmp = GetComponent<SpriteRenderer> ().color;

        tmp.a = 0.5f;

        GetComponent<SpriteRenderer> ().color = tmp;

        this.currentHealth = this.currentHealth - damage;
        healthBar.SetHealth (currentHealth);
    }
    public void showDetails () {
        details.enabled = true;
    }
    public void hideDetails () {
        details.enabled = false;
    }

}