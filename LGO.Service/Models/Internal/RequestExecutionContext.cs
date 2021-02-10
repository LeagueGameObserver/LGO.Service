using System;
using System.Collections.Concurrent;
using System.Threading;
using LGO.Service.Models.Public.League.Champion;
using LGO.Service.Models.Public.League.Game;
using LGO.Service.Models.Public.League.Item;
using LGO.Service.Models.Public.League.Player;
using LGO.Service.Models.Public.League.Team;
using LGO.Service.Models.Public.League.Timer;

namespace LGO.Service.Models.Internal
{
    internal sealed class RequestExecutionContext
    {
        private static readonly ConcurrentDictionary<int, ConcurrentStack<RequestExecutionContext>> ThreadContexts = new();

        private readonly ConcurrentDictionary<string, object> _properties = new();

        public static void ExecuteWith(RequestExecutionContext context, Action action)
        {
            var contextStack = ThreadContexts.GetOrAdd(Thread.CurrentThread.ManagedThreadId, _ => new ConcurrentStack<RequestExecutionContext>());
            contextStack.Push(context);

            try
            {
                action.Invoke();
            }
            finally
            {
                contextStack.TryPop(out _);
                if (contextStack.IsEmpty)
                {
                    ThreadContexts.TryRemove(Thread.CurrentThread.ManagedThreadId, out _);
                }
            }
        }

        public static RequestExecutionContext GetCurrentOrDefault()
        {
            if (TryGetCurrent(out var context))
            {
                return context;
            }

            return Default();
        }

        public static bool TryGetCurrent(out RequestExecutionContext context)
        {
            context = null!;
            if (!ThreadContexts.TryGetValue(Thread.CurrentThread.ManagedThreadId, out var contextStack))
            {
                return false;
            }

            if (!contextStack.TryPeek(out var actualContext))
            {
                return false;
            }

            context = actualContext;
            return true;
        }

        public static RequestExecutionContext Default()
        {
            var context = new RequestExecutionContext();
            context.TryAttachProperty(LgoLeagueChampionRetrievalConfiguration.RequestExecutionContextPropertyName, LgoLeagueChampionRetrievalConfiguration.IncludeEverything);
            context.TryAttachProperty(LgoLeagueGameRetrievalConfiguration.RequestExecutionContextPropertyName, LgoLeagueGameRetrievalConfiguration.IncludeEverything);
            context.TryAttachProperty(LgoLeagueItemRetrievalConfiguration.RequestExecutionContextPropertyName, LgoLeagueItemRetrievalConfiguration.IncludeEverything);
            context.TryAttachProperty(LgoLeaguePlayerRetrievalConfiguration.RequestExecutionContextPropertyName, LgoLeaguePlayerRetrievalConfiguration.IncludeEverything);
            context.TryAttachProperty(LgoLeagueTeamRetrievalConfiguration.RequestExecutionContextPropertyName, LgoLeagueTeamRetrievalConfiguration.IncludeEverything);
            context.TryAttachProperty(LgoLeagueTimerRetrievalConfiguration.RequestExecutionContextPropertyName, LgoLeagueTimerRetrievalConfiguration.IncludeEverything);
            context.TryAttachProperty(LgoLeaguePowerPlayTimerRetrievalConfiguration.RequestExecutionContextPropertyName, LgoLeaguePowerPlayTimerRetrievalConfiguration.IncludeEverything);
            return context;
        }

        public static RequestExecutionContext Empty()
        {
            return new();
        }

        private RequestExecutionContext() { }

        public bool TryAttachProperty(string propertyName, object property)
        {
            return _properties.TryAdd(propertyName, property);
        }

        public void AddOrUpdateProperty(string propertyName, Func<string, object> propertyFactory, Func<string, object, object> updateFactory)
        {
            _properties.AddOrUpdate(propertyName, propertyFactory, updateFactory);
        }

        public bool TryGetProperty<TProperty>(string propertyName, out TProperty property)
        {
            property = default!;
            if (!_properties.TryGetValue(propertyName, out var propertyAsObject))
            {
                return false;
            }

            if (propertyAsObject is not TProperty castedProperty)
            {
                return false;
            }

            property = castedProperty;
            return true;
        }

        public class Builder
        {
            private readonly RequestExecutionContext _context = Empty();

            public Builder With(LgoLeagueChampionRetrievalConfiguration configuration)
            {
                _context.AddOrUpdateProperty(LgoLeagueChampionRetrievalConfiguration.RequestExecutionContextPropertyName, _ => configuration, (_, _) => configuration);
                return this;
            }

            public Builder With(LgoLeagueGameRetrievalConfiguration configuration)
            {
                _context.AddOrUpdateProperty(LgoLeagueGameRetrievalConfiguration.RequestExecutionContextPropertyName, _ => configuration, (_, _) => configuration);
                return this;
            }

            public Builder With(LgoLeagueItemRetrievalConfiguration configuration)
            {
                _context.AddOrUpdateProperty(LgoLeagueItemRetrievalConfiguration.RequestExecutionContextPropertyName, _ => configuration, (_, _) => configuration);
                return this;
            }

            public Builder With(LgoLeaguePlayerRetrievalConfiguration configuration)
            {
                _context.AddOrUpdateProperty(LgoLeaguePlayerRetrievalConfiguration.RequestExecutionContextPropertyName, _ => configuration, (_, _) => configuration);
                return this;
            }

            public Builder With(LgoLeagueTimerRetrievalConfiguration configuration)
            {
                _context.AddOrUpdateProperty(LgoLeagueTimerRetrievalConfiguration.RequestExecutionContextPropertyName, _ => configuration, (_, _) => configuration);
                return this;
            }

            public Builder With(LgoLeaguePowerPlayTimerRetrievalConfiguration configuration)
            {
                _context.AddOrUpdateProperty(LgoLeaguePowerPlayTimerRetrievalConfiguration.RequestExecutionContextPropertyName, _ => configuration, (_, _) => configuration);
                return this;
            }

            public Builder With(LgoLeagueTeamRetrievalConfiguration configuration)
            {
                _context.AddOrUpdateProperty(LgoLeagueTeamRetrievalConfiguration.RequestExecutionContextPropertyName, _ => configuration, (_, _) => configuration);
                return this;
            }

            public RequestExecutionContext Build()
            {
                return _context;
            }
        }
    }
}