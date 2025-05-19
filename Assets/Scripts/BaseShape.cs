using UnityEngine;

public class BaseShape : MonoBehaviour
{
    [SerializeField] private string shapeName;
    [SerializeField] private Color shapeColor = Color.white;
    private int clickCount = 0;

    // Lista med färger att växla mellan
    [SerializeField]
    private Color[] colorCycle = new Color[]
    {
        Color.red,
        Color.green,
        Color.blue,
        Color.yellow,
        Color.magenta
    };

    private int currentColorIndex = 0;

    public string ShapeName
    {
        get => shapeName;
        set
        {
            if (value.Length <= 20)
                shapeName = value;
        }
    }

    public Color ShapeColor
    {
        get => shapeColor;
        set
        {
            shapeColor = value;
            ApplyColor();
        }
    }

    public int ClickCount => clickCount;

    private void Start()
    {
        // Börjar med shapeColor om inget angivet, annars första i colorCycle
        ApplyColor();
    }

    private void ApplyColor()
    {
        Renderer renderer = GetComponent<Renderer>();
        if (renderer != null)
        {
            renderer.material.color = shapeColor;
        }
    }

    public void OnClick()
    {
        IncrementClickCount();
        CycleColor();
        DisplayText();
    }

    protected void IncrementClickCount()
    {
        clickCount++;
    }

    private void CycleColor()
    {
        if (colorCycle.Length == 0) return;

        currentColorIndex = (currentColorIndex + 1) % colorCycle.Length;
        ShapeColor = colorCycle[currentColorIndex];
    }

    public virtual void DisplayText()
    {
        UIManager.Instance.ShowMessage($"I am a {ShapeName} — Clicked {ClickCount} times!");
    }
}
