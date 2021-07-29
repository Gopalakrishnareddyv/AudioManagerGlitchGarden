using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attackers : MonoBehaviour
{
    [Range(-1f, 2f)]
    public float lizardSpeed;
    Animator lizardAnim;
    // Start is called before the first frame update
    void Start()
    {
        lizardAnim = GetComponent<Animator>();
        //lizardAnim.SetTrigger("isAppear");
        if (lizardSpeed > 0)
        {
            lizardAnim.SetTrigger("isAppear");



        }
    }

    // Update is called once per frame
    void Update()
    {

        if (lizardSpeed > 0)
        {

            lizardAnim.SetTrigger("isWalk");
            transform.Translate(Vector3.left * lizardSpeed * Time.deltaTime);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            lizardSpeed = 0f;
            lizardAnim.SetTrigger("isAttack");
            
        }
        else if (collision.gameObject.tag == "Stone")
        {
            lizardAnim.SetTrigger("isFoxJump");
        }
    }
    
}
