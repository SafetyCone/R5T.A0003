using System;

using R5T.Lombardy;

using R5T.A0003;

using IHumanOutputActionAggregation = R5T.D0096.A001.IServiceActionAggregation;
using IMachineOutputActionAggregation = R5T.D0099.A001.IServiceActionAggregation;
using IOrganizationDataDirectoryPathProviderActionAggregation = R5T.Quadia.A001.IServiceActionAggregation01;
using IOutputFilePathProviderActionAggregation = R5T.D0048.A001.IServiceActionAggregation01;


namespace System
{
    public static class IProvidedServiceActionAggregationExtensions
    {
        public static T FillFrom<T>(this T aggregation,
            IProvidedServiceActionAggregation other)
            where T : IProvidedServiceActionAggregation
        {
            (aggregation as IProvidedServiceActionAggregationIncrement).FillFrom(other);

            (aggregation as IHumanOutputActionAggregation).FillFrom(other);
            (aggregation as IMachineOutputActionAggregation).FillFrom(other);
            (aggregation as IOrganizationDataDirectoryPathProviderActionAggregation).FillFrom(other);
            (aggregation as IOutputFilePathProviderActionAggregation).FillFrom(other);

            return aggregation;
        }
    }
}
