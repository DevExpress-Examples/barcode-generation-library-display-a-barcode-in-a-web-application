using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Runtime.Serialization;
using System.Reflection;

namespace BarcodeWebApi.Services;

public class BarcodeSymbologyModelBinder : IModelBinder
{
    public Task BindModelAsync(ModelBindingContext bindingContext)
    {
        var valueProviderResult = bindingContext.ValueProvider.GetValue(bindingContext.ModelName);
        if (valueProviderResult == ValueProviderResult.None)
        {
            return Task.CompletedTask;
        }

        var value = valueProviderResult.FirstValue;
        if (string.IsNullOrEmpty(value))
        {
            return Task.CompletedTask;
        }

        // Try to parse using EnumMember attribute values
        var enumType = typeof(BarcodeSymbology);
        foreach (var field in enumType.GetFields(BindingFlags.Public | BindingFlags.Static))
        {
            var attribute = field.GetCustomAttribute<EnumMemberAttribute>();
            if (attribute?.Value?.Equals(value, StringComparison.OrdinalIgnoreCase) == true)
            {
                bindingContext.Result = ModelBindingResult.Success(field.GetValue(null));
                return Task.CompletedTask;
            }
        }

        // Try standard enum parsing as fallback
        if (Enum.TryParse<BarcodeSymbology>(value, ignoreCase: true, out var result))
        {
            bindingContext.Result = ModelBindingResult.Success(result);
            return Task.CompletedTask;
        }

        bindingContext.ModelState.TryAddModelError(
            bindingContext.ModelName,
            $"The value '{value}' is not a valid symbology.");

        return Task.CompletedTask;
    }
}
