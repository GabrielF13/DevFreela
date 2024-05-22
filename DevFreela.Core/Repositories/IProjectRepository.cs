﻿using DevFreela.Core.Entities;

namespace DevFreela.Core.Repositories
{
    public interface IProjectRepository
    {
        Task<List<Project>> GetAllAsync(string query);

        Task<Project> GetDetailsByIdAsync(int id);

        Task<Project> GetByIdAsync(int id);

        Task AddAsync(Project project);

        Task StartAsync(Project project);

        Task AddCommentAsync(ProjectComment projectComment);

        Task SaveChangesAsync();
    }
}