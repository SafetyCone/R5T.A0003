using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Bulgaria;
using R5T.Carpathia;
using R5T.Costobocia;
using R5T.Lombardy;
using R5T.Quadia;
using R5T.Quadia.D002;
using R5T.Suebia;
using R5T.Visigothia;

using R5T.D0048;
using R5T.D0048.D002;
using R5T.D0065;
using R5T.D0074;
using R5T.D0093;
using R5T.D0095.D001;
using R5T.D0096;
using R5T.D0096.D001;
using R5T.D0096.D003;
using R5T.D0098;
using R5T.D0099;
using R5T.D0099.D001;
using R5T.D0099.D002;
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
    public class ProvidedServiceActionAggregation : IProvidedServiceActionAggregation
    {
        public IServiceAction<D0075.ICommandLineOperator> BaseCommandLineOperatorAction { get; set; }
        public IServiceAction<D0076.ICommandLineOperator> CommandLineOperatorAction { get; set; }
        public IServiceAction<IConfigurationAuditSerializer> ConfigurationAuditSerializerAction { get; set; }
        public IServiceAction<IConfigurationSerializationFileNameProvider> ConfigurationSerializationFileNameProviderAction { get; set; }
        public IServiceAction<IConfigurationSerializationFilePathProvider> ConfigurationSerializationFilePathProviderAction { get; set; }
        public IServiceAction<ICurrentProcessStartTimeProvider> CurrentProcessStartTimeProviderAction { get; set; }
        public IServiceAction<IDateTimeDirectoryNameProvider> DateTimeDirectoryNameProviderAction { get; set; }
        public IServiceAction<IDirectoryNameOperator> DirectoryNameOperatorAction { get; set; }
        public IServiceAction<IDirectoryNameProvider> DirectoryNameProviderAction { get; set; }
        public IServiceAction<IDirectorySeparatorOperator> DirectorySeparatorOperatorAction { get; set; }
        public IServiceAction<IDropboxDirectoryPathProvider> DropboxDirectoryPathProviderAction { get; set; }
        public IServiceAction<IDropboxDirectoryNameProvider> DropboxDirectoryNameProviderAction { get; set; }
        public IServiceAction<IExecutableDirectoryPathProvider> ExecutableDirectoryPathProviderAction { get; set; }
        public IServiceAction<IExecutableFilePathProvider> ExecutableFilePathProviderAction { get; set; }
        public IServiceAction<D0071.ExecutingAssembly.IFilePathProvider> ExecutingAssemblyFilePathProviderAction { get; set; }
        public IServiceAction<IFileExtensionOperator> FileExtensionOperatorAction { get; set; }
        public IServiceAction<IFileNameOperator> FileNameOperatorAction { get; set; }
        public IServiceAction<IHumanOutput> HumanOutputAction { get; set; }
        public IServiceAction<IHumanOutputFileNameProvider> HumanOutputFileNameProviderAction { get; set; }
        public IServiceAction<IHumanOutputFilePathProvider> HumanOutputFilePathProviderAction { get; set; }
        public IServiceAction<IHumanOutputSinkProvider> FileHumanOutputSinkProviderAction { get; set; }
        public IServiceAction<IHumanOutputSinkProvider> ConsoleHumanOutputSinkProviderAction { get; set; }
        public IServiceAction<IHumanOutputSynchronicityProvider> HumanOutputSynchronicityProviderAction { get; set; }
        public IServiceAction<ILogFileNameProvider> LogFileNameProviderAction { get; set; }
        public IServiceAction<ILogFilePathProvider> LogFilePathProviderAction { get; set; }
        public IServiceAction<ILoggerSynchronicityProvider> LoggerSynchronicityProviderAction { get; set; }
        public IServiceAction<IMachineMessageJsonReserializer> MachineMessageJsonReserializerAction { get; set; }
        public IServiceAction<IMachineMessageOutputSinkProvider> MachineMessageOutputSinkProviderAction { get; set; }
        public IServiceAction<IMachineOutput> MachineOutputAction { get; set; }
        public IServiceAction<IMachineOutputFileNameProvider> MachineOutputFileNameProviderAction { get; set; }
        public IServiceAction<IMachineOutputFilePathProvider> MachineOutputFilePathProviderAction { get; set; }
        public IServiceAction<IMachineOutputSynchronicityProvider> MachineOutputSynchronicityProviderAction { get; set; }
        public IServiceAction<IOrganizationSharedDataDirectoryFilePathProvider> OrganizationSharedDataDirectoryFilePathProviderAction { get; set; }
        public IServiceAction<IOrganizationSharedDataDirectoryPathProvider> OrganizationSharedDataDirectoryPathProviderAction { get; set; }
        public IServiceAction<IProcessDirectoryNameProvider> ProcessDirectoryNameProviderAction { get; set; }
        public IServiceAction<IProcessNameProvider> ProcessNameProviderAction { get; set; }
        public IServiceAction<IProcessSpecificOutputDirectoryPathProvider> ProcessSpecificOutputDirectoryPathProviderAction { get; set; }
        public IServiceAction<IProcessStartTimeDirectoryNameProvider> ProcessStartTimeDirectoryNameProviderAction { get; set; }
        public IServiceAction<IProcessStartTimeProvider> ProcessStartTimeProviderAction { get; set; }
        public IServiceAction<IProcessStartTimeSpecificOutputDirectoryPathProvider> ProcessStartTimeSpecificOutputDirectoryPathProviderAction { get; set; }
        public IServiceAction<IOutputDirectoryPathProvider> OutputDirectoryPathProviderAction { get; set; }
        public IServiceAction<IOutputFilePathProvider> OutputFilePathProviderAction { get; set; }
        public IServiceAction<ISecretsDirectoryFilePathProvider> SecretsDirectoryFilePathProviderAction { get; set; }
        public IServiceAction<ISecretsDirectoryPathProvider> SecretsDirectoryPathProviderAction { get; set; }
        public IServiceAction<IServiceCollection> ServiceCollectionAction { get; set; }
        public IServiceAction<IServiceCollectionAuditSerializer> ServiceCollectionAuditSerializerAction { get; set; }
        public IServiceAction<IServiceCollectionSerializationFileNameProvider> ServiceCollectionSerializationFileNameProviderAction { get; set; }
        public IServiceAction<IServiceCollectionSerializationFilePathProvider> ServiceCollectionSerializationFilePathProviderAction { get; set; }
        public IServiceAction<ISharedOrganizationDirectoryPathProvider> SharedOrganizationDirectoryPathProviderAction { get; set; }
        public IServiceAction<ISharedDirectoryNameProvider> SharedDirectoryNameProviderAction { get; set; }
        public IServiceAction<IStringlyTypedPathOperator> StringlyTypedPathOperatorAction { get; set; }
        public IServiceAction<ITaskQueue> TaskQueueAction { get; set; }
        public IServiceAction<ITaskQueueConstructor> TaskQueueConstructorAction { get; set; }
        public IServiceAction<IUserProfileDirectoryPathProvider> UserProfileDirectoryPathProviderAction { get; set; }

        public IServiceAction<IOrganizationDataDirectoryPathProvider> OrganizationDataDirectoryPathProviderAction { get; set; }
        public IServiceAction<Carpathia.IOrganizationDirectoryPathProvider> OrganizationDirectoryPathProviderAction { get; set; }
        public IServiceAction<Costobocia.IOrganizationDirectoryPathProvider> OrganizationalDirectoryPathProviderAction { get; set; }
        public IServiceAction<IOrganizationDirectoryNameProvider> OrganizationDirectoryNameProviderAction { get; set; }
        public IServiceAction<IOrganizationsDirectoryPathProvider> OrganizationsDirectoryPathProviderAction { get; set; }
        public IServiceAction<IOrganizationsDirectoryNameProvider> OrganizationsDirectoryNameProviderAction { get; set; }
       
    }
}
