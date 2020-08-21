using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    public Renderer rend;
    public GameObject Obj1;
    // Start is called before the first frame update
    void Start()
    {
        rend.GetComponent<Renderer>();
        rend.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < 100; i++)
        {
            Debug.Log(Obj1 + " : " + i);
            checkTag(i);
        }

    }

    private void checkTag(int i)
    {
        if (Obj1.tag == "Red")
        {
            if (i == 100)
            {
                Obj1.SetActive(false);
            }

        }
        else if (Obj1.tag == "Blue") {
            if (i >= 200 && i <= 250)
            {
                rend.enabled = false;
            }
        }
    }
}
