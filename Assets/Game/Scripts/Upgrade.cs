using UnityEngine;
using UnityEngine.UI;

public class Upgrade : MonoBehaviour
{
    protected bool isUnlocked = false;
    //[SerializeField] private int unlockPrice = 10;
    private Button upgradeButton;

    private void Start()
    {
        upgradeButton = GetComponent<Button>();
    }
    private void OnEnable()
    {
        
    }

    protected virtual internal void OnUpgradeClicked()
    {
        if (!isUnlocked)
        {
            isUnlocked = true;
        }
    }
}
