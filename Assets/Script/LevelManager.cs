using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Threading.Tasks;
public class LevelManager : MonoBehaviour
{

[SerializeField] private GameObject _loaderGame;
[SerializeField] private Image _progressBar;
    public static LevelManager _Instance;
    // Start is called before the first frame update
    void Start()
    {
    }

    private void Awake(){

        if(_Instance == null){
            _Instance = this; 
            DontDestroyOnLoad(gameObject);
        }

        else{
            Destroy(gameObject);
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadScene(string SceneName){
 SceneManager.LoadScene(SceneName);
    }

    public void LoadNewGame(){
        LoadScene("Level01");
    }
    public void LoadMainMenu(){
        LoadScene("Intro");
    }

    public void QuitGame(){
        Debug.Log("lol");
        Application.Quit();
    }

    public void LoadNextScene(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public async void LoadAsychScene(string sceneName){
        var scene = SceneManager.LoadSceneAsync(sceneName);

        scene.allowSceneActivation= false;

        _loaderGame.SetActive(true);

        do{
            await Task.Delay(100);

            _progressBar.fillAmount = scene.progress;
    }
        while (scene.progress < 0.9f);
        {
            scene.allowSceneActivation = true;

            _loaderGame.SetActive(false);
        }
    }
}
