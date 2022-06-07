using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using trackssl.Data;
using trackssl.Service;
using trackssl.ViewModel;

namespace trackssl.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DomainController : Controller
    {
        DomainService _repo;
        public DomainController(DomainService repo)
        {
            _repo = repo;
        }

        [HttpGet]
        [Route("DomainList")]
        public IActionResult DomainList()
        {
            try
            {
                var domainlist = _repo.DomainList();
                return StatusCode(StatusCodes.Status200OK, domainlist);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status404NotFound, new Response { Status = "Failed", Message = ex.Message });
            }
        }
        [HttpPost]
        [Route("AddDomain")]
        public IActionResult AddDomain([FromBody] DomainVM domain)
        {   
            try
            {   
                _repo.AddDomain(domain);
                return StatusCode(StatusCodes.Status200OK, new Response { Status = "Success", Message = "Domain Added Successfully!" });
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status404NotFound, new Response { Status = "Failed", Message = ex.Message });
            }
        }
        [HttpPut]
        [Route("UpdateDomain")]
        public IActionResult UpdateDomain(DomainVM domain)
        {
            try
            {
                _repo.UpdateDomain(domain);
                return StatusCode(StatusCodes.Status200OK, new Response { Status = "Success", Message = "Details Updated Successfully!" });
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status404NotFound, new Response { Status = "Failed", Message = ex.Message });
            }
        }
        [HttpDelete]
        [Route("DeleteDomain/{domainId}")]
        public IActionResult DeleteDomain(int domainId)
        {
            try
            {
                _repo.DeleteDomain(domainId);
                return StatusCode(StatusCodes.Status200OK, new Response { Status = "Success", Message = "Details Deleted Successfully!" });
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status404NotFound, new Response { Status = "Failed", Message = ex.Message });
            }
        }
    }
}
