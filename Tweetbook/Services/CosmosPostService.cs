using Cosmonaut;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tweetbook.Domain;

namespace Tweetbook.Services
{
    public class CosmosPostService : IPostService
    {
        private readonly ICosmosStore<CosmosPostDto> _NoDb;

        public CosmosPostService(ICosmosStore<CosmosPostDto> _NoDb)
        {
            this._NoDb = _NoDb;
        }
        public Task<bool> CreatePostAsync(Post post)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CreateTagAsync(Tag tag)
        {
            //var Project = new CosmosProjectDto()
            //{
            //    Id = Guid.NewGuid().ToString(),
            //    ProjectName = model.Name,
            //    ProjectLogo = null,
            //    Mark = 0,
            //    Developer = new List<Developer>() { },
            //    Evalution = 0,
            //    Framework = new Framework() { },
            //    SuperVisior = new SuperVisor() { },
            //};
            //var result = await _NoDb.AddAsync(Project);
            //return result.IsSuccess;
            throw new NotImplementedException();
        }

        public Task<bool> DeletePostAsync(Guid postId)
        {
            //var result = await _NoDb.RemoveByIdAsync(projectId, projectId);
            //return result.IsSuccess;
            throw new NotImplementedException();
        }

        public Task<bool> DeleteTagAsync(string tagName)
        {
            throw new NotImplementedException();
        }

        public Task<List<Tag>> GetAllTagsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Post> GetPostByIdAsync(Guid postId)
        {
            //return await _NoDb.Query().SingleOrDefaultAsync(p => p.Id == projectId);
            throw new NotImplementedException();
        }

        public Task<List<Post>> GetPostsAsync(GetAllPostsFilter filter = null, PaginationFilter paginationFilter = null)
        {
            //await _NoDb.Query()
            //               .Select(x => new CreateProjectViewModel { Name = x.ProjectName })
            //               .ToListAsync();
            throw new NotImplementedException();
        }

        public Task<Tag> GetTagByNameAsync(string tagName)
        {
            //var projects = await _NoDb.Query().Where(p => p.ProjectName == projectName).ToListAsync();
            //return projects;
            throw new NotImplementedException();
        }

        public Task<bool> UpdatePostAsync(Post postToUpdate)
        {
            //var oldProject = await _NoDb.FindAsync(projectId, projectId);
            //if (oldProject != null)
            //{
            //    oldProject.ProjectName = updatedProject.ProjectName;
            //    var result = await _NoDb.UpdateAsync(oldProject);
            //    return result.IsSuccess;
            //}
            //return false;
            throw new NotImplementedException();
        }

        public Task<bool> UserOwnsPostAsync(Guid postId, string userId)
        {
            throw new NotImplementedException();
        }
    }
}
