using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Text;

namespace System.Enums
{
    public static class CountryExtension
    {
        public static string Description<TCountry>(this TCountry source)
        {
            if (source == null)
            {
                return string.Empty;
            }
            var fi = source.GetType().GetField(source.ToString());
            if (fi == null)
            {
                return string.Empty;
            }
            var attributes = (DescriptionAttribute[])fi.GetCustomAttributes(
                typeof(DescriptionAttribute), false);

            if (attributes.Length > 0)
            {
                if (attributes[0].Description == null)
                {
                    return string.Empty;
                }
                return attributes[0].Description;

            }
            return source.ToString();
        }

        public static string Name<TCountry>(this TCountry source)
        {
            if (source == null)
            {
                return string.Empty;
            }
            var fi = source.GetType().GetField(source.ToString());
            if (fi == null)
            {
                return string.Empty;
            }
            var attributes = (DescriptionAttribute[])fi.GetCustomAttributes(
                typeof(DescriptionAttribute), false);

            if (attributes.Length > 0)
            {
                if (attributes[0].Description == null)
                {
                    return string.Empty;
                }
                var attributeDesc = attributes[0].Description;
                switch (attributeDesc)
                {
                    //NamePlaceholder
                    default:
                        return string.Empty;
                }

            }
            return string.Empty;
        }

        public static string Alpha2Code<TCountry>(this TCountry source)
        {
            if (source == null)
            {
                return string.Empty;
            }
            var fi = source.GetType().GetField(source.ToString());
            if (fi == null)
            {
                return string.Empty;
            }
            var attributes = (DescriptionAttribute[])fi.GetCustomAttributes(
                typeof(DescriptionAttribute), false);

            if (attributes.Length > 0)
            {
                if (attributes[0].Description == null)
                {
                    return string.Empty;
                }
                var attributeDesc = attributes[0].Description;
                switch (attributeDesc)
                {
                    //Alpha2CodePlaceholder
                    default:
                        return string.Empty;
                }

            }
            return string.Empty;
        }

        public static string Alpha3Code<TCountry>(this TCountry source)
        {
            if (source == null)
            {
                return string.Empty;
            }
            var fi = source.GetType().GetField(source.ToString());
            if (fi == null)
            {
                return string.Empty;
            }
            var attributes = (DescriptionAttribute[])fi.GetCustomAttributes(
                typeof(DescriptionAttribute), false);

            if (attributes.Length > 0)
            {
                if (attributes[0].Description == null)
                {
                    return string.Empty;
                }
                var attributeDesc = attributes[0].Description;
                switch (attributeDesc)
                {
                    //Alpha3CodePlaceholder
                    default:
                        return string.Empty;
                }

            }
            return string.Empty;
        }

        public static string NumericCode<TCountry>(this TCountry source)
        {
            if (source == null)
            {
                return string.Empty;
            }
            var fi = source.GetType().GetField(source.ToString());
            if (fi == null)
            {
                return string.Empty;
            }
            var attributes = (DescriptionAttribute[])fi.GetCustomAttributes(
                typeof(DescriptionAttribute), false);

            if (attributes.Length > 0)
            {
                if (attributes[0].Description == null)
                {
                    return string.Empty;
                }
                var attributeDesc = attributes[0].Description;
                switch (attributeDesc)
                {
                    //NumericCodePlaceholder
                    default:
                        return string.Empty;
                }

            }
            return string.Empty;
        }

        public static string CountryDataURIImage<TCountry>(this TCountry source)
        {
            if (source == null)
            {
                return string.Empty;
            }
            var fi = source.GetType().GetField(source.ToString());
            if (fi == null)
            {
                return string.Empty;
            }
            var attributes = (DescriptionAttribute[])fi.GetCustomAttributes(
                typeof(DescriptionAttribute), false);

            if (attributes.Length > 0)
            {
                if (attributes[0].Description == null)
                {
                    return string.Empty;
                }
                var attributeDesc = attributes[0].Description;
                switch (attributeDesc)
                {
                    //CountryDataURIImagePlaceholder
                    default:
                        return string.Empty;
                }

            }
            return string.Empty;
        }

        public static string CountryDialingCode<TCountry>(this TCountry source)
        {
            if (source == null)
            {
                return string.Empty;
            }
            var fi = source.GetType().GetField(source.ToString());
            if (fi == null)
            {
                return string.Empty;
            }
            var attributes = (DescriptionAttribute[])fi.GetCustomAttributes(
                typeof(DescriptionAttribute), false);

            if (attributes.Length > 0)
            {
                if (attributes[0].Description == null)
                {
                    return string.Empty;
                }
                var attributeDesc = attributes[0].Description;
                switch (attributeDesc)
                {
                    //CountryDialingCodePlaceholder
                    default:
                        return string.Empty;
                }

            }
            return string.Empty;
        }

        public static string CurrencySymbol<TCountry>(this TCountry source)
        {
            if (source == null)
            {
                return string.Empty;
            }
            var fi = source.GetType().GetField(source.ToString());
            if (fi == null)
            {
                return string.Empty;
            }
            var attributes = (DescriptionAttribute[])fi.GetCustomAttributes(
                typeof(DescriptionAttribute), false);

            if (attributes.Length > 0)
            {
                if (attributes[0].Description == null)
                {
                    return string.Empty;
                }
                var attributeDesc = attributes[0].Description;
                switch (attributeDesc)
                {
                    //CurrencySymbolPlaceholder
                    default:
                        return string.Empty;
                }

            }
            return string.Empty;
        }

