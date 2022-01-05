using System;

using R5T.Lombardy;

using ICommandLineOperatorActionAggregation = R5T.D0076.A001.IServiceActionAggregation01;
using IExecutableDirectoryPathActionAggregation = R5T.D0065.Standard.IExecutableDirectoryPathActionAggregation;
using IHumanOutputActionAggregation = R5T.D0096.A001.IServiceActionAggregation;
using IMachineOutputActionAggregation = R5T.D0099.A001.IServiceActionAggregation;
using IOrganizationDataDirectoryPathProviderActionAggregation = R5T.Quadia.A001.IServiceActionAggregation01;
using IOutputFilePathProviderActionAggregation = R5T.D0048.A001.IServiceActionAggregation01;


namespace R5T.A0003
{
    public interface IProvidedServiceActionAggregation : IProvidedServiceActionAggregationIncrement,
        ICommandLineOperatorActionAggregation,
        IExecutableDirectoryPathActionAggregation,
        IHumanOutputActionAggregation,
        IMachineOutputActionAggregation,
        IOrganizationDataDirectoryPathProviderActionAggregation,
        IOutputFilePathProviderActionAggregation,
        IStringlyTypedPathOperatorActionAggregation
    {   
    }
}
