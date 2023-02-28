using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform arCamera;
    public GameObject projectile;
    public float shootForce = 700.0f;
    
    RaycastHit hit;
    // Update is called once per frame
    void Update(){
        if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began){
            GameObject bullet = Instantiate(projectile, arCamera.position, arCamera.rotation) as GameObject;
            bullet.GetComponent<Rigidbody>().AddForce(arCamera.forward * shootForce);
        }
        if(Input.GetKeyDown(KeyCode.Space)){
        	GameObject bullet = Instantiate(projectile, arCamera.position, arCamera.rotation) as GameObject;
            bullet.GetComponent<Rigidbody>().AddForce(arCamera.forward * shootForce);
        }
    }
}
