using Cysharp.Threading.Tasks;
using JGame.Scripts.State.Loading;
using UnityEngine;

namespace JGame.Scripts.AssetLoader
{
    public interface IAssetLoader : ILoadable
    {
        string ILoadable.Description => "Asset Loader";
        public UniTask<T> Load<T>(string assetName, Transform parent = null);
        public void Unload();
    }
}