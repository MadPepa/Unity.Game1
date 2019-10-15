using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] private Animator _creatorsAnimator;

    public void Play()
    {
        SceneManager.LoadScene("Game");
    }

    public void Creators()
    {
        _creatorsAnimator.SetBool("IsOpen", !_creatorsAnimator.GetBool("IsOpen"));
    }

    public void Exit()
    {
        Application.Quit();
    }
}
