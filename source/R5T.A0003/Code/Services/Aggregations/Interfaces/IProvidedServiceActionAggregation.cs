using System;

using R5T.Lombardy;

using IHumanOutputActionAggregation = R5T.D0096.A001.IServiceActionAggregation;
using IMachineOutputActionAggregation = R5T.D0099.A001.IServiceActionAggregation;
using IOrganizationDataDirectoryPathProviderActionAggregation = R5T.Quadia.A001.IServiceActionAggregation01;
using IOutputFilePathProviderActionAggregation = R5T.D0048.A001.IServiceActionAggregation01;


namespace R5T.A0003
{
    public interface IProvidedServiceActionAggregation : IProvidedServiceActionAggregationIncrement,
        IHumanOutputActionAggregation,
        IMachineOutputActionAggregation,
        IOrganizationDataDirectoryPathProviderActionAggregation,
        IOutputFilePathProviderActionAggregation,
        IStringlyTypedPathOperatorActionAggregation
    {   
    }
}
