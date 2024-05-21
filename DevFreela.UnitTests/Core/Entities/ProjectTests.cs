using DevFreela.Core.Entities;
using DevFreela.Core.Enums;

namespace DevFreela.UnitTests.Core.Entities
{
    public class ProjectTests
    {
        [Fact]
        public void TestIfProjectSStartWorks()
        {
            var projetc = new Project("Nome de teste", "Descrição de teste", 1, 2, 10000);

            Assert.Equal(ProjectStatusEnum.Created, projetc.Status);
            Assert.Null(projetc.StartedAt);

            Assert.NotEmpty(projetc.Title);
            Assert.NotNull(projetc.Title);

            Assert.NotEmpty(projetc.Description);
            Assert.NotNull(projetc.Description);

            projetc.Start();

            Assert.Equal(ProjectStatusEnum.InProgress, projetc.Status);
            Assert.NotNull(projetc.StartedAt);
        }
    }
}