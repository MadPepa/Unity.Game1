using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] private Animator _creatorsAnimator;

<<<<<<< Updated upstream
    public void Play()
=======
    public void OnPlayClick()
>>>>>>> Stashed changes
    {
        SceneManager.LoadScene("Game");
    }

<<<<<<< Updated upstream
    public void Creators()
=======
    public void OnCreatorsClick()
>>>>>>> Stashed changes
    {
        _creatorsAnimator.SetBool("IsOpen", !_creatorsAnimator.GetBool("IsOpen"));
    }

<<<<<<< Updated upstream
    public void Exit()
=======
    public void OnExitClick()
>>>>>>> Stashed changes
    {
        Application.Quit();
    }
}
