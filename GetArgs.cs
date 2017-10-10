using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Net;

public class GetArgs : MonoBehaviour {

	public Text agad;
	private string Code = "16A696";
	private string Code_r = "";
	void Start () {
		string[] args = System.Environment.GetCommandLineArgs ();
		string input = "";
		for (int i = 0; i < args.Length; i++) {
			if (args [i].Contains("code")) {
				Code_r = args[i].Split('=')[1];
			}
		}
	}

	void Update () {
		if (Code != Code_r) {
			agad.text = "Hatalı Serial, Serialiniz: " + Code_r;
			Application.Quit();
		} else {
			agad.text = "Doğru Serial";
			//Kodlarınız
		}
	}
}
