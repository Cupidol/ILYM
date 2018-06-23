using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerInteraction : MonoBehaviour
{
    public bool pickedUp;
	public TextMeshProUGUI guitarInstruction2;

    void Update()
    {
        int layerMask = 1 << 9;
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 4.5f, layerMask))
        {

            if (Input.GetKeyDown(KeyCode.E))
            {
                hit.transform.gameObject.GetComponent<StoryInteractable>().AddToStoryList();
                if (hit.transform.gameObject.name == "guitar")
                {
                    //hit.transform.gameObject.SetActive (false);
					hit.transform.gameObject.GetComponent<MeshRenderer>().enabled = false;
                    pickedUp = true;

                }
                else
                {
                    hit.transform.gameObject.GetComponent<Interactable>().ActivateObject();
                }

            }
			if ((hit.transform.gameObject.name == "polaroid1") || (hit.transform.gameObject.name == "polaroid2")){
				guitarInstruction2.enabled = true;
			}else{
				guitarInstruction2.enabled = false;
			}/*
			if (hit.transform.gameObject.name == "polaroid2"){
				guitarInstruction2.enabled = true;
			}else{
				guitarInstruction2.enabled = false;
			}*/
            }

        }
    }