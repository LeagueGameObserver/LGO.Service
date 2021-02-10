using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace LGO.Service.Models.Internal
{
    internal class StateRepository<TState> where TState : class
    {
        private readonly ConcurrentBag<TState> _values = new();

        public StateRepository(TState? initialValue = null)
        {
            if (initialValue != null)
            {
                _values.Add(initialValue);
            }
        }

        public bool TryGet(out TState state)
        {
            return (state = _values.LastOrDefault()!) != null;
        }

        public void Update(Func<TState?, TState?> updateFactory)
        {
            var latestValue = _values.LastOrDefault();
            var newValue = updateFactory.Invoke(latestValue);

            if (newValue == null || EqualityComparer<TState>.Default.Equals(latestValue, newValue))
            {
                return;
            }

            _values.Add(newValue);
        }
    }
}