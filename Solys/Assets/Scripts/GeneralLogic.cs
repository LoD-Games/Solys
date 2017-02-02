﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralLogic : MonoBehaviour {

	public delegate void Action();
	public static Action StartSimulationEvent;
	public static Action StopSimulationEvent;
	public static Action ResetSimulationEvent;

	public void StartSimulation()
	{
		if(StartSimulationEvent != null)
			StartSimulationEvent();
	}

	public void StopSimulation()
	{
		if(StopSimulationEvent != null)
			StopSimulationEvent();
	}

	public void ResetSimulation()
	{
		if(ResetSimulationEvent != null)
			ResetSimulationEvent();
	}
}
