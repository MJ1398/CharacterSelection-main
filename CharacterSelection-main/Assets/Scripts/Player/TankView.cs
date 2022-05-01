using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankView : MonoBehaviour
{
    private TankController tankController;

    public float movement;

    public float rotation;

    public Rigidbody rb;

    public MeshRenderer[] childs;

    public ShellSpawner shellSpawner;

    private Vector3 camRotation = new Vector3(30f, 0f, 0f);                                  // for camera rotation

    // Start is called before the first frame update
    void Start()
    {
        GameObject cam = GameObject.Find("Main Camera");
        cam.transform.SetParent(transform);
        cam.transform.position = new Vector3(0f, 15f, -15f);
        cam.transform.rotation = Quaternion.Euler(camRotation);                              // for camera rotation used quaternion.euler since rotation will not
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        PlayerInput();
        if (movement != 0)
        {
            tankController.Move(movement, tankController.GetTankModel().movementSpeed);
        }

        if (rotation != 0)
        {
            tankController.Rotate(rotation, tankController.GetTankModel().rotationSpeed);
        }
    }

    private void Movement()
    {
        movement = Input.GetAxis("Vertical");
        rotation = Input.GetAxis("Horizontal");
    }

    private void PlayerInput()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            tankController.Fire();
        }
    }

    public void Hit(int damage)
    {
        tankController.ReduceHealth(damage);
    }

    public void SetTankController(TankController _tankController)
    {
        tankController = _tankController;
    }

    public Rigidbody GetRigidbody()
    {
        return rb;
    }

    public void ChangeColor(Material color)
    {
        for(int i = 0; i<childs.Length; i++)
        {
            childs[i].material = color;
        }
    }
}
