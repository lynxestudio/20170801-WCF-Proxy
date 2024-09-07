 
using System;
using System.ServiceModel;

namespace Samples.GradeConverterService
{
    [ServiceContract]
    public interface IGradeConverter
    {
        [OperationContract]
        double CelsiusToFahrenheit(double celsius);

        [OperationContract]
        double CelsiusToKelvin(double celsius);

        [OperationContract]
        double FahrenheitToCelsius(double fahrenheit);

        [OperationContract]
        double FahrenheitToKelvin(double fahrenheit);

        [OperationContract]
        double KelvinToCelsius(double kelvin);

        [OperationContract]
        double KelvinToFahrenheit(double kelvin);
    }
}