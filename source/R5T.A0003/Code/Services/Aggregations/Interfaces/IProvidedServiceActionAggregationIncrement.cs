using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Quadia.D002;

using R5T.D0075;
using R5T.D0093;
using R5T.D0095.D001;
using R5T.D0096.D003;
using R5T.D0099.D003;
using R5T.D0102;
using R5T.D0103;
using R5T.D0104;
using R5T.D0106;
using R5T.D0106.D002;
using R5T.D0107;
using R5T.T0063;


namespace R5T.A0003
{
    public interface IProvidedServiceActionAggregationIncrement
    {
        IServiceAction<ICommandLineOperator> CommandLineOperatorAction { get; set; }
        IServiceAction<IConfigurationAuditSerializer> ConfigurationAuditSerializerAction { get; set; }
        IServiceAction<IConfigurationSerializationFileNameProvider> ConfigurationSerializationFileNameProviderAction { get; set; }
        IServiceAction<IConfigurationSerializationFilePathProvider> ConfigurationSerializationFilePathProviderAction { get; set; }
        IServiceAction<ICurrentProcessStartTimeProvider> CurrentProcessStartTimeProviderAction { get; set; }
        IServiceAction<IDateTimeDirectoryNameProvider> DateTimeDirectoryNameProviderAction { get; set; }
        IServiceAction<IDirectoryNameProvider> DirectoryNameProviderAction { get; set; }
        IServiceAction<IHumanOutputFileNameProvider> HumanOutputFileNameProviderAction { get; set; }
        IServiceAction<IHumanOutputFilePathProvider> HumanOutputFilePathProviderAction { get; set; }
        IServiceAction<ILogFileNameProvider> LogFileNameProviderAction { get; set; }
        IServiceAction<ILogFilePathProvider> LogFilePathProviderAction { get; set; }
        IServiceAction<ILoggerSynchronicityProvider> LoggerSynchronicityProviderAction { get; set; }
        IServiceAction<IMachineOutputFileNameProvider> MachineOutputFileNameProviderAction { get; set; }
        IServiceAction<IMachineOutputFilePathProvider> MachineOutputFilePathProviderAction { get; set; }
        IServiceAction<IOrganizationSharedDataDirectoryFilePathProvider> OrganizationSharedDataDirectoryFilePathProviderAction { get; set; }
        IServiceAction<IOrganizationSharedDataDirectoryPathProvider> OrganizationSharedDataDirectoryPathProviderAction { get; set; }
        IServiceAction<IProcessNameProvider> ProcessNameProviderAction { get; set; }
        IServiceAction<IProcessStartTimeProvider> ProcessStartTimeProviderAction { get; set; }
        IServiceAction<IServiceCollection> ServiceCollectionAction { get; set; }
        IServiceAction<IServiceCollectionAuditSerializer> ServiceCollectionAuditSerializerAction { get; set; }
        IServiceAction<IServiceCollectionSerializationFileNameProvider> ServiceCollectionSerializationFileNameProviderAction { get; set; }
        IServiceAction<IServiceCollectionSerializationFilePathProvider> ServiceCollectionSerializationFilePathProviderAction { get; set; }
    }
}
