using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using trackssl.Model;
using trackssl.ViewModel;

namespace trackssl.Interface
{
    public interface IDomain
    {
        public List<DomainVM> DomainList();
        public Domain AddDomain(Domain domain);
        public Domain UpdateDomain(Domain domain);
        public void DeleteDomain(int domainId);
    }
}
