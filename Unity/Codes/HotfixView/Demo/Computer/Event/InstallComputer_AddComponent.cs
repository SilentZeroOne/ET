using ET.EventType;

namespace ET
{
    public class InstallComputer_AddComponent: AEvent<EventType.InstallComputer>
    {
        protected override async ETTask Run(InstallComputer a)
        {
            await TimerComponent.Instance.WaitAsync(1000);
            
            a.Computer.AddComponent<PCCaseComponent>();
            a.Computer.AddComponent<KeyboardComponent>();
            a.Computer.AddComponent<MonitorComponent>();
            a.Computer.AddComponent<MouseComponent>();

            await ETTask.CompletedTask;
        }
    }
}