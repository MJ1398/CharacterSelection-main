using UnityEngine;

public class ShellController
{
    private ShellModel shellModel;
    private ShellView shellView;

    private Rigidbody rb;

    public ShellController(ShellModel _shellModel, ShellView _shellView, Transform transform)
    {
        shellModel = _shellModel;
        shellView  = GameObject.Instantiate<ShellView>(_shellView, transform.position, transform.rotation);
        //rb = shellView.GetRigidbody();

        shellModel.SetShellController(this);
        shellView.SetShellController(this);           
    }

    public void Move()
    {
        shellView.rb.velocity = shellView.transform.forward * shellModel.movementSpeed;
    }

    public int getDamage()
    {
        return shellModel.damage;
    }
}
