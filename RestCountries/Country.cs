using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace RestCountries
{
    [Serializable, JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Country
    {
		/// <summary>
        /// Afghanistan, AFG
        /// </summary>
        [EnumMember(Value = "AFG")]
        Afghanistan,

        /// <summary>
        /// Albania, ALB
        /// </summary>
        [EnumMember(Value = "ALB")]
        Albania,

        /// <summary>
        /// Algeria, DZA
        /// </summary>
        [EnumMember(Value = "DZA")]
        Algeria,

        /// <summary>
        /// American Samoa, ASM
        /// </summary>
        [EnumMember(Value = "ASM")]
        AmericanSamoa,

        /// <summary>
        /// Andorra, AND
        /// </summary>
        [EnumMember(Value = "AND")]
        Andorra,

        /// <summary>
        /// Angola, AGO
        /// </summary>
        [EnumMember(Value = "AGO")]
        Angola,

        /// <summary>
        /// Anguilla, AIA
        /// </summary>
        [EnumMember(Value = "AIA")]
        Anguilla,

        /// <summary>
        /// Antarctica, ATA
        /// </summary>
        [EnumMember(Value = "ATA")]
        Antarctica,

        /// <summary>
        /// Antigua and Barbuda, ATG
        /// </summary>
        [EnumMember(Value = "ATG")]
        Antiguaand,

        /// <summary>
        /// Argentina, ARG
        /// </summary>
        [EnumMember(Value = "ARG")]
        Argentina,

        /// <summary>
        /// Armenia, ARM
        /// </summary>
        [EnumMember(Value = "ARM")]
        Armenia,

        /// <summary>
        /// Aruba, ABW
        /// </summary>
        [EnumMember(Value = "ABW")]
        Aruba,

        /// <summary>
        /// Australia, AUS
        /// </summary>
        [EnumMember(Value = "AUS")]
        Australia,

        /// <summary>
        /// Austria, AUT
        /// </summary>
        [EnumMember(Value = "AUT")]
        Austria,

        /// <summary>
        /// Azerbaijan, AZE
        /// </summary>
        [EnumMember(Value = "AZE")]
        Azerbaijan,

        /// <summary>
        /// Bahamas (the), BHS
        /// </summary>
        [EnumMember(Value = "BHS")]
        Bahamas,

        /// <summary>
        /// Bahrain, BHR
        /// </summary>
        [EnumMember(Value = "BHR")]
        Bahrain,

        /// <summary>
        /// Bangladesh, BGD
        /// </summary>
        [EnumMember(Value = "BGD")]
        Bangladesh,

        /// <summary>
        /// Barbados, BRB
        /// </summary>
        [EnumMember(Value = "BRB")]
        Barbados,

        /// <summary>
        /// Belarus, BLR
        /// </summary>
        [EnumMember(Value = "BLR")]
        Belarus,

        /// <summary>
        /// Belgium, BEL
        /// </summary>
        [EnumMember(Value = "BEL")]
        Belgium,

        /// <summary>
        /// Belize, BLZ
        /// </summary>
        [EnumMember(Value = "BLZ")]
        Belize,

        /// <summary>
        /// Benin, BEN
        /// </summary>
        [EnumMember(Value = "BEN")]
        Benin,

        /// <summary>
        /// Bermuda, BMU
        /// </summary>
        [EnumMember(Value = "BMU")]
        Bermuda,

        /// <summary>
        /// Bhutan, BTN
        /// </summary>
        [EnumMember(Value = "BTN")]
        Bhutan,

        /// <summary>
        /// Bolivia (Plurinational State of), BOL
        /// </summary>
        [EnumMember(Value = "BOL")]
        Bolivia,

        /// <summary>
        /// Bonaire, Sint Eustatius and Saba, BES
        /// </summary>
        [EnumMember(Value = "BES")]
        BonaireSintEustatiusAndSaba,

        /// <summary>
        /// Bosnia and Herzegovina, BIH
        /// </summary>
        [EnumMember(Value = "BIH")]
        Bosniaand,

        /// <summary>
        /// Botswana, BWA
        /// </summary>
        [EnumMember(Value = "BWA")]
        Botswana,

        /// <summary>
        /// Bouvet Island, BVT
        /// </summary>
        [EnumMember(Value = "BVT")]
        BouvetIsland,

        /// <summary>
        /// Brazil, BRA
        /// </summary>
        [EnumMember(Value = "BRA")]
        Brazil,

        /// <summary>
        /// British Indian Ocean Territory (the), IOT
        /// </summary>
        [EnumMember(Value = "IOT")]
        BritishIndian,

        /// <summary>
        /// Brunei Darussalam, BRN
        /// </summary>
        [EnumMember(Value = "BRN")]
        BruneiDarussalam,

        /// <summary>
        /// Bulgaria, BGR
        /// </summary>
        [EnumMember(Value = "BGR")]
        Bulgaria,

        /// <summary>
        /// Burkina Faso, BFA
        /// </summary>
        [EnumMember(Value = "BFA")]
        BurkinaFaso,

        /// <summary>
        /// Burundi, BDI
        /// </summary>
        [EnumMember(Value = "BDI")]
        Burundi,

        /// <summary>
        /// Cabo Verde, CPV
        /// </summary>
        [EnumMember(Value = "CPV")]
        CaboVerde,

        /// <summary>
        /// Cambodia, KHM
        /// </summary>
        [EnumMember(Value = "KHM")]
        Cambodia,

        /// <summary>
        /// Cameroon, CMR
        /// </summary>
        [EnumMember(Value = "CMR")]
        Cameroon,

        /// <summary>
        /// Canada, CAN
        /// </summary>
        [EnumMember(Value = "CAN")]
        Canada,

        /// <summary>
        /// Cayman Islands (the), CYM
        /// </summary>
        [EnumMember(Value = "CYM")]
        CaymanIslands,

        /// <summary>
        /// Central African Republic (the), CAF
        /// </summary>
        [EnumMember(Value = "CAF")]
        CentralAfrican,

        /// <summary>
        /// Chad, TCD
        /// </summary>
        [EnumMember(Value = "TCD")]
        Chad,

        /// <summary>
        /// Chile, CHL
        /// </summary>
        [EnumMember(Value = "CHL")]
        Chile,

        /// <summary>
        /// China, CHN
        /// </summary>
        [EnumMember(Value = "CHN")]
        China,

        /// <summary>
        /// Christmas Island, CXR
        /// </summary>
        [EnumMember(Value = "CXR")]
        ChristmasIsland,

        /// <summary>
        /// Cocos (Keeling) Islands (the), CCK
        /// </summary>
        [EnumMember(Value = "CCK")]
        CocosKeelingIslands,

        /// <summary>
        /// Colombia, COL
        /// </summary>
        [EnumMember(Value = "COL")]
        Colombia,

        /// <summary>
        /// Comoros (the), COM
        /// </summary>
        [EnumMember(Value = "COM")]
        Comoros,

        /// <summary>
        /// Congo (the Democratic Republic of the), COD
        /// </summary>
        [EnumMember(Value = "COD")]
        DemocraticRepublicOfCongo,

        /// <summary>
        /// Congo (the), COG
        /// </summary>
        [EnumMember(Value = "COG")]
        Congo,

        /// <summary>
        /// Cook Islands (the), COK
        /// </summary>
        [EnumMember(Value = "COK")]
        CookIslands,

        /// <summary>
        /// Costa Rica, CRI
        /// </summary>
        [EnumMember(Value = "CRI")]
        CostaRica,

        /// <summary>
        /// Croatia, HRV
        /// </summary>
        [EnumMember(Value = "HRV")]
        Croatia,

        /// <summary>
        /// Cuba, CUB
        /// </summary>
        [EnumMember(Value = "CUB")]
        Cuba,

        /// <summary>
        /// Curaçao, CUW
        /// </summary>
        [EnumMember(Value = "CUW")]
        Curaçao,

        /// <summary>
        /// Cyprus, CYP
        /// </summary>
        [EnumMember(Value = "CYP")]
        Cyprus,

        /// <summary>
        /// Czechia, CZE
        /// </summary>
        [EnumMember(Value = "CZE")]
        Czechia,

        /// <summary>
        /// Côte d'Ivoire, CIV
        /// </summary>
        [EnumMember(Value = "CIV")]
        CotedIvoire,

        /// <summary>
        /// Denmark, DNK
        /// </summary>
        [EnumMember(Value = "DNK")]
        Denmark,

        /// <summary>
        /// Djibouti, DJI
        /// </summary>
        [EnumMember(Value = "DJI")]
        Djibouti,

        /// <summary>
        /// Dominica, DMA
        /// </summary>
        [EnumMember(Value = "DMA")]
        Dominica,

        /// <summary>
        /// Dominican Republic (the), DOM
        /// </summary>
        [EnumMember(Value = "DOM")]
        DominicanRepublic,

        /// <summary>
        /// Ecuador, ECU
        /// </summary>
        [EnumMember(Value = "ECU")]
        Ecuador,

        /// <summary>
        /// Egypt, EGY
        /// </summary>
        [EnumMember(Value = "EGY")]
        Egypt,

        /// <summary>
        /// El Salvador, SLV
        /// </summary>
        [EnumMember(Value = "SLV")]
        ElSalvador,

        /// <summary>
        /// Equatorial Guinea, GNQ
        /// </summary>
        [EnumMember(Value = "GNQ")]
        EquatorialGuinea,

        /// <summary>
        /// Eritrea, ERI
        /// </summary>
        [EnumMember(Value = "ERI")]
        Eritrea,

        /// <summary>
        /// Estonia, EST
        /// </summary>
        [EnumMember(Value = "EST")]
        Estonia,

        /// <summary>
        /// Eswatini, SWZ
        /// </summary>
        [EnumMember(Value = "SWZ")]
        Eswatini,

        /// <summary>
        /// Ethiopia, ETH
        /// </summary>
        [EnumMember(Value = "ETH")]
        Ethiopia,

        /// <summary>
        /// Falkland Islands (the) [Malvinas], FLK
        /// </summary>
        [EnumMember(Value = "FLK")]
        FalklandIslands,

        /// <summary>
        /// Faroe Islands (the), FRO
        /// </summary>
        [EnumMember(Value = "FRO")]
        FaroeIslands,

        /// <summary>
        /// Fiji, FJI
        /// </summary>
        [EnumMember(Value = "FJI")]
        Fiji,

        /// <summary>
        /// Finland, FIN
        /// </summary>
        [EnumMember(Value = "FIN")]
        Finland,

        /// <summary>
        /// France, FRA
        /// </summary>
        [EnumMember(Value = "FRA")]
        France,

        /// <summary>
        /// French Guiana, GUF
        /// </summary>
        [EnumMember(Value = "GUF")]
        FrenchGuiana,

        /// <summary>
        /// French Polynesia, PYF
        /// </summary>
        [EnumMember(Value = "PYF")]
        FrenchPolynesia,

        /// <summary>
        /// French Southern Territories (the), ATF
        /// </summary>
        [EnumMember(Value = "ATF")]
        FrenchSouthern,

        /// <summary>
        /// Gabon, GAB
        /// </summary>
        [EnumMember(Value = "GAB")]
        Gabon,

        /// <summary>
        /// Gambia (the), GMB
        /// </summary>
        [EnumMember(Value = "GMB")]
        Gambia,

        /// <summary>
        /// Georgia, GEO
        /// </summary>
        [EnumMember(Value = "GEO")]
        Georgia,

        /// <summary>
        /// Germany, DEU
        /// </summary>
        [EnumMember(Value = "DEU")]
        Germany,

        /// <summary>
        /// Ghana, GHA
        /// </summary>
        [EnumMember(Value = "GHA")]
        Ghana,

        /// <summary>
        /// Gibraltar, GIB
        /// </summary>
        [EnumMember(Value = "GIB")]
        Gibraltar,

        /// <summary>
        /// Greece, GRC
        /// </summary>
        [EnumMember(Value = "GRC")]
        Greece,

        /// <summary>
        /// Greenland, GRL
        /// </summary>
        [EnumMember(Value = "GRL")]
        Greenland,

        /// <summary>
        /// Grenada, GRD
        /// </summary>
        [EnumMember(Value = "GRD")]
        Grenada,

        /// <summary>
        /// Guadeloupe, GLP
        /// </summary>
        [EnumMember(Value = "GLP")]
        Guadeloupe,

        /// <summary>
        /// Guam, GUM
        /// </summary>
        [EnumMember(Value = "GUM")]
        Guam,

        /// <summary>
        /// Guatemala, GTM
        /// </summary>
        [EnumMember(Value = "GTM")]
        Guatemala,

        /// <summary>
        /// Guernsey, GGY
        /// </summary>
        [EnumMember(Value = "GGY")]
        Guernsey,

        /// <summary>
        /// Guinea, GIN
        /// </summary>
        [EnumMember(Value = "GIN")]
        Guinea,

        /// <summary>
        /// Guinea-Bissau, GNB
        /// </summary>
        [EnumMember(Value = "GNB")]
        GuineaBissau,

        /// <summary>
        /// Guyana, GUY
        /// </summary>
        [EnumMember(Value = "GUY")]
        Guyana,

        /// <summary>
        /// Haiti, HTI
        /// </summary>
        [EnumMember(Value = "HTI")]
        Haiti,

        /// <summary>
        /// Heard Island and McDonald Islands, HMD
        /// </summary>
        [EnumMember(Value = "HMD")]
        HeardIsland,

        /// <summary>
        /// Holy See (the), VAT
        /// </summary>
        [EnumMember(Value = "VAT")]
        HolySee,

        /// <summary>
        /// Honduras, HND
        /// </summary>
        [EnumMember(Value = "HND")]
        Honduras,

        /// <summary>
        /// Hong Kong, HKG
        /// </summary>
        [EnumMember(Value = "HKG")]
        HongKong,

        /// <summary>
        /// Hungary, HUN
        /// </summary>
        [EnumMember(Value = "HUN")]
        Hungary,

        /// <summary>
        /// Iceland, ISL
        /// </summary>
        [EnumMember(Value = "ISL")]
        Iceland,

        /// <summary>
        /// India, IND
        /// </summary>
        [EnumMember(Value = "IND")]
        India,

        /// <summary>
        /// Indonesia, IDN
        /// </summary>
        [EnumMember(Value = "IDN")]
        Indonesia,

        /// <summary>
        /// Iran (Islamic Republic of), IRN
        /// </summary>
        [EnumMember(Value = "IRN")]
        IslamicRepublicOfIran,

        /// <summary>
        /// Iraq, IRQ
        /// </summary>
        [EnumMember(Value = "IRQ")]
        Iraq,

        /// <summary>
        /// Ireland, IRL
        /// </summary>
        [EnumMember(Value = "IRL")]
        Ireland,

        /// <summary>
        /// Isle of Man, IMN
        /// </summary>
        [EnumMember(Value = "IMN")]
        Isleof,

        /// <summary>
        /// Israel, ISR
        /// </summary>
        [EnumMember(Value = "ISR")]
        Israel,

        /// <summary>
        /// Italy, ITA
        /// </summary>
        [EnumMember(Value = "ITA")]
        Italy,

        /// <summary>
        /// Jamaica, JAM
        /// </summary>
        [EnumMember(Value = "JAM")]
        Jamaica,

        /// <summary>
        /// Japan, JPN
        /// </summary>
        [EnumMember(Value = "JPN")]
        Japan,

        /// <summary>
        /// Jersey, JEY
        /// </summary>
        [EnumMember(Value = "JEY")]
        Jersey,

        /// <summary>
        /// Jordan, JOR
        /// </summary>
        [EnumMember(Value = "JOR")]
        Jordan,

        /// <summary>
        /// Kazakhstan, KAZ
        /// </summary>
        [EnumMember(Value = "KAZ")]
        Kazakhstan,

        /// <summary>
        /// Kenya, KEN
        /// </summary>
        [EnumMember(Value = "KEN")]
        Kenya,

        /// <summary>
        /// Kiribati, KIR
        /// </summary>
        [EnumMember(Value = "KIR")]
        Kiribati,

        /// <summary>
        /// Korea (the Democratic People's Republic of), PRK
        /// </summary>
        [EnumMember(Value = "PRK")]
        DemocraticRepublicOfKorea,

        /// <summary>
        /// Korea (the Republic of), KOR
        /// </summary>
        [EnumMember(Value = "KOR")]
        RepublicOfKorea,

        /// <summary>
        /// Kuwait, KWT
        /// </summary>
        [EnumMember(Value = "KWT")]
        Kuwait,

        /// <summary>
        /// Kyrgyzstan, KGZ
        /// </summary>
        [EnumMember(Value = "KGZ")]
        Kyrgyzstan,

        /// <summary>
        /// Lao People's Democratic Republic (the), LAO
        /// </summary>
        [EnumMember(Value = "LAO")]
        LaoPeoples,

        /// <summary>
        /// Latvia, LVA
        /// </summary>
        [EnumMember(Value = "LVA")]
        Latvia,

        /// <summary>
        /// Lebanon, LBN
        /// </summary>
        [EnumMember(Value = "LBN")]
        Lebanon,

        /// <summary>
        /// Lesotho, LSO
        /// </summary>
        [EnumMember(Value = "LSO")]
        Lesotho,

        /// <summary>
        /// Liberia, LBR
        /// </summary>
        [EnumMember(Value = "LBR")]
        Liberia,

        /// <summary>
        /// Libya, LBY
        /// </summary>
        [EnumMember(Value = "LBY")]
        Libya,

        /// <summary>
        /// Liechtenstein, LIE
        /// </summary>
        [EnumMember(Value = "LIE")]
        Liechtenstein,

        /// <summary>
        /// Lithuania, LTU
        /// </summary>
        [EnumMember(Value = "LTU")]
        Lithuania,

        /// <summary>
        /// Luxembourg, LUX
        /// </summary>
        [EnumMember(Value = "LUX")]
        Luxembourg,

        /// <summary>
        /// Macao, MAC
        /// </summary>
        [EnumMember(Value = "MAC")]
        Macao,

        /// <summary>
        /// Madagascar, MDG
        /// </summary>
        [EnumMember(Value = "MDG")]
        Madagascar,

        /// <summary>
        /// Malawi, MWI
        /// </summary>
        [EnumMember(Value = "MWI")]
        Malawi,

        /// <summary>
        /// Malaysia, MYS
        /// </summary>
        [EnumMember(Value = "MYS")]
        Malaysia,

        /// <summary>
        /// Maldives, MDV
        /// </summary>
        [EnumMember(Value = "MDV")]
        Maldives,

        /// <summary>
        /// Mali, MLI
        /// </summary>
        [EnumMember(Value = "MLI")]
        Mali,

        /// <summary>
        /// Malta, MLT
        /// </summary>
        [EnumMember(Value = "MLT")]
        Malta,

        /// <summary>
        /// Marshall Islands (the), MHL
        /// </summary>
        [EnumMember(Value = "MHL")]
        MarshallIslands,

        /// <summary>
        /// Martinique, MTQ
        /// </summary>
        [EnumMember(Value = "MTQ")]
        Martinique,

        /// <summary>
        /// Mauritania, MRT
        /// </summary>
        [EnumMember(Value = "MRT")]
        Mauritania,

        /// <summary>
        /// Mauritius, MUS
        /// </summary>
        [EnumMember(Value = "MUS")]
        Mauritius,

        /// <summary>
        /// Mayotte, MYT
        /// </summary>
        [EnumMember(Value = "MYT")]
        Mayotte,

        /// <summary>
        /// Mexico, MEX
        /// </summary>
        [EnumMember(Value = "MEX")]
        Mexico,

        /// <summary>
        /// Micronesia (Federated States of), FSM
        /// </summary>
        [EnumMember(Value = "FSM")]
        FederatedStatesOfMicronesia,

        /// <summary>
        /// Moldova (the Republic of), MDA
        /// </summary>
        [EnumMember(Value = "MDA")]
        RepublicOfMoldova,

        /// <summary>
        /// Monaco, MCO
        /// </summary>
        [EnumMember(Value = "MCO")]
        Monaco,

        /// <summary>
        /// Mongolia, MNG
        /// </summary>
        [EnumMember(Value = "MNG")]
        Mongolia,

        /// <summary>
        /// Montenegro, MNE
        /// </summary>
        [EnumMember(Value = "MNE")]
        Montenegro,

        /// <summary>
        /// Montserrat, MSR
        /// </summary>
        [EnumMember(Value = "MSR")]
        Montserrat,

        /// <summary>
        /// Morocco, MAR
        /// </summary>
        [EnumMember(Value = "MAR")]
        Morocco,

        /// <summary>
        /// Mozambique, MOZ
        /// </summary>
        [EnumMember(Value = "MOZ")]
        Mozambique,

        /// <summary>
        /// Myanmar, MMR
        /// </summary>
        [EnumMember(Value = "MMR")]
        Myanmar,

        /// <summary>
        /// Namibia, NAM
        /// </summary>
        [EnumMember(Value = "NAM")]
        Namibia,

        /// <summary>
        /// Nauru, NRU
        /// </summary>
        [EnumMember(Value = "NRU")]
        Nauru,

        /// <summary>
        /// Nepal, NPL
        /// </summary>
        [EnumMember(Value = "NPL")]
        Nepal,

        /// <summary>
        /// Netherlands (the), NLD
        /// </summary>
        [EnumMember(Value = "NLD")]
        Netherlands,

        /// <summary>
        /// New Caledonia, NCL
        /// </summary>
        [EnumMember(Value = "NCL")]
        NewCaledonia,

        /// <summary>
        /// New Zealand, NZL
        /// </summary>
        [EnumMember(Value = "NZL")]
        NewZealand,

        /// <summary>
        /// Nicaragua, NIC
        /// </summary>
        [EnumMember(Value = "NIC")]
        Nicaragua,

        /// <summary>
        /// Niger (the), NER
        /// </summary>
        [EnumMember(Value = "NER")]
        Niger,

        /// <summary>
        /// Nigeria, NGA
        /// </summary>
        [EnumMember(Value = "NGA")]
        Nigeria,

        /// <summary>
        /// Niue, NIU
        /// </summary>
        [EnumMember(Value = "NIU")]
        Niue,

        /// <summary>
        /// Norfolk Island, NFK
        /// </summary>
        [EnumMember(Value = "NFK")]
        NorfolkIsland,

        /// <summary>
        /// Northern Mariana Islands (the), MNP
        /// </summary>
        [EnumMember(Value = "MNP")]
        NorthernMariana,

        /// <summary>
        /// Norway, NOR
        /// </summary>
        [EnumMember(Value = "NOR")]
        Norway,

        /// <summary>
        /// Oman, OMN
        /// </summary>
        [EnumMember(Value = "OMN")]
        Oman,

        /// <summary>
        /// Pakistan, PAK
        /// </summary>
        [EnumMember(Value = "PAK")]
        Pakistan,

        /// <summary>
        /// Palau, PLW
        /// </summary>
        [EnumMember(Value = "PLW")]
        Palau,

        /// <summary>
        /// Palestine, PSE
        /// </summary>
        [EnumMember(Value = "PSE")]
        Palestine,

        /// <summary>
        /// Panama, PAN
        /// </summary>
        [EnumMember(Value = "PAN")]
        Panama,

        /// <summary>
        /// Papua New Guinea, PNG
        /// </summary>
        [EnumMember(Value = "PNG")]
        PapuaNew,

        /// <summary>
        /// Paraguay, PRY
        /// </summary>
        [EnumMember(Value = "PRY")]
        Paraguay,

        /// <summary>
        /// Peru, PER
        /// </summary>
        [EnumMember(Value = "PER")]
        Peru,

        /// <summary>
        /// Philippines (the), PHL
        /// </summary>
        [EnumMember(Value = "PHL")]
        Philippines,

        /// <summary>
        /// Pitcairn, PCN
        /// </summary>
        [EnumMember(Value = "PCN")]
        Pitcairn,

        /// <summary>
        /// Poland, POL
        /// </summary>
        [EnumMember(Value = "POL")]
        Poland,

        /// <summary>
        /// Portugal, PRT
        /// </summary>
        [EnumMember(Value = "PRT")]
        Portugal,

        /// <summary>
        /// Puerto Rico, PRI
        /// </summary>
        [EnumMember(Value = "PRI")]
        PuertoRico,

        /// <summary>
        /// Qatar, QAT
        /// </summary>
        [EnumMember(Value = "QAT")]
        Qatar,

        /// <summary>
        /// Republic of North Macedonia, MKD
        /// </summary>
        [EnumMember(Value = "MKD")]
        Republicof,

        /// <summary>
        /// Romania, ROU
        /// </summary>
        [EnumMember(Value = "ROU")]
        Romania,

        /// <summary>
        /// Russian Federation (the), RUS
        /// </summary>
        [EnumMember(Value = "RUS")]
        RussianFederation,

        /// <summary>
        /// Rwanda, RWA
        /// </summary>
        [EnumMember(Value = "RWA")]
        Rwanda,

        /// <summary>
        /// Réunion, REU
        /// </summary>
        [EnumMember(Value = "REU")]
        Réunion,

        /// <summary>
        /// Saint Barthélemy, BLM
        /// </summary>
        [EnumMember(Value = "BLM")]
        SaintBarthélemy,

        /// <summary>
        /// Saint Helena, Ascension and Tristan da Cunha, SHN
        /// </summary>
        [EnumMember(Value = "SHN")]
        SaintHelena,

        /// <summary>
        /// Saint Kitts and Nevis, KNA
        /// </summary>
        [EnumMember(Value = "KNA")]
        SaintKitts,

        /// <summary>
        /// Saint Lucia, LCA
        /// </summary>
        [EnumMember(Value = "LCA")]
        SaintLucia,

        /// <summary>
        /// Saint Martin (French part), MAF
        /// </summary>
        [EnumMember(Value = "MAF")]
        SaintMartin,

        /// <summary>
        /// Saint Pierre and Miquelon, SPM
        /// </summary>
        [EnumMember(Value = "SPM")]
        SaintPierre,

        /// <summary>
        /// Saint Vincent and the Grenadines, VCT
        /// </summary>
        [EnumMember(Value = "VCT")]
        SaintVincent,

        /// <summary>
        /// Samoa, WSM
        /// </summary>
        [EnumMember(Value = "WSM")]
        Samoa,

        /// <summary>
        /// San Marino, SMR
        /// </summary>
        [EnumMember(Value = "SMR")]
        SanMarino,

        /// <summary>
        /// Sao Tome and Principe, STP
        /// </summary>
        [EnumMember(Value = "STP")]
        SaoTome,

        /// <summary>
        /// Saudi Arabia, SAU
        /// </summary>
        [EnumMember(Value = "SAU")]
        SaudiArabia,

        /// <summary>
        /// Senegal, SEN
        /// </summary>
        [EnumMember(Value = "SEN")]
        Senegal,

        /// <summary>
        /// Serbia, SRB
        /// </summary>
        [EnumMember(Value = "SRB")]
        Serbia,

        /// <summary>
        /// Seychelles, SYC
        /// </summary>
        [EnumMember(Value = "SYC")]
        Seychelles,

        /// <summary>
        /// Sierra Leone, SLE
        /// </summary>
        [EnumMember(Value = "SLE")]
        SierraLeone,

        /// <summary>
        /// Singapore, SGP
        /// </summary>
        [EnumMember(Value = "SGP")]
        Singapore,

        /// <summary>
        /// Sint Maarten (Dutch part), SXM
        /// </summary>
        [EnumMember(Value = "SXM")]
        SintMaarten,

        /// <summary>
        /// Slovakia, SVK
        /// </summary>
        [EnumMember(Value = "SVK")]
        Slovakia,

        /// <summary>
        /// Slovenia, SVN
        /// </summary>
        [EnumMember(Value = "SVN")]
        Slovenia,

        /// <summary>
        /// Solomon Islands, SLB
        /// </summary>
        [EnumMember(Value = "SLB")]
        SolomonIslands,

        /// <summary>
        /// Somalia, SOM
        /// </summary>
        [EnumMember(Value = "SOM")]
        Somalia,

        /// <summary>
        /// South Africa, ZAF
        /// </summary>
        [EnumMember(Value = "ZAF")]
        SouthAfrica,

        /// <summary>
        /// South Georgia and the South Sandwich Islands, SGS
        /// </summary>
        [EnumMember(Value = "SGS")]
        SouthGeorgia,

        /// <summary>
        /// South Sudan, SSD
        /// </summary>
        [EnumMember(Value = "SSD")]
        SouthSudan,

        /// <summary>
        /// Spain, ESP
        /// </summary>
        [EnumMember(Value = "ESP")]
        Spain,

        /// <summary>
        /// Sri Lanka, LKA
        /// </summary>
        [EnumMember(Value = "LKA")]
        SriLanka,

        /// <summary>
        /// Sudan (the), SDN
        /// </summary>
        [EnumMember(Value = "SDN")]
        Sudan,

        /// <summary>
        /// Suriname, SUR
        /// </summary>
        [EnumMember(Value = "SUR")]
        Suriname,

        /// <summary>
        /// Svalbard and Jan Mayen, SJM
        /// </summary>
        [EnumMember(Value = "SJM")]
        Svalbardand,

        /// <summary>
        /// Sweden, SWE
        /// </summary>
        [EnumMember(Value = "SWE")]
        Sweden,

        /// <summary>
        /// Switzerland, CHE
        /// </summary>
        [EnumMember(Value = "CHE")]
        Switzerland,

        /// <summary>
        /// Syrian Arab Republic, SYR
        /// </summary>
        [EnumMember(Value = "SYR")]
        SyrianArab,

        /// <summary>
        /// Taiwan, TWN
        /// </summary>
        [EnumMember(Value = "TWN")]
        Taiwan,

        /// <summary>
        /// Tajikistan, TJK
        /// </summary>
        [EnumMember(Value = "TJK")]
        Tajikistan,

        /// <summary>
        /// United Republic of Tanzania, TZA
        /// </summary>
        [EnumMember(Value = "TZA")]
        Tanzania,

        /// <summary>
        /// Thailand, THA
        /// </summary>
        [EnumMember(Value = "THA")]
        Thailand,

        /// <summary>
        /// Timor-Leste, TLS
        /// </summary>
        [EnumMember(Value = "TLS")]
        TimorLeste,

        /// <summary>
        /// Togo, TGO
        /// </summary>
        [EnumMember(Value = "TGO")]
        Togo,

        /// <summary>
        /// Tokelau, TKL
        /// </summary>
        [EnumMember(Value = "TKL")]
        Tokelau,

        /// <summary>
        /// Tonga, TON
        /// </summary>
        [EnumMember(Value = "TON")]
        Tonga,

        /// <summary>
        /// Trinidad and Tobago, TTO
        /// </summary>
        [EnumMember(Value = "TTO")]
        Trinidadand,

        /// <summary>
        /// Tunisia, TUN
        /// </summary>
        [EnumMember(Value = "TUN")]
        Tunisia,

        /// <summary>
        /// Turkey, TUR
        /// </summary>
        [EnumMember(Value = "TUR")]
        Turkey,

        /// <summary>
        /// Turkmenistan, TKM
        /// </summary>
        [EnumMember(Value = "TKM")]
        Turkmenistan,

        /// <summary>
        /// Turks and Caicos Islands (the), TCA
        /// </summary>
        [EnumMember(Value = "TCA")]
        Turksand,

        /// <summary>
        /// Tuvalu, TUV
        /// </summary>
        [EnumMember(Value = "TUV")]
        Tuvalu,

        /// <summary>
        /// Uganda, UGA
        /// </summary>
        [EnumMember(Value = "UGA")]
        Uganda,

        /// <summary>
        /// Ukraine, UKR
        /// </summary>
        [EnumMember(Value = "UKR")]
        Ukraine,

        /// <summary>
        /// United Arab Emirates (the), ARE
        /// </summary>
        [EnumMember(Value = "ARE")]
        UnitedArab,

        /// <summary>
        /// United Kingdom of Great Britain and Northern Ireland (the), GBR
        /// </summary>
        [EnumMember(Value = "GBR")]
        UnitedKingdom,

        /// <summary>
        /// United States Outlying Islands (the), UMI
        /// </summary>
        [EnumMember(Value = "UMI")]
        UnitedStatesOutlyingIslands,

        /// <summary>
        /// United States of America (the), USA
        /// </summary>
        [EnumMember(Value = "USA")]
        UnitedStates,

        /// <summary>
        /// Uruguay, URY
        /// </summary>
        [EnumMember(Value = "URY")]
        Uruguay,

        /// <summary>
        /// Uzbekistan, UZB
        /// </summary>
        [EnumMember(Value = "UZB")]
        Uzbekistan,

        /// <summary>
        /// Vanuatu, VUT
        /// </summary>
        [EnumMember(Value = "VUT")]
        Vanuatu,

        /// <summary>
        /// Venezuela (Bolivarian Republic of), VEN
        /// </summary>
        [EnumMember(Value = "VEN")]
        Venezuela,

        /// <summary>
        /// Viet Nam, VNM
        /// </summary>
        [EnumMember(Value = "VNM")]
        VietNam,

        /// <summary>
        /// Virgin Islands (British), VGB
        /// </summary>
        [EnumMember(Value = "VGB")]
        BritishVirginIslands,

        /// <summary>
        /// Virgin Islands (U.S.), VIR
        /// </summary>
        [EnumMember(Value = "VIR")]
        USVirginIslands,

        /// <summary>
        /// Wallis and Futuna, WLF
        /// </summary>
        [EnumMember(Value = "WLF")]
        Wallisand,

        /// <summary>
        /// Western Sahara, ESH
        /// </summary>
        [EnumMember(Value = "ESH")]
        WesternSahara,

        /// <summary>
        /// Yemen, YEM
        /// </summary>
        [EnumMember(Value = "YEM")]
        Yemen,

        /// <summary>
        /// Zambia, ZMB
        /// </summary>
        [EnumMember(Value = "ZMB")]
        Zambia,

        /// <summary>
        /// Zimbabwe, ZWE
        /// </summary>
        [EnumMember(Value = "ZWE")]
        Zimbabwe,

        /// <summary>
        /// Åland Islands, ALA
        /// </summary>
        [EnumMember(Value = "ALA")]
        AlandIslands
    }
}
