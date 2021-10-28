using System;
using Ardalis.GuardClauses;

namespace GuardClauseDemo
{
    public static class CustomGuardClause
    {
        public static string Zeshan(this IGuardClause guardClause, string input, string parameterName)
        {
            if (input == "Zeshan")
                throw new ArgumentException("Disgusting", parameterName);

            return input;
        }
    }
}