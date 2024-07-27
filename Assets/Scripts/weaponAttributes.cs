using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponAttributes : MonoBehaviour
{
    public AttributesManager atm;
    public int damageAmount = 20;
    private void OnTriggerEnter(Collider other)
    {
       
        if (other.CompareTag("quaivat"))
        {
            
            other.GetComponent<AttributesManager>().TakeDamage(atm.tancong);
        }
    }

}
