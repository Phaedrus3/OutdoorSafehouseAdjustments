﻿using UnityEngine;
using Il2Cpp;

namespace OutdoorSafehouseAdjustments
{
    public class Patches : MonoBehaviour                               //public class Patches:MonoBehaviour
    {
        /*
        public struct fixdata
        {
            public bool Delete;
            public string Scene;
            public string Name;
            public int EulerY;
        }
        private List<fixdata> fL_ = new List<fixdata>();
        */

        public static string[,] itemDataArray =
        {
            //OBJECTS
            {"0_Delete","1_Scene",              "2_Name",                               "3_EulerY", "4_Position" },

            //Blackrock
            {"false",   "BlackrockRegion",        "INTERACTIVE_BedMattressD",             "192.9915",       "903.2423, 231.4615, -100.397"},
            {"false",   "BlackrockRegion",        "CONTAINER_SmallCabinetB",             "345.4815",       "899.0304, 231.4896, -100.777"},
            {"false",   "BlackrockRegion",        "STR_StoneCabinADoor_Prefab",             "327.1487",       "897.7574, 231.4832, -99.706"},
            {"false",   "BlackrockRegion",        "OBJ_RugH_Prefab",             "-0, 338.6585, 0",       "902.1544, 231.4844, -100.222"},
            {"false",   "BlackrockRegion",        "STR_StoneCabinAShutterRight_Prefab",   "-0, 102.0222, 0" ,     "0"},
            {"false",   "BlackrockRegion",        "STR_StoneCabinAShutterLeft_Prefab",    "-0, 43.9695, 0" ,     "0"},
            {"false",   "BlackrockRegion",        "STR_StoneCabinA_Prefab/TRIGGER_IndoorSpace",              "0",        "0"},
            {"false",   "BlackrockRegion",        "STR_StoneCabinATrapDoor",              "0",        "0"},

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
            {"false",   "CanneryRegion_SANDBOX",        "OBJ_DishServeB3_Prefab (4)",             "355.4505, 215.848, 359.2446",       "298.952 240.357 354.0861"},
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
            {"false",   "CanneryRegion_SANDBOX",        "OBJ_PaperDataPrintout_A_Prefab",             "-0, 37.8465, 270.1953",       "296.982 240.167 352.254"},
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
            {"false",   "CoastalRegion",        "INTERACTIVE_BedMattressB",             "98",       "357.2500,203.2560,1155.4300"},
            {"false",   "CoastalRegion",        "CONTAINER_Cupboard",                   "43",       "354.138, 203.691, 1156.432"},

            //Forlorn Muskeg
            {"false",   "MarshRegion",        "OBJ_IndustrialDebrisE_Prefab (1)",             "13.8148, 137.5335, 287.5473",       "474.339, -124.329, 58.679"},
            {"false",   "MarshRegion",        "CONTAINER_ToolCabinetMedium",             "357.8826, 24.87, 357.0498",       "466.827, -125.3849, 55.844"},
            {"false",   "MarshRegion",        "CONTAINER_LockerA",             "17.1265, 280.7316, 356.7398",       "463.188, -125.014, 58.629"},
            {"false",   "MarshRegion",        "INTERACTIVE_WorkBench",             "354.489, 208.2193, 3.5024",       "467.143, -124.462, 63.486"},

            //Forsaken Airfield
            {"false",   "AirfieldRegion",        "CONTAINER_LargeKitchenCabinetA (1)",             "90",       "324.877, 208.6422, 1017.392"},
            {"false",   "AirfieldRegion",        "CONTAINER_LargeKitchenCabinetA",             "90",       "324.118, 200.4288, 1016.597"},
            {"false",   "AirfieldRegion",        "OBJ_MetalTroughA_Prefab",             "223.229",       "-739.1814, 294.7993, 1134.499"},
            {"false",   "AirfieldRegion",        "CONTAINER_KitchenCabinetD",             "90",       "328.0724, 201.7289, 1011.972"},
            {"false",   "AirfieldRegion",        "CONTAINER_SteamerTrunk",             "323.7494",       "-740.4617, 294.7993, 1136.31"},

            
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
            

            //Timberwolf Mountain
            {"false",   "CrashMountainRegion",  "STR_StoneCabinA_Prefab/TRIGGER_IndoorSpace",              "0",        "0"},
            {"false",   "CrashMountainRegion",  "STR_StoneCabinATrapDoor",              "0",        "0"},
            {"false",   "CrashMountainRegion",  "INTERACTIVE_BedMattressB",             "0",        "890.3362, 160.6400, 341.8036"},
            {"false",   "CrashMountainRegion",  "INTERACTIVE_WorkBench",                "0",        "0"},
            {"false",   "CrashMountainRegion",  "STR_StoneCabinAShutterRight_Prefab",   "175" ,     "0"},
            {"false",   "CrashMountainRegion",  "STR_StoneCabinAShutterLeft_Prefab",    "175" ,     "0"},

        };

