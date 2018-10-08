using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {

    public List<GameObject> currentPlatforms;
    public List<GameObject> prefabSelection;

	void Update () {
		
        if(currentPlatforms[0].transform.position.x <= this.transform.position.x - 8)
        {

            currentPlatforms = UpdatePlatformList (currentPlatforms);

            int randInt = Random.Range (0, prefabSelection.Count);

            GameObject toInstance = prefabSelection[randInt];

            toInstance.transform.position = currentPlatforms [currentPlatforms.Count - 1].transform.position + new Vector3 (4, 0, 0);

            currentPlatforms.Add (Instantiate (toInstance));



        }

	}

    List<GameObject> UpdatePlatformList (List<GameObject> platformList)
    {

        List<GameObject> newList = new List<GameObject>();

        for (int i = 0; i < platformList.Count - 1; i++)
        {

            newList.Add (platformList [i + 1]);

        }

        Destroy (platformList [0]);

        return (newList);

    }

}
