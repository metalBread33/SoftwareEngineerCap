using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponAttack : MonoBehaviour
{
    public Animator animator;

    [SerializeField] public Transform SwordAttackPoint;

    [SerializeField] public float SwordAttackRange= 0.5f;

    public LayerMask enemyLayers;

    // Start is called before the first frame update
    void Update()
    {
        //when q is pressed, it calles function sword a
        if (Input.GetKeyDown(KeyCode.Q)) {
            SwordA();
        }
    }

    //triggers sword attack condition and plays the animation 
    void SwordA()
    {
        animator.SetTrigger("SwordAttack");
        Collider2D[] hitEnemies= Physics2D.OverlapCircleAll(SwordAttackPoint.position, SwordAttackRange, enemyLayers);

        foreach (Collider2D enemy in hitEnemies)
        {
            Debug.Log("We hit: ");
        }
    }


}

