﻿using LecturerManagement.Core.Models;
using LecturerManagement.DTOS.Account;
using LecturerManagement.DTOS.Modules.Enums;
using LecturerManagement.Services.AccountService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LecturerManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public AccountsController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [Authorize(Roles = "Admin")]
        [HttpGet("{username}")]
        public async Task<ActionResult<ServiceResponse<GetAccountDto>>> GetAccountByUsername(string username)
        {
            var response = await _accountService.GetAccountByUsername(username);
            if (!response.Success)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }

        [Authorize(Roles = "Admin")]
        [HttpDelete("{username}")]
        public async Task<IActionResult> DeleteAccount(string username)
        {
            var response = await _accountService.DeleteAccount(username);
            if (!response.Success)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }

        [Authorize]
        [HttpPut("{username}")]
        public async Task<IActionResult> UpdateAccount(string username, UpdateAccountDto updateAccountDto)
        {
            var response = await _accountService.UpdateAccount(username, updateAccountDto);
            if (!response.Success)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }
    }
}
