using TransientSingletonScoped.Repositories;

namespace TransientSingletonScoped.Services
{
    public class OperationService : ISingletonService,IScopeService,ITransientService
    {
        private Guid _id;

        public OperationService()
        {
            _id = Guid.NewGuid();

        }
        public Guid GetOperation()
        {
            return _id;
        }
    }
}
