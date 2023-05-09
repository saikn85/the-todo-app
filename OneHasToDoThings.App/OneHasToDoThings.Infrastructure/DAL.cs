namespace OneHasToDoThings.Infrastructure
{
    public class DAL
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