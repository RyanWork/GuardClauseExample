using Ardalis.GuardClauses;

namespace GuardClauseDemo
{
    public class SomeDomainObject
    {
        public string Property1 { get; init; }
        
        public string Property2 { get; init; }

        public SomeDomainObject(string property1, string property2)
        {
            Property1 = Guard.Against.NullOrEmpty(property1, nameof(property1), "Custom Message");
            Property2 = Guard.Against.Zeshan(property2, nameof(property2));
        }
    }
}