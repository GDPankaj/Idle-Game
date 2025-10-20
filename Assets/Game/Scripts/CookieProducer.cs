using UnityEngine;
using UnityEngine.UI;

public class CookieProducer : MonoBehaviour
{
    [SerializeField] [Range(0.2f, 20f)]double cookiesPerSecond;
    private Button cookieProducerButton;

    private void Awake()
    {
        cookieProducerButton = GetComponent<Button>();
    }

    private void OnEnable()
    {
        //cookieProducerButton.onClick.AddListener(Cookie.Instance.subtractCookiesAction);
    }

    private void OnDisable()
    {
        if (cookieProducerButton != null) { 
        cookieProducerButton.onClick.RemoveAllListeners();
        }
    }
    private void Update()
    {
        Cookie.Instance.AddCookies(cookiesPerSecond * Time.deltaTime);
    }

    public void IncreaseCps(float cps)
    {
        cookiesPerSecond += cps;
    }
}
