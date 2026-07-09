using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DialogSystem : MonoBehaviour
{
  public static DialogSystem Instance { get; private set;}
  [SerializeField]
  private Text dialogText;
  [SerializeField]
  private float timeBetWeenWords = 0.25f;
  private Animator animator;
  private void Awake()
    {
        Instance = this;
        animator = GetComponent<Animator>();
    }
    public void ShowDialog(string dialog)
    {
        StopAllCoroutines();
        StartCoroutine( ShowDialogCoroutine(dialog));
    }
    private IEnumerator ShowDialogCoroutine(string dialog)
    {
        dialogText.text = "";
        animator.Play("Show" , 0, 0f);
        SoundManager.instance.Play("ShowText");
        yield return null;
        yield return new WaitForSeconds (animator. GetCurrentAnimatorStateInfo(0).length);
        foreach (char letter in dialog.ToCharArray())
        {
            dialogText.text += letter;
            SoundManager.instance.Play("DialogLetter");
            yield return new WaitForSeconds(timeBetWeenWords);
        }
        yield return new WaitForSeconds(1f);
        animator.Play("Hide", 0, 0f);
}
public void StopDialog()
    {
        StopAllCoroutines();
        dialogText.text = "";
        animator.Play("Hide", 0, 0f);
    }
}