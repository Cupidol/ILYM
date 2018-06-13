using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryManager : MonoBehaviour {
    public static StoryManager Instance;
	public List<StoryInteractable> storyList = new List<StoryInteractable>();

    private void Awake(){
        if (Instance == null)
        {
            Instance = this;
        }
        else {
            Destroy(gameObject);
        }
    }


}
