using System;
using UnityEngine;

namespace ET
{
    public class AfterUnitCreate_CreateUnitView: AEvent<EventType.AfterUnitCreate>
    {
        protected override async ETTask Run(EventType.AfterUnitCreate args)
        {
            GameObject bundleGameObject;
            GameObject prefab;
            GameObject go;
            switch (args.Unit.UnitType)
            {
                case UnitType.Player:
                    // Unit View层
                    // 这里可以改成异步加载，demo就不搞了
                    bundleGameObject = (GameObject)ResourcesComponent.Instance.GetAsset("Unit.unity3d", "Unit");
                    prefab = bundleGameObject.Get<GameObject>("Skeleton");
	        
                    go = UnityEngine.Object.Instantiate(prefab, GlobalComponent.Instance.Unit, true);
                    go.transform.position = args.Unit.Position;
                    args.Unit.AddComponent<GameObjectComponent>().GameObject = go;
                    args.Unit.AddComponent<AnimatorComponent>();
                    break;
                case UnitType.Monster:
                    break;
                case UnitType.Npc:
                    // Unit View层
                    // 这里可以改成异步加载，demo就不搞了
                    bundleGameObject = (GameObject)ResourcesComponent.Instance.GetAsset("Unit.unity3d", "Unit");
                    prefab = bundleGameObject.Get<GameObject>("Skeleton");
	        
                    go = UnityEngine.Object.Instantiate(prefab, GlobalComponent.Instance.Unit, true);
                    go.transform.position = args.Unit.Position;
                    args.Unit.AddComponent<GameObjectComponent>().GameObject = go;
                    args.Unit.AddComponent<AnimatorComponent>();
                    break;
                case UnitType.DropItem:
                    break;
                case UnitType.Box:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            
            await ETTask.CompletedTask;
        }
    }
}