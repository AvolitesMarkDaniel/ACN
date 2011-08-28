﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Acn.Rdm
{
    public enum RdmParameters
    {
        None = 0,

        //---- RDM ----
        SupportedParameters = 0x0050,
        ParameterDescription = 0x0051,

        //---- Product Information ----
        DeviceInfo = 0x0060,
        ProductDetailIdList = 0x0070,
        DeviceModelDescription = 0x0080,
        ManufacturerLabel = 0x0081,
        DeviceLabel = 0x0082,
        FactoryDefaults = 0x0090,
        LanguageCapabilities = 0x00A0,
        Language = 0x00B0,
        SoftwareVersionLabel = 0x00C0,
        BootSoftwareVersionId = 0x00C1,
        BootSoftwareVersionLabel = 0x00C2,

        //---- DMX512 ----
        DmxPersonality = 0x00E0,
        DmxPersonalityDescription = 0x00E1,
        DmxStartAddress = 0x00F0,
        SlotInfo = 0x0120,
        SlotDescription = 0x0121,
        DefaultSlotValue = 0x0122,

        //---- Sensors ----
        SensorDefinition = 0x0200,
        SensoreValue = 0x0201,
        RecordSensors = 0x0202,
        
        //---- Power/Lamp Settings ----
        DeviceHours = 0x0400,
        LampHours = 0x0401,
        LampStrikes = 0x0402,
        LampState = 0x0403,
        LampOnMode = 0x0404,
        DevicePowerCycles = 0x0405,

        //---- Display Settings ----
        DisplayInvert = 0x0500,
        DisplayLevel = 0x0501,

        //---- Configuration ----
        PanInvert = 0x0600,
        TiltInvert = 0x0601,
        PanTiltSwap = 0x0602,
        RealTimeClock = 0x0603,

        //---- Control ----
        IdentifyDevice = 0x1000,
        ResetDevice = 0x1001,
        PowerState = 0x1010,
        PerformSelfTest = 0x1020,
        SelfTestDescription = 0x1021,
        CapturePreset = 0x1030,
        PresetPlayback = 0x1031,

        //---- RDMnet ----
        PortList = 0x7FE0,
        PortIdentify = 0x7FE9,
        PortToUniverse = 0x7FE1,
        RdmTrafficEnable = 0x7FE2,
        PortFunction = 0x7FE3,
        PortLabel = 0x7FE4,
        InitiateDiscovery = 0x7FE5,
        BackgroundDiscovery = 0x7FEA,
        PortTiming = 0x7FE6,
        PortTimingDescription = 0x7FE7,
        BindingControlFields = 0x7FE8
    }
}
