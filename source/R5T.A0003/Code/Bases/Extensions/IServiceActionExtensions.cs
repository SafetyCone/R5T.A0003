using System;

using R5T.Lombardy;
using R5T.Magyar;
using R5T.Quadia.A001;
using R5T.Quadia.D002.I001;

using R5T.D0048.A001;
using R5T.D0075.Default;
using R5T.D0093.I002;
using R5T.D0095.D001.I001;
using R5T.D0095.D001.I002;
using R5T.D0096.A001;
using R5T.D0096.D003.I001;
using R5T.D0096.D003.I002;
using R5T.D0099.A001;
using R5T.D0099.D003.I001;
using R5T.D0099.D003.I002;
using R5T.D0102.I001;
using R5T.D0103.I001;
using R5T.D0104.I001;
using R5T.D0106.I001;
using R5T.D0106.D002.I001;
using R5T.D0107.I001;
using R5T.L0013.I001;
using R5T.T0062;


namespace R5T.A0003
{
    public static class IServiceActionExtensions
    {
        public static IProvidedServiceActionAggregation AddProvidedServiceActionAggregation(this IServiceAction _,
            IRequiredServiceActionAggregation requiredServiceActionAggregation)
        {
            // Level 0.
            var commandLineOperatorAction = _.AddCommandLineOperatorAction();
            var configurationSerializationFileNameProviderAction = _.AddConstructorBasedConfigurationSerializationFileNameProviderAction(
                Instances.FileName.ConfigurationText());
            var currentProcessStartTimeProviderAction = _.AddCurrentProcessStartTimeProviderAction();
            var dateTimeDirectoryNameProviderAction = _.AddYYYYMMDD_HHMMSS_DateTimeDirectoryNameProviderAction();
            var directoryNameProviderAction = _.AddDirectDirectoryNameProviderAction();
            var humanOutputFileNameProviderAction = _.AddConstructorBasedHumanOutputFileNameProviderAction(
                Instances.FileName.HumanOutputText());
            var logFileNameProviderAction = _.AddConstructorBasedLogFileNameProviderAction(
                Instances.FileName.LogText());
            var machineOutputFileNameProviderAction = _.AddConstructorBasedMachineOutputFileNameProviderAction(
                Instances.FileName.MachineOutputJson());
            var processNameProviderAction = _.AddEntryPointAssemblyProcessNameProviderAction();
            var serviceCollectionAction = _.AddServiceCollectionAction();
            var serviceCollectionSerializationFileNameProviderAction = _.AddConstructorBasedServiceCollectionSerializationFileNameProviderAction(
                Instances.FileName.ServicesText());
            var stringlyTypedPathOperatorActions = _.AddStringlyTypedPathOperatorActions();

            // Level 1.
            var loggerSynchronicityProviderAction = _.AddLoggerSynchronicityProviderAction(
                requiredServiceActionAggregation.ExecutionSynchronicityProviderAction);
            var organizationDataDirectoryPathProviderActions = _.AddOrganizationDataDirectoryPathProviderActions(
                requiredServiceActionAggregation.OrganizationProviderAction,
                stringlyTypedPathOperatorActions.StringlyTypedPathOperatorAction);
            var processStartTimeProviderAction = _.AddOverridableProcessStartTimeProviderAction(
                currentProcessStartTimeProviderAction);

            // Level 2.
            var organizationSharedDataDirectoryPathProviderAction = _.AddOrganizationSharedDataDirectoryPathProviderAction(
                organizationDataDirectoryPathProviderActions.OrganizationDataDirectoryPathProviderAction);
            var outputFilePathProviderActions = _.AddOutputFilePathProviderActions(
                dateTimeDirectoryNameProviderAction,
                directoryNameProviderAction,
                processNameProviderAction,
                processStartTimeProviderAction,
                requiredServiceActionAggregation.RootOutputDirectoryPathProviderAction,
                stringlyTypedPathOperatorActions.StringlyTypedPathOperatorAction);

            // Level 3.
            var configurationSerializationFilePathProviderAction = _.AddConfigurationSerializationFilePathProviderAction(
                configurationSerializationFileNameProviderAction,
                outputFilePathProviderActions.OutputFilePathProviderAction);
            var humanOutputFilePathProviderAction = _.AddHumanOutputFilePathProviderAction(
                humanOutputFileNameProviderAction,
                outputFilePathProviderActions.OutputFilePathProviderAction);
            var logFilePathProviderAction = _.AddLogFilePathProviderAction(
                logFileNameProviderAction,
                outputFilePathProviderActions.OutputFilePathProviderAction);
            var machineOutputFilePathProviderAction = _.AddMachineOutputFilePathProviderAction(
                machineOutputFileNameProviderAction,
                outputFilePathProviderActions.OutputFilePathProviderAction);
            var organizationSharedDataDirectoryFilePathProviderAction = _.AddOrganizationSharedDataDirectoryFilePathProviderAction(
                organizationSharedDataDirectoryPathProviderAction,
                stringlyTypedPathOperatorActions.StringlyTypedPathOperatorAction);
            var serviceCollectionSerializationFilePathProviderAction = _.AddServiceCollectionSerializationFilePathProviderAction(
                outputFilePathProviderActions.OutputFilePathProviderAction,
                serviceCollectionSerializationFileNameProviderAction);

            // Level 4.
            var configurationAuditSerializerAction = _.AddConfigurationAuditSerializerAction(
                requiredServiceActionAggregation.ConfigurationAction,
                configurationSerializationFilePathProviderAction);
            var humanOutputActions = _.AddHumanOutputActions(
                requiredServiceActionAggregation.ExecutionSynchronicityProviderAction,
                humanOutputFilePathProviderAction);
            var serviceCollectionAuditSerializerAction = _.AddServiceCollectionAuditSerializerAction(
                serviceCollectionAction,
                serviceCollectionSerializationFilePathProviderAction);

            // Level 5.
            var machineOutputActions = _.AddMachineOutputActions(
                requiredServiceActionAggregation.ExecutionSynchronicityProviderAction,
                humanOutputActions.HumanOutputAction,
                requiredServiceActionAggregation.LoggerFactoryAction,
                requiredServiceActionAggregation.LoggerAction,
                requiredServiceActionAggregation.MachineMessageOutputSinkProviderActions,
                requiredServiceActionAggregation.MachineMessageTypeJsonSerializationHandlerActions,
                machineOutputFilePathProviderAction);

            var output = new ProvidedServiceActionAggregation()
                .As<ProvidedServiceActionAggregation, IProvidedServiceActionAggregationIncrement>(aggregation =>
                {
                    aggregation.CommandLineOperatorAction = commandLineOperatorAction;
                    aggregation.ConfigurationAuditSerializerAction = configurationAuditSerializerAction;
                    aggregation.ConfigurationSerializationFileNameProviderAction = configurationSerializationFileNameProviderAction;
                    aggregation.ConfigurationSerializationFilePathProviderAction = configurationSerializationFilePathProviderAction;
                    aggregation.CurrentProcessStartTimeProviderAction = currentProcessStartTimeProviderAction;
                    aggregation.DateTimeDirectoryNameProviderAction = dateTimeDirectoryNameProviderAction;
                    aggregation.DirectoryNameProviderAction = directoryNameProviderAction;
                    aggregation.HumanOutputFileNameProviderAction = humanOutputFileNameProviderAction;
                    aggregation.HumanOutputFilePathProviderAction = humanOutputFilePathProviderAction;
                    aggregation.LogFileNameProviderAction = logFileNameProviderAction;
                    aggregation.LogFilePathProviderAction = logFilePathProviderAction;
                    aggregation.LoggerSynchronicityProviderAction = loggerSynchronicityProviderAction;
                    aggregation.MachineOutputFileNameProviderAction = machineOutputFileNameProviderAction;
                    aggregation.MachineOutputFilePathProviderAction = machineOutputFilePathProviderAction;
                    aggregation.OrganizationSharedDataDirectoryFilePathProviderAction = organizationSharedDataDirectoryFilePathProviderAction;
                    aggregation.OrganizationSharedDataDirectoryPathProviderAction = organizationSharedDataDirectoryPathProviderAction;
                    aggregation.ProcessNameProviderAction = processNameProviderAction;
                    aggregation.ProcessStartTimeProviderAction = processStartTimeProviderAction;
                    aggregation.ServiceCollectionAction = serviceCollectionAction;
                    aggregation.ServiceCollectionAuditSerializerAction = serviceCollectionAuditSerializerAction;
                    aggregation.ServiceCollectionSerializationFileNameProviderAction = serviceCollectionSerializationFileNameProviderAction;
                    aggregation.ServiceCollectionSerializationFilePathProviderAction = serviceCollectionSerializationFilePathProviderAction;
                })
                .FillFrom(humanOutputActions)
                .FillFrom(machineOutputActions)
                .FillFrom(organizationDataDirectoryPathProviderActions)
                .FillFrom(outputFilePathProviderActions)
                .FillFrom(stringlyTypedPathOperatorActions)
                ;

            return output;
        }
    }
}
