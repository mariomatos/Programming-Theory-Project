using UnityEngine;

public class SphereShape : BaseShape
{
    public override void DisplayText()
    {
        UIManager.Instance.ShowMessage("I am a Sphere!");
    }
}
