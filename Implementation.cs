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


            Patches.ChangeObjects();
        }

        public static void Aaa()
        {
            MelonLogger.Msg("Debug Log ========================== Aaa = ");

        }

    }
}