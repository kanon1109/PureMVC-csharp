using UnityEngine;
using System.Collections;
using Assets.scripts.controller;

public class Main : MonoBehaviour
{
	// Use this for initialization
	void Start () 
    {
        this.startMvc();
	}

    void startMvc()
    {
        ModelCommand m = new ModelCommand();
        ViewCommand v = new ViewCommand();
        InitDataCommand dataCommand = new InitDataCommand();
        m.execute(null);
        v.execute(null);
        dataCommand.execute(null);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
