// <auto-generated />

namespace OpenTabletDriver.Configurations
{
    partial class DeviceConfigurationProvider : global::OpenTabletDriver.Components.IDeviceConfigurationProvider
    {
        public global::System.Collections.Immutable.ImmutableArray<global::OpenTabletDriver.Tablet.TabletConfiguration> TabletConfigurations { get; } = global::System.Collections.Immutable.ImmutableArray.Create(new[]
        {
            new global::OpenTabletDriver.Tablet.TabletConfiguration()
            {
                Name = "Wacom CTH-480",
                Specifications = new global::OpenTabletDriver.Tablet.TabletSpecifications()
                {
                    Digitizer = new global::OpenTabletDriver.Tablet.DigitizerSpecifications()
                    {
                        Width = 152F,
                        Height = 95F,
                        MaxX = 15200F,
                        MaxY = 9500F
                    },
                    Pen = new global::OpenTabletDriver.Tablet.PenSpecifications()
                    {
                        MaxPressure = 1023U,
                        ButtonCount = 2U
                    },
                    AuxiliaryButtons = new global::OpenTabletDriver.Tablet.ButtonSpecifications()
                    {
                        ButtonCount = 4U
                    },
                    MouseButtons = null,
                    Wheel = null,
                    Touch = null
                },
                DigitizerIdentifiers = new global::System.Collections.Generic.List<global::OpenTabletDriver.Tablet.DeviceIdentifier>()
                {
                    new global::OpenTabletDriver.Tablet.DeviceIdentifier()
                    {
                        VendorID = 1386,
                        ProductID = 770,
                        InputReportLength = 10U,
                        OutputReportLength = null,
                        ReportParser = "OpenTabletDriver.Configurations.Parsers.Wacom.Intuos.IntuosReportParser",
                        FeatureInitReport = new global::System.Collections.Generic.List<byte[]>()
                        {
                            new byte[] { 0x02, 0x02 }
                        },
                        OutputInitReport = null,
                        DeviceStrings = new global::System.Collections.Generic.Dictionary<byte, string>(),
                        InitializationStrings = new global::System.Collections.Generic.List<byte>()
                    },
                    new global::OpenTabletDriver.Tablet.DeviceIdentifier()
                    {
                        VendorID = 1386,
                        ProductID = 770,
                        InputReportLength = 11U,
                        OutputReportLength = null,
                        ReportParser = "OpenTabletDriver.Configurations.Parsers.Wacom.Intuos.WacomDriverIntuosReportParser",
                        FeatureInitReport = new global::System.Collections.Generic.List<byte[]>()
                        {
                            new byte[] { 0x02, 0x02 }
                        },
                        OutputInitReport = null,
                        DeviceStrings = new global::System.Collections.Generic.Dictionary<byte, string>(),
                        InitializationStrings = new global::System.Collections.Generic.List<byte>()
                    }
                },
                AuxiliaryDeviceIdentifiers = new global::System.Collections.Generic.List<global::OpenTabletDriver.Tablet.DeviceIdentifier>()
                {
                    new global::OpenTabletDriver.Tablet.DeviceIdentifier()
                    {
                        VendorID = 1386,
                        ProductID = 770,
                        InputReportLength = 64U,
                        OutputReportLength = null,
                        ReportParser = "OpenTabletDriver.Configurations.Parsers.Wacom.Wacom64bAuxReportParser",
                        FeatureInitReport = null,
                        OutputInitReport = null,
                        DeviceStrings = new global::System.Collections.Generic.Dictionary<byte, string>(),
                        InitializationStrings = new global::System.Collections.Generic.List<byte>()
                    }
                },
                Attributes = new global::System.Collections.Generic.Dictionary<string, string>()
            }
        });
    }
}
