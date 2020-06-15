using System.Globalization;
using System.Linq;

namespace System.Enums
{
    /// <summary>
    /// Class CountryExtension.
    /// </summary>
    public static class CountryExtension
    {
        /// <summary>
        /// Gets the official state name for the country using the data supplied at https://en.wikipedia.org/wiki/List_of_ISO_3166_country_codes
        /// </summary>
        /// <param name="country">The country.</param>
        /// <returns>System.String.</returns>
        public static string Description(this Country country)
        {
            var genericEnumType = country.GetType();
            var memberInfo = genericEnumType.GetMember(country.ToString());
            if ((memberInfo.Length <= 0)) return country.ToString();
            var customAttributes = memberInfo[0].GetCustomAttributes(typeof(System.ComponentModel.DescriptionAttribute), false);
            return customAttributes.Any() ? ((System.ComponentModel.DescriptionAttribute)customAttributes.ElementAt(0)).Description : country.ToString();
        }

        /// <summary>
        /// Gets the name for the country using the data supplied at https://en.wikipedia.org/wiki/List_of_ISO_3166_country_codes
        /// </summary>
        /// <param name="country">The country.</param>
        /// <returns>System.String.</returns>
        public static string Name(this Country country)
        {
            switch (country)
            {
                case Country.NotSet:
                    return string.Empty;
                //NamePlaceholder
                default:
                    return string.Empty;
            }
        }

        /// <summary>
        /// Gets the ISO 3166-1 alpha-2 country codes as defined in ISO 3166-1.
        /// </summary>
        /// <param name="country">The country.</param>
        /// <returns>System.String.</returns>
        public static string Alpha2Code(this Country country)
        {
            switch (country)
            {
                case Country.NotSet:
                    return string.Empty;
                //Alpha2CodePlaceholder
                default:
                    return string.Empty;
            }
        }

        /// <summary>
        /// Gets the ISO 3166-1 alpha-3 country codes as defined in ISO 3166-1
        /// </summary>
        /// <param name="country">The country.</param>
        /// <returns>System.String.</returns>
        public static string Alpha3Code(this Country country)
        {
            switch (country)
            {
                case Country.NotSet:
                    return string.Empty;
                //Alpha3CodePlaceholder
                default:
                    return string.Empty;
            }
        }

        /// <summary>
        /// Gets the ISO 3166-1 numeric codes as defined in ISO 3166-1
        /// </summary>
        /// <param name="country">The country.</param>
        /// <returns>System.String.</returns>
        public static string NumericCode(this Country country)
        {
            switch (country)
            {
                case Country.NotSet:
                    return string.Empty;
                //NumericCodePlaceholder
                default:
                    return string.Empty;
            }
        }

        /// <summary>
        /// The country data URI scheme to provide the actual content of the resource in the URI.
        /// </summary>
        /// <param name="country">The country.</param>
        /// <returns>System.String.</returns>
        public static string DataURIImage(this Country country)
        {
            switch (country)
            {
                case Country.NotSet:
                    return string.Empty;
                //DataURIImagePlaceholder
                default:
                    return string.Empty;
            }
        }

        /// <summary>
        /// Gets the country calling codes or country dial-in codes are telephone number prefixes  for reaching telephone subscribers
        /// </summary>
        /// <param name="country">The country.</param>
        /// <returns>System.String.</returns>
        public static string DialingCode(this Country country)
        {
            switch (country)
            {
                case Country.NotSet:
                    return string.Empty;
                //CountryDialingCodePlaceholder
                default:
                    return string.Empty;
            }
        }

        /// <summary>
        /// Gets the country currency symbol as defined in the ISO 4217 standard which delineates currency designators.
        /// </summary>
        /// <param name="country">The country.</param>
        /// <returns>System.String.</returns>
        public static string CurrencySymbol(this Country country)
        {
            switch (country)
            {
                case Country.NotSet:
                    return string.Empty;
                //CurrencySymbolPlaceholder
                default:
                    return string.Empty;
            }
        }

        /// <summary>
        /// "The countries currency name
        /// </summary>
        /// <param name="country">The country.</param>
        /// <returns>System.String.</returns>
        public static string CurrencyName(this Country country)
        {
            switch (country)
            {
                case Country.NotSet:
                    return string.Empty;
                //CurrencyNamePlaceholder
                default:
                    return string.Empty;
            }
        }

        /// <summary>
        /// Gets the Continent the country is situated in.
        /// </summary>
        /// <param name="country">The country.</param>
        /// <returns>System.Enums.Continent.</returns>
        public static System.Enums.Continent Continent(this Country country)
        {
            switch (country)
            {
                case Country.NotSet:
                    return Enums.Continent.NotSet;
                //ContinentPlaceholder
                default:
                    return Enums.Continent.NotSet;
            }
        }

        /// <summary>
        /// Gets the countries postal code format as defined by the Area format at https://en.wikipedia.org/wiki/List_of_postal_codes
        /// </summary>
        /// <param name="country">The country.</param>
        /// <returns>System.String.</returns>
        public static string PostalCodeFormat(this Country country)
        {
            switch (country)
            {
                case Country.NotSet:
                    return string.Empty;
                //PostalCodeFormatPlaceholder
                default:
                    return string.Empty;
            }
        }

        /// <summary>
        /// The countries post code regular expression
        /// </summary>
        /// <param name="country">The country.</param>
        /// <returns>System.String.</returns>
        public static string PostalCodeRegex(this Country country)
        {
            switch (country)
            {
                case Country.NotSet:
                    return string.Empty;
                //PostalCodeRegexPlaceholder
                default:
                    return string.Empty;
            }
        }

        /// <summary>
        /// Gets culture specific information about the format of date and time values used by the country
        /// </summary>
        /// <param name="country">The country.</param>
        /// <returns>DateTimeFormatInfo.</returns>
        public static DateTimeFormatInfo DateTimeFormat(this Country country)
        {
            switch (country)
            {
                case Country.NotSet:
                    var culture = new CultureInfo("EN");
                    return culture.DateTimeFormat;
                //DateTimeFormatPlaceholder
                default:
                    culture = new CultureInfo("EN");
                    return culture.DateTimeFormat;
            }
        }

        /// <summary>
        /// Gets a calendar that represents the divisions, such as weeks, months and years used by the country
        /// </summary>
        /// <param name="country">The country.</param>
        /// <returns>Calendar.</returns>
        public static Calendar Calendar(this Country country)
        {
            switch (country)
            {
                case Country.NotSet:
                    var culture = new CultureInfo("EN");
                    return culture.Calendar;
                //CalendarPlaceholder
                default:
                    culture = new CultureInfo("EN");
                    return culture.Calendar;
            }
        }

        /// <summary>
        /// Gets the appropriate format for displaying numbers, currency and percentages used by the country
        /// </summary>
        /// <param name="country">The country.</param>
        /// <returns>NumberFormatInfo.</returns>
        public static NumberFormatInfo NumberFormat(this Country country)
        {
            switch (country)
            {
                case Country.NotSet:
                    var culture = new CultureInfo("EN");
                    return culture.NumberFormat;
                //NumberFormatPlaceholder
                default:
                    culture = new CultureInfo("EN");
                    return culture.NumberFormat;
            }
        }

    }

}
