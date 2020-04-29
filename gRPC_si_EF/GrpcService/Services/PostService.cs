using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using GrpcService.Protos;
using Microsoft.Extensions.Logging;
using PostComment;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcService.Services
{
    public class PostService : RemotePost.RemotePostBase
    {
        private readonly ILogger<PostService> _logger;
        private readonly ModelPostCommentContainer _context;

        public PostService(ILogger<PostService> logger, ModelPostCommentContainer context)
        {
            _logger = logger;
            _context = context;
        }

        public override Task<PostModel> GetPostById(PostLookupModel request, ServerCallContext context)
        {
            PostModel output = new PostModel();

            var post = _context.Posts.Find(request.PostId);

            if (post != null)
            {
                output.PostId = post.PostId;
                output.Description = post.Description;
                output.Domain = post.Domain;
                output.Date = Timestamp.FromDateTime(post.Date);
            }
            return Task.FromResult(output);
        }

        public override Task<Reply> AddPost(PostModel request, ServerCallContext context)
        {
            var s = _context.Posts.Find(request.PostId);

            if (s != null)
            {
                return Task.FromResult(
                  new Reply()
                  {
                      Result = $"Post {request.Description} {request.Domain} already exists.",
                      IsOk = false
                  }
                );
            }

            Post post = new Post()
            {
                PostId = request.PostId,
                Description = request.Description,
                Domain = request.Domain,
                Date = request.Date.ToDateTime()
            };
 
            _context.Posts.Add(post);
            _context.SaveChanges();

            return Task.FromResult(
               new Reply()
               {
                   Result = $"Post {request.Description} {request.Domain}  was successfully inserted.",
                   IsOk = true
               }
            );
        }

        public override Task<Reply> DeletePost(PostLookupModel request, ServerCallContext context)
        {
            var p = _context.Posts.Find(request.PostId);

            if (p == null)
            {
                return Task.FromResult(
                  new Reply()
                  {
                      Result = $"Post with ID {request.PostId} cannot be found.",
                      IsOk = false
                  }
                );
            }
            _context.Database.ExecuteSqlCommand("Delete From Post where postid = @p0", request.PostId);
            _context.SaveChanges();

            return Task.FromResult(
               new Reply()
               {
                   Result = $"Post with ID {request.PostId} was successfully deleted.",
                   IsOk = true
               }
            );
        }

        public override Task<PostsList> GetAllPosts(Protos.Empty request, ServerCallContext context)
        {         

            PostsList plist = new PostsList();

            List<PostModel> postList = new List<PostModel>();

            var posts = _context.Posts.Include("Comments").ToList();

            foreach (var p in posts)
            {
                postList.Add(new PostModel()
                {
                    PostId = p.PostId,
                    Description = p.Description,
                    Domain = p.Domain,
                    Date = Timestamp.FromDateTime(p.Date),
                });
            }

            plist.Items.AddRange(postList);
           
            return Task.FromResult(plist);
        }
    }
}

