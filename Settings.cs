using ModSettings;

namespace OutdoorSafehouseAdjustments
{
    internal class OutdoorSafehouseSettings : JsonModSettings
    {
        
        //Blackrock
        [Section("Blackrock - Brick Layers Retreat")]

        [Name("Change the Indoor Temperature")]
        [Description("The Value of Temperature Added to the Outdoor Air Temperature (Celsius.Default is 10).")]
        [Slider(0, 50, 51)]
        public float BRRBLRTemp = 10f;

        [Name("Remove Bed")]
        [Description("Remove the Bed.")]
        public bool BRRBLRRemoveBeds = false;

        [Name("Remove Cabinet")]
        [Description("Remove the Cabinet.")]
        public bool BRRBLRRemoveCabinet = false;

        [Name("Remove Door")]
        [Description("Remove the Broken Door.")]
        public bool BRRBLRFixDoor = false;

        [Name("Remove Rug")]
        [Description("Remove the Rug.")]
        public bool BRRBLRRemoveRug = false;

        [Name("Patch the Hole in the Roof")]
        [Description("Patch the Hole in the Roof.")]
        public bool BRRBLRCloseRoof = false;


        //Bleak Inlet
        [Section("Bleak Inlet - Pensive Lookout")]

        [Name("Remove Bed")]
        [Description("Remove the Bed.")]
        public bool BIPLRemoveBeds = false;

        [Name("Remove Cabinet")]
        [Description("Remove the Cabinet.")]
        public bool BIPLRemoveCabinet = false;

        [Name("Remove Short Counter")]
        [Description("Remove the Short Counter and Everything on it.")]
        public bool BIPLRemoveShortCounter = false;

        [Name("Remove Corner Counter")]
        [Description("Remove the Corner Counter and Everything on it.")]
        public bool BIPLRemoveCornerCounter = false;

        [Name("Remove Bulletin Board")]
        [Description("Remove the Bulletin Board and Everything attached to it.")]
        public bool BIPLRemoveBBoard = false;
   
        [Name("Remove Objects on Desk")]
        [Description("Remove Everything on the desk.")]
        public bool BIPLRemoveDesk = false;

        [Name("Remove Chair")]
        [Description("Remove the Chair.")]
        public bool BIPLRemoveChair = false;

        [Name("Remove Potted Plant")]
        [Description("Remove the Potted Plant.")]
        public bool BIPLRemovePottedPlant = false;

        [Name("Remove Rugs")]
        [Description("Remove the rugs.")]
        public bool BIPLRemoveRugs = false;


        [Section("Bleak Inlet - Cannery")]

        [Name("Add Bridge to Workshop")]
        [Description("Add a Bridge from Main Area to the Workshop.")]
        public bool BICAddBridgeWorkshop = false;

        [Name("Add Ramp from ice to Workshop")]
        [Description("Add a Ramp from the Ice to the Workshop.")]
        public bool BICAddRampWorkshop = false;

        [Name("Add Ramp from ice to breakroom")]
        [Description("Add a Ramp from the Ice to the Breakroom.")]
        public bool BICAddRampWarehouse = false;

        [Name("Remove cable reels")]
        [Description("Remove the Cable Reels from Breakroom.")]
        public bool BIBRRemoveReels = false;

        [Name("Remove metal counter")]
        [Description("Remove the Metal Counter from the Breakroom.")]
        public bool BIBRRemoveCounter = false;

        [Name("Remove fridge door")]
        [Description("Remove the Broken Fridge Door in the Breakroom.")]
        public bool BIBRRemoveFridgeDoor = false;

        [Name("Move Picnic Table")]
        [Description("Move Picnic Table next to the Others in the Breakroom.")]
        public bool BIBRMovePicnicTable = false;

        [Name("Add Six Burner Stove to Breakroom")]
        [Description("Add a Six Burner Stove to the Breakroom.")]
        public bool BIBRAddStove = false;


        //Coastal Highway
        [Section("Coastal Highway - Abandoned Lookout")]

        [Name("Remove Bed")]
        [Description("Remove the Bed.")]
        public bool CHALRemoveBeds = false;

        [Name("Remove Cupboard")]
        [Description("Remove a Cupboard.")]
        public bool CHALRemoveCupBoard = false;

