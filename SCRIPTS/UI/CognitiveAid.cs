﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CognitiveAid : MonoBehaviour
{
    public GameObject select;
        public void popup() {
        if(select.activeInHierarchy == true){
            select.SetActive(false);
        }
        else{
            select.SetActive(true);
        }
    }
}