        public static string CurrencyName<TCountry>(this TCountry source)
        {
            if (source == null)
            {
                return string.Empty;
            }
            var fi = source.GetType().GetField(source.ToString());
            if (fi == null)
            {
                return string.Empty;
            }
            var attributes = (DescriptionAttribute[])fi.GetCustomAttributes(
                typeof(DescriptionAttribute), false);

            if (attributes.Length > 0)
            {
                if (attributes[0].Description == null)
                {
                    return string.Empty;
                }
                var attributeDesc = attributes[0].Description;
                switch (attributeDesc)
                {
                    //CurrencyNamePlaceholder
                    default:
                        return string.Empty;
                }

            }
            return string.Empty;
        }

        public static System.Enums.Continent Continent<TCountry>(this TCountry source)
        {
            if (source == null)
            {
                return System.Enums.Continent.NotSet;
            }
            var fi = source.GetType().GetField(source.ToString());
            if (fi == null)
            {
                return System.Enums.Continent.NotSet;
            }
            var attributes = (DescriptionAttribute[])fi.GetCustomAttributes(
                typeof(DescriptionAttribute), false);

            if (attributes.Length > 0)
            {
                if (attributes[0].Description == null)
                {
                    return System.Enums.Continent.NotSet;
                }
                var attributeDesc = attributes[0].Description;
                switch (attributeDesc)
                {
                    //ContinentPlaceholder
                    default:
                        return System.Enums.Continent.NotSet;
                }

            }
            return System.Enums.Continent.NotSet;
        }

        public static string PostalCodeFormat<TCountry>(this TCountry source)
        {
            if (source == null)
            {
                return string.Empty;
            }
            var fi = source.GetType().GetField(source.ToString());
            if (fi == null)
            {
                return string.Empty;
            }
            var attributes = (DescriptionAttribute[])fi.GetCustomAttributes(
                typeof(DescriptionAttribute), false);

            if (attributes.Length > 0)
            {
                if (attributes[0].Description == null)
                {
                    return string.Empty;
                }
                var attributeDesc = attributes[0].Description;
                switch (attributeDesc)
                {
                    //PostalCodeFormatPlaceholder
                    default:
                        return string.Empty;
                }

            }
            return string.Empty;
        }

        public static string PostalCodeRegex<TCountry>(this TCountry source)
        {
            if (source == null)
            {
                return string.Empty;
            }
            var fi = source.GetType().GetField(source.ToString());
            if (fi == null)
            {
                return string.Empty;
            }
            var attributes = (DescriptionAttribute[])fi.GetCustomAttributes(
                typeof(DescriptionAttribute), false);

            if (attributes.Length > 0)
            {
                if (attributes[0].Description == null)
                {
                    return string.Empty;
                }
                var attributeDesc = attributes[0].Description;
                switch (attributeDesc)
                {
                    //PostalCodeRegexPlaceholder
                    default:
                        return string.Empty;
                }

            }
            return string.Empty;
        }

        public static DateTimeFormatInfo DateTimeFormat<TCountry>(this TCountry source)
        {
            var culture = new CultureInfo("EN");
            if (source == null)
            {
                return culture.DateTimeFormat;
            }
            var fi = source.GetType().GetField(source.ToString());
            if (fi == null)
            {
                return culture.DateTimeFormat;
            }
            var attributes = (DescriptionAttribute[])fi.GetCustomAttributes(
                typeof(DescriptionAttribute), false);

            if (attributes.Length > 0)
            {
                if (attributes[0].Description == null)
                {
                    return culture.DateTimeFormat;
                }
                var attributeDesc = attributes[0].Description;
                switch (attributeDesc)
                {
                    //DateTimeFormatPlaceholder
                    default:
                        return culture.DateTimeFormat;
                }

            }
            return culture.DateTimeFormat;
        }

        public static Calendar Calendar<TCountry>(this TCountry source)
        {
            var culture = new CultureInfo("EN");
            if (source == null)
            {
                return culture.Calendar;
            }
            var fi = source.GetType().GetField(source.ToString());
            if (fi == null)
            {
                return culture.Calendar;
            }
            var attributes = (DescriptionAttribute[])fi.GetCustomAttributes(
                typeof(DescriptionAttribute), false);

            if (attributes.Length > 0)
            {
                if (attributes[0].Description == null)
                {
                    return culture.Calendar;
                }
                var attributeDesc = attributes[0].Description;
                switch (attributeDesc)
                {
                    //CalendarPlaceholder
                    default:
                        return culture.Calendar;
                }

            }
            return culture.Calendar;
        }

        public static NumberFormatInfo NumberFormat<TCountry>(this TCountry source)
        {
            var culture = new CultureInfo("EN");
            if (source == null)
            {
                return culture.NumberFormat;
            }
            var fi = source.GetType().GetField(source.ToString());
            if (fi == null)
            {
                return culture.NumberFormat;
            }
            var attributes = (DescriptionAttribute[])fi.GetCustomAttributes(
                typeof(DescriptionAttribute), false);

            if (attributes.Length > 0)
            {
                if (attributes[0].Description == null)
                {
                    return culture.NumberFormat;
                }
                var attributeDesc = attributes[0].Description;
                switch (attributeDesc)
                {
                    //NumberFormatPlaceholder
                    default:
                        return culture.NumberFormat;
                }

            }
            return culture.NumberFormat;
        }

    }

}
