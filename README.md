# Netizine.Enums.Country
A country enum created to simplyfy mapping countries to a enum. 
Created from the country data exttracted from [Wikipedia](https://en.wikipedia.org/wiki/List_of_ISO_3166_country_codes).

Using Netizine.Enums.Country
------------------------------
To use the country enum in your project, add the [Netizine.Enums.Country](https://www.nuget.org/packages/Netizine.Enums.Country) NuGet package to your project.
------------------------------

Provides a few extension methods to easilly access country name, decription, state name, ISO 3166-1 codes such as the Alpha-2, Alpha-3 and Numeric codes etc as show below.
![Extension Methods](https://user-images.githubusercontent.com/598617/84762987-71be4580-afc3-11ea-86ad-156e769314f9.png)

As a example, calling the following code 
```cs
var imageUri = countries.First().GetDataURIImage();
```
Would return data:image/png;base64,iVBO........ which you can use to render a png country flag for the United States of America ![United States of America](https://upload.wikimedia.org/wikipedia/en/thumb/a/a4/Flag_of_the_United_States.svg/46px-Flag_of_the_United_States.svg.png)


in the case of convert to and from JSOn, i have included a CountryConverter that you can use to try multiple different ways to cast to the correct enum namely country name, country description, the ISO 3166-1 codes etc. 

```cs
        static void Main(string[] args)
        {
            var countries = ((Country[]) Enum.GetValues(typeof(Country)))
                .Where(countryEnum => countryEnum == Country.UnitedStatesOfAmerica || countryEnum == Country.UnitedKingdom).ToList();
            var json = JsonConvert.SerializeObject(countries, Converter.Settings);
            var newCountries = JsonConvert.DeserializeObject<List<Country>>(json, Converter.Settings);
            
            //Validate USA post code
            var usa = Country.UnitedStatesOfAmerica;
            var r = new Regex(usa.GetPostalCodeRegex());
            var postalCodeValid = r.IsMatch("85001");
            var postalCodeInvalid = r.IsMatch("85001A");
        }

        public static class Converter
        {
            public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
            {
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                DateParseHandling = DateParseHandling.None,
                Converters =
                {
                    CountryConverter.Singleton,
                    new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
                },
            };
        }
```


