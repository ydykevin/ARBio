using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{

    public GameObject panel;
    private float scale;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void small()
    {
        scale = panel.transform.localScale.x;
        panel.transform.localScale = new Vector3(scale/1.2f, scale / 1.2f, scale / 1.2f);
    }

    public void big()
    {
        scale = panel.transform.localScale.x;
        panel.transform.localScale = new Vector3(scale * 1.2f, scale * 1.2f, scale * 1.2f);
    }
}
