namespace ET
{
    public partial class UnitConfigCategory
    {
        public UnitConfig GetConfigByHeight(int height)
        {
            UnitConfig config = null;
            foreach (var info in this.dict.Values)
            {
                if (info.Height == height)
                {
                    config = info;
                    break;
                }
            }
            
            return config;
        }
    }
}