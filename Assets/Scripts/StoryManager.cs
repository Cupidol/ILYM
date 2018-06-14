using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryManager : MonoBehaviour {
    public static StoryManager Instance;
	public List<StoryInteractable> storyList = new List<StoryInteractable>();


    public void Update()
    {
        if (storyList.Count >= 3) {
            Debug.Log("There are 3 things in the story list.");
        }
    }
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
