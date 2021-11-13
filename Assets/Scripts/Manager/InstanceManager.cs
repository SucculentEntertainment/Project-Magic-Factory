using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class InstanceManager
{
    // List containing all registered instances
    public static Dictionary<string, MonoBehaviour> instances = new();

    // Generates UUID and registers given MonoBehaviour with it
    public static string createInstance(MonoBehaviour instance)
    {
        string uuid = System.Guid.NewGuid().ToString();
        instances.Add(uuid, instance);
        return uuid;
    }

    // Retrieves the MonoBehaviour registered with given UUID
    public static MonoBehaviour getInstance(string uuid)
    {
        return instances[uuid];
    }

    // Removes instance corresponding to the given UUID from the list
    public static void removeInstance(string uuid)
    {
        instances.Remove(uuid);
    }

    // Prints all instances to the console for debugging
    public static void logInstances()
    {
        string msg = "Registered Instances:\n";

        foreach(KeyValuePair<string, MonoBehaviour> instance in instances)
        {
            msg += instance.Key + ":\t\t" + instance.Value + "\n";
        }

        Debug.Log(msg);
    }
}
