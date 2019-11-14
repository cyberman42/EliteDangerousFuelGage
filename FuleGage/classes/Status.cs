using System;
using System.Text.Json.Serialization;

namespace FuleGage
{
    public class Status
    {
        [JsonPropertyName("timestamp")]
        public DateTime Timestamp { get; set; }
        [JsonPropertyName("Flags")]
        public ShipStatusFlags Flags { get; set; }
        public int[] Pips { get; set; }
        public int FireGroup { get; set; }
        public int GuiFocus { get; set; }
        public FuelInfo Fuel { get; set; }
        public float Cargo { get; set; }
        public string LegalState { get; set; }

        public bool Docked { get { return GetFlag(0); } }
        public bool Landed { get { return GetFlag(1); } }
        public bool Gear { get { return GetFlag(2); } }
        public bool Shields { get { return GetFlag(3); } }
        public bool Supercruise { get { return GetFlag(4); } }
        public bool FlightAssist { get { return !GetFlag(5); } }
        public bool Hardpoints { get { return GetFlag(6); } }
        public bool Winging { get { return GetFlag(7); } }
        public bool Lights { get { return GetFlag(8); } }
        public bool CargoScoop { get { return GetFlag(9); } }
        public bool SilentRunning { get { return GetFlag(10); } }
        public bool Scooping { get { return GetFlag(11); } }
        public bool SrvHandbreak { get { return GetFlag(12); } }
        public bool SrvTurrent { get { return GetFlag(13); } }
        public bool SrvNearShip { get { return GetFlag(14); } }
        public bool SrvDriveAssist { get { return GetFlag(15); } }
        public bool MassLocked { get { return GetFlag(16); } }
        public bool FsdCharging { get { return GetFlag(17); } }
        public bool FsdCooldown { get { return GetFlag(18); } }
        public bool LowFuel { get { return GetFlag(19); } }
        public bool Overheating { get { return GetFlag(20); } }
        public bool HasLatLong { get { return GetFlag(21); } }
        public bool InDanger { get { return GetFlag(22); } }
        public bool InInterdiction { get { return GetFlag(23); } }
        public bool InMothership { get { return GetFlag(24); } }
        public bool InFighter { get { return GetFlag(25); } }
        public bool InSRV { get { return GetFlag(26); } }
        public bool AnalysisMode { get { return GetFlag(27); } }
        public bool NightVision { get { return GetFlag(28); } }
        public bool AltitudeRadius { get { return GetFlag(29); } }
        public bool FsdJump { get { return GetFlag(30); } }
        public bool SRVHightBeams { get { return GetFlag(31); } }
        public enum ShipStatusFlags
        {
            None = 0,
            Docked = 1,
            Landed = 1 << 1,
            Gear = 1 << 2,
            Shields = 1 << 3,
            Supercruise = 1 << 4,
            FlightAssistOff = 1 << 5,
            Hardpoints = 1 << 6,
            Winging = 1 << 7,
            Lights = 1 << 8,
            CargoScoop = 1 << 9,
            SilentRunning = 1 << 10,
            Scooping = 1 << 11,
            SrvHandbreak = 1 << 12,
            SrvTurret = 1 << 13,
            SrvNearShip = 1 << 14,
            SrvDriveAssist = 1 << 15,
            MassLocked = 1 << 16,
            FsdCharging = 1 << 17,
            FsdCooldown = 1 << 18,
            LowFuel = 1 << 19,
            Overheating = 1 << 20,
            HasLatlong = 1 << 21,
            InDanger = 1 << 22,
            InInterdiction = 1 << 23,
            InMothership = 1 << 24,
            InFighter = 1 << 25,
            InSrv = 1 << 26,
            AnalysisMode = 1 << 27,
            NightVision = 1 << 28,
            AltitudeRadius = 1 << 29,
            fsdJump = 1 << 30,
            srvHighBeam = 1 << 31,


        }

        public bool GetFlag(int bit)
        {
            return Flags.HasFlag((ShipStatusFlags)(1 << bit));
        }

        public class FuelInfo
        {
            public float FuelMain { get; set; }
            public float FuelReservoir { get; set; }

        }

        public Status()
        {


        }
    }
}
