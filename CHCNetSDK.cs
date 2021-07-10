using System;
using System.Runtime.InteropServices;

namespace VMS_Ares.SDKs.Saphire
{
	public class CHCNetSDK
	{
		public struct NET_DVR_SUBSYSTEMINFO
		{
			public byte bySubSystemType;

			public byte byChan;

			public byte byLoginType;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;

			public NET_DVR_IPADDR struSubSystemIP;

			public ushort wSubSystemPort;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;

			public NET_DVR_IPADDR struSubSystemIPMask;

			public NET_DVR_IPADDR struGatewayIpAddr;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] sUserName;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] sPassword;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
			public string sDomainName;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
			public string sDnsAddress;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
			public byte[] sSerialNumber;
		}

		public struct NET_DVR_ALLSUBSYSTEMINFO
		{
			public uint dwSize;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 80, ArraySubType = UnmanagedType.Struct)]
			public NET_DVR_SUBSYSTEMINFO[] struSubSystemInfo;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		public struct NET_DVR_LOOPPLAN_SUBCFG
		{
			public uint dwSize;

			public uint dwPoolTime;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.Struct)]
			public NET_DVR_MATRIX_CHAN_INFO_V30[] struChanConInfo;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		public struct NET_DVR_LOOPPLAN_ARRAYCFG
		{
			public uint dwSize;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.Struct)]
			public NET_DVR_LOOPPLAN_SUBCFG[] struLoopPlanSubCfg;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		public struct NET_DVR_ALARMMODECFG
		{
			public uint dwSize;

			public byte byAlarmMode;

			public ushort wLoopTime;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 9, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		public struct NET_DVR_CODESYSTEMINFO
		{
			public byte bySerialNum;

			public byte byChan;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
		}

		public struct NET_DVR_CODESPLITTERINFO
		{
			public uint dwSize;

			public NET_DVR_IPADDR struIP;

			public ushort wPort;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] sUserName;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] sPassword;

			public byte byChan;

			public byte by485Port;

			public ushort wBaudRate;

			public byte byDataBit;

			public byte byStopBit;

			public byte byParity;

			public byte byFlowControl;

			public ushort wDecoderType;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}

		public struct NET_DVR_CODESPLITTERCFG
		{
			public uint dwSize;

			public NET_DVR_CODESYSTEMINFO struCodeSubsystemInfo;

			public NET_DVR_CODESPLITTERINFO struCodeSplitterInfo;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		public struct NET_DVR_ASSOCIATECFG
		{
			public byte byAssociateType;

			public ushort wAlarmDelay;

			public byte byAlarmNum;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		public struct NET_DVR_DYNAMICDECODE
		{
			public uint dwSize;

			public NET_DVR_ASSOCIATECFG struAssociateCfg;

			public NET_DVR_PU_STREAM_CFG struPuStreamCfg;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		public struct NET_DVR_DECODESCHED
		{
			public NET_DVR_SCHEDTIME struSchedTime;

			public byte byDecodeType;

			public byte byLoopGroup;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;

			public NET_DVR_PU_STREAM_CFG struDynamicDec;
		}

		public struct NET_DVR_PLANDECODE
		{
			public uint dwSize;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 28, ArraySubType = UnmanagedType.Struct)]
			public NET_DVR_DECODESCHED[] struDecodeSched;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
			public byte[] byres;
		}

		public struct NET_DVR_VIDEOPLATFORM_ABILITY
		{
			public uint dwSize;

			public byte byCodeSubSystemNums;

			public byte byDecodeSubSystemNums;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
			public byte[] byWindowMode;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		public struct NET_DVR_TIME
		{
			public uint dwYear;

			public uint dwMonth;

			public uint dwDay;

			public uint dwHour;

			public uint dwMinute;

			public uint dwSecond;
		}

		public struct NET_DVR_SCHEDTIME
		{
			public byte byStartHour;

			public byte byStartMin;

			public byte byStopHour;

			public byte byStopMin;
		}

		public struct NET_DVR_HANDLEEXCEPTION_V30
		{
			public uint dwHandleType;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 96, ArraySubType = UnmanagedType.I1)]
			public byte[] byRelAlarmOut;
		}

		public struct NET_DVR_HANDLEEXCEPTION
		{
			public uint dwHandleType;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
			public byte[] byRelAlarmOut;
		}

		public struct NET_DVR_DEVICECFG
		{
			public uint dwSize;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] sDVRName;

			public uint dwDVRID;

			public uint dwRecycleRecord;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 48, ArraySubType = UnmanagedType.I1)]
			public byte[] sSerialNumber;

			public uint dwSoftwareVersion;

			public uint dwSoftwareBuildDate;

			public uint dwDSPSoftwareVersion;

			public uint dwDSPSoftwareBuildDate;

			public uint dwPanelVersion;

			public uint dwHardwareVersion;

			public byte byAlarmInPortNum;

			public byte byAlarmOutPortNum;

			public byte byRS232Num;

			public byte byRS485Num;

			public byte byNetworkPortNum;

			public byte byDiskCtrlNum;

			public byte byDiskNum;

			public byte byDVRType;

			public byte byChanNum;

			public byte byStartChan;

			public byte byDecordChans;

			public byte byVGANum;

			public byte byUSBNum;

			public byte byAuxoutNum;

			public byte byAudioNum;

			public byte byIPChanNum;
		}

		public struct NET_DVR_IPADDR
		{
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sIpV4;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;

			public void Init()
			{
				byRes = new byte[128];
			}
		}

		public struct NET_DVR_ETHERNET_V30
		{
			public NET_DVR_IPADDR struDVRIP;

			public NET_DVR_IPADDR struDVRIPMask;

			public uint dwNetInterface;

			public ushort wDVRPort;

			public ushort wMTU;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
			public byte[] byMACAddr;
		}

		public struct NET_DVR_ETHERNET
		{
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sDVRIP;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sDVRIPMask;

			public uint dwNetInterface;

			public ushort wDVRPort;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
			public byte[] byMACAddr;
		}

		public struct NET_DVR_PPPOECFG
		{
			public uint dwPPPOE;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] sPPPoEUser;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sPPPoEPassword;

			public NET_DVR_IPADDR struPPPoEIP;
		}

		public struct NET_DVR_NETCFG_V30
		{
			public uint dwSize;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.Struct)]
			public NET_DVR_ETHERNET_V30[] struEtherNet;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.Struct)]
			public NET_DVR_IPADDR[] struRes1;

			public NET_DVR_IPADDR struAlarmHostIpAddr;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.U2)]
			public ushort[] wRes2;

			public ushort wAlarmHostIpPort;

			public byte byUseDhcp;

			public byte byRes3;

			public NET_DVR_IPADDR struDnsServer1IpAddr;

			public NET_DVR_IPADDR struDnsServer2IpAddr;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byIpResolver;

			public ushort wIpResolverPort;

			public ushort wHttpPortNo;

			public NET_DVR_IPADDR struMulticastIpAddr;

			public NET_DVR_IPADDR struGatewayIpAddr;

			public NET_DVR_PPPOECFG struPPPoE;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		public struct NET_DVR_NETCFG
		{
			public uint dwSize;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.Struct)]
			public NET_DVR_ETHERNET[] struEtherNet;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sManageHostIP;

			public ushort wManageHostPort;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sIPServerIP;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sMultiCastIP;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sGatewayIP;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sNFSIP;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
			public byte[] sNFSDirectory;

			public uint dwPPPOE;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] sPPPoEUser;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sPPPoEPassword;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sPPPoEIP;

			public ushort wHttpPort;
		}

		public struct NET_DVR_MOTION_V30
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6144, ArraySubType = UnmanagedType.I1)]
			public byte[] byMotionScope;

			public byte byMotionSensitive;

			public byte byEnableHandleMotion;

			public byte byPrecision;

			public byte reservedData;

			public NET_DVR_HANDLEEXCEPTION_V30 struMotionHandleType;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 56, ArraySubType = UnmanagedType.Struct)]
			public NET_DVR_SCHEDTIME[] struAlarmTime;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byRelRecordChan;
		}

		public struct NET_DVR_MOTION
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 396, ArraySubType = UnmanagedType.I1)]
			public byte[] byMotionScope;

			public byte byMotionSensitive;

			public byte byEnableHandleMotion;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
			public string reservedData;

			public NET_DVR_HANDLEEXCEPTION strMotionHandleType;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 28, ArraySubType = UnmanagedType.Struct)]
			public NET_DVR_SCHEDTIME[] struAlarmTime;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byRelRecordChan;
		}

		public struct NET_DVR_HIDEALARM_V30
		{
			public uint dwEnableHideAlarm;

			public ushort wHideAlarmAreaTopLeftX;

			public ushort wHideAlarmAreaTopLeftY;

			public ushort wHideAlarmAreaWidth;

			public ushort wHideAlarmAreaHeight;

			public NET_DVR_HANDLEEXCEPTION_V30 strHideAlarmHandleType;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 56, ArraySubType = UnmanagedType.Struct)]
			public NET_DVR_SCHEDTIME[] struAlarmTime;
		}

		public struct NET_DVR_HIDEALARM
		{
			public uint dwEnableHideAlarm;

			public ushort wHideAlarmAreaTopLeftX;

			public ushort wHideAlarmAreaTopLeftY;

			public ushort wHideAlarmAreaWidth;

			public ushort wHideAlarmAreaHeight;

			public NET_DVR_HANDLEEXCEPTION strHideAlarmHandleType;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 28, ArraySubType = UnmanagedType.Struct)]
			public NET_DVR_SCHEDTIME[] struAlarmTime;
		}

		public struct NET_DVR_VILOST_V30
		{
			public byte byEnableHandleVILost;

			public NET_DVR_HANDLEEXCEPTION_V30 strVILostHandleType;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 56, ArraySubType = UnmanagedType.Struct)]
			public NET_DVR_SCHEDTIME[] struAlarmTime;
		}

		public struct NET_DVR_VILOST
		{
			public byte byEnableHandleVILost;

			public NET_DVR_HANDLEEXCEPTION strVILostHandleType;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 56, ArraySubType = UnmanagedType.Struct)]
			public NET_DVR_SCHEDTIME[] struAlarmTime;
		}

		public struct NET_DVR_SHELTER
		{
			public ushort wHideAreaTopLeftX;

			public ushort wHideAreaTopLeftY;

			public ushort wHideAreaWidth;

			public ushort wHideAreaHeight;
		}

		public struct NET_DVR_COLOR
		{
			public byte byBrightness;

			public byte byContrast;

			public byte bySaturation;

			public byte byHue;
		}

		public struct NET_DVR_PICCFG_V30
		{
			public uint dwSize;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] sChanName;

			public uint dwVideoFormat;

			public NET_DVR_COLOR struColor;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 60)]
			public string reservedData;

			public uint dwShowChanName;

			public ushort wShowNameTopLeftX;

			public ushort wShowNameTopLeftY;

			public NET_DVR_VILOST_V30 struVILost;

			public NET_DVR_VILOST_V30 struRes;

			public NET_DVR_MOTION_V30 struMotion;

			public NET_DVR_HIDEALARM_V30 struHideAlarm;

			public uint dwEnableHide;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.Struct)]
			public NET_DVR_SHELTER[] struShelter;

			public uint dwShowOsd;

			public ushort wOSDTopLeftX;

			public ushort wOSDTopLeftY;

			public byte byOSDType;

			public byte byDispWeek;

			public byte byOSDAttrib;

			public byte byHourOSDType;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		public struct NET_DVR_PICCFG_EX
		{
			public uint dwSize;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] sChanName;

			public uint dwVideoFormat;

			public byte byBrightness;

			public byte byContrast;

			public byte bySaturation;

			public byte byHue;

			public uint dwShowChanName;

			public ushort wShowNameTopLeftX;

			public ushort wShowNameTopLeftY;

			public NET_DVR_VILOST struVILost;

			public NET_DVR_MOTION struMotion;

			public NET_DVR_HIDEALARM struHideAlarm;

			public uint dwEnableHide;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.Struct)]
			public NET_DVR_SHELTER[] struShelter;

			public uint dwShowOsd;

			public ushort wOSDTopLeftX;

			public ushort wOSDTopLeftY;

			public byte byOSDType;

			public byte byDispWeek;

			public byte byOSDAttrib;

			public byte byHourOsdType;
		}

		public struct NET_DVR_PICCFG
		{
			public uint dwSize;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] sChanName;

			public uint dwVideoFormat;

			public byte byBrightness;

			public byte byContrast;

			public byte bySaturation;

			public byte byHue;

			public uint dwShowChanName;

			public ushort wShowNameTopLeftX;

			public ushort wShowNameTopLeftY;

			public NET_DVR_VILOST struVILost;

			public NET_DVR_MOTION struMotion;

			public NET_DVR_HIDEALARM struHideAlarm;

			public uint dwEnableHide;

			public ushort wHideAreaTopLeftX;

			public ushort wHideAreaTopLeftY;

			public ushort wHideAreaWidth;

			public ushort wHideAreaHeight;

			public uint dwShowOsd;

			public ushort wOSDTopLeftX;

			public ushort wOSDTopLeftY;

			public byte byOSDType;

			public byte byDispWeek;

			public byte byOSDAttrib;

			public byte reservedData2;
		}

		public struct NET_DVR_COMPRESSION_INFO_V30
		{
			public byte byStreamType;

			public byte byResolution;

			public byte byBitrateType;

			public byte byPicQuality;

			public uint dwVideoBitrate;

			public uint dwVideoFrameRate;

			public ushort wIntervalFrameI;

			public byte byIntervalBPFrame;

			public byte byres1;

			public byte byVideoEncType;

			public byte byAudioEncType;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 10, ArraySubType = UnmanagedType.I1)]
			public byte[] byres;
		}

		public struct NET_DVR_COMPRESSIONCFG_V30
		{
			public uint dwSize;

			public NET_DVR_COMPRESSION_INFO_V30 struNormHighRecordPara;

			public NET_DVR_COMPRESSION_INFO_V30 struRes;

			public NET_DVR_COMPRESSION_INFO_V30 struEventRecordPara;

			public NET_DVR_COMPRESSION_INFO_V30 struNetPara;
		}

		public struct NET_DVR_COMPRESSION_INFO
		{
			public byte byStreamType;

			public byte byResolution;

			public byte byBitrateType;

			public byte byPicQuality;

			public uint dwVideoBitrate;

			public uint dwVideoFrameRate;
		}

		public struct NET_DVR_COMPRESSIONCFG
		{
			public uint dwSize;

			public NET_DVR_COMPRESSION_INFO struRecordPara;

			public NET_DVR_COMPRESSION_INFO struNetPara;
		}

		public struct NET_DVR_COMPRESSION_INFO_EX
		{
			public byte byStreamType;

			public byte byResolution;

			public byte byBitrateType;

			public byte byPicQuality;

			public uint dwVideoBitrate;

			public uint dwVideoFrameRate;

			public ushort wIntervalFrameI;

			public byte byIntervalBPFrame;

			public byte byRes;
		}

		public struct NET_DVR_COMPRESSIONCFG_EX
		{
			public uint dwSize;

			public NET_DVR_COMPRESSION_INFO_EX struRecordPara;

			public NET_DVR_COMPRESSION_INFO_EX struNetPara;
		}

		public struct NET_DVR_RECORDSCHED
		{
			public NET_DVR_SCHEDTIME struRecordTime;

			public byte byRecordType;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
			public string reservedData;
		}

		public struct NET_DVR_RECORDDAY
		{
			public ushort wAllDayRecord;

			public byte byRecordType;

			public byte reservedData;
		}

		public struct NET_DVR_RECORD_V30
		{
			public uint dwSize;

			public uint dwRecord;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 7, ArraySubType = UnmanagedType.Struct)]
			public NET_DVR_RECORDDAY[] struRecAllDay;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 56, ArraySubType = UnmanagedType.Struct)]
			public NET_DVR_RECORDSCHED[] struRecordSched;

			public uint dwRecordTime;

			public uint dwPreRecordTime;

			public uint dwRecorderDuration;

			public byte byRedundancyRec;

			public byte byAudioRec;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 10, ArraySubType = UnmanagedType.I1)]
			public byte[] byReserve;
		}

		public struct NET_DVR_RECORD
		{
			public uint dwSize;

			public uint dwRecord;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 7, ArraySubType = UnmanagedType.Struct)]
			public NET_DVR_RECORDDAY[] struRecAllDay;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 28, ArraySubType = UnmanagedType.Struct)]
			public NET_DVR_RECORDSCHED[] struRecordSched;

			public uint dwRecordTime;

			public uint dwPreRecordTime;
		}

		public struct NET_DVR_PTZ_PROTOCOL
		{
			public uint dwType;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byDescribe;
		}

		public struct NET_DVR_PTZCFG
		{
			public uint dwSize;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 200, ArraySubType = UnmanagedType.Struct)]
			public NET_DVR_PTZ_PROTOCOL[] struPtz;

			public uint dwPtzNum;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		public struct NET_DVR_DECODERCFG_V30
		{
			public uint dwSize;

			public uint dwBaudRate;

			public byte byDataBit;

			public byte byStopBit;

			public byte byParity;

			public byte byFlowcontrol;

			public ushort wDecoderType;

			public ushort wDecoderAddress;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 256, ArraySubType = UnmanagedType.I1)]
			public byte[] bySetPreset;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 256, ArraySubType = UnmanagedType.I1)]
			public byte[] bySetCruise;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 256, ArraySubType = UnmanagedType.I1)]
			public byte[] bySetTrack;
		}

		public struct NET_DVR_DECODERCFG
		{
			public uint dwSize;

			public uint dwBaudRate;

			public byte byDataBit;

			public byte byStopBit;

			public byte byParity;

			public byte byFlowcontrol;

			public ushort wDecoderType;

			public ushort wDecoderAddress;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
			public byte[] bySetPreset;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
			public byte[] bySetCruise;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
			public byte[] bySetTrack;
		}

		public struct NET_DVR_PPPCFG_V30
		{
			public NET_DVR_IPADDR struRemoteIP;

			public NET_DVR_IPADDR struLocalIP;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sLocalIPMask;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] sUsername;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] sPassword;

			public byte byPPPMode;

			public byte byRedial;

			public byte byRedialMode;

			public byte byDataEncrypt;

			public uint dwMTU;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
			public string sTelephoneNumber;
		}

		public struct NET_DVR_PPPCFG
		{
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sRemoteIP;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sLocalIP;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sLocalIPMask;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] sUsername;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] sPassword;

			public byte byPPPMode;

			public byte byRedial;

			public byte byRedialMode;

			public byte byDataEncrypt;

			public uint dwMTU;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
			public string sTelephoneNumber;
		}

		public struct NET_DVR_SINGLE_RS232
		{
			public uint dwBaudRate;

			public byte byDataBit;

			public byte byStopBit;

			public byte byParity;

			public byte byFlowcontrol;

			public uint dwWorkMode;
		}

		public struct NET_DVR_RS232CFG_V30
		{
			public uint dwSize;

			public NET_DVR_SINGLE_RS232 struRs232;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 84, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;

			public NET_DVR_PPPCFG_V30 struPPPConfig;
		}

		public struct NET_DVR_RS232CFG
		{
			public uint dwSize;

			public uint dwBaudRate;

			public byte byDataBit;

			public byte byStopBit;

			public byte byParity;

			public byte byFlowcontrol;

			public uint dwWorkMode;

			public NET_DVR_PPPCFG struPPPConfig;
		}

		public struct NET_DVR_PLATE_INFO
		{
			public byte byPlateType;

			public byte byColor;

			public byte byBright;

			public byte byLicenseLen;

			public byte byEntireBelieve;

			public byte byRegion;

			public byte byCountry;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 33, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;

			public NET_VCA_RECT struPlateRect;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sLicense;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byBelieve;
		}

		public struct NET_DVR_VEHICLE_INFO
		{
			public uint dwIndex;

			public byte byVehicleType;

			public byte byColorDepth;

			public byte byColor;

			public byte byRadarState;

			public ushort wSpeed;

			public ushort wLength;

			public byte byIllegalType;

			public byte byVehicleLogoRecog;

			public byte byVehicleSubLogoRecog;

			public byte byVehicleModel;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byCustomInfo;

			public ushort wVehicleLogoRecog;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 14, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes3;
		}

		public struct NET_DVR_TIME_V30
		{
			public ushort wYear;

			public byte byMonth;

			public byte byDay;

			public byte byHour;

			public byte byMinute;

			public byte bySecond;

			public byte byRes;

			public ushort wMilliSec;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
		}

		public struct NET_ITS_PICTURE_INFO
		{
			public uint dwDataLen;

			public byte byType;

			public byte byDataType;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;

			public uint dwRedLightTime;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byAbsTime;

			public NET_VCA_RECT struPlateRect;

			public NET_VCA_RECT struPlateRecgRect;

			public IntPtr pBuffer;

			public uint dwUTCTime;

			public byte byCompatibleAblity;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 7, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}

		public struct NET_DVR_CAPTURE_UPLOAD
		{
			public uint dwSize;

			public NET_DVR_TIME_V30 struTime;

			public uint dwChannel;

			public string szDevName;

			public byte dwPicLen;

			public byte pBuffer;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 124, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		public struct NET_ITS_PLATE_RESULT
		{
			public uint dwSize;

			public uint dwMatchNo;

			public byte byGroupNum;

			public byte byPicNo;

			public byte bySecondCam;

			public byte byFeaturePicNo;

			public byte byDriveChan;

			public byte byVehicleType;

			public byte byDetSceneID;

			public byte byVehicleAttribute;

			public ushort wIllegalType;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
			public byte[] byIllegalSubType;

			public byte byPostPicNo;

			public byte byChanIndex;

			public ushort wSpeedLimit;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;

			public NET_DVR_PLATE_INFO struPlateInfo;

			public NET_DVR_VEHICLE_INFO struVehicleInfo;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 48, ArraySubType = UnmanagedType.I1)]
			public byte[] byMonitoringSiteID;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 48, ArraySubType = UnmanagedType.I1)]
			public byte[] byDeviceID;

			public byte byDir;

			public byte byDetectType;

			public byte byRelaLaneDirectionType;

			public byte byCarDirectionType;

			public uint dwCustomIllegalType;

			public byte pIllegalInfoBuf;

			public byte byIllegalFromatType;

			public byte byPendant;

			public byte byDataAnalysis;

			public byte byYellowLabelCar;

			public byte byDangerousVehicles;

			public byte byPilotSafebelt;

			public byte byCopilotSafebelt;

			public byte byPilotSunVisor;

			public byte byCopilotSunVisor;

			public byte byPilotCall;

			public byte byBarrierGateCtrlType;

			public byte byAlarmDataType;

			public NET_DVR_TIME_V30 struSnapFirstPicTime;

			public uint dwIllegalTime;

			public uint dwPicNum;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.Struct)]
			public NET_ITS_PICTURE_INFO[] struPicInfo;
		}

		public struct NET_DVR_ALARMINCFG_V30
		{
			public uint dwSize;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] sAlarmInName;

			public byte byAlarmType;

			public byte byAlarmInHandle;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;

			public NET_DVR_HANDLEEXCEPTION_V30 struAlarmHandleType;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 56, ArraySubType = UnmanagedType.Struct)]
			public NET_DVR_SCHEDTIME[] struAlarmTime;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byRelRecordChan;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byEnablePreset;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byPresetNo;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 192, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byEnableCruise;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byCruiseNo;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byEnablePtzTrack;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byPTZTrack;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes3;
		}

		public struct NET_DVR_ALARMINCFG
		{
			public uint dwSize;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] sAlarmInName;

			public byte byAlarmType;

			public byte byAlarmInHandle;

			public NET_DVR_HANDLEEXCEPTION struAlarmHandleType;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 28, ArraySubType = UnmanagedType.Struct)]
			public NET_DVR_SCHEDTIME[] struAlarmTime;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byRelRecordChan;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byEnablePreset;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byPresetNo;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byEnableCruise;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byCruiseNo;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byEnablePtzTrack;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byPTZTrack;
		}

		public struct NET_DVR_ALARMINFO_V30
		{
			public int dwAlarmType;

			public int dwAlarmInputNumber;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 96, ArraySubType = UnmanagedType.I1)]
			public byte[] byAlarmOutputNumber;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byAlarmRelateChannel;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byChannel;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 33, ArraySubType = UnmanagedType.I1)]
			public byte[] byDiskNumber;

			public void Init()
			{
				dwAlarmType = 0;
				dwAlarmInputNumber = 0;
				byAlarmRelateChannel = new byte[64];
				byChannel = new byte[64];
				byAlarmOutputNumber = new byte[96];
				byDiskNumber = new byte[33];
				for (int i = 0; i < 64; i++)
				{
					byAlarmRelateChannel[i] = Convert.ToByte(0);
					byChannel[i] = Convert.ToByte(0);
				}
				for (int j = 0; j < 96; j++)
				{
					byAlarmOutputNumber[j] = Convert.ToByte(0);
				}
				for (int k = 0; k < 33; k++)
				{
					byDiskNumber[k] = Convert.ToByte(0);
				}
			}

			public void Reset()
			{
				dwAlarmType = 0;
				dwAlarmInputNumber = 0;
				for (int i = 0; i < 64; i++)
				{
					byAlarmRelateChannel[i] = Convert.ToByte(0);
					byChannel[i] = Convert.ToByte(0);
				}
				for (int j = 0; j < 96; j++)
				{
					byAlarmOutputNumber[j] = Convert.ToByte(0);
				}
				for (int k = 0; k < 33; k++)
				{
					byDiskNumber[k] = Convert.ToByte(0);
				}
			}
		}

		public struct NET_DVR_ALARMINFO
		{
			public int dwAlarmType;

			public int dwAlarmInputNumber;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.U4)]
			public int[] dwAlarmOutputNumber;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.U4)]
			public int[] dwAlarmRelateChannel;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.U4)]
			public int[] dwChannel;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.U4)]
			public int[] dwDiskNumber;

			public void Init()
			{
				dwAlarmType = 0;
				dwAlarmInputNumber = 0;
				dwAlarmOutputNumber = new int[4];
				dwAlarmRelateChannel = new int[16];
				dwChannel = new int[16];
				dwDiskNumber = new int[16];
				for (int i = 0; i < 4; i++)
				{
					dwAlarmOutputNumber[i] = 0;
				}
				for (int j = 0; j < 16; j++)
				{
					dwAlarmRelateChannel[j] = 0;
					dwChannel[j] = 0;
				}
				for (int k = 0; k < 16; k++)
				{
					dwDiskNumber[k] = 0;
				}
			}

			public void Reset()
			{
				dwAlarmType = 0;
				dwAlarmInputNumber = 0;
				for (int i = 0; i < 4; i++)
				{
					dwAlarmOutputNumber[i] = 0;
				}
				for (int j = 0; j < 16; j++)
				{
					dwAlarmRelateChannel[j] = 0;
					dwChannel[j] = 0;
				}
				for (int k = 0; k < 16; k++)
				{
					dwDiskNumber[k] = 0;
				}
			}
		}

		public struct NET_DVR_IPDEVINFO
		{
			public uint dwEnable;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] sUserName;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] sPassword;

			public NET_DVR_IPADDR struIP;

			public ushort wDVRPort;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 34, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;

			public void Init()
			{
				sUserName = new byte[32];
				sPassword = new byte[16];
				byRes = new byte[34];
			}
		}

		public struct tagNET_DVR_IPDEVINFO_V31
		{
			public byte byEnable;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] sUserName;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] sPassword;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byDomain;

			public NET_DVR_IPADDR struIP;

			public ushort wDVRPort;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 34, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;

			public void Init()
			{
				byRes1 = new byte[3];
				sUserName = new byte[32];
				sPassword = new byte[16];
				byDomain = new byte[64];
				byRes2 = new byte[34];
			}
		}

		public struct NET_DVR_IPCHANINFO
		{
			public byte byEnable;

			public byte byIPID;

			public byte byChannel;

			public byte byProType;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;

			public void Init()
			{
				byRes = new byte[32];
			}
		}

		public struct NET_DVR_IPPARACFG
		{
			public uint dwSize;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.Struct)]
			public NET_DVR_IPDEVINFO[] struIPDevInfo;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byAnalogChanEnable;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.Struct)]
			public NET_DVR_IPCHANINFO[] struIPChanInfo;

			public void Init()
			{
				int num = 0;
				struIPDevInfo = new NET_DVR_IPDEVINFO[32];
				for (num = 0; num < 32; num++)
				{
					struIPDevInfo[num].Init();
				}
				byAnalogChanEnable = new byte[32];
				struIPChanInfo = new NET_DVR_IPCHANINFO[32];
				for (num = 0; num < 32; num++)
				{
					struIPChanInfo[num].Init();
				}
			}
		}

		public struct NET_DVR_IPPARACFG_V31
		{
			public uint dwSize;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.Struct)]
			public tagNET_DVR_IPDEVINFO_V31[] struIPDevInfo;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byAnalogChanEnable;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.Struct)]
			public NET_DVR_IPCHANINFO[] struIPChanInfo;

			public void Init()
			{
				int num = 0;
				struIPDevInfo = new tagNET_DVR_IPDEVINFO_V31[32];
				for (num = 0; num < 32; num++)
				{
					struIPDevInfo[num].Init();
				}
				byAnalogChanEnable = new byte[32];
				struIPChanInfo = new NET_DVR_IPCHANINFO[32];
				for (num = 0; num < 32; num++)
				{
					struIPChanInfo[num].Init();
				}
			}
		}

		public struct NET_DVR_IPALARMOUTINFO
		{
			public byte byIPID;

			public byte byAlarmOut;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 18, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;

			public void Init()
			{
				byRes = new byte[18];
			}
		}

		public struct NET_DVR_IPALARMOUTCFG
		{
			public uint dwSize;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.Struct)]
			public NET_DVR_IPALARMOUTINFO[] struIPAlarmOutInfo;

			public void Init()
			{
				struIPAlarmOutInfo = new NET_DVR_IPALARMOUTINFO[64];
				for (int i = 0; i < 64; i++)
				{
					struIPAlarmOutInfo[i].Init();
				}
			}
		}

		public struct NET_DVR_IPALARMININFO
		{
			public byte byIPID;

			public byte byAlarmIn;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 18, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		public struct NET_DVR_IPALARMINCFG
		{
			public uint dwSize;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.Struct)]
			public NET_DVR_IPALARMININFO[] struIPAlarmInInfo;
		}

		public struct tagNET_DVR_IPALARMINFO
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.Struct)]
			public NET_DVR_IPDEVINFO[] struIPDevInfo;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byAnalogChanEnable;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.Struct)]
			public NET_DVR_IPCHANINFO[] struIPChanInfo;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.Struct)]
			public NET_DVR_IPALARMININFO[] struIPAlarmInInfo;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.Struct)]
			public NET_DVR_IPALARMOUTINFO[] struIPAlarmOutInfo;
		}

		public struct tagNET_DVR_IPALARMINFO_V31
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.Struct)]
			public tagNET_DVR_IPDEVINFO_V31[] struIPDevInfo;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byAnalogChanEnable;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.Struct)]
			public NET_DVR_IPCHANINFO[] struIPChanInfo;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.Struct)]
			public NET_DVR_IPALARMININFO[] struIPAlarmInInfo;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.Struct)]
			public NET_DVR_IPALARMOUTINFO[] struIPAlarmOutInfo;
		}

		public enum HD_STAT
		{
			HD_STAT_OK,
			HD_STAT_UNFORMATTED,
			HD_STAT_ERROR,
			HD_STAT_SMART_FAILED,
			HD_STAT_MISMATCH,
			HD_STAT_IDLE,
			NET_HD_STAT_OFFLINE
		}

		public struct NET_DVR_SINGLE_HD
		{
			public uint dwHDNo;

			public uint dwCapacity;

			public uint dwFreeSpace;

			public uint dwHdStatus;

			public byte byHDAttr;

			public byte byHDType;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;

			public uint dwHdGroup;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 120, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}

		public struct NET_DVR_HDCFG
		{
			public uint dwSize;

			public uint dwHDCount;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 33, ArraySubType = UnmanagedType.Struct)]
			public NET_DVR_SINGLE_HD[] struHDInfo;
		}

		public struct NET_DVR_SINGLE_HDGROUP
		{
			public uint dwHDGroupNo;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byHDGroupChans;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		public struct NET_DVR_HDGROUP_CFG
		{
			public uint dwSize;

			public uint dwHDGroupCount;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.Struct)]
			public NET_DVR_SINGLE_HDGROUP[] struHDGroupAttr;
		}

		public struct NET_DVR_SCALECFG
		{
			public uint dwSize;

			public uint dwMajorScale;

			public uint dwMinorScale;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.U4)]
			public uint[] dwRes;
		}

		public struct NET_DVR_ALARMOUTCFG_V30
		{
			public uint dwSize;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] sAlarmOutName;

			public uint dwAlarmOutDelay;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 56, ArraySubType = UnmanagedType.Struct)]
			public NET_DVR_SCHEDTIME[] struAlarmOutTime;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		public struct NET_DVR_ALARMOUTCFG
		{
			public uint dwSize;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] sAlarmOutName;

			public uint dwAlarmOutDelay;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 28, ArraySubType = UnmanagedType.Struct)]
			public NET_DVR_SCHEDTIME[] struAlarmOutTime;
		}

		public struct NET_DVR_PREVIEWCFG_V30
		{
			public uint dwSize;

			public byte byPreviewNumber;

			public byte byEnableAudio;

			public ushort wSwitchTime;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 256, ArraySubType = UnmanagedType.I1)]
			public byte[] bySwitchSeq;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		public struct NET_DVR_PREVIEWCFG
		{
			public uint dwSize;

			public byte byPreviewNumber;

			public byte byEnableAudio;

			public ushort wSwitchTime;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] bySwitchSeq;
		}

		public struct NET_DVR_VGAPARA
		{
			public ushort wResolution;

			public ushort wFreq;

			public uint dwBrightness;
		}

		public struct NET_DVR_MATRIXPARA_V30
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.U2)]
			public ushort[] wOrder;

			public ushort wSwitchTime;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 14, ArraySubType = UnmanagedType.I1)]
			public byte[] res;
		}

		public struct NET_DVR_MATRIXPARA
		{
			public ushort wDisplayLogo;

			public ushort wDisplayOsd;
		}

		public struct NET_DVR_VOOUT
		{
			public byte byVideoFormat;

			public byte byMenuAlphaValue;

			public ushort wScreenSaveTime;

			public ushort wVOffset;

			public ushort wBrightness;

			public byte byStartMode;

			public byte byEnableScaler;
		}

		public struct NET_DVR_VIDEOOUT_V30
		{
			public uint dwSize;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.Struct)]
			public NET_DVR_VOOUT[] struVOOut;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.Struct)]
			public NET_DVR_VGAPARA[] struVGAPara;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.Struct)]
			public NET_DVR_MATRIXPARA_V30[] struMatrixPara;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		public struct NET_DVR_VIDEOOUT
		{
			public uint dwSize;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.Struct)]
			public NET_DVR_VOOUT[] struVOOut;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.Struct)]
			public NET_DVR_VGAPARA[] struVGAPara;

			public NET_DVR_MATRIXPARA struMatrixPara;
		}

		public struct NET_DVR_USER_INFO_V30
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] sUserName;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] sPassword;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byLocalRight;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byRemoteRight;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byNetPreviewRight;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byLocalPlaybackRight;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byNetPlaybackRight;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byLocalRecordRight;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byNetRecordRight;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byLocalPTZRight;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byNetPTZRight;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byLocalBackupRight;

			public NET_DVR_IPADDR struUserIP;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
			public byte[] byMACAddr;

			public byte byPriority;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 17, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		public struct NET_DVR_USER_INFO_EX
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] sUserName;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] sPassword;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.U4)]
			public uint[] dwLocalRight;

			public uint dwLocalPlaybackRight;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.U4)]
			public uint[] dwRemoteRight;

			public uint dwNetPreviewRight;

			public uint dwNetPlaybackRight;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sUserIP;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
			public byte[] byMACAddr;
		}

		public struct NET_DVR_USER_INFO
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] sUserName;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] sPassword;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.U4)]
			public uint[] dwLocalRight;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.U4)]
			public uint[] dwRemoteRight;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sUserIP;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
			public byte[] byMACAddr;
		}

		public struct NET_DVR_USER_V30
		{
			public uint dwSize;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.Struct)]
			public NET_DVR_USER_INFO_V30[] struUser;
		}

		public struct NET_DVR_USER_EX
		{
			public uint dwSize;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.Struct)]
			public NET_DVR_USER_INFO_EX[] struUser;
		}

		public struct NET_DVR_USER
		{
			public uint dwSize;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.Struct)]
			public NET_DVR_USER_INFO[] struUser;
		}

		public struct NET_DVR_EXCEPTION_V30
		{
			public uint dwSize;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.Struct)]
			public NET_DVR_HANDLEEXCEPTION_V30[] struExceptionHandleType;
		}

		public struct NET_DVR_EXCEPTION
		{
			public uint dwSize;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.Struct)]
			public NET_DVR_HANDLEEXCEPTION[] struExceptionHandleType;
		}

		public struct NET_DVR_CHANNELSTATE_V30
		{
			public byte byRecordStatic;

			public byte bySignalStatic;

			public byte byHardwareStatic;

			public byte byRes1;

			public uint dwBitRate;

			public uint dwLinkNum;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.Struct)]
			public NET_DVR_IPADDR[] struClientIP;

			public uint dwIPLinkNum;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;

			public void Init()
			{
				struClientIP = new NET_DVR_IPADDR[6];
				for (int i = 0; i < 6; i++)
				{
					struClientIP[i].Init();
				}
				byRes = new byte[12];
			}
		}

		public struct NET_DVR_CHANNELSTATE
		{
			public byte byRecordStatic;

			public byte bySignalStatic;

			public byte byHardwareStatic;

			public byte reservedData;

			public uint dwBitRate;

			public uint dwLinkNum;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.U4)]
			public uint[] dwClientIP;
		}

		public struct NET_DVR_DISKSTATE
		{
			public uint dwVolume;

			public uint dwFreeSpace;

			public uint dwHardDiskStatic;
		}

		public struct NET_DVR_WORKSTATE_V30
		{
			public uint dwDeviceStatic;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 33, ArraySubType = UnmanagedType.Struct)]
			public NET_DVR_DISKSTATE[] struHardDiskStatic;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.Struct)]
			public NET_DVR_CHANNELSTATE_V30[] struChanStatic;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 160, ArraySubType = UnmanagedType.I1)]
			public byte[] byAlarmInStatic;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 96, ArraySubType = UnmanagedType.I1)]
			public byte[] byAlarmOutStatic;

			public uint dwLocalDisplay;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byAudioChanStatus;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 10, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;

			public void Init()
			{
				struHardDiskStatic = new NET_DVR_DISKSTATE[33];
				struChanStatic = new NET_DVR_CHANNELSTATE_V30[64];
				for (int i = 0; i < 64; i++)
				{
					struChanStatic[i].Init();
				}
				byAlarmInStatic = new byte[96];
				byAlarmOutStatic = new byte[96];
				byAudioChanStatus = new byte[2];
				byRes = new byte[10];
			}
		}

		public struct NET_DVR_WORKSTATE
		{
			public uint dwDeviceStatic;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.Struct)]
			public NET_DVR_DISKSTATE[] struHardDiskStatic;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.Struct)]
			public NET_DVR_CHANNELSTATE[] struChanStatic;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byAlarmInStatic;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
			public byte[] byAlarmOutStatic;

			public uint dwLocalDisplay;

			public void Init()
			{
				struHardDiskStatic = new NET_DVR_DISKSTATE[16];
				struChanStatic = new NET_DVR_CHANNELSTATE[16];
				byAlarmInStatic = new byte[16];
				byAlarmOutStatic = new byte[4];
			}
		}

		public struct NET_DVR_LOG_V30
		{
			public NET_DVR_TIME strLogTime;

			public uint dwMajorType;

			public uint dwMinorType;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] sPanelUser;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] sNetUser;

			public NET_DVR_IPADDR struRemoteHostAddr;

			public uint dwParaType;

			public uint dwChannel;

			public uint dwDiskNumber;

			public uint dwAlarmInPort;

			public uint dwAlarmOutPort;

			public uint dwInfoLen;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11840)]
			public string sInfo;
		}

		public struct NET_DVR_LOG
		{
			public NET_DVR_TIME strLogTime;

			public uint dwMajorType;

			public uint dwMinorType;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] sPanelUser;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] sNetUser;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sRemoteHostAddr;

			public uint dwParaType;

			public uint dwChannel;

			public uint dwDiskNumber;

			public uint dwAlarmInPort;

			public uint dwAlarmOutPort;
		}

		public struct NET_DVR_ALARMOUTSTATUS_V30
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 96, ArraySubType = UnmanagedType.I1)]
			public byte[] Output;

			public void Init()
			{
				Output = new byte[96];
			}
		}

		public struct NET_DVR_ALARMOUTSTATUS
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
			public byte[] Output;
		}

		public struct NET_DVR_TRADEINFO
		{
			public ushort m_Year;

			public ushort m_Month;

			public ushort m_Day;

			public ushort m_Hour;

			public ushort m_Minute;

			public ushort m_Second;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
			public byte[] DeviceName;

			public uint dwChannelNumer;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] CardNumber;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 12)]
			public string cTradeType;

			public uint dwCash;
		}

		public struct NET_DVR_FRAMETYPECODE
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
			public byte[] code;
		}

		public struct NET_DVR_FRAMEFORMAT_V30
		{
			public uint dwSize;

			public NET_DVR_IPADDR struATMIP;

			public uint dwATMType;

			public uint dwInputMode;

			public uint dwFrameSignBeginPos;

			public uint dwFrameSignLength;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
			public byte[] byFrameSignContent;

			public uint dwCardLengthInfoBeginPos;

			public uint dwCardLengthInfoLength;

			public uint dwCardNumberInfoBeginPos;

			public uint dwCardNumberInfoLength;

			public uint dwBusinessTypeBeginPos;

			public uint dwBusinessTypeLength;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 10, ArraySubType = UnmanagedType.Struct)]
			public NET_DVR_FRAMETYPECODE[] frameTypeCode;

			public ushort wATMPort;

			public ushort wProtocolType;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		public struct NET_DVR_FRAMEFORMAT
		{
			public uint dwSize;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sATMIP;

			public uint dwATMType;

			public uint dwInputMode;

			public uint dwFrameSignBeginPos;

			public uint dwFrameSignLength;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
			public byte[] byFrameSignContent;

			public uint dwCardLengthInfoBeginPos;

			public uint dwCardLengthInfoLength;

			public uint dwCardNumberInfoBeginPos;

			public uint dwCardNumberInfoLength;

			public uint dwBusinessTypeBeginPos;

			public uint dwBusinessTypeLength;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 10, ArraySubType = UnmanagedType.Struct)]
			public NET_DVR_FRAMETYPECODE[] frameTypeCode;
		}

		public struct tagNET_DVR_FILTER
		{
			public byte byEnable;

			public byte byMode;

			public byte byFrameBeginPos;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byFilterText;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}

		public struct tagNET_DVR_IDENTIFICAT
		{
			public byte byStartMode;

			public byte byEndMode;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;

			public NET_DVR_FRAMETYPECODE struStartCode;

			public NET_DVR_FRAMETYPECODE struEndCode;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
		}

		public struct tagNET_DVR_PACKAGE_LOCATION
		{
			public byte byOffsetMode;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;

			public uint dwOffsetPos;

			public NET_DVR_FRAMETYPECODE struTokenCode;

			public byte byMultiplierValue;

			public byte byEternOffset;

			public byte byCodeMode;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 9, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}

		public struct tagNET_DVR_PACKAGE_LENGTH
		{
			public byte byLengthMode;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;

			public uint dwFixLength;

			public uint dwMaxLength;

			public uint dwMinLength;

			public byte byEndMode;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;

			public NET_DVR_FRAMETYPECODE struEndCode;

			public uint dwLengthPos;

			public uint dwLengthLen;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes3;
		}

		public struct tagNET_DVR_OSD_POSITION
		{
			public byte byPositionMode;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;

			public uint dwPos_x;

			public uint dwPos_y;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}

		public struct tagNET_DVR_DATE_FORMAT
		{
			public byte byItem1;

			public byte byItem2;

			public byte byItem3;

			public byte byDateForm;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
			public string chSeprator;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
			public string chDisplaySeprator;

			public byte byDisplayForm;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 27, ArraySubType = UnmanagedType.I1)]
			public byte[] res;
		}

		public struct tagNET_DVRT_TIME_FORMAT
		{
			public byte byTimeForm;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 23, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;

			public byte byHourMode;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
			public string chSeprator;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
			public string chDisplaySeprator;

			public byte byDisplayForm;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes3;

			public byte byDisplayHourMode;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 19, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes4;
		}

		public struct tagNET_DVR_OVERLAY_CHANNEL
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byChannel;

			public uint dwDelayTime;

			public byte byEnableDelayTime;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 11, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		public struct tagNET_DVR_ATM_PACKAGE_ACTION
		{
			public tagNET_DVR_PACKAGE_LOCATION struPackageLocation;

			public tagNET_DVR_OSD_POSITION struOsdPosition;

			public NET_DVR_FRAMETYPECODE struActionCode;

			public NET_DVR_FRAMETYPECODE struPreCode;

			public byte byActionCodeMode;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 7, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		public struct tagNET_DVR_ATM_PACKAGE_DATE
		{
			public tagNET_DVR_PACKAGE_LOCATION struPackageLocation;

			public tagNET_DVR_DATE_FORMAT struDateForm;

			public tagNET_DVR_OSD_POSITION struOsdPosition;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
			public byte[] res;
		}

		public struct tagNET_DVR_ATM_PACKAGE_TIME
		{
			public tagNET_DVR_PACKAGE_LOCATION location;

			public tagNET_DVRT_TIME_FORMAT struTimeForm;

			public tagNET_DVR_OSD_POSITION struOsdPosition;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		public struct tagNET_DVR_ATM_PACKAGE_OTHERS
		{
			public tagNET_DVR_PACKAGE_LOCATION struPackageLocation;

			public tagNET_DVR_PACKAGE_LENGTH struPackageLength;

			public tagNET_DVR_OSD_POSITION struOsdPosition;

			public NET_DVR_FRAMETYPECODE struPreCode;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
			public byte[] res;
		}

		public struct tagNET_DVR_ATM_FRAMETYPE_NEW
		{
			public byte byEnable;

			public byte byInputMode;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byAtmName;

			public NET_DVR_IPADDR struAtmIp;

			public ushort wAtmPort;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;

			public uint dwAtmType;

			public tagNET_DVR_IDENTIFICAT struIdentification;

			public tagNET_DVR_FILTER struFilter;

			public tagNET_DVR_ATM_PACKAGE_OTHERS struCardNoPara;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.Struct)]
			public tagNET_DVR_ATM_PACKAGE_ACTION[] struTradeActionPara;

			public tagNET_DVR_ATM_PACKAGE_OTHERS struAmountPara;

			public tagNET_DVR_ATM_PACKAGE_OTHERS struSerialNoPara;

			public tagNET_DVR_OVERLAY_CHANNEL struOverlayChan;

			public tagNET_DVR_ATM_PACKAGE_DATE byRes4;

			public tagNET_DVR_ATM_PACKAGE_TIME byRes5;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 132, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes3;
		}

		public struct tagNET_DVR_FRAMEFORMAT_V31
		{
			public uint dwSize;

			public tagNET_DVR_ATM_FRAMETYPE_NEW struAtmFrameTypeNew;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.Struct)]
			public tagNET_DVR_ATM_FRAMETYPE_NEW[] byRes;
		}

		public struct tagNET_DVR_ATM_PROTOIDX
		{
			public uint dwAtmType;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
			public string chDesc;
		}

		public struct tagNET_DVR_ATM_PROTOCOL
		{
			public uint dwSize;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 1025, ArraySubType = UnmanagedType.Struct)]
			public tagNET_DVR_ATM_PROTOIDX[] struAtmProtoidx;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.U4)]
			public uint[] dwAtmNumPerSort;
		}

		public struct NET_DVR_DECODERINFO
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byEncoderIP;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byEncoderUser;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byEncoderPasswd;

			public byte bySendMode;

			public byte byEncoderChannel;

			public ushort wEncoderPort;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
			public byte[] reservedData;
		}

		public struct NET_DVR_DECODERSTATE
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byEncoderIP;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byEncoderUser;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byEncoderPasswd;

			public byte byEncoderChannel;

			public byte bySendMode;

			public ushort wEncoderPort;

			public uint dwConnectState;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
			public byte[] reservedData;
		}

		public struct NET_DVR_DECCHANINFO
		{
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sDVRIP;

			public ushort wDVRPort;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] sUserName;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] sPassword;

			public byte byChannel;

			public byte byLinkMode;

			public byte byLinkType;
		}

		public struct NET_DVR_DECINFO
		{
			public byte byPoolChans;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.Struct)]
			public NET_DVR_DECCHANINFO[] struchanConInfo;

			public byte byEnablePoll;

			public byte byPoolTime;
		}

		public struct NET_DVR_DECCFG
		{
			public uint dwSize;

			public uint dwDecChanNum;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.Struct)]
			public NET_DVR_DECINFO[] struDecInfo;
		}

		public struct NET_DVR_PORTINFO
		{
			public uint dwEnableTransPort;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sDecoderIP;

			public ushort wDecoderPort;

			public ushort wDVRTransPort;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
			public string cReserve;
		}

		public struct NET_DVR_PORTCFG
		{
			public uint dwSize;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.Struct)]
			public NET_DVR_PORTINFO[] struTransPortInfo;
		}

		public struct NET_DVR_PLAYREMOTEFILE
		{
			[StructLayout(LayoutKind.Explicit)]
			public struct mode_size
			{
				public struct bytime
				{
					public uint dwChannel;

					[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
					public byte[] sUserName;

					[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
					public byte[] sPassword;

					public NET_DVR_TIME struStartTime;

					public NET_DVR_TIME struStopTime;
				}

				[FieldOffset(0)]
				[MarshalAs(UnmanagedType.ByValArray, SizeConst = 100, ArraySubType = UnmanagedType.I1)]
				public byte[] byFile;
			}

			public uint dwSize;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sDecoderIP;

			public ushort wDecoderPort;

			public ushort wLoadMode;
		}

		public struct NET_DVR_DECCHANSTATUS
		{
			[StructLayout(LayoutKind.Explicit)]
			public struct objectInfo
			{
				public struct userInfo
				{
					[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
					public byte[] sUserName;

					[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
					public byte[] sPassword;

					[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 52)]
					public string cReserve;
				}

				public struct fileInfo
				{
					[MarshalAs(UnmanagedType.ByValArray, SizeConst = 100, ArraySubType = UnmanagedType.I1)]
					public byte[] fileName;
				}

				public struct timeInfo
				{
					public uint dwChannel;

					[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
					public byte[] sUserName;

					[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
					public byte[] sPassword;

					public NET_DVR_TIME struStartTime;

					public NET_DVR_TIME struStopTime;
				}
			}

			public uint dwWorkType;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sDVRIP;

			public ushort wDVRPort;

			public byte byChannel;

			public byte byLinkMode;

			public uint dwLinkType;
		}

		public struct NET_DVR_DECSTATUS
		{
			public uint dwSize;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.Struct)]
			public NET_DVR_DECCHANSTATUS[] struTransPortInfo;
		}

		public struct NET_DVR_SHOWSTRINGINFO
		{
			public ushort wShowString;

			public ushort wStringSize;

			public ushort wShowStringTopLeftX;

			public ushort wShowStringTopLeftY;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 44)]
			public string sString;
		}

		public struct NET_DVR_SHOWSTRING_V30
		{
			public uint dwSize;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.Struct)]
			public NET_DVR_SHOWSTRINGINFO[] struStringInfo;
		}

		public struct NET_DVR_SHOWSTRING_EX
		{
			public uint dwSize;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.Struct)]
			public NET_DVR_SHOWSTRINGINFO[] struStringInfo;
		}

		public struct NET_DVR_SHOWSTRING
		{
			public uint dwSize;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.Struct)]
			public NET_DVR_SHOWSTRINGINFO[] struStringInfo;
		}

		public struct struReceiver
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] sName;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 48, ArraySubType = UnmanagedType.I1)]
			public byte[] sAddress;
		}

		public struct NET_DVR_EMAILCFG_V30
		{
			public struct struSender
			{
				[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
				public byte[] sName;

				[MarshalAs(UnmanagedType.ByValArray, SizeConst = 48, ArraySubType = UnmanagedType.I1)]
				public byte[] sAddress;
			}

			public uint dwSize;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] sAccount;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] sPassword;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 48, ArraySubType = UnmanagedType.I1)]
			public byte[] sSmtpServer;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 48, ArraySubType = UnmanagedType.I1)]
			public byte[] sPop3Server;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.Struct)]
			public struReceiver[] struStringInfo;

			public byte byAttachment;

			public byte bySmtpServerVerify;

			public byte byMailInterval;

			public byte byEnableSSL;

			public ushort wSmtpPort;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 74, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		public struct NET_DVR_CRUISE_PARA
		{
			public uint dwSize;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byPresetNo;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byCruiseSpeed;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.U2)]
			public ushort[] wDwellTime;

			public byte byEnableThisCruise;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 15, ArraySubType = UnmanagedType.I1)]
			public byte[] res;
		}

		public struct NET_DVR_TIMEPOINT
		{
			public uint dwMonth;

			public uint dwWeekNo;

			public uint dwWeekDate;

			public uint dwHour;

			public uint dwMin;
		}

		public struct NET_DVR_ZONEANDDST
		{
			public uint dwSize;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;

			public uint dwEnableDST;

			public byte byDSTBias;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;

			public NET_DVR_TIMEPOINT struBeginPoint;

			public NET_DVR_TIMEPOINT struEndPoint;
		}

		public struct NET_DVR_JPEGPARA
		{
			public ushort wPicSize;

			public ushort wPicQuality;
		}

		public struct NET_DVR_AUXOUTCFG
		{
			public uint dwSize;

			public uint dwAlarmOutChan;

			public uint dwAlarmChanSwitchTime;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.U4)]
			public uint[] dwAuxSwitchTime;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byAuxOrder;
		}

		public struct NET_DVR_NTPPARA
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] sNTPServer;

			public ushort wInterval;

			public byte byEnableNTP;

			public byte cTimeDifferenceH;

			public byte cTimeDifferenceM;

			public byte res1;

			public ushort wNtpPort;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
			public byte[] res2;
		}

		public struct NET_DVR_DDNSPARA
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] sUsername;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] sPassword;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] sDomainName;

			public byte byEnableDDNS;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 15, ArraySubType = UnmanagedType.I1)]
			public byte[] res;
		}

		public struct NET_DVR_DDNSPARA_EX
		{
			public byte byHostIndex;

			public byte byEnableDDNS;

			public ushort wDDNSPort;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] sUsername;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] sPassword;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] sDomainName;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] sServerName;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		public struct struDDNS
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] sUsername;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] sPassword;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] sDomainName;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] sServerName;

			public ushort wDDNSPort;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 10, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		public struct NET_DVR_DDNSPARA_V30
		{
			public byte byEnableDDNS;

			public byte byHostIndex;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 10, ArraySubType = UnmanagedType.Struct)]
			public struDDNS[] struDDNS;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}

		public struct NET_DVR_EMAILPARA
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] sUsername;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] sPassword;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] sSmtpServer;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] sPop3Server;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] sMailAddr;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] sEventMailAddr1;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] sEventMailAddr2;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] res;
		}

		public struct NET_DVR_NETAPPCFG
		{
			public uint dwSize;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sDNSIp;

			public NET_DVR_NTPPARA struNtpClientParam;

			public NET_DVR_DDNSPARA struDDNSClientParam;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 464, ArraySubType = UnmanagedType.I1)]
			public byte[] res;
		}

		public struct NET_DVR_SINGLE_NFS
		{
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sNfsHostIPAddr;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
			public byte[] sNfsDirectory;

			public void Init()
			{
				sNfsDirectory = new byte[128];
			}
		}

		public struct NET_DVR_NFSCFG
		{
			public uint dwSize;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.Struct)]
			public NET_DVR_SINGLE_NFS[] struNfsDiskParam;

			public void Init()
			{
				struNfsDiskParam = new NET_DVR_SINGLE_NFS[8];
				for (int i = 0; i < 8; i++)
				{
					struNfsDiskParam[i].Init();
				}
			}
		}

		public struct NET_DVR_CRUISE_POINT
		{
			public byte PresetNum;

			public byte Dwell;

			public byte Speed;

			public byte Reserve;

			public void Init()
			{
				PresetNum = 0;
				Dwell = 0;
				Speed = 0;
				Reserve = 0;
			}
		}

		public struct NET_DVR_CRUISE_RET
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.Struct)]
			public NET_DVR_CRUISE_POINT[] struCruisePoint;

			public void Init()
			{
				struCruisePoint = new NET_DVR_CRUISE_POINT[32];
				for (int i = 0; i < 32; i++)
				{
					struCruisePoint[i].Init();
				}
			}
		}

		public struct NET_DVR_NETCFG_OTHER
		{
			public uint dwSize;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sFirstDNSIP;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sSecondDNSIP;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
			public string sRes;
		}

		public struct NET_DVR_MATRIX_DECINFO
		{
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sDVRIP;

			public ushort wDVRPort;

			public byte byChannel;

			public byte byTransProtocol;

			public byte byTransMode;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] sUserName;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] sPassword;
		}

		public struct NET_DVR_MATRIX_DYNAMIC_DEC
		{
			public uint dwSize;

			public NET_DVR_MATRIX_DECINFO struDecChanInfo;
		}

		public struct NET_DVR_MATRIX_DEC_CHAN_STATUS
		{
			public uint dwSize;

			public uint dwIsLinked;

			public uint dwStreamCpRate;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
			public string cRes;
		}

		public struct NET_DVR_MATRIX_DEC_CHAN_INFO
		{
			public uint dwSize;

			public NET_DVR_MATRIX_DECINFO struDecChanInfo;

			public uint dwDecState;

			public NET_DVR_TIME StartTime;

			public NET_DVR_TIME StopTime;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
			public string sFileName;
		}

		public struct NET_DVR_MATRIX_DECCHANINFO
		{
			public uint dwEnable;

			public NET_DVR_MATRIX_DECINFO struDecChanInfo;
		}

		public struct NET_DVR_MATRIX_LOOP_DECINFO
		{
			public uint dwSize;

			public uint dwPoolTime;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.Struct)]
			public NET_DVR_MATRIX_DECCHANINFO[] struchanConInfo;
		}

		public struct TTY_CONFIG
		{
			public byte baudrate;

			public byte databits;

			public byte stopbits;

			public byte parity;

			public byte flowcontrol;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] res;
		}

		public struct NET_DVR_MATRIX_TRAN_CHAN_INFO
		{
			public byte byTranChanEnable;

			public byte byLocalSerialDevice;

			public byte byRemoteSerialDevice;

			public byte res1;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sRemoteDevIP;

			public ushort wRemoteDevPort;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] res2;

			public TTY_CONFIG RemoteSerialDevCfg;
		}

		public struct NET_DVR_MATRIX_TRAN_CHAN_CONFIG
		{
			public uint dwSize;

			public byte by232IsDualChan;

			public byte by485IsDualChan;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] res;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.Struct)]
			public NET_DVR_MATRIX_TRAN_CHAN_INFO[] struTranInfo;
		}

		public struct NET_DVR_MATRIX_DEC_REMOTE_PLAY
		{
			public uint dwSize;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sDVRIP;

			public ushort wDVRPort;

			public byte byChannel;

			public byte byReserve;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] sUserName;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] sPassword;

			public uint dwPlayMode;

			public NET_DVR_TIME StartTime;

			public NET_DVR_TIME StopTime;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
			public string sFileName;
		}

		public struct NET_DVR_MATRIX_DEC_REMOTE_PLAY_CONTROL
		{
			public uint dwSize;

			public uint dwPlayCmd;

			public uint dwCmdParam;
		}

		public struct NET_DVR_MATRIX_DEC_REMOTE_PLAY_STATUS
		{
			public uint dwSize;

			public uint dwCurMediaFileLen;

			public uint dwCurMediaFilePosition;

			public uint dwCurMediaFileDuration;

			public uint dwCurPlayTime;

			public uint dwCurMediaFIleFrames;

			public uint dwCurDataType;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 72, ArraySubType = UnmanagedType.I1)]
			public byte[] res;
		}

		public struct tagNET_MATRIX_PASSIVEMODE
		{
			public ushort wTransProtol;

			public ushort wPassivePort;

			public NET_DVR_IPADDR struMcastIP;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
			public byte[] res;
		}

		public struct tagDEV_CHAN_INFO
		{
			public NET_DVR_IPADDR struIP;

			public ushort wDVRPort;

			public byte byChannel;

			public byte byTransProtocol;

			public byte byTransMode;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 71, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] sUserName;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] sPassword;
		}

		public struct tagMATRIX_TRAN_CHAN_INFO
		{
			public byte byTranChanEnable;

			public byte byLocalSerialDevice;

			public byte byRemoteSerialDevice;

			public byte byRes1;

			public NET_DVR_IPADDR struRemoteDevIP;

			public ushort wRemoteDevPort;

			public byte byIsEstablished;

			public byte byRes2;

			public TTY_CONFIG RemoteSerialDevCfg;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byUsername;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byPassword;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes3;
		}

		public struct tagMATRIX_TRAN_CHAN_CONFIG
		{
			public uint dwSize;

			public byte by232IsDualChan;

			public byte by485IsDualChan;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] vyRes;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.Struct)]
			public tagMATRIX_TRAN_CHAN_INFO[] struTranInfo;
		}

		public struct NET_DVR_STREAM_MEDIA_SERVER_CFG
		{
			public byte byValid;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;

			public NET_DVR_IPADDR struDevIP;

			public ushort wDevPort;

			public byte byTransmitType;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 69, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}

		public struct NET_DVR_PU_STREAM_CFG
		{
			public uint dwSize;

			public NET_DVR_STREAM_MEDIA_SERVER_CFG struStreamMediaSvrCfg;

			public tagDEV_CHAN_INFO struDevChanInfo;
		}

		public struct NET_DVR_MATRIX_CHAN_INFO_V30
		{
			public uint dwEnable;

			public NET_DVR_STREAM_MEDIA_SERVER_CFG streamMediaServerCfg;

			public tagDEV_CHAN_INFO struDevChanInfo;
		}

		public struct tagMATRIX_LOOP_DECINFO_V30
		{
			public uint dwSize;

			public uint dwPoolTime;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.Struct)]
			public NET_DVR_MATRIX_CHAN_INFO_V30[] struchanConInfo;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		public struct tagDEC_MATRIX_CHAN_INFO
		{
			public uint dwSize;

			public NET_DVR_STREAM_MEDIA_SERVER_CFG streamMediaServerCfg;

			public tagDEV_CHAN_INFO struDevChanInfo;

			public uint dwDecState;

			public NET_DVR_TIME StartTime;

			public NET_DVR_TIME StopTime;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
			public string sFileName;

			public uint dwGetStreamMode;

			public tagNET_MATRIX_PASSIVEMODE struPassiveMode;
		}

		public struct tagNET_DVR_MATRIX_ABILITY
		{
			public uint dwSize;

			public byte byDecNums;

			public byte byStartChan;

			public byte byVGANums;

			public byte byBNCNums;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
			public byte[] byVGAWindowMode;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
			public byte[] byBNCWindowMode;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] res;
		}

		public struct tagNET_DVR_DISP_LOGOCFG
		{
			public uint dwCorordinateX;

			public uint dwCorordinateY;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;

			public byte byFlash;

			public byte byTranslucent;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;

			public uint dwLogoSize;
		}

		public struct NET_DVR_MATRIX_CHAN_STATUS
		{
			public byte byDecodeStatus;

			public byte byStreamType;

			public byte byPacketType;

			public byte byRecvBufUsage;

			public byte byDecBufUsage;

			public byte byFpsDecV;

			public byte byFpsDecA;

			public byte byCpuLoad;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;

			public uint dwDecodedV;

			public uint dwDecodedA;

			public ushort wImgW;

			public ushort wImgH;

			public byte byVideoFormat;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 27, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}

		public enum VGA_MODE
		{
			VGA_NOT_AVALIABLE,
			VGA_THS8200_MODE_SVGA_60HZ,
			VGA_THS8200_MODE_SVGA_75HZ,
			VGA_THS8200_MODE_XGA_60HZ,
			VGA_THS8200_MODE_XGA_70HZ,
			VGA_THS8200_MODE_SXGA_60HZ,
			VGA_THS8200_MODE_720P_60HZ,
			VGA_THS8200_MODE_1080i_60HZ,
			VGA_THS8200_MODE_1080P_30HZ,
			VGA_THS8200_MODE_1080P_25HZ,
			VGA_THS8200_MODE_UXGA_30HZ
		}

		public enum VIDEO_STANDARD
		{
			VS_NON,
			VS_NTSC,
			VS_PAL
		}

		public struct tagNET_DVR_VGA_DISP_CHAN_CFG
		{
			public uint dwSize;

			public byte byAudio;

			public byte byAudioWindowIdx;

			public byte byVgaResolution;

			public byte byVedioFormat;

			public uint dwWindowMode;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byJoinDecChan;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		public struct NET_DVR_DISP_CHAN_STATUS
		{
			public byte byDispStatus;

			public byte byBVGA;

			public byte byVideoFormat;

			public byte byWindowMode;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 10, ArraySubType = UnmanagedType.I1)]
			public byte[] byJoinDecChan;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byFpsDisp;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}

		public struct tagNET_DVR__DECODER_WORK_STATUS
		{
			public uint dwSize;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.Struct)]
			public NET_DVR_MATRIX_CHAN_STATUS[] struDecChanStatus;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.Struct)]
			public NET_DVR_DISP_CHAN_STATUS[] struDispChanStatus;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byAlarmInStatus;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byAalarmOutStatus;

			public byte byAudioInChanStatus;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 127, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		public struct NET_DVR_EMAILCFG
		{
			public uint dwSize;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
			public string sUserName;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
			public string sPassWord;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
			public string sFromName;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 48)]
			public string sFromAddr;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
			public string sToName1;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
			public string sToName2;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 48)]
			public string sToAddr1;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 48)]
			public string sToAddr2;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
			public string sEmailServer;

			public byte byServerType;

			public byte byUseAuthen;

			public byte byAttachment;

			public byte byMailinterval;
		}

		public struct NET_DVR_COMPRESSIONCFG_NEW
		{
			public uint dwSize;

			public NET_DVR_COMPRESSION_INFO_EX struLowCompression;

			public NET_DVR_COMPRESSION_INFO_EX struEventCompression;
		}

		public struct NET_DVR_PTZPOS
		{
			public ushort wAction;

			public ushort wPanPos;

			public ushort wTiltPos;

			public ushort wZoomPos;
		}

		public struct NET_DVR_PTZSCOPE
		{
			public ushort wPanPosMin;

			public ushort wPanPosMax;

			public ushort wTiltPosMin;

			public ushort wTiltPosMax;

			public ushort wZoomPosMin;

			public ushort wZoomPosMax;
		}

		public struct NET_DVR_RTSPCFG
		{
			public uint dwSize;

			public ushort wPort;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 54, ArraySubType = UnmanagedType.I1)]
			public byte[] byReserve;
		}

		public struct NET_DVR_DEVICEINFO
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 48, ArraySubType = UnmanagedType.I1)]
			public byte[] sSerialNumber;

			public byte byAlarmInPortNum;

			public byte byAlarmOutPortNum;

			public byte byDiskNum;

			public byte byDVRType;

			public byte byChanNum;

			public byte byStartChan;
		}

		public struct NET_DVR_DEVICEINFO_V30
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 48, ArraySubType = UnmanagedType.I1)]
			public byte[] sSerialNumber;

			public byte byAlarmInPortNum;

			public byte byAlarmOutPortNum;

			public byte byDiskNum;

			public byte byDVRType;

			public byte byChanNum;

			public byte byStartChan;

			public byte byAudioChanNum;

			public byte byIPChanNum;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
		}

		public enum SDK_NETWORK_ENVIRONMENT
		{
			LOCAL_AREA_NETWORK,
			WIDE_AREA_NETWORK
		}

		public enum DISPLAY_MODE
		{
			NORMALMODE,
			OVERLAYMODE
		}

		public enum SEND_MODE
		{
			PTOPTCPMODE,
			PTOPUDPMODE,
			MULTIMODE,
			RTPMODE,
			RESERVEDMODE
		}

		public enum CAPTURE_MODE
		{
			BMP_MODE,
			JPEG_MODE
		}

		public enum REALSOUND_MODE
		{
			MONOPOLIZE_MODE = 1,
			SHARE_MODE
		}

		public struct NET_DVR_SDKSTATE
		{
			public uint dwTotalLoginNum;

			public uint dwTotalRealPlayNum;

			public uint dwTotalPlayBackNum;

			public uint dwTotalAlarmChanNum;

			public uint dwTotalFormatNum;

			public uint dwTotalFileSearchNum;

			public uint dwTotalLogSearchNum;

			public uint dwTotalSerialNum;

			public uint dwTotalUpgradeNum;

			public uint dwTotalVoiceComNum;

			public uint dwTotalBroadCastNum;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 10, ArraySubType = UnmanagedType.U4)]
			public uint[] dwRes;
		}

		public struct NET_DVR_SDKABL
		{
			public uint dwMaxLoginNum;

			public uint dwMaxRealPlayNum;

			public uint dwMaxPlayBackNum;

			public uint dwMaxAlarmChanNum;

			public uint dwMaxFormatNum;

			public uint dwMaxFileSearchNum;

			public uint dwMaxLogSearchNum;

			public uint dwMaxSerialNum;

			public uint dwMaxUpgradeNum;

			public uint dwMaxVoiceComNum;

			public uint dwMaxBroadCastNum;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 10, ArraySubType = UnmanagedType.U4)]
			public uint[] dwRes;
		}

		public struct NET_DVR_ALARMER
		{
			public byte byUserIDValid;

			public byte bySerialValid;

			public byte byVersionValid;

			public byte byDeviceNameValid;

			public byte byMacAddrValid;

			public byte byLinkPortValid;

			public byte byDeviceIPValid;

			public byte bySocketIPValid;

			public int lUserID;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 48, ArraySubType = UnmanagedType.I1)]
			public byte[] sSerialNumber;

			public uint dwDeviceVersion;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
			public string sDeviceName;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
			public byte[] byMacAddr;

			public ushort wLinkPort;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
			public string sDeviceIP;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
			public string sSocketIP;

			public byte byIpProtocol;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 11, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}

		public struct NET_DVR_DISPLAY_PARA
		{
			public int bToScreen;

			public int bToVideoOut;

			public int nLeft;

			public int nTop;

			public int nWidth;

			public int nHeight;

			public int nReserved;
		}

		public struct NET_DVR_CARDINFO
		{
			public int lChannel;

			public int lLinkMode;

			[MarshalAs(UnmanagedType.LPStr)]
			public string sMultiCastIP;

			public NET_DVR_DISPLAY_PARA struDisplayPara;
		}

		public struct NET_DVR_FIND_DATA
		{
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 100)]
			public string sFileName;

			public NET_DVR_TIME struStartTime;

			public NET_DVR_TIME struStopTime;

			public uint dwFileSize;
		}

		public struct NET_DVR_FINDDATA_V30
		{
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 100)]
			public string sFileName;

			public NET_DVR_TIME struStartTime;

			public NET_DVR_TIME struStopTime;

			public uint dwFileSize;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
			public string sCardNum;

			public byte byLocked;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		public struct NET_DVR_FINDDATA_CARD
		{
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 100)]
			public string sFileName;

			public NET_DVR_TIME struStartTime;

			public NET_DVR_TIME struStopTime;

			public uint dwFileSize;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
			public string sCardNum;
		}

		public struct NET_DVR_FILECOND
		{
			public int lChannel;

			public uint dwFileType;

			public uint dwIsLocked;

			public uint dwUseCardNo;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] sCardNumber;

			public NET_DVR_TIME struStartTime;

			public NET_DVR_TIME struStopTime;
		}

		public struct NET_DVR_POINT_FRAME
		{
			public int xTop;

			public int yTop;

			public int xBottom;

			public int yBottom;

			public int bCounter;
		}

		public struct tagNET_DVR_COMPRESSION_AUDIO
		{
			public byte byAudioEncType;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 7, ArraySubType = UnmanagedType.I1)]
			public byte[] byres;
		}

		public delegate void EXCEPYIONCALLBACK(uint dwType, int lUserID, int lHandle, IntPtr pUser);

		public delegate int MESSCALLBACK(int lCommand, string sDVRIP, string pBuf, uint dwBufLen);

		public delegate int MESSCALLBACKEX(int iCommand, int iUserID, string pBuf, uint dwBufLen);

		public delegate int MESSCALLBACKNEW(int lCommand, string sDVRIP, string pBuf, uint dwBufLen, ushort dwLinkDVRPort);

		public delegate int MESSAGECALLBACK(int lCommand, IntPtr sDVRIP, IntPtr pBuf, uint dwBufLen, uint dwUser);

		public delegate void MSGCallBack(int lCommand, ref NET_DVR_ALARMER pAlarmer, IntPtr pAlarmInfo, uint dwBufLen, IntPtr pUser);

		public delegate void REALDATACALLBACK(int lRealHandle, uint dwDataType, ref byte pBuffer, uint dwBufSize, IntPtr pUser);

		public delegate void DRAWFUN(int lRealHandle, IntPtr hDc, uint dwUser);

		public delegate void SETREALDATACALLBACK(int lRealHandle, uint dwDataType, IntPtr pBuffer, uint dwBufSize, uint dwUser);

		public delegate void STDDATACALLBACK(int lRealHandle, uint dwDataType, ref byte pBuffer, uint dwBufSize, uint dwUser);

		public delegate void PLAYDATACALLBACK(int lPlayHandle, uint dwDataType, IntPtr pBuffer, uint dwBufSize, uint dwUser);

		public struct NET_DVR_PLAYCOND
		{
			public int lChannel;

			public NET_DVR_TIME startTime;

			public NET_DVR_TIME stopTime;

			public byte drawFrame;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 63)]
			public byte[] byRes;
		}

		public struct NET_DVR_STREAM_INFO
		{
			public int dwSize;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
			public byte[] byID;

			public int dwChannel;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
			public byte[] byRes;
		}

		public struct NET_DVR_VOD_PARA
		{
			public int dwSize;

			public NET_DVR_STREAM_INFO struIDInfo;

			public NET_DVR_TIME struBeginTime;

			public NET_DVR_TIME struEndTime;

			public IntPtr hWnd;

			public byte byDrawFrame;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 31)]
			public byte[] byRes;
		}

		public struct NET_DVR_RECORD_TIME_SPAN_INQUIRY
		{
			public uint dwSize;

			public byte byType;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 63)]
			public byte[] byRes;
		}

		public struct NET_DVR_RECORD_TIME_SPAN
		{
			public uint dwSize;

			public NET_DVR_TIME strBeginTime;

			public NET_DVR_TIME strEndTime;

			public byte byType;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 35)]
			public byte[] byRes;
		}

		public delegate void VOICEDATACALLBACK(int lVoiceComHandle, string pRecvDataBuffer, uint dwBufSize, byte byAudioFlag, uint dwUser);

		public delegate void VOICEDATACALLBACKV30(int lVoiceComHandle, string pRecvDataBuffer, uint dwBufSize, byte byAudioFlag, IntPtr pUser);

		public delegate void VOICEAUDIOSTART(string pRecvDataBuffer, uint dwBufSize, IntPtr pUser);

		public delegate void SERIALDATACALLBACK(int lSerialHandle, string pRecvDataBuffer, uint dwBufSize, uint dwUser);

		public struct tagNET_VCA_CTRLINFO
		{
			public byte byVCAEnable;

			public byte byVCAType;

			public byte byStreamWithVCA;

			public byte byMode;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		public struct tagNET_VCA_CTRLCFG
		{
			public uint dwSize;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.Struct)]
			public tagNET_VCA_CTRLINFO[] struCtrlInfo;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		public struct tagNET_VCA_DEV_ABILITY
		{
			public uint dwSize;

			public byte byVCAChanNum;

			public byte byPlateChanNum;

			public byte byBBaseChanNum;

			public byte byBAdvanceChanNum;

			public byte byBFullChanNum;

			public byte byATMChanNum;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 34, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		public enum VCA_ABILITY_TYPE
		{
			TRAVERSE_PLANE_ABILITY = 1,
			ENTER_AREA_ABILITY = 2,
			EXIT_AREA_ABILITY = 4,
			INTRUSION_ABILITY = 8,
			LOITER_ABILITY = 0x10,
			LEFT_TAKE_ABILITY = 0x20,
			PARKING_ABILITY = 0x40,
			RUN_ABILITY = 0x80,
			HIGH_DENSITY_ABILITY = 0x100,
			LF_TRACK_ABILITY = 0x200,
			STICK_UP_ABILITY = 0x40000000,
			INSTALL_SCANNER_ABILITY = int.MinValue
		}

		public enum VCA_CHAN_ABILITY_TYPE
		{
			VCA_BEHAVIOR_BASE = 1,
			VCA_BEHAVIOR_ADVANCE,
			VCA_BEHAVIOR_FULL,
			VCA_PLATE,
			VCA_ATM
		}

		public enum VCA_CHAN_MODE_TYPE
		{
			VCA_ATM_PANEL,
			VCA_ATM_SURROUND
		}

		public struct tagNET_VCA_CHAN_IN_PARAM
		{
			public byte byVCAType;

			public byte byMode;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		public struct tagNET_VCA_BEHAVIOR_ABILITY
		{
			public uint dwSize;

			public uint dwAbilityType;

			public byte byMaxRuleNum;

			public byte byMaxTargetNum;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 10, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		public struct tagNET_VCA_POINT
		{
			public float fX;

			public float fY;
		}

		public struct tagNET_VCA_RECT
		{
			public float fX;

			public float fY;

			public float fWidth;

			public float fHeight;
		}

		public struct NET_VCA_RECT
		{
			public float fX;

			public float fY;

			public float fWidth;

			public float fHeight;
		}

		public enum VCA_EVENT_TYPE
		{
			VCA_TRAVERSE_PLANE = 1,
			VCA_ENTER_AREA = 2,
			VCA_EXIT_AREA = 4,
			VCA_INTRUSION = 8,
			VCA_LOITER = 0x10,
			VCA_LEFT_TAKE = 0x20,
			VCA_PARKING = 0x40,
			VCA_RUN = 0x80,
			VCA_HIGH_DENSITY = 0x100,
			VCA_STICK_UP = 0x40000000,
			VCA_INSTALL_SCANNER = int.MinValue
		}

		public enum VCA_CROSS_DIRECTION
		{
			VCA_BOTH_DIRECTION,
			VCA_LEFT_GO_RIGHT,
			VCA_RIGHT_GO_LEFT
		}

		public struct tagNET_VCA_LINE
		{
			public tagNET_VCA_POINT struStart;

			public tagNET_VCA_POINT struEnd;
		}

		public struct tagNET_VCA_POLYGON
		{
			public uint dwPointNum;
		}

		public struct tagNET_VCA_TRAVERSE_PLANE
		{
			public tagNET_VCA_LINE struPlaneBottom;

			public VCA_CROSS_DIRECTION dwCrossDirection;

			public byte byRes1;

			public byte byPlaneHeight;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 38, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}

		public struct tagNET_VCA_AREA
		{
			public tagNET_VCA_POLYGON struRegion;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		public struct tagNET_VCA_INTRUSION
		{
			public tagNET_VCA_POLYGON struRegion;

			public ushort wDuration;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		public struct tagNET_VCA_PARAM_LOITER
		{
			public tagNET_VCA_POLYGON struRegion;

			public ushort wDuration;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		public struct tagNET_VCA_TAKE_LEFT
		{
			public tagNET_VCA_POLYGON struRegion;

			public ushort wDuration;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		public struct tagNET_VCA_PARKING
		{
			public tagNET_VCA_POLYGON struRegion;

			public ushort wDuration;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		public struct tagNET_VCA_RUN
		{
			public tagNET_VCA_POLYGON struRegion;

			public float fRunDistance;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		public struct tagNET_VCA_HIGH_DENSITY
		{
			public tagNET_VCA_POLYGON struRegion;

			public float fDensity;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		public struct tagNET_VCA_STICK_UP
		{
			public tagNET_VCA_POLYGON struRegion;

			public ushort wDuration;

			public byte bySensitivity;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		public struct tagNET_VCA_SCANNER
		{
			public tagNET_VCA_POLYGON struRegion;

			public ushort wDuration;

			public byte bySensitivity;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		[StructLayout(LayoutKind.Explicit)]
		public struct tagNET_VCA_EVENT_UNION
		{
			[FieldOffset(0)]
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 23, ArraySubType = UnmanagedType.U4)]
			public uint[] uLen;

			[FieldOffset(0)]
			public tagNET_VCA_TRAVERSE_PLANE struTraversePlane;

			[FieldOffset(0)]
			public tagNET_VCA_AREA struArea;

			[FieldOffset(0)]
			public tagNET_VCA_INTRUSION struIntrusion;

			[FieldOffset(0)]
			public tagNET_VCA_PARAM_LOITER struLoiter;

			[FieldOffset(0)]
			public tagNET_VCA_TAKE_LEFT struTakeTeft;

			[FieldOffset(0)]
			public tagNET_VCA_PARKING struParking;

			[FieldOffset(0)]
			public tagNET_VCA_RUN struRun;

			[FieldOffset(0)]
			public tagNET_VCA_HIGH_DENSITY struHighDensity;

			[FieldOffset(0)]
			public tagNET_VCA_STICK_UP struStickUp;

			[FieldOffset(0)]
			public tagNET_VCA_SCANNER struScanner;
		}

		public enum SIZE_FILTER_MODE
		{
			IMAGE_PIX_MODE,
			REAL_WORLD_MODE
		}

		public struct tagNET_VCA_SIZE_FILTER
		{
			public byte byActive;

			public byte byMode;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;

			public tagNET_VCA_RECT struMiniRect;

			public tagNET_VCA_RECT struMaxRect;
		}

		public struct tagNET_VCA_ONE_RULE
		{
			public byte byActive;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 7, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byRuleName;

			public VCA_EVENT_TYPE dwEventType;

			public tagNET_VCA_EVENT_UNION uEventParam;

			public tagNET_VCA_SIZE_FILTER struSizeFilter;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 14, ArraySubType = UnmanagedType.Struct)]
			public NET_DVR_SCHEDTIME[] struAlarmTime;

			public NET_DVR_HANDLEEXCEPTION_V30 struHandleType;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byRelRecordChan;
		}

		public struct tagNET_VCA_RULECFG
		{
			public uint dwSize;

			public byte byPicProType;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;

			public NET_DVR_JPEGPARA struPictureParam;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.Struct)]
			public tagNET_VCA_ONE_RULE[] struRule;
		}

		public struct tagNET_VCA_TARGET_INFO
		{
			public uint dwID;

			public tagNET_VCA_RECT struRect;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		public struct tagNET_VCA_RULE_INFO
		{
			public byte byRuleID;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byRuleName;

			public VCA_EVENT_TYPE dwEventType;

			public tagNET_VCA_EVENT_UNION uEventParam;
		}

		public struct tagNET_VCA_DEV_INFO
		{
			public NET_DVR_IPADDR struDevIP;

			public ushort wPort;

			public byte byChannel;

			public byte byRes;
		}

		public struct tagNET_VCA_RULE_ALARM
		{
			public uint dwSize;

			public uint dwRelativeTime;

			public uint dwAbsTime;

			public tagNET_VCA_RULE_INFO struRuleInfo;

			public tagNET_VCA_TARGET_INFO struTargetInfo;

			public tagNET_VCA_DEV_INFO struDevInfo;

			public uint dwPicDataLen;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.U4)]
			public uint[] dwRes;

			public IntPtr pImage;
		}

		public enum IVS_PARAM_KEY
		{
			OBJECT_DETECT_SENSITIVE = 1,
			BACKGROUND_UPDATE_RATE = 2,
			SCENE_CHANGE_RATIO = 3,
			SUPPRESS_LAMP = 4,
			MIN_OBJECT_SIZE = 5,
			OBJECT_GENERATE_RATE = 6,
			MISSING_OBJECT_HOLD = 7,
			MAX_MISSING_DISTANCE = 8,
			OBJECT_MERGE_SPEED = 9,
			REPEATED_MOTION_SUPPRESS = 10,
			ILLUMINATION_CHANGE = 11,
			TRACK_OUTPUT_MODE = 12,
			ENTER_CHANGE_HOLD = 13,
			RESUME_DEFAULT_PARAM = 0xFF
		}

		public struct tagNET_VCA_DRAW_MODE
		{
			public uint dwSize;

			public byte byDspAddTarget;

			public byte byDspAddRule;

			public byte byDspPicAddTarget;

			public byte byDspPicAddRule;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		public struct tagNET_DVR_CB_POINT
		{
			public tagNET_VCA_POINT struPoint;

			public NET_DVR_PTZPOS struPtzPos;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		public struct tagNET_DVR_LF_CALIBRATION_PARAM
		{
			public byte byPointNum;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.Struct)]
			public tagNET_DVR_CB_POINT[] struCBPoint;
		}

		public struct tagNET_DVR_LF_CFG
		{
			public uint dwSize;

			public byte byEnable;

			public byte byFollowChan;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;

			public tagNET_DVR_LF_CALIBRATION_PARAM struCalParam;
		}

		public enum TRACK_MODE
		{
			MANUAL_CTRL,
			ALARM_TRACK,
			TARGET_TRACK
		}

		public struct tagNET_DVR_LF_MANUAL_CTRL_INFO
		{
			public tagNET_VCA_POINT struCtrlPoint;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		public struct tagNET_DVR_LF_TRACK_TARGET_INFO
		{
			public uint dwTargetID;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		public struct tagNET_DVR_LF_TRACK_MODE
		{
			[StructLayout(LayoutKind.Explicit)]
			public struct uModeParam
			{
				[FieldOffset(0)]
				[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.U4)]
				public uint[] dwULen;

				[FieldOffset(0)]
				public tagNET_DVR_LF_MANUAL_CTRL_INFO struManualCtrl;

				[FieldOffset(0)]
				public tagNET_DVR_LF_TRACK_TARGET_INFO struTargetTrack;
			}

			public uint dwSize;

			public byte byTrackMode;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		public enum VCA_RECOGNIZE_SCENE
		{
			VCA_LOW_SPEED_SCENE,
			VCA_HIGH_SPEED_SCENE,
			VCA_MOBILE_CAMERA_SCENE
		}

		public enum VCA_RECOGNIZE_RESULT
		{
			VCA_RECOGNIZE_FAILURE,
			VCA_IMAGE_RECOGNIZE_SUCCESS,
			VCA_VIDEO_RECOGNIZE_SUCCESS_OF_BEST_LICENSE,
			VCA_VIDEO_RECOGNIZE_SUCCESS_OF_NEW_LICENSE,
			VCA_VIDEO_RECOGNIZE_FINISH_OF_CUR_LICENSE
		}

		public enum VCA_PLATE_COLOR
		{
			VCA_BLUE_PLATE,
			VCA_YELLOW_PLATE,
			VCA_WHITE_PLATE,
			VCA_BLACK_PLATE
		}

		public enum VCA_PLATE_TYPE
		{
			VCA_STANDARD92_PLATE,
			VCA_STANDARD02_PLATE,
			VCA_WJPOLICE_PLATE,
			VCA_JINGCHE_PLATE,
			STANDARD92_BACK_PLATE
		}

		public enum VCA_TRIGGER_TYPE
		{
			INTER_TRIGGER,
			EXTER_TRIGGER
		}

		public struct tagNET_VCA_PLATE_PARAM
		{
			public tagNET_VCA_RECT struSearchRect;

			public tagNET_VCA_RECT struInvalidateRect;

			public ushort wMinPlateWidth;

			public ushort wTriggerDuration;

			public byte byTriggerType;

			public byte bySensitivity;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byCharPriority;
		}

		public struct tagNET_VCA_PLATEINFO
		{
			public VCA_RECOGNIZE_SCENE eRecogniseScene;

			public tagNET_VCA_PLATE_PARAM struModifyParam;
		}

		public struct tagNET_VCA_PLATECFG
		{
			public uint dwSize;

			public byte byPicProType;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;

			public NET_DVR_JPEGPARA struPictureParam;

			public tagNET_VCA_PLATEINFO struPlateInfo;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 14, ArraySubType = UnmanagedType.Struct)]
			public NET_DVR_SCHEDTIME[] struAlarmTime;

			public NET_DVR_HANDLEEXCEPTION_V30 struHandleType;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byRelRecordChan;
		}

		public struct tagNET_VCA_PLATE_INFO
		{
			public VCA_RECOGNIZE_RESULT eResultFlag;

			public VCA_PLATE_TYPE ePlateType;

			public VCA_PLATE_COLOR ePlateColor;

			public tagNET_VCA_RECT struPlateRect;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.U4)]
			public uint[] dwRes;

			public uint dwLicenseLen;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sLicense;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sBelieve;
		}

		public struct tagNET_VCA_PLATE_RESULT
		{
			public uint dwSize;

			public uint dwRelativeTime;

			public uint dwAbsTime;

			public byte byPlateNum;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.Struct)]
			public tagNET_VCA_PLATE_INFO[] struPlateInfo;

			public uint dwPicDataLen;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.U4)]
			public uint[] dwRes2;

			public IntPtr pImage;
		}

		public struct tagNET_IVMS_ONE_RULE_
		{
			public byte byActive;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 7, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byRuleName;

			public VCA_EVENT_TYPE dwEventType;

			public tagNET_VCA_EVENT_UNION uEventParam;

			public tagNET_VCA_SIZE_FILTER struSizeFilter;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 68, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}

		public struct tagNET_IVMS_RULECFG
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.Struct)]
			public tagNET_IVMS_ONE_RULE_[] struRule;
		}

		public struct tagNET_IVMS_BEHAVIORCFG
		{
			public uint dwSize;

			public byte byPicProType;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;

			public NET_DVR_JPEGPARA struPicParam;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 28, ArraySubType = UnmanagedType.Struct)]
			public tagNET_IVMS_RULECFG[] struRuleCfg;
		}

		public struct tagNET_IVMS_DEVSCHED
		{
			public NET_DVR_SCHEDTIME struTime;

			public NET_DVR_PU_STREAM_CFG struPUStream;
		}

		public struct tagNET_IVMS_STREAMCFG
		{
			public uint dwSize;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 28, ArraySubType = UnmanagedType.Struct)]
			public tagNET_IVMS_DEVSCHED[] struDevSched;
		}

		public struct tagNET_VCA_MASK_REGION
		{
			public byte byEnable;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;

			public tagNET_VCA_POLYGON struPolygon;
		}

		public struct tagNET_VCA_MASK_REGION_LIST
		{
			public uint dwSize;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.Struct)]
			public tagNET_VCA_MASK_REGION[] struMask;
		}

		public struct tagNET_VCA_ENTER_REGION
		{
			public uint dwSize;

			public byte byEnable;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;

			public tagNET_VCA_POLYGON struPolygon;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}

		public struct tagNET_VCA_LINE_SEGMENT
		{
			public tagNET_VCA_POINT struStartPoint;

			public tagNET_VCA_POINT struEndPoint;

			public float fValue;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		public struct tagNET_VCA_LINE_SEG_LIST
		{
			public uint dwSize;

			public byte bySegNum;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.Struct)]
			public tagNET_VCA_LINE_SEGMENT[] struSeg;
		}

		public struct tagNET_IVMS_MASK_REGION_LIST
		{
			public uint dwSize;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 28, ArraySubType = UnmanagedType.Struct)]
			public tagNET_VCA_MASK_REGION_LIST[] struList;
		}

		public struct tagNET_IVMS_ENTER_REGION
		{
			public uint dwSize;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 28, ArraySubType = UnmanagedType.Struct)]
			public tagNET_VCA_ENTER_REGION[] struEnter;
		}

		public struct tagNET_IVMS_ALARM_JPEG
		{
			public byte byPicProType;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;

			public NET_DVR_JPEGPARA struPicParam;
		}

		public struct tagNET_IVMS_SEARCHCFG
		{
			public uint dwSize;

			public NET_DVR_MATRIX_DEC_REMOTE_PLAY struRemotePlay;

			public tagNET_IVMS_ALARM_JPEG struAlarmJpeg;

			public tagNET_IVMS_RULECFG struRuleCfg;
		}

		public struct tagNET_DVR_AP_INFO
		{
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
			public string sSsid;

			public uint dwMode;

			public uint dwSecurity;

			public uint dwChannel;

			public uint dwSignalStrength;

			public uint dwSpeed;
		}

		public struct tagNET_DVR_AP_INFO_LIST
		{
			public uint dwSize;

			public uint dwCount;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.Struct)]
			public tagNET_DVR_AP_INFO[] struApInfo;
		}

		public struct tagNET_DVR_WIFIETHERNET
		{
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sIpAddress;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sIpMask;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
			public byte[] byMACAddr;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] bRes;

			public uint dwEnableDhcp;

			public uint dwAutoDns;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sFirstDns;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sSecondDns;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sGatewayIpAddr;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
			public byte[] bRes2;
		}

		public struct tagNET_DVR__WIFI_CFG_EX
		{
			[StructLayout(LayoutKind.Explicit)]
			public struct key
			{
				public struct wep
				{
					public uint dwAuthentication;

					public uint dwKeyLength;

					public uint dwKeyType;

					public uint dwActive;

					[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 132)]
					public string sKeyInfo;
				}

				public struct wpa_psk
				{
					public uint dwKeyLength;

					[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 63)]
					public string sKeyInfo;

					public byte sRes;
				}
			}

			public tagNET_DVR_WIFIETHERNET struEtherNet;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
			public string sEssid;

			public uint dwMode;

			public uint dwSecurity;
		}

		public struct tagNET_DVR_WIFI_CFG
		{
			public uint dwSize;

			public tagNET_DVR__WIFI_CFG_EX struWifiCfg;
		}

		public struct tagNET_DVR_WIFI_WORKMODE
		{
			public uint dwSize;

			public uint dwNetworkInterfaceMode;
		}

		public struct tagNET_DVR_SINGLE_NET_DISK_INFO
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;

			public NET_DVR_IPADDR struNetDiskAddr;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
			public byte[] sDirectory;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 68, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}

		public struct tagNET_DVR_NET_DISKCFG
		{
			public uint dwSize;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.Struct)]
			public tagNET_DVR_SINGLE_NET_DISK_INFO[] struNetDiskParam;
		}

		public enum MAIN_EVENT_TYPE
		{
			EVENT_MOT_DET,
			EVENT_ALARM_IN,
			EVENT_VCA_BEHAVIOR
		}

		public enum BEHAVIOR_MINOR_TYPE
		{
			EVENT_TRAVERSE_PLANE,
			EVENT_ENTER_AREA,
			EVENT_EXIT_AREA,
			EVENT_INTRUSION,
			EVENT_LOITER,
			EVENT_LEFT_TAKE,
			EVENT_PARKING,
			EVENT_RUN,
			EVENT_HIGH_DENSITY,
			EVENT_STICK_UP,
			EVENT_INSTALL_SCANNER
		}

		public struct struAlarmParam
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 160, ArraySubType = UnmanagedType.I1)]
			public byte[] byAlarmInNo;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 140, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;

			public void init()
			{
				byAlarmInNo = new byte[160];
				byRes = new byte[236];
			}
		}

		public struct struMotionParam
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byMotDetChanNo;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 236, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;

			public void init()
			{
				byMotDetChanNo = new byte[64];
				byRes = new byte[236];
			}
		}

		public struct struVcaParam
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byChanNo;

			public byte byRuleID;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 43, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;

			public void init()
			{
				byChanNo = new byte[64];
				byRes1 = new byte[43];
			}
		}

		[StructLayout(LayoutKind.Explicit)]
		public struct uSeniorParam
		{
			[FieldOffset(0)]
			public struMotionParam struMotionPara;

			[FieldOffset(0)]
			public struAlarmParam struAlarmPara;

			public void init()
			{
				struAlarmPara = default(struAlarmParam);
				struAlarmPara.init();
			}
		}

		public struct tagNET_DVR_SEARCH_EVENT_PARAM
		{
			public ushort wMajorType;

			public ushort wMinorType;

			public NET_DVR_TIME struStartTime;

			public NET_DVR_TIME struEndTime;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 132, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;

			public uSeniorParam uSeniorPara;

			public void init()
			{
				byRes = new byte[132];
				uSeniorPara = default(uSeniorParam);
				uSeniorPara.init();
			}
		}

		public struct struAlarmRet
		{
			public uint dwAlarmInNo;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 300, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;

			public void init()
			{
				byRes = new byte[300];
			}
		}

		public struct struMotionRet
		{
			public uint dwMotDetNo;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 300, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;

			public void init()
			{
				byRes = new byte[300];
			}
		}

		public struct struVcaRet
		{
			public uint dwChanNo;

			public byte byRuleID;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byRuleName;

			public tagNET_VCA_EVENT_UNION uEvent;

			public void init()
			{
				byRes1 = new byte[3];
				byRuleName = new byte[32];
			}
		}

		[StructLayout(LayoutKind.Explicit)]
		public struct uSeniorRet
		{
			[FieldOffset(0)]
			public struAlarmRet struAlarmRe;

			[FieldOffset(0)]
			public struMotionRet struMotionRe;

			public void init()
			{
				struAlarmRe = default(struAlarmRet);
				struAlarmRe.init();
			}
		}

		public struct tagNET_DVR_SEARCH_EVENT_RET
		{
			public ushort wMajorType;

			public ushort wMinorType;

			public NET_DVR_TIME struStartTime;

			public NET_DVR_TIME struEndTime;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byChan;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 36, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;

			public uSeniorRet uSeniorRe;

			public void init()
			{
				byChan = new byte[64];
				byRes = new byte[36];
				uSeniorRe = default(uSeniorRet);
				uSeniorRe.init();
			}
		}

		public enum Anonymous_26594f67_851c_4f7d_bec4_094765b7ff83
		{
			BLUE_PLATE,
			YELLOW_PLATE,
			WHITE_PLATE,
			BLACK_PLATE
		}

		public struct tagNET_DVR_PLATE_RET
		{
			public uint dwSize;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byPlateNum;

			public byte byVehicleType;

			public byte byTrafficLight;

			public byte byPlateColor;

			public byte byDriveChan;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byTimeInfo;

			public byte byCarSpeed;

			public byte byCarSpeedH;

			public byte byCarSpeedL;

			public byte byRes;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 988, ArraySubType = UnmanagedType.I1)]
			public byte[] byInfo;

			public uint dwPicLen;
		}

		public struct tagNET_DVR_CCD_CFG
		{
			public uint dwSize;

			public byte byBlc;

			public byte byBlcMode;

			public byte byAwb;

			public byte byAgc;

			public byte byDayNight;

			public byte byMirror;

			public byte byShutter;

			public byte byIrCutTime;

			public byte byLensType;

			public byte byEnVideoTrig;

			public byte byCapShutter;

			public byte byEnRecognise;
		}

		public struct tagCAMERAPARAMCFG
		{
			public uint dwSize;

			public uint dwPowerLineFrequencyMode;

			public uint dwWhiteBalanceMode;

			public uint dwWhiteBalanceModeRGain;

			public uint dwWhiteBalanceModeBGain;

			public uint dwExposureMode;

			public uint dwExposureSet;

			public uint dwExposureUserSet;

			public uint dwExposureTarget;

			public uint dwIrisMode;

			public uint dwGainLevel;

			public uint dwBrightnessLevel;

			public uint dwContrastLevel;

			public uint dwSharpnessLevel;

			public uint dwSaturationLevel;

			public uint dwHueLevel;

			public uint dwGammaCorrectionEnabled;

			public uint dwGammaCorrectionLevel;

			public uint dwWDREnabled;

			public uint dwWDRLevel1;

			public uint dwWDRLevel2;

			public uint dwWDRContrastLevel;

			public uint dwDayNightFilterType;

			public uint dwSwitchScheduleEnabled;

			public uint dwBeginTime;

			public uint dwEndTime;

			public uint dwDayToNightFilterLevel;

			public uint dwNightToDayFilterLevel;

			public uint dwDayNightFilterTime;

			public uint dwBacklightMode;

			public uint dwPositionX1;

			public uint dwPositionY1;

			public uint dwPositionX2;

			public uint dwPositionY2;

			public uint dwBacklightLevel;

			public uint dwDigitalNoiseRemoveEnable;

			public uint dwDigitalNoiseRemoveLevel;

			public uint dwMirror;

			public uint dwDigitalZoom;

			public uint dwDeadPixelDetect;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.U4)]
			public uint[] dwRes;
		}

		public struct tagIMAGEREGION
		{
			public uint dwSize;

			public ushort wImageRegionTopLeftX;

			public ushort wImageRegionTopLeftY;

			public ushort wImageRegionWidth;

			public ushort wImageRegionHeight;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		public struct tagIMAGESUBPARAM
		{
			public NET_DVR_SCHEDTIME struImageStatusTime;

			public byte byImageEnhancementLevel;

			public byte byImageDenoiseLevel;

			public byte byImageStableEnable;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 9, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		public struct tagIMAGEPARAM
		{
			public uint dwSize;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 28, ArraySubType = UnmanagedType.Struct)]
			public tagIMAGESUBPARAM[] struImageParamSched;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		public struct NET_DVR_CLIENTINFO
		{
			public int lChannel;

			public int lLinkMode;

			public IntPtr hPlayWnd;

			public string sMultiCastIP;
		}

		public struct NET_SDK_CLIENTINFO
		{
			public int lChannel;

			public int lLinkType;

			public int lLinkMode;

			public IntPtr hPlayWnd;

			public string sMultiCastIP;

			public int iMediaSrvNum;

			public IntPtr pMediaSrvDir;
		}

		public struct LPNET_DVR_FIND_PICTURE
		{
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
			public string sFileName;

			public NET_DVR_TIME struTime;

			public uint dwFileSize;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 40)]
			public string sCardNum;

			public byte byPlateColor;

			public byte byVehicleLogo;

			public byte byEventSearchStatus;

			public byte byRecogResult;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sLicense;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		public struct NET_DVR_FIND_PICTURE_PARAM
		{
			public uint dwSize;

			public int lChannel;

			public byte byFileType;

			public byte byNeedCard;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
			public byte[] sCardNum;

			public NET_DVR_TIME struStartTime;

			public NET_DVR_TIME struStopTime;

			public uint dwTrafficType;

			public uint dwVehicleType;

			public uint dwIllegalType;

			public byte byLaneNo;

			public byte bySubHvtType;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sLicense;

			public byte byRegion;

			public byte byCountry;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes3;
		}

		public struct PLAY_INFO
		{
			public int iUserID;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 20)]
			public string strDeviceIP;

			public int iDevicePort;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
			public string strDevAdmin;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string strDevPsd;

			public int iChannel;

			public int iLinkMode;

			public bool bUseMedia;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 20)]
			public string strMediaIP;

			public int iMediaPort;
		}

		public struct NET_DVR_SETUPALARM_PARAM
		{
			public uint dwSize;

			public byte byLevel;

			public byte byAlarmInfoType;

			public byte byRetAlarmTypeV40;

			public byte byRetDevInfoVersion;

			public byte byRetVQDAlarmType;

			public byte byFaceAlarmDetection;

			public byte bySupport;

			public byte byBrokenNetHttp;

			public ushort wTaskNo;

			public byte byDeployType;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;

			public byte byAlarmTypeURL;

			public byte byCustomCtrl;
		}

		public struct BLOCKTIME
		{
			public ushort wYear;

			public byte bMonth;

			public byte bDay;

			public byte bHour;

			public byte bMinute;

			public byte bSecond;
		}

		public struct VODSEARCHPARAM
		{
			public IntPtr sessionHandle;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
			public string dvrIP;

			public uint dvrPort;

			public uint channelNum;

			public BLOCKTIME startTime;

			public BLOCKTIME stopTime;

			public bool bUseIPServer;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
			public string SerialNumber;
		}

		public struct SECTIONLIST
		{
			public BLOCKTIME startTime;

			public BLOCKTIME stopTime;

			public byte byRecType;

			public IntPtr pNext;
		}

		public struct VODOPENPARAM
		{
			public IntPtr sessionHandle;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
			public string dvrIP;

			public uint dvrPort;

			public uint channelNum;

			public BLOCKTIME startTime;

			public BLOCKTIME stopTime;

			public uint uiUser;

			public bool bUseIPServer;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
			public string SerialNumber;

			public VodStreamFrameData streamFrameData;
		}

		public struct CONNPARAM
		{
			public uint uiUser;

			public ErrorCallback errorCB;
		}

		public delegate void ErrorCallback(IntPtr hSession, uint dwUser, int lErrorType);

		public delegate void VodStreamFrameData(IntPtr hStream, uint dwUser, int lFrameType, IntPtr pBuffer, uint dwSize);

		public struct PACKET_INFO
		{
			public int nPacketType;

			public IntPtr pPacketBuffer;

			public uint dwPacketSize;

			public int nYear;

			public int nMonth;

			public int nDay;

			public int nHour;

			public int nMinute;

			public int nSecond;

			public uint dwTimeStamp;
		}

		public struct STOREINFO
		{
			public int iMaxChannels;

			public int iDiskGroup;

			public int iStreamType;

			public bool bAnalyze;

			public bool bCycWrite;

			public uint uiFileSize;

			public CALLBACKFUN_MESSAGE funCallback;
		}

		public struct CREATEFILE_INFO
		{
			public int iHandle;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
			public string strCameraid;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
			public string strFileName;

			public BLOCKTIME tFileCreateTime;
		}

		public struct CLOSEFILE_INFO
		{
			public int iHandle;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
			public string strCameraid;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
			public string strFileName;

			public BLOCKTIME tFileSwitchTime;
		}

		public delegate int CALLBACKFUN_MESSAGE(int iMessageType, IntPtr pBuf, int iBufLen);

		public struct NET_DVR_LOG_MATRIX
		{
			public NET_DVR_TIME strLogTime;

			public uint dwMajorType;

			public uint dwMinorType;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] sPanelUser;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] sNetUser;

			public NET_DVR_IPADDR struRemoteHostAddr;

			public uint dwParaType;

			public uint dwChannel;

			public uint dwDiskNumber;

			public uint dwAlarmInPort;

			public uint dwAlarmOutPort;

			public uint dwInfoLen;

			public byte byDevSequence;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
			public byte[] byMacAddr;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 48, ArraySubType = UnmanagedType.I1)]
			public byte[] sSerialNumber;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11785)]
			public string sInfo;
		}

		public struct tagVEDIOPLATLOG
		{
			public byte bySearchCondition;

			public byte byDevSequence;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 48, ArraySubType = UnmanagedType.I1)]
			public byte[] sSerialNumber;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
			public byte[] byMacAddr;
		}

		public const int MAX_SUBSYSTEM_NUM = 80;

		public const int MAX_SERIALLEN = 36;

		public const int MAX_LOOPPLANNUM = 16;

		public const int DECODE_TIMESEGMENT = 4;

		public const int MAX_DOMAIN_NAME = 64;

		public const int MAX_DISKNUM_V30 = 33;

		public const int MAX_DAYS = 7;

		public const int NET_DVR_PLAY_REVERSE = 30;

		public const int VIDEOPLATFORM_ABILITY = 528;

		public const int SDK_PLAYMPEG4 = 1;

		public const int SDK_HCNETSDK = 2;

		public const int INSERTTYPE = 0;

		public const int MODIFYTYPE = 1;

		public const int DELETETYPE = 2;

		public const int DEF_OPE_PREVIEW = 1;

		public const int DEF_OPE_TALK = 2;

		public const int DEF_OPE_SETALARM = 3;

		public const int DEF_OPE_PTZCTRL = 4;

		public const int DEF_OPE_VIDEOPARAM = 5;

		public const int DEF_OPE_PLAYBACK = 6;

		public const int DEF_OPE_REMOTECFG = 7;

		public const int DEF_OPE_GETSERVSTATE = 8;

		public const int DEF_OPE_CHECKTIME = 9;

		public const int DEF_OPE_PRE_STARTPREVIEW = 1;

		public const int DEF_OPE_PRE_STOPPREVIEW = 2;

		public const int DEF_OPE_PRE_STRATCYCPLAY = 3;

		public const int DEF_OPE_PRE_STOPCYCPLAY = 4;

		public const int DEF_OPE_PRE_STARTRECORD = 5;

		public const int DEF_OPE_PRE_STOPRECORD = 6;

		public const int DEF_OPE_PRE_CAPTURE = 7;

		public const int DEF_OPE_PRE_OPENSOUND = 8;

		public const int DEF_OPE_PRE_CLOSESOUND = 9;

		public const int DEF_OPE_TALK_STARTTALK = 1;

		public const int DEF_OPE_TALK_STOPTALK = 2;

		public const int DEF_OPE_ALARM_SETALARM = 1;

		public const int DEF_OPE_ALARM_WITHDRAWALARM = 2;

		public const int DEF_OPE_PTZ_PTZCTRL = 1;

		public const int DEF_OPE_VIDEOPARAM_SET = 1;

		public const int DEF_OPE_PLAYBACK_LOCALSEARCH = 1;

		public const int DEF_OPE_PLAYBACK_LOCALPLAY = 2;

		public const int DEF_OPE_PLAYBACK_LOCALDOWNLOAD = 3;

		public const int DEF_OPE_PLAYBACK_REMOTESEARCH = 4;

		public const int DEF_OPE_PLAYBACK_REMOTEPLAYFILE = 5;

		public const int DEF_OPE_PLAYBACK_REMOTEPLAYTIME = 6;

		public const int DEF_OPE_PLAYBACK_REMOTEDOWNLOAD = 7;

		public const int DEF_OPE_REMOTE_REMOTECFG = 1;

		public const int DEF_OPE_STATE_GETSERVSTATE = 1;

		public const int DEF_OPE_CHECKT_CHECKTIME = 1;

		public const int DEF_ALARM_IO = 1;

		public const int DEF_ALARM_HARDFULL = 2;

		public const int DEF_ALARM_VL = 3;

		public const int DEF_ALARM_MV = 4;

		public const int DEF_ALARM_HARDFORMAT = 5;

		public const int DEF_ALARM_HARDERROR = 6;

		public const int DEF_ALARM_VH = 7;

		public const int DEF_ALARM_NOPATCH = 8;

		public const int DEF_ALARM_ERRORVISIT = 9;

		public const int DEF_ALARM_EXCEPTION = 10;

		public const int DEF_ALARM_RECERROR = 11;

		public const int DEF_SYS_LOGIN = 1;

		public const int DEF_SYS_LOGOUT = 2;

		public const int DEF_SYS_LOCALCFG = 3;

		public const int NAME_LEN = 32;

		public const int PASSWD_LEN = 16;

		public const int MAX_NAMELEN = 16;

		public const int MAX_RIGHT = 32;

		public const int SERIALNO_LEN = 48;

		public const int MACADDR_LEN = 6;

		public const int MAX_ETHERNET = 2;

		public const int PATHNAME_LEN = 128;

		public const int MAX_TIMESEGMENT_V30 = 8;

		public const int MAX_TIMESEGMENT = 4;

		public const int MAX_SHELTERNUM = 4;

		public const int PHONENUMBER_LEN = 32;

		public const int MAX_DISKNUM = 16;

		public const int MAX_DISKNUM_V10 = 8;

		public const int MAX_WINDOW_V30 = 32;

		public const int MAX_WINDOW = 16;

		public const int MAX_VGA_V30 = 4;

		public const int MAX_VGA = 1;

		public const int MAX_USERNUM_V30 = 32;

		public const int MAX_USERNUM = 16;

		public const int MAX_EXCEPTIONNUM_V30 = 32;

		public const int MAX_EXCEPTIONNUM = 16;

		public const int MAX_LINK = 6;

		public const int MAX_DECPOOLNUM = 4;

		public const int MAX_DECNUM = 4;

		public const int MAX_TRANSPARENTNUM = 2;

		public const int MAX_CYCLE_CHAN = 16;

		public const int MAX_CYCLE_CHAN_V30 = 64;

		public const int MAX_DIRNAME_LENGTH = 80;

		public const int MAX_WINDOWS = 16;

		public const int MAX_STRINGNUM_V30 = 8;

		public const int MAX_STRINGNUM = 4;

		public const int MAX_STRINGNUM_EX = 8;

		public const int MAX_AUXOUT_V30 = 16;

		public const int MAX_AUXOUT = 4;

		public const int MAX_HD_GROUP = 16;

		public const int MAX_NFS_DISK = 8;

		public const int IW_ESSID_MAX_SIZE = 32;

		public const int IW_ENCODING_TOKEN_MAX = 32;

		public const int MAX_SERIAL_NUM = 64;

		public const int MAX_DDNS_NUMS = 10;

		public const int MAX_EMAIL_ADDR_LEN = 48;

		public const int MAX_EMAIL_PWD_LEN = 32;

		public const int MAXPROGRESS = 100;

		public const int MAX_SERIALNUM = 2;

		public const int CARDNUM_LEN = 20;

		public const int MAX_VIDEOOUT_V30 = 4;

		public const int MAX_VIDEOOUT = 2;

		public const int MAX_PRESET_V30 = 256;

		public const int MAX_TRACK_V30 = 256;

		public const int MAX_CRUISE_V30 = 256;

		public const int MAX_PRESET = 128;

		public const int MAX_TRACK = 128;

		public const int MAX_CRUISE = 128;

		public const int CRUISE_MAX_PRESET_NUMS = 32;

		public const int MAX_SERIAL_PORT = 8;

		public const int MAX_PREVIEW_MODE = 8;

		public const int MAX_MATRIXOUT = 16;

		public const int LOG_INFO_LEN = 11840;

		public const int DESC_LEN = 16;

		public const int PTZ_PROTOCOL_NUM = 200;

		public const int MAX_AUDIO = 1;

		public const int MAX_AUDIO_V30 = 2;

		public const int MAX_CHANNUM = 16;

		public const int MAX_ALARMIN = 16;

		public const int MAX_ALARMOUT = 4;

		public const int MAX_ANALOG_CHANNUM = 32;

		public const int MAX_ANALOG_ALARMOUT = 32;

		public const int MAX_ANALOG_ALARMIN = 32;

		public const int MAX_IP_DEVICE = 32;

		public const int MAX_IP_CHANNEL = 32;

		public const int MAX_IP_ALARMIN = 128;

		public const int MAX_IP_ALARMOUT = 64;

		public const int MAX_ATM_NUM = 1;

		public const int MAX_ACTION_TYPE = 12;

		public const int ATM_FRAMETYPE_NUM = 4;

		public const int MAX_ATM_PROTOCOL_NUM = 1025;

		public const int ATM_PROTOCOL_SORT = 4;

		public const int ATM_DESC_LEN = 32;

		public const int MAX_CHANNUM_V30 = 64;

		public const int MAX_ALARMOUT_V30 = 96;

		public const int MAX_ALARMIN_V30 = 160;

		public const int NORMALCONNECT = 1;

		public const int MEDIACONNECT = 2;

		public const int HCDVR = 1;

		public const int MEDVR = 2;

		public const int PCDVR = 3;

		public const int HC_9000 = 4;

		public const int HF_I = 5;

		public const int PCNVR = 6;

		public const int HC_76NVR = 8;

		public const int DS8000HC_NVR = 0;

		public const int DS9000HC_NVR = 1;

		public const int DS8000ME_NVR = 2;

		public const int NET_DVR_NOERROR = 0;

		public const int NET_DVR_PASSWORD_ERROR = 1;

		public const int NET_DVR_NOENOUGHPRI = 2;

		public const int NET_DVR_NOINIT = 3;

		public const int NET_DVR_CHANNEL_ERROR = 4;

		public const int NET_DVR_OVER_MAXLINK = 5;

		public const int NET_DVR_VERSIONNOMATCH = 6;

		public const int NET_DVR_NETWORK_FAIL_CONNECT = 7;

		public const int NET_DVR_NETWORK_SEND_ERROR = 8;

		public const int NET_DVR_NETWORK_RECV_ERROR = 9;

		public const int NET_DVR_NETWORK_RECV_TIMEOUT = 10;

		public const int NET_DVR_NETWORK_ERRORDATA = 11;

		public const int NET_DVR_ORDER_ERROR = 12;

		public const int NET_DVR_OPERNOPERMIT = 13;

		public const int NET_DVR_COMMANDTIMEOUT = 14;

		public const int NET_DVR_ERRORSERIALPORT = 15;

		public const int NET_DVR_ERRORALARMPORT = 16;

		public const int NET_DVR_PARAMETER_ERROR = 17;

		public const int NET_DVR_CHAN_EXCEPTION = 18;

		public const int NET_DVR_NODISK = 19;

		public const int NET_DVR_ERRORDISKNUM = 20;

		public const int NET_DVR_DISK_FULL = 21;

		public const int NET_DVR_DISK_ERROR = 22;

		public const int NET_DVR_NOSUPPORT = 23;

		public const int NET_DVR_BUSY = 24;

		public const int NET_DVR_MODIFY_FAIL = 25;

		public const int NET_DVR_PASSWORD_FORMAT_ERROR = 26;

		public const int NET_DVR_DISK_FORMATING = 27;

		public const int NET_DVR_DVRNORESOURCE = 28;

		public const int NET_DVR_DVROPRATEFAILED = 29;

		public const int NET_DVR_OPENHOSTSOUND_FAIL = 30;

		public const int NET_DVR_DVRVOICEOPENED = 31;

		public const int NET_DVR_TIMEINPUTERROR = 32;

		public const int NET_DVR_NOSPECFILE = 33;

		public const int NET_DVR_CREATEFILE_ERROR = 34;

		public const int NET_DVR_FILEOPENFAIL = 35;

		public const int NET_DVR_OPERNOTFINISH = 36;

		public const int NET_DVR_GETPLAYTIMEFAIL = 37;

		public const int NET_DVR_PLAYFAIL = 38;

		public const int NET_DVR_FILEFORMAT_ERROR = 39;

		public const int NET_DVR_DIR_ERROR = 40;

		public const int NET_DVR_ALLOC_RESOURCE_ERROR = 41;

		public const int NET_DVR_AUDIO_MODE_ERROR = 42;

		public const int NET_DVR_NOENOUGH_BUF = 43;

		public const int NET_DVR_CREATESOCKET_ERROR = 44;

		public const int NET_DVR_SETSOCKET_ERROR = 45;

		public const int NET_DVR_MAX_NUM = 46;

		public const int NET_DVR_USERNOTEXIST = 47;

		public const int NET_DVR_WRITEFLASHERROR = 48;

		public const int NET_DVR_UPGRADEFAIL = 49;

		public const int NET_DVR_CARDHAVEINIT = 50;

		public const int NET_DVR_PLAYERFAILED = 51;

		public const int NET_DVR_MAX_USERNUM = 52;

		public const int NET_DVR_GETLOCALIPANDMACFAIL = 53;

		public const int NET_DVR_NOENCODEING = 54;

		public const int NET_DVR_IPMISMATCH = 55;

		public const int NET_DVR_MACMISMATCH = 56;

		public const int NET_DVR_UPGRADELANGMISMATCH = 57;

		public const int NET_DVR_MAX_PLAYERPORT = 58;

		public const int NET_DVR_NOSPACEBACKUP = 59;

		public const int NET_DVR_NODEVICEBACKUP = 60;

		public const int NET_DVR_PICTURE_BITS_ERROR = 61;

		public const int NET_DVR_PICTURE_DIMENSION_ERROR = 62;

		public const int NET_DVR_PICTURE_SIZ_ERROR = 63;

		public const int NET_DVR_LOADPLAYERSDKFAILED = 64;

		public const int NET_DVR_LOADPLAYERSDKPROC_ERROR = 65;

		public const int NET_DVR_LOADDSSDKFAILED = 66;

		public const int NET_DVR_LOADDSSDKPROC_ERROR = 67;

		public const int NET_DVR_DSSDK_ERROR = 68;

		public const int NET_DVR_VOICEMONOPOLIZE = 69;

		public const int NET_DVR_JOINMULTICASTFAILED = 70;

		public const int NET_DVR_CREATEDIR_ERROR = 71;

		public const int NET_DVR_BINDSOCKET_ERROR = 72;

		public const int NET_DVR_SOCKETCLOSE_ERROR = 73;

		public const int NET_DVR_USERID_ISUSING = 74;

		public const int NET_DVR_SOCKETLISTEN_ERROR = 75;

		public const int NET_DVR_PROGRAM_EXCEPTION = 76;

		public const int NET_DVR_WRITEFILE_FAILED = 77;

		public const int NET_DVR_FORMAT_READONLY = 78;

		public const int NET_DVR_WITHSAMEUSERNAME = 79;

		public const int NET_DVR_DEVICETYPE_ERROR = 80;

		public const int NET_DVR_LANGUAGE_ERROR = 81;

		public const int NET_DVR_PARAVERSION_ERROR = 82;

		public const int NET_DVR_IPCHAN_NOTALIVE = 83;

		public const int NET_DVR_RTSP_SDK_ERROR = 84;

		public const int NET_DVR_CONVERT_SDK_ERROR = 85;

		public const int NET_DVR_IPC_COUNT_OVERFLOW = 86;

		public const int NET_PLAYM4_NOERROR = 500;

		public const int NET_PLAYM4_PARA_OVER = 501;

		public const int NET_PLAYM4_ORDER_ERROR = 502;

		public const int NET_PLAYM4_TIMER_ERROR = 503;

		public const int NET_PLAYM4_DEC_VIDEO_ERROR = 504;

		public const int NET_PLAYM4_DEC_AUDIO_ERROR = 505;

		public const int NET_PLAYM4_ALLOC_MEMORY_ERROR = 506;

		public const int NET_PLAYM4_OPEN_FILE_ERROR = 507;

		public const int NET_PLAYM4_CREATE_OBJ_ERROR = 508;

		public const int NET_PLAYM4_CREATE_DDRAW_ERROR = 509;

		public const int NET_PLAYM4_CREATE_OFFSCREEN_ERROR = 510;

		public const int NET_PLAYM4_BUF_OVER = 511;

		public const int NET_PLAYM4_CREATE_SOUND_ERROR = 512;

		public const int NET_PLAYM4_SET_VOLUME_ERROR = 513;

		public const int NET_PLAYM4_SUPPORT_FILE_ONLY = 514;

		public const int NET_PLAYM4_SUPPORT_STREAM_ONLY = 515;

		public const int NET_PLAYM4_SYS_NOT_SUPPORT = 516;

		public const int NET_PLAYM4_FILEHEADER_UNKNOWN = 517;

		public const int NET_PLAYM4_VERSION_INCORRECT = 518;

		public const int NET_PALYM4_INIT_DECODER_ERROR = 519;

		public const int NET_PLAYM4_CHECK_FILE_ERROR = 520;

		public const int NET_PLAYM4_INIT_TIMER_ERROR = 521;

		public const int NET_PLAYM4_BLT_ERROR = 522;

		public const int NET_PLAYM4_UPDATE_ERROR = 523;

		public const int NET_PLAYM4_OPEN_FILE_ERROR_MULTI = 524;

		public const int NET_PLAYM4_OPEN_FILE_ERROR_VIDEO = 525;

		public const int NET_PLAYM4_JPEG_COMPRESS_ERROR = 526;

		public const int NET_PLAYM4_EXTRACT_NOT_SUPPORT = 527;

		public const int NET_PLAYM4_EXTRACT_DATA_ERROR = 528;

		public const int NET_DVR_SUPPORT_DDRAW = 1;

		public const int NET_DVR_SUPPORT_BLT = 2;

		public const int NET_DVR_SUPPORT_BLTFOURCC = 4;

		public const int NET_DVR_SUPPORT_BLTSHRINKX = 8;

		public const int NET_DVR_SUPPORT_BLTSHRINKY = 16;

		public const int NET_DVR_SUPPORT_BLTSTRETCHX = 32;

		public const int NET_DVR_SUPPORT_BLTSTRETCHY = 64;

		public const int NET_DVR_SUPPORT_SSE = 128;

		public const int NET_DVR_SUPPORT_MMX = 256;

		public const int LIGHT_PWRON = 2;

		public const int WIPER_PWRON = 3;

		public const int FAN_PWRON = 4;

		public const int HEATER_PWRON = 5;

		public const int AUX_PWRON1 = 6;

		public const int AUX_PWRON2 = 7;

		public const int SET_PRESET = 8;

		public const int CLE_PRESET = 9;

		public const int ZOOM_IN = 11;

		public const int ZOOM_OUT = 12;

		public const int FOCUS_NEAR = 13;

		public const int FOCUS_FAR = 14;

		public const int IRIS_OPEN = 15;

		public const int IRIS_CLOSE = 16;

		public const int TILT_UP = 21;

		public const int TILT_DOWN = 22;

		public const int PAN_LEFT = 23;

		public const int PAN_RIGHT = 24;

		public const int UP_LEFT = 25;

		public const int UP_RIGHT = 26;

		public const int DOWN_LEFT = 27;

		public const int DOWN_RIGHT = 28;

		public const int PAN_AUTO = 29;

		public const int FILL_PRE_SEQ = 30;

		public const int SET_SEQ_DWELL = 31;

		public const int SET_SEQ_SPEED = 32;

		public const int CLE_PRE_SEQ = 33;

		public const int STA_MEM_CRUISE = 34;

		public const int STO_MEM_CRUISE = 35;

		public const int RUN_CRUISE = 36;

		public const int RUN_SEQ = 37;

		public const int STOP_SEQ = 38;

		public const int GOTO_PRESET = 39;

		public const int NET_DVR_PLAYSTART = 1;

		public const int NET_DVR_PLAYSTOP = 2;

		public const int NET_DVR_PLAYPAUSE = 3;

		public const int NET_DVR_PLAYRESTART = 4;

		public const int NET_DVR_PLAYFAST = 5;

		public const int NET_DVR_PLAYSLOW = 6;

		public const int NET_DVR_PLAYNORMAL = 7;

		public const int NET_DVR_PLAYFRAME = 8;

		public const int NET_DVR_PLAYSTARTAUDIO = 9;

		public const int NET_DVR_PLAYSTOPAUDIO = 10;

		public const int NET_DVR_PLAYAUDIOVOLUME = 11;

		public const int NET_DVR_PLAYSETPOS = 12;

		public const int NET_DVR_PLAYGETPOS = 13;

		public const int NET_DVR_PLAYGETTIME = 14;

		public const int NET_DVR_PLAYGETFRAME = 15;

		public const int NET_DVR_GETTOTALFRAMES = 16;

		public const int NET_DVR_GETTOTALTIME = 17;

		public const int NET_DVR_THROWBFRAME = 20;

		public const int NET_DVR_SETSPEED = 24;

		public const int NET_DVR_KEEPALIVE = 25;

		public const int KEY_CODE_1 = 1;

		public const int KEY_CODE_2 = 2;

		public const int KEY_CODE_3 = 3;

		public const int KEY_CODE_4 = 4;

		public const int KEY_CODE_5 = 5;

		public const int KEY_CODE_6 = 6;

		public const int KEY_CODE_7 = 7;

		public const int KEY_CODE_8 = 8;

		public const int KEY_CODE_9 = 9;

		public const int KEY_CODE_0 = 10;

		public const int KEY_CODE_POWER = 11;

		public const int KEY_CODE_MENU = 12;

		public const int KEY_CODE_ENTER = 13;

		public const int KEY_CODE_CANCEL = 14;

		public const int KEY_CODE_UP = 15;

		public const int KEY_CODE_DOWN = 16;

		public const int KEY_CODE_LEFT = 17;

		public const int KEY_CODE_RIGHT = 18;

		public const int KEY_CODE_EDIT = 19;

		public const int KEY_CODE_ADD = 20;

		public const int KEY_CODE_MINUS = 21;

		public const int KEY_CODE_PLAY = 22;

		public const int KEY_CODE_REC = 23;

		public const int KEY_CODE_PAN = 24;

		public const int KEY_CODE_M = 25;

		public const int KEY_CODE_A = 26;

		public const int KEY_CODE_F1 = 27;

		public const int KEY_CODE_F2 = 28;

		public const int KEY_PTZ_UP_START = 15;

		public const int KEY_PTZ_UP_STOP = 32;

		public const int KEY_PTZ_DOWN_START = 16;

		public const int KEY_PTZ_DOWN_STOP = 33;

		public const int KEY_PTZ_LEFT_START = 17;

		public const int KEY_PTZ_LEFT_STOP = 34;

		public const int KEY_PTZ_RIGHT_START = 18;

		public const int KEY_PTZ_RIGHT_STOP = 35;

		public const int KEY_PTZ_AP1_START = 19;

		public const int KEY_PTZ_AP1_STOP = 36;

		public const int KEY_PTZ_AP2_START = 24;

		public const int KEY_PTZ_AP2_STOP = 37;

		public const int KEY_PTZ_FOCUS1_START = 26;

		public const int KEY_PTZ_FOCUS1_STOP = 38;

		public const int KEY_PTZ_FOCUS2_START = 25;

		public const int KEY_PTZ_FOCUS2_STOP = 39;

		public const int KEY_PTZ_B1_START = 40;

		public const int KEY_PTZ_B1_STOP = 41;

		public const int KEY_PTZ_B2_START = 42;

		public const int KEY_PTZ_B2_STOP = 43;

		public const int KEY_CODE_11 = 44;

		public const int KEY_CODE_12 = 45;

		public const int KEY_CODE_13 = 46;

		public const int KEY_CODE_14 = 47;

		public const int KEY_CODE_15 = 48;

		public const int KEY_CODE_16 = 49;

		public const int NET_DVR_GET_DEVICECFG = 100;

		public const int NET_DVR_SET_DEVICECFG = 101;

		public const int NET_DVR_GET_NETCFG = 102;

		public const int NET_DVR_SET_NETCFG = 103;

		public const int NET_DVR_GET_PICCFG = 104;

		public const int NET_DVR_SET_PICCFG = 105;

		public const int NET_DVR_GET_COMPRESSCFG = 106;

		public const int NET_DVR_SET_COMPRESSCFG = 107;

		public const int NET_DVR_GET_RECORDCFG = 108;

		public const int NET_DVR_SET_RECORDCFG = 109;

		public const int NET_DVR_GET_DECODERCFG = 110;

		public const int NET_DVR_SET_DECODERCFG = 111;

		public const int NET_DVR_GET_RS232CFG = 112;

		public const int NET_DVR_SET_RS232CFG = 113;

		public const int NET_DVR_GET_ALARMINCFG = 114;

		public const int NET_DVR_SET_ALARMINCFG = 115;

		public const int NET_DVR_GET_ALARMOUTCFG = 116;

		public const int NET_DVR_SET_ALARMOUTCFG = 117;

		public const int NET_DVR_GET_TIMECFG = 118;

		public const int NET_DVR_SET_TIMECFG = 119;

		public const int NET_DVR_GET_PREVIEWCFG = 120;

		public const int NET_DVR_SET_PREVIEWCFG = 121;

		public const int NET_DVR_GET_VIDEOOUTCFG = 122;

		public const int NET_DVR_SET_VIDEOOUTCFG = 123;

		public const int NET_DVR_GET_USERCFG = 124;

		public const int NET_DVR_SET_USERCFG = 125;

		public const int NET_DVR_GET_EXCEPTIONCFG = 126;

		public const int NET_DVR_SET_EXCEPTIONCFG = 127;

		public const int NET_DVR_GET_ZONEANDDST = 128;

		public const int NET_DVR_SET_ZONEANDDST = 129;

		public const int NET_DVR_GET_SHOWSTRING = 130;

		public const int NET_DVR_SET_SHOWSTRING = 131;

		public const int NET_DVR_GET_EVENTCOMPCFG = 132;

		public const int NET_DVR_SET_EVENTCOMPCFG = 133;

		public const int NET_DVR_GET_AUXOUTCFG = 140;

		public const int NET_DVR_SET_AUXOUTCFG = 141;

		public const int NET_DVR_GET_PREVIEWCFG_AUX = 142;

		public const int NET_DVR_SET_PREVIEWCFG_AUX = 143;

		public const int NET_DVR_GET_PICCFG_EX = 200;

		public const int NET_DVR_SET_PICCFG_EX = 201;

		public const int NET_DVR_GET_USERCFG_EX = 202;

		public const int NET_DVR_SET_USERCFG_EX = 203;

		public const int NET_DVR_GET_COMPRESSCFG_EX = 204;

		public const int NET_DVR_SET_COMPRESSCFG_EX = 205;

		public const int NET_DVR_GET_NETAPPCFG = 222;

		public const int NET_DVR_SET_NETAPPCFG = 223;

		public const int NET_DVR_GET_NTPCFG = 224;

		public const int NET_DVR_SET_NTPCFG = 225;

		public const int NET_DVR_GET_DDNSCFG = 226;

		public const int NET_DVR_SET_DDNSCFG = 227;

		public const int NET_DVR_GET_EMAILCFG = 228;

		public const int NET_DVR_SET_EMAILCFG = 229;

		public const int NET_DVR_GET_NFSCFG = 230;

		public const int NET_DVR_SET_NFSCFG = 231;

		public const int NET_DVR_GET_SHOWSTRING_EX = 238;

		public const int NET_DVR_SET_SHOWSTRING_EX = 239;

		public const int NET_DVR_GET_NETCFG_OTHER = 244;

		public const int NET_DVR_SET_NETCFG_OTHER = 245;

		public const int NET_DVR_GET_EMAILPARACFG = 250;

		public const int NET_DVR_SET_EMAILPARACFG = 251;

		public const int NET_DVR_GET_DDNSCFG_EX = 274;

		public const int NET_DVR_SET_DDNSCFG_EX = 275;

		public const int NET_DVR_SET_PTZPOS = 292;

		public const int NET_DVR_GET_PTZPOS = 293;

		public const int NET_DVR_GET_PTZSCOPE = 294;

		public const int NET_DVR_GET_NETCFG_V30 = 1000;

		public const int NET_DVR_SET_NETCFG_V30 = 1001;

		public const int NET_DVR_GET_PICCFG_V30 = 1002;

		public const int NET_DVR_SET_PICCFG_V30 = 1003;

		public const int NET_DVR_GET_RECORDCFG_V30 = 1004;

		public const int NET_DVR_SET_RECORDCFG_V30 = 1005;

		public const int NET_DVR_GET_USERCFG_V30 = 1006;

		public const int NET_DVR_SET_USERCFG_V30 = 1007;

		public const int NET_DVR_GET_DDNSCFG_V30 = 1010;

		public const int NET_DVR_SET_DDNSCFG_V30 = 1011;

		public const int NET_DVR_GET_EMAILCFG_V30 = 1012;

		public const int NET_DVR_SET_EMAILCFG_V30 = 1013;

		public const int NET_DVR_GET_CRUISE = 1020;

		public const int NET_DVR_SET_CRUISE = 1021;

		public const int NET_DVR_GET_ALARMINCFG_V30 = 1024;

		public const int NET_DVR_SET_ALARMINCFG_V30 = 1025;

		public const int NET_DVR_GET_ALARMOUTCFG_V30 = 1026;

		public const int NET_DVR_SET_ALARMOUTCFG_V30 = 1027;

		public const int NET_DVR_GET_VIDEOOUTCFG_V30 = 1028;

		public const int NET_DVR_SET_VIDEOOUTCFG_V30 = 1029;

		public const int NET_DVR_GET_SHOWSTRING_V30 = 1030;

		public const int NET_DVR_SET_SHOWSTRING_V30 = 1031;

		public const int NET_DVR_GET_EXCEPTIONCFG_V30 = 1034;

		public const int NET_DVR_SET_EXCEPTIONCFG_V30 = 1035;

		public const int NET_DVR_GET_RS232CFG_V30 = 1036;

		public const int NET_DVR_SET_RS232CFG_V30 = 1037;

		public const int NET_DVR_GET_NET_DISKCFG = 1038;

		public const int NET_DVR_SET_NET_DISKCFG = 1039;

		public const int NET_DVR_GET_COMPRESSCFG_V30 = 1040;

		public const int NET_DVR_SET_COMPRESSCFG_V30 = 1041;

		public const int NET_DVR_GET_DECODERCFG_V30 = 1042;

		public const int NET_DVR_SET_DECODERCFG_V30 = 1043;

		public const int NET_DVR_GET_PREVIEWCFG_V30 = 1044;

		public const int NET_DVR_SET_PREVIEWCFG_V30 = 1045;

		public const int NET_DVR_GET_PREVIEWCFG_AUX_V30 = 1046;

		public const int NET_DVR_SET_PREVIEWCFG_AUX_V30 = 1047;

		public const int NET_DVR_GET_IPPARACFG = 1048;

		public const int NET_DVR_SET_IPPARACFG = 1049;

		public const int NET_DVR_GET_IPALARMINCFG = 1050;

		public const int NET_DVR_SET_IPALARMINCFG = 1051;

		public const int NET_DVR_GET_IPALARMOUTCFG = 1052;

		public const int NET_DVR_SET_IPALARMOUTCFG = 1053;

		public const int NET_DVR_GET_HDCFG = 1054;

		public const int NET_DVR_SET_HDCFG = 1055;

		public const int NET_DVR_GET_HDGROUP_CFG = 1056;

		public const int NET_DVR_SET_HDGROUP_CFG = 1057;

		public const int NET_DVR_GET_COMPRESSCFG_AUD = 1058;

		public const int NET_DVR_SET_COMPRESSCFG_AUD = 1059;

		public const int NET_DVR_GET_IPPARACFG_V31 = 1060;

		public const int NET_DVR_SET_IPPARACFG_V31 = 1061;

		public const int NET_DVR_FILE_SUCCESS = 1000;

		public const int NET_DVR_FILE_NOFIND = 1001;

		public const int NET_DVR_ISFINDING = 1002;

		public const int NET_DVR_NOMOREFILE = 1003;

		public const int NET_DVR_FILE_EXCEPTION = 1004;

		public const int COMM_ALARM = 4352;

		public const int COMM_TRADEINFO = 5376;

		public const int COMM_ALARM_V30 = 16384;

		public const int COMM_IPCCFG = 16385;

		public const int COMM_IPCCFG_V31 = 16386;

		public const int COMM_ALARM_RULE_CALC = 4368;

		public const int EXCEPTION_EXCHANGE = 32768;

		public const int EXCEPTION_AUDIOEXCHANGE = 32769;

		public const int EXCEPTION_ALARM = 32770;

		public const int EXCEPTION_PREVIEW = 32771;

		public const int EXCEPTION_SERIAL = 32772;

		public const int EXCEPTION_RECONNECT = 32773;

		public const int EXCEPTION_ALARMRECONNECT = 32774;

		public const int EXCEPTION_SERIALRECONNECT = 32775;

		public const int EXCEPTION_PLAYBACK = 32784;

		public const int EXCEPTION_DISKFMT = 32785;

		public const int NET_DVR_SYSHEAD = 1;

		public const int NET_DVR_STREAMDATA = 2;

		public const int NET_DVR_AUDIOSTREAMDATA = 3;

		public const int NET_DVR_STD_VIDEODATA = 4;

		public const int NET_DVR_STD_AUDIODATA = 5;

		public const int NET_DVR_REALPLAYEXCEPTION = 111;

		public const int NET_DVR_REALPLAYNETCLOSE = 112;

		public const int NET_DVR_REALPLAY5SNODATA = 113;

		public const int NET_DVR_REALPLAYRECONNECT = 114;

		public const int NET_DVR_PLAYBACKOVER = 101;

		public const int NET_DVR_PLAYBACKEXCEPTION = 102;

		public const int NET_DVR_PLAYBACKNETCLOSE = 103;

		public const int NET_DVR_PLAYBACK5SNODATA = 104;

		public const int DVR = 1;

		public const int ATMDVR = 2;

		public const int DVS = 3;

		public const int DEC = 4;

		public const int ENC_DEC = 5;

		public const int DVR_HC = 6;

		public const int DVR_HT = 7;

		public const int DVR_HF = 8;

		public const int DVR_HS = 9;

		public const int DVR_HTS = 10;

		public const int DVR_HB = 11;

		public const int DVR_HCS = 12;

		public const int DVS_A = 13;

		public const int DVR_HC_S = 14;

		public const int DVR_HT_S = 15;

		public const int DVR_HF_S = 16;

		public const int DVR_HS_S = 17;

		public const int ATMDVR_S = 18;

		public const int LOWCOST_DVR = 19;

		public const int DEC_MAT = 20;

		public const int DVR_MOBILE = 21;

		public const int DVR_HD_S = 22;

		public const int DVR_HD_SL = 23;

		public const int DVR_HC_SL = 24;

		public const int DVR_HS_ST = 25;

		public const int DVS_HW = 26;

		public const int DS630X_D = 27;

		public const int IPCAM = 30;

		public const int MEGA_IPCAM = 31;

		public const int IPCAM_X62MF = 32;

		public const int IPDOME = 40;

		public const int IPDOME_MEGA200 = 41;

		public const int IPDOME_MEGA130 = 42;

		public const int IPMOD = 50;

		public const int DS71XX_H = 71;

		public const int DS72XX_H_S = 72;

		public const int DS73XX_H_S = 73;

		public const int DS76XX_H_S = 76;

		public const int DS81XX_HS_S = 81;

		public const int DS81XX_HL_S = 82;

		public const int DS81XX_HC_S = 83;

		public const int DS81XX_HD_S = 84;

		public const int DS81XX_HE_S = 85;

		public const int DS81XX_HF_S = 86;

		public const int DS81XX_AH_S = 87;

		public const int DS81XX_AHF_S = 88;

		public const int DS90XX_HF_S = 90;

		public const int DS91XX_HF_S = 91;

		public const int DS91XX_HD_S = 92;

		public const int NOACTION = 0;

		public const int WARNONMONITOR = 1;

		public const int WARNONAUDIOOUT = 2;

		public const int UPTOCENTER = 4;

		public const int TRIGGERALARMOUT = 8;

		public const int MAJOR_ALARM = 1;

		public const int MINOR_ALARM_IN = 1;

		public const int MINOR_ALARM_OUT = 2;

		public const int MINOR_MOTDET_START = 3;

		public const int MINOR_MOTDET_STOP = 4;

		public const int MINOR_HIDE_ALARM_START = 5;

		public const int MINOR_HIDE_ALARM_STOP = 6;

		public const int MINOR_VCA_ALARM_START = 7;

		public const int MINOR_VCA_ALARM_STOP = 8;

		public const int MAJOR_EXCEPTION = 2;

		public const int MINOR_VI_LOST = 33;

		public const int MINOR_ILLEGAL_ACCESS = 34;

		public const int MINOR_HD_FULL = 35;

		public const int MINOR_HD_ERROR = 36;

		public const int MINOR_DCD_LOST = 37;

		public const int MINOR_IP_CONFLICT = 38;

		public const int MINOR_NET_BROKEN = 39;

		public const int MINOR_REC_ERROR = 40;

		public const int MINOR_IPC_NO_LINK = 41;

		public const int MINOR_VI_EXCEPTION = 42;

		public const int MINOR_IPC_IP_CONFLICT = 43;

		public const int MINOR_FANABNORMAL = 49;

		public const int MINOR_FANRESUME = 50;

		public const int MINOR_SUBSYSTEM_ABNORMALREBOOT = 51;

		public const int MINOR_MATRIX_STARTBUZZER = 52;

		public const int MAJOR_OPERATION = 3;

		public const int MINOR_START_DVR = 65;

		public const int MINOR_STOP_DVR = 66;

		public const int MINOR_STOP_ABNORMAL = 67;

		public const int MINOR_REBOOT_DVR = 68;

		public const int MINOR_LOCAL_LOGIN = 80;

		public const int MINOR_LOCAL_LOGOUT = 81;

		public const int MINOR_LOCAL_CFG_PARM = 82;

		public const int MINOR_LOCAL_PLAYBYFILE = 83;

		public const int MINOR_LOCAL_PLAYBYTIME = 84;

		public const int MINOR_LOCAL_START_REC = 85;

		public const int MINOR_LOCAL_STOP_REC = 86;

		public const int MINOR_LOCAL_PTZCTRL = 87;

		public const int MINOR_LOCAL_PREVIEW = 88;

		public const int MINOR_LOCAL_MODIFY_TIME = 89;

		public const int MINOR_LOCAL_UPGRADE = 90;

		public const int MINOR_LOCAL_RECFILE_OUTPUT = 91;

		public const int MINOR_LOCAL_FORMAT_HDD = 92;

		public const int MINOR_LOCAL_CFGFILE_OUTPUT = 93;

		public const int MINOR_LOCAL_CFGFILE_INPUT = 94;

		public const int MINOR_LOCAL_COPYFILE = 95;

		public const int MINOR_LOCAL_LOCKFILE = 96;

		public const int MINOR_LOCAL_UNLOCKFILE = 97;

		public const int MINOR_LOCAL_DVR_ALARM = 98;

		public const int MINOR_IPC_ADD = 99;

		public const int MINOR_IPC_DEL = 100;

		public const int MINOR_IPC_SET = 101;

		public const int MINOR_LOCAL_START_BACKUP = 102;

		public const int MINOR_LOCAL_STOP_BACKUP = 103;

		public const int MINOR_LOCAL_COPYFILE_START_TIME = 104;

		public const int MINOR_LOCAL_COPYFILE_END_TIME = 105;

		public const int MINOR_LOCAL_ADD_NAS = 106;

		public const int MINOR_LOCAL_DEL_NAS = 107;

		public const int MINOR_LOCAL_SET_NAS = 108;

		public const int MINOR_REMOTE_LOGIN = 112;

		public const int MINOR_REMOTE_LOGOUT = 113;

		public const int MINOR_REMOTE_START_REC = 114;

		public const int MINOR_REMOTE_STOP_REC = 115;

		public const int MINOR_START_TRANS_CHAN = 116;

		public const int MINOR_STOP_TRANS_CHAN = 117;

		public const int MINOR_REMOTE_GET_PARM = 118;

		public const int MINOR_REMOTE_CFG_PARM = 119;

		public const int MINOR_REMOTE_GET_STATUS = 120;

		public const int MINOR_REMOTE_ARM = 121;

		public const int MINOR_REMOTE_DISARM = 122;

		public const int MINOR_REMOTE_REBOOT = 123;

		public const int MINOR_START_VT = 124;

		public const int MINOR_STOP_VT = 125;

		public const int MINOR_REMOTE_UPGRADE = 126;

		public const int MINOR_REMOTE_PLAYBYFILE = 127;

		public const int MINOR_REMOTE_PLAYBYTIME = 128;

		public const int MINOR_REMOTE_PTZCTRL = 129;

		public const int MINOR_REMOTE_FORMAT_HDD = 130;

		public const int MINOR_REMOTE_STOP = 131;

		public const int MINOR_REMOTE_LOCKFILE = 132;

		public const int MINOR_REMOTE_UNLOCKFILE = 133;

		public const int MINOR_REMOTE_CFGFILE_OUTPUT = 134;

		public const int MINOR_REMOTE_CFGFILE_INTPUT = 135;

		public const int MINOR_REMOTE_RECFILE_OUTPUT = 136;

		public const int MINOR_REMOTE_DVR_ALARM = 137;

		public const int MINOR_REMOTE_IPC_ADD = 138;

		public const int MINOR_REMOTE_IPC_DEL = 139;

		public const int MINOR_REMOTE_IPC_SET = 140;

		public const int MINOR_REBOOT_VCA_LIB = 141;

		public const int MINOR_REMOTE_ADD_NAS = 142;

		public const int MINOR_REMOTE_DEL_NAS = 143;

		public const int MINOR_REMOTE_SET_NAS = 144;

		public const int MINOR_SUBSYSTEMREBOOT = 160;

		public const int MINOR_MATRIX_STARTTRANSFERVIDEO = 161;

		public const int MINOR_MATRIX_STOPTRANSFERVIDEO = 162;

		public const int MINOR_REMOTE_SET_ALLSUBSYSTEM = 163;

		public const int MINOR_REMOTE_GET_ALLSUBSYSTEM = 164;

		public const int MINOR_REMOTE_SET_PLANARRAY = 165;

		public const int MINOR_REMOTE_GET_PLANARRAY = 166;

		public const int MINOR_MATRIX_STARTTRANSFERAUDIO = 167;

		public const int MINOR_MATRIX_STOPRANSFERAUDIO = 168;

		public const int MINOR_LOGON_CODESPITTER = 169;

		public const int MINOR_LOGOFF_CODESPITTER = 170;

		public const int MAJOR_INFORMATION = 4;

		public const int MINOR_HDD_INFO = 161;

		public const int MINOR_SMART_INFO = 162;

		public const int MINOR_REC_START = 163;

		public const int MINOR_REC_STOP = 164;

		public const int MINOR_REC_OVERDUE = 165;

		public const int MINOR_LINK_START = 166;

		public const int MINOR_LINK_STOP = 167;

		public const int MINOR_NET_DISK_INFO = 168;

		public const int PARA_VIDEOOUT = 1;

		public const int PARA_IMAGE = 2;

		public const int PARA_ENCODE = 4;

		public const int PARA_NETWORK = 8;

		public const int PARA_ALARM = 16;

		public const int PARA_EXCEPTION = 32;

		public const int PARA_DECODER = 64;

		public const int PARA_RS232 = 128;

		public const int PARA_PREVIEW = 256;

		public const int PARA_SECURITY = 512;

		public const int PARA_DATETIME = 1024;

		public const int PARA_FRAMETYPE = 2048;

		public const int PARA_VCA_RULE = 4096;

		public const int NCR = 0;

		public const int DIEBOLD = 1;

		public const int WINCOR_NIXDORF = 2;

		public const int SIEMENS = 3;

		public const int OLIVETTI = 4;

		public const int FUJITSU = 5;

		public const int HITACHI = 6;

		public const int SMI = 7;

		public const int IBM = 8;

		public const int BULL = 9;

		public const int YiHua = 10;

		public const int LiDe = 11;

		public const int GDYT = 12;

		public const int Mini_Banl = 13;

		public const int GuangLi = 14;

		public const int DongXin = 15;

		public const int ChenTong = 16;

		public const int NanTian = 17;

		public const int XiaoXing = 18;

		public const int GZYY = 19;

		public const int QHTLT = 20;

		public const int DRS918 = 21;

		public const int KALATEL = 22;

		public const int NCR_2 = 23;

		public const int NXS = 24;

		public const int NET_DEC_STARTDEC = 1;

		public const int NET_DEC_STOPDEC = 2;

		public const int NET_DEC_STOPCYCLE = 3;

		public const int NET_DEC_CONTINUECYCLE = 4;

		public const int NET_DVR_ENCODER_UNKOWN = 0;

		public const int NET_DVR_ENCODER_H264 = 1;

		public const int NET_DVR_ENCODER_S264 = 2;

		public const int NET_DVR_ENCODER_MPEG4 = 3;

		public const int NET_DVR_STREAM_TYPE_UNKOWN = 0;

		public const int NET_DVR_STREAM_TYPE_HIKPRIVT = 1;

		public const int NET_DVR_STREAM_TYPE_TS = 7;

		public const int NET_DVR_STREAM_TYPE_PS = 8;

		public const int NET_DVR_STREAM_TYPE_RTP = 9;

		public const int NET_DVR_MAX_DISPREGION = 16;

		public const int MAX_DECODECHANNUM = 32;

		public const int MAX_DISPCHANNUM = 24;

		public const int NET_DVR_SHOWLOGO = 1;

		public const int NET_DVR_HIDELOGO = 2;

		public const int DISP_CMD_ENLARGE_WINDOW = 1;

		public const int DISP_CMD_RENEW_WINDOW = 2;

		public const int DS6001_HF_B = 60;

		public const int DS6001_HF_P = 61;

		public const int DS6002_HF_B = 62;

		public const int DS6101_HF_B = 63;

		public const int IDS52XX = 64;

		public const int DS9000_IVS = 65;

		public const int DS8004_AHL_A = 66;

		public const int DS6101_HF_P = 67;

		public const int VCA_DEV_ABILITY = 256;

		public const int VCA_CHAN_ABILITY = 272;

		public const int MATRIXDECODER_ABILITY = 512;

		public const int NET_DVR_SET_PLATECFG = 150;

		public const int NET_DVR_GET_PLATECFG = 151;

		public const int NET_DVR_SET_RULECFG = 152;

		public const int NET_DVR_GET_RULECFG = 153;

		public const int NET_DVR_SET_LF_CFG = 160;

		public const int NET_DVR_GET_LF_CFG = 161;

		public const int NET_DVR_SET_IVMS_STREAMCFG = 162;

		public const int NET_DVR_GET_IVMS_STREAMCFG = 163;

		public const int NET_DVR_SET_VCA_CTRLCFG = 164;

		public const int NET_DVR_GET_VCA_CTRLCFG = 165;

		public const int NET_DVR_SET_VCA_MASK_REGION = 166;

		public const int NET_DVR_GET_VCA_MASK_REGION = 167;

		public const int NET_DVR_SET_VCA_ENTER_REGION = 168;

		public const int NET_DVR_GET_VCA_ENTER_REGION = 169;

		public const int NET_DVR_SET_VCA_LINE_SEGMENT = 170;

		public const int NET_DVR_GET_VCA_LINE_SEGMENT = 171;

		public const int NET_DVR_SET_IVMS_MASK_REGION = 172;

		public const int NET_DVR_GET_IVMS_MASK_REGION = 173;

		public const int NET_DVR_SET_IVMS_ENTER_REGION = 174;

		public const int NET_DVR_GET_IVMS_ENTER_REGION = 175;

		public const int NET_DVR_SET_IVMS_BEHAVIORCFG = 176;

		public const int NET_DVR_GET_IVMS_BEHAVIORCFG = 177;

		public const int NET_DVR_IVMS_SET_SEARCHCFG = 178;

		public const int NET_DVR_IVMS_GET_SEARCHCFG = 179;

		public const int COMM_ALARM_PLATE = 4353;

		public const int COMM_ALARM_RULE = 4354;

		public const int COMM_ITS_PLATE_RESULT = 12368;

		public const int COMM_ALARM_CAPTURE_UPLOAD = 12408;

		public const int COMM_UPLOAD_PLATE_RESULT = 10240;

		public const int VCA_MAX_POLYGON_POINT_NUM = 10;

		public const int MAX_RULE_NUM = 8;

		public const int MAX_TARGET_NUM = 30;

		public const int MAX_CALIB_PT = 6;

		public const int MIN_CALIB_PT = 4;

		public const int MAX_TIMESEGMENT_2 = 2;

		public const int MAX_LICENSE_LEN = 16;

		public const int MAX_PLATE_NUM = 3;

		public const int MAX_MASK_REGION_NUM = 4;

		public const int MAX_SEGMENT_NUM = 6;

		public const int MIN_SEGMENT_NUM = 3;

		public const int MAX_VCA_CHAN = 16;

		public const int MAX_CHINESE_CHAR_NUM = 64;

		public const int NET_DVR_GET_AP_INFO_LIST = 305;

		public const int NET_DVR_SET_WIFI_CFG = 306;

		public const int NET_DVR_GET_WIFI_CFG = 307;

		public const int NET_DVR_SET_WIFI_WORKMODE = 308;

		public const int NET_DVR_GET_WIFI_WORKMODE = 309;

		public const int WIFI_WEP_MAX_KEY_COUNT = 4;

		public const int WIFI_WEP_MAX_KEY_LENGTH = 33;

		public const int WIFI_WPA_PSK_MAX_KEY_LENGTH = 63;

		public const int WIFI_WPA_PSK_MIN_KEY_LENGTH = 8;

		public const int WIFI_MAX_AP_COUNT = 20;

		public const int MAX_NET_DISK = 16;

		public const int SEARCH_EVENT_INFO_LEN = 300;

		public const int PLATE_INFO_LEN = 1024;

		public const int PLATE_NUM_LEN = 16;

		public const int FILE_NAME_LEN = 256;

		public const int NET_DVR_GET_CCDPARAMCFG = 1067;

		public const int NET_DVR_SET_CCDPARAMCFG = 1068;

		public const int NET_DVR_GET_IMAGEREGION = 1062;

		public const int NET_DVR_SET_IMAGEREGION = 1063;

		public const int NET_DVR_GET_IMAGEPARAM = 1064;

		public const int NET_DVR_SET_IMAGEPARAM = 1065;

		public const int WM_NETERROR = 1126;

		public const int WM_STREAMEND = 1127;

		public const int FILE_HEAD = 0;

		public const int VIDEO_I_FRAME = 1;

		public const int VIDEO_B_FRAME = 2;

		public const int VIDEO_P_FRAME = 3;

		public const int VIDEO_BP_FRAME = 4;

		public const int VIDEO_BBP_FRAME = 5;

		public const int AUDIO_PACKET = 10;

		public const int DATASTREAM_HEAD = 0;

		public const int DATASTREAM_BITBLOCK = 1;

		public const int DATASTREAM_KEYFRAME = 2;

		public const int DATASTREAM_NORMALFRAME = 3;

		public const int MESSAGEVALUE_DISKFULL = 1;

		public const int MESSAGEVALUE_SWITCHDISK = 2;

		public const int MESSAGEVALUE_CREATEFILE = 3;

		public const int MESSAGEVALUE_DELETEFILE = 4;

		public const int MESSAGEVALUE_SWITCHFILE = 5;

		public const int REGIONTYPE = 0;

		public const int MATRIXTYPE = 11;

		public const int DEVICETYPE = 2;

		public const int CHANNELTYPE = 3;

		public const int USERTYPE = 5;

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_Init();

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_Cleanup();

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_SetDVRMessage(uint nMessage, IntPtr hWnd);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_SetExceptionCallBack_V30(uint nMessage, IntPtr hWnd, EXCEPYIONCALLBACK fExceptionCallBack, IntPtr pUser);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_SetDVRMessCallBack(MESSCALLBACK fMessCallBack);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_SetDVRMessCallBack_EX(MESSCALLBACKEX fMessCallBack_EX);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_SetDVRMessCallBack_NEW(MESSCALLBACKNEW fMessCallBack_NEW);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_SetDVRMessageCallBack(MESSAGECALLBACK fMessageCallBack, uint dwUser);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_SetDVRMessageCallBack_V31(MSGCallBack fMessageCallBack, IntPtr pUser);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_SetConnectTime(uint dwWaitTime, uint dwTryTimes);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_SetReconnect(uint dwInterval, int bEnableRecon);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern uint NET_DVR_GetSDKVersion();

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern uint NET_DVR_GetSDKBuildVersion();

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern int NET_DVR_IsSupport();

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_StartListen(string sLocalIP, ushort wLocalPort);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_StopListen();

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern int NET_DVR_StartListen_V30(string sLocalIP, ushort wLocalPort, MSGCallBack DataCallback, IntPtr pUserData);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_StopListen_V30(int lListenHandle);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern int NET_DVR_Login(string sDVRIP, ushort wDVRPort, string sUserName, string sPassword, ref NET_DVR_DEVICEINFO lpDeviceInfo);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_Logout(int iUserID);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern uint NET_DVR_GetLastError();

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern string NET_DVR_GetErrorMsg(ref int pErrorNo);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_SetShowMode(uint dwShowType, uint colorKey);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_GetDVRIPByResolveSvr(string sServerIP, ushort wServerPort, string sDVRName, ushort wDVRNameLen, string sDVRSerialNumber, ushort wDVRSerialLen, IntPtr pGetIP);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_GetDVRIPByResolveSvr_EX(string sServerIP, ushort wServerPort, ref byte sDVRName, ushort wDVRNameLen, ref byte sDVRSerialNumber, ushort wDVRSerialLen, string sGetIP, ref uint dwPort);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern int NET_DVR_RealPlay(int iUserID, ref NET_DVR_CLIENTINFO lpClientInfo);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern int NET_SDK_RealPlay(int iUserLogID, ref NET_SDK_CLIENTINFO lpDVRClientInfo);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern int NET_DVR_RealPlay_V30(int iUserID, ref NET_DVR_CLIENTINFO lpClientInfo, REALDATACALLBACK fRealDataCallBack_V30, IntPtr pUser, uint bBlocked);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_StopRealPlay(int iRealHandle);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_RigisterDrawFun(int lRealHandle, DRAWFUN fDrawFun, uint dwUser);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_SetPlayerBufNumber(int lRealHandle, uint dwBufNum);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_ThrowBFrame(int lRealHandle, uint dwNum);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_SetAudioMode(uint dwMode);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_OpenSound(int lRealHandle);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_CloseSound();

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_OpenSoundShare(int lRealHandle);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_CloseSoundShare(int lRealHandle);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_Volume(int lRealHandle, ushort wVolume);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_SaveRealData(int lRealHandle, string sFileName);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_StopSaveRealData(int lRealHandle);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_SetRealDataCallBack(int lRealHandle, SETREALDATACALLBACK fRealDataCallBack, uint dwUser);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_SetStandardDataCallBack(int lRealHandle, STDDATACALLBACK fStdDataCallBack, uint dwUser);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_CapturePicture(int lRealHandle, string sPicFileName);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_MakeKeyFrame(int lUserID, int lChannel);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_MakeKeyFrameSub(int lUserID, int lChannel);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_GetPTZCtrl(int lRealHandle);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_GetPTZCtrl_Other(int lUserID, int lChannel);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_PTZControl(int lRealHandle, uint dwPTZCommand, uint dwStop);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_PTZControl_Other(int lUserID, int lChannel, uint dwPTZCommand, uint dwStop);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_TransPTZ(int lRealHandle, string pPTZCodeBuf, uint dwBufSize);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_TransPTZ_Other(int lUserID, int lChannel, string pPTZCodeBuf, uint dwBufSize);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_PTZPreset(int lRealHandle, uint dwPTZPresetCmd, uint dwPresetIndex);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_PTZPreset_Other(int lUserID, int lChannel, uint dwPTZPresetCmd, uint dwPresetIndex);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_TransPTZ_EX(int lRealHandle, string pPTZCodeBuf, uint dwBufSize);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_PTZControl_EX(int lRealHandle, uint dwPTZCommand, uint dwStop);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_PTZPreset_EX(int lRealHandle, uint dwPTZPresetCmd, uint dwPresetIndex);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_PTZCruise(int lRealHandle, uint dwPTZCruiseCmd, byte byCruiseRoute, byte byCruisePoint, ushort wInput);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_PTZCruise_Other(int lUserID, int lChannel, uint dwPTZCruiseCmd, byte byCruiseRoute, byte byCruisePoint, ushort wInput);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_PTZCruise_EX(int lRealHandle, uint dwPTZCruiseCmd, byte byCruiseRoute, byte byCruisePoint, ushort wInput);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_PTZTrack(int lRealHandle, uint dwPTZTrackCmd);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_PTZTrack_Other(int lUserID, int lChannel, uint dwPTZTrackCmd);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_PTZTrack_EX(int lRealHandle, uint dwPTZTrackCmd);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_PTZControlWithSpeed(int lRealHandle, uint dwPTZCommand, uint dwStop, uint dwSpeed);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_PTZControlWithSpeed_Other(int lUserID, int lChannel, int dwPTZCommand, int dwStop, int dwSpeed);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_PTZControlWithSpeed_EX(int lRealHandle, uint dwPTZCommand, uint dwStop, uint dwSpeed);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_GetPTZCruise(int lUserID, int lChannel, int lCruiseRoute, ref NET_DVR_CRUISE_RET lpCruiseRet);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_PTZMltTrack(int lRealHandle, uint dwPTZTrackCmd, uint dwTrackIndex);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_PTZMltTrack_Other(int lUserID, int lChannel, uint dwPTZTrackCmd, uint dwTrackIndex);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_PTZMltTrack_EX(int lRealHandle, uint dwPTZTrackCmd, uint dwTrackIndex);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern int NET_DVR_FindFile(int lUserID, int lChannel, uint dwFileType, ref NET_DVR_TIME lpStartTime, ref NET_DVR_TIME lpStopTime);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern int NET_DVR_FindNextFile(int lFindHandle, ref NET_DVR_FIND_DATA lpFindData);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_FindClose(int lFindHandle);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern int NET_DVR_FindNextFile_V30(int lFindHandle, ref NET_DVR_FINDDATA_V30 lpFindData);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern int NET_DVR_FindFile_V30(int lUserID, ref NET_DVR_FILECOND pFindCond);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_FindClose_V30(int lFindHandle);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern int NET_DVR_FindNextFile_Card(int lFindHandle, ref NET_DVR_FINDDATA_CARD lpFindData);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern int NET_DVR_FindFile_Card(int lUserID, int lChannel, uint dwFileType, ref NET_DVR_TIME lpStartTime, ref NET_DVR_TIME lpStopTime);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_LockFileByName(int lUserID, string sLockFileName);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_UnlockFileByName(int lUserID, string sUnlockFileName);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern int NET_DVR_PlayBackByName(int lUserID, string sPlayBackFileName, IntPtr hWnd);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern int NET_DVR_PlayBackByTime(int lUserID, int lChannel, ref NET_DVR_TIME lpStartTime, ref NET_DVR_TIME lpStopTime, IntPtr hWnd);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_PlayBackControl(int lPlayHandle, uint dwControlCode, uint dwInValue, ref uint LPOutValue);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_StopPlayBack(int lPlayHandle);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_SetPlayDataCallBack(int lPlayHandle, PLAYDATACALLBACK fPlayDataCallBack, uint dwUser);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_PlayBackSaveData(int lPlayHandle, string sFileName);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_StopPlayBackSave(int lPlayHandle);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_GetPlayBackOsdTime(int lPlayHandle, ref NET_DVR_TIME lpOsdTime);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_PlayBackCaptureFile(int lPlayHandle, string sFileName);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern int NET_DVR_GetFileByName(int lUserID, string sDVRFileName, string sSavedFileName);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern int NET_DVR_GetFileByTime(int lUserID, int lChannel, ref NET_DVR_TIME lpStartTime, ref NET_DVR_TIME lpStopTime, string sSavedFileName);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern int NET_DVR_GetFileByTime_V40(int lUserID, string sSavedFileName, ref NET_DVR_PLAYCOND pDownloadCond);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern int NET_DVR_PlayBackByTime_V40(int lUserID, ref NET_DVR_VOD_PARA pDownloadCond);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_InquiryRecordTimeSpan(int lUserID, uint dwChannel, ref NET_DVR_RECORD_TIME_SPAN_INQUIRY lpInquiry, ref NET_DVR_RECORD_TIME_SPAN lpResult);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_PlayBackControl_V40(int lPlayHandle, uint dwControlCode, IntPtr dwInValue, uint dwInvalue_len, IntPtr LPOutValue, ref uint LPOutValue_len);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_UpdateRecordIndex(int lUserID, ushort lChannel);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_StopGetFile(int lFileHandle);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern int NET_DVR_GetDownloadPos(int lFileHandle);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern int NET_DVR_GetPlayBackPos(int lPlayHandle);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern int NET_DVR_Upgrade(int lUserID, string sFileName);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern int NET_DVR_GetUpgradeState(int lUpgradeHandle);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern int NET_DVR_GetUpgradeProgress(int lUpgradeHandle);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_CloseUpgradeHandle(int lUpgradeHandle);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_SetNetworkEnvironment(uint dwEnvironmentLevel);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern int NET_DVR_FormatDisk(int lUserID, int lDiskNumber);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_GetFormatProgress(int lFormatHandle, ref int pCurrentFormatDisk, ref int pCurrentDiskPos, ref int pFormatStatic);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_CloseFormatHandle(int lFormatHandle);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern int NET_DVR_SetupAlarmChan(int lUserID);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_CloseAlarmChan(int lAlarmHandle);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern int NET_DVR_SetupAlarmChan_V30(int lUserID);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern int NET_DVR_SetupAlarmChan_V41(int lUserID, ref NET_DVR_SETUPALARM_PARAM lpSetupParam);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_CloseAlarmChan_V30(int lAlarmHandle);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern int NET_DVR_StartVoiceCom(int lUserID, VOICEDATACALLBACK fVoiceDataCallBack, uint dwUser);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern int NET_DVR_StartVoiceCom_V30(int lUserID, uint dwVoiceChan, bool bNeedCBNoEncData, VOICEDATACALLBACKV30 fVoiceDataCallBack, IntPtr pUser);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_SetVoiceComClientVolume(int lVoiceComHandle, ushort wVolume);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_StopVoiceCom(int lVoiceComHandle);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern int NET_DVR_StartVoiceCom_MR(int lUserID, VOICEDATACALLBACK fVoiceDataCallBack, uint dwUser);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern int NET_DVR_StartVoiceCom_MR_V30(int lUserID, uint dwVoiceChan, VOICEDATACALLBACKV30 fVoiceDataCallBack, IntPtr pUser);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_VoiceComSendData(int lVoiceComHandle, string pSendBuf, uint dwBufSize);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_ClientAudioStart();

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_ClientAudioStart_V30(VOICEAUDIOSTART fVoiceAudioStart, IntPtr pUser);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_ClientAudioStop();

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_AddDVR(int lUserID);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern int NET_DVR_AddDVR_V30(int lUserID, uint dwVoiceChan);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_DelDVR(int lUserID);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_DelDVR_V30(int lVoiceHandle);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_SerialStart(int lUserID, int lSerialPort, SERIALDATACALLBACK fSerialDataCallBack, uint dwUser);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_SerialSend(int lSerialHandle, int lChannel, string pSendBuf, uint dwBufSize);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_SerialStop(int lSerialHandle);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_SendTo232Port(int lUserID, string pSendBuf, uint dwBufSize);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_SendToSerialPort(int lUserID, uint dwSerialPort, uint dwSerialIndex, string pSendBuf, uint dwBufSize);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern IntPtr NET_DVR_InitG722Decoder(int nBitrate);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern void NET_DVR_ReleaseG722Decoder(IntPtr pDecHandle);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_DecodeG722Frame(IntPtr pDecHandle, ref byte pInBuffer, ref byte pOutBuffer);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern IntPtr NET_DVR_InitG722Encoder();

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_EncodeG722Frame(IntPtr pEncodeHandle, ref byte pInBuffer, ref byte pOutBuffer);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern void NET_DVR_ReleaseG722Encoder(IntPtr pEncodeHandle);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_ClickKey(int lUserID, int lKeyIndex);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_StartDVRRecord(int lUserID, int lChannel, int lRecordType);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_StopDVRRecord(int lUserID, int lChannel);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_InitDevice_Card(ref int pDeviceTotalChan);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_ReleaseDevice_Card();

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_InitDDraw_Card(IntPtr hParent, uint colorKey);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_ReleaseDDraw_Card();

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern int NET_DVR_RealPlay_Card(int lUserID, ref NET_DVR_CARDINFO lpCardInfo, int lChannelNum);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_ResetPara_Card(int lRealHandle, ref NET_DVR_DISPLAY_PARA lpDisplayPara);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_RefreshSurface_Card();

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_ClearSurface_Card();

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_RestoreSurface_Card();

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_OpenSound_Card(int lRealHandle);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_CloseSound_Card(int lRealHandle);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_SetVolume_Card(int lRealHandle, ushort wVolume);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_AudioPreview_Card(int lRealHandle, int bEnable);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern int NET_DVR_GetCardLastError_Card();

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern IntPtr NET_DVR_GetChanHandle_Card(int lRealHandle);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_CapturePicture_Card(int lRealHandle, string sPicFileName);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_GetSerialNum_Card(int lChannelNum, ref uint pDeviceSerialNo);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern int NET_DVR_FindDVRLog(int lUserID, int lSelectMode, uint dwMajorType, uint dwMinorType, ref NET_DVR_TIME lpStartTime, ref NET_DVR_TIME lpStopTime);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern int NET_DVR_FindNextLog(int lLogHandle, ref NET_DVR_LOG lpLogData);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_FindLogClose(int lLogHandle);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern int NET_DVR_FindDVRLog_V30(int lUserID, int lSelectMode, uint dwMajorType, uint dwMinorType, ref NET_DVR_TIME lpStartTime, ref NET_DVR_TIME lpStopTime, bool bOnlySmart);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern int NET_DVR_FindNextLog_V30(int lLogHandle, ref NET_DVR_LOG_V30 lpLogData);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_FindLogClose_V30(int lLogHandle);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern int NET_DVR_FindFileByCard(int lUserID, int lChannel, uint dwFileType, int nFindType, ref byte sCardNumber, ref NET_DVR_TIME lpStartTime, ref NET_DVR_TIME lpStopTime);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_CaptureJPEGPicture(int lUserID, int lChannel, ref NET_DVR_JPEGPARA lpJpegPara, string sPicFileName);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_CaptureJPEGPicture_NEW(int lUserID, int lChannel, ref NET_DVR_JPEGPARA lpJpegPara, string sJpegPicBuffer, uint dwPicSize, ref uint lpSizeReturned);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern int NET_DVR_GetRealPlayerIndex(int lRealHandle);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern int NET_DVR_GetPlayBackPlayerIndex(int lPlayHandle);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_SetScaleCFG(int lUserID, uint dwScale);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_GetScaleCFG(int lUserID, ref uint lpOutScale);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_SetScaleCFG_V30(int lUserID, ref NET_DVR_SCALECFG pScalecfg);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_GetScaleCFG_V30(int lUserID, ref NET_DVR_SCALECFG pScalecfg);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_SetATMPortCFG(int lUserID, ushort wATMPort);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_GetATMPortCFG(int lUserID, ref ushort LPOutATMPort);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_InitDDrawDevice();

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_ReleaseDDrawDevice();

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern int NET_DVR_GetDDrawDeviceTotalNums();

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_SetDDrawDevice(int lPlayPort, uint nDeviceNum);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_PTZSelZoomIn(int lRealHandle, ref NET_DVR_POINT_FRAME pStruPointFrame);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_PTZSelZoomIn_EX(int lUserID, int lChannel, ref NET_DVR_POINT_FRAME pStruPointFrame);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_StartDecode(int lUserID, int lChannel, ref NET_DVR_DECODERINFO lpDecoderinfo);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_StopDecode(int lUserID, int lChannel);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_GetDecoderState(int lUserID, int lChannel, ref NET_DVR_DECODERSTATE lpDecoderState);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_SetDecInfo(int lUserID, int lChannel, ref NET_DVR_DECCFG lpDecoderinfo);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_GetDecInfo(int lUserID, int lChannel, ref NET_DVR_DECCFG lpDecoderinfo);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_SetDecTransPort(int lUserID, ref NET_DVR_PORTCFG lpTransPort);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_GetDecTransPort(int lUserID, ref NET_DVR_PORTCFG lpTransPort);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_DecPlayBackCtrl(int lUserID, int lChannel, uint dwControlCode, uint dwInValue, ref uint LPOutValue, ref NET_DVR_PLAYREMOTEFILE lpRemoteFileInfo);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_StartDecSpecialCon(int lUserID, int lChannel, ref NET_DVR_DECCHANINFO lpDecChanInfo);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_StopDecSpecialCon(int lUserID, int lChannel, ref NET_DVR_DECCHANINFO lpDecChanInfo);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_DecCtrlDec(int lUserID, int lChannel, uint dwControlCode);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_DecCtrlScreen(int lUserID, int lChannel, uint dwControl);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_GetDecCurLinkStatus(int lUserID, int lChannel, ref NET_DVR_DECSTATUS lpDecStatus);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_MatrixStartDynamic(int lUserID, uint dwDecChanNum, ref NET_DVR_MATRIX_DYNAMIC_DEC lpDynamicInfo);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_MatrixStopDynamic(int lUserID, uint dwDecChanNum);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_MatrixGetDecChanInfo(int lUserID, uint dwDecChanNum, ref NET_DVR_MATRIX_DEC_CHAN_INFO lpInter);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_MatrixSetLoopDecChanInfo(int lUserID, uint dwDecChanNum, ref NET_DVR_MATRIX_LOOP_DECINFO lpInter);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_MatrixGetLoopDecChanInfo(int lUserID, uint dwDecChanNum, ref NET_DVR_MATRIX_LOOP_DECINFO lpInter);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_MatrixSetLoopDecChanEnable(int lUserID, uint dwDecChanNum, uint dwEnable);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_MatrixGetLoopDecChanEnable(int lUserID, uint dwDecChanNum, ref uint lpdwEnable);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_MatrixGetLoopDecEnable(int lUserID, ref uint lpdwEnable);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_MatrixSetDecChanEnable(int lUserID, uint dwDecChanNum, uint dwEnable);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_MatrixGetDecChanEnable(int lUserID, uint dwDecChanNum, ref uint lpdwEnable);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_MatrixGetDecChanStatus(int lUserID, uint dwDecChanNum, ref NET_DVR_MATRIX_DEC_CHAN_STATUS lpInter);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_MatrixSetTranInfo(int lUserID, ref NET_DVR_MATRIX_TRAN_CHAN_CONFIG lpTranInfo);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_MatrixGetTranInfo(int lUserID, ref NET_DVR_MATRIX_TRAN_CHAN_CONFIG lpTranInfo);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_MatrixSetRemotePlay(int lUserID, uint dwDecChanNum, ref NET_DVR_MATRIX_DEC_REMOTE_PLAY lpInter);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_MatrixSetRemotePlayControl(int lUserID, uint dwDecChanNum, uint dwControlCode, uint dwInValue, ref uint LPOutValue);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_MatrixGetRemotePlayStatus(int lUserID, uint dwDecChanNum, ref NET_DVR_MATRIX_DEC_REMOTE_PLAY_STATUS lpOuter);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_MatrixStartDynamic_V30(int lUserID, uint dwDecChanNum, ref NET_DVR_PU_STREAM_CFG lpDynamicInfo);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_MatrixSetLoopDecChanInfo_V30(int lUserID, uint dwDecChanNum, ref tagMATRIX_LOOP_DECINFO_V30 lpInter);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_MatrixGetLoopDecChanInfo_V30(int lUserID, uint dwDecChanNum, ref tagMATRIX_LOOP_DECINFO_V30 lpInter);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_MatrixGetDecChanInfo_V30(int lUserID, uint dwDecChanNum, ref tagDEC_MATRIX_CHAN_INFO lpInter);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_MatrixSetTranInfo_V30(int lUserID, ref tagMATRIX_TRAN_CHAN_CONFIG lpTranInfo);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_MatrixGetTranInfo_V30(int lUserID, ref tagMATRIX_TRAN_CHAN_CONFIG lpTranInfo);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_MatrixGetDisplayCfg(int lUserID, uint dwDispChanNum, ref tagNET_DVR_VGA_DISP_CHAN_CFG lpDisplayCfg);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_MatrixSetDisplayCfg(int lUserID, uint dwDispChanNum, ref tagNET_DVR_VGA_DISP_CHAN_CFG lpDisplayCfg);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern int NET_DVR_MatrixStartPassiveDecode(int lUserID, uint dwDecChanNum, ref tagNET_MATRIX_PASSIVEMODE lpPassiveMode);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_MatrixSendData(int lPassiveHandle, IntPtr pSendBuf, uint dwBufSize);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_MatrixStopPassiveDecode(int lPassiveHandle);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_UploadLogo(int lUserID, uint dwDispChanNum, ref tagNET_DVR_DISP_LOGOCFG lpDispLogoCfg, IntPtr sLogoBuffer);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_LogoSwitch(int lUserID, uint dwDecChan, uint dwLogoSwitch);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_MatrixGetDeviceStatus(int lUserID, ref tagNET_DVR__DECODER_WORK_STATUS lpDecoderCfg);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_RigisterPlayBackDrawFun(int lRealHandle, DRAWFUN fDrawFun, uint dwUser);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_MatrixDiaplayControl(int lUserID, uint dwDispChanNum, uint dwDispChanCmd, uint dwCmdParam);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_RefreshPlay(int lPlayHandle);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_RestoreConfig(int lUserID);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_SaveConfig(int lUserID);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_RebootDVR(int lUserID);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_ShutDownDVR(int lUserID);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_GetDVRConfig(int lUserID, uint dwCommand, int lChannel, IntPtr lpOutBuffer, uint dwOutBufferSize, ref uint lpBytesReturned);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_SetDVRConfig(int lUserID, uint dwCommand, int lChannel, IntPtr lpInBuffer, uint dwInBufferSize);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_GetDVRWorkState_V30(int lUserID, IntPtr pWorkState);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_GetDVRWorkState(int lUserID, ref NET_DVR_WORKSTATE lpWorkState);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_SetVideoEffect(int lUserID, int lChannel, uint dwBrightValue, uint dwContrastValue, uint dwSaturationValue, uint dwHueValue);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_GetVideoEffect(int lUserID, int lChannel, ref uint pBrightValue, ref uint pContrastValue, ref uint pSaturationValue, ref uint pHueValue);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_ClientGetframeformat(int lUserID, ref NET_DVR_FRAMEFORMAT lpFrameFormat);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_ClientSetframeformat(int lUserID, ref NET_DVR_FRAMEFORMAT lpFrameFormat);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_ClientGetframeformat_V30(int lUserID, ref NET_DVR_FRAMEFORMAT_V30 lpFrameFormat);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_ClientSetframeformat_V30(int lUserID, ref NET_DVR_FRAMEFORMAT_V30 lpFrameFormat);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_Getframeformat_V31(int lUserID, ref tagNET_DVR_FRAMEFORMAT_V31 lpFrameFormat);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_Setframeformat_V31(int lUserID, ref tagNET_DVR_FRAMEFORMAT_V31 lpFrameFormat);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_GetAtmProtocol(int lUserID, ref tagNET_DVR_ATM_PROTOCOL lpAtmProtocol);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_GetAlarmOut_V30(int lUserID, IntPtr lpAlarmOutState);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_GetAlarmOut(int lUserID, ref NET_DVR_ALARMOUTSTATUS lpAlarmOutState);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_SetAlarmOut(int lUserID, int lAlarmOutPort, int lAlarmOutStatic);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_ClientSetVideoEffect(int lRealHandle, uint dwBrightValue, uint dwContrastValue, uint dwSaturationValue, uint dwHueValue);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_ClientGetVideoEffect(int lRealHandle, ref uint pBrightValue, ref uint pContrastValue, ref uint pSaturationValue, ref uint pHueValue);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_GetConfigFile(int lUserID, string sFileName);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_SetConfigFile(int lUserID, string sFileName);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_GetConfigFile_V30(int lUserID, string sOutBuffer, uint dwOutSize, ref uint pReturnSize);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_GetConfigFile_EX(int lUserID, string sOutBuffer, uint dwOutSize);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_SetConfigFile_EX(int lUserID, string sInBuffer, uint dwInSize);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_SetLogToFile(int bLogEnable, string strLogDir, int bAutoDel);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_GetSDKState(ref NET_DVR_SDKSTATE pSDKState);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_GetSDKAbility(ref NET_DVR_SDKABL pSDKAbl);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_GetPTZProtocol(int lUserID, ref NET_DVR_PTZCFG pPtzcfg);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_LockPanel(int lUserID);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_UnLockPanel(int lUserID);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_SetRtspConfig(int lUserID, uint dwCommand, ref NET_DVR_RTSPCFG lpInBuffer, uint dwInBufferSize);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_GetRtspConfig(int lUserID, uint dwCommand, ref NET_DVR_RTSPCFG lpOutBuffer, uint dwOutBufferSize);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_GetDeviceAbility(int lUserID, uint dwAbilityType, IntPtr pInBuf, uint dwInLength, IntPtr pOutBuf, uint dwOutLength);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_SetBehaviorParamKey(int lUserID, int lChannel, uint dwParameterKey, int nValue);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_GetBehaviorParamKey(int lUserID, int lChannel, uint dwParameterKey, ref int pValue);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_GetVCADrawMode(int lUserID, int lChannel, ref tagNET_VCA_DRAW_MODE lpDrawMode);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_SetVCADrawMode(int lUserID, int lChannel, ref tagNET_VCA_DRAW_MODE lpDrawMode);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_SetLFTrackMode(int lUserID, int lChannel, ref tagNET_DVR_LF_TRACK_MODE lpTrackMode);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_GetLFTrackMode(int lUserID, int lChannel, ref tagNET_DVR_LF_TRACK_MODE lpTrackMode);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_VCA_RestartLib(int lUserID, int lChannel);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_GetRealHeight(int lUserID, int lChannel, ref tagNET_VCA_LINE lpLine, ref float lpHeight);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_GetRealLength(int lUserID, int lChannel, ref tagNET_VCA_LINE lpLine, ref float lpLength);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_SaveRealData_V30(int lRealHandle, uint dwTransType, string sFileName);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_EncodeG711Frame(uint iType, ref byte pInBuffer, ref byte pOutBuffer);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_DecodeG711Frame(uint iType, ref byte pInBuffer, ref byte pOutBuffer);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_EmailTest(int lUserID);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern int NET_DVR_FindFileByEvent(int lUserID, ref tagNET_DVR_SEARCH_EVENT_PARAM lpSearchEventParam);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern int NET_DVR_FindNextEvent(int lSearchHandle, ref tagNET_DVR_SEARCH_EVENT_RET lpSearchEventRet);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_INVOKE_PLATE_RECOGNIZE(int lUserID, int lChannel, string pPicFileName, ref tagNET_DVR_PLATE_RET pPlateRet, string pPicBuf, uint dwPicBufLen);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_GetCCDCfg(int lUserID, int lChannel, ref tagNET_DVR_CCD_CFG lpCCDCfg);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_SetCCDCfg(int lUserID, int lChannel, ref tagNET_DVR_CCD_CFG lpCCDCfg);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_GetParamSetMode(int lUserID, ref uint dwParamSetMode);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern int NET_DVR_Login_V30(string sDVRIP, int wDVRPort, string sUserName, string sPassword, ref NET_DVR_DEVICEINFO_V30 lpDeviceInfo);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern bool NET_DVR_Logout_V30(int lUserID);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern int NET_DVR_FindPicture(int lUserID, ref NET_DVR_FIND_PICTURE_PARAM pFindParam);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern int NET_DVR_FindNextPicture(int lFindHandle, ref LPNET_DVR_FIND_PICTURE lpFindData);

		[DllImport("GetStream.dll")]
		public static extern bool CLIENT_SDK_Init();

		[DllImport("GetStream.dll")]
		public static extern bool CLIENT_SDK_UnInit();

		[DllImport("GetStream.dll")]
		public static extern int CLIENT_SDK_GetStream(PLAY_INFO lpPlayInfo);

		[DllImport("GetStream.dll")]
		public static extern bool CLIENT_SetRealDataCallBack(int iRealHandle, SETREALDATACALLBACK fRealDataCallBack, uint lUser);

		[DllImport("GetStream.dll")]
		public static extern bool CLIENT_SDK_StopStream(int iRealHandle);

		[DllImport("GetStream.dll")]
		public static extern bool CLIENT_SDK_GetVideoEffect(int iRealHandle, ref int iBrightValue, ref int iContrastValue, ref int iSaturationValue, ref int iHueValue);

		[DllImport("GetStream.dll")]
		public static extern bool CLIENT_SDK_SetVideoEffect(int iRealHandle, int iBrightValue, int iContrastValue, int iSaturationValue, int iHueValue);

		[DllImport("GetStream.dll")]
		public static extern bool CLIENT_SDK_MakeKeyFrame(int iRealHandle);

		[DllImport("PdCssVodClient.dll")]
		public static extern bool VODServerConnect(string strServerIp, uint uiServerPort, ref IntPtr hSession, ref CONNPARAM struConn, IntPtr hWnd);

		[DllImport("PdCssVodClient.dll")]
		public static extern bool VODServerDisconnect(IntPtr hSession);

		[DllImport("PdCssVodClient.dll")]
		public static extern bool VODStreamSearch(IntPtr pSearchParam, ref IntPtr pSecList);

		[DllImport("PdCssVodClient.dll")]
		public static extern bool VODDeleteSectionList(IntPtr pSecList);

		[DllImport("PdCssVodClient.dll")]
		public static extern bool VODOpenStream(IntPtr pOpenParam, ref IntPtr phStream);

		[DllImport("PdCssVodClient.dll")]
		public static extern bool VODCloseStream(IntPtr hStream);

		[DllImport("PdCssVodClient.dll")]
		public static extern bool VODOpenDownloadStream(ref VODOPENPARAM struVodParam, ref IntPtr phStream);

		[DllImport("PdCssVodClient.dll")]
		public static extern bool VODCloseDownloadStream(IntPtr hStream);

		[DllImport("PdCssVodClient.dll")]
		public static extern bool VODStartStreamData(IntPtr phStream);

		[DllImport("PdCssVodClient.dll")]
		public static extern bool VODPauseStreamData(IntPtr hStream, bool bPause);

		[DllImport("PdCssVodClient.dll")]
		public static extern bool VODStopStreamData(IntPtr hStream);

		[DllImport("PdCssVodClient.dll")]
		public static extern bool VODSeekStreamData(IntPtr hStream, IntPtr pStartTime);

		[DllImport("PdCssVodClient.dll")]
		public static extern bool VODSetStreamSpeed(IntPtr hStream, int iSpeed);

		[DllImport("PdCssVodClient.dll")]
		public static extern bool VODGetStreamCurrentTime(IntPtr hStream, ref BLOCKTIME pCurrentTime);

		[DllImport("AnalyzeData.dll")]
		public static extern int AnalyzeDataGetSafeHandle();

		[DllImport("AnalyzeData.dll")]
		public static extern bool AnalyzeDataOpenStreamEx(int iHandle, byte[] pFileHead);

		[DllImport("AnalyzeData.dll")]
		public static extern bool AnalyzeDataClose(int iHandle);

		[DllImport("AnalyzeData.dll")]
		public static extern bool AnalyzeDataInputData(int iHandle, IntPtr pBuffer, uint uiSize);

		[DllImport("AnalyzeData.dll")]
		public static extern int AnalyzeDataGetPacket(int iHandle, ref PACKET_INFO pPacketInfo);

		[DllImport("AnalyzeData.dll")]
		public static extern bool AnalyzeDataGetTail(int iHandle, ref IntPtr pBuffer, ref uint uiSize);

		[DllImport("AnalyzeData.dll")]
		public static extern uint AnalyzeDataGetLastError(int iHandle);

		[DllImport("RecordDLL.dll")]
		public static extern int Initialize(STOREINFO struStoreInfo);

		[DllImport("RecordDLL.dll")]
		public static extern int Release();

		[DllImport("RecordDLL.dll")]
		public static extern int OpenChannelRecord(string strCameraid, IntPtr pHead, uint dwHeadLength);

		[DllImport("RecordDLL.dll")]
		public static extern bool CloseChannelRecord(int iRecordHandle);

		[DllImport("RecordDLL.dll")]
		public static extern int GetData(int iHandle, int iDataType, IntPtr pBuf, uint uiSize);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern int NET_DVR_FindNextLog_MATRIX(int iLogHandle, ref NET_DVR_LOG_MATRIX lpLogData);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern int NET_DVR_FindDVRLog_Matrix(int iUserID, int lSelectMode, uint dwMajorType, uint dwMinorType, ref tagVEDIOPLATLOG lpVedioPlatLog, ref NET_DVR_TIME lpStartTime, ref NET_DVR_TIME lpStopTime);

		[DllImport("dlls\\Saphire\\HCNetSDK.dll")]
		public static extern int NET_DVR_PlayBackReverseByTime_V40(int lUserID, IntPtr hWnd, ref NET_DVR_PLAYCOND pDownloadCond);
	}
}
