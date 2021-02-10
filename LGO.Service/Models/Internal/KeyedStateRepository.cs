using System;
using System.Collections.Concurrent;

namespace LGO.Service.Models.Internal
{
    internal class KeyedStateRepository<TKey, TState> where TKey : IEquatable<TKey> where TState : class
    {
        private readonly ConcurrentDictionary<TKey, StateRepository<TState>> _repositories = new();

        public bool TryGet(TKey key, out TState state)
        {
            state = null!;
            if (!_repositories.TryGetValue(key, out var repository))
            {
                return false;
            }

            return repository.TryGet(out state);
        }

        public void Update(TKey key, Func<TState?, TState?> updateFactory)
        {
            var repository = _repositories.GetOrAdd(key, _ => new StateRepository<TState>());
            repository.Update(updateFactory);
        }
    }
}