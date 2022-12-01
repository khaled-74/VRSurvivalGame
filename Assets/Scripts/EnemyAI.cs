using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.AI;
//using UnityEngine.AI;
public class EnemyAI : MonoBehaviour
{
    NavMeshAgent agent;
    public Transform player;
    Animator animator;

    // public LayerMask whatIsGround, whatIsPlayer;

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();

    }
    private void Update()
    {
        agent.SetDestination(player.position);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            animator.SetBool("isDead", true);
            GetComponent<CapsuleCollider>().enabled = false;
            GetComponent<EnemyAI>().enabled = false;
            GetComponent<NavMeshAgent>().enabled = false;
            Destroy(this.gameObject,10);
        }
    }

}
