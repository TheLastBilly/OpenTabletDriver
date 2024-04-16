// <auto-generated />

namespace OpenTabletDriver.Configurations
{
    partial class DeviceConfigurationProvider : global::OpenTabletDriver.Components.IDeviceConfigurationProvider
    {
        public global::System.Collections.Immutable.ImmutableArray<global::OpenTabletDriver.Tablet.TabletConfiguration> TabletConfigurations { get; } = global::System.Collections.Immutable.ImmutableArray.Create(new[]
        {
            new global::OpenTabletDriver.Tablet.TabletConfiguration()
            {
                Name = "XP-Pen Star G640S",
                Specifications = new global::OpenTabletDriver.Tablet.TabletSpecifications()
                {
                    Digitizer = new global::OpenTabletDriver.Tablet.DigitizerSpecifications()
                    {
                        Width = 165F,
                        Height = 103F,
                        MaxX = 32999F,
                        MaxY = 20599F
                    },
                    Pen = new global::OpenTabletDriver.Tablet.PenSpecifications()
                    {
                        MaxPressure = 8191U,
                        ButtonCount = 2U
                    },
                    AuxiliaryButtons = new global::OpenTabletDriver.Tablet.ButtonSpecifications()
                    {
                        ButtonCount = 6U
                    },
                    MouseButtons = null,
                    Wheel = null,
                    Touch = null
                },
                DigitizerIdentifiers = new global::System.Collections.Generic.List<global::OpenTabletDriver.Tablet.DeviceIdentifier>()
                {
                    new global::OpenTabletDriver.Tablet.DeviceIdentifier()
                    {
                        VendorID = 10429,
                        ProductID = 2310,
                        InputReportLength = 10U,
                        OutputReportLength = 8U,
                        ReportParser = "OpenTabletDriver.Configurations.Parsers.XP_Pen.XP_PenReportParser",
                        FeatureInitReport = null,
                        OutputInitReport = new global::System.Collections.Generic.List<byte[]>()
                        {
                            new byte[] { 0x02, 0xb0, 0x04 }
                        },
                        DeviceStrings = new global::System.Collections.Generic.Dictionary<byte, string>(),
                        InitializationStrings = new global::System.Collections.Generic.List<byte>()
                    },
                    new global::OpenTabletDriver.Tablet.DeviceIdentifier()
                    {
                        VendorID = 10429,
                        ProductID = 2310,
                        InputReportLength = 10U,
                        OutputReportLength = 10U,
                        ReportParser = "OpenTabletDriver.Configurations.Parsers.XP_Pen.XP_PenReportParser",
                        FeatureInitReport = null,
                        OutputInitReport = new global::System.Collections.Generic.List<byte[]>()
                        {
                            new byte[] { 0x02, 0xb0, 0x04 }
                        },
                        DeviceStrings = new global::System.Collections.Generic.Dictionary<byte, string>(),
                        InitializationStrings = new global::System.Collections.Generic.List<byte>()
                    },
                    new global::OpenTabletDriver.Tablet.DeviceIdentifier()
                    {
                        VendorID = 10429,
                        ProductID = 2310,
                        InputReportLength = 12U,
                        OutputReportLength = 10U,
                        ReportParser = "OpenTabletDriver.Configurations.Parsers.XP_Pen.XP_PenReportParser",
                        FeatureInitReport = null,
                        OutputInitReport = new global::System.Collections.Generic.List<byte[]>()
                        {
                            new byte[] { 0x02, 0xb0, 0x04 }
                        },
                        DeviceStrings = new global::System.Collections.Generic.Dictionary<byte, string>(),
                        InitializationStrings = new global::System.Collections.Generic.List<byte>()
                    }
                },
                AuxiliaryDeviceIdentifiers = new global::System.Collections.Generic.List<global::OpenTabletDriver.Tablet.DeviceIdentifier>(),
                Attributes = new global::System.Collections.Generic.Dictionary<string, string>()
                {
                    ["libinputoverride"] = "1"
                }
            }
        });
    }
}
