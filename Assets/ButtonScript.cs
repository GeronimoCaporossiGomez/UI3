using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public InputField input_nombe;
    

    // Start is called before the first frame update
    public void EscribirNombreEnConsola()
    {
        string Contra = "mami";
        string MEME = input_nombe.text;
        Debug.Log(input_nombe.text);
        if (MEME == Contra)
        {
            Debug.Log("Access Granted");

        }
        else
        {
            Debug.Log("Access Denied");
        }

    }
    void Start()

    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