        public static void ChangeObjects()
        {

            GameObject findTargetGO = new GameObject();

            // EY === Euler_Y
            float MHShutterRight_EY = 187.4753f;
            float MHShutterLeft_EY = 129.4225f;
            float MHShutterRight_EY_Close = 175f;
            float MHShutterLeft_EY_Close = 175f;
            float MHShutterRight_EY_Open = 305f;
            float MHShutterLeft_EY_Open = 45f;

            float BLRShutterRight_EY = 102.0222f;
            float BLRShutterLeft_EY = 43.9695f;
            float BLRShutterRight_EY_Close = 90f;
            float BLRShutterLeft_EY_Close = 90f;
            float BLRShutterRight_EY_Open = 240f;
            float BLRShutterLeft_EY_Open = 300f;

            Vector3 FAMCtrunkOrigPos = new Vector3(-740.4617f, 294.7993f, 1136.31f);
            Quaternion FAMCtrunkOrigRot = Quaternion.Euler(-0, 323.7494f, 0);

            Vector3 FAMCtrunkNewPos = new Vector3(-732.4329f, 297.7632f, 1133.026f);
            Quaternion FAMCtrunkNewRot = Quaternion.Euler(-0, 312.5606f, 0);

            Vector3 BIBRtableOrigPos = new Vector3(-364.0239f, 33.022f, -514.212f);
            Quaternion BIBRtableOrigRot = Quaternion.Euler(357.253f, 9.925f, 111.205f);

            Vector3 BIBRtableNewPos = new Vector3(-362.0244f, 31.8511f, -513.4122f);
            Quaternion BIBRtableNewRot = Quaternion.Euler(0.8532f, 338.1381f, 359.2569f);

            Vector3 BRRBLRdoorOrigPos = new Vector3(897.7574f, 231.4832f, -99.706f);
            Quaternion BRRBLRdoorOrigRot = Quaternion.Euler(1.1958f, 327.1487f, 90.6146f);

            Vector3 BRRBLRdoorNewPos = new Vector3(897.7574f, 227.4832f, -99.706f);
            Quaternion BRRBLRdoorNewRot = Quaternion.Euler(0, 327.1487f, 0);

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
                        /*
                        if (itemDataArray[i, 2] == "STR_StoneCabinADoor_Prefab")
                        {
                            if (Settings.options.BRRBLRFixDoor)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }
                        */

                        if (itemDataArray[i, 2] == "STR_StoneCabinADoor_Prefab")
                        {

                            if (Settings.options.BRRBLRFixDoor)
                            {
                                findTargetGO.transform.position = BRRBLRdoorNewPos;
                                findTargetGO.transform.rotation = BRRBLRdoorNewRot;
                            }
                            else
                            {
                                findTargetGO.transform.position = BRRBLRdoorOrigPos;
                                findTargetGO.transform.rotation = BRRBLRdoorOrigRot;
                            }
                        }


        
                        // ------------------------------------------------------------------------------------------

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
                        if (Settings.options.BRRBLRCloseRoof)
                        {
                            if (GameObject.Find("STR_StoneCabinATrapDoor(Clone)"))
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
                            if (GameObject.Find("STR_StoneCabinATrapDoor(Clone)"))
                            {
                                Destroy(GameObject.Find("STR_StoneCabinATrapDoor(Clone)"), 0.5f);
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

                    // Windows --------------------------------------------------------------------------------

                    if (itemDataArray[i, 2] == "STR_StoneCabinAShutterRight_Prefab") // Window Right  
                    {
                        switch (Settings.options.BRRBLRWindows)
                        {
                            case 0: //default
                                findTargetGO.transform.rotation = Quaternion.Euler(0, BLRShutterRight_EY, 0);
                                break;
                            case 1: //open
                                findTargetGO.transform.rotation = Quaternion.Euler(0, BLRShutterRight_EY_Open, 0);
                                break;
                            case 2: //close
                                findTargetGO.transform.rotation = Quaternion.Euler(0, BLRShutterRight_EY_Close, 0);
                                break;
                        }
                    }
                    if (itemDataArray[i, 2] == "STR_StoneCabinAShutterLeft_Prefab") // Window Left  
                    {
                        switch (Settings.options.BRRBLRWindows)
                        {
                            case 0: //default
                                findTargetGO.transform.rotation = Quaternion.Euler(0, BLRShutterLeft_EY, 0);
                                break;
                            case 1: //open
                                findTargetGO.transform.rotation = Quaternion.Euler(0, BLRShutterLeft_EY_Open, 0);
                                break;
                            case 2: //close
                                findTargetGO.transform.rotation = Quaternion.Euler(0, BLRShutterLeft_EY_Close, 0);
                                break;
                        }
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

                        // Desk ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 2] == "CONTAINER_MetalDesk")
                        {
                            if (Settings.options.BIPLRemoveDesk)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }
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
                                        new Vector3(-406.4824f, 30.2328f, -569.3584f),
                                        Quaternion.Euler(0.3513f, 317.0115f, 0.3914f)
                                        );
                                    cloneObject.transform.localScale = new Vector3(6f, 5f, 10f);
                                }
                            }
                            else
                            {
                                if (GameObject.Find("OBJ_PalletA_Prefab (1)(Clone)"))
                                {
                                    Destroy(GameObject.Find("OBJ_PalletA_Prefab (1)(Clone)"), 5f);
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
                                        new Vector3(-394.2018f, 26.7464f, - 572.0848f),
                                        Quaternion.Euler(339.7879f, 133.5122f, 0.653f)
                                        );
                                    cloneObject.transform.localScale = new Vector3(2f, 3f, 4f);
                                }
                            }
                            else
                            {
                                if (GameObject.Find("OBJ_PalletA_Prefab (1)(Clone)2"))
                                {
                                    Destroy(GameObject.Find("OBJ_PalletA_Prefab (1)(Clone)2"), 3f);
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
                                        new Vector3(-341.9017f, 28.0128f, -533.1097f),
                                        Quaternion.Euler(343.4938f, 251.2847f, 1.053f)
                                        );
                                    cloneObject.transform.localScale = new Vector3(1.7f, 2f, 11f);
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


                        // Bed MH ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 2] == "INTERACTIVE_BedMattressB")
                        {
                            if (Settings.options.TMMHRemoveBeds && findTargetGO.scene.name == itemDataArray[i, 1])
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
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


                        // Roof ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 2] == "STR_StoneCabinATrapDoor")
                        {
                            if (Settings.options.TMMHCloseRoof)
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
                                    Destroy(GameObject.Find("STR_StoneCabinATrapDoor(Clone)"), 0.5f);
                                }
                            }
                        }
                        // ------------------------------------------------------------------------------------------

