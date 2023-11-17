using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectServiceEZATU.Models;
using ProjectServiceEZATU.DTO.Request.login;
using ProjectServiceEZATU.Models.activity;
using ProjectServiceEZATU.DTO.Request.activity;
namespace ProjectServiceEZATU.Service.Interface.activity
{
    public interface IApproved
    {
        Task<ApprovedModel> Approved(ApprovedscreenRequest approvedscreenRequest);
    }
}
