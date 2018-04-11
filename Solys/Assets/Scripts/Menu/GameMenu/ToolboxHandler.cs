using UnityEngine;
using UnityEngine.UI;

public class ToolboxHandler : MonoBehaviour {

    private GameObject writer;
    private int fullClearCounter = 0;

	// Use this for initialization
	void Start () {
        writer = GameObject.Find("LineWriter");
        //Debug.Log(writer.name);
	}
	
    void OnEnable()
    {
        GeneralLogic.StartSimulationEvent += HideToolbox;
        GeneralLogic.StopSimulationEvent += ShowToolbox;
    }

    void OnDisable()
    {
        GeneralLogic.StartSimulationEvent -= HideToolbox;
        GeneralLogic.StopSimulationEvent -= ShowToolbox;
    }

    private void HideToolbox()
    {
        GetComponent<Animator>().ResetTrigger("Enter");
        GetComponent<Animator>().SetTrigger("Exit");
    }

    private void ShowToolbox()
    {
        GetComponent<Animator>().ResetTrigger("Exit");
        GetComponent<Animator>().SetTrigger("Enter");
    }

    public void valueChange(bool isWriter)
    {
        //Debug.Log(isWriter);
        if (isWriter)
        {
            fullClearCounter = 0;
            writer.GetComponent<LineWriter>().ChangeTool(0);
        }
        else
            writer.GetComponent<LineWriter>().ChangeTool(1);           

    }

    public void FullResetClickCounter(bool isEraser)
    {
        fullClearCounter++;
        if (fullClearCounter > 2 && isEraser)
        {
            ClearAll();
        }
    }

    private void ClearAll()
    {
        fullClearCounter = 0;
        if (GameObject.Find("Play").GetComponent<PlayButton>().IsPlaying == false)
        {
            transform.Find("Writer").GetComponent<Toggle>().isOn = true;
            GeneralLogic.ResetSimulationEvent();
        }
    }
}
