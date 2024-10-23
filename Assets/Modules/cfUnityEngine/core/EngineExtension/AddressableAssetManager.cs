using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine.ResourceManagement.AsyncOperations;
using Object = UnityEngine.Object;

namespace cfEngine.Asset
{
    public class AddressableAssetManager: AssetManager<Object>
    {
        private Dictionary<string, (WeakReference wr, AsyncOperationHandle handle)> _cacheAssetMap = new();

        protected override T _Load<T>(string key)
        {
            throw new System.NotImplementedException();
        }

        protected override Task<T> _LoadAsync<T>(string key, CancellationToken token)
        {
            throw new System.NotImplementedException();
        }
    }
}