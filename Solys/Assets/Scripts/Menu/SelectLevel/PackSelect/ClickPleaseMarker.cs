using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickPleaseMarker : MonoBehaviour {

    SelectPackButton pack;


    void Start () {
         pack = transform.parent.gameObject.GetComponent<SelectPackButton>();

        if (pack.locked && PrefsDriver.GetAvailableStars() >= pack.Cost)
            gameObject.SetActive(true);
        else
            gameObject.SetActive(false);
	}
	
	void Update()
    {
        if (!pack.locked)
            gameObject.SetActive(false);
    }
}
