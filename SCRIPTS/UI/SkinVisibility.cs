using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinVisibility : MonoBehaviour
{
        public GameObject select;
        private MeshRenderer mesh;
        public void popup() {
        mesh = select.GetComponent(typeof(MeshRenderer)) as MeshRenderer;
        if(mesh.enabled == true){
            mesh.enabled = false;
        }
        else{
            mesh.enabled = true;
        }
    }
}
