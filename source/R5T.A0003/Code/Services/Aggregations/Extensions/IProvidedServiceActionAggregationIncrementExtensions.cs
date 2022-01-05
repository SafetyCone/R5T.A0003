using System;

using R5T.A0003;


namespace System
{
    public static class IProvidedServiceActionAggregationIncrementExtensions
    {
        public static T FillFrom<T>(this T aggregation,
            IProvidedServiceActionAggregationIncrement other)
            where T : IProvidedServiceActionAggregationIncrement
        {
            aggregation.ConfigurationAuditSerializerAction = other.ConfigurationAuditSerializerAction;
            aggregation.ConfigurationSerializationFileNameProviderAction = other.ConfigurationSerializationFileNameProviderAction;
            aggregation.ConfigurationSerializationFilePathProviderAction = other.ConfigurationSerializationFilePathProviderAction;
            aggregation.CurrentProcessStartTimeProviderAction = other.CurrentProcessStartTimeProviderAction;
            aggregation.DateTimeDirectoryNameProviderAction = other.DateTimeDirectoryNameProviderAction;
            aggregation.DirectoryNameProviderAction = other.DirectoryNameProviderAction;
            aggregation.HumanOutputFileNameProviderAction = other.HumanOutputFileNameProviderAction;
            aggregation.HumanOutputFilePathProviderAction = other.HumanOutputFilePathProviderAction;
            aggregation.LogFileNameProviderAction = other.LogFileNameProviderAction;
            aggregation.LogFilePathProviderAction = other.LogFilePathProviderAction;
            aggregation.LoggerSynchronicityProviderAction = other.LoggerSynchronicityProviderAction;
            aggregation.MachineOutputFileNameProviderAction = other.MachineOutputFileNameProviderAction;
            aggregation.MachineOutputFilePathProviderAction = other.MachineOutputFilePathProviderAction;
            aggregation.OrganizationSharedDataDirectoryFilePathProviderAction = other.OrganizationSharedDataDirectoryFilePathProviderAction;
            aggregation.OrganizationSharedDataDirectoryPathProviderAction = other.OrganizationSharedDataDirectoryPathProviderAction;
            aggregation.ProcessNameProviderAction = other.ProcessNameProviderAction;
            aggregation.ProcessStartTimeProviderAction = other.ProcessStartTimeProviderAction;
            aggregation.ServiceCollectionAction = other.ServiceCollectionAction;
            aggregation.ServiceCollectionAuditSerializerAction = other.ServiceCollectionAuditSerializerAction;
            aggregation.ServiceCollectionSerializationFileNameProviderAction = other.ServiceCollectionSerializationFileNameProviderAction;
            aggregation.ServiceCollectionSerializationFilePathProviderAction = other.ServiceCollectionSerializationFilePathProviderAction;

            return aggregation;
        }
    }
}
