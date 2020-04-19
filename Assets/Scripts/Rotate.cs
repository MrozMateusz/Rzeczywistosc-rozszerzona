using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rotate : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gameObject;
    public GameObject gameObject2;
    public GameObject house;

    public Button lewobt;
    public Button prawobt;

    public void Obr_Lewo()
    {
        gameObject.transform.Rotate(new Vector3(0, Time.deltaTime * 150, 0));
        gameObject2.transform.Rotate(new Vector3(0, Time.deltaTime * 150, 0));
        house.transform.Rotate(new Vector3(0, Time.deltaTime * 150, 0));
    }

    public void Obr_Up()
    {
        gameObject.transform.Rotate(new Vector3(Time.deltaTime * 150, 0, 0));
        gameObject2.transform.Rotate(new Vector3(Time.deltaTime * 150, 0, 0));
        house.transform.Rotate(new Vector3(Time.deltaTime * 150, 0, 0));
    }
    public void Obr_Down()
    {
        gameObject.transform.Rotate(new Vector3(Time.deltaTime * -150, 0, 0));
        gameObject2.transform.Rotate(new Vector3(Time.deltaTime * -150, 0, 0));
        house.transform.Rotate(new Vector3(Time.deltaTime * -150, 0, 0));
    }
    public void Obr_Prawo()
    {
       gameObject.transform.Rotate(new Vector3(0, Time.deltaTime * -150, 0));
       gameObject2.transform.Rotate(new Vector3(0, Time.deltaTime * -150, 0));
        house.transform.Rotate(new Vector3(0, Time.deltaTime * -150, 0));
    }

}
