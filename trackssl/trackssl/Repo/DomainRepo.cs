using System;
using System.Collections.Generic;
using System.Linq;
using trackssl.Data;
using trackssl.Interface;
using trackssl.Model;
using trackssl.ViewModel;

namespace trackssl.Repo
{
    public class DomainRepo: IDomain
    {
        private readonly TrackSSLDBContext _context;
        public DomainRepo(TrackSSLDBContext context)
        {
            _context = context;
        }

        public List<DomainVM> DomainList()
        {
            return (from a in _context.Domain
                    select new DomainVM
                    {
                        DomainID = a.DomainID,
                        DomainName = a.DomainName,
                        CreatedAT = a.CreatedAT
                    }).ToList();
        }

        public Domain AddDomain(Domain domain)
        {
            /*eturn _context.Domain.Any(e => e.DomainName == e.DomainName);*/
            /*var domainname = (from a in _context.Domain
                              where a.DomainName == a.DomainName
                              select a).Any();*/
            /*var duplicateExists = _context.Domain.Any(a =>
                         a.DomainName == a.DomainName);*/
            
                _context.Add(domain);
                _context.SaveChanges();
                return domain;
        }

        public Domain UpdateDomain(Domain domain)
        {
            _context.Update(domain);
            _context.SaveChanges();
            return domain;
        }

        public void DeleteDomain(int domainId)
        {
            var deldomain = _context.Domain.Where(s => s.DomainID == domainId).FirstOrDefault();
            if (deldomain != null)
            {
                _context.Remove(deldomain);
                _context.SaveChanges();
            }
        }
    }
}
