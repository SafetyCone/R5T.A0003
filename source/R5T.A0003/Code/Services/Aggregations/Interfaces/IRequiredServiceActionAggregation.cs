using System;
using System.Collections.Generic;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

using R5T.Ostrogothia;

using R5T.D0048;
using R5T.D0081;
using R5T.D0098;
using R5T.D0099.D002;
using R5T.L0017.D001;
using R5T.T0063;


namespace R5T.A0003
{
    public interface IRequiredServiceActionAggregation
    {
        IServiceAction<IConfiguration> ConfigurationAction { get; set; }
        IServiceAction<IExecutionSynchronicityProvider> ExecutionSynchronicityProviderAction { get; set; }
        IServiceAction<ILoggerFactory> LoggerFactoryAction { get; set; }
        IServiceAction<ILoggerUnbound> LoggerAction { get; set; }
        IEnumerable<IServiceAction<IMachineMessageTypeJsonSerializationHandler>> MachineMessageTypeJsonSerializationHandlerActions { get; set; }
        IEnumerable<IServiceAction<IMachineMessageOutputSinkProvider>> MachineMessageOutputSinkProviderActions { get; set; }
        IServiceAction<IOrganizationProvider> OrganizationProviderAction { get; set; }
        IServiceAction<IRootOutputDirectoryPathProvider> RootOutputDirectoryPathProviderAction { get; set; }   
    }
}
