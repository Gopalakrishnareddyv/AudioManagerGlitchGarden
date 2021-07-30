using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attackers : MonoBehaviour
{
    // Start is called before the first frame update
    [Range(-1f, 2f)]
    public float lizardWalkSpeed;
    Animator lizardAnim;
    SpriteRenderer lizardSprite;
    //public GameObject currentObject;
    float currentDamage = 10.0f;


    void Start()
    {
        lizardAnim = GetComponent<Animator>();
        Rigidbody2D rb = gameObject.AddComponent<Rigidbody2D>();
        lizardSprite = GetComponent<SpriteRenderer>();
        rb.isKinematic = true;
    }

    // Update is called once per frame
    void Update()
    {
        //if (!currentObject)
        //{
         //   lizardAnim.SetBool("isAttacking", false);

        //}
        if (lizardWalkSpeed > 0)
        {
            lizardSprite.flipX = false;
            transform.Translate(Vector3.left * lizardWalkSpeed * Time.deltaTime);

        }




    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        lizardAnim.SetBool("isAttacking", true);
        StrikeCurrentTarget(currentDamage);


    }

    public void SetSpeed(float speed)
    {
        lizardWalkSpeed = speed;
    }

    public void StrikeCurrentTarget(float currentdamage)
    {
        GameObject.FindObjectOfType<Health>().HealthDamage(currentdamage);
        /*  if (currentObject)
          {
            Health health=  currentObject.GetComponent<Health>();
              if(health)
              {
                  health.HealthDamage(currentdamage);
              }
          }*/
    }

    public void Attack(GameObject obj)
    {
        currentObject = obj;
    }
}