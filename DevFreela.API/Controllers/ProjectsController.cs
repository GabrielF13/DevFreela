﻿using DevFreela.Application.Commands.CreateComment;
using DevFreela.Application.Commands.CreateProject;
using DevFreela.Application.Commands.DeleteProject;
using DevFreela.Application.Commands.FinishProject;
using DevFreela.Application.Commands.StartProject;
using DevFreela.Application.Commands.UpdateProject;
using DevFreela.Application.Queries.GetAllProjects;
using DevFreela.Application.Queries.GetProjectById;
using DevFreela.Application.Services.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProjectsController : ControllerBase
{
    private readonly IProjectService _projectService;
    private readonly IMediator _mediator;

    public ProjectsController(IProjectService projectService, IMediator mediator)
    {
        _projectService = projectService;
        _mediator = mediator;
    }

    [HttpGet]
    public IActionResult Get(string query)
    {
        var GetAllProjecstQuery = new GetAllProjectsQuery(query);

        _mediator.Send(GetAllProjecstQuery);

        return Ok(GetAllProjecstQuery);
    }

    // api/projects/2
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var command = new GetProjectByIdQuery(id);

        await _mediator.Send(command);

        return Ok(command);
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] CreateProjectCommand command)
    {
        if (command.Title.Length > 50)
        {
            return BadRequest();
        }

        var id = await _mediator.Send(command);

        return CreatedAtAction(nameof(GetById), new { id }, command);
    }

    // api/projects/2
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, [FromBody] UpdateProjectCommand comand)
    {
        if (comand.Description.Length > 200)
        {
            return BadRequest();
        }

        await _mediator.Send(comand);

        return NoContent();
    }

    // api/projects/3 DELETE
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var command = new DeleteProjectCommand(id);

        await _mediator.Send(command);

        return NoContent();
    }

    // api/projects/1/comments POST
    [HttpPost("{id}/comments")]
    public async Task<IActionResult> PostComment(int id, [FromBody] CreateCommentCommand command)
    {
        await _mediator.Send(command);

        return NoContent();
    }

    [HttpPut("{id}/start")]
    public async Task<IActionResult> Start(int id)
    {
        var command = new StartProjectCommand(id);

        await _mediator.Send(command);
        return NoContent();
    }

    [HttpPut("{id}/finish")]
    public async Task<IActionResult> Finish(int id)
    {
        var command = new FinishProjectCommand(id);

        await _mediator.Send(command);

        return NoContent();
    }
}