using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellSpawner : MonoBehaviour
{
    public ShellView shellView;
    public float movementSpeed;
    public int damage;

    // Start is called before the first frame update
    void Start()
    {
        CreateShell();
    }

    public void CreateShell()
    {
        ShellModel shellModel = new ShellModel(movementSpeed, damage);
        ShellController shellController = new ShellController(shellModel, shellView, transform);
        //Destroy(gameObject);
    }
}
