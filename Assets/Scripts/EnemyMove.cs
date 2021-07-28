using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    int times=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Bullet")
        {
            times++;
            if (times >= 4)
            {
                Destroy(this.gameObject);
            }
        }  
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * 1f * Time.deltaTime);
    }
}
