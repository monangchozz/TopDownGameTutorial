using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    Animator animator;

    public void Start() {
        animator = GetComponent<Animator>();
    }
    public float Health{
        set{
            health = value;
            if (health <= 0){
                Defeated();
            }
        }
        get{
            return health;
        }
    }
    public float health = 1; 

    public void Defeated(){
        animator.SetTrigger("isDead");
    }

    public void Destroyed(){
        Destroy(gameObject);
    }
        

}
