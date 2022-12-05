using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject Bullet,ShootingOffset;
    public float bulletSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //OVRGrabbable grabbable = GetComponent<OVRGrabbable>(); -> What is the different?
        OVRGrabbable grabbable = this.gameObject.GetComponent<OVRGrabbable>();

        if (grabbable.grabbedBy != null)
        {
            if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger,grabbable.grabbedBy.m_controller)&&grabbable.isGrabbed)
            {
                GameObject currentBullet = Instantiate(Bullet, ShootingOffset.transform.position, ShootingOffset.transform.rotation);
                currentBullet.GetComponent<Rigidbody>().AddForce(transform.forward * bulletSpeed, ForceMode.Impulse);
            }
        }
    }
}
