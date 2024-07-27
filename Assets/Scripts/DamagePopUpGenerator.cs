using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DamagePopUpGenerator : MonoBehaviour
{
    public static DamagePopUpGenerator current;
    public GameObject prefab;
    
    public void Awake()
    {
        current = this;
    }
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.T))
        {
            Createpopup(new Vector3(1,1,1), Random.Range(0, 100).ToString(), Color.red);
        }
       
    }
    public void Createpopup(Vector3 position, string text, Color color)
    {
        var popup = Instantiate(prefab, position, Quaternion.identity);
        var temp = popup.transform.GetChild(0).GetComponent<TextMeshProUGUI>();
        temp.text = text;
        temp.faceColor = color;

        Destroy(popup, 1f);
        Destroy(temp, 1f);
    }
}
