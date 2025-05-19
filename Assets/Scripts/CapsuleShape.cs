using UnityEngine;

public class CapsuleShape : BaseShape
{
    public override void DisplayText()
    {
        UIManager.Instance.ShowMessage("I am a Capsule!");
    }
}