                        //Indoor Temp ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 2] == "STR_StoneCabinA_Prefab/TRIGGER_IndoorSpace")
                        {
                            findTargetGO.GetComponent<IndoorSpaceTrigger>().m_TemperatureDeltaCelsius = Settings.options.TMMHTemp;
                        }
                        // ------------------------------------------------------------------------------------------

                    }

                    // ==============================================================================================================
                    // Forsaken Airfield - Mindful Cabin
                    // ==============================================================================================================
                    if (itemDataArray[i, 1] == "AirfieldRegion")
                    {

                        // Trough FA_MC ------------------------------------------------------------------------------------------

                        if (itemDataArray[i, 2] == "OBJ_MetalTroughA_Prefab")
                        {

                            if (Settings.options.FAMCRemoveTrough && findTargetGO.scene.name == itemDataArray[i, 1])
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }
                        // ------------------------------------------------------------------------------------------

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

                                if (GameObject.Find("CONTAINER_KitchenCabinetD(Clone)"))
                                {
                                    continue;
                                }

                                else
                                {
                                    GameObject cloneObject = Instantiate(  // #Instantiate: clone to gameobject (MonoBehaviour)
                                        findTargetGO,
                                        new Vector3(-739.7708f, 295.2693f, 1134.375f),
                                        Quaternion.Euler(-0, 132.6981f, 0)
                                        );

                                }
                            }
                            else
                            {
                                if (GameObject.Find("CONTAINER_KitchenCabinetD(Clone)"))
                                {
                                    Destroy(GameObject.Find("CONTAINER_KitchenCabinetD(Clone)"));
                                }
                            }
                        }
                        // -----------------------------------------------------------------------------------------


                        // ==============================================================================================================
                        // Forsaken Airfield - Drift Island Cabin
                        // ==============================================================================================================
                        if (itemDataArray[i, 1] == "AirfieldRegion")
                        {

                            // Hidden Large Cabinet2 ------------------------------------------------------------------------------------------

                            if (itemDataArray[i, 2] == "CONTAINER_LargeKitchenCabinetA")
                            {
                                if (Settings.options.FADICEnableCabinet2)
                                {

                                    if (GameObject.Find("CONTAINER_LargeKitchenCabinetA(Clone)"))
                                    {
                                        continue;
                                    }

                                    else
                                    {
                                        GameObject cloneObject = Instantiate(  // #Instantiate: clone to gameobject (MonoBehaviour)
                                            findTargetGO,
                                            new Vector3(324.218f, 208.6293f, 1016.597f),
                                            Quaternion.Euler(-0, 38.0627f, 0)
                                            );

                                    }
                                }
                                else
                                {
                                    if (GameObject.Find("CONTAINER_LargeKitchenCabinetA(Clone)"))
                                    {
                                        Destroy(GameObject.Find("CONTAINER_LargeKitchenCabinetA(Clone)"));
                                    }
                                }
                            }
                            // -----------------------------------------------------------------------------------------

                            // Hidden Large Cabinet1 ------------------------------------------------------------------------------------------

                            if (itemDataArray[i, 2] == "CONTAINER_LargeKitchenCabinetA (1)")
                            {
                                if (Settings.options.FADICEnableCabinet1)
                                {

                                    if (GameObject.Find("CONTAINER_LargeKitchenCabinetA (1)(Clone)"))
                                    {
                                        continue;
                                    }

                                    else
                                    {
                                        GameObject cloneObject = Instantiate(  // #Instantiate: clone to gameobject (MonoBehaviour)
                                            findTargetGO,
                                            new Vector3(324.877f, 208.6422f, 1017.392f),
                                            Quaternion.Euler(-0, 38.0627f, 0)
                                            );

                                    }
                                }
                                else
                                {
                                    if (GameObject.Find("CONTAINER_LargeKitchenCabinetA (1)(Clone)"))
                                    {
                                        Destroy(GameObject.Find("CONTAINER_LargeKitchenCabinetA (1)(Clone)"));
                                    }
                                }
                            }
                            // -----------------------------------------------------------------------------------------
                        }





                    }
                }

            }

        }

    }
}