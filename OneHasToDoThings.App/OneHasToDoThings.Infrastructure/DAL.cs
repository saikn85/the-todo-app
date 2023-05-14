namespace OneHasToDoThings.Infrastructure
{
    public sealed class DAL
    {
        #region Dependencies
        
        private readonly string _connectionString;

        public DAL(string connectionString)
        {
            _connectionString = connectionString;
        }

        #endregion
    }
}