using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseEntity : MonoBehaviour
{
    [HideInInspector] public string state = "idle";
    [HideInInspector] public string returnState = "";
    [HideInInspector] public Vector2 aimDir = new Vector2(0, 0);
    [HideInInspector] public Vector2 movDir = new Vector2(0, 0);
    
    [Header("Properties")]
    public string typeID;
    public BaseController controller;
    public List<BaseBehaviour> behaviours = new();

    [Header("Generated")]
    public string typeName;



    private void Start()
    {
        init();
    }

    private void Update()
    {
        foreach(BaseBehaviour b in behaviours)
        {
            if(b.targetState == state) b.exec(movDir, aimDir, returnState, Time.deltaTime);
        }
    }



    public void init()
    {
        controller.init(this);
    }

    public void setData(Vector2 movDir, Vector2 aimDir, string state, string returnState = "")
    {
        this.movDir = movDir;
        this.aimDir = aimDir;
        setState(state, returnState);
    }

    public void setState(string state, string returnState = "")
    {   
        this.state = state;
        this.returnState = returnState;
    }
}
