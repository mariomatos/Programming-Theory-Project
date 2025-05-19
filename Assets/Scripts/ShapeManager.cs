using UnityEngine;

public class ShapeManager : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Vänsterklick
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                BaseShape shape = hit.collider.GetComponent<BaseShape>();
                if (shape != null)
                {
                    shape.OnClick();
                }
            }
        }
    }
}
