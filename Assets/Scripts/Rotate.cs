using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rotate : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gameObject;

    public void Obr_Lewo()
    {
        gameObject.transform.Rotate(new Vector3(0, Time.deltaTime * 150, 0));
      
    }

    public void Obr_Up()
    {
        gameObject.transform.Rotate(new Vector3(Time.deltaTime * 150, 0, 0));
      
    }
    public void Obr_Down()
    {
        gameObject.transform.Rotate(new Vector3(Time.deltaTime * -150, 0, 0));
      
    }
    public void Obr_Prawo()
    {
       gameObject.transform.Rotate(new Vector3(0, Time.deltaTime * -150, 0));
       
    }

    public void restart()
    {
        gameObject.transform.Rotate(new Vector3(0, 0, 0));
    }

}
