using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLife : MonoBehaviour
{
    private Animator anim;

    // Start is called before the first frame update
    private void Start()
    {
        anim=GetComponent<Animator>();
    }

    private void onCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Trap"))
        {
           Die();
        }
    }

    private void Die()
    {
        anim.SetTrigger("death");
      
    
    

   
    }

}