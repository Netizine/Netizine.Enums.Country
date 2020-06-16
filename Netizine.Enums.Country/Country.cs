using System.ComponentModel;
using System.Runtime.Serialization;
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
        [EnumMember(Value = "notSet")]
        [Description("Not Set")]
        NotSet = 0,
        [EnumMember(Value = "afghanistan")]
        [Description("The Islamic Republic of Afghanistan")]
        Afghanistan = 1,
        [EnumMember(Value = "alandIslands")]
        [Description("Åland")]
        AlandIslands = 2,
        [EnumMember(Value = "albania")]
        [Description("The Republic of Albania")]
        Albania = 3,
        [EnumMember(Value = "algeria")]
        [Description("The People's Democratic Republic of Algeria")]
        Algeria = 4,
        [EnumMember(Value = "americanSamoa")]
        [Description("The Territory of American Samoa")]
        AmericanSamoa = 5,
        [EnumMember(Value = "andorra")]
        [Description("The Principality of Andorra")]
        Andorra = 6,
        [EnumMember(Value = "angola")]
        [Description("The Republic of Angola")]
        Angola = 7,
        [EnumMember(Value = "anguilla")]
        [Description("Anguilla")]
        Anguilla = 8,
        [EnumMember(Value = "antarctica")]
        [Description("60th parallel south")]
        Antarctica = 9,
        [EnumMember(Value = "antiguaAndBarbuda")]
        [Description("Antigua and Barbuda")]
        AntiguaAndBarbuda = 10,
        [EnumMember(Value = "argentina")]
        [Description("The Argentine Republic")]
        Argentina = 11,
        [EnumMember(Value = "armenia")]
        [Description("The Republic of Armenia")]
        Armenia = 12,
        [EnumMember(Value = "aruba")]
        [Description("Aruba")]
        Aruba = 13,
        [EnumMember(Value = "australia")]
        [Description("The Commonwealth of Australia")]
        Australia = 14,
        [EnumMember(Value = "austria")]
        [Description("The Republic of Austria")]
        Austria = 15,
        [EnumMember(Value = "azerbaijan")]
        [Description("The Republic of Azerbaijan")]
        Azerbaijan = 16,
        [EnumMember(Value = "bahamas")]
        [Description("The Commonwealth of The Bahamas")]
        Bahamas = 17,
        [EnumMember(Value = "bahrain")]
        [Description("The Kingdom of Bahrain")]
        Bahrain = 18,
        [EnumMember(Value = "bangladesh")]
        [Description("The People's Republic of Bangladesh")]
        Bangladesh = 19,
        [EnumMember(Value = "barbados")]
        [Description("Barbados")]
        Barbados = 20,
        [EnumMember(Value = "belarus")]
        [Description("The Republic of Belarus")]
        Belarus = 21,
        [EnumMember(Value = "belgium")]
        [Description("The Kingdom of Belgium")]
        Belgium = 22,
        [EnumMember(Value = "belize")]
        [Description("Belize")]
        Belize = 23,
        [EnumMember(Value = "benin")]
        [Description("The Republic of Benin")]
        Benin = 24,
        [EnumMember(Value = "bermuda")]
        [Description("Bermuda")]
        Bermuda = 25,
        [EnumMember(Value = "bhutan")]
        [Description("The Kingdom of Bhutan")]
        Bhutan = 26,
        [EnumMember(Value = "boliviaPlurinationalState")]
        [Description("The Plurinational State of Bolivia")]
        BoliviaPlurinationalState = 27,
        [EnumMember(Value = "bonaire")]
        [Description("Bonaire, Sint Eustatius and Saba")]
        Bonaire = 28,
        [EnumMember(Value = "bosniaAndHerzegovina")]
        [Description("Bosnia and Herzegovina")]
        BosniaAndHerzegovina = 29,
        [EnumMember(Value = "botswana")]
        [Description("The Republic of Botswana")]
        Botswana = 30,
        [EnumMember(Value = "bouvetIsland")]
        [Description("Bouvet Island")]
        BouvetIsland = 31,
        [EnumMember(Value = "brazil")]
        [Description("The Federative Republic of Brazil")]
        Brazil = 32,
        [EnumMember(Value = "britishIndianOceanTerritory")]
        [Description("The British Indian Ocean Territory")]
        BritishIndianOceanTerritory = 33,
        [EnumMember(Value = "bruneiDarussalam")]
        [Description("The Nation of Brunei, the Abode of Peace")]
        BruneiDarussalam = 34,
        [EnumMember(Value = "bulgaria")]
        [Description("The Republic of Bulgaria")]
        Bulgaria = 35,
        [EnumMember(Value = "burkinaFaso")]
        [Description("Burkina Faso")]
        BurkinaFaso = 36,
        [EnumMember(Value = "burundi")]
        [Description("The Republic of Burundi")]
        Burundi = 37,
        [EnumMember(Value = "caboVerde")]
        [Description("The Republic of Cabo Verde")]
        CaboVerde = 38,
        [EnumMember(Value = "cambodia")]
        [Description("The Kingdom of Cambodia")]
        Cambodia = 39,
        [EnumMember(Value = "cameroon")]
        [Description("The Republic of Cameroon")]
        Cameroon = 40,
        [EnumMember(Value = "canada")]
        [Description("Canada")]
        Canada = 41,
        [EnumMember(Value = "caymanIslands")]
        [Description("The Cayman Islands")]
        CaymanIslands = 42,
        [EnumMember(Value = "centralAfricanRepublic")]
        [Description("The Central African Republic")]
        CentralAfricanRepublic = 43,
        [EnumMember(Value = "chad")]
        [Description("The Republic of Chad")]
        Chad = 44,
        [EnumMember(Value = "chile")]
        [Description("The Republic of Chile")]
        Chile = 45,
        [EnumMember(Value = "china")]
        [Description("The People's Republic of China")]
        China = 46,
        [EnumMember(Value = "christmasIsland")]
        [Description("The Territory of Christmas Island")]
        ChristmasIsland = 47,
        [EnumMember(Value = "cocosKeelingIslands")]
        [Description("The Territory of Cocos (Keeling) Islands")]
        CocosKeelingIslands = 48,
        [EnumMember(Value = "colombia")]
        [Description("The Republic of Colombia")]
        Colombia = 49,
        [EnumMember(Value = "comoros")]
        [Description("The Union of the Comoros")]
        Comoros = 50,
        [EnumMember(Value = "congoTheDemocraticRepublic")]
        [Description("The Democratic Republic of the Congo")]
        CongoTheDemocraticRepublic = 51,
        [EnumMember(Value = "congo")]
        [Description("The Republic of the Congo")]
        Congo = 52,
        [EnumMember(Value = "cookIslands")]
        [Description("The Cook Islands")]
        CookIslands = 53,
        [EnumMember(Value = "costaRica")]
        [Description("The Republic of Costa Rica")]
        CostaRica = 54,
        [EnumMember(Value = "cotedIvoire")]
        [Description("The Republic of Côte d'Ivoire")]
        CotedIvoire = 55,
        [EnumMember(Value = "croatia")]
        [Description("The Republic of Croatia")]
        Croatia = 56,
        [EnumMember(Value = "cuba")]
        [Description("The Republic of Cuba")]
        Cuba = 57,
        [EnumMember(Value = "curacao")]
        [Description("The Country of Curaçao")]
        Curacao = 58,
        [EnumMember(Value = "cyprus")]
        [Description("The Republic of Cyprus")]
        Cyprus = 59,
        [EnumMember(Value = "czechia")]
        [Description("The Czech Republic")]
        Czechia = 60,
        [EnumMember(Value = "denmark")]
        [Description("The Kingdom of Denmark")]
        Denmark = 61,
        [EnumMember(Value = "djibouti")]
        [Description("The Republic of Djibouti")]
        Djibouti = 62,
        [EnumMember(Value = "dominica")]
        [Description("The Commonwealth of Dominica")]
        Dominica = 63,
        [EnumMember(Value = "dominicanRepublic")]
        [Description("The Dominican Republic")]
        DominicanRepublic = 64,
        [EnumMember(Value = "ecuador")]
        [Description("The Republic of Ecuador")]
        Ecuador = 65,
        [EnumMember(Value = "egypt")]
        [Description("The Arab Republic of Egypt")]
        Egypt = 66,
        [EnumMember(Value = "elSalvador")]
        [Description("The Republic of El Salvador")]
        ElSalvador = 67,
        [EnumMember(Value = "equatorialGuinea")]
        [Description("The Republic of Equatorial Guinea")]
        EquatorialGuinea = 68,
        [EnumMember(Value = "eritrea")]
        [Description("The State of Eritrea")]
        Eritrea = 69,
        [EnumMember(Value = "estonia")]
        [Description("The Republic of Estonia")]
        Estonia = 70,
        [EnumMember(Value = "eswatini")]
        [Description("The Kingdom of Eswatini")]
        Eswatini = 71,
        [EnumMember(Value = "ethiopia")]
        [Description("The Federal Democratic Republic of Ethiopia")]
        Ethiopia = 72,
        [EnumMember(Value = "falklandIslandsTheMalvinas")]
        [Description("The Falkland Islands")]
        FalklandIslandsTheMalvinas = 73,
        [EnumMember(Value = "faroeIslands")]
        [Description("The Faroe Islands")]
        FaroeIslands = 74,
        [EnumMember(Value = "fiji")]
        [Description("The Republic of Fiji")]
        Fiji = 75,
        [EnumMember(Value = "finland")]
        [Description("The Republic of Finland")]
        Finland = 76,
        [EnumMember(Value = "france")]
        [Description("The French Republic")]
        France = 77,
        [EnumMember(Value = "frenchGuiana")]
        [Description("Guyane")]
        FrenchGuiana = 78,
        [EnumMember(Value = "frenchPolynesia")]
        [Description("French Polynesia")]
        FrenchPolynesia = 79,
        [EnumMember(Value = "frenchSouthernTerritories")]
        [Description("The French Southern and Antarctic Lands")]
        FrenchSouthernTerritories = 80,
        [EnumMember(Value = "gabon")]
        [Description("The Gabonese Republic")]
        Gabon = 81,
        [EnumMember(Value = "gambia")]
        [Description("The Republic of The Gambia")]
        Gambia = 82,
        [EnumMember(Value = "georgia")]
        [Description("Georgia")]
        Georgia = 83,
        [EnumMember(Value = "germany")]
        [Description("The Federal Republic of Germany")]
        Germany = 84,
        [EnumMember(Value = "ghana")]
        [Description("The Republic of Ghana")]
        Ghana = 85,
        [EnumMember(Value = "gibraltar")]
        [Description("Gibraltar")]
        Gibraltar = 86,
        [EnumMember(Value = "greece")]
        [Description("The Hellenic Republic")]
        Greece = 87,
        [EnumMember(Value = "greenland")]
        [Description("Kalaallit Nunaat")]
        Greenland = 88,
        [EnumMember(Value = "grenada")]
        [Description("Grenada")]
        Grenada = 89,
        [EnumMember(Value = "guadeloupe")]
        [Description("Guadeloupe")]
        Guadeloupe = 90,
        [EnumMember(Value = "guam")]
        [Description("The Territory of Guam")]
        Guam = 91,
        [EnumMember(Value = "guatemala")]
        [Description("The Republic of Guatemala")]
        Guatemala = 92,
        [EnumMember(Value = "guernsey")]
        [Description("The Bailiwick of Guernsey")]
        Guernsey = 93,
        [EnumMember(Value = "guinea")]
        [Description("The Republic of Guinea")]
        Guinea = 94,
        [EnumMember(Value = "guineaBissau")]
        [Description("The Republic of Guinea-Bissau")]
        GuineaBissau = 95,
        [EnumMember(Value = "guyana")]
        [Description("The Co-operative Republic of Guyana")]
        Guyana = 96,
        [EnumMember(Value = "haiti")]
        [Description("The Republic of Haiti")]
        Haiti = 97,
        [EnumMember(Value = "heardIslandAndMcDonaldIslands")]
        [Description("The Territory of Heard Island and McDonald Islands")]
        HeardIslandAndMcDonaldIslands = 98,
        [EnumMember(Value = "holySee")]
        [Description("The Holy See")]
        HolySee = 99,
        [EnumMember(Value = "honduras")]
        [Description("The Republic of Honduras")]
        Honduras = 100,
        [EnumMember(Value = "hongKong")]
        [Description("The Hong Kong Special Administrative Region of China")]
        HongKong = 101,
        [EnumMember(Value = "hungary")]
        [Description("Hungary")]
        Hungary = 102,
        [EnumMember(Value = "iceland")]
        [Description("Iceland")]
        Iceland = 103,
        [EnumMember(Value = "india")]
        [Description("The Republic of India")]
        India = 104,
        [EnumMember(Value = "indonesia")]
        [Description("The Republic of Indonesia")]
        Indonesia = 105,
        [EnumMember(Value = "iranIslamicRepublic")]
        [Description("The Islamic Republic of Iran")]
        IranIslamicRepublic = 106,
        [EnumMember(Value = "iraq")]
        [Description("The Republic of Iraq")]
        Iraq = 107,
        [EnumMember(Value = "ireland")]
        [Description("Ireland")]
        Ireland = 108,
        [EnumMember(Value = "isleOfMan")]
        [Description("The Isle of Man")]
        IsleOfMan = 109,
        [EnumMember(Value = "israel")]
        [Description("The State of Israel")]
        Israel = 110,
        [EnumMember(Value = "italy")]
        [Description("The Italian Republic")]
        Italy = 111,
        [EnumMember(Value = "jamaica")]
        [Description("Jamaica")]
        Jamaica = 112,
        [EnumMember(Value = "japan")]
        [Description("Japan")]
        Japan = 113,
        [EnumMember(Value = "jersey")]
        [Description("The Bailiwick of Jersey")]
        Jersey = 114,
        [EnumMember(Value = "jordan")]
        [Description("The Hashemite Kingdom of Jordan")]
        Jordan = 115,
        [EnumMember(Value = "kazakhstan")]
        [Description("The Republic of Kazakhstan")]
        Kazakhstan = 116,
        [EnumMember(Value = "kenya")]
        [Description("The Republic of Kenya")]
        Kenya = 117,
        [EnumMember(Value = "kiribati")]
        [Description("The Republic of Kiribati")]
        Kiribati = 118,
        [EnumMember(Value = "koreaTheDemocraticPeoplesRepublic")]
        [Description("The Democratic People's Republic of Korea")]
        KoreaTheDemocraticPeoplesRepublic = 119,
        [EnumMember(Value = "koreaTheRepublic")]
        [Description("The Republic of Korea")]
        KoreaTheRepublic = 120,
        [EnumMember(Value = "kuwait")]
        [Description("The State of Kuwait")]
        Kuwait = 121,
        [EnumMember(Value = "kyrgyzstan")]
        [Description("The Kyrgyz Republic")]
        Kyrgyzstan = 122,
        [EnumMember(Value = "laoPeoplesDemocraticRepublic")]
        [Description("The Lao People's Democratic Republic")]
        LaoPeoplesDemocraticRepublic = 123,
        [EnumMember(Value = "latvia")]
        [Description("The Republic of Latvia")]
        Latvia = 124,
        [EnumMember(Value = "lebanon")]
        [Description("The Lebanese Republic")]
        Lebanon = 125,
        [EnumMember(Value = "lesotho")]
        [Description("The Kingdom of Lesotho")]
        Lesotho = 126,
        [EnumMember(Value = "liberia")]
        [Description("The Republic of Liberia")]
        Liberia = 127,
        [EnumMember(Value = "libya")]
        [Description("The State of Libya")]
        Libya = 128,
        [EnumMember(Value = "liechtenstein")]
        [Description("The Principality of Liechtenstein")]
        Liechtenstein = 129,
        [EnumMember(Value = "lithuania")]
        [Description("The Republic of Lithuania")]
        Lithuania = 130,
        [EnumMember(Value = "luxembourg")]
        [Description("The Grand Duchy of Luxembourg")]
        Luxembourg = 131,
        [EnumMember(Value = "macao")]
        [Description("Macao Special Administrative Region of China")]
        Macao = 132,
        [EnumMember(Value = "northMacedonia")]
        [Description("Republic of North Macedonia")]
        NorthMacedonia = 133,
        [EnumMember(Value = "madagascar")]
        [Description("The Republic of Madagascar")]
        Madagascar = 134,
        [EnumMember(Value = "malawi")]
        [Description("The Republic of Malawi")]
        Malawi = 135,
        [EnumMember(Value = "malaysia")]
        [Description("Malaysia")]
        Malaysia = 136,
        [EnumMember(Value = "maldives")]
        [Description("The Republic of Maldives")]
        Maldives = 137,
        [EnumMember(Value = "mali")]
        [Description("The Republic of Mali")]
        Mali = 138,
        [EnumMember(Value = "malta")]
        [Description("The Republic of Malta")]
        Malta = 139,
        [EnumMember(Value = "marshallIslands")]
        [Description("The Republic of the Marshall Islands")]
        MarshallIslands = 140,
        [EnumMember(Value = "martinique")]
        [Description("Martinique")]
        Martinique = 141,
        [EnumMember(Value = "mauritania")]
        [Description("The Islamic Republic of Mauritania")]
        Mauritania = 142,
        [EnumMember(Value = "mauritius")]
        [Description("The Republic of Mauritius")]
        Mauritius = 143,
        [EnumMember(Value = "mayotte")]
        [Description("The Department of Mayotte")]
        Mayotte = 144,
        [EnumMember(Value = "mexico")]
        [Description("The United Mexican States")]
        Mexico = 145,
        [EnumMember(Value = "micronesiaFederatedStates")]
        [Description("The Federated States of Micronesia")]
        MicronesiaFederatedStates = 146,
        [EnumMember(Value = "moldovaTheRepublic")]
        [Description("The Republic of Moldova")]
        MoldovaTheRepublic = 147,
        [EnumMember(Value = "monaco")]
        [Description("The Principality of Monaco")]
        Monaco = 148,
        [EnumMember(Value = "mongolia")]
        [Description("The State of Mongolia")]
        Mongolia = 149,
        [EnumMember(Value = "montenegro")]
        [Description("Montenegro")]
        Montenegro = 150,
        [EnumMember(Value = "montserrat")]
        [Description("Montserrat")]
        Montserrat = 151,
        [EnumMember(Value = "morocco")]
        [Description("The Kingdom of Morocco")]
        Morocco = 152,
        [EnumMember(Value = "mozambique")]
        [Description("The Republic of Mozambique")]
        Mozambique = 153,
        [EnumMember(Value = "myanmar")]
        [Description("The Republic of the Union of Myanmar")]
        Myanmar = 154,
        [EnumMember(Value = "namibia")]
        [Description("The Republic of Namibia")]
        Namibia = 155,
        [EnumMember(Value = "nauru")]
        [Description("The Republic of Nauru")]
        Nauru = 156,
        [EnumMember(Value = "nepal")]
        [Description("The Federal Democratic Republic of Nepal")]
        Nepal = 157,
        [EnumMember(Value = "netherlands")]
        [Description("The Kingdom of the Netherlands")]
        Netherlands = 158,
        [EnumMember(Value = "newCaledonia")]
        [Description("New Caledonia")]
        NewCaledonia = 159,
        [EnumMember(Value = "newZealand")]
        [Description("New Zealand")]
        NewZealand = 160,
        [EnumMember(Value = "nicaragua")]
        [Description("The Republic of Nicaragua")]
        Nicaragua = 161,
        [EnumMember(Value = "niger")]
        [Description("The Republic of the Niger")]
        Niger = 162,
        [EnumMember(Value = "nigeria")]
        [Description("The Federal Republic of Nigeria")]
        Nigeria = 163,
        [EnumMember(Value = "niue")]
        [Description("Niue")]
        Niue = 164,
        [EnumMember(Value = "norfolkIsland")]
        [Description("The Territory of Norfolk Island")]
        NorfolkIsland = 165,
        [EnumMember(Value = "northernMarianaIslands")]
        [Description("The Commonwealth of the Northern Mariana Islands")]
        NorthernMarianaIslands = 166,
        [EnumMember(Value = "norway")]
        [Description("The Kingdom of Norway")]
        Norway = 167,
        [EnumMember(Value = "oman")]
        [Description("The Sultanate of Oman")]
        Oman = 168,
        [EnumMember(Value = "pakistan")]
        [Description("The Islamic Republic of Pakistan")]
        Pakistan = 169,
        [EnumMember(Value = "palau")]
        [Description("The Republic of Palau")]
        Palau = 170,
        [EnumMember(Value = "palestineState")]
        [Description("The State of Palestine")]
        PalestineState = 171,
        [EnumMember(Value = "panama")]
        [Description("The Republic of Panamá")]
        Panama = 172,
        [EnumMember(Value = "papuaNewGuinea")]
        [Description("The Independent State of Papua New Guinea")]
        PapuaNewGuinea = 173,
        [EnumMember(Value = "paraguay")]
        [Description("The Republic of Paraguay")]
        Paraguay = 174,
        [EnumMember(Value = "peru")]
        [Description("The Republic of Perú")]
        Peru = 175,
        [EnumMember(Value = "philippines")]
        [Description("The Republic of the Philippines")]
        Philippines = 176,
        [EnumMember(Value = "pitcairn")]
        [Description("The Pitcairn, Henderson, Ducie and Oeno Islands")]
        Pitcairn = 177,
        [EnumMember(Value = "poland")]
        [Description("The Republic of Poland")]
        Poland = 178,
        [EnumMember(Value = "portugal")]
        [Description("The Portuguese Republic")]
        Portugal = 179,
        [EnumMember(Value = "puertoRico")]
        [Description("The Commonwealth of Puerto Rico")]
        PuertoRico = 180,
        [EnumMember(Value = "qatar")]
        [Description("The State of Qatar")]
        Qatar = 181,
        [EnumMember(Value = "reunion")]
        [Description("Réunion")]
        Reunion = 182,
        [EnumMember(Value = "romania")]
        [Description("Romania")]
        Romania = 183,
        [EnumMember(Value = "russianFederation")]
        [Description("The Russian Federation")]
        RussianFederation = 184,
        [EnumMember(Value = "rwanda")]
        [Description("The Republic of Rwanda")]
        Rwanda = 185,
        [EnumMember(Value = "saintBarthelemy")]
        [Description("The Collectivity of Saint-Barthélemy")]
        SaintBarthelemy = 186,
        [EnumMember(Value = "saintHelena")]
        [Description("Saint Helena, Ascension and Tristan da Cunha")]
        SaintHelena = 187,
        [EnumMember(Value = "saintKittsandNevis")]
        [Description("Saint Kitts and Nevis")]
        SaintKittsandNevis = 188,
        [EnumMember(Value = "saintLucia")]
        [Description("Saint Lucia")]
        SaintLucia = 189,
        [EnumMember(Value = "saintMartinFrenchPart")]
        [Description("The Collectivity of Saint-Martin")]
        SaintMartinFrenchPart = 190,
        [EnumMember(Value = "saintPierreAndMiquelon")]
        [Description("The Overseas Collectivity of Saint-Pierre and Miquelon")]
        SaintPierreAndMiquelon = 191,
        [EnumMember(Value = "saintVincentAndTheGrenadines")]
        [Description("Saint Vincent and the Grenadines")]
        SaintVincentAndTheGrenadines = 192,
        [EnumMember(Value = "samoa")]
        [Description("The Independent State of Samoa")]
        Samoa = 193,
        [EnumMember(Value = "sanMarino")]
        [Description("The Republic of San Marino")]
        SanMarino = 194,
        [EnumMember(Value = "saoTomeAndPrincipe")]
        [Description("The Democratic Republic of São Tomé and Príncipe")]
        SaoTomeAndPrincipe = 195,
        [EnumMember(Value = "saudiArabia")]
        [Description("The Kingdom of Saudi Arabia")]
        SaudiArabia = 196,
        [EnumMember(Value = "senegal")]
        [Description("The Republic of Senegal")]
        Senegal = 197,
        [EnumMember(Value = "serbia")]
        [Description("The Republic of Serbia")]
        Serbia = 198,
        [EnumMember(Value = "seychelles")]
        [Description("The Republic of Seychelles")]
        Seychelles = 199,
        [EnumMember(Value = "sierraLeone")]
        [Description("The Republic of Sierra Leone")]
        SierraLeone = 200,
        [EnumMember(Value = "singapore")]
        [Description("The Republic of Singapore")]
        Singapore = 201,
        [EnumMember(Value = "sintMaartenDutchPart")]
        [Description("Sint Maarten")]
        SintMaartenDutchPart = 202,
        [EnumMember(Value = "slovakia")]
        [Description("The Slovak Republic")]
        Slovakia = 203,
        [EnumMember(Value = "slovenia")]
        [Description("The Republic of Slovenia")]
        Slovenia = 204,
        [EnumMember(Value = "solomonIslands")]
        [Description("The Solomon Islands")]
        SolomonIslands = 205,
        [EnumMember(Value = "somalia")]
        [Description("The Federal Republic of Somalia")]
        Somalia = 206,
        [EnumMember(Value = "southAfrica")]
        [Description("The Republic of South Africa")]
        SouthAfrica = 207,
        [EnumMember(Value = "southGeorgiaAndTheSouthSandwichIslands")]
        [Description("South Georgia and the South Sandwich Islands")]
        SouthGeorgiaAndTheSouthSandwichIslands = 208,
        [EnumMember(Value = "southSudan")]
        [Description("The Republic of South Sudan")]
        SouthSudan = 209,
        [EnumMember(Value = "spain")]
        [Description("The Kingdom of Spain")]
        Spain = 210,
        [EnumMember(Value = "sriLanka")]
        [Description("The Democratic Socialist Republic of Sri Lanka")]
        SriLanka = 211,
        [EnumMember(Value = "sudan")]
        [Description("The Republic of the Sudan")]
        Sudan = 212,
        [EnumMember(Value = "suriname")]
        [Description("The Republic of Suriname")]
        Suriname = 213,
        [EnumMember(Value = "svalbard")]
        [Description("Svalbard and Jan Mayen")]
        Svalbard = 214,
        [EnumMember(Value = "sweden")]
        [Description("The Kingdom of Sweden")]
        Sweden = 215,
        [EnumMember(Value = "switzerland")]
        [Description("The Swiss Confederation")]
        Switzerland = 216,
        [EnumMember(Value = "syrianArabRepublic")]
        [Description("The Syrian Arab Republic")]
        SyrianArabRepublic = 217,
        [EnumMember(Value = "taiwanProvinceOfChina")]
        [Description("The Republic of China")]
        TaiwanProvinceOfChina = 218,
        [EnumMember(Value = "tajikistan")]
        [Description("The Republic of Tajikistan")]
        Tajikistan = 219,
        [EnumMember(Value = "tanzaniaTheUnitedRepublic")]
        [Description("The United Republic of Tanzania")]
        TanzaniaTheUnitedRepublic = 220,
        [EnumMember(Value = "thailand")]
        [Description("The Kingdom of Thailand")]
        Thailand = 221,
        [EnumMember(Value = "timorLeste")]
        [Description("The Democratic Republic of Timor-Leste")]
        TimorLeste = 222,
        [EnumMember(Value = "togo")]
        [Description("The Togolese Republic")]
        Togo = 223,
        [EnumMember(Value = "tokelau")]
        [Description("Tokelau")]
        Tokelau = 224,
        [EnumMember(Value = "tonga")]
        [Description("The Kingdom of Tonga")]
        Tonga = 225,
        [EnumMember(Value = "trinidadAndTobago")]
        [Description("The Republic of Trinidad and Tobago")]
        TrinidadAndTobago = 226,
        [EnumMember(Value = "tunisia")]
        [Description("The Republic of Tunisia")]
        Tunisia = 227,
        [EnumMember(Value = "turkey")]
        [Description("The Republic of Turkey")]
        Turkey = 228,
        [EnumMember(Value = "turkmenistan")]
        [Description("Turkmenistan")]
        Turkmenistan = 229,
        [EnumMember(Value = "turksAndCaicosIslands")]
        [Description("The Turks and Caicos Islands")]
        TurksAndCaicosIslands = 230,
        [EnumMember(Value = "tuvalu")]
        [Description("Tuvalu")]
        Tuvalu = 231,
        [EnumMember(Value = "uganda")]
        [Description("The Republic of Uganda")]
        Uganda = 232,
        [EnumMember(Value = "ukraine")]
        [Description("Ukraine")]
        Ukraine = 233,
        [EnumMember(Value = "unitedArabEmirates")]
        [Description("The United Arab Emirates")]
        UnitedArabEmirates = 234,
        [EnumMember(Value = "unitedKingdom")]
        [Description("The United Kingdom of Great Britain and Northern Ireland")]
        UnitedKingdom = 235,
        [EnumMember(Value = "unitedStatesMinorOutlyingIslands")]
        [Description("Baker Island")]
        UnitedStatesMinorOutlyingIslands = 236,
        [EnumMember(Value = "unitedStatesOfAmerica")]
        [Description("The United States of America")]
        UnitedStatesOfAmerica = 237,
        [EnumMember(Value = "uruguay")]
        [Description("The Oriental Republic of Uruguay")]
        Uruguay = 238,
        [EnumMember(Value = "uzbekistan")]
        [Description("The Republic of Uzbekistan")]
        Uzbekistan = 239,
        [EnumMember(Value = "vanuatu")]
        [Description("The Republic of Vanuatu")]
        Vanuatu = 240,
        [EnumMember(Value = "venezuelaBolivarianRepublic")]
        [Description("The Bolivarian Republic of Venezuela")]
        VenezuelaBolivarianRepublic = 241,
        [EnumMember(Value = "vietNam")]
        [Description("The Socialist Republic of Viet Nam")]
        VietNam = 242,
        [EnumMember(Value = "virginIslandsBritish")]
        [Description("The Virgin Islands")]
        VirginIslandsBritish = 243,
        [EnumMember(Value = "virginIslandsUS")]
        [Description("The Virgin Islands of the United States")]
        VirginIslandsUS = 244,
        [EnumMember(Value = "wallisAndFutuna")]
        [Description("The Territory of the Wallis and Futuna Islands")]
        WallisAndFutuna = 245,
        [EnumMember(Value = "westernSahara")]
        [Description("The Sahrawi Arab Democratic Republic")]
        WesternSahara = 246,
        [EnumMember(Value = "yemen")]
        [Description("The Republic of Yemen")]
        Yemen = 247,
        [EnumMember(Value = "zambia")]
        [Description("The Republic of Zambia")]
        Zambia = 248,
        [EnumMember(Value = "zimbabwe")]
        [Description("The Republic of Zimbabwe")]
        Zimbabwe = 249,
    }
}
