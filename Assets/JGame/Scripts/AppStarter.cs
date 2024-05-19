using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using JGame.Scripts.State.Loading;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.SceneManagement;

namespace JGame.Scripts
{
    public class AppStarter : MonoBehaviour
    {
        // Init or load config
        // Init main scene (create or load from config)

        private Loader _loader;

        private void Construct()
        {
        }

        private async void Start()
        {
            Loader loader = new();

            // _context.Initialize(loader, in configBindingsList);
            //
            // await _context.LoadingScreenProvider.LoadAndDestroy(loader);
            await LoadGameSceneAsync();
        }


        private async UniTask LoadGameSceneAsync()
        {
            // var gameScene = Addressables.LoadSceneAsync(Scene.Game, LoadSceneMode.Additive);
            // await gameScene.Task;

            var tempActiveScene = SceneManager.GetActiveScene();
            // SceneManager.SetActiveScene(gameScene.Result.Scene);
            await SceneManager.UnloadSceneAsync(tempActiveScene);
        }
    }
}