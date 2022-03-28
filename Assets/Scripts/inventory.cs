using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using TMPro;

public class inventory : MonoBehaviour
{
    [SerializeField] private item[] inv;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < inv.Length; i++)
        {
            inv[i].idOriginal = i;
        }

        orderByID();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void orderByName()
    {
        IEnumerable<item> invTemp =
            from i in inv
            orderby i.name ascending
            select i;

        var tempID = 0;
        foreach (item item in invTemp)
        {
            transform.Find("item"+tempID).gameObject.GetComponent<TMP_Text>().text = item.name;
            tempID++;
        }
    }

    public void orderByID()
    {
        for(int i = 0; i < inv.Length; i++)
        {
            transform.Find("item" + i).gameObject.GetComponent<TMP_Text>().text = inv[i].name;
        }
        
    }
}
