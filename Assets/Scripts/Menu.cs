using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] private Animator _creatorsAnimator;

    public void OnPlayClick()
    {
        SceneManager.LoadScene("Game");
    }

    public void OnCreatorsClick()
    {
        _creatorsAnimator.SetBool("IsOpen", !_creatorsAnimator.GetBool("IsOpen"));
    }

    public void OnExitClick()
    {
        Application.Quit();
    }
}
