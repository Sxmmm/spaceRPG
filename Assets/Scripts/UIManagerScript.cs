using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManagerScript : MonoBehaviour {

    [SerializeField]
    private float updateSpeedSeconds = 0.5f;

    [SerializeField]
    private Image foregroundImg;

    public void HandleHealthChanged(float per) {
        StartCoroutine(ChangeToPer(per));
    }

    private IEnumerator ChangeToPer(float per) {
        float preChangePer = foregroundImg.fillAmount;
        float elapsed = 0f;

        while (elapsed < updateSpeedSeconds) {
            elapsed += Time.deltaTime;
            foregroundImg.fillAmount = Mathf.Lerp(preChangePer, per, elapsed / updateSpeedSeconds);
            yield return null;
        }
        foregroundImg.fillAmount = per;
    }
}
