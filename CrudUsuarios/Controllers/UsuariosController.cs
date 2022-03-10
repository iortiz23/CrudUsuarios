using Contexto;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CrudUsuarios.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly ServiceContext contexto;

        public UsuariosController(ServiceContext contexto)
        {
            this.contexto = contexto;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Usuario>>> GetUsuario()
        {
            return await this.contexto.Usuarios.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Usuario>> PostUsuarios(Usuario usuario) {
        var  exist = await this.contexto.Usuarios.FirstOrDefaultAsync(x => x.Identificacion == usuario.Identificacion);
            if (exist == null) {
                return NotFound($"El usuario ya se encuentra creado con el numero de identificacion {usuario.Identificacion}");
            }
            await this.contexto.Usuarios.AddAsync(usuario);
            await this.contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(GetUsuario), new { identificacion = usuario.Identificacion }, usuario);
        }

        [HttpPut]
        public async Task<ActionResult> PutUsuario(Usuario usuario) {
            this.contexto.Entry(usuario).State = EntityState.Modified;
            await this.contexto.SaveChangesAsync();
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteUsuario(int id) {
            var find = await this.contexto.Usuarios.FindAsync(id);
            if (find == null) {
            return NotFound("El  registro no fue encontrado para eliminar");
            }
            this.contexto.Remove(find);
            return NoContent();
        }

    }
}
