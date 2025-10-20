using UnityEngine;

public class AutoClicker : Upgrade
{
    protected override internal void OnUpgradeClicked()
    {
        if (!isUnlocked)
        {
            isUnlocked = true;
        }
    }
}
