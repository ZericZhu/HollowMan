using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackCollide : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "enemy")
        {
            Debug.Log("Die!");
            Destroy(other.gameObject);
        }
    }
}
