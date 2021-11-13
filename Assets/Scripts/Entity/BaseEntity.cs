using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseEntity : MonoBehaviour
{
    [Header("Properties")]
    public string typeID;
    public BaseController controller;
    public List<BaseBehaviour> behaviours;

    [Header("Generated")]
    public string instanceID;
    public string typeName;

    void Start()
    {
        if(instanceID == "") instanceID = InstanceManager.createInstance(this);
        InstanceManager.logInstances();
    }

    void Update()
    {
        
    }
}
