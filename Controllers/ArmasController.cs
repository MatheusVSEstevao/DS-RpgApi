using Microsoft.AspNetCore.Mvc;
using RpgApi.models;
using Microsoft.EntityFrameworkCore;
using RpgApi.Data;




namespace RpgApi.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class ArmasController : ControllerBase
    {
       private readonly DataContext _context;

       public ArmasController(DataContext context)
       {
        _context = context;
       }
    



[HttpGet("{id}")]
public async Task<IActionResult> GetSingle(int id)

[HttpGet("GetAll")]
public async Task<IActionResult> Get()
{
    try
    {
        List<Armas> lista = await _context.TB_ARMA.ToListAsync();
        return Ok(lista);
    }
    catch (System.Exception ex)
    {
        return BadRequest(ex.Message);
    }
} 
[HttpPost]
public async Task<IActionResult> Add(Armas novaArma)
{
    try
    {
        if (novaArma.Dano > 100)
        {
            throw new System.Exception("Pontos de dano não pode ser maior que 100");
        }
        await _context.TB_ARMA.AddAsync(novaArma);
        await _context.SaveChangesAsync();

        return Ok(novaArma.Id);
    }
    catch (System.Exception ex)
    {
        return BadRequest(ex.Message);
    }
}
[HttpPut]
public async Task<IActionResult> Update(Armas novaArma)
{
    try
    {
        if (novaArma.Dano > 100)
        {
            throw new System.Exception("Pontos de Dano não pode ser maior que 100");
        }
        _context.TB_ARMA.Update(novaArma);
        int linhasAfetadas = await _context.SaveChangesAsync();

        return Ok(linhasAfetadas);

    }
    catch (System.Exception ex)
    {
        return BadRequest(ex.Message);
    }

}
[HttpDelete("{id}")]

public async Task<IActionResult> Delete(int id)
{
    try
    {
        Armas aRemover = await _context.TB_ARMA.FirstOrDefaultAsync(a => a.Id == id);

        _context.TB_ARMA.Remove(aRemover);
        int linhasAfetadas = await _context.SaveChangesAsync();
        return Ok(linhasAfetadas);
    }
    catch (System.Exception ex)
    {
        return BadRequest(ex.Message);
    }
    

}


    
    }

}