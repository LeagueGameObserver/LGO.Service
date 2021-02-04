namespace LGO.Service.Models.Public
{
    public abstract record LgoDataRetrievalConfiguration
    {
        public abstract LgoDataRetrievalConfigurationType Type { get; }
    }
}