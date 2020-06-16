using Newtonsoft.Json;

namespace System.Enums
{
    /// <summary>
    /// Class CountryConverter.
    /// Implements the <see cref="Newtonsoft.Json.JsonConverter" />
    /// </summary>
    /// <seealso cref="Newtonsoft.Json.JsonConverter" />
    public class CountryConverter : JsonConverter
    {
        /// <summary>
        /// Determines whether this instance can convert the specified type.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns><c>true</c> if this instance can convert the specified type; otherwise, <c>false</c>.</returns>
        public override bool CanConvert(Type type) => type == typeof(Country);

        /// <summary>
        /// Reads the json.
        /// </summary>
        /// <param name="reader">The reader.</param>
        /// <param name="type">The type.</param>
        /// <param name="existingValue">The existing value.</param>
        /// <param name="serializer">The serializer.</param>
        /// <returns>System.Object.</returns>
        public override object ReadJson(JsonReader reader, Type type, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == null)
            {
                return Country.NotSet;
            }
            if (Enum.TryParse(value, true, out Country country))
            {
                return country;
            }
            else
            {
                //As we couldn't map the value to the enum directly, try map it using the country description
                foreach (var countryEnum in (Country[])Enum.GetValues(typeof(Country)))
                {
                    if (!string.Equals(countryEnum.Description(), value, StringComparison.InvariantCultureIgnoreCase)) continue;
                    return countryEnum;
                }
                //Next attempt to map the value to the enum directly using the country name
                foreach (var countryEnum in (Country[])Enum.GetValues(typeof(Country)))
                {
                    if (!string.Equals(countryEnum.Name(), value, StringComparison.InvariantCultureIgnoreCase)) continue;
                    return countryEnum;
                }
                //As we still couldn't map the value to the enum directly, try using the countries Alpha2Code
                foreach (var countryEnum in (Country[])Enum.GetValues(typeof(Country)))
                {
                    if (!string.Equals(countryEnum.Alpha2Code(), value, StringComparison.InvariantCultureIgnoreCase)) continue;
                    return countryEnum;
                }
                //Now lets try map the value to the enum directly, using the the countries Alpha3Code
                foreach (var countryEnum in (Country[])Enum.GetValues(typeof(Country)))
                {
                    if (!string.Equals(countryEnum.Alpha3Code(), value, StringComparison.InvariantCultureIgnoreCase)) continue;
                    return countryEnum;
                }
                //Finally lets try map the value to the enum directly, using the countries NumericCode
                foreach (var countryEnum in (Country[])Enum.GetValues(typeof(Country)))
                {
                    if (!string.Equals(countryEnum.NumericCode(), value, StringComparison.InvariantCultureIgnoreCase)) continue;
                    return countryEnum;
                }

            }
            //throw new Exception("Cannot marshal type Country for value " + value);
            return Country.NotSet;
        }

        /// <summary>
        /// Writes the json.
        /// </summary>
        /// <param name="writer">The writer.</param>
        /// <param name="untypedValue">The untyped value.</param>
        /// <param name="serializer">The serializer.</param>
        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Country)untypedValue;
            serializer.Serialize(writer, value);
        }

        /// <summary>
        /// The singleton
        /// </summary>
        public static readonly CountryConverter Singleton = new CountryConverter();
    }
}
