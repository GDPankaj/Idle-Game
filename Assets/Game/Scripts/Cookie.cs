using TMPro;
using UnityEngine;

public class Cookie : MonoBehaviour
{
    public int numberOfCookies { get; private set; }
    [SerializeField] private TextMeshProUGUI cookieUIText;

    private void Start()
    {
        
    }

    public void AddCookies(int cookiesToAdd)
    {
        numberOfCookies += cookiesToAdd;
        UpdateCookieUI();
    }

    private void UpdateCookieUI()
    {
        cookieUIText.text = $"{numberOfCookies}";
    }
}
