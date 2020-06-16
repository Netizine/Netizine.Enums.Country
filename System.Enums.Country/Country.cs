using System.ComponentModel;
using Newtonsoft.Json;

namespace System.Enums
{

    /// <summary>
    /// Country Enum using the data supplied at https://en.wikipedia.org/wiki/List_of_ISO_3166_country_codes
    /// </summary>
    public enum Country
    {
        /// <summary>
        /// The default when the country is not set
        /// </summary>
        [JsonProperty("notSet")]
        [Description("Not Set")]
        NotSet = 0,
        [JsonProperty("afghanistan")]
        [Description("The Islamic Republic of Afghanistan")]
        Afghanistan = 1,
        [JsonProperty("alandIslands")]
        [Description("Åland")]
        AlandIslands = 2,
        [JsonProperty("albania")]
        [Description("The Republic of Albania")]
        Albania = 3,
        [JsonProperty("algeria")]
        [Description("The People's Democratic Republic of Algeria")]
        Algeria = 4,
        [JsonProperty("americanSamoa")]
        [Description("The Territory of American Samoa")]
        AmericanSamoa = 5,
        [JsonProperty("andorra")]
        [Description("The Principality of Andorra")]
        Andorra = 6,
        [JsonProperty("angola")]
        [Description("The Republic of Angola")]
        Angola = 7,
        [JsonProperty("anguilla")]
        [Description("Anguilla")]
        Anguilla = 8,
        [JsonProperty("antarctica")]
        [Description("60th parallel south")]
        Antarctica = 9,
        [JsonProperty("antiguaAndBarbuda")]
        [Description("Antigua and Barbuda")]
        AntiguaAndBarbuda = 10,
        [JsonProperty("argentina")]
        [Description("The Argentine Republic")]
        Argentina = 11,
        [JsonProperty("armenia")]
        [Description("The Republic of Armenia")]
        Armenia = 12,
        [JsonProperty("aruba")]
        [Description("Aruba")]
        Aruba = 13,
        [JsonProperty("australia")]
        [Description("The Commonwealth of Australia")]
        Australia = 14,
        [JsonProperty("austria")]
        [Description("The Republic of Austria")]
        Austria = 15,
        [JsonProperty("azerbaijan")]
        [Description("The Republic of Azerbaijan")]
        Azerbaijan = 16,
        [JsonProperty("bahamas")]
        [Description("The Commonwealth of The Bahamas")]
        Bahamas = 17,
        [JsonProperty("bahrain")]
        [Description("The Kingdom of Bahrain")]
        Bahrain = 18,
        [JsonProperty("bangladesh")]
        [Description("The People's Republic of Bangladesh")]
        Bangladesh = 19,
        [JsonProperty("barbados")]
        [Description("Barbados")]
        Barbados = 20,
        [JsonProperty("belarus")]
        [Description("The Republic of Belarus")]
        Belarus = 21,
        [JsonProperty("belgium")]
        [Description("The Kingdom of Belgium")]
        Belgium = 22,
        [JsonProperty("belize")]
        [Description("Belize")]
        Belize = 23,
        [JsonProperty("benin")]
        [Description("The Republic of Benin")]
        Benin = 24,
        [JsonProperty("bermuda")]
        [Description("Bermuda")]
        Bermuda = 25,
        [JsonProperty("bhutan")]
        [Description("The Kingdom of Bhutan")]
        Bhutan = 26,
        [JsonProperty("boliviaPlurinationalState")]
        [Description("The Plurinational State of Bolivia")]
        BoliviaPlurinationalState = 27,
        [JsonProperty("bonaire")]
        [Description("Bonaire, Sint Eustatius and Saba")]
        Bonaire = 28,
        [JsonProperty("bosniaAndHerzegovina")]
        [Description("Bosnia and Herzegovina")]
        BosniaAndHerzegovina = 29,
        [JsonProperty("botswana")]
        [Description("The Republic of Botswana")]
        Botswana = 30,
        [JsonProperty("bouvetIsland")]
        [Description("Bouvet Island")]
        BouvetIsland = 31,
        [JsonProperty("brazil")]
        [Description("The Federative Republic of Brazil")]
        Brazil = 32,
        [JsonProperty("britishIndianOceanTerritory")]
        [Description("The British Indian Ocean Territory")]
        BritishIndianOceanTerritory = 33,
        [JsonProperty("bruneiDarussalam")]
        [Description("The Nation of Brunei, the Abode of Peace")]
        BruneiDarussalam = 34,
        [JsonProperty("bulgaria")]
        [Description("The Republic of Bulgaria")]
        Bulgaria = 35,
        [JsonProperty("burkinaFaso")]
        [Description("Burkina Faso")]
        BurkinaFaso = 36,
        [JsonProperty("burundi")]
        [Description("The Republic of Burundi")]
        Burundi = 37,
        [JsonProperty("caboVerde")]
        [Description("The Republic of Cabo Verde")]
        CaboVerde = 38,
        [JsonProperty("cambodia")]
        [Description("The Kingdom of Cambodia")]
        Cambodia = 39,
        [JsonProperty("cameroon")]
        [Description("The Republic of Cameroon")]
        Cameroon = 40,
        [JsonProperty("canada")]
        [Description("Canada")]
        Canada = 41,
        [JsonProperty("caymanIslands")]
        [Description("The Cayman Islands")]
        CaymanIslands = 42,
        [JsonProperty("centralAfricanRepublic")]
        [Description("The Central African Republic")]
        CentralAfricanRepublic = 43,
        [JsonProperty("chad")]
        [Description("The Republic of Chad")]
        Chad = 44,
        [JsonProperty("chile")]
        [Description("The Republic of Chile")]
        Chile = 45,
        [JsonProperty("china")]
        [Description("The People's Republic of China")]
        China = 46,
        [JsonProperty("christmasIsland")]
        [Description("The Territory of Christmas Island")]
        ChristmasIsland = 47,
        [JsonProperty("cocosKeelingIslands")]
        [Description("The Territory of Cocos (Keeling) Islands")]
        CocosKeelingIslands = 48,
        [JsonProperty("colombia")]
        [Description("The Republic of Colombia")]
        Colombia = 49,
        [JsonProperty("comoros")]
        [Description("The Union of the Comoros")]
        Comoros = 50,
        [JsonProperty("congoTheDemocraticRepublic")]
        [Description("The Democratic Republic of the Congo")]
        CongoTheDemocraticRepublic = 51,
        [JsonProperty("congo")]
        [Description("The Republic of the Congo")]
        Congo = 52,
        [JsonProperty("cookIslands")]
        [Description("The Cook Islands")]
        CookIslands = 53,
        [JsonProperty("costaRica")]
        [Description("The Republic of Costa Rica")]
        CostaRica = 54,
        [JsonProperty("cotedIvoire")]
        [Description("The Republic of Côte d'Ivoire")]
        CotedIvoire = 55,
        [JsonProperty("croatia")]
        [Description("The Republic of Croatia")]
        Croatia = 56,
        [JsonProperty("cuba")]
        [Description("The Republic of Cuba")]
        Cuba = 57,
        [JsonProperty("curacao")]
        [Description("The Country of Curaçao")]
        Curacao = 58,
        [JsonProperty("cyprus")]
        [Description("The Republic of Cyprus")]
        Cyprus = 59,
        [JsonProperty("czechia")]
        [Description("The Czech Republic")]
        Czechia = 60,
        [JsonProperty("denmark")]
        [Description("The Kingdom of Denmark")]
        Denmark = 61,
        [JsonProperty("djibouti")]
        [Description("The Republic of Djibouti")]
        Djibouti = 62,
        [JsonProperty("dominica")]
        [Description("The Commonwealth of Dominica")]
        Dominica = 63,
        [JsonProperty("dominicanRepublic")]
        [Description("The Dominican Republic")]
        DominicanRepublic = 64,
        [JsonProperty("ecuador")]
        [Description("The Republic of Ecuador")]
        Ecuador = 65,
        [JsonProperty("egypt")]
        [Description("The Arab Republic of Egypt")]
        Egypt = 66,
        [JsonProperty("elSalvador")]
        [Description("The Republic of El Salvador")]
        ElSalvador = 67,
        [JsonProperty("equatorialGuinea")]
        [Description("The Republic of Equatorial Guinea")]
        EquatorialGuinea = 68,
        [JsonProperty("eritrea")]
        [Description("The State of Eritrea")]
        Eritrea = 69,
        [JsonProperty("estonia")]
        [Description("The Republic of Estonia")]
        Estonia = 70,
        [JsonProperty("eswatini")]
        [Description("The Kingdom of Eswatini")]
        Eswatini = 71,
        [JsonProperty("ethiopia")]
        [Description("The Federal Democratic Republic of Ethiopia")]
        Ethiopia = 72,
        [JsonProperty("falklandIslandsTheMalvinas")]
        [Description("The Falkland Islands")]
        FalklandIslandsTheMalvinas = 73,
        [JsonProperty("faroeIslands")]
        [Description("The Faroe Islands")]
        FaroeIslands = 74,
        [JsonProperty("fiji")]
        [Description("The Republic of Fiji")]
        Fiji = 75,
        [JsonProperty("finland")]
        [Description("The Republic of Finland")]
        Finland = 76,
        [JsonProperty("france")]
        [Description("The French Republic")]
        France = 77,
        [JsonProperty("frenchGuiana")]
        [Description("Guyane")]
        FrenchGuiana = 78,
        [JsonProperty("frenchPolynesia")]
        [Description("French Polynesia")]
        FrenchPolynesia = 79,
        [JsonProperty("frenchSouthernTerritories")]
        [Description("The French Southern and Antarctic Lands")]
        FrenchSouthernTerritories = 80,
        [JsonProperty("gabon")]
        [Description("The Gabonese Republic")]
        Gabon = 81,
        [JsonProperty("gambia")]
        [Description("The Republic of The Gambia")]
        Gambia = 82,
        [JsonProperty("georgia")]
        [Description("Georgia")]
        Georgia = 83,
        [JsonProperty("germany")]
        [Description("The Federal Republic of Germany")]
        Germany = 84,
        [JsonProperty("ghana")]
        [Description("The Republic of Ghana")]
        Ghana = 85,
        [JsonProperty("gibraltar")]
        [Description("Gibraltar")]
        Gibraltar = 86,
        [JsonProperty("greece")]
        [Description("The Hellenic Republic")]
        Greece = 87,
        [JsonProperty("greenland")]
        [Description("Kalaallit Nunaat")]
        Greenland = 88,
        [JsonProperty("grenada")]
        [Description("Grenada")]
        Grenada = 89,
        [JsonProperty("guadeloupe")]
        [Description("Guadeloupe")]
        Guadeloupe = 90,
        [JsonProperty("guam")]
        [Description("The Territory of Guam")]
        Guam = 91,
        [JsonProperty("guatemala")]
        [Description("The Republic of Guatemala")]
        Guatemala = 92,
        [JsonProperty("guernsey")]
        [Description("The Bailiwick of Guernsey")]
        Guernsey = 93,
        [JsonProperty("guinea")]
        [Description("The Republic of Guinea")]
        Guinea = 94,
        [JsonProperty("guineaBissau")]
        [Description("The Republic of Guinea-Bissau")]
        GuineaBissau = 95,
        [JsonProperty("guyana")]
        [Description("The Co-operative Republic of Guyana")]
        Guyana = 96,
        [JsonProperty("haiti")]
        [Description("The Republic of Haiti")]
        Haiti = 97,
        [JsonProperty("heardIslandAndMcDonaldIslands")]
        [Description("The Territory of Heard Island and McDonald Islands")]
        HeardIslandAndMcDonaldIslands = 98,
        [JsonProperty("holySee")]
        [Description("The Holy See")]
        HolySee = 99,
        [JsonProperty("honduras")]
        [Description("The Republic of Honduras")]
        Honduras = 100,
        [JsonProperty("hongKong")]
        [Description("The Hong Kong Special Administrative Region of China")]
        HongKong = 101,
        [JsonProperty("hungary")]
        [Description("Hungary")]
        Hungary = 102,
        [JsonProperty("iceland")]
        [Description("Iceland")]
        Iceland = 103,
        [JsonProperty("india")]
        [Description("The Republic of India")]
        India = 104,
        [JsonProperty("indonesia")]
        [Description("The Republic of Indonesia")]
        Indonesia = 105,
        [JsonProperty("iranIslamicRepublic")]
        [Description("The Islamic Republic of Iran")]
        IranIslamicRepublic = 106,
        [JsonProperty("iraq")]
        [Description("The Republic of Iraq")]
        Iraq = 107,
        [JsonProperty("ireland")]
        [Description("Ireland")]
        Ireland = 108,
        [JsonProperty("isleOfMan")]
        [Description("The Isle of Man")]
        IsleOfMan = 109,
        [JsonProperty("israel")]
        [Description("The State of Israel")]
        Israel = 110,
        [JsonProperty("italy")]
        [Description("The Italian Republic")]
        Italy = 111,
        [JsonProperty("jamaica")]
        [Description("Jamaica")]
        Jamaica = 112,
        [JsonProperty("japan")]
        [Description("Japan")]
        Japan = 113,
        [JsonProperty("jersey")]
        [Description("The Bailiwick of Jersey")]
        Jersey = 114,
        [JsonProperty("jordan")]
        [Description("The Hashemite Kingdom of Jordan")]
        Jordan = 115,
        [JsonProperty("kazakhstan")]
        [Description("The Republic of Kazakhstan")]
        Kazakhstan = 116,
        [JsonProperty("kenya")]
        [Description("The Republic of Kenya")]
        Kenya = 117,
        [JsonProperty("kiribati")]
        [Description("The Republic of Kiribati")]
        Kiribati = 118,
        [JsonProperty("koreaTheDemocraticPeoplesRepublic")]
        [Description("The Democratic People's Republic of Korea")]
        KoreaTheDemocraticPeoplesRepublic = 119,
        [JsonProperty("koreaTheRepublic")]
        [Description("The Republic of Korea")]
        KoreaTheRepublic = 120,
        [JsonProperty("kuwait")]
        [Description("The State of Kuwait")]
        Kuwait = 121,
        [JsonProperty("kyrgyzstan")]
        [Description("The Kyrgyz Republic")]
        Kyrgyzstan = 122,
        [JsonProperty("laoPeoplesDemocraticRepublic")]
        [Description("The Lao People's Democratic Republic")]
        LaoPeoplesDemocraticRepublic = 123,
        [JsonProperty("latvia")]
        [Description("The Republic of Latvia")]
        Latvia = 124,
        [JsonProperty("lebanon")]
        [Description("The Lebanese Republic")]
        Lebanon = 125,
        [JsonProperty("lesotho")]
        [Description("The Kingdom of Lesotho")]
        Lesotho = 126,
        [JsonProperty("liberia")]
        [Description("The Republic of Liberia")]
        Liberia = 127,
        [JsonProperty("libya")]
        [Description("The State of Libya")]
        Libya = 128,
        [JsonProperty("liechtenstein")]
        [Description("The Principality of Liechtenstein")]
        Liechtenstein = 129,
        [JsonProperty("lithuania")]
        [Description("The Republic of Lithuania")]
        Lithuania = 130,
        [JsonProperty("luxembourg")]
        [Description("The Grand Duchy of Luxembourg")]
        Luxembourg = 131,
        [JsonProperty("macao")]
        [Description("Macao Special Administrative Region of China")]
        Macao = 132,
        [JsonProperty("northMacedonia")]
        [Description("Republic of North Macedonia")]
        NorthMacedonia = 133,
        [JsonProperty("madagascar")]
        [Description("The Republic of Madagascar")]
        Madagascar = 134,
        [JsonProperty("malawi")]
        [Description("The Republic of Malawi")]
        Malawi = 135,
        [JsonProperty("malaysia")]
        [Description("Malaysia")]
        Malaysia = 136,
        [JsonProperty("maldives")]
        [Description("The Republic of Maldives")]
        Maldives = 137,
        [JsonProperty("mali")]
        [Description("The Republic of Mali")]
        Mali = 138,
        [JsonProperty("malta")]
        [Description("The Republic of Malta")]
        Malta = 139,
        [JsonProperty("marshallIslands")]
        [Description("The Republic of the Marshall Islands")]
        MarshallIslands = 140,
        [JsonProperty("martinique")]
        [Description("Martinique")]
        Martinique = 141,
        [JsonProperty("mauritania")]
        [Description("The Islamic Republic of Mauritania")]
        Mauritania = 142,
        [JsonProperty("mauritius")]
        [Description("The Republic of Mauritius")]
        Mauritius = 143,
        [JsonProperty("mayotte")]
        [Description("The Department of Mayotte")]
        Mayotte = 144,
        [JsonProperty("mexico")]
        [Description("The United Mexican States")]
        Mexico = 145,
        [JsonProperty("micronesiaFederatedStates")]
        [Description("The Federated States of Micronesia")]
        MicronesiaFederatedStates = 146,
        [JsonProperty("moldovaTheRepublic")]
        [Description("The Republic of Moldova")]
        MoldovaTheRepublic = 147,
        [JsonProperty("monaco")]
        [Description("The Principality of Monaco")]
        Monaco = 148,
        [JsonProperty("mongolia")]
        [Description("The State of Mongolia")]
        Mongolia = 149,
        [JsonProperty("montenegro")]
        [Description("Montenegro")]
        Montenegro = 150,
        [JsonProperty("montserrat")]
        [Description("Montserrat")]
        Montserrat = 151,
        [JsonProperty("morocco")]
        [Description("The Kingdom of Morocco")]
        Morocco = 152,
        [JsonProperty("mozambique")]
        [Description("The Republic of Mozambique")]
        Mozambique = 153,
        [JsonProperty("myanmar")]
        [Description("The Republic of the Union of Myanmar")]
        Myanmar = 154,
        [JsonProperty("namibia")]
        [Description("The Republic of Namibia")]
        Namibia = 155,
        [JsonProperty("nauru")]
        [Description("The Republic of Nauru")]
        Nauru = 156,
        [JsonProperty("nepal")]
        [Description("The Federal Democratic Republic of Nepal")]
        Nepal = 157,
        [JsonProperty("netherlands")]
        [Description("The Kingdom of the Netherlands")]
        Netherlands = 158,
        [JsonProperty("newCaledonia")]
        [Description("New Caledonia")]
        NewCaledonia = 159,
        [JsonProperty("newZealand")]
        [Description("New Zealand")]
        NewZealand = 160,
        [JsonProperty("nicaragua")]
        [Description("The Republic of Nicaragua")]
        Nicaragua = 161,
        [JsonProperty("niger")]
        [Description("The Republic of the Niger")]
        Niger = 162,
        [JsonProperty("nigeria")]
        [Description("The Federal Republic of Nigeria")]
        Nigeria = 163,
        [JsonProperty("niue")]
        [Description("Niue")]
        Niue = 164,
        [JsonProperty("norfolkIsland")]
        [Description("The Territory of Norfolk Island")]
        NorfolkIsland = 165,
        [JsonProperty("northernMarianaIslands")]
        [Description("The Commonwealth of the Northern Mariana Islands")]
        NorthernMarianaIslands = 166,
        [JsonProperty("norway")]
        [Description("The Kingdom of Norway")]
        Norway = 167,
        [JsonProperty("oman")]
        [Description("The Sultanate of Oman")]
        Oman = 168,
        [JsonProperty("pakistan")]
        [Description("The Islamic Republic of Pakistan")]
        Pakistan = 169,
        [JsonProperty("palau")]
        [Description("The Republic of Palau")]
        Palau = 170,
        [JsonProperty("palestineState")]
        [Description("The State of Palestine")]
        PalestineState = 171,
        [JsonProperty("panama")]
        [Description("The Republic of Panamá")]
        Panama = 172,
        [JsonProperty("papuaNewGuinea")]
        [Description("The Independent State of Papua New Guinea")]
        PapuaNewGuinea = 173,
        [JsonProperty("paraguay")]
        [Description("The Republic of Paraguay")]
        Paraguay = 174,
        [JsonProperty("peru")]
        [Description("The Republic of Perú")]
        Peru = 175,
        [JsonProperty("philippines")]
        [Description("The Republic of the Philippines")]
        Philippines = 176,
        [JsonProperty("pitcairn")]
        [Description("The Pitcairn, Henderson, Ducie and Oeno Islands")]
        Pitcairn = 177,
        [JsonProperty("poland")]
        [Description("The Republic of Poland")]
        Poland = 178,
        [JsonProperty("portugal")]
        [Description("The Portuguese Republic")]
        Portugal = 179,
        [JsonProperty("puertoRico")]
        [Description("The Commonwealth of Puerto Rico")]
        PuertoRico = 180,
        [JsonProperty("qatar")]
        [Description("The State of Qatar")]
        Qatar = 181,
        [JsonProperty("reunion")]
        [Description("Réunion")]
        Reunion = 182,
        [JsonProperty("romania")]
        [Description("Romania")]
        Romania = 183,
        [JsonProperty("russianFederation")]
        [Description("The Russian Federation")]
        RussianFederation = 184,
        [JsonProperty("rwanda")]
        [Description("The Republic of Rwanda")]
        Rwanda = 185,
        [JsonProperty("saintBarthelemy")]
        [Description("The Collectivity of Saint-Barthélemy")]
        SaintBarthelemy = 186,
        [JsonProperty("saintHelena")]
        [Description("Saint Helena, Ascension and Tristan da Cunha")]
        SaintHelena = 187,
        [JsonProperty("saintKittsandNevis")]
        [Description("Saint Kitts and Nevis")]
        SaintKittsandNevis = 188,
        [JsonProperty("saintLucia")]
        [Description("Saint Lucia")]
        SaintLucia = 189,
        [JsonProperty("saintMartinFrenchPart")]
        [Description("The Collectivity of Saint-Martin")]
        SaintMartinFrenchPart = 190,
        [JsonProperty("saintPierreAndMiquelon")]
        [Description("The Overseas Collectivity of Saint-Pierre and Miquelon")]
        SaintPierreAndMiquelon = 191,
        [JsonProperty("saintVincentAndTheGrenadines")]
        [Description("Saint Vincent and the Grenadines")]
        SaintVincentAndTheGrenadines = 192,
        [JsonProperty("samoa")]
        [Description("The Independent State of Samoa")]
        Samoa = 193,
        [JsonProperty("sanMarino")]
        [Description("The Republic of San Marino")]
        SanMarino = 194,
        [JsonProperty("saoTomeAndPrincipe")]
        [Description("The Democratic Republic of São Tomé and Príncipe")]
        SaoTomeAndPrincipe = 195,
        [JsonProperty("saudiArabia")]
        [Description("The Kingdom of Saudi Arabia")]
        SaudiArabia = 196,
        [JsonProperty("senegal")]
        [Description("The Republic of Senegal")]
        Senegal = 197,
        [JsonProperty("serbia")]
        [Description("The Republic of Serbia")]
        Serbia = 198,
        [JsonProperty("seychelles")]
        [Description("The Republic of Seychelles")]
        Seychelles = 199,
        [JsonProperty("sierraLeone")]
        [Description("The Republic of Sierra Leone")]
        SierraLeone = 200,
        [JsonProperty("singapore")]
        [Description("The Republic of Singapore")]
        Singapore = 201,
        [JsonProperty("sintMaartenDutchPart")]
        [Description("Sint Maarten")]
        SintMaartenDutchPart = 202,
        [JsonProperty("slovakia")]
        [Description("The Slovak Republic")]
        Slovakia = 203,
        [JsonProperty("slovenia")]
        [Description("The Republic of Slovenia")]
        Slovenia = 204,
        [JsonProperty("solomonIslands")]
        [Description("The Solomon Islands")]
        SolomonIslands = 205,
        [JsonProperty("somalia")]
        [Description("The Federal Republic of Somalia")]
        Somalia = 206,
        [JsonProperty("southAfrica")]
        [Description("The Republic of South Africa")]
        SouthAfrica = 207,
        [JsonProperty("southGeorgiaAndTheSouthSandwichIslands")]
        [Description("South Georgia and the South Sandwich Islands")]
        SouthGeorgiaAndTheSouthSandwichIslands = 208,
        [JsonProperty("southSudan")]
        [Description("The Republic of South Sudan")]
        SouthSudan = 209,
        [JsonProperty("spain")]
        [Description("The Kingdom of Spain")]
        Spain = 210,
        [JsonProperty("sriLanka")]
        [Description("The Democratic Socialist Republic of Sri Lanka")]
        SriLanka = 211,
        [JsonProperty("sudan")]
        [Description("The Republic of the Sudan")]
        Sudan = 212,
        [JsonProperty("suriname")]
        [Description("The Republic of Suriname")]
        Suriname = 213,
        [JsonProperty("svalbard")]
        [Description("Svalbard and Jan Mayen")]
        Svalbard = 214,
        [JsonProperty("sweden")]
        [Description("The Kingdom of Sweden")]
        Sweden = 215,
        [JsonProperty("switzerland")]
        [Description("The Swiss Confederation")]
        Switzerland = 216,
        [JsonProperty("syrianArabRepublic")]
        [Description("The Syrian Arab Republic")]
        SyrianArabRepublic = 217,
        [JsonProperty("taiwanProvinceOfChina")]
        [Description("The Republic of China")]
        TaiwanProvinceOfChina = 218,
        [JsonProperty("tajikistan")]
        [Description("The Republic of Tajikistan")]
        Tajikistan = 219,
        [JsonProperty("tanzaniaTheUnitedRepublic")]
        [Description("The United Republic of Tanzania")]
        TanzaniaTheUnitedRepublic = 220,
        [JsonProperty("thailand")]
        [Description("The Kingdom of Thailand")]
        Thailand = 221,
        [JsonProperty("timorLeste")]
        [Description("The Democratic Republic of Timor-Leste")]
        TimorLeste = 222,
        [JsonProperty("togo")]
        [Description("The Togolese Republic")]
        Togo = 223,
        [JsonProperty("tokelau")]
        [Description("Tokelau")]
        Tokelau = 224,
        [JsonProperty("tonga")]
        [Description("The Kingdom of Tonga")]
        Tonga = 225,
        [JsonProperty("trinidadAndTobago")]
        [Description("The Republic of Trinidad and Tobago")]
        TrinidadAndTobago = 226,
        [JsonProperty("tunisia")]
        [Description("The Republic of Tunisia")]
        Tunisia = 227,
        [JsonProperty("turkey")]
        [Description("The Republic of Turkey")]
        Turkey = 228,
        [JsonProperty("turkmenistan")]
        [Description("Turkmenistan")]
        Turkmenistan = 229,
        [JsonProperty("turksAndCaicosIslands")]
        [Description("The Turks and Caicos Islands")]
        TurksAndCaicosIslands = 230,
        [JsonProperty("tuvalu")]
        [Description("Tuvalu")]
        Tuvalu = 231,
        [JsonProperty("uganda")]
        [Description("The Republic of Uganda")]
        Uganda = 232,
        [JsonProperty("ukraine")]
        [Description("Ukraine")]
        Ukraine = 233,
        [JsonProperty("unitedArabEmirates")]
        [Description("The United Arab Emirates")]
        UnitedArabEmirates = 234,
        [JsonProperty("unitedKingdom")]
        [Description("The United Kingdom of Great Britain and Northern Ireland")]
        UnitedKingdom = 235,
        [JsonProperty("unitedStatesMinorOutlyingIslands")]
        [Description("Baker Island")]
        UnitedStatesMinorOutlyingIslands = 236,
        [JsonProperty("unitedStatesOfAmerica")]
        [Description("The United States of America")]
        UnitedStatesOfAmerica = 237,
        [JsonProperty("uruguay")]
        [Description("The Oriental Republic of Uruguay")]
        Uruguay = 238,
        [JsonProperty("uzbekistan")]
        [Description("The Republic of Uzbekistan")]
        Uzbekistan = 239,
        [JsonProperty("vanuatu")]
        [Description("The Republic of Vanuatu")]
        Vanuatu = 240,
        [JsonProperty("venezuelaBolivarianRepublic")]
        [Description("The Bolivarian Republic of Venezuela")]
        VenezuelaBolivarianRepublic = 241,
        [JsonProperty("vietNam")]
        [Description("The Socialist Republic of Viet Nam")]
        VietNam = 242,
        [JsonProperty("virginIslandsBritish")]
        [Description("The Virgin Islands")]
        VirginIslandsBritish = 243,
        [JsonProperty("virginIslandsUS")]
        [Description("The Virgin Islands of the United States")]
        VirginIslandsUS = 244,
        [JsonProperty("wallisAndFutuna")]
        [Description("The Territory of the Wallis and Futuna Islands")]
        WallisAndFutuna = 245,
        [JsonProperty("westernSahara")]
        [Description("The Sahrawi Arab Democratic Republic")]
        WesternSahara = 246,
        [JsonProperty("yemen")]
        [Description("The Republic of Yemen")]
        Yemen = 247,
        [JsonProperty("zambia")]
        [Description("The Republic of Zambia")]
        Zambia = 248,
        [JsonProperty("zimbabwe")]
        [Description("The Republic of Zimbabwe")]
        Zimbabwe = 249,
    }
}
