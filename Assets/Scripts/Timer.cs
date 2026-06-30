using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Collections;

public class Timer : MonoBehaviour
{
    [SerializeField]
    private TimerData[] timerData;
    [SerializeField]
    private Image timerImage;
    private UnityEvent onTimerEnd;
    public void StartTime(int duration)
    {
        StartCoroutine(TimerCoroutine(duration));
    }
    private IEnumerator TimerCoroutine(int duration)
    {
        while ( duration > 0)
        {
            SoundManager.intance.Play(timerData[duration - 1].soundName);
            timerImage.sprite = timerData[duration - 1].texture;
            yield return new WaitForSeconds(1f);
            duration--;
        }
        onTimerEnd.Invoke();
    }
    public void StopTimer()
    {
        StopAllCoroutines();
    }
}
[System.Serializable]
public class TimerData
{
    public string soundName;
    public Sprite Texture;
}
