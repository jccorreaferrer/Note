using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Note.Api.Controllers.Base;
using Note.Application.DTOs;
using Note.Application.Interfaces.Services;

namespace Note.Api.Controllers.V1
{
    [Route("api/v1/[controller]")]
    [ApiController]
    [Authorize]
    public class NoteController : BaseController
    {
        private readonly INoteService _service;
        public NoteController(INoteService iService)
        {
            _service = iService;
        }
        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var result = await _service.GetListAsync();
            return Ok(result);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _service.GetByIdAsync(id);
            if (result == null) return NotFound();
            return Ok(result);
        }



        [HttpPost]
        public async Task<IActionResult> Create([FromBody] NoteInsertDTO insertDTO)
        {
            insertDTO.CreationAppUserId = AppUserId;
            var result = await _service.InsertAsync(insertDTO);
            return CreatedAtAction(nameof(GetById), new { id = result.NoteId }, result);
        }

        [HttpPost("GetByIds")]
        public async Task<IActionResult> GetByIds([FromBody] NoteGetByIdsDTO listId)
        {
            var result = await _service.GetByIdsAsync(listId);
            return Ok(result);
        }

    }
}
