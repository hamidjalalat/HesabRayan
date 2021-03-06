﻿namespace DAL
{
	public class UnitOfWork : System.Object, IUnitOfWork
	{
		public UnitOfWork()
		{
			IsDisposed = false;
		}

		protected bool IsDisposed { get; set; }

		private Models.DataBaseContext _databaseContext;

		protected virtual Models.DataBaseContext DataBaseContext
		{
			get
			{
				if (_databaseContext == null)
				{
					_databaseContext =
						new Models.DataBaseContext();
				}

				return (_databaseContext);
			}
		}

        // **************************************************
        //private IXXXXXRepository _XXXXXRepository;

        //public IXXXXXRepository XXXXXRepository
        //{
        //	get
        //	{
        //		if (_XXXXXRepository == null)
        //		{
        //			_XXXXXRepository =
        //				new XXXXXRepository(DataBaseContext);
        //		}

        //		return (_XXXXXRepository);
        //	}
        //}
        // **************************************************

        // **************************************************



        // **************************************************
        private IProductRepository _ProductRepository;

        public IProductRepository ProductRepository
        {
            get
            {
                if (_ProductRepository == null)
                {
                    _ProductRepository =
                        new ProductRepository(DataBaseContext);
                }

                return (_ProductRepository);
            }
        }
        // **************************************************

        // **************************************************




        // **************************************************
        private IUnitProductRepository _UnitProductRepository;

        public IUnitProductRepository UnitProductRepository
        {
            get
            {
                if (_UnitProductRepository == null)
                {
                    _UnitProductRepository =
                        new UnitProductRepository(DataBaseContext);
                }

                return (_UnitProductRepository);
            }
        }
        // **************************************************

        // **************************************************

        private IUserRepository _userRepository;

		public IUserRepository UserRepository
		{
			get
			{
				if (_userRepository == null)
				{
					_userRepository =
						new UserRepository(DataBaseContext);
				}

				return (_userRepository);
			}
		}
		// **************************************************

		public void Save()
		{
			DataBaseContext.SaveChanges();
		}

		protected virtual void Dispose(bool disposing)
		{
			if (IsDisposed == false)
			{
				if (disposing)
				{
					_databaseContext.Dispose();
					_databaseContext = null;
				}
			}

			IsDisposed = true;
		}

		public void Dispose()
		{
			Dispose(true);

			System.GC.SuppressFinalize(this);
		}
	}
}
