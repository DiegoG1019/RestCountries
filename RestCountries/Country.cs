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
        [EnumMember(Value = "AFG")]
		AFG,

		[EnumMember(Value = "ALA")]
		ALA,

		[EnumMember(Value = "ALB")]
		ALB,

		[EnumMember(Value = "DZA")]
		DZA,

		[EnumMember(Value = "ASM")]
		ASM,

		[EnumMember(Value = "AND")]
		AND,

		[EnumMember(Value = "AGO")]
		AGO,

		[EnumMember(Value = "AIA")]
		AIA,

		[EnumMember(Value = "ATA")]
		ATA,

		[EnumMember(Value = "ATG")]
		ATG,

		[EnumMember(Value = "ARG")]
		ARG,

		[EnumMember(Value = "ARM")]
		ARM,

		[EnumMember(Value = "ABW")]
		ABW,

		[EnumMember(Value = "AUS")]
		AUS,

		[EnumMember(Value = "AUT")]
		AUT,

		[EnumMember(Value = "AZE")]
		AZE,

		[EnumMember(Value = "BHS")]
		BHS,

		[EnumMember(Value = "BHR")]
		BHR,

		[EnumMember(Value = "BGD")]
		BGD,

		[EnumMember(Value = "BRB")]
		BRB,

		[EnumMember(Value = "BLR")]
		BLR,

		[EnumMember(Value = "BEL")]
		BEL,

		[EnumMember(Value = "BLZ")]
		BLZ,

		[EnumMember(Value = "BEN")]
		BEN,

		[EnumMember(Value = "BMU")]
		BMU,

		[EnumMember(Value = "BTN")]
		BTN,

		[EnumMember(Value = "BOL")]
		BOL,

		[EnumMember(Value = "BES")]
		BES,

		[EnumMember(Value = "BIH")]
		BIH,

		[EnumMember(Value = "BWA")]
		BWA,

		[EnumMember(Value = "BVT")]
		BVT,

		[EnumMember(Value = "BRA")]
		BRA,

		[EnumMember(Value = "IOT")]
		IOT,

		[EnumMember(Value = "UMI")]
		UMI,

		[EnumMember(Value = "VGB")]
		VGB,

		[EnumMember(Value = "VIR")]
		VIR,

		[EnumMember(Value = "BRN")]
		BRN,

		[EnumMember(Value = "BGR")]
		BGR,

		[EnumMember(Value = "BFA")]
		BFA,

		[EnumMember(Value = "BDI")]
		BDI,

		[EnumMember(Value = "KHM")]
		KHM,

		[EnumMember(Value = "CMR")]
		CMR,

		[EnumMember(Value = "CAN")]
		CAN,

		[EnumMember(Value = "CPV")]
		CPV,

		[EnumMember(Value = "CYM")]
		CYM,

		[EnumMember(Value = "CAF")]
		CAF,

		[EnumMember(Value = "TCD")]
		TCD,

		[EnumMember(Value = "CHL")]
		CHL,

		[EnumMember(Value = "CHN")]
		CHN,

		[EnumMember(Value = "CXR")]
		CXR,

		[EnumMember(Value = "CCK")]
		CCK,

		[EnumMember(Value = "COL")]
		COL,

		[EnumMember(Value = "COM")]
		COM,

		[EnumMember(Value = "COG")]
		COG,

		[EnumMember(Value = "COD")]
		COD,

		[EnumMember(Value = "COK")]
		COK,

		[EnumMember(Value = "CRI")]
		CRI,

		[EnumMember(Value = "HRV")]
		HRV,

		[EnumMember(Value = "CUB")]
		CUB,

		[EnumMember(Value = "CUW")]
		CUW,

		[EnumMember(Value = "CYP")]
		CYP,

		[EnumMember(Value = "CZE")]
		CZE,

		[EnumMember(Value = "DNK")]
		DNK,

		[EnumMember(Value = "DJI")]
		DJI,

		[EnumMember(Value = "DMA")]
		DMA,

		[EnumMember(Value = "DOM")]
		DOM,

		[EnumMember(Value = "ECU")]
		ECU,

		[EnumMember(Value = "EGY")]
		EGY,

		[EnumMember(Value = "SLV")]
		SLV,

		[EnumMember(Value = "GNQ")]
		GNQ,

		[EnumMember(Value = "ERI")]
		ERI,

		[EnumMember(Value = "EST")]
		EST,

		[EnumMember(Value = "ETH")]
		ETH,

		[EnumMember(Value = "FLK")]
		FLK,

		[EnumMember(Value = "FRO")]
		FRO,

		[EnumMember(Value = "FJI")]
		FJI,

		[EnumMember(Value = "FIN")]
		FIN,

		[EnumMember(Value = "FRA")]
		FRA,

		[EnumMember(Value = "GUF")]
		GUF,

		[EnumMember(Value = "PYF")]
		PYF,

		[EnumMember(Value = "ATF")]
		ATF,

		[EnumMember(Value = "GAB")]
		GAB,

		[EnumMember(Value = "GMB")]
		GMB,

		[EnumMember(Value = "GEO")]
		GEO,

		[EnumMember(Value = "DEU")]
		DEU,

		[EnumMember(Value = "GHA")]
		GHA,

		[EnumMember(Value = "GIB")]
		GIB,

		[EnumMember(Value = "GRC")]
		GRC,

		[EnumMember(Value = "GRL")]
		GRL,

		[EnumMember(Value = "GRD")]
		GRD,

		[EnumMember(Value = "GLP")]
		GLP,

		[EnumMember(Value = "GUM")]
		GUM,

		[EnumMember(Value = "GTM")]
		GTM,

		[EnumMember(Value = "GGY")]
		GGY,

		[EnumMember(Value = "GIN")]
		GIN,

		[EnumMember(Value = "GNB")]
		GNB,

		[EnumMember(Value = "GUY")]
		GUY,

		[EnumMember(Value = "HTI")]
		HTI,

		[EnumMember(Value = "HMD")]
		HMD,

		[EnumMember(Value = "VAT")]
		VAT,

		[EnumMember(Value = "HND")]
		HND,

		[EnumMember(Value = "HKG")]
		HKG,

		[EnumMember(Value = "HUN")]
		HUN,

		[EnumMember(Value = "ISL")]
		ISL,

		[EnumMember(Value = "IND")]
		IND,

		[EnumMember(Value = "IDN")]
		IDN,

		[EnumMember(Value = "CIV")]
		CIV,

		[EnumMember(Value = "IRN")]
		IRN,

		[EnumMember(Value = "IRQ")]
		IRQ,

		[EnumMember(Value = "IRL")]
		IRL,

		[EnumMember(Value = "IMN")]
		IMN,

		[EnumMember(Value = "ISR")]
		ISR,

		[EnumMember(Value = "ITA")]
		ITA,

		[EnumMember(Value = "JAM")]
		JAM,

		[EnumMember(Value = "JPN")]
		JPN,

		[EnumMember(Value = "JEY")]
		JEY,

		[EnumMember(Value = "JOR")]
		JOR,

		[EnumMember(Value = "KAZ")]
		KAZ,

		[EnumMember(Value = "KEN")]
		KEN,

		[EnumMember(Value = "KIR")]
		KIR,

		[EnumMember(Value = "KWT")]
		KWT,

		[EnumMember(Value = "KGZ")]
		KGZ,

		[EnumMember(Value = "LAO")]
		LAO,

		[EnumMember(Value = "LVA")]
		LVA,

		[EnumMember(Value = "LBN")]
		LBN,

		[EnumMember(Value = "LSO")]
		LSO,

		[EnumMember(Value = "LBR")]
		LBR,

		[EnumMember(Value = "LBY")]
		LBY,

		[EnumMember(Value = "LIE")]
		LIE,

		[EnumMember(Value = "LTU")]
		LTU,

		[EnumMember(Value = "LUX")]
		LUX,

		[EnumMember(Value = "MAC")]
		MAC,

		[EnumMember(Value = "MKD")]
		MKD,

		[EnumMember(Value = "MDG")]
		MDG,

		[EnumMember(Value = "MWI")]
		MWI,

		[EnumMember(Value = "MYS")]
		MYS,

		[EnumMember(Value = "MDV")]
		MDV,

		[EnumMember(Value = "MLI")]
		MLI,

		[EnumMember(Value = "MLT")]
		MLT,

		[EnumMember(Value = "MHL")]
		MHL,

		[EnumMember(Value = "MTQ")]
		MTQ,

		[EnumMember(Value = "MRT")]
		MRT,

		[EnumMember(Value = "MUS")]
		MUS,

		[EnumMember(Value = "MYT")]
		MYT,

		[EnumMember(Value = "MEX")]
		MEX,

		[EnumMember(Value = "FSM")]
		FSM,

		[EnumMember(Value = "MDA")]
		MDA,

		[EnumMember(Value = "MCO")]
		MCO,

		[EnumMember(Value = "MNG")]
		MNG,

		[EnumMember(Value = "MNE")]
		MNE,

		[EnumMember(Value = "MSR")]
		MSR,

		[EnumMember(Value = "MAR")]
		MAR,

		[EnumMember(Value = "MOZ")]
		MOZ,

		[EnumMember(Value = "MMR")]
		MMR,

		[EnumMember(Value = "NAM")]
		NAM,

		[EnumMember(Value = "NRU")]
		NRU,

		[EnumMember(Value = "NPL")]
		NPL,

		[EnumMember(Value = "NLD")]
		NLD,

		[EnumMember(Value = "NCL")]
		NCL,

		[EnumMember(Value = "NZL")]
		NZL,

		[EnumMember(Value = "NIC")]
		NIC,

		[EnumMember(Value = "NER")]
		NER,

		[EnumMember(Value = "NGA")]
		NGA,

		[EnumMember(Value = "NIU")]
		NIU,

		[EnumMember(Value = "NFK")]
		NFK,

		[EnumMember(Value = "PRK")]
		PRK,

		[EnumMember(Value = "MNP")]
		MNP,

		[EnumMember(Value = "NOR")]
		NOR,

		[EnumMember(Value = "OMN")]
		OMN,

		[EnumMember(Value = "PAK")]
		PAK,

		[EnumMember(Value = "PLW")]
		PLW,

		[EnumMember(Value = "PSE")]
		PSE,

		[EnumMember(Value = "PAN")]
		PAN,

		[EnumMember(Value = "PNG")]
		PNG,

		[EnumMember(Value = "PRY")]
		PRY,

		[EnumMember(Value = "PER")]
		PER,

		[EnumMember(Value = "PHL")]
		PHL,

		[EnumMember(Value = "PCN")]
		PCN,

		[EnumMember(Value = "POL")]
		POL,

		[EnumMember(Value = "PRT")]
		PRT,

		[EnumMember(Value = "PRI")]
		PRI,

		[EnumMember(Value = "QAT")]
		QAT,

		[EnumMember(Value = "KOS")]
		KOS,

		[EnumMember(Value = "REU")]
		REU,

		[EnumMember(Value = "ROU")]
		ROU,

		[EnumMember(Value = "RUS")]
		RUS,

		[EnumMember(Value = "RWA")]
		RWA,

		[EnumMember(Value = "BLM")]
		BLM,

		[EnumMember(Value = "SHN")]
		SHN,

		[EnumMember(Value = "KNA")]
		KNA,

		[EnumMember(Value = "LCA")]
		LCA,

		[EnumMember(Value = "MAF")]
		MAF,

		[EnumMember(Value = "SPM")]
		SPM,

		[EnumMember(Value = "VCT")]
		VCT,

		[EnumMember(Value = "WSM")]
		WSM,

		[EnumMember(Value = "SMR")]
		SMR,

		[EnumMember(Value = "STP")]
		STP,

		[EnumMember(Value = "SAU")]
		SAU,

		[EnumMember(Value = "SEN")]
		SEN,

		[EnumMember(Value = "SRB")]
		SRB,

		[EnumMember(Value = "SYC")]
		SYC,

		[EnumMember(Value = "SLE")]
		SLE,

		[EnumMember(Value = "SGP")]
		SGP,

		[EnumMember(Value = "SXM")]
		SXM,

		[EnumMember(Value = "SVK")]
		SVK,

		[EnumMember(Value = "SVN")]
		SVN,

		[EnumMember(Value = "SLB")]
		SLB,

		[EnumMember(Value = "SOM")]
		SOM,

		[EnumMember(Value = "ZAF")]
		ZAF,

		[EnumMember(Value = "SGS")]
		SGS,

		[EnumMember(Value = "KOR")]
		KOR,

		[EnumMember(Value = "SSD")]
		SSD,

		[EnumMember(Value = "ESP")]
		ESP,

		[EnumMember(Value = "LKA")]
		LKA,

		[EnumMember(Value = "SDN")]
		SDN,

		[EnumMember(Value = "SUR")]
		SUR,

		[EnumMember(Value = "SJM")]
		SJM,

		[EnumMember(Value = "SWZ")]
		SWZ,

		[EnumMember(Value = "SWE")]
		SWE,

		[EnumMember(Value = "CHE")]
		CHE,

		[EnumMember(Value = "SYR")]
		SYR,

		[EnumMember(Value = "TWN")]
		TWN,

		[EnumMember(Value = "TJK")]
		TJK,

		[EnumMember(Value = "TZA")]
		TZA,

		[EnumMember(Value = "THA")]
		THA,

		[EnumMember(Value = "TLS")]
		TLS,

		[EnumMember(Value = "TGO")]
		TGO,

		[EnumMember(Value = "TKL")]
		TKL,

		[EnumMember(Value = "TON")]
		TON,

		[EnumMember(Value = "TTO")]
		TTO,

		[EnumMember(Value = "TUN")]
		TUN,

		[EnumMember(Value = "TUR")]
		TUR,

		[EnumMember(Value = "TKM")]
		TKM,

		[EnumMember(Value = "TCA")]
		TCA,

		[EnumMember(Value = "TUV")]
		TUV,

		[EnumMember(Value = "UGA")]
		UGA,

		[EnumMember(Value = "UKR")]
		UKR,

		[EnumMember(Value = "ARE")]
		ARE,

		[EnumMember(Value = "GBR")]
		GBR,

		[EnumMember(Value = "USA")]
		USA,

		[EnumMember(Value = "URY")]
		URY,

		[EnumMember(Value = "UZB")]
		UZB,

		[EnumMember(Value = "VUT")]
		VUT,

		[EnumMember(Value = "VEN")]
		VEN,

		[EnumMember(Value = "VNM")]
		VNM,

		[EnumMember(Value = "WLF")]
		WLF,

		[EnumMember(Value = "ESH")]
		ESH,

		[EnumMember(Value = "YEM")]
		YEM,

		[EnumMember(Value = "ZMB")]
		ZMB,

		[EnumMember(Value = "ZWE")]
		ZWE,
    }
}
