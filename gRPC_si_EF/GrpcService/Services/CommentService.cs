using Grpc.Core;
using GrpcService.Protos;
using PostComment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcService.Services
{
    public class CommentService : RemoteComment.RemoteCommentBase
    {
        private readonly ModelPostCommentContainer _context;

        public CommentService(ModelPostCommentContainer context)
        { 
            _context = context;
        }

        public override Task<CommentModel> GetCommentById(CommentLookupModel request, ServerCallContext context)
        {
            CommentModel output = new CommentModel();

            var comment = _context.Comments.Find(request.CommentId);

            if (comment != null)
            {
                output.CommentId = comment.CommentId;
                output.Text = comment.Text;
            }
            return Task.FromResult(output);
        }
    }
}
