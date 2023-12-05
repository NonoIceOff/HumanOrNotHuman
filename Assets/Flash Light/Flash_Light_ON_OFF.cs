using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flash_Light_ON_OFF : MonoBehaviour
{
    public bool isOn = false;
    public GameObject lightSource;
    public AudioSource clickSound;
    public bool failSafe = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetButtonDown("KeyCode.F"))
        {
            if (isOn == false && failSafe == false)

            {
                failSafe = true;
                lightSource.SetActive(true);
                clickSound.Play();
                isOn = true;
                StartCoroutine(FailSafe());
            }

            if (isOn == true && failSafe == false)
            {

                failSafe = true;
                lightSource.SetActive(false);
                clickSound.Play();
                isOn = false;
                StartCoroutine(FailSafe());

            }
        }

    IEnumerator FailSafe()
        {
            yield return new WaitForSeconds(0.25f);
            failSafe = false;


        }
        */

    



        if(Input.GetKeyDown(KeyCode.F))
        {
            GetComponent<Light>().enabled = !GetComponent<Light>().enabled;
            clickSound.Play();
        }

    }
}



