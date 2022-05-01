using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellView : MonoBehaviour
{
    private ShellController shellController;

    public Rigidbody rb;

    public MeshRenderer[] childs;

    // Update is called once per frame
    private void Update()
    {
        shellController.Move();
    }

    public void SetShellController(ShellController _shellController)
    {
        shellController = _shellController;
    }

    public void ChangeColor(Material color)
    {
        for (int i = 0; i < childs.Length; i++)
            childs[i].material = color;
    }

    /*public Rigidbody GetRigidbody()
    {
        return rb;
    }*/
}
