using DevFreela.API.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace DevFreela.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProjectsController : ControllerBase
{
    private readonly OpeningTimeOption _option;

    public ProjectsController(IOptions<OpeningTimeOption> option)
    {
        _option = option.Value;
    }

    [HttpGet]
    public IActionResult Get(string query)
    {
        // Buscar todos ou filtrar

        return Ok();
    }

    // api/projects/2
    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        // Buscar o projeto

        // return NotFound();

        return Ok();
    }

    [HttpPost]
    public IActionResult Post([FromBody] CreateProjectModel createProject)
    {
        if (createProject.Title.Length > 50)
        {
            return BadRequest();
        }

        // Cadastrar o projeto

        return CreatedAtAction(nameof(GetById), new { id = createProject.Id }, createProject);
    }

    // api/projects/2
    [HttpPut("{id}")]
    public IActionResult Put(int id, [FromBody] UpdateProjectModel updateProject)
    {
        if (updateProject.Description.Length > 200)
        {
            return BadRequest();
        }

        // Atualizo o objeto

        return NoContent();
    }

    // api/projects/3 DELETE
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        // Buscar, se não existir, retorna NotFound

        // Remover

        return NoContent();
    }

    // api/projects/1/comments POST
    [HttpPost("{id}/comments")]
    public IActionResult PostComment(int id, [FromBody] CreateCommentModel createComment)
    {
        return NoContent();
    }

    [HttpPut("{id}/start")]
    public IActionResult Start(int id)
    {
        return NoContent();
    }

    [HttpPut("{id}/finish")]
    public IActionResult Finish(int id)
    {
        return NoContent();
    }
}