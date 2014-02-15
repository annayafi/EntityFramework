// <auto-generated />
namespace Microsoft.Data.Migrations
{
    using System.Globalization;
    using System.Reflection;
    using System.Resources;

    internal static class Strings
    {
        private static readonly ResourceManager _resourceManager
            = new ResourceManager("Microsoft.Data.Migrations.Strings", typeof(Strings).GetTypeInfo().Assembly);

        /// <summary>
        /// The argument '{argumentName}' cannot be null, empty or contain only white space.
        /// </summary>
        internal static string ArgumentIsNullOrWhitespace(object argumentName)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("ArgumentIsNullOrWhitespace", "argumentName"), argumentName);
        }

        /// <summary>
        /// The current migration SQL generator '{sqlGeneratorType}' is unable to generate SQL for operations of type '{operationType}'.
        /// </summary>
        internal static string UnknownOperation(object sqlGeneratorType, object operationType)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("UnknownOperation", "sqlGeneratorType", "operationType"), sqlGeneratorType, operationType);
        }

        private static string GetString(string name, params string[] argumentNames)
        {
            var value = _resourceManager.GetString(name);

            System.Diagnostics.Debug.Assert(value != null);

            for (var i = 0; i < argumentNames.Length; i++)
            {
                value = value.Replace("{" + argumentNames[i] + "}", "{" + i + "}");
            }

            return value;
        }
    }
}
