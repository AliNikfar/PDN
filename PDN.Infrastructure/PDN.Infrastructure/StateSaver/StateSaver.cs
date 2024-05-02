using PDN.Application.StateSaver;
using PDN.Infrastructure.DBContexts;

namespace PDN.Infrastructure.StateSaver
{
    public class StateSaver : IStateSaver
    {
        private readonly PDNDBContext _dbContext;

        public StateSaver(PDNDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task SaveChangeAsync()
    {
        await _dbContext.SaveChangesAsync();
    }
}
}
