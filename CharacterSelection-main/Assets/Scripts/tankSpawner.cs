using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    [System.Serializable]
    public class Tank
    {
        public float movementSpeed;
        public float rotationSpeed;
        
        public TankTypes tankType;
        public Material color;
    }

    public List<Tank> tankList;
    

    public TankView tankView;

    // Start is called before the first frame update
    void Start()
    {
        CreateTank();
    }

    private void CreateTank()
    {
        TankModel tankModel = new TankModel(tankList[3].movementSpeed, tankList[3].rotationSpeed, tankList[3].tankType, tankList[3].color);
        TankController tankController = new TankController(tankModel, tankView);
    }
}