        /*
        //Forlorn Muskeg
        [Section("Forlorn Muskeg - Spence Farm")]

        [Name("Remove Reel")]
        [Description("Remove the Cable Reel on the Ground Level.")]
        public bool FMSFRemoveReel = false;

        [Name("Straighten Tool Cabinet")]
        [Description("Straighten Tool Cabinet.")]
        public bool FMSFMoveCabinet = false;

        [Name("Move Locker")]
        [Description("Move Locker next to Wall by the Forge.")]
        public bool FMSFMoveLocker = false;

        [Name("Move Workbench")]
        [Description("Move Workbench next to Forge.")]
        public bool FMSFMoveWorkbench = false;
        */

        //Forsaken Airfield
        [Section("Forsaken Airfield - Mindful Cabin")]

        [Name("Remove Bed")]
        [Description("Remove the Bed.")]
        public bool FAMCRemoveBed = false;

        [Name("Remove Upstairs Rug")]
        [Description("Remove the Upstairs Rug.")]
        public bool FAMCRemoveRug = false;

        [Name("Remove All Downstairs Rugs")]
        [Description("Remove All Downstairs Rugs.")]
        public bool FAMCRemoveRugs = false;

        [Name("Remove Trough")]
        [Description("Remove the Trough.")]
        public bool FAMCRemoveTrough = false;

        [Name("Remove Potted Plants")]
        [Description("Remove Potted Plants.")]
        public bool FAMCRemovePlants = false;

        /*
        [Name("Move Trunk")]
        [Description("Move Trunk to Upper Level.")]
        public bool FAMCMoveTrunk = false;

        [Name("Enable Hidden Cabinet")]
        [Description("Enable a Hidden Cabinet in Place of the Trough.")]
        public bool FAMCEnableCabinet = false;
        */

        [Section("Forsaken Airfield - Drift Island Cabin")]

        [Name("Remove all Rugs")]
        [Description("Remove all Rugs.")]
        public bool FADICRemoveRugs = false;

        [Name("Remove Potted Plants")]
        [Description("Remove Potted Plants.")]
        public bool FADICRemovePlants = false;

        /*
        [Name("Enable Hidden Cabinet 1")]
        [Description("Enable a Hidden Cabinet in place of the End Table.")]
        public bool FADICEnableCabinet1 = false;

        [Name("Enable Hidden Cabinet 2")]
        [Description("Enable a Hidden Cabinet Next to the End Table.")]
        public bool FADICEnableCabinet2 = false;
        */


        //Mystery Lake
        [Section("Mystery Lake - Forestry Lookout")]

        [Name("Remove Bunk Beds")]
        [Description("Remove the Bunk Beds.")]
        public bool MLFLRemoveBeds = false;

        [Name("Remove Short Counter")]
        [Description("Remove the Short Counter.")]
        public bool MLFLRemoveShortCounter = false;

        [Name("Remove Corner Counter")]
        [Description("Remove the Corner Counter.")]
        public bool MLFLRemoveCornerCounter = false;
        

        //Timberwolf Mountain
        [Section("Timberwolf Mountain - Mountaineer's Hut")]

        [Name("Change the Indoor Temperature")]
        [Description("The Value of Temperature Added to the Outdoor Air Temperature (Celsius.Default is 10).")]
        [Slider(0, 50, 51)]
        public float TMMHTemp = 10f;

        [Name("Patch the Hole in the Roof")]
        [Description("Patch the Hole in the Roof.")]
        public bool TMMHCloseRoof = false;

        [Name("Windows")]
        [Description("Default / Open / Close")]
        [Choice("Default", "Open", "Close")]
        public int TMMHWindows = 0;

        [Name("Remove Beds")]
        [Description("Remove the Two Beds.")]
        public bool TMMHRemoveBeds = false;

        [Name("Remove Workbench")]
        [Description("Remove the Workbench.")]
        public bool TMMHRemoveWorkbench = false;


        protected override void OnConfirm()
        {
            base.OnConfirm();

            Patches.ChangeObjects();
        }

    }

    internal static class Settings
    {
        public static OutdoorSafehouseSettings options;

        public static void OnLoad()
        {
            options = new OutdoorSafehouseSettings();
            options.AddToModSettings("Outdoor Safehouse Adjustments", MenuType.Both);
        }
    }

}