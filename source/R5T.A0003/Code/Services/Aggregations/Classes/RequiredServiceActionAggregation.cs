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
    public class RequiredServiceActionAggregation : IRequiredServiceActionAggregation
    {
        public IServiceAction<IConfiguration> ConfigurationAction { get; set; }
        public IServiceAction<IExecutionSynchronicityProvider> ExecutionSynchronicityProviderAction { get; set; }
        public IServiceAction<ILoggerFactory> LoggerFactoryAction { get; set; }
        public IServiceAction<ILoggerUnbound> LoggerAction { get; set; }
        public IEnumerable<IServiceAction<IMachineMessageTypeJsonSerializationHandler>> MachineMessageTypeJsonSerializationHandlerActions { get; set; }
        public IEnumerable<IServiceAction<IMachineMessageOutputSinkProvider>> MachineMessageOutputSinkProviderActions { get; set; }
        public IServiceAction<IOrganizationProvider> OrganizationProviderAction { get; set; }
        public IServiceAction<IRootOutputDirectoryPathProvider> RootOutputDirectoryPathProviderAction { get; set; }
    }
}
