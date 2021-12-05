using System;

using R5T.A0003;


namespace System
{
    public static class IRequiredServiceActionAggregationExtensions
    {
        public static T FillFrom<T>(this T aggregation,
            IRequiredServiceActionAggregation other)
            where T : IRequiredServiceActionAggregation
        {
            aggregation.ConfigurationAction = other.ConfigurationAction;
            aggregation.ExecutionSynchronicityProviderAction = other.ExecutionSynchronicityProviderAction;
            aggregation.LoggerAction = other.LoggerAction;
            aggregation.LoggerFactoryAction = other.LoggerFactoryAction;
            aggregation.MachineMessageOutputSinkProviderActions = other.MachineMessageOutputSinkProviderActions;
            aggregation.MachineMessageTypeJsonSerializationHandlerActions = other.MachineMessageTypeJsonSerializationHandlerActions;
            aggregation.OrganizationProviderAction = other.OrganizationProviderAction;
            aggregation.RootOutputDirectoryPathProviderAction = other.RootOutputDirectoryPathProviderAction;

            return aggregation;
        }
    }
}
