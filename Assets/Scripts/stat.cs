using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class stat : MonoBehaviour
{
    private TMP_InputField statText;
    // Start is called before the first frame update
    void Start()
    {
        statText = GetComponent<TMP_InputField>();
        randomStat.randomStatEvent += random;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void random()
    {
        statText.text = Random.Range(1, 20).ToString();
    }
}
