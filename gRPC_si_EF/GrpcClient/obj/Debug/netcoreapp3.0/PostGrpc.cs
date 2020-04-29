// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/post.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace GrpcService.Protos {
  public static partial class RemotePost
  {
    static readonly string __ServiceName = "RemotePost";

    static readonly grpc::Marshaller<global::GrpcService.Protos.PostLookupModel> __Marshaller_PostLookupModel = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcService.Protos.PostLookupModel.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcService.Protos.PostModel> __Marshaller_PostModel = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcService.Protos.PostModel.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcService.Protos.Reply> __Marshaller_Reply = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcService.Protos.Reply.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcService.Protos.Empty> __Marshaller_Empty = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcService.Protos.Empty.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcService.Protos.PostsList> __Marshaller_PostsList = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcService.Protos.PostsList.Parser.ParseFrom);

    static readonly grpc::Method<global::GrpcService.Protos.PostLookupModel, global::GrpcService.Protos.PostModel> __Method_GetPostById = new grpc::Method<global::GrpcService.Protos.PostLookupModel, global::GrpcService.Protos.PostModel>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetPostById",
        __Marshaller_PostLookupModel,
        __Marshaller_PostModel);

    static readonly grpc::Method<global::GrpcService.Protos.PostModel, global::GrpcService.Protos.Reply> __Method_AddPost = new grpc::Method<global::GrpcService.Protos.PostModel, global::GrpcService.Protos.Reply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AddPost",
        __Marshaller_PostModel,
        __Marshaller_Reply);

    static readonly grpc::Method<global::GrpcService.Protos.PostLookupModel, global::GrpcService.Protos.Reply> __Method_DeletePost = new grpc::Method<global::GrpcService.Protos.PostLookupModel, global::GrpcService.Protos.Reply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeletePost",
        __Marshaller_PostLookupModel,
        __Marshaller_Reply);

    static readonly grpc::Method<global::GrpcService.Protos.Empty, global::GrpcService.Protos.PostsList> __Method_GetAllPosts = new grpc::Method<global::GrpcService.Protos.Empty, global::GrpcService.Protos.PostsList>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetAllPosts",
        __Marshaller_Empty,
        __Marshaller_PostsList);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GrpcService.Protos.PostReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for RemotePost</summary>
    public partial class RemotePostClient : grpc::ClientBase<RemotePostClient>
    {
      /// <summary>Creates a new client for RemotePost</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public RemotePostClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for RemotePost that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public RemotePostClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected RemotePostClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected RemotePostClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::GrpcService.Protos.PostModel GetPostById(global::GrpcService.Protos.PostLookupModel request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetPostById(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::GrpcService.Protos.PostModel GetPostById(global::GrpcService.Protos.PostLookupModel request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetPostById, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcService.Protos.PostModel> GetPostByIdAsync(global::GrpcService.Protos.PostLookupModel request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetPostByIdAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcService.Protos.PostModel> GetPostByIdAsync(global::GrpcService.Protos.PostLookupModel request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetPostById, null, options, request);
      }
      public virtual global::GrpcService.Protos.Reply AddPost(global::GrpcService.Protos.PostModel request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AddPost(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::GrpcService.Protos.Reply AddPost(global::GrpcService.Protos.PostModel request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_AddPost, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcService.Protos.Reply> AddPostAsync(global::GrpcService.Protos.PostModel request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AddPostAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcService.Protos.Reply> AddPostAsync(global::GrpcService.Protos.PostModel request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_AddPost, null, options, request);
      }
      public virtual global::GrpcService.Protos.Reply DeletePost(global::GrpcService.Protos.PostLookupModel request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeletePost(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::GrpcService.Protos.Reply DeletePost(global::GrpcService.Protos.PostLookupModel request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DeletePost, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcService.Protos.Reply> DeletePostAsync(global::GrpcService.Protos.PostLookupModel request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeletePostAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcService.Protos.Reply> DeletePostAsync(global::GrpcService.Protos.PostLookupModel request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DeletePost, null, options, request);
      }
      public virtual global::GrpcService.Protos.PostsList GetAllPosts(global::GrpcService.Protos.Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAllPosts(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::GrpcService.Protos.PostsList GetAllPosts(global::GrpcService.Protos.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetAllPosts, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcService.Protos.PostsList> GetAllPostsAsync(global::GrpcService.Protos.Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAllPostsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcService.Protos.PostsList> GetAllPostsAsync(global::GrpcService.Protos.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetAllPosts, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override RemotePostClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new RemotePostClient(configuration);
      }
    }

  }
}
#endregion