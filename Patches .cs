using UnityEngine;
using Il2Cpp;

namespace OutdoorSafehouseAdjustments
{
    public class Patches : MonoBehaviour                               //public class Patches:MonoBehaviour
    {


        public static string[,] itemDataArray =
        {
            //OBJECTS
            {"0_Delete","1_Scene",              "2_Name",                               "3_EulerY", "4_Position" },

            
            //Blackrock
            {"false",   "BlackrockRegion",        "INTERACTIVE_BedMattressD",             "192.9915",       "903.2423, 231.4615, -100.397"},
            {"false",   "BlackrockRegion",        "CONTAINER_SmallCabinetB",             "345.4815",       "899.0304, 231.4896, -100.777"},
            {"false",   "BlackrockRegion",        "STR_StoneCabinADoor_Prefab",             "327.1487",       "897.7574, 231.4832, -99.706"},
            {"false",   "BlackrockRegion",        "OBJ_RugH_Prefab",             "-0, 338.6585, 0",       "902.1544, 231.4844, -100.222"},

            {"false",   "BlackrockRegion",        "STR_StoneCabinA_Prefab/TRIGGER_IndoorSpace",              "0",        "0"},
            {"false",   "BlackrockRegion",        "STR_StoneCabinATrapDoor",              "0",        "904.7001, 231.3751, -100.9531"},
            

            //Bleak Inlet
            {"false",   "CanneryRegion_SANDBOX",        "INTERACTIVE_BedMattressB",             "116.410",       "299.446, 239.029, 350.7729"},
            {"false",   "CanneryRegion_SANDBOX",        "CONTAINER_BathroomCabinetA",             "116.4107",       "299.0701, 238.884, 353.907"},
            {"false",   "CanneryRegion_SANDBOX",        "OBJ_CounterShort_Prefab",             "206.410",       "299.701, 239.015, 351.533"},
            {"false",   "CanneryRegion_SANDBOX",        "OBJ_CounterCorner_Prefab",             "296.4107",       "300.265, 239.015, 347.517"},
            {"false",   "CanneryRegion_SANDBOX",        "OBJ_CupA_Prefab (6)",             "0, 7.5708, 95.039",       "299.865, 240.067, 351.3651"},
            {"false",   "CanneryRegion_SANDBOX",        "OBJ_CupE_Prefab (5)",             "27.2928",       "299.994, 240.01, 351.207"},
            {"false",   "CanneryRegion_SANDBOX",        "OBJ_DishServeB3_Prefab (2)",             "0",       "299.544, 239.424, 351.598"},
            {"false",   "CanneryRegion_SANDBOX",        "OBJ_DishServeB3_Prefab (3)",             "359.5615, 1.5627, 2.8393",       "299.555, 239.443, 351.598"},
            {"false",   "CanneryRegion_SANDBOX",        "OBJ_PitcherA_Prefab (2)",             "325.2213",       "298.642, 239.974, 354.0001"},
            {"false",   "CanneryRegion_SANDBOX",        "OBJ_CupA_Prefab (7)",             "0",       "299.524, 240.3037, 353.85"},
            {"false",   "CanneryRegion_SANDBOX",        "OBJ_CupA_Prefab (8)",             "277.3769",       "299.391, 240.3037, 353.955"},
            {"false",   "CanneryRegion_SANDBOX",        "OBJ_DishServeB3_Prefab (4)",             "355.4505, 215.848, 359.2446",       "298.952, 240.357, 354.0861"},
            {"false",   "CanneryRegion_SANDBOX",        "OBJ_DishServeB3_Prefab (5)",             "116.4107",       "298.956, 240.332, 354.0941"},
            {"false",   "CanneryRegion_SANDBOX",        "OBJ_DishServeB3_Prefab (6)",             "320.9328",       "298.765, 240.584, 354.16"},
            {"false",   "CanneryRegion_SANDBOX",        "OBJ_SoapA_Prefab",             "13.9255",       "299.33, 239.99, 353.622"},
            {"false",   "CanneryRegion_SANDBOX",        "OBJ_DishBowlA_LOD0",             "0",       "299, 240.044, 353.783"},

            {"false",   "CanneryRegion",        "OBJ_PalletA_Prefab (1)",             "339.7879, 133.5122, 0.653",       "-394.2018, 26.7464, -572.0848"},
            {"false",   "CanneryRegion",        "OBJ_IndustrialDebrisD_Prefab (1)",             "359.665, 344.0029, 91.5537",       "-360.584, 32.251, -524.259"},
            {"false",   "CanneryRegion",        "OBJ_IndustrialDebrisE_Prefab (3)",             "0.5008, 325.2972, 355.3721",       "-360.476, 32.85, -524.352"},
            {"false",   "CanneryRegion",        "OBJ_MetalCounterD_Prefab",             "271.9111, 150.3862, 354.9356",       "-364.447, 32.415, -512.917"},
            {"false",   "CanneryRegion",        "OBJ_PicnicTableF_Prefab",             "357.253, 9.925, 111.205",       "-364.024, 33.022, -514.212"},
            {"false",   "CanneryRegion",        "INTERACTIVE_StoveMetalA",             "-0, 166.943, 0",       "76.1788, 83.01, -918.8228"},
            {"false",   "CanneryRegion",        "OBJ_FridgeBottomDoor",             "0, 338.2791, 0",       "-363.2078, 32.6496, -518.0428"},

            {"false",   "CanneryRegion_SANDBOX",        "OBJ_BulletinBoardD_Prefab",             "-0, 127.8744, -0",       "297.274, 239.001, 352.6561"},
            {"false",   "CanneryRegion_SANDBOX",        "OBJ_PhotoWolf_A_Prefab",             "4.2527, 218.0767, 90.6029",       "297.349, 240.591, 352.761"},
            {"false",   "CanneryRegion_SANDBOX",        "OBJ_PhotoWolf_B_Prefab",             "4.018, 219.2882, 90.0634",       "297.225, 240.2677, 352.5756"},
            {"false",   "CanneryRegion_SANDBOX",        "OBJ_PaperDataPrintout_A_Prefab",             "-0, 37.8465, 270.1953",       "296.982, 240.167, 352.254"},
            {"false",   "CanneryRegion_SANDBOX",        "OBJ_MapBreyerhouse_A_Prefab",             "356.6375, 216.3942, 90",       "297.68, 239.929, 353.166"},
            {"false",   "CanneryRegion_SANDBOX",        "OBJ_RugG_Prefab",             "-0, 105.3242, -0",       "298.984, 239.071, 350.0421"},
            {"false",   "CanneryRegion_SANDBOX",        "OBJ_RugC_Prefab",             "-0, 126.6813, -0",       "301.748, 239.024, 351.972"},
            {"false",   "CanneryRegion_SANDBOX",        "OBJ_ChairFoldng_A_Open_Prefab (4)",             "-0, 320.8122, 0",       "296.968, 239.015, 350.212"},
            {"false",   "CanneryRegion_SANDBOX",        "CONTAINER_MetalDesk",             "-0, 116.4106, 0",       "296.2939, 239.536, 350.501"},
            {"false",   "CanneryRegion_SANDBOX",        "OBJ_ComputerMouse_Prefab",             "-0, 116.4106, 0",       "296.795, 240.049, 350.684"},
            {"false",   "CanneryRegion_SANDBOX",        "OBJ_ComputerKeyboard_Prefab",             "-0, 106.1597, -0",       "296.411, 240.052, 349.928"},
            {"false",   "CanneryRegion_SANDBOX",        "OBJ_ComputerMonitorA_Prefab",             "-0, 86.7951, -0",       "295.916, 240.002, 349.892"},
            {"false",   "CanneryRegion_SANDBOX",        "OBJ_LampB_Prefab",             "-0, 159.1041, -0",       "296.439, 240.039, 351.4141"},
            {"false",   "CanneryRegion_SANDBOX",        "OBJ_Kettle_A_Prefab",             "-0, 75.16, -0",       "296.7359, 240.054, 351.2313"},
            {"false",   "CanneryRegion_SANDBOX",        "OBJ_PictureFrameB4_Prefab",             "355.5178, 118.5629, 0",       "295.958, 240.272, 350.97"},
            {"false",   "CanneryRegion_SANDBOX",        "OBJ_PaperBreyerhouse_A_Prefab",             "0, 116.6226, 0",       "296.197, 240.065, 350.4691"},
            {"false",   "CanneryRegion_SANDBOX",        "OBJ_PottedPlantA_Prefab (3)",             "0, 212.4915, 0",       "297.967, 239.015, 354.127"},


            //Coastal Highway
            {"false",   "CoastalRegion",        "INTERACTIVE_BedMattressB",             "98",       "357.2500, 203.2560, 1155.4300"},
            {"false",   "CoastalRegion",        "CONTAINER_Cupboard",                   "43",       "354.138, 203.691, 1156.432"},

            //Forlorn Muskeg
            {"false",   "MarshRegion",        "OBJ_IndustrialDebrisE_Prefab (1)",             "13.8148, 137.5335, 287.5473",       "474.339, -124.329, 58.679"},
            {"false",   "MarshRegion",        "CONTAINER_ToolCabinetMedium",             "357.8826, 24.87, 357.0498",       "466.827, -125.3849, 55.844"},
            {"false",   "MarshRegion",        "CONTAINER_LockerA",             "17.1265, 280.7316, 356.7398",       "463.188, -125.014, 58.629"},
            {"false",   "MarshRegion",        "INTERACTIVE_WorkBench",             "354.489, 208.2193, 3.5024",       "467.143, -124.462, 63.486"},

            //Forsaken Airfield
            {"false",   "AirfieldRegion",        "CONTAINER_LargeKitchenCabinetA (1)",             "90",       "324.877, 200.7145, 1017.392"},
            {"false",   "AirfieldRegion",        "CONTAINER_LargeKitchenCabinetA",             "90",       "324.118, 200.4288, 1016.597"},
            {"false",   "AirfieldRegion",        "OBJ_MetalTroughA_Prefab",             "223.229",       "-739.1814, 294.7993, 1134.499"},
            {"false",   "AirfieldRegion",        "CONTAINER_KitchenCabinetD",             "90",       "328.0724, 201.7289, 1011.972"},
            {"false",   "AirfieldRegion",        "CONTAINER_SteamerTrunk",             "323.7494",       "-740.4617, 294.7993, 1136.31"},
            {"false",   "AirfieldRegion",        "INTERACTIVE_BedMattressG",             "33.9328",       "-734.7939, 297.7632, 1131.562"},
            {"false",   "AirfieldRegion",        "OBJ_RugY_Prefab",             "24.735",       "-734.0422, 297.7579, 1132.554"},
            {"false",   "AirfieldRegion",        "OBJ_RugG_Prefab",             "130.0941",       "-737.9136, 294.7993, 1138.101"},
            {"false",   "AirfieldRegion",        "OBJ_RugW_Prefab",             "130.2984",       "-739.7617, 294.8214, 1139.211"},
            {"false",   "AirfieldRegion",        "OBJ_RugX_Prefab",             "133.9457",       "-733.2372, 294.7993, 1132.967"},
            {"false",   "AirfieldRegion",        "OBJ_RugF_Prefab",             "310.317",       "-740.7252, 294.7993, 1136.599"},
            {"false",   "AirfieldRegion",        "OBJ_RugH_Prefab",             "223.229",       "-738.0361, 294.8214, 1135.496"},

            {"false",   "AirfieldRegion",        "OBJ_RugI_Prefab",             "0",       "329.0771, 208.6502, 1014.201"},
            {"false",   "AirfieldRegion",        "OBJ_RugI_Prefab (1)",             "-0, 0, 0",       "327.6528, 208.6253, 1012.363"},
            {"false",   "AirfieldRegion",        "OBJ_RugP_Prefab",             "264.09",       "325.9467, 208.6502, 1012.642"},
            {"false",   "AirfieldRegion",        "OBJ_RugQ_Prefab",             "0",       "330.6923, 208.6502, 1017.804"},

            {"false",   "AirfieldRegion",        "OBJ_PottedPlantC_Prefab",             "0",       "323.6055, 209.7138, 1015.941"},
            {"false",   "AirfieldRegion",        "OBJ_PottedPlantC_Prefab (1)",             "274.7862",       "326.6073, 210.6118, 1010.757"},


            {"false",   "AirfieldRegion",        "OBJ_PottedPlantB_Prefab",             "326.6727",       "-734.8719, 297.343, 1134.122"},
            {"false",   "AirfieldRegion",        "OBJ_PottedPlantC_Prefab",             "282.1097",       "-736.028, 296.584, 1130.842"},
            {"false",   "AirfieldRegion",        "OBJ_PottedPlantC_Prefab",             "71.4624",       "-735.6611, 295.2503, 1135.697"},
            {"false",   "AirfieldRegion",        "OBJ_PottedPlantC_Prefab (1)",             "218.0752",       "-735.58, 297.314, 1133.389"},

            {"false",   "AirfieldRegion",        "INTERACTIVE_FirePlace",             "-0 92.8433 -0",       "-230.9173 160.3223 -149.6738"},


            
            //Mystery Lake
            {"false",   "LakeRegion",        "INTERACTIVE_BunkBed",             "180.0005",       "789.6909, 212.9654, 966.4996"},
            {"false",   "LakeRegion",        "OBJ_CounterShort_Prefab",             "90",       "786.1348, 212.9763, 967.1045"},
            {"false",   "LakeRegion",        "OBJ_CupA_Prefab",             "131.3085",       "786.1907, 214.173, 967.4338"},
            {"false",   "LakeRegion",        "OBJ_CupA_Prefab",             "0.0001, 192.0052, 0",       "786.0354, 214.13, 967.5464"},
            {"false",   "LakeRegion",        "OBJ_BasinA_Prefab",             "6.9869, 352.9229, 0",       "786.2968, 213.4794, 966.7321"},
            {"false",   "LakeRegion",        "OBJ_BasinA_Prefab",             "352.9229",       "786.2968, 213.4154, 966.7321"},
            {"false",   "LakeRegion",        "OBJ_PitcherA_Prefab",             "25.48",       "786.1748, 214.116, 967.268"},
            {"false",   "LakeRegion",        "INTERACTIVE_RadioA",             "261.6048",       "786.1396, 213.0193, 966.606"},
            {"false",   "LakeRegion",        "OBJ_CounterCorner_Prefab",             "180.0016",       "791.1887, 212.9964, 969.7589"},
            {"false",   "LakeRegion",        "OBJ_CupA_Prefab",             "97.1377",       "790.7213, 213.4554, 969.4648"},
            {"false",   "LakeRegion",        "OBJ_CupA_Prefab",             "97.1377",       "790.5533, 213.4554, 969.5096"},
            {"false",   "LakeRegion",        "OBJ_SoapA_Prefab",             "359.5456, 65.2828, 0.9724",       "790.9919, 214.1484, 969.2787"},
 
            
            /*
            //Mountain Town
            {"false",   "MountainTownRegion",        "OBJ_CabinExteriorRoofDamagedA_Prefab",             "1.2284, 159.6069, 5.6376",       "441.96, 6.64, 705.66"},
            {"false",   "MountainTownRegion",        "CONTAINER_FirewoodBin",             "17.067",       "442.6285, 4.4288, 717.6844"},
            {"false",   "MountainTownRegion",        "CONTAINER_Cupboard",             "344.9128, 274.2128, 346.9027",       "445.2426, 7.0139, 715.5024"},
            {"false",   "MountainTownRegion",        "CONTAINER_MetalBox",             "10.2702, 53.2206, 1.0596",       "445.1125, 6.7179, 714.2025"},
            {"false",   "MountainTownRegion",        "INTERACTIVE_StoveWoodC",             "18.7631",       "444.8939, -7.8953, 714.7869"},
            {"false",   "MountainTownRegion",        "STRSPAWN_CabinAExterior_Damaged_Prefab",             "11.5254",       "440.0325, 7.4889, 709.1224"},
            {"false",   "MountainTownRegion",        "CONTAINER_Cupboard",             "344.9128, 274.2128, 346.9027",       "445.2426, 5.7138, 715.5024"},
            {"false",   "MountainTownRegion",        "CONTAINER_MetalBox",             "358.4593, 6.4194, 359.9309f",       "444.8527, 6.7774, 712.819"},
            {*/


            //Timberwolf Mountain
            {"false",   "CrashMountainRegion",  "STR_StoneCabinAShutterRight_Prefab",   "175" ,     "0"},
            {"false",   "CrashMountainRegion",  "STR_StoneCabinAShutterLeft_Prefab",    "175" ,     "0"},
            {"false",   "CrashMountainRegion",  "STR_StoneCabinA_Prefab/TRIGGER_IndoorSpace",              "0",        "0"},
            {"false",   "CrashMountainRegion",  "STR_StoneCabinATrapDoor",              "0",        "887.2076, 160.515, 339.6578"},
            {"false",   "CrashMountainRegion",  "INTERACTIVE_BedMattressB",             "0",        "890.3362, 160.6400, 341.8036"},
            {"false",   "CrashMountainRegion",  "INTERACTIVE_WorkBench",                "0",        "0"},

            {"false",   "AFHangar",  "INTERACTIVE_FirePlace",                "-0 92.8433 -0",        "-230.9173 160.3223 -149.6738"},

        };



        public static void ChangeObjects()
        {
            UnityEngine.Random.Range(0, 3);

            GameObject findTargetGO = new GameObject();

            // EY === Euler_Y
            float MHShutterRight_EY = 187.4753f;
            float MHShutterLeft_EY = 129.4225f;
            float MHShutterRight_EY_Close = 175f;
            float MHShutterLeft_EY_Close = 175f;
            float MHShutterRight_EY_Open = 305f;
            float MHShutterLeft_EY_Open = 45f;


            //Bleak Inlet
            Vector3 BIBRtableOrigPos = new Vector3(-364.0239f, 33.022f, -514.212f);
            Quaternion BIBRtableOrigRot = Quaternion.Euler(357.253f, 9.925f, 111.205f);

            Vector3 BIBRtableNewPos = new Vector3(-362.0244f, 31.8511f, -513.4122f);
            Quaternion BIBRtableNewRot = Quaternion.Euler(0.8532f, 338.1381f, 359.2569f);


            //Forlorn Muskeg
            Vector3 FMSFCabinetOrigPos = new Vector3(466.827f, -125.3849f, 55.844f);
            Quaternion FMSFCabinetOrigRot = Quaternion.Euler(357.8826f, 24.87f, 357.0498f);

            Vector3 FMSFCabinetNewPos = new Vector3(466.627f, -125.2849f, 55.844f);
            Quaternion FMSFCabinetNewRot = Quaternion.Euler(357.8826f, 38.8718f, 359.55f);

            Vector3 FMSFLockerOrigPos = new Vector3(463.188f, -125.014f, 58.629f);
            Quaternion FMSFLockerOrigRot = Quaternion.Euler(17.1265f, 280.7316f, 356.7398f);

            Vector3 FMSFLockerNewPos = new Vector3(465.7677f, -125.114f, 56.729f);
            Quaternion FMSFLockerNewRot = Quaternion.Euler(0.2684f, 214.6252f, 0.8017f);

            Vector3 FMSFWorkbenchOrigPos = new Vector3(467.143f, -124.462f, 63.486f);
            Quaternion FMSFWorkbenchOrigRot = Quaternion.Euler(354.489f, 208.2193f, 3.5024f);

            Vector3 FMSFWorkbenchNewPos = new Vector3(468.5431f, -124.562f, 55.0225f);
            Quaternion FMSFWorkbenchNewRot = Quaternion.Euler(356.5891f, 39.3271f, 0.7024f);


            //Forsaken Airfield
            Vector3 FAMCtrunkOrigPos = new Vector3(-740.4617f, 294.7993f, 1136.31f);
            Quaternion FAMCtrunkOrigRot = Quaternion.Euler(-0, 323.7494f, 0);

            Vector3 FAMCtrunkNewPos = new Vector3(-732.4329f, 297.7632f, 1133.026f);
            Quaternion FAMCtrunkNewRot = Quaternion.Euler(-0, 312.5606f, 0);

            Vector3 FAMCcabinetOrigPos = new Vector3(328.0724f, 201.7289f, 1011.972f);
            Quaternion FAMCcabinetOrigRot = Quaternion.Euler(-0, 90f, 0);

            Vector3 FAMCcabinetNewPos = new Vector3(-739.7708f, 295.2693f, 1134.375f);
            Quaternion FAMCcabinetNewRot = Quaternion.Euler(-0, 132.6981f, 0);

            Vector3 FADICcabinet1OrigPos = new Vector3(324.877f, 200.7145f, 1017.392f);
            Quaternion FADICcabinet1OrigRot = Quaternion.Euler(0, 90f, 0);

            Vector3 FADICcabinet1NewPos = new Vector3(324.877f, 208.6422f, 1017.392f);
            Quaternion FADICcabinet1NewRot = Quaternion.Euler(-0, 38.0627f, 0);

            Vector3 FADICcabinet2OrigPos = new Vector3(324.118f, 200.4288f, 1016.597f);
            Quaternion FADICcabinet2OrigRot = Quaternion.Euler(0, 90f, 0);

            Vector3 FADICcabinet2NewPos = new Vector3(324.218f, 208.6293f, 1016.597f);
            Quaternion FADICcabinet2NewRot = Quaternion.Euler(-0, 38.0627f, 0);


            /*
            //Mountain Town
            Vector3 MTHCwoodbinNewPos = new Vector3(442.6288f, 6.5289f, 717.6843f);
            Quaternion MTHCwoodbinNewRot = Quaternion.Euler(-0, 17.067f, 0);

            Vector3 MTHCwoodbinOrigPos = new Vector3(442.6288f, 4.4288f, 717.6843f);
            Quaternion MTHCwoodbinOrigRot = Quaternion.Euler(-0, 17.067f, 0);

            Vector3 MTHCcupboardNewPos = new Vector3(444.5507f, 7.1639f, 710.7277f);
            Quaternion MTHCcupboardNewRot = Quaternion.Euler(357.886f, 280.5309f, 2.0466f);

            Vector3 MTHCcupboardOrigPos = new Vector3(445.2426f, 5.7138f, 715.5024f);
            Quaternion MTHCcupboardOrigRot = Quaternion.Euler(344.9128f, 274.2128f, 346.9027f);

            Vector3 MTHCmetalboxNewPos = new Vector3(444.8527f, 6.7774f, 712.819f);
            Quaternion MTHCmetalboxNewRot = Quaternion.Euler(358.4593f, 6.4194f, 359.9309f);

            Vector3 MTHCmetalboxOrigPos = new Vector3(445.1124f, 5.8178f, 714.2025f);
            Quaternion MTHCmetalboxOrigRot = Quaternion.Euler(10.2702f, 53.2206f, 1.0596f);

            Vector3 MTHCstoveNewPos = new Vector3(444.8939f, 6.7349f, 715.1869f);
            Quaternion MTHCstoveNewRot = Quaternion.Euler(-0, 30.2885f, 0);

            Vector3 MTHCstoveOrigPos = new Vector3(444.8939f, -7.8953f, 714.7869f);
            Quaternion MTHCstoveOrigRot = Quaternion.Euler(-0, 18.7631f, 0);

            Vector3 MTHChalfcabinNewPos = new Vector3(440.0325f, 7.4889f, 708.7225f);
            Quaternion MTHChalfcabinNewRot = Quaternion.Euler(-0, 11.5254f, 0);

            Vector3 MTHChalfcabinOrigPos = new Vector3(440.0325f, -1.3409f, 708.7225f);
            Quaternion MTHChalfcabinOrigRot = Quaternion.Euler(-0, 11.5254f, 0);


            Vector3 MTHCcupboard2NewPos = new Vector3(444.7506f, 7.1639f, 711.6275f);
            Quaternion MTHCcupboard2NewRot = Quaternion.Euler(357.886f, 280.5309f, 2.0466f);

            Vector3 MTHCcupboard2OrigPos = new Vector3(444.9506f, 7.0139f, 715.5295f);
            Quaternion MTHCcupboard2OrigRot = Quaternion.Euler(344.9128f, 274.2128f, 346.9027f);

            Vector3 MTHCmetalbox2NewPos = new Vector3(444.9526f, 6.7974f, 713.4188f);
            Quaternion MTHCmetalbox2NewRot = Quaternion.Euler(356.8724f, 4.8906f, 359.8327f);

            Vector3 MTHCmetalbox2OrigPos = new Vector3(445.1526f, 6.6974f, 714.6185f);
            Quaternion MTHCmetalbox2OrigRot = Quaternion.Euler(355.0434f, 288.8684f, 350.9322f);
            */

            for (int i = 1; i < itemDataArray.GetLength(0); i++)
            {
                // ----- Find Name -----------------------------------------------------------------
                if (GameObject.Find(itemDataArray[i, 2]) == null)
                {
                    //MelonLogger.Msg("ChangeObjcet is null.");
                    continue;
                }
                else
                {
                    findTargetGO = GameObject.Find(itemDataArray[i, 2]);
                    // GameObject.Find cannot find for already inactive game objects. So this needs to be reloaded after confermation.
                }
                // -------------------------------------------------------------------------------------


                if (findTargetGO != null)
                {
                    // ----- Scene check -----------------------------------------------------------------
                    if (findTargetGO.scene.name != itemDataArray[i, 1]) // Scene 
                    {
                        //MelonLogger.Msg("Scene name does not match.");
                        continue;
                    }
                    // -------------------------------------------------------------------------------------

                    // ==============================================================================================================
                    // Timberwolf Mountain, CrashMountainRegion 
                    // ==============================================================================================================

                    if (itemDataArray[i, 1] == "AFHangar")
                    {

                        /*
                        // Bed MH ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 2] == "INTERACTIVE_BedMattressB")
                        {
                            if (Settings.options.TMMHRemoveBeds)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }
                        // ------------------------------------------------------------------------------------------



                        //Indoor Temp ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 2] == "STR_StoneCabinA_Prefab/TRIGGER_IndoorSpace")
                        {
                            findTargetGO.GetComponent<IndoorSpaceTrigger>().m_TemperatureDeltaCelsius = Settings.options.TMMHTemp;
                        }
                        // ------------------------------------------------------------------------------------------

                        // WorkBench ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 2] == "INTERACTIVE_WorkBench")
                        {
                            if (Settings.options.TMMHRemoveWorkbench)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }
                        // ------------------------------------------------------------------------------------------
                        */

                        // Roof ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 2] == "STR_StoneCabinATrapDoor")
                        {
                            if (Settings.options.TMMHCloseRoof && findTargetGO.scene.name == itemDataArray[i, 1])
                            {
                                if (GameObject.Find("STR_StoneCabinATrapDoor(Clone)"))
                                {
                                    continue;
                                }
                                else
                                {
                                    GameObject cloneObject = Instantiate(  // #Instantiate: clone to gameobject (MonoBehaviour)
                                        findTargetGO,
                                        new Vector3(887f, 164.7f, 343.2f),
                                        Quaternion.Euler(0f, 175f, 325f)
                                        );
                                    cloneObject.transform.localScale = new Vector3(3f, 0.5f, 2f);
                                }
                            }
                            else
                            {
                                if (GameObject.Find("STR_StoneCabinATrapDoor(Clone)"))
                                {
                                    Destroy(GameObject.Find("STR_StoneCabinATrapDoor(Clone)"));
                                }
                            }
                        }
                        // ------------------------------------------------------------------------------------------



                    }


                    // ==============================================================================================================
                    // Timberwolf Mountain, CrashMountainRegion 
                    // ==============================================================================================================

                    if (itemDataArray[i, 1] == "CrashMountainRegion")
                    {

                        // Windows --------------------------------------------------------------------------------

                        if (itemDataArray[i, 2] == "STR_StoneCabinAShutterRight_Prefab") // Window Right  
                        {
                            switch (Settings.options.TMMHWindows)
                            {
                                case 0: //default
                                    findTargetGO.transform.rotation = Quaternion.Euler(0, MHShutterRight_EY, 0);
                                    break;
                                case 1: //open
                                    findTargetGO.transform.rotation = Quaternion.Euler(0, MHShutterRight_EY_Open, 0);
                                    break;
                                case 2: //close
                                    findTargetGO.transform.rotation = Quaternion.Euler(0, MHShutterRight_EY_Close, 0);
                                    break;
                            }
                        }
                        if (itemDataArray[i, 2] == "STR_StoneCabinAShutterLeft_Prefab") // Window Left  
                        {
                            switch (Settings.options.TMMHWindows)
                            {
                                case 0: //default
                                    findTargetGO.transform.rotation = Quaternion.Euler(0, MHShutterLeft_EY, 0);
                                    break;
                                case 1: //open
                                    findTargetGO.transform.rotation = Quaternion.Euler(0, MHShutterLeft_EY_Open, 0);
                                    break;
                                case 2: //close
                                    findTargetGO.transform.rotation = Quaternion.Euler(0, MHShutterLeft_EY_Close, 0);
                                    break;
                            }
                        }
                        // ------------------------------------------------------------------------------------------

                    }

                    
                    // ==============================================================================================================
                    // Black Rock
                    // ==============================================================================================================
                    if (itemDataArray[i, 1] == "BlackrockRegion")
                    {

                        // Bed BRR_PL ------------------------------------------------------------------------------------------

                        if (itemDataArray[i, 2] == "INTERACTIVE_BedMattressD")
                        {
                            if (Settings.options.BRRBLRRemoveBeds && findTargetGO.scene.name == itemDataArray[i, 1])
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }
                        // ------------------------------------------------------------------------------------------

                        // Cabinet ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 2] == "CONTAINER_SmallCabinetB")
                        {
                            if (Settings.options.BRRBLRRemoveCabinet)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }
                        // ------------------------------------------------------------------------------------------

                        // Door ------------------------------------------------------------------------------------------
                        
                        if (itemDataArray[i, 2] == "STR_StoneCabinADoor_Prefab")
                        {
                            if (Settings.options.BRRBLRFixDoor)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }

                        // Rug ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 2] == "OBJ_RugH_Prefab")
                        {
                            if (Settings.options.BRRBLRRemoveRug)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }
                        // ------------------------------------------------------------------------------------------
                    }

                    // Roof ------------------------------------------------------------------------------------------
                    if (itemDataArray[i, 2] == "STR_StoneCabinATrapDoor")
                    {
                        if (Settings.options.BRRBLRCloseRoof && findTargetGO.scene.name == itemDataArray[i, 1])
                        {
                            if (GameObject.Find("STR_StoneCabinATrapDoor(Clone)2"))
                            {
                                continue;
                            }
                            else
                            {
                                GameObject cloneObject = Instantiate(  // #Instantiate: clone to gameobject (MonoBehaviour)
                                    findTargetGO,
                                    new Vector3(901.2124f, 235.874f, -100.3531f),
                                    Quaternion.Euler(-0, 92.2011f, 323.6668f)
                                    );
                                cloneObject.transform.localScale = new Vector3(3f, .5f, 2f);
                            }
                        }
                        else
                        {
                            if (GameObject.Find("STR_StoneCabinATrapDoor(Clone)2"))
                            {
                                Destroy(GameObject.Find("STR_StoneCabinATrapDoor(Clone)2"), 0.5f);
                            }
                        }
                    }
                    // ------------------------------------------------------------------------------------------

                    //Indoor Temp ------------------------------------------------------------------------------------------
                    if (itemDataArray[i, 2] == "STR_StoneCabinA_Prefab/TRIGGER_IndoorSpace")
                    {
                        findTargetGO.GetComponent<IndoorSpaceTrigger>().m_TemperatureDeltaCelsius = Settings.options.BRRBLRTemp;
                    }
                    // ------------------------------------------------------------------------------------------


                    

                    // ==============================================================================================================
                    // Bleak Inlet SANDBOX
                    // ==============================================================================================================
                    if (itemDataArray[i, 1] == "CanneryRegion_SANDBOX")
                    {

                        // Bed BI_PL ------------------------------------------------------------------------------------------

                        if (itemDataArray[i, 2] == "INTERACTIVE_BedMattressB")
                        {

                            if (Settings.options.BIPLRemoveBeds && findTargetGO.scene.name == itemDataArray[i, 1])
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }
                        // ------------------------------------------------------------------------------------------

                        // Cabinet ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 2] == "CONTAINER_BathroomCabinetA")
                        {
                            if (Settings.options.BIPLRemoveCabinet)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }

                        // Short Counter ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 2] == "OBJ_CounterShort_Prefab")
                        {
                            if (Settings.options.BIPLRemoveShortCounter)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }
                        if (itemDataArray[i, 2] == "OBJ_CupA_Prefab (6)")
                        {
                            if (Settings.options.BIPLRemoveShortCounter)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }
                        if (itemDataArray[i, 2] == "OBJ_CupE_Prefab (5)")
                        {
                            if (Settings.options.BIPLRemoveShortCounter)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }
                        if (itemDataArray[i, 2] == "OBJ_DishServeB3_Prefab (2)")
                        {
                            if (Settings.options.BIPLRemoveShortCounter)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }
                        if (itemDataArray[i, 2] == "OBJ_DishServeB3_Prefab (3)")
                        {
                            if (Settings.options.BIPLRemoveShortCounter)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }

                        // Desk Items------------------------------------------------------------------------------------------

                        if (itemDataArray[i, 2] == "OBJ_ComputerMouse_Prefab")
                        {
                            if (Settings.options.BIPLRemoveDesk)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }
                        if (itemDataArray[i, 2] == "OBJ_ComputerKeyboard_Prefab")
                        {
                            if (Settings.options.BIPLRemoveDesk)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }
                        if (itemDataArray[i, 2] == "OBJ_ComputerMonitorA_Prefab")
                        {
                            if (Settings.options.BIPLRemoveDesk)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }
                        if (itemDataArray[i, 2] == "OBJ_LampB_Prefab")
                        {
                            if (Settings.options.BIPLRemoveDesk)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }
                        if (itemDataArray[i, 2] == "OBJ_Kettle_A_Prefab")
                        {
                            if (Settings.options.BIPLRemoveDesk)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }
                        if (itemDataArray[i, 2] == "OBJ_PictureFrameB4_Prefab")
                        {
                            if (Settings.options.BIPLRemoveDesk)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }
                        if (itemDataArray[i, 2] == "OBJ_PaperBreyerhouse_A_Prefab")
                        {
                            if (Settings.options.BIPLRemoveDesk)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }

                        // Corner Counter ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 2] == "OBJ_CounterCorner_Prefab")
                        {
                            if (Settings.options.BIPLRemoveCornerCounter)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }
                        if (itemDataArray[i, 2] == "OBJ_PitcherA_Prefab (2)")
                        {
                            if (Settings.options.BIPLRemoveCornerCounter)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }
                        if (itemDataArray[i, 2] == "OBJ_CupA_Prefab (7)")
                        {
                            if (Settings.options.BIPLRemoveCornerCounter)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }
                        if (itemDataArray[i, 2] == "OBJ_CupA_Prefab (8)")
                        {
                            if (Settings.options.BIPLRemoveCornerCounter)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }
                        if (itemDataArray[i, 2] == "OBJ_DishServeB3_Prefab (4)")
                        {
                            if (Settings.options.BIPLRemoveCornerCounter)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }
                        if (itemDataArray[i, 2] == "OBJ_DishServeB3_Prefab (5)")
                        {
                            if (Settings.options.BIPLRemoveCornerCounter)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }
                        if (itemDataArray[i, 2] == "OBJ_DishServeB3_Prefab (6)")
                        {
                            if (Settings.options.BIPLRemoveCornerCounter)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }
                        if (itemDataArray[i, 2] == "OBJ_SoapA_Prefab")
                        {
                            if (Settings.options.BIPLRemoveCornerCounter)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }
                        if (itemDataArray[i, 2] == "OBJ_DishBowlA_LOD0")
                        {
                            if (Settings.options.BIPLRemoveCornerCounter)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }
                        // ------------------------------------------------------------------------------------------

                        // Chair ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 2] == "OBJ_ChairFoldng_A_Open_Prefab (4)")
                        {
                            if (Settings.options.BIPLRemoveChair)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }

                        // Potted Plant ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 2] == "OBJ_PottedPlantA_Prefab (3)")
                        {
                            if (Settings.options.BIPLRemovePottedPlant)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }

                        // Rugs ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 2] == "OBJ_RugG_Prefab")
                        {
                            if (Settings.options.BIPLRemoveRugs)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }
                        if (itemDataArray[i, 2] == "OBJ_RugC_Prefab")
                        {
                            if (Settings.options.BIPLRemoveRugs)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }

                        // Bulletin Board ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 2] == "OBJ_BulletinBoardD_Prefab")
                        {
                            if (Settings.options.BIPLRemoveBBoard)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }

                        if (itemDataArray[i, 2] == "OBJ_PhotoWolf_B_Prefab")
                        {
                            if (Settings.options.BIPLRemoveBBoard)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }

                        if (itemDataArray[i, 2] == "OBJ_PhotoWolf_A_Prefab")
                        {
                            if (Settings.options.BIPLRemoveBBoard)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }

                        if (itemDataArray[i, 2] == "OBJ_MapBreyerhouse_A_Prefab")
                        {
                            if (Settings.options.BIPLRemoveBBoard)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }

                        if (itemDataArray[i, 2] == "OBJ_PaperDataPrintout_A_Prefab")
                        {
                            if (Settings.options.BIPLRemoveBBoard)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }


                    }

                    // ==============================================================================================================
                    // Bleak Inlet
                    // ==============================================================================================================
                    if (itemDataArray[i, 1] == "CanneryRegion")
                    {

                        // Bridge Workshop ------------------------------------------------------------------------------------------

                        if (itemDataArray[i, 2] == "OBJ_PalletA_Prefab (1)")
                        {
                            if (Settings.options.BICAddBridgeWorkshop)
                            {

                                if (GameObject.Find("OBJ_PalletA_Prefab (1)(Clone)"))
                                {
                                    continue;
                                }

                                else
                                {
                                    GameObject cloneObject = Instantiate(  // #Instantiate: clone to gameobject (MonoBehaviour)
                                        findTargetGO,
                                        new Vector3(-411.7827f, 31.5328f, -567.2589f),
                                        Quaternion.Euler(358.8512f, 321.147f, 352.0909f)
                                        );
                                    cloneObject.transform.localScale = new Vector3(1f, 1f, 3.5f);
                                }
                            }
                            else
                            {
                                if (GameObject.Find("OBJ_PalletA_Prefab (1)(Clone)"))
                                {
                                    Destroy(GameObject.Find("OBJ_PalletA_Prefab (1)(Clone)"));
                                }
                            }
                        }
                        if (itemDataArray[i, 2] == "OBJ_PalletA_Prefab (1)")
                        {
                            if (Settings.options.BICAddBridgeWorkshop)
                            {

                                if (GameObject.Find("OBJ_PalletA_Prefab (1)(Clone)5"))
                                {
                                    continue;
                                }

                                else
                                {
                                    GameObject cloneObject = Instantiate(  // #Instantiate: clone to gameobject (MonoBehaviour)
                                        findTargetGO,
                                        new Vector3(-407.1835f, 31.6328f, -573.6055f),
                                        Quaternion.Euler(0.8982f, 320.4858f, 354.3644f)
                                        );
                                    cloneObject.transform.localScale = new Vector3(1f, 1f, 3.5f);
                                }
                            }
                            else
                            {
                                if (GameObject.Find("OBJ_PalletA_Prefab (1)(Clone)5"))
                                {
                                    Destroy(GameObject.Find("OBJ_PalletA_Prefab (1)(Clone)5"));
                                }
                            }
                        }

                        // Ramp Workshop ------------------------------------------------------------------------------------------

                        if (itemDataArray[i, 2] == "OBJ_PalletA_Prefab (1)")
                        {
                            if (Settings.options.BICAddRampWorkshop)
                            {

                                if (GameObject.Find("OBJ_PalletA_Prefab (1)(Clone)2"))
                                {
                                    continue;
                                }

                                else
                                {
                                    GameObject cloneObject = Instantiate(  // #Instantiate: clone to gameobject (MonoBehaviour)
                                        findTargetGO,
                                        new Vector3(-394.2018f, 26.5464f, -572.0848f),
                                        Quaternion.Euler(327.6758f, 133.5122f, 359.3619f)
                                        );
                                    cloneObject.transform.localScale = new Vector3(1f, 1f, 4f);
                                }
                            }
                            else
                            {
                                if (GameObject.Find("OBJ_PalletA_Prefab (1)(Clone)2"))
                                {
                                    Destroy(GameObject.Find("OBJ_PalletA_Prefab (1)(Clone)2"));
                                }
                            }
                        }

                        // Cable Reels ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 2] == "OBJ_IndustrialDebrisD_Prefab (1)")
                        {
                            if (Settings.options.BIBRRemoveReels)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }
                        if (itemDataArray[i, 2] == "OBJ_IndustrialDebrisE_Prefab (3)")
                        {
                            if (Settings.options.BIBRRemoveReels)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }

                        // Metal Counter ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 2] == "OBJ_MetalCounterD_Prefab")
                        {
                            if (Settings.options.BIBRRemoveCounter)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }

                        // Fridge Door ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 2] == "OBJ_FridgeBottomDoor")
                        {
                            if (Settings.options.BIBRRemoveFridgeDoor)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }

                        // Picnic Table ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 2] == "OBJ_PicnicTableF_Prefab")
                        {

                            if (Settings.options.BIBRMovePicnicTable)
                            {
                                findTargetGO.transform.position = BIBRtableNewPos;
                                findTargetGO.transform.rotation = BIBRtableNewRot;
                            }
                            else
                            {
                                findTargetGO.transform.position = BIBRtableOrigPos;
                                findTargetGO.transform.rotation = BIBRtableOrigRot;
                            }
                        }

                        // Ramp Warehouse ------------------------------------------------------------------------------------------

                        if (itemDataArray[i, 2] == "OBJ_PalletA_Prefab (1)")
                        {
                            if (Settings.options.BICAddRampWarehouse)
                            {

                                if (GameObject.Find("OBJ_PalletA_Prefab (1)(Clone)3"))
                                {
                                    continue;
                                }

                                else
                                {
                                    GameObject cloneObject = Instantiate(  // #Instantiate: clone to gameobject (MonoBehaviour)
                                        findTargetGO,
                                        new Vector3(-348.9021f, 28.2128f, -536.1089f),
                                        Quaternion.Euler(316.847f, 273.2391f, 349.9521f)
                                        );
                                    cloneObject.transform.localScale = new Vector3(1f, 1f, 5f);
                                }
                            }
                            else
                            {
                                if (GameObject.Find("OBJ_PalletA_Prefab (1)(Clone)3"))
                                {
                                    Destroy(GameObject.Find("OBJ_PalletA_Prefab (1)(Clone)3"));
                                }
                            }

                        }

                        // Stove ------------------------------------------------------------------------------------------

                        if (itemDataArray[i, 2] == "INTERACTIVE_StoveMetalA")
                        {
                            if (Settings.options.BIBRAddStove)
                            {
                                if (GameObject.Find("INTERACTIVE_StoveMetalA(Clone)"))
                                {
                                    continue;
                                }
                                else
                                {
                                    GameObject cloneObject = Instantiate(  // #Instantiate: clone to gameobject (MonoBehaviour)
                                        findTargetGO,
                                        new Vector3(-364.7241f, 31.822f, -514.447f),
                                        Quaternion.Euler(-0, 252.1115f, 0)
                                        );
                                }
                            }
                            else
                            {
                                if (GameObject.Find("INTERACTIVE_StoveMetalA(Clone)"))
                                {
                                    Destroy(GameObject.Find("INTERACTIVE_StoveMetalA(Clone)"));
                                }
                            }
                        }
                        // ------------------------------------------------------------------------------------------

                    }


                    // ==============================================================================================================
                    // Coastal Highway 
                    // ==============================================================================================================
                    if (itemDataArray[i, 1] == "CoastalRegion")
                    {

                        // Bed CH_AL ------------------------------------------------------------------------------------------

                        if (itemDataArray[i, 2] == "INTERACTIVE_BedMattressB")
                        {

                            if (Settings.options.CHALRemoveBeds && findTargetGO.scene.name == itemDataArray[i, 1])
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }
                        // ------------------------------------------------------------------------------------------

                        // Cupboard ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 2] == "CONTAINER_Cupboard")
                        {
                            if (Settings.options.CHALRemoveCupBoard)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }
                        // ------------------------------------------------------------------------------------------
                    }

                    
                    // ==============================================================================================================
                    // Forlorn Muskeg 
                    // ==============================================================================================================
                    if (itemDataArray[i, 1] == "MarshRegion")
                    {

                        // Cable Reel ------------------------------------------------------------------------------------------

                        if (itemDataArray[i, 2] == "OBJ_IndustrialDebrisE_Prefab (1)")
                        {

                            if (Settings.options.FMSFRemoveReel)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }
                        // ------------------------------------------------------------------------------------------

                        // Cabinet ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 2] == "CONTAINER_ToolCabinetMedium")
                        {

                            if (Settings.options.FMSFMoveCabinet)
                            {
                                findTargetGO.transform.position = FMSFCabinetNewPos;
                                findTargetGO.transform.rotation = FMSFCabinetNewRot;
                            }
                            else
                            {
                                findTargetGO.transform.position = FMSFCabinetOrigPos;
                                findTargetGO.transform.rotation = FMSFCabinetOrigRot;
                            }
                        }

                        // ------------------------------------------------------------------------------------------

                        // Locker ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 2] == "CONTAINER_LockerA")
                        {

                            if (Settings.options.FMSFMoveLocker)
                            {
                                findTargetGO.transform.position = FMSFLockerNewPos;
                                findTargetGO.transform.rotation = FMSFLockerNewRot;
                            }
                            else
                            {
                                findTargetGO.transform.position = FMSFLockerOrigPos;
                                findTargetGO.transform.rotation = FMSFLockerOrigRot;
                            }
                        }

                        // ------------------------------------------------------------------------------------------

                        // Workbench ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 2] == "INTERACTIVE_WorkBench")
                        {

                            if (Settings.options.FMSFMoveWorkbench)
                            {
                                findTargetGO.transform.position = FMSFWorkbenchNewPos;
                                findTargetGO.transform.rotation = FMSFWorkbenchNewRot;
                            }
                            else
                            {
                                findTargetGO.transform.position = FMSFWorkbenchOrigPos;
                                findTargetGO.transform.rotation = FMSFWorkbenchOrigRot;
                            }
                        }

                        // ------------------------------------------------------------------------------------------

                    }
                    

                    // ==============================================================================================================
                    // Mystery Lake
                    // ==============================================================================================================
                    if (itemDataArray[i, 1] == "LakeRegion")
                    {

                        // Bed ML_FL ------------------------------------------------------------------------------------------

                        if (itemDataArray[i, 2] == "INTERACTIVE_BunkBed")
                        {

                            if (Settings.options.MLFLRemoveBeds)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }
                        // ------------------------------------------------------------------------------------------

                        // Short Counter ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 2] == "OBJ_CounterShort_Prefab")
                        {
                            if (Settings.options.MLFLRemoveShortCounter)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }
                        // Short Counter ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 2] == "OBJ_CupA_Prefab")
                        {
                            if (Settings.options.MLFLRemoveShortCounter)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }
                        // Short Counter ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 2] == "OBJ_CupA_Prefab")
                        {
                            if (Settings.options.MLFLRemoveShortCounter)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }
                        // Short Counter ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 2] == "OBJ_BasinA_Prefab")
                        {
                            if (Settings.options.MLFLRemoveShortCounter)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }
                        // Short Counter ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 2] == "OBJ_BasinA_Prefab")
                        {
                            if (Settings.options.MLFLRemoveShortCounter)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }
                        // Short Counter ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 2] == "OBJ_PitcherA_Prefab")
                        {
                            if (Settings.options.MLFLRemoveShortCounter)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }
                        // Short Counter ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 2] == "INTERACTIVE_RadioA")
                        {
                            if (Settings.options.MLFLRemoveShortCounter)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }

                        // Corner Counter ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 2] == "OBJ_CounterCorner_Prefab")
                        {
                            if (Settings.options.MLFLRemoveCornerCounter)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }
                        // Corner Counter ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 2] == "OBJ_CupA_Prefab")
                        {
                            if (Settings.options.MLFLRemoveCornerCounter)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }
                        // Corner Counter ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 2] == "OBJ_CupA_Prefab")
                        {
                            if (Settings.options.MLFLRemoveCornerCounter)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }
                        // Corner Counter ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 2] == "OBJ_SoapA_Prefab")
                        {
                            if (Settings.options.MLFLRemoveCornerCounter)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }
                        // ------------------------------------------------------------------------------------------
                    }


                    /*
                    // ==============================================================================================================
                    // Mountain Town - Hermits Cabin
                    // ==============================================================================================================
                    if (itemDataArray[i, 1] == "MountainTownRegion")
                    {

                        // Enable Cabin Half ------------------------------------------------------------------------------------------

                        if (itemDataArray[i, 2] == "OBJ_CabinExteriorRoofDamagedA_Prefab")
                        {

                            if (Settings.options.MTHCEnableCabinHalf)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }


                        if (itemDataArray[i, 2] == "STRSPAWN_CabinAExterior_Damaged_Prefab")
                        {

                            if (Settings.options.MTHCEnableCabinHalf)
                            {
                                findTargetGO.transform.position = MTHChalfcabinNewPos;
                                findTargetGO.transform.rotation = MTHChalfcabinNewRot;
                            }
                            else
                            {
                                findTargetGO.transform.position = MTHChalfcabinOrigPos;
                                findTargetGO.transform.rotation = MTHChalfcabinOrigRot;
                            }
                        }
                        // -----------------------------------------------------------------------------------------


                        // Hidden Wood Bin ------------------------------------------------------------------------------------------

                        if (itemDataArray[i, 2] == "CONTAINER_FirewoodBin")
                        {

                            if (Settings.options.MTHCAddWoodBin)
                            {
                                findTargetGO.transform.position = MTHCwoodbinNewPos;
                                findTargetGO.transform.rotation = MTHCwoodbinNewRot;
                            }
                            else
                            {
                                findTargetGO.transform.position = MTHCwoodbinOrigPos;
                                findTargetGO.transform.rotation = MTHCwoodbinOrigRot;
                            }
                        }
                        // -----------------------------------------------------------------------------------------

                        // Hidden Cupboard ------------------------------------------------------------------------------------------

                        if (itemDataArray[i, 2] == "CONTAINER_Cupboard")
                        {

                            if (Settings.options.MTHCAddCupboard)
                            {
                                findTargetGO.transform.position = MTHCcupboardNewPos;
                                findTargetGO.transform.rotation = MTHCcupboardNewRot;
                            }
                            else
                            {
                                findTargetGO.transform.position = MTHCcupboardOrigPos;
                                findTargetGO.transform.rotation = MTHCcupboardOrigRot;
                            }
                        }
                        // -----------------------------------------------------------------------------------------


                        // Hidden Metal Box ------------------------------------------------------------------------------------------

                        if (itemDataArray[i, 2] == "CONTAINER_MetalBox")
                        {

                            if (Settings.options.MTHCAddMetalBox)
                            {
                                findTargetGO.transform.position = MTHCmetalboxNewPos;
                                findTargetGO.transform.rotation = MTHCmetalboxNewRot;
                            }
                            else
                            {
                                findTargetGO.transform.position = MTHCmetalboxOrigPos;
                                findTargetGO.transform.rotation = MTHCmetalboxOrigRot;
                            }
                        }
                        // -----------------------------------------------------------------------------------------

                        // Normal Cupboard ------------------------------------------------------------------------------------------

                        if (itemDataArray[i, 2] == "CONTAINER_Cupboard")
                        {

                            if (Settings.options.MTHCMoveCupboard)
                            {
                                findTargetGO.transform.position = MTHCcupboard2NewPos;
                                findTargetGO.transform.rotation = MTHCcupboard2NewRot;
                            }
                            else
                            {
                                findTargetGO.transform.position = MTHCcupboard2OrigPos;
                                findTargetGO.transform.rotation = MTHCcupboard2OrigRot;
                            }
                        }
                        // -----------------------------------------------------------------------------------------


                        // Normal Metal Box ------------------------------------------------------------------------------------------

                        if (itemDataArray[i, 2] == "CONTAINER_MetalBox")
                        {

                            if (Settings.options.MTHCMoveMetalBox)
                            {
                                findTargetGO.transform.position = MTHCmetalbox2NewPos;
                                findTargetGO.transform.rotation = MTHCmetalbox2NewRot;
                            }
                            else
                            {
                                findTargetGO.transform.position = MTHCmetalbox2OrigPos;
                                findTargetGO.transform.rotation = MTHCmetalbox2OrigRot;
                            }
                        }
                        // -----------------------------------------------------------------------------------------

                        // Hidden Stove ------------------------------------------------------------------------------------------

                        if (itemDataArray[i, 2] == "INTERACTIVE_StoveWoodC")
                        {

                            if (Settings.options.MTHCAddStove)
                            {
                                findTargetGO.transform.position = MTHCstoveNewPos;
                                findTargetGO.transform.rotation = MTHCstoveNewRot;
                            }
                            else
                            {
                                findTargetGO.transform.position = MTHCstoveOrigPos;
                                findTargetGO.transform.rotation = MTHCstoveOrigRot;
                            }
                        }
                        // -----------------------------------------------------------------------------------------
                    }
                    */

                        // ==============================================================================================================
                        // Forsaken Airfield - Mindful Cabin
                        // ==============================================================================================================
                        if (itemDataArray[i, 1] == "AirfieldRegion")
                    {

                        // Bed FA_MC ------------------------------------------------------------------------------------------

                        if (itemDataArray[i, 2] == "INTERACTIVE_BedMattressG")
                        {

                            if (Settings.options.FAMCRemoveBed)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }
                        // ------------------------------------------------------------------------------------------

                        // Rug FA_MC ------------------------------------------------------------------------------------------

                        if (itemDataArray[i, 2] == "OBJ_RugY_Prefab")
                        {

                            if (Settings.options.FAMCRemoveRug)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }
                        // ------------------------------------------------------------------------------------------

                        // All Rugs FA_MC ------------------------------------------------------------------------------------------

                        if (itemDataArray[i, 2] == "OBJ_RugG_Prefab")
                        {

                            if (Settings.options.FAMCRemoveRugs)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }
                        if (itemDataArray[i, 2] == "OBJ_RugH_Prefab")
                        {

                            if (Settings.options.FAMCRemoveRugs)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }
                        if (itemDataArray[i, 2] == "OBJ_RugW_Prefab")
                        {

                            if (Settings.options.FAMCRemoveRugs)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }
                        if (itemDataArray[i, 2] == "OBJ_RugX_Prefab")
                        {

                            if (Settings.options.FAMCRemoveRugs)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }
                        if (itemDataArray[i, 2] == "OBJ_RugF_Prefab")
                        {

                            if (Settings.options.FAMCRemoveRugs)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }
                        // ------------------------------------------------------------------------------------------


                        // Trough FA_MC ------------------------------------------------------------------------------------------

                        if (itemDataArray[i, 2] == "OBJ_MetalTroughA_Prefab")
                        {

                            if (Settings.options.FAMCRemoveTrough && findTargetGO.scene.name == itemDataArray[i, 1])
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }
                        // ------------------------------------------------------------------------------------------

                        // Potted Plant ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 2] == "OBJ_PottedPlantC_Prefab")
                        {
                            if (Settings.options.FAMCRemovePlants)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }
                        if (itemDataArray[i, 2] == "OBJ_PottedPlantC_Prefab (1)")
                        {
                            if (Settings.options.FAMCRemovePlants)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }
                        if (itemDataArray[i, 2] == "OBJ_PottedPlantC_Prefab")
                        {
                            if (Settings.options.FAMCRemovePlants)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }
                        if (itemDataArray[i, 2] == "OBJ_PottedPlantB_Prefab")
                        {
                            if (Settings.options.FAMCRemovePlants)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }

                        
                        // Trunk ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 2] == "CONTAINER_SteamerTrunk")
                        {

                            if (Settings.options.FAMCMoveTrunk)
                            {
                                findTargetGO.transform.position = FAMCtrunkNewPos;
                                findTargetGO.transform.rotation = FAMCtrunkNewRot;
                            }
                            else
                            {
                                findTargetGO.transform.position = FAMCtrunkOrigPos;
                                findTargetGO.transform.rotation = FAMCtrunkOrigRot;
                            }
                        }

                        // Hidden Cabinet ------------------------------------------------------------------------------------------

                        if (itemDataArray[i, 2] == "CONTAINER_KitchenCabinetD")
                        {

                            if (Settings.options.FAMCEnableCabinet)
                            {
                                findTargetGO.transform.position = FAMCcabinetNewPos;
                                findTargetGO.transform.rotation = FAMCcabinetNewRot;
                            }
                            else
                            {
                                findTargetGO.transform.position = FAMCcabinetOrigPos;
                                findTargetGO.transform.rotation = FAMCcabinetOrigRot;
                            }
                        }
                        // -----------------------------------------------------------------------------------------


                        // ==============================================================================================================
                        // Forsaken Airfield - Drift Island Cabin
                        // ==============================================================================================================
                        if (itemDataArray[i, 1] == "AirfieldRegion")
                        {

                            // All Rugs FA_DIC ------------------------------------------------------------------------------------------

                            if (itemDataArray[i, 2] == "OBJ_RugI_Prefab")
                            {

                                if (Settings.options.FADICRemoveRugs)
                                { findTargetGO.SetActive(false); }
                                else
                                { findTargetGO.SetActive(true); }
                            }
                            if (itemDataArray[i, 2] == "OBJ_RugI_Prefab (1)")
                            {

                                if (Settings.options.FADICRemoveRugs)
                                { findTargetGO.SetActive(false); }
                                else
                                { findTargetGO.SetActive(true); }
                            }
                            if (itemDataArray[i, 2] == "OBJ_RugP_Prefab")
                            {

                                if (Settings.options.FADICRemoveRugs)
                                { findTargetGO.SetActive(false); }
                                else
                                { findTargetGO.SetActive(true); }
                            }
                            if (itemDataArray[i, 2] == "OBJ_RugQ_Prefab")
                            {

                                if (Settings.options.FADICRemoveRugs)
                                { findTargetGO.SetActive(false); }
                                else
                                { findTargetGO.SetActive(true); }
                            }

                            // ------------------------------------------------------------------------------------------

                            // Potted Plant ------------------------------------------------------------------------------------------
                            if (itemDataArray[i, 2] == "OBJ_PottedPlantC_Prefab")
                            {
                                if (Settings.options.FADICRemovePlants)
                                { findTargetGO.SetActive(false); }
                                else
                                { findTargetGO.SetActive(true); }
                            }
                            if (itemDataArray[i, 2] == "OBJ_PottedPlantC_Prefab (1)")
                            {
                                if (Settings.options.FADICRemovePlants)
                                { findTargetGO.SetActive(false); }
                                else
                                { findTargetGO.SetActive(true); }
                            }

                            
                            // Hidden Large Cabinet2 ------------------------------------------------------------------------------------------

                            if (itemDataArray[i, 2] == "CONTAINER_LargeKitchenCabinetA")
                            {

                                if (Settings.options.FADICEnableCabinet2)
                                {
                                    findTargetGO.transform.position = FADICcabinet2NewPos;
                                    findTargetGO.transform.rotation = FADICcabinet2NewRot;
                                }
                                else
                                {
                                    findTargetGO.transform.position = FADICcabinet2OrigPos;
                                    findTargetGO.transform.rotation = FADICcabinet2OrigRot;
                                }
                            }
                            // -----------------------------------------------------------------------------------------

                            // Hidden Large Cabinet1 ------------------------------------------------------------------------------------------

                            if (itemDataArray[i, 2] == "CONTAINER_LargeKitchenCabinetA (1)")
                            {

                                if (Settings.options.FADICEnableCabinet1)
                                {
                                    findTargetGO.transform.position = FADICcabinet1NewPos;
                                    findTargetGO.transform.rotation = FADICcabinet1NewRot;
                                }
                                else
                                {
                                    findTargetGO.transform.position = FADICcabinet1OrigPos;
                                    findTargetGO.transform.rotation = FADICcabinet1OrigRot;
                                }
                            }
                            // -----------------------------------------------------------------------------------------


                        }



                            // Fire "Barrel" in Hangar
                            if (itemDataArray[i, 2] == "INTERACTIVE_FirePlace")
                            {
                                if (Settings.options.FAOHAddFireBarrel)
                                {
                                    if (GameObject.Find("INTERACTIVE_FirePlace(Clone)"))
                                    {
                                        continue;
                                    }
                                    else
                                    {
                                        GameObject cloneObject = Instantiate(  // #Instantiate: clone to gameobject (MonoBehaviour)
                                            findTargetGO,
                                            new Vector3(101.6014f, 161.603f, -577.1132f),
                                            Quaternion.Euler(-0, 103.1058f, 0)
                                            );

                                    }
                                }
                                else
                                {
                                    if (GameObject.Find("INTERACTIVE_FirePlace(Clone)"))
                                    {
                                        Destroy(GameObject.Find("INTERACTIVE_FirePlace(Clone)"));
                                    }
                                }
                            }
                            // ------------------------------------------------------------------------------------------






                    }


                }

            }

        }

    }
}