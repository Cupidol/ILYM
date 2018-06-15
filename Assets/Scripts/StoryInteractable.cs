using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryInteractable : MonoBehaviour {

    public bool isUsed;
   // public SpriteRenderer indicatorSpriteRenderer;
    public GameObject indicator;

    public void Start()
    {
       // indicatorSpriteRenderer = GetComponent<SpriteRenderer>();
    } 
    public void AddToStoryList() {
        if (!StoryManager.Instance.storyList.Contains(this)) {
                 StoryManager.Instance.storyList.Add(this);
            }
        isUsed = true;
        //indicatorSpriteRenderer.enabled = false;
        indicator.GetComponent<SpriteRenderer>().enabled = false;
    }

}
