using UnityEngine;

public class test-raft : Mod
{
    public void Start()
    {
        Debug.Log("Mod test-raft has been loaded!");
    }

    public void OnModUnload()
    {
        Debug.Log("Mod test-raft has been unloaded!");
    }
}