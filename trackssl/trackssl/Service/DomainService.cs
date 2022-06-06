using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using trackssl.Interface;
using trackssl.Model;
using trackssl.ViewModel;

namespace trackssl.Service
{
    public class DomainService
    {
        IDomain _service;
        public DomainService(IDomain service)
        {
            _service = service;
        }

        public List<DomainVM> DomainList()
        {
            return _service.DomainList().ToList();
        }
        public Domain AddDomain(DomainVM domainVM)
        {
            Domain domain = new Domain()
            {
                DomainID = domainVM.DomainID,
                DomainName = domainVM.DomainName,
            };
            return _service.AddDomain(domain);
        }
        public Domain UpdateDomain(DomainVM domainVM)
        {
            Domain domain = new Domain()
            {
                DomainID = domainVM.DomainID,
                DomainName = domainVM.DomainName,
            };
            return _service.UpdateDomain(domain);
        }
        public void DeleteDomain(int domainId)
        {
            _service.DeleteDomain(domainId);
        }
    }
}
