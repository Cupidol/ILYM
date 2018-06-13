using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    public bool pickedUp;

    void Update()
    {
        int layerMask = 1 << 9;
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity, layerMask))
        {

            if (Input.GetKeyDown(KeyCode.E))
            {

                if (hit.transform.gameObject.name == "guitar")
                {
                    hit.transform.gameObject.SetActive (false);
                    pickedUp = true;
                    Debug.Log(hit.transform.gameObject.name);
                }
                else
                {
                    hit.transform.gameObject.GetComponent<DoorButton>().PressButton();
                    Debug.Log(hit.transform.gameObject.name);
                }

            }

            }

        }
    }