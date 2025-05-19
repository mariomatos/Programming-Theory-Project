using UnityEngine;

public class CubeShape : BaseShape
{
    public override void DisplayText()
    {
        UIManager.Instance.ShowMessage("I am a Cube!");
    }
}

