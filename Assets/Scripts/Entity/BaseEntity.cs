using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseEntity : MonoBehaviour
{
    private string state = "idle";
    
    [Header("Properties")]
    public string typeID;
    public BaseController controller;
    public List<BaseBehaviour> behaviours;

    [Header("Generated")]
    public string instanceID;
    public string typeName;



    private void Start()
    {
        if(instanceID == "") instanceID = InstanceManager.createInstance(this);
        InstanceManager.logInstances();
    }

    private void Update()
    {
        foreach(BaseBehaviour b in behaviours)
        {
            if(b.targetState == state) b.exec();
        }
    }



    public void setState(string state, string returnState = "")
    {

        
        this.state = state;
    }
}
