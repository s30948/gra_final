using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {

       if (!collision.gameObject.CompareTag("Player"))
        {
            return;
        }

      Inventory inventory = collision.gameObject.GetComponent<Inventory>();

        Destroy(gameObject);
    }
}
