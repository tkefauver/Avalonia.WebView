namespace AudioUnit;

public enum AudioUnitPropertyIDType
{
	ClassInfo = 0,
	MakeConnection = 1,
	SampleRate = 2,
	ParameterList = 3,
	ParameterInfo = 4,
	CPULoad = 6,
	StreamFormat = 8,
	ElementCount = 11,
	Latency = 12,
	SupportedNumChannels = 13,
	MaximumFramesPerSlice = 14,
	ParameterValueStrings = 16,
	AudioChannelLayout = 19,
	TailTime = 20,
	BypassEffect = 21,
	LastRenderError = 22,
	SetRenderCallback = 23,
	FactoryPresets = 24,
	RenderQuality = 26,
	HostCallbacks = 27,
	InPlaceProcessing = 29,
	ElementName = 30,
	SupportedChannelLayoutTags = 32,
	PresentPreset = 36,
	OfflineRender = 37,
	DependentParameters = 45,
	InputSampleInOutput = 49,
	ShouldAllocateBuffer = 51,
	ParameterHistoryInfo = 53,
	Nickname = 54,
	FastDispatch = 5,
	SetExternalBuffer = 15,
	GetUIComponentList = 18,
	ContextName = 25,
	CocoaUI = 31,
	ParameterIDName = 34,
	ParameterClumpName = 35,
	ParameterStringFromValue = 33,
	ParameterValueFromString = 38,
	IconLocation = 39,
	PresentationLatency = 40,
	AUHostIdentifier = 46,
	MIDIOutputCallbackInfo = 47,
	MIDIOutputCallback = 48,
	ClassInfoFromDocument = 50,
	FrequencyResponse = 52,
	CurrentDevice = 2000,
	IsRunning = 2001,
	ChannelMap = 2002,
	EnableIO = 2003,
	StartTime = 2004,
	SetInputCallback = 2005,
	HasIO = 2006,
	StartTimestampsAtZero = 2007
}
