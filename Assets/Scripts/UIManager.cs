using TMPro;
using UnityEngine;
using System.Collections;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    [SerializeField] private TextMeshProUGUI messageText;
    [SerializeField] private float displayDuration = 2f;

    private Coroutine clearMessageCoroutine;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    public void ShowMessage(string message)
    {
        messageText.text = message;

        // Starta om nedräkningen om ett nytt meddelande visas
        if (clearMessageCoroutine != null)
        {
            StopCoroutine(clearMessageCoroutine);
        }
        clearMessageCoroutine = StartCoroutine(ClearMessageAfterDelay());
    }

    private IEnumerator ClearMessageAfterDelay()
    {
        yield return new WaitForSeconds(displayDuration);
        messageText.text = "";
        clearMessageCoroutine = null;
    }
}
