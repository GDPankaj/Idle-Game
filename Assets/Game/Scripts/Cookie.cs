using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class Cookie : MonoBehaviour
{
    public double numberOfCookies { get; private set; }
    [SerializeField] private TextMeshProUGUI cookieUIText;

    public UnityAction<int> subtractCookiesAction;
    public static Cookie Instance { get; private set; }

    private void Awake()
    {
        if (Instance == null) { Instance = this; }
        else { Destroy(gameObject); }
    }

    private void Start()
    {
        subtractCookiesAction += SubtractCookies;   
    }

    public void AddCookies(double cookiesToAdd)
    {
        numberOfCookies += cookiesToAdd;
        UpdateCookieUI();
    }

    public void AddCookies(int cookiesToAdd)
    {
        numberOfCookies += cookiesToAdd;
        UpdateCookieUI();
    }
    public void SubtractCookies(int cookiesToSubtract)
    {
        numberOfCookies -= cookiesToSubtract;
        UpdateCookieUI();
    }

    private void UpdateCookieUI()
    {
        cookieUIText.text = $"{(int)numberOfCookies}";
    }

}
