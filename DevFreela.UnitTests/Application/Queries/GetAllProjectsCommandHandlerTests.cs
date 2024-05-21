using DevFreela.Application.Queries.GetAllProjects;
using DevFreela.Core.Entities;
using DevFreela.Core.Repositories;
using Moq;

namespace DevFreela.UnitTests.Application.Queries
{
    public class GetAllProjectsCommandHandlerTests
    {
        [Fact]
        public async Task ThreePorjectsExist_Executed_returnThreeProjectViewModels()
        {
            var projects = new List<Project>
            {
                new Project("Project 1", "Description 1", 1, 1, 1000),
                new Project("Project 2", "Description 2", 2, 2, 2000),
                new Project("Project 3", "Description 3", 3, 3, 3000)
            };

            var projectRepositoryMock = new Mock<IProjectRepository>();

            projectRepositoryMock
                .Setup(pr => pr.GetAllAsync().Result)
                .Returns(projects);

            var getAllProjectsQuery = new GetAllProjectsQuery("");
            var getAllProjectsCommandHandler = new GetAllProjectsQueryHandler(projectRepositoryMock.Object);

            var projectsViewModel = await getAllProjectsCommandHandler.Handle(getAllProjectsQuery, new CancellationToken());

            Assert.NotNull(projectsViewModel);
            Assert.NotEmpty(projectsViewModel);
            Assert.Equal(3, projectsViewModel.Count());

            projectRepositoryMock.Verify(pr => pr.GetAllAsync().Result, Times.Once);
        }
    }
}