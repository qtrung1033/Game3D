using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttributesManager : MonoBehaviour
{
    public int mau;
    public int tancong;
    public float chimang = 1.5f;
    public float chimangq = 0.5f;
    public int giap;
    public Animator animator;
    public Slider thanhmau;

   void Update()
    {
        thanhmau.value = mau;
    }

    public void TakeDamage(int soluong)
    {
        mau -= soluong-(soluong *giap/100);
        DamagePopUpGenerator.current.Createpopup(transform.position, soluong.ToString(), Color.red);
        
        if (mau <= 0)
        {
            animator.SetTrigger("die");
            GetComponent<Collider>().enabled = false;
            
        }
        else
        {
            animator.SetTrigger("damage");
        }
    }
    



    public void dealdamage(GameObject target)
    {
        var atm=target.GetComponent<AttributesManager>();
        if (atm != null)
        {
            float tongdamage = tancong;
            if(Random.Range(0f,1f) < chimangq)
            
                tongdamage = chimang;
                atm.TakeDamage((int)tongdamage);
            
            
        }
    }
}
