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
        /// <summary>
        /// The afghanistan
        /// </summary>
        [JsonProperty("afghanistan")]
        [Description("The Islamic Republic of Afghanistan")]
        Afghanistan = 1,
        /// <summary>
        /// The åland islands
        /// </summary>
        [JsonProperty("ålandIslands")]
        [Description("Åland")]
        ÅlandIslands = 2,
        /// <summary>
        /// The albania
        /// </summary>
        [JsonProperty("albania")]
        [Description("The Republic of Albania")]
        Albania = 3,
        /// <summary>
        /// The algeria
        /// </summary>
        [JsonProperty("algeria")]
        [Description("The People's Democratic Republic of Algeria")]
        Algeria = 4,
        /// <summary>
        /// The american samoa
        /// </summary>
        [JsonProperty("americanSamoa")]
        [Description("The Territory of American Samoa")]
        AmericanSamoa = 5,
        /// <summary>
        /// The andorra
        /// </summary>
        [JsonProperty("andorra")]
        [Description("The Principality of Andorra")]
        Andorra = 6,
        /// <summary>
        /// The angola
        /// </summary>
        [JsonProperty("angola")]
        [Description("The Republic of Angola")]
        Angola = 7,
        /// <summary>
        /// The anguilla
        /// </summary>
        [JsonProperty("anguilla")]
        [Description("Anguilla")]
        Anguilla = 8,
        /// <summary>
        /// The antarctica
        /// </summary>
        [JsonProperty("antarctica")]
        [Description("60th parallel south")]
        Antarctica = 9,
        /// <summary>
        /// The antiguaand barbuda
        /// </summary>
        [JsonProperty("antiguaandBarbuda")]
        [Description("Antigua and Barbuda")]
        AntiguaandBarbuda = 10,
        /// <summary>
        /// The argentina
        /// </summary>
        [JsonProperty("argentina")]
        [Description("The Argentine Republic")]
        Argentina = 11,
        /// <summary>
        /// The armenia
        /// </summary>
        [JsonProperty("armenia")]
        [Description("The Republic of Armenia")]
        Armenia = 12,
        /// <summary>
        /// The aruba
        /// </summary>
        [JsonProperty("aruba")]
        [Description("Aruba")]
        Aruba = 13,
        /// <summary>
        /// The australia
        /// </summary>
        [JsonProperty("australia")]
        [Description("The Commonwealth of Australia")]
        Australia = 14,
        /// <summary>
        /// The austria
        /// </summary>
        [JsonProperty("austria")]
        [Description("The Republic of Austria")]
        Austria = 15,
        /// <summary>
        /// The azerbaijan
        /// </summary>
        [JsonProperty("azerbaijan")]
        [Description("The Republic of Azerbaijan")]
        Azerbaijan = 16,
        /// <summary>
        /// The bahamasthe
        /// </summary>
        [JsonProperty("bahamasthe")]
        [Description("The Commonwealth of The Bahamas")]
        Bahamasthe = 17,
        /// <summary>
        /// The bahrain
        /// </summary>
        [JsonProperty("bahrain")]
        [Description("The Kingdom of Bahrain")]
        Bahrain = 18,
        /// <summary>
        /// The bangladesh
        /// </summary>
        [JsonProperty("bangladesh")]
        [Description("The People's Republic of Bangladesh")]
        Bangladesh = 19,
        /// <summary>
        /// The barbados
        /// </summary>
        [JsonProperty("barbados")]
        [Description("Barbados")]
        Barbados = 20,
        /// <summary>
        /// The belarus
        /// </summary>
        [JsonProperty("belarus")]
        [Description("The Republic of Belarus")]
        Belarus = 21,
        /// <summary>
        /// The belgium
        /// </summary>
        [JsonProperty("belgium")]
        [Description("The Kingdom of Belgium")]
        Belgium = 22,
        /// <summary>
        /// The belize
        /// </summary>
        [JsonProperty("belize")]
        [Description("Belize")]
        Belize = 23,
        /// <summary>
        /// The benin
        /// </summary>
        [JsonProperty("benin")]
        [Description("The Republic of Benin")]
        Benin = 24,
        /// <summary>
        /// The bermuda
        /// </summary>
        [JsonProperty("bermuda")]
        [Description("Bermuda")]
        Bermuda = 25,
        /// <summary>
        /// The bhutan
        /// </summary>
        [JsonProperty("bhutan")]
        [Description("The Kingdom of Bhutan")]
        Bhutan = 26,
        /// <summary>
        /// The bolivia plurinational stateof
        /// </summary>
        [JsonProperty("boliviaPlurinationalStateof")]
        [Description("The Plurinational State of Bolivia")]
        BoliviaPlurinationalStateof = 27,
        /// <summary>
        /// The bonaire
        /// </summary>
        [JsonProperty("bonaire")]
        [Description("Bonaire, Sint Eustatius and Saba")]
        Bonaire = 28,
        /// <summary>
        /// The bosniaand herzegovina
        /// </summary>
        [JsonProperty("bosniaandHerzegovina")]
        [Description("Bosnia and Herzegovina")]
        BosniaandHerzegovina = 29,
        /// <summary>
        /// The botswana
        /// </summary>
        [JsonProperty("botswana")]
        [Description("The Republic of Botswana")]
        Botswana = 30,
        /// <summary>
        /// The bouvet island
        /// </summary>
        [JsonProperty("bouvetIsland")]
        [Description("Bouvet Island")]
        BouvetIsland = 31,
        /// <summary>
        /// The brazil
        /// </summary>
        [JsonProperty("brazil")]
        [Description("The Federative Republic of Brazil")]
        Brazil = 32,
        /// <summary>
        /// The british indian ocean territorythe
        /// </summary>
        [JsonProperty("britishIndianOceanTerritorythe")]
        [Description("The British Indian Ocean Territory")]
        BritishIndianOceanTerritorythe = 33,
        /// <summary>
        /// The brunei darussalam
        /// </summary>
        [JsonProperty("bruneiDarussalam")]
        [Description("The Nation of Brunei, the Abode of Peace")]
        BruneiDarussalam = 34,
        /// <summary>
        /// The bulgaria
        /// </summary>
        [JsonProperty("bulgaria")]
        [Description("The Republic of Bulgaria")]
        Bulgaria = 35,
        /// <summary>
        /// The burkina faso
        /// </summary>
        [JsonProperty("burkinaFaso")]
        [Description("Burkina Faso")]
        BurkinaFaso = 36,
        /// <summary>
        /// The burundi
        /// </summary>
        [JsonProperty("burundi")]
        [Description("The Republic of Burundi")]
        Burundi = 37,
        /// <summary>
        /// The cabo verde
        /// </summary>
        [JsonProperty("caboVerde")]
        [Description("The Republic of Cabo Verde")]
        CaboVerde = 38,
        /// <summary>
        /// The cambodia
        /// </summary>
        [JsonProperty("cambodia")]
        [Description("The Kingdom of Cambodia")]
        Cambodia = 39,
        /// <summary>
        /// The cameroon
        /// </summary>
        [JsonProperty("cameroon")]
        [Description("The Republic of Cameroon")]
        Cameroon = 40,
        /// <summary>
        /// The canada
        /// </summary>
        [JsonProperty("canada")]
        [Description("Canada")]
        Canada = 41,
        /// <summary>
        /// The cayman islandsthe
        /// </summary>
        [JsonProperty("caymanIslandsthe")]
        [Description("The Cayman Islands")]
        CaymanIslandsthe = 42,
        /// <summary>
        /// The central african republicthe
        /// </summary>
        [JsonProperty("centralAfricanRepublicthe")]
        [Description("The Central African Republic")]
        CentralAfricanRepublicthe = 43,
        /// <summary>
        /// The chad
        /// </summary>
        [JsonProperty("chad")]
        [Description("The Republic of Chad")]
        Chad = 44,
        /// <summary>
        /// The chile
        /// </summary>
        [JsonProperty("chile")]
        [Description("The Republic of Chile")]
        Chile = 45,
        /// <summary>
        /// The china
        /// </summary>
        [JsonProperty("china")]
        [Description("The People's Republic of China")]
        China = 46,
        /// <summary>
        /// The christmas island
        /// </summary>
        [JsonProperty("christmasIsland")]
        [Description("The Territory of Christmas Island")]
        ChristmasIsland = 47,
        /// <summary>
        /// The cocos keeling islandsthe
        /// </summary>
        [JsonProperty("cocosKeelingIslandsthe")]
        [Description("The Territory of Cocos (Keeling) Islands")]
        CocosKeelingIslandsthe = 48,
        /// <summary>
        /// The colombia
        /// </summary>
        [JsonProperty("colombia")]
        [Description("The Republic of Colombia")]
        Colombia = 49,
        /// <summary>
        /// The comorosthe
        /// </summary>
        [JsonProperty("comorosthe")]
        [Description("The Union of the Comoros")]
        Comorosthe = 50,
        /// <summary>
        /// The congothe democratic republicofthe
        /// </summary>
        [JsonProperty("congotheDemocraticRepublicofthe")]
        [Description("The Democratic Republic of the Congo")]
        CongotheDemocraticRepublicofthe = 51,
        /// <summary>
        /// The congothe
        /// </summary>
        [JsonProperty("congothe")]
        [Description("The Republic of the Congo")]
        Congothe = 52,
        /// <summary>
        /// The cook islandsthe
        /// </summary>
        [JsonProperty("cookIslandsthe")]
        [Description("The Cook Islands")]
        CookIslandsthe = 53,
        /// <summary>
        /// The costa rica
        /// </summary>
        [JsonProperty("costaRica")]
        [Description("The Republic of Costa Rica")]
        CostaRica = 54,
        /// <summary>
        /// The côted ivoire
        /// </summary>
        [JsonProperty("côtedIvoire")]
        [Description("The Republic of Côte d'Ivoire")]
        CôtedIvoire = 55,
        /// <summary>
        /// The croatia
        /// </summary>
        [JsonProperty("croatia")]
        [Description("The Republic of Croatia")]
        Croatia = 56,
        /// <summary>
        /// The cuba
        /// </summary>
        [JsonProperty("cuba")]
        [Description("The Republic of Cuba")]
        Cuba = 57,
        /// <summary>
        /// The curaçao
        /// </summary>
        [JsonProperty("curaçao")]
        [Description("The Country of Curaçao")]
        Curaçao = 58,
        /// <summary>
        /// The cyprus
        /// </summary>
        [JsonProperty("cyprus")]
        [Description("The Republic of Cyprus")]
        Cyprus = 59,
        /// <summary>
        /// The czechia
        /// </summary>
        [JsonProperty("czechia")]
        [Description("The Czech Republic")]
        Czechia = 60,
        /// <summary>
        /// The denmark
        /// </summary>
        [JsonProperty("denmark")]
        [Description("The Kingdom of Denmark")]
        Denmark = 61,
        /// <summary>
        /// The djibouti
        /// </summary>
        [JsonProperty("djibouti")]
        [Description("The Republic of Djibouti")]
        Djibouti = 62,
        /// <summary>
        /// The dominica
        /// </summary>
        [JsonProperty("dominica")]
        [Description("The Commonwealth of Dominica")]
        Dominica = 63,
        /// <summary>
        /// The dominican republicthe
        /// </summary>
        [JsonProperty("dominicanRepublicthe")]
        [Description("The Dominican Republic")]
        DominicanRepublicthe = 64,
        /// <summary>
        /// The ecuador
        /// </summary>
        [JsonProperty("ecuador")]
        [Description("The Republic of Ecuador")]
        Ecuador = 65,
        /// <summary>
        /// The egypt
        /// </summary>
        [JsonProperty("egypt")]
        [Description("The Arab Republic of Egypt")]
        Egypt = 66,
        /// <summary>
        /// The el salvador
        /// </summary>
        [JsonProperty("elSalvador")]
        [Description("The Republic of El Salvador")]
        ElSalvador = 67,
        /// <summary>
        /// The equatorial guinea
        /// </summary>
        [JsonProperty("equatorialGuinea")]
        [Description("The Republic of Equatorial Guinea")]
        EquatorialGuinea = 68,
        /// <summary>
        /// The eritrea
        /// </summary>
        [JsonProperty("eritrea")]
        [Description("The State of Eritrea")]
        Eritrea = 69,
        /// <summary>
        /// The estonia
        /// </summary>
        [JsonProperty("estonia")]
        [Description("The Republic of Estonia")]
        Estonia = 70,
        /// <summary>
        /// The eswatini
        /// </summary>
        [JsonProperty("eswatini")]
        [Description("The Kingdom of Eswatini")]
        Eswatini = 71,
        /// <summary>
        /// The ethiopia
        /// </summary>
        [JsonProperty("ethiopia")]
        [Description("The Federal Democratic Republic of Ethiopia")]
        Ethiopia = 72,
        /// <summary>
        /// The falkland islandsthe malvinas
        /// </summary>
        [JsonProperty("falklandIslandstheMalvinas")]
        [Description("The Falkland Islands")]
        FalklandIslandstheMalvinas = 73,
        /// <summary>
        /// The faroe islandsthe
        /// </summary>
        [JsonProperty("faroeIslandsthe")]
        [Description("The Faroe Islands")]
        FaroeIslandsthe = 74,
        /// <summary>
        /// The fiji
        /// </summary>
        [JsonProperty("fiji")]
        [Description("The Republic of Fiji")]
        Fiji = 75,
        /// <summary>
        /// The finland
        /// </summary>
        [JsonProperty("finland")]
        [Description("The Republic of Finland")]
        Finland = 76,
        /// <summary>
        /// The france
        /// </summary>
        [JsonProperty("france")]
        [Description("The French Republic")]
        France = 77,
        /// <summary>
        /// The french guiana
        /// </summary>
        [JsonProperty("frenchGuiana")]
        [Description("Guyane")]
        FrenchGuiana = 78,
        /// <summary>
        /// The french polynesia
        /// </summary>
        [JsonProperty("frenchPolynesia")]
        [Description("French Polynesia")]
        FrenchPolynesia = 79,
        /// <summary>
        /// The french southern territoriesthe
        /// </summary>
        [JsonProperty("frenchSouthernTerritoriesthe")]
        [Description("The French Southern and Antarctic Lands")]
        FrenchSouthernTerritoriesthe = 80,
        /// <summary>
        /// The gabon
        /// </summary>
        [JsonProperty("gabon")]
        [Description("The Gabonese Republic")]
        Gabon = 81,
        /// <summary>
        /// The gambiathe
        /// </summary>
        [JsonProperty("gambiathe")]
        [Description("The Republic of The Gambia")]
        Gambiathe = 82,
        /// <summary>
        /// The georgia
        /// </summary>
        [JsonProperty("georgia")]
        [Description("Georgia")]
        Georgia = 83,
        /// <summary>
        /// The germany
        /// </summary>
        [JsonProperty("germany")]
        [Description("The Federal Republic of Germany")]
        Germany = 84,
        /// <summary>
        /// The ghana
        /// </summary>
        [JsonProperty("ghana")]
        [Description("The Republic of Ghana")]
        Ghana = 85,
        /// <summary>
        /// The gibraltar
        /// </summary>
        [JsonProperty("gibraltar")]
        [Description("Gibraltar")]
        Gibraltar = 86,
        /// <summary>
        /// The greece
        /// </summary>
        [JsonProperty("greece")]
        [Description("The Hellenic Republic")]
        Greece = 87,
        /// <summary>
        /// The greenland
        /// </summary>
        [JsonProperty("greenland")]
        [Description("Kalaallit Nunaat")]
        Greenland = 88,
        /// <summary>
        /// The grenada
        /// </summary>
        [JsonProperty("grenada")]
        [Description("Grenada")]
        Grenada = 89,
        /// <summary>
        /// The guadeloupe
        /// </summary>
        [JsonProperty("guadeloupe")]
        [Description("Guadeloupe")]
        Guadeloupe = 90,
        /// <summary>
        /// The guam
        /// </summary>
        [JsonProperty("guam")]
        [Description("The Territory of Guam")]
        Guam = 91,
        /// <summary>
        /// The guatemala
        /// </summary>
        [JsonProperty("guatemala")]
        [Description("The Republic of Guatemala")]
        Guatemala = 92,
        /// <summary>
        /// The guernsey
        /// </summary>
        [JsonProperty("guernsey")]
        [Description("The Bailiwick of Guernsey")]
        Guernsey = 93,
        /// <summary>
        /// The guinea
        /// </summary>
        [JsonProperty("guinea")]
        [Description("The Republic of Guinea")]
        Guinea = 94,
        /// <summary>
        /// The guinea bissau
        /// </summary>
        [JsonProperty("guineaBissau")]
        [Description("The Republic of Guinea-Bissau")]
        GuineaBissau = 95,
        /// <summary>
        /// The guyana
        /// </summary>
        [JsonProperty("guyana")]
        [Description("The Co-operative Republic of Guyana")]
        Guyana = 96,
        /// <summary>
        /// The haiti
        /// </summary>
        [JsonProperty("haiti")]
        [Description("The Republic of Haiti")]
        Haiti = 97,
        /// <summary>
        /// The heard islandand mc donald islands
        /// </summary>
        [JsonProperty("heardIslandandMcDonaldIslands")]
        [Description("The Territory of Heard Island and McDonald Islands")]
        HeardIslandandMcDonaldIslands = 98,
        /// <summary>
        /// The holy seethe
        /// </summary>
        [JsonProperty("holySeethe")]
        [Description("The Holy See")]
        HolySeethe = 99,
        /// <summary>
        /// The honduras
        /// </summary>
        [JsonProperty("honduras")]
        [Description("The Republic of Honduras")]
        Honduras = 100,
        /// <summary>
        /// The hong kong
        /// </summary>
        [JsonProperty("hongKong")]
        [Description("The Hong Kong Special Administrative Region of China")]
        HongKong = 101,
        /// <summary>
        /// The hungary
        /// </summary>
        [JsonProperty("hungary")]
        [Description("Hungary")]
        Hungary = 102,
        /// <summary>
        /// The iceland
        /// </summary>
        [JsonProperty("iceland")]
        [Description("Iceland")]
        Iceland = 103,
        /// <summary>
        /// The india
        /// </summary>
        [JsonProperty("india")]
        [Description("The Republic of India")]
        India = 104,
        /// <summary>
        /// The indonesia
        /// </summary>
        [JsonProperty("indonesia")]
        [Description("The Republic of Indonesia")]
        Indonesia = 105,
        /// <summary>
        /// The iran islamic republicof
        /// </summary>
        [JsonProperty("iranIslamicRepublicof")]
        [Description("The Islamic Republic of Iran")]
        IranIslamicRepublicof = 106,
        /// <summary>
        /// The iraq
        /// </summary>
        [JsonProperty("iraq")]
        [Description("The Republic of Iraq")]
        Iraq = 107,
        /// <summary>
        /// The ireland
        /// </summary>
        [JsonProperty("ireland")]
        [Description("Ireland")]
        Ireland = 108,
        /// <summary>
        /// The isleof man
        /// </summary>
        [JsonProperty("isleofMan")]
        [Description("The Isle of Man")]
        IsleofMan = 109,
        /// <summary>
        /// The israel
        /// </summary>
        [JsonProperty("israel")]
        [Description("The State of Israel")]
        Israel = 110,
        /// <summary>
        /// The italy
        /// </summary>
        [JsonProperty("italy")]
        [Description("The Italian Republic")]
        Italy = 111,
        /// <summary>
        /// The jamaica
        /// </summary>
        [JsonProperty("jamaica")]
        [Description("Jamaica")]
        Jamaica = 112,
        /// <summary>
        /// The japan
        /// </summary>
        [JsonProperty("japan")]
        [Description("Japan")]
        Japan = 113,
        /// <summary>
        /// The jersey
        /// </summary>
        [JsonProperty("jersey")]
        [Description("The Bailiwick of Jersey")]
        Jersey = 114,
        /// <summary>
        /// The jordan
        /// </summary>
        [JsonProperty("jordan")]
        [Description("The Hashemite Kingdom of Jordan")]
        Jordan = 115,
        /// <summary>
        /// The kazakhstan
        /// </summary>
        [JsonProperty("kazakhstan")]
        [Description("The Republic of Kazakhstan")]
        Kazakhstan = 116,
        /// <summary>
        /// The kenya
        /// </summary>
        [JsonProperty("kenya")]
        [Description("The Republic of Kenya")]
        Kenya = 117,
        /// <summary>
        /// The kiribati
        /// </summary>
        [JsonProperty("kiribati")]
        [Description("The Republic of Kiribati")]
        Kiribati = 118,
        /// <summary>
        /// The koreathe democratic peoples republicof
        /// </summary>
        [JsonProperty("koreatheDemocraticPeoplesRepublicof")]
        [Description("The Democratic People's Republic of Korea")]
        KoreatheDemocraticPeoplesRepublicof = 119,
        /// <summary>
        /// The koreathe republicof
        /// </summary>
        [JsonProperty("koreatheRepublicof")]
        [Description("The Republic of Korea")]
        KoreatheRepublicof = 120,
        /// <summary>
        /// The kuwait
        /// </summary>
        [JsonProperty("kuwait")]
        [Description("The State of Kuwait")]
        Kuwait = 121,
        /// <summary>
        /// The kyrgyzstan
        /// </summary>
        [JsonProperty("kyrgyzstan")]
        [Description("The Kyrgyz Republic")]
        Kyrgyzstan = 122,
        /// <summary>
        /// The lao peoples democratic republicthe
        /// </summary>
        [JsonProperty("laoPeoplesDemocraticRepublicthe")]
        [Description("The Lao People's Democratic Republic")]
        LaoPeoplesDemocraticRepublicthe = 123,
        /// <summary>
        /// The latvia
        /// </summary>
        [JsonProperty("latvia")]
        [Description("The Republic of Latvia")]
        Latvia = 124,
        /// <summary>
        /// The lebanon
        /// </summary>
        [JsonProperty("lebanon")]
        [Description("The Lebanese Republic")]
        Lebanon = 125,
        /// <summary>
        /// The lesotho
        /// </summary>
        [JsonProperty("lesotho")]
        [Description("The Kingdom of Lesotho")]
        Lesotho = 126,
        /// <summary>
        /// The liberia
        /// </summary>
        [JsonProperty("liberia")]
        [Description("The Republic of Liberia")]
        Liberia = 127,
        /// <summary>
        /// The libya
        /// </summary>
        [JsonProperty("libya")]
        [Description("The State of Libya")]
        Libya = 128,
        /// <summary>
        /// The liechtenstein
        /// </summary>
        [JsonProperty("liechtenstein")]
        [Description("The Principality of Liechtenstein")]
        Liechtenstein = 129,
        /// <summary>
        /// The lithuania
        /// </summary>
        [JsonProperty("lithuania")]
        [Description("The Republic of Lithuania")]
        Lithuania = 130,
        /// <summary>
        /// The luxembourg
        /// </summary>
        [JsonProperty("luxembourg")]
        [Description("The Grand Duchy of Luxembourg")]
        Luxembourg = 131,
        /// <summary>
        /// The macao
        /// </summary>
        [JsonProperty("macao")]
        [Description("Macao Special Administrative Region of China")]
        Macao = 132,
        /// <summary>
        /// The north macedonia
        /// </summary>
        [JsonProperty("northMacedonia")]
        [Description("Republic of North Macedonia")]
        NorthMacedonia = 133,
        /// <summary>
        /// The madagascar
        /// </summary>
        [JsonProperty("madagascar")]
        [Description("The Republic of Madagascar")]
        Madagascar = 134,
        /// <summary>
        /// The malawi
        /// </summary>
        [JsonProperty("malawi")]
        [Description("The Republic of Malawi")]
        Malawi = 135,
        /// <summary>
        /// The malaysia
        /// </summary>
        [JsonProperty("malaysia")]
        [Description("Malaysia")]
        Malaysia = 136,
        /// <summary>
        /// The maldives
        /// </summary>
        [JsonProperty("maldives")]
        [Description("The Republic of Maldives")]
        Maldives = 137,
        /// <summary>
        /// The mali
        /// </summary>
        [JsonProperty("mali")]
        [Description("The Republic of Mali")]
        Mali = 138,
        /// <summary>
        /// The malta
        /// </summary>
        [JsonProperty("malta")]
        [Description("The Republic of Malta")]
        Malta = 139,
        /// <summary>
        /// The marshall islandsthe
        /// </summary>
        [JsonProperty("marshallIslandsthe")]
        [Description("The Republic of the Marshall Islands")]
        MarshallIslandsthe = 140,
        /// <summary>
        /// The martinique
        /// </summary>
        [JsonProperty("martinique")]
        [Description("Martinique")]
        Martinique = 141,
        /// <summary>
        /// The mauritania
        /// </summary>
        [JsonProperty("mauritania")]
        [Description("The Islamic Republic of Mauritania")]
        Mauritania = 142,
        /// <summary>
        /// The mauritius
        /// </summary>
        [JsonProperty("mauritius")]
        [Description("The Republic of Mauritius")]
        Mauritius = 143,
        /// <summary>
        /// The mayotte
        /// </summary>
        [JsonProperty("mayotte")]
        [Description("The Department of Mayotte")]
        Mayotte = 144,
        /// <summary>
        /// The mexico
        /// </summary>
        [JsonProperty("mexico")]
        [Description("The United Mexican States")]
        Mexico = 145,
        /// <summary>
        /// The micronesia federated statesof
        /// </summary>
        [JsonProperty("micronesiaFederatedStatesof")]
        [Description("The Federated States of Micronesia")]
        MicronesiaFederatedStatesof = 146,
        /// <summary>
        /// The moldovathe republicof
        /// </summary>
        [JsonProperty("moldovatheRepublicof")]
        [Description("The Republic of Moldova")]
        MoldovatheRepublicof = 147,
        /// <summary>
        /// The monaco
        /// </summary>
        [JsonProperty("monaco")]
        [Description("The Principality of Monaco")]
        Monaco = 148,
        /// <summary>
        /// The mongolia
        /// </summary>
        [JsonProperty("mongolia")]
        [Description("The State of Mongolia")]
        Mongolia = 149,
        /// <summary>
        /// The montenegro
        /// </summary>
        [JsonProperty("montenegro")]
        [Description("Montenegro")]
        Montenegro = 150,
        /// <summary>
        /// The montserrat
        /// </summary>
        [JsonProperty("montserrat")]
        [Description("Montserrat")]
        Montserrat = 151,
        /// <summary>
        /// The morocco
        /// </summary>
        [JsonProperty("morocco")]
        [Description("The Kingdom of Morocco")]
        Morocco = 152,
        /// <summary>
        /// The mozambique
        /// </summary>
        [JsonProperty("mozambique")]
        [Description("The Republic of Mozambique")]
        Mozambique = 153,
        /// <summary>
        /// The myanmar
        /// </summary>
        [JsonProperty("myanmar")]
        [Description("The Republic of the Union of Myanmar")]
        Myanmar = 154,
        /// <summary>
        /// The namibia
        /// </summary>
        [JsonProperty("namibia")]
        [Description("The Republic of Namibia")]
        Namibia = 155,
        /// <summary>
        /// The nauru
        /// </summary>
        [JsonProperty("nauru")]
        [Description("The Republic of Nauru")]
        Nauru = 156,
        /// <summary>
        /// The nepal
        /// </summary>
        [JsonProperty("nepal")]
        [Description("The Federal Democratic Republic of Nepal")]
        Nepal = 157,
        /// <summary>
        /// The netherlandsthe
        /// </summary>
        [JsonProperty("netherlandsthe")]
        [Description("The Kingdom of the Netherlands")]
        Netherlandsthe = 158,
        /// <summary>
        /// Creates new caledonia.
        /// </summary>
        [JsonProperty("newCaledonia")]
        [Description("New Caledonia")]
        NewCaledonia = 159,
        /// <summary>
        /// Creates new zealand.
        /// </summary>
        [JsonProperty("newZealand")]
        [Description("New Zealand")]
        NewZealand = 160,
        /// <summary>
        /// The nicaragua
        /// </summary>
        [JsonProperty("nicaragua")]
        [Description("The Republic of Nicaragua")]
        Nicaragua = 161,
        /// <summary>
        /// The nigerthe
        /// </summary>
        [JsonProperty("nigerthe")]
        [Description("The Republic of the Niger")]
        Nigerthe = 162,
        /// <summary>
        /// The nigeria
        /// </summary>
        [JsonProperty("nigeria")]
        [Description("The Federal Republic of Nigeria")]
        Nigeria = 163,
        /// <summary>
        /// The niue
        /// </summary>
        [JsonProperty("niue")]
        [Description("Niue")]
        Niue = 164,
        /// <summary>
        /// The norfolk island
        /// </summary>
        [JsonProperty("norfolkIsland")]
        [Description("The Territory of Norfolk Island")]
        NorfolkIsland = 165,
        /// <summary>
        /// The northern mariana islandsthe
        /// </summary>
        [JsonProperty("northernMarianaIslandsthe")]
        [Description("The Commonwealth of the Northern Mariana Islands")]
        NorthernMarianaIslandsthe = 166,
        /// <summary>
        /// The norway
        /// </summary>
        [JsonProperty("norway")]
        [Description("The Kingdom of Norway")]
        Norway = 167,
        /// <summary>
        /// The oman
        /// </summary>
        [JsonProperty("oman")]
        [Description("The Sultanate of Oman")]
        Oman = 168,
        /// <summary>
        /// The pakistan
        /// </summary>
        [JsonProperty("pakistan")]
        [Description("The Islamic Republic of Pakistan")]
        Pakistan = 169,
        /// <summary>
        /// The palau
        /// </summary>
        [JsonProperty("palau")]
        [Description("The Republic of Palau")]
        Palau = 170,
        /// <summary>
        /// The palestine stateof
        /// </summary>
        [JsonProperty("palestineStateof")]
        [Description("The State of Palestine")]
        PalestineStateof = 171,
        /// <summary>
        /// The panama
        /// </summary>
        [JsonProperty("panama")]
        [Description("The Republic of Panamá")]
        Panama = 172,
        /// <summary>
        /// The papua new guinea
        /// </summary>
        [JsonProperty("papuaNewGuinea")]
        [Description("The Independent State of Papua New Guinea")]
        PapuaNewGuinea = 173,
        /// <summary>
        /// The paraguay
        /// </summary>
        [JsonProperty("paraguay")]
        [Description("The Republic of Paraguay")]
        Paraguay = 174,
        /// <summary>
        /// The peru
        /// </summary>
        [JsonProperty("peru")]
        [Description("The Republic of Perú")]
        Peru = 175,
        /// <summary>
        /// The philippinesthe
        /// </summary>
        [JsonProperty("philippinesthe")]
        [Description("The Republic of the Philippines")]
        Philippinesthe = 176,
        /// <summary>
        /// The pitcairn
        /// </summary>
        [JsonProperty("pitcairn")]
        [Description("The Pitcairn, Henderson, Ducie and Oeno Islands")]
        Pitcairn = 177,
        /// <summary>
        /// The poland
        /// </summary>
        [JsonProperty("poland")]
        [Description("The Republic of Poland")]
        Poland = 178,
        /// <summary>
        /// The portugal
        /// </summary>
        [JsonProperty("portugal")]
        [Description("The Portuguese Republic")]
        Portugal = 179,
        /// <summary>
        /// The puerto rico
        /// </summary>
        [JsonProperty("puertoRico")]
        [Description("The Commonwealth of Puerto Rico")]
        PuertoRico = 180,
        /// <summary>
        /// The qatar
        /// </summary>
        [JsonProperty("qatar")]
        [Description("The State of Qatar")]
        Qatar = 181,
        /// <summary>
        /// The réunion
        /// </summary>
        [JsonProperty("réunion")]
        [Description("Réunion")]
        Réunion = 182,
        /// <summary>
        /// The romania
        /// </summary>
        [JsonProperty("romania")]
        [Description("Romania")]
        Romania = 183,
        /// <summary>
        /// The russian federationthe
        /// </summary>
        [JsonProperty("russianFederationthe")]
        [Description("The Russian Federation")]
        RussianFederationthe = 184,
        /// <summary>
        /// The rwanda
        /// </summary>
        [JsonProperty("rwanda")]
        [Description("The Republic of Rwanda")]
        Rwanda = 185,
        /// <summary>
        /// The saint barthélemy
        /// </summary>
        [JsonProperty("saintBarthélemy")]
        [Description("The Collectivity of Saint-Barthélemy")]
        SaintBarthélemy = 186,
        /// <summary>
        /// The saint helena
        /// </summary>
        [JsonProperty("saintHelena")]
        [Description("Saint Helena, Ascension and Tristan da Cunha")]
        SaintHelena = 187,
        /// <summary>
        /// The saint kittsand nevis
        /// </summary>
        [JsonProperty("saintKittsandNevis")]
        [Description("Saint Kitts and Nevis")]
        SaintKittsandNevis = 188,
        /// <summary>
        /// The saint lucia
        /// </summary>
        [JsonProperty("saintLucia")]
        [Description("Saint Lucia")]
        SaintLucia = 189,
        /// <summary>
        /// The saint martin frenchpart
        /// </summary>
        [JsonProperty("saintMartinFrenchpart")]
        [Description("The Collectivity of Saint-Martin")]
        SaintMartinFrenchpart = 190,
        /// <summary>
        /// The saint pierreand miquelon
        /// </summary>
        [JsonProperty("saintPierreandMiquelon")]
        [Description("The Overseas Collectivity of Saint-Pierre and Miquelon")]
        SaintPierreandMiquelon = 191,
        /// <summary>
        /// The saint vincentandthe grenadines
        /// </summary>
        [JsonProperty("saintVincentandtheGrenadines")]
        [Description("Saint Vincent and the Grenadines")]
        SaintVincentandtheGrenadines = 192,
        /// <summary>
        /// The samoa
        /// </summary>
        [JsonProperty("samoa")]
        [Description("The Independent State of Samoa")]
        Samoa = 193,
        /// <summary>
        /// The san marino
        /// </summary>
        [JsonProperty("sanMarino")]
        [Description("The Republic of San Marino")]
        SanMarino = 194,
        /// <summary>
        /// The sao tomeand principe
        /// </summary>
        [JsonProperty("saoTomeandPrincipe")]
        [Description("The Democratic Republic of São Tomé and Príncipe")]
        SaoTomeandPrincipe = 195,
        /// <summary>
        /// The saudi arabia
        /// </summary>
        [JsonProperty("saudiArabia")]
        [Description("The Kingdom of Saudi Arabia")]
        SaudiArabia = 196,
        /// <summary>
        /// The senegal
        /// </summary>
        [JsonProperty("senegal")]
        [Description("The Republic of Senegal")]
        Senegal = 197,
        /// <summary>
        /// The serbia
        /// </summary>
        [JsonProperty("serbia")]
        [Description("The Republic of Serbia")]
        Serbia = 198,
        /// <summary>
        /// The seychelles
        /// </summary>
        [JsonProperty("seychelles")]
        [Description("The Republic of Seychelles")]
        Seychelles = 199,
        /// <summary>
        /// The sierra leone
        /// </summary>
        [JsonProperty("sierraLeone")]
        [Description("The Republic of Sierra Leone")]
        SierraLeone = 200,
        /// <summary>
        /// The singapore
        /// </summary>
        [JsonProperty("singapore")]
        [Description("The Republic of Singapore")]
        Singapore = 201,
        /// <summary>
        /// The sint maarten dutchpart
        /// </summary>
        [JsonProperty("sintMaartenDutchpart")]
        [Description("Sint Maarten")]
        SintMaartenDutchpart = 202,
        /// <summary>
        /// The slovakia
        /// </summary>
        [JsonProperty("slovakia")]
        [Description("The Slovak Republic")]
        Slovakia = 203,
        /// <summary>
        /// The slovenia
        /// </summary>
        [JsonProperty("slovenia")]
        [Description("The Republic of Slovenia")]
        Slovenia = 204,
        /// <summary>
        /// The solomon islands
        /// </summary>
        [JsonProperty("solomonIslands")]
        [Description("The Solomon Islands")]
        SolomonIslands = 205,
        /// <summary>
        /// The somalia
        /// </summary>
        [JsonProperty("somalia")]
        [Description("The Federal Republic of Somalia")]
        Somalia = 206,
        /// <summary>
        /// The south africa
        /// </summary>
        [JsonProperty("southAfrica")]
        [Description("The Republic of South Africa")]
        SouthAfrica = 207,
        /// <summary>
        /// The south georgiaandthe south sandwich islands
        /// </summary>
        [JsonProperty("southGeorgiaandtheSouthSandwichIslands")]
        [Description("South Georgia and the South Sandwich Islands")]
        SouthGeorgiaandtheSouthSandwichIslands = 208,
        /// <summary>
        /// The south sudan
        /// </summary>
        [JsonProperty("southSudan")]
        [Description("The Republic of South Sudan")]
        SouthSudan = 209,
        /// <summary>
        /// The spain
        /// </summary>
        [JsonProperty("spain")]
        [Description("The Kingdom of Spain")]
        Spain = 210,
        /// <summary>
        /// The sri lanka
        /// </summary>
        [JsonProperty("sriLanka")]
        [Description("The Democratic Socialist Republic of Sri Lanka")]
        SriLanka = 211,
        /// <summary>
        /// The sudanthe
        /// </summary>
        [JsonProperty("sudanthe")]
        [Description("The Republic of the Sudan")]
        Sudanthe = 212,
        /// <summary>
        /// The suriname
        /// </summary>
        [JsonProperty("suriname")]
        [Description("The Republic of Suriname")]
        Suriname = 213,
        /// <summary>
        /// The svalbard
        /// </summary>
        [JsonProperty("svalbard")]
        [Description("Svalbard and Jan Mayen")]
        Svalbard = 214,
        /// <summary>
        /// The sweden
        /// </summary>
        [JsonProperty("sweden")]
        [Description("The Kingdom of Sweden")]
        Sweden = 215,
        /// <summary>
        /// The switzerland
        /// </summary>
        [JsonProperty("switzerland")]
        [Description("The Swiss Confederation")]
        Switzerland = 216,
        /// <summary>
        /// The syrian arab republicthe
        /// </summary>
        [JsonProperty("syrianArabRepublicthe")]
        [Description("The Syrian Arab Republic")]
        SyrianArabRepublicthe = 217,
        /// <summary>
        /// The taiwan provinceof china
        /// </summary>
        [JsonProperty("taiwanProvinceofChina")]
        [Description("The Republic of China")]
        TaiwanProvinceofChina = 218,
        /// <summary>
        /// The tajikistan
        /// </summary>
        [JsonProperty("tajikistan")]
        [Description("The Republic of Tajikistan")]
        Tajikistan = 219,
        /// <summary>
        /// The tanzaniathe united republicof
        /// </summary>
        [JsonProperty("tanzaniatheUnitedRepublicof")]
        [Description("The United Republic of Tanzania")]
        TanzaniatheUnitedRepublicof = 220,
        /// <summary>
        /// The thailand
        /// </summary>
        [JsonProperty("thailand")]
        [Description("The Kingdom of Thailand")]
        Thailand = 221,
        /// <summary>
        /// The timor leste
        /// </summary>
        [JsonProperty("timorLeste")]
        [Description("The Democratic Republic of Timor-Leste")]
        TimorLeste = 222,
        /// <summary>
        /// The togo
        /// </summary>
        [JsonProperty("togo")]
        [Description("The Togolese Republic")]
        Togo = 223,
        /// <summary>
        /// The tokelau
        /// </summary>
        [JsonProperty("tokelau")]
        [Description("Tokelau")]
        Tokelau = 224,
        /// <summary>
        /// The tonga
        /// </summary>
        [JsonProperty("tonga")]
        [Description("The Kingdom of Tonga")]
        Tonga = 225,
        /// <summary>
        /// The trinidadand tobago
        /// </summary>
        [JsonProperty("trinidadandTobago")]
        [Description("The Republic of Trinidad and Tobago")]
        TrinidadandTobago = 226,
        /// <summary>
        /// The tunisia
        /// </summary>
        [JsonProperty("tunisia")]
        [Description("The Republic of Tunisia")]
        Tunisia = 227,
        /// <summary>
        /// The turkey
        /// </summary>
        [JsonProperty("turkey")]
        [Description("The Republic of Turkey")]
        Turkey = 228,
        /// <summary>
        /// The turkmenistan
        /// </summary>
        [JsonProperty("turkmenistan")]
        [Description("Turkmenistan")]
        Turkmenistan = 229,
        /// <summary>
        /// The turksand caicos islandsthe
        /// </summary>
        [JsonProperty("turksandCaicosIslandsthe")]
        [Description("The Turks and Caicos Islands")]
        TurksandCaicosIslandsthe = 230,
        /// <summary>
        /// The tuvalu
        /// </summary>
        [JsonProperty("tuvalu")]
        [Description("Tuvalu")]
        Tuvalu = 231,
        /// <summary>
        /// The uganda
        /// </summary>
        [JsonProperty("uganda")]
        [Description("The Republic of Uganda")]
        Uganda = 232,
        /// <summary>
        /// The ukraine
        /// </summary>
        [JsonProperty("ukraine")]
        [Description("Ukraine")]
        Ukraine = 233,
        /// <summary>
        /// The united arab emiratesthe
        /// </summary>
        [JsonProperty("unitedArabEmiratesthe")]
        [Description("The United Arab Emirates")]
        UnitedArabEmiratesthe = 234,
        /// <summary>
        /// The united kingdomof great britainand northern irelandthe
        /// </summary>
        [JsonProperty("unitedKingdomofGreatBritainandNorthernIrelandthe")]
        [Description("The United Kingdom of Great Britain and Northern Ireland")]
        UnitedKingdomofGreatBritainandNorthernIrelandthe = 235,
        /// <summary>
        /// The united states minor outlying islandsthe
        /// </summary>
        [JsonProperty("unitedStatesMinorOutlyingIslandsthe")]
        [Description("Baker&#160;Island")]
        UnitedStatesMinorOutlyingIslandsthe = 236,
        /// <summary>
        /// The united statesof americathe
        /// </summary>
        [JsonProperty("unitedStatesofAmericathe")]
        [Description("The United States of America")]
        UnitedStatesofAmericathe = 237,
        /// <summary>
        /// The uruguay
        /// </summary>
        [JsonProperty("uruguay")]
        [Description("The Oriental Republic of Uruguay")]
        Uruguay = 238,
        /// <summary>
        /// The uzbekistan
        /// </summary>
        [JsonProperty("uzbekistan")]
        [Description("The Republic of Uzbekistan")]
        Uzbekistan = 239,
        /// <summary>
        /// The vanuatu
        /// </summary>
        [JsonProperty("vanuatu")]
        [Description("The Republic of Vanuatu")]
        Vanuatu = 240,
        /// <summary>
        /// The venezuela bolivarian republicof
        /// </summary>
        [JsonProperty("venezuelaBolivarianRepublicof")]
        [Description("The Bolivarian Republic of Venezuela")]
        VenezuelaBolivarianRepublicof = 241,
        /// <summary>
        /// The viet nam
        /// </summary>
        [JsonProperty("vietNam")]
        [Description("The Socialist Republic of Viet Nam")]
        VietNam = 242,
        /// <summary>
        /// The virgin islands british
        /// </summary>
        [JsonProperty("virginIslandsBritish")]
        [Description("The Virgin Islands")]
        VirginIslandsBritish = 243,
        /// <summary>
        /// The virgin islands us
        /// </summary>
        [JsonProperty("virginIslandsUS")]
        [Description("The Virgin Islands of the United States")]
        VirginIslandsUS = 244,
        /// <summary>
        /// The wallisand futuna
        /// </summary>
        [JsonProperty("wallisandFutuna")]
        [Description("The Territory of the Wallis and Futuna Islands")]
        WallisandFutuna = 245,
        /// <summary>
        /// The western sahara
        /// </summary>
        [JsonProperty("westernSahara")]
        [Description("The Sahrawi Arab Democratic Republic")]
        WesternSahara = 246,
        /// <summary>
        /// The yemen
        /// </summary>
        [JsonProperty("yemen")]
        [Description("The Republic of Yemen")]
        Yemen = 247,
        /// <summary>
        /// The zambia
        /// </summary>
        [JsonProperty("zambia")]
        [Description("The Republic of Zambia")]
        Zambia = 248,
        /// <summary>
        /// The zimbabwe
        /// </summary>
        [JsonProperty("zimbabwe")]
        [Description("The Republic of Zimbabwe")]
        Zimbabwe = 249,
    }
}
