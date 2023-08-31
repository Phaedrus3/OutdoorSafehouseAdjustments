using MelonLoader;
using UnityEngine;


namespace OutdoorSafehouseAdjustments
{
    internal class Implementation : MelonMod
    {
        [Obsolete]
        public override void OnApplicationStart()
        {
            Settings.OnLoad();/// ModSettings
            LoggerInstance.Msg($"Version {BuildInfo.Version}");

        }

        public override void OnSceneWasInitialized(int level, string name)
        {
            if (name == "AirfieldRegion")
            {

                GameObject.Find("/Lit Art/STR_SteepCabinB_InteriorObjects_Prefab/Interior Objects/CONTAINER_KitchenCabinetD").gameObject.SetActive(true);
                GameObject.Find("/Lit Art/STR_SteepCabinB_InteriorObjects_Prefab/Interior Objects/CONTAINER_LargeKitchenCabinetA").gameObject.SetActive(true);
                GameObject.Find("/Lit Art/STR_SteepCabinB_InteriorObjects_Prefab/Interior Objects/CONTAINER_LargeKitchenCabinetA (1)").gameObject.SetActive(true);
                GameObject.Find("Lit Art/STR_SteepCabinB_InteriorObjects_Prefab/Interior Objects/CONTAINER_LargeKitchenCabinetA").transform.SetPositionAndRotation(new Vector3(324.118f, 200.4288f, 1016.597f), Quaternion.Euler(new Vector3(-0, 90, 0)));
                GameObject.Find("Lit Art/STR_SteepCabinB_InteriorObjects_Prefab/Interior Objects/CONTAINER_LargeKitchenCabinetA (1)").transform.SetPositionAndRotation(new Vector3(324.877f, 200.7145f, 1017.392f), Quaternion.Euler(new Vector3(-0, 90, 0)));
                GameObject.Find("Lit Art/STR_SteepCabinB_InteriorObjects_Prefab/Interior Objects/CONTAINER_KitchenCabinetD").transform.SetPositionAndRotation(new Vector3(328.0724f, 201.7289f, 1011.972f), Quaternion.Euler(new Vector3(-0, 90, 0)));

            }


            if (name == "CanneryRegion")
            {

                GameObject.Find("/Art/Docks/STR_WhalingShipA_Prefab").gameObject.SetActive(true);
                GameObject.Find("Art/Docks/STR_WhalingShipA_Prefab").transform.SetPositionAndRotation(new Vector3(-335.87f, 0.7712f, -516.3101f), Quaternion.Euler(new Vector3(1.2214f, 104.1295f, 10.0066f)));

            }


            Patches.ChangeObjects();
        }

        public static void Aaa()
        {
            MelonLogger.Msg("Debug Log ========================== Aaa = ");

        }

    }
}