﻿using System.Linq;
using Cysharp.Threading.Tasks;
using JGame.Scripts.AssetLoader;
using JGame.Scripts.Const;

namespace JGame.Scripts.State.Loading
{
    public class LoadingScreenProvider : LocalAssetLoader
    {
        public async UniTask LoadAndDestroy(Loader loader)
        {
            var loadingScreen = await Load<LoadingScreenView>(Screen.LoadingScreen);

            loadingScreen._steps = loader.LoadingQueue.Count;
            loadingScreen.SetTime(loader.LoadingQueueDelay.Select(x => x.Value).Sum());

            await loadingScreen.Load(loader);
            Unload();
        }
    }
}