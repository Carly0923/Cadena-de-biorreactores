using Dominio_Fermentación.Common;
using Dominio_Fermentación.Errors;
using FluentResults;
using Dominio_Fermentación.Types;

namespace Dominio_Fermentación.Rules
{
    public record IPAddressMustHaveFourSeparators(string IPAddress)
     : IBussiness_Rules
    {
        public Result CheckRule()
        {
            if (IPAddress.Split('.').Count() != 4)
                return Result.Fail(NetworkAddressErrors.InvalidIPAddressFormat);
            return Result.Ok();
        }
    }

    public record IPAddressMustHaveValidValues(
        string IPAddress)
        : IBussiness_Rules
    {
        public Result CheckRule()
        {
            var ipValues = IPAddress.Split(".");
            foreach (var value in ipValues)
            {
                if (!int.TryParse(value, out int numericValue))
                    return Result.Fail(NetworkAddressErrors.InvalidIPAddressFormat);
                if (numericValue < 0 || numericValue > 255)
                    return Result.Fail(NetworkAddressErrors.InvalidIPAddressFormat);
            }
            return Result.Ok();
        }
    }

    public record PortMustBeInAValidRange(
        int Port)
       : IBussiness_Rules
    {
        public Result CheckRule()
        {
            if (Port < 1023 || Port > 65.535)
                return Result.Fail(NetworkAddressErrors.InvalidPort);
            return Result.Ok();
        }
    }
}