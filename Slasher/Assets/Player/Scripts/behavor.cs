using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class behavor : MonoBehaviour
{
    public int mag = 30;
    public AudioSource gunShot;

    bool isReloading;
    public Animation gun;
    public AnimationClip recoil;
    public AnimationClip reload;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if (mag > 0)
            {
                if (!isReloading)
                {
                    mag -= 1;
                    gunShot.Play();
                    gun.clip = recoil;
                    gun.Play();
                    RaycastHit hit;
                    if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit))
                    {
                        if (hit.collider.gameObject.tag == "Enemy")
                        {
                            hit.collider.gameObject.transform.root.GetComponent<enemyscript>().alive = false;
                        }
                    }
                }
            }
        }
        if(Input.GetKeyDown("r"))
        {
            isReloading = true;
            gun.clip = reload;
            gun.Play();
        }
        if(isReloading)
        {
            if(!gun.isPlaying)
            {
                isReloading = false;
                mag = 30;
            }
        }
    }
}
