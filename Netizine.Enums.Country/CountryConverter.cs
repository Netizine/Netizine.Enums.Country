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
                foreach (var countryEnum in (Country[]) Enum.GetValues(typeof(Country)))
                {
                    if (!string.Equals(countryEnum.GetDescription(), value,
                        StringComparison.InvariantCultureIgnoreCase)) continue;
                    return countryEnum;
                }

                //Next attempt to map the value to the enum directly using the country name
                foreach (var countryEnum in (Country[]) Enum.GetValues(typeof(Country)))
                {
                    if (!string.Equals(countryEnum.GetName(), value, StringComparison.InvariantCultureIgnoreCase))
                        continue;
                    return countryEnum;
                }

                //As we still couldn't map the value to the enum directly, try using the countries Alpha2Code
                foreach (var countryEnum in (Country[]) Enum.GetValues(typeof(Country)))
                {
                    if (!string.Equals(countryEnum.GetAlpha2Code(), value,
                        StringComparison.InvariantCultureIgnoreCase)) continue;
                    return countryEnum;
                }

                //Now lets try map the value to the enum directly, using the the countries Alpha3Code
                foreach (var countryEnum in (Country[]) Enum.GetValues(typeof(Country)))
                {
                    if (!string.Equals(countryEnum.GetAlpha3Code(), value,
                        StringComparison.InvariantCultureIgnoreCase)) continue;
                    return countryEnum;
                }

                //Finally lets try map the value to the enum directly, using the countries NumericCode
                foreach (var countryEnum in (Country[]) Enum.GetValues(typeof(Country)))
                {
                    if (!string.Equals(countryEnum.GetNumericCode(), value,
                        StringComparison.InvariantCultureIgnoreCase)) continue;
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

            var value = (Country) untypedValue;
            switch (value)
            {
                case Country.NotSet:
                    serializer.Serialize(writer, "notSet");
                    return;
                case Country.Afghanistan:
                    serializer.Serialize(writer, "afghanistan");
                    return;
                case Country.AlandIslands:
                    serializer.Serialize(writer, "alandIslands");
                    return;
                case Country.Albania:
                    serializer.Serialize(writer, "albania");
                    return;
                case Country.Algeria:
                    serializer.Serialize(writer, "algeria");
                    return;
                case Country.AmericanSamoa:
                    serializer.Serialize(writer, "americanSamoa");
                    return;
                case Country.Andorra:
                    serializer.Serialize(writer, "andorra");
                    return;
                case Country.Angola:
                    serializer.Serialize(writer, "angola");
                    return;
                case Country.Anguilla:
                    serializer.Serialize(writer, "anguilla");
                    return;
                case Country.Antarctica:
                    serializer.Serialize(writer, "antarctica");
                    return;
                case Country.AntiguaAndBarbuda:
                    serializer.Serialize(writer, "antiguaAndBarbuda");
                    return;
                case Country.Argentina:
                    serializer.Serialize(writer, "argentina");
                    return;
                case Country.Armenia:
                    serializer.Serialize(writer, "armenia");
                    return;
                case Country.Aruba:
                    serializer.Serialize(writer, "aruba");
                    return;
                case Country.Australia:
                    serializer.Serialize(writer, "australia");
                    return;
                case Country.Austria:
                    serializer.Serialize(writer, "austria");
                    return;
                case Country.Azerbaijan:
                    serializer.Serialize(writer, "azerbaijan");
                    return;
                case Country.Bahamas:
                    serializer.Serialize(writer, "bahamas");
                    return;
                case Country.Bahrain:
                    serializer.Serialize(writer, "bahrain");
                    return;
                case Country.Bangladesh:
                    serializer.Serialize(writer, "bangladesh");
                    return;
                case Country.Barbados:
                    serializer.Serialize(writer, "barbados");
                    return;
                case Country.Belarus:
                    serializer.Serialize(writer, "belarus");
                    return;
                case Country.Belgium:
                    serializer.Serialize(writer, "belgium");
                    return;
                case Country.Belize:
                    serializer.Serialize(writer, "belize");
                    return;
                case Country.Benin:
                    serializer.Serialize(writer, "benin");
                    return;
                case Country.Bermuda:
                    serializer.Serialize(writer, "bermuda");
                    return;
                case Country.Bhutan:
                    serializer.Serialize(writer, "bhutan");
                    return;
                case Country.BoliviaPlurinationalState:
                    serializer.Serialize(writer, "boliviaPlurinationalState");
                    return;
                case Country.Bonaire:
                    serializer.Serialize(writer, "bonaire");
                    return;
                case Country.BosniaAndHerzegovina:
                    serializer.Serialize(writer, "bosniaAndHerzegovina");
                    return;
                case Country.Botswana:
                    serializer.Serialize(writer, "botswana");
                    return;
                case Country.BouvetIsland:
                    serializer.Serialize(writer, "bouvetIsland");
                    return;
                case Country.Brazil:
                    serializer.Serialize(writer, "brazil");
                    return;
                case Country.BritishIndianOceanTerritory:
                    serializer.Serialize(writer, "britishIndianOceanTerritory");
                    return;
                case Country.BruneiDarussalam:
                    serializer.Serialize(writer, "bruneiDarussalam");
                    return;
                case Country.Bulgaria:
                    serializer.Serialize(writer, "bulgaria");
                    return;
                case Country.BurkinaFaso:
                    serializer.Serialize(writer, "burkinaFaso");
                    return;
                case Country.Burundi:
                    serializer.Serialize(writer, "burundi");
                    return;
                case Country.CaboVerde:
                    serializer.Serialize(writer, "caboVerde");
                    return;
                case Country.Cambodia:
                    serializer.Serialize(writer, "cambodia");
                    return;
                case Country.Cameroon:
                    serializer.Serialize(writer, "cameroon");
                    return;
                case Country.Canada:
                    serializer.Serialize(writer, "canada");
                    return;
                case Country.CaymanIslands:
                    serializer.Serialize(writer, "caymanIslands");
                    return;
                case Country.CentralAfricanRepublic:
                    serializer.Serialize(writer, "centralAfricanRepublic");
                    return;
                case Country.Chad:
                    serializer.Serialize(writer, "chad");
                    return;
                case Country.Chile:
                    serializer.Serialize(writer, "chile");
                    return;
                case Country.China:
                    serializer.Serialize(writer, "china");
                    return;
                case Country.ChristmasIsland:
                    serializer.Serialize(writer, "christmasIsland");
                    return;
                case Country.CocosKeelingIslands:
                    serializer.Serialize(writer, "cocosKeelingIslands");
                    return;
                case Country.Colombia:
                    serializer.Serialize(writer, "colombia");
                    return;
                case Country.Comoros:
                    serializer.Serialize(writer, "comoros");
                    return;
                case Country.CongoTheDemocraticRepublic:
                    serializer.Serialize(writer, "congoTheDemocraticRepublic");
                    return;
                case Country.Congo:
                    serializer.Serialize(writer, "congo");
                    return;
                case Country.CookIslands:
                    serializer.Serialize(writer, "cookIslands");
                    return;
                case Country.CostaRica:
                    serializer.Serialize(writer, "costaRica");
                    return;
                case Country.CotedIvoire:
                    serializer.Serialize(writer, "cotedIvoire");
                    return;
                case Country.Croatia:
                    serializer.Serialize(writer, "croatia");
                    return;
                case Country.Cuba:
                    serializer.Serialize(writer, "cuba");
                    return;
                case Country.Curacao:
                    serializer.Serialize(writer, "curacao");
                    return;
                case Country.Cyprus:
                    serializer.Serialize(writer, "cyprus");
                    return;
                case Country.Czechia:
                    serializer.Serialize(writer, "czechia");
                    return;
                case Country.Denmark:
                    serializer.Serialize(writer, "denmark");
                    return;
                case Country.Djibouti:
                    serializer.Serialize(writer, "djibouti");
                    return;
                case Country.Dominica:
                    serializer.Serialize(writer, "dominica");
                    return;
                case Country.DominicanRepublic:
                    serializer.Serialize(writer, "dominicanRepublic");
                    return;
                case Country.Ecuador:
                    serializer.Serialize(writer, "ecuador");
                    return;
                case Country.Egypt:
                    serializer.Serialize(writer, "egypt");
                    return;
                case Country.ElSalvador:
                    serializer.Serialize(writer, "elSalvador");
                    return;
                case Country.EquatorialGuinea:
                    serializer.Serialize(writer, "equatorialGuinea");
                    return;
                case Country.Eritrea:
                    serializer.Serialize(writer, "eritrea");
                    return;
                case Country.Estonia:
                    serializer.Serialize(writer, "estonia");
                    return;
                case Country.Eswatini:
                    serializer.Serialize(writer, "eswatini");
                    return;
                case Country.Ethiopia:
                    serializer.Serialize(writer, "ethiopia");
                    return;
                case Country.FalklandIslandsTheMalvinas:
                    serializer.Serialize(writer, "falklandIslandsTheMalvinas");
                    return;
                case Country.FaroeIslands:
                    serializer.Serialize(writer, "faroeIslands");
                    return;
                case Country.Fiji:
                    serializer.Serialize(writer, "fiji");
                    return;
                case Country.Finland:
                    serializer.Serialize(writer, "finland");
                    return;
                case Country.France:
                    serializer.Serialize(writer, "france");
                    return;
                case Country.FrenchGuiana:
                    serializer.Serialize(writer, "frenchGuiana");
                    return;
                case Country.FrenchPolynesia:
                    serializer.Serialize(writer, "frenchPolynesia");
                    return;
                case Country.FrenchSouthernTerritories:
                    serializer.Serialize(writer, "frenchSouthernTerritories");
                    return;
                case Country.Gabon:
                    serializer.Serialize(writer, "gabon");
                    return;
                case Country.Gambia:
                    serializer.Serialize(writer, "gambia");
                    return;
                case Country.Georgia:
                    serializer.Serialize(writer, "georgia");
                    return;
                case Country.Germany:
                    serializer.Serialize(writer, "germany");
                    return;
                case Country.Ghana:
                    serializer.Serialize(writer, "ghana");
                    return;
                case Country.Gibraltar:
                    serializer.Serialize(writer, "gibraltar");
                    return;
                case Country.Greece:
                    serializer.Serialize(writer, "greece");
                    return;
                case Country.Greenland:
                    serializer.Serialize(writer, "greenland");
                    return;
                case Country.Grenada:
                    serializer.Serialize(writer, "grenada");
                    return;
                case Country.Guadeloupe:
                    serializer.Serialize(writer, "guadeloupe");
                    return;
                case Country.Guam:
                    serializer.Serialize(writer, "guam");
                    return;
                case Country.Guatemala:
                    serializer.Serialize(writer, "guatemala");
                    return;
                case Country.Guernsey:
                    serializer.Serialize(writer, "guernsey");
                    return;
                case Country.Guinea:
                    serializer.Serialize(writer, "guinea");
                    return;
                case Country.GuineaBissau:
                    serializer.Serialize(writer, "guineaBissau");
                    return;
                case Country.Guyana:
                    serializer.Serialize(writer, "guyana");
                    return;
                case Country.Haiti:
                    serializer.Serialize(writer, "haiti");
                    return;
                case Country.HeardIslandAndMcDonaldIslands:
                    serializer.Serialize(writer, "heardIslandAndMcDonaldIslands");
                    return;
                case Country.HolySee:
                    serializer.Serialize(writer, "holySee");
                    return;
                case Country.Honduras:
                    serializer.Serialize(writer, "honduras");
                    return;
                case Country.HongKong:
                    serializer.Serialize(writer, "hongKong");
                    return;
                case Country.Hungary:
                    serializer.Serialize(writer, "hungary");
                    return;
                case Country.Iceland:
                    serializer.Serialize(writer, "iceland");
                    return;
                case Country.India:
                    serializer.Serialize(writer, "india");
                    return;
                case Country.Indonesia:
                    serializer.Serialize(writer, "indonesia");
                    return;
                case Country.IranIslamicRepublic:
                    serializer.Serialize(writer, "iranIslamicRepublic");
                    return;
                case Country.Iraq:
                    serializer.Serialize(writer, "iraq");
                    return;
                case Country.Ireland:
                    serializer.Serialize(writer, "ireland");
                    return;
                case Country.IsleOfMan:
                    serializer.Serialize(writer, "isleOfMan");
                    return;
                case Country.Israel:
                    serializer.Serialize(writer, "israel");
                    return;
                case Country.Italy:
                    serializer.Serialize(writer, "italy");
                    return;
                case Country.Jamaica:
                    serializer.Serialize(writer, "jamaica");
                    return;
                case Country.Japan:
                    serializer.Serialize(writer, "japan");
                    return;
                case Country.Jersey:
                    serializer.Serialize(writer, "jersey");
                    return;
                case Country.Jordan:
                    serializer.Serialize(writer, "jordan");
                    return;
                case Country.Kazakhstan:
                    serializer.Serialize(writer, "kazakhstan");
                    return;
                case Country.Kenya:
                    serializer.Serialize(writer, "kenya");
                    return;
                case Country.Kiribati:
                    serializer.Serialize(writer, "kiribati");
                    return;
                case Country.KoreaTheDemocraticPeoplesRepublic:
                    serializer.Serialize(writer, "koreaTheDemocraticPeoplesRepublic");
                    return;
                case Country.KoreaTheRepublic:
                    serializer.Serialize(writer, "koreaTheRepublic");
                    return;
                case Country.Kuwait:
                    serializer.Serialize(writer, "kuwait");
                    return;
                case Country.Kyrgyzstan:
                    serializer.Serialize(writer, "kyrgyzstan");
                    return;
                case Country.LaoPeoplesDemocraticRepublic:
                    serializer.Serialize(writer, "laoPeoplesDemocraticRepublic");
                    return;
                case Country.Latvia:
                    serializer.Serialize(writer, "latvia");
                    return;
                case Country.Lebanon:
                    serializer.Serialize(writer, "lebanon");
                    return;
                case Country.Lesotho:
                    serializer.Serialize(writer, "lesotho");
                    return;
                case Country.Liberia:
                    serializer.Serialize(writer, "liberia");
                    return;
                case Country.Libya:
                    serializer.Serialize(writer, "libya");
                    return;
                case Country.Liechtenstein:
                    serializer.Serialize(writer, "liechtenstein");
                    return;
                case Country.Lithuania:
                    serializer.Serialize(writer, "lithuania");
                    return;
                case Country.Luxembourg:
                    serializer.Serialize(writer, "luxembourg");
                    return;
                case Country.Macao:
                    serializer.Serialize(writer, "macao");
                    return;
                case Country.NorthMacedonia:
                    serializer.Serialize(writer, "northMacedonia");
                    return;
                case Country.Madagascar:
                    serializer.Serialize(writer, "madagascar");
                    return;
                case Country.Malawi:
                    serializer.Serialize(writer, "malawi");
                    return;
                case Country.Malaysia:
                    serializer.Serialize(writer, "malaysia");
                    return;
                case Country.Maldives:
                    serializer.Serialize(writer, "maldives");
                    return;
                case Country.Mali:
                    serializer.Serialize(writer, "mali");
                    return;
                case Country.Malta:
                    serializer.Serialize(writer, "malta");
                    return;
                case Country.MarshallIslands:
                    serializer.Serialize(writer, "marshallIslands");
                    return;
                case Country.Martinique:
                    serializer.Serialize(writer, "martinique");
                    return;
                case Country.Mauritania:
                    serializer.Serialize(writer, "mauritania");
                    return;
                case Country.Mauritius:
                    serializer.Serialize(writer, "mauritius");
                    return;
                case Country.Mayotte:
                    serializer.Serialize(writer, "mayotte");
                    return;
                case Country.Mexico:
                    serializer.Serialize(writer, "mexico");
                    return;
                case Country.MicronesiaFederatedStates:
                    serializer.Serialize(writer, "micronesiaFederatedStates");
                    return;
                case Country.MoldovaTheRepublic:
                    serializer.Serialize(writer, "moldovaTheRepublic");
                    return;
                case Country.Monaco:
                    serializer.Serialize(writer, "monaco");
                    return;
                case Country.Mongolia:
                    serializer.Serialize(writer, "mongolia");
                    return;
                case Country.Montenegro:
                    serializer.Serialize(writer, "montenegro");
                    return;
                case Country.Montserrat:
                    serializer.Serialize(writer, "montserrat");
                    return;
                case Country.Morocco:
                    serializer.Serialize(writer, "morocco");
                    return;
                case Country.Mozambique:
                    serializer.Serialize(writer, "mozambique");
                    return;
                case Country.Myanmar:
                    serializer.Serialize(writer, "myanmar");
                    return;
                case Country.Namibia:
                    serializer.Serialize(writer, "namibia");
                    return;
                case Country.Nauru:
                    serializer.Serialize(writer, "nauru");
                    return;
                case Country.Nepal:
                    serializer.Serialize(writer, "nepal");
                    return;
                case Country.Netherlands:
                    serializer.Serialize(writer, "netherlands");
                    return;
                case Country.NewCaledonia:
                    serializer.Serialize(writer, "newCaledonia");
                    return;
                case Country.NewZealand:
                    serializer.Serialize(writer, "newZealand");
                    return;
                case Country.Nicaragua:
                    serializer.Serialize(writer, "nicaragua");
                    return;
                case Country.Niger:
                    serializer.Serialize(writer, "niger");
                    return;
                case Country.Nigeria:
                    serializer.Serialize(writer, "nigeria");
                    return;
                case Country.Niue:
                    serializer.Serialize(writer, "niue");
                    return;
                case Country.NorfolkIsland:
                    serializer.Serialize(writer, "norfolkIsland");
                    return;
                case Country.NorthernMarianaIslands:
                    serializer.Serialize(writer, "northernMarianaIslands");
                    return;
                case Country.Norway:
                    serializer.Serialize(writer, "norway");
                    return;
                case Country.Oman:
                    serializer.Serialize(writer, "oman");
                    return;
                case Country.Pakistan:
                    serializer.Serialize(writer, "pakistan");
                    return;
                case Country.Palau:
                    serializer.Serialize(writer, "palau");
                    return;
                case Country.PalestineState:
                    serializer.Serialize(writer, "palestineState");
                    return;
                case Country.Panama:
                    serializer.Serialize(writer, "panama");
                    return;
                case Country.PapuaNewGuinea:
                    serializer.Serialize(writer, "papuaNewGuinea");
                    return;
                case Country.Paraguay:
                    serializer.Serialize(writer, "paraguay");
                    return;
                case Country.Peru:
                    serializer.Serialize(writer, "peru");
                    return;
                case Country.Philippines:
                    serializer.Serialize(writer, "philippines");
                    return;
                case Country.Pitcairn:
                    serializer.Serialize(writer, "pitcairn");
                    return;
                case Country.Poland:
                    serializer.Serialize(writer, "poland");
                    return;
                case Country.Portugal:
                    serializer.Serialize(writer, "portugal");
                    return;
                case Country.PuertoRico:
                    serializer.Serialize(writer, "puertoRico");
                    return;
                case Country.Qatar:
                    serializer.Serialize(writer, "qatar");
                    return;
                case Country.Reunion:
                    serializer.Serialize(writer, "reunion");
                    return;
                case Country.Romania:
                    serializer.Serialize(writer, "romania");
                    return;
                case Country.RussianFederation:
                    serializer.Serialize(writer, "russianFederation");
                    return;
                case Country.Rwanda:
                    serializer.Serialize(writer, "rwanda");
                    return;
                case Country.SaintBarthelemy:
                    serializer.Serialize(writer, "saintBarthelemy");
                    return;
                case Country.SaintHelena:
                    serializer.Serialize(writer, "saintHelena");
                    return;
                case Country.SaintKittsandNevis:
                    serializer.Serialize(writer, "saintKittsandNevis");
                    return;
                case Country.SaintLucia:
                    serializer.Serialize(writer, "saintLucia");
                    return;
                case Country.SaintMartinFrenchPart:
                    serializer.Serialize(writer, "saintMartinFrenchPart");
                    return;
                case Country.SaintPierreAndMiquelon:
                    serializer.Serialize(writer, "saintPierreAndMiquelon");
                    return;
                case Country.SaintVincentAndTheGrenadines:
                    serializer.Serialize(writer, "saintVincentAndTheGrenadines");
                    return;
                case Country.Samoa:
                    serializer.Serialize(writer, "samoa");
                    return;
                case Country.SanMarino:
                    serializer.Serialize(writer, "sanMarino");
                    return;
                case Country.SaoTomeAndPrincipe:
                    serializer.Serialize(writer, "saoTomeAndPrincipe");
                    return;
                case Country.SaudiArabia:
                    serializer.Serialize(writer, "saudiArabia");
                    return;
                case Country.Senegal:
                    serializer.Serialize(writer, "senegal");
                    return;
                case Country.Serbia:
                    serializer.Serialize(writer, "serbia");
                    return;
                case Country.Seychelles:
                    serializer.Serialize(writer, "seychelles");
                    return;
                case Country.SierraLeone:
                    serializer.Serialize(writer, "sierraLeone");
                    return;
                case Country.Singapore:
                    serializer.Serialize(writer, "singapore");
                    return;
                case Country.SintMaartenDutchPart:
                    serializer.Serialize(writer, "sintMaartenDutchPart");
                    return;
                case Country.Slovakia:
                    serializer.Serialize(writer, "slovakia");
                    return;
                case Country.Slovenia:
                    serializer.Serialize(writer, "slovenia");
                    return;
                case Country.SolomonIslands:
                    serializer.Serialize(writer, "solomonIslands");
                    return;
                case Country.Somalia:
                    serializer.Serialize(writer, "somalia");
                    return;
                case Country.SouthAfrica:
                    serializer.Serialize(writer, "southAfrica");
                    return;
                case Country.SouthGeorgiaAndTheSouthSandwichIslands:
                    serializer.Serialize(writer, "southGeorgiaAndTheSouthSandwichIslands");
                    return;
                case Country.SouthSudan:
                    serializer.Serialize(writer, "southSudan");
                    return;
                case Country.Spain:
                    serializer.Serialize(writer, "spain");
                    return;
                case Country.SriLanka:
                    serializer.Serialize(writer, "sriLanka");
                    return;
                case Country.Sudan:
                    serializer.Serialize(writer, "sudan");
                    return;
                case Country.Suriname:
                    serializer.Serialize(writer, "suriname");
                    return;
                case Country.Svalbard:
                    serializer.Serialize(writer, "svalbard");
                    return;
                case Country.Sweden:
                    serializer.Serialize(writer, "sweden");
                    return;
                case Country.Switzerland:
                    serializer.Serialize(writer, "switzerland");
                    return;
                case Country.SyrianArabRepublic:
                    serializer.Serialize(writer, "syrianArabRepublic");
                    return;
                case Country.TaiwanProvinceOfChina:
                    serializer.Serialize(writer, "taiwanProvinceOfChina");
                    return;
                case Country.Tajikistan:
                    serializer.Serialize(writer, "tajikistan");
                    return;
                case Country.TanzaniaTheUnitedRepublic:
                    serializer.Serialize(writer, "tanzaniaTheUnitedRepublic");
                    return;
                case Country.Thailand:
                    serializer.Serialize(writer, "thailand");
                    return;
                case Country.TimorLeste:
                    serializer.Serialize(writer, "timorLeste");
                    return;
                case Country.Togo:
                    serializer.Serialize(writer, "togo");
                    return;
                case Country.Tokelau:
                    serializer.Serialize(writer, "tokelau");
                    return;
                case Country.Tonga:
                    serializer.Serialize(writer, "tonga");
                    return;
                case Country.TrinidadAndTobago:
                    serializer.Serialize(writer, "trinidadAndTobago");
                    return;
                case Country.Tunisia:
                    serializer.Serialize(writer, "tunisia");
                    return;
                case Country.Turkey:
                    serializer.Serialize(writer, "turkey");
                    return;
                case Country.Turkmenistan:
                    serializer.Serialize(writer, "turkmenistan");
                    return;
                case Country.TurksAndCaicosIslands:
                    serializer.Serialize(writer, "turksAndCaicosIslands");
                    return;
                case Country.Tuvalu:
                    serializer.Serialize(writer, "tuvalu");
                    return;
                case Country.Uganda:
                    serializer.Serialize(writer, "uganda");
                    return;
                case Country.Ukraine:
                    serializer.Serialize(writer, "ukraine");
                    return;
                case Country.UnitedArabEmirates:
                    serializer.Serialize(writer, "unitedArabEmirates");
                    return;
                case Country.UnitedKingdom:
                    serializer.Serialize(writer, "unitedKingdom");
                    return;
                case Country.UnitedStatesMinorOutlyingIslands:
                    serializer.Serialize(writer, "unitedStatesMinorOutlyingIslands");
                    return;
                case Country.UnitedStatesOfAmerica:
                    serializer.Serialize(writer, "unitedStatesOfAmerica");
                    return;
                case Country.Uruguay:
                    serializer.Serialize(writer, "uruguay");
                    return;
                case Country.Uzbekistan:
                    serializer.Serialize(writer, "uzbekistan");
                    return;
                case Country.Vanuatu:
                    serializer.Serialize(writer, "vanuatu");
                    return;
                case Country.VenezuelaBolivarianRepublic:
                    serializer.Serialize(writer, "venezuelaBolivarianRepublic");
                    return;
                case Country.VietNam:
                    serializer.Serialize(writer, "vietNam");
                    return;
                case Country.VirginIslandsBritish:
                    serializer.Serialize(writer, "virginIslandsBritish");
                    return;
                case Country.VirginIslandsUS:
                    serializer.Serialize(writer, "virginIslandsUS");
                    return;
                case Country.WallisAndFutuna:
                    serializer.Serialize(writer, "wallisAndFutuna");
                    return;
                case Country.WesternSahara:
                    serializer.Serialize(writer, "westernSahara");
                    return;
                case Country.Yemen:
                    serializer.Serialize(writer, "yemen");
                    return;
                case Country.Zambia:
                    serializer.Serialize(writer, "zambia");
                    return;
                case Country.Zimbabwe:
                    serializer.Serialize(writer, "zimbabwe");
                    return;


            }

            throw new Exception("Cannot marshal type Country");
        }

        /// <summary>
        /// The singleton
        /// </summary>
        public static readonly CountryConverter Singleton = new CountryConverter();
    }
}