using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class HelpButton : MonoBehaviour {

    void Start()
    {
        int activeScene = SceneManager.GetActiveScene().buildIndex;
        GetComponent<Button>().interactable = HelperTextData.GetRussian(activeScene).Length != 0;
    }

    public void OnClick()
    {
        GameObject.Find("Helper").GetComponent<Helper>().ShowTipAgain();
    }
}
