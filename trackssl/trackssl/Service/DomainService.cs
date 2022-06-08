using System;
using System.Collections.Generic;
using System.Linq;
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

        public bool isDomainExists(DomainVM domain)
        {
            return _service.isDomainExists(domain);
        }
        public Domain AddDomain(DomainVM domainVM)
        {
            Domain domain = new Domain()
            {
                DomainID = domainVM.DomainID,
                DomainName = domainVM.DomainName,
                CreatedAT = domainVM.CreatedAT = DateTime.Now,
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
