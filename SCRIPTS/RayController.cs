using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SMARTS_SDK.Ultrasound;

public class RayController : MonoBehaviour
{
    //public string Taglookup = "raycaster";
    //public GameObject[] raycasters;
    public CollisionReverseRaycast[] script_list;
    public UltrasoundMaterial[] ultrasound_list;
    public float pressure_threshold=0.05f;
    // Start is called before the first frame update
    void Start()
    {
        script_list = FindObjectsOfType<CollisionReverseRaycast>();
        ultrasound_list = FindObjectsOfType<UltrasoundMaterial>();


    }

    // Update is called once per frame
    void Update()
    {
        for (int j = 0; j < ultrasound_list.Length; j++)
        {
            ultrasound_list[j].ShowOnUltrasound = false;
        }
        for (int i = 0; i < script_list.Length; i++)
        {
            if (script_list[0] != null )
            {   
                if (script_list[i].pressure > pressure_threshold)
                {
                    Debug.Log("VEIN COLLAPSED " + "Pressure " +
                        script_list[i].pressure + " OBJECT " + script_list[i].gameObject);
                    for (int j = 0; j < ultrasound_list.Length; j++)
                    {
                        ultrasound_list[j].ShowOnUltrasound = true;
                    }
                }
               
            }   

        }
   
    }
}
