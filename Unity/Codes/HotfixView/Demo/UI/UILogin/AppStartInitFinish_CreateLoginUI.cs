

namespace ET
{
	public class AppStartInitFinish_RemoveLoginUI: AEvent<EventType.AppStartInitFinish>
	{
		protected override async ETTask Run(EventType.AppStartInitFinish args)
		{
			await UIHelper.Create(args.ZoneScene, UIType.UILogin);

			Computer computer = args.ZoneScene.AddChild<Computer>();
			computer.AddComponent<PCCaseComponent>();
			computer.AddComponent<KeyboardComponent>();
			computer.AddComponent<MonitorComponent>();
			computer.AddComponent<MouseComponent>();
			args.ZoneScene.AddComponent<OperaComponent>();
			computer.Start();

			await TimerComponent.Instance.WaitAsync(3000);
			
			computer.Dispose();

			UnitConfig config = UnitConfigCategory.Instance.Get(1001);

			Log.Debug(config.Name + " " + config.Desc);

			var allConfig = UnitConfigCategory.Instance.GetAll();
			foreach (var cf in allConfig)
			{
				Log.Debug("Key "+cf.Key +"Value "+ cf.Value.Name);
			}

			config = UnitConfigCategory.Instance.GetConfigByHeight(180);
			
			Log.Debug(config.Name+" "+config.Height);
		}
	}
}
