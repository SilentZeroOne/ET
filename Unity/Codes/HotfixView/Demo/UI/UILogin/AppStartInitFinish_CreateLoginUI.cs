

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
		}
	}
}
