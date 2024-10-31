namespace cfEngine.Core
{
    public partial class UserDataManager
    {
        public partial void RegisterSavables()
        {
#if CF_STATISTIC
            Register(Game.Meta.Statistic);
#endif
        }
    }
}