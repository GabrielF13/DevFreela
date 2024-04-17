using DevFreela.Core.Entities;

namespace DevFreela.Infrastructure.Persistence;

public class DevFreelaDbContext
{
    public DevFreelaDbContext()
    {
        Projects = new List<Project>
        {
            new Project("Meu projeto ASPNET Core 1", "Mudei o nome do projeto", 1, 1, 10000),
            new Project("Meu projeto ASPNET Core 2", "Mudei o nome do projeto", 1, 1, 20000),
            new Project("Meu projeto ASPNET Core 3", "Mudei o nome do projeto", 1, 1, 30000)
        };

        Users = new List<User>
        {
            new User("Gabriel", "g@g.com", new DateTime(1990, 1, 1)),
            new User("Ashley", "a@a.com", new DateTime(1990, 1, 1)),
            new User("Cezar", "c@c.com", new DateTime(1990, 1, 1))
        };

        Skills = new List<Skill>
        {
            new Skill("C#"),
            new Skill("Java"),
            new Skill("Python")
        };
    }

    public List<Project> Projects { get; set; }

    public List<User> Users { get; set; }

    public List<Skill> Skills { get; set; }

    public List<ProjectComment> ProjectComments { get; set; }
}