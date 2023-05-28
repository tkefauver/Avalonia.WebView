using ObjCRuntime;

namespace AudioToolbox;

public enum AudioFormatType : uint
{
	LinearPCM = 1819304813u,
	AC3 = 1633889587u,
	CAC3 = 1667326771u,
	AppleIMA4 = 1768775988u,
	MPEG4AAC = 1633772320u,
	MPEG4CELP = 1667591280u,
	MPEG4HVXC = 1752594531u,
	MPEG4TwinVQ = 1953986161u,
	MACE3 = 1296122675u,
	MACE6 = 1296122678u,
	ULaw = 1970037111u,
	ALaw = 1634492791u,
	QDesign = 1363430723u,
	QDesign2 = 1363430706u,
	QUALCOMM = 1365470320u,
	MPEGLayer1 = 778924081u,
	MPEGLayer2 = 778924082u,
	MPEGLayer3 = 778924083u,
	TimeCode = 1953066341u,
	MIDIStream = 1835623529u,
	ParameterValueStream = 1634760307u,
	AppleLossless = 1634492771u,
	MPEG4AAC_HE = 1633772392u,
	MPEG4AAC_LD = 1633772396u,
	MPEG4AAC_ELD = 1633772389u,
	MPEG4AAC_ELD_SBR = 1633772390u,
	MPEG4AAC_ELD_V2 = 1633772391u,
	MPEG4AAC_HE_V2 = 1633772400u,
	MPEG4AAC_Spatial = 1633772403u,
	MpegD_Usac = 1970495843u,
	AMR = 1935764850u,
	AMRWideBand = 1935767394u,
	Audible = 1096107074u,
	iLBC = 1768710755u,
	DVIIntelIMA = 1836253201u,
	MicrosoftGSM = 1836253233u,
	AES3 = 1634038579u,
	EnhancedAES3 = 1700998451u,
	Flac = 1718378851u,
	[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
	[NoWatch]
	[iOS(13, 0)]
	[Mac(10, 15)]
	[TV(13, 0)]
	LatmInLoas = 1819238771u,
	Opus = 1869641075u
}