using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolidPrinciples.Dip
{
    public interface IErpSyncService
    {
        void SyncPerson(Person person);
    }

    public class ErpSyncService : IErpSyncService
    {
        public void SyncPerson(Person person)
        {
            throw new NotImplementedException();
        }
    }
}