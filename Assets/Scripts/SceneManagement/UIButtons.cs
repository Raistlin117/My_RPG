using UnityEngine;
using UnityEngine.SceneManagement;

namespace RPG.SceneManagement
{
    public class UIButtons : MonoBehaviour
    {
        public void StartLevel(int levelSceneIndex)
        {
            SceneManager.LoadScene(levelSceneIndex);
        }
        
        public void Continue()
        {
            GameObject.FindObjectOfType<SavingWrapper>().LoadScene();
        }

        public void DeleteSaving()
        {
            GameObject.FindObjectOfType<SavingWrapper>().Delete();
        }

        public void Saving()
        {
            GameObject.FindObjectOfType<SavingWrapper>().Save();
        }

        private void Update()
        {
            
        }

    }
}