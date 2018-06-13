using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryInteractable : MonoBehaviour {

    public bool isUsed;

    public void AddToStoryList() {
        if (!StoryManager.Instance.storyList.Contains(this)) {
                 StoryManager.Instance.storyList.Add(this);
            }

    }

}
