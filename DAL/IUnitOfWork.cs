namespace DAL
{
	public interface IUnitOfWork : System.IDisposable
	{
		IUserRepository UserRepository { get; }
        IUnitProductRepository UnitProductRepository { get; }
        IProductRepository ProductRepository { get; }

        void Save();
	}
}
