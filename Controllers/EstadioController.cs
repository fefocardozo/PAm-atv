using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using CopaHAS.Data;
using CopaHAS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace CopaHAS.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EstadioController : ControllerBase
    {
        private readonly DataContext _context;

        public EstadioController(DataContext context)
        {
            _context = context;
        }
        [HttpGet("GetAll")]
        public async Task<IActionResult> Get()
        {
            try
            {
                List<Estadio> lista = await _context.TB_ESTADIOS.ToListAsync();
                return Ok(lista);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message + " - " + ex.InnerException);
            }
        }
        [HttpPost]
        public async Task<IActionResult> Post (Estadio novoEstadio)
        {
            try
            {
                await _context.TB_ESTADIOS.AddAsync(novoEstadio);
                await _context.SaveChangesAsync();

                return Ok(novoEstadio.Id);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message + " - " + ex.InnerException);
            }
        }
        ///---------------------------

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                Estadio eRemover = await _context.TB_ESTADIOS
                    .FirstOrDefaultAsync(p => p.Id == id);

              if (eRemover == null)
              return NotFound("Estádio não encontrado.");
            _context.TB_ESTADIOS.Remove(eRemover);

                int linhasAfetadas = await
            _context.SaveChangesAsync();
                return Ok(linhasAfetadas); 
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message + " - " + ex.InnerException);
            }
        }

    }
}