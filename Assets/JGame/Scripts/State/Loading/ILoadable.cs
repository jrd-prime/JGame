using System;
using Cysharp.Threading.Tasks;

namespace JGame.Scripts.State.Loading
{
    public interface ILoadable
    {
        public string Description { get; }
        public UniTask Load(Action<ILoadable> action);
    }
}