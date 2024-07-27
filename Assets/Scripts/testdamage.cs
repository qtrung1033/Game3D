using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testdamage : MonoBehaviour
{
    public AttributesManager nhanvat_atm;
    public AttributesManager enemy_atm;

    
   private void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
            nhanvat_atm.dealdamage(enemy_atm.gameObject);
        if (Input.GetKeyDown(KeyCode.P))
            enemy_atm.dealdamage(nhanvat_atm.gameObject);
    }
}
