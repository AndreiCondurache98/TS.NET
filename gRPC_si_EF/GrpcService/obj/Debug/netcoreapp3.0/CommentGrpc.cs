// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/comment.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace GrpcService.Protos {
  public static partial class RemoteComment
  {
    static readonly string __ServiceName = "RemoteComment";

    static readonly grpc::Marshaller<global::GrpcService.Protos.CommentModel> __Marshaller_CommentModel = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcService.Protos.CommentModel.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcService.Protos.Reply1> __Marshaller_Reply1 = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcService.Protos.Reply1.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcService.Protos.CommentLookupModel> __Marshaller_CommentLookupModel = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcService.Protos.CommentLookupModel.Parser.ParseFrom);

    static readonly grpc::Method<global::GrpcService.Protos.CommentModel, global::GrpcService.Protos.Reply1> __Method_AddComment = new grpc::Method<global::GrpcService.Protos.CommentModel, global::GrpcService.Protos.Reply1>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AddComment",
        __Marshaller_CommentModel,
        __Marshaller_Reply1);

    static readonly grpc::Method<global::GrpcService.Protos.CommentLookupModel, global::GrpcService.Protos.CommentModel> __Method_GetCommentById = new grpc::Method<global::GrpcService.Protos.CommentLookupModel, global::GrpcService.Protos.CommentModel>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetCommentById",
        __Marshaller_CommentLookupModel,
        __Marshaller_CommentModel);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GrpcService.Protos.CommentReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of RemoteComment</summary>
    [grpc::BindServiceMethod(typeof(RemoteComment), "BindService")]
    public abstract partial class RemoteCommentBase
    {
      public virtual global::System.Threading.Tasks.Task<global::GrpcService.Protos.Reply1> AddComment(global::GrpcService.Protos.CommentModel request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::GrpcService.Protos.CommentModel> GetCommentById(global::GrpcService.Protos.CommentLookupModel request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(RemoteCommentBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_AddComment, serviceImpl.AddComment)
          .AddMethod(__Method_GetCommentById, serviceImpl.GetCommentById).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, RemoteCommentBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_AddComment, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcService.Protos.CommentModel, global::GrpcService.Protos.Reply1>(serviceImpl.AddComment));
      serviceBinder.AddMethod(__Method_GetCommentById, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcService.Protos.CommentLookupModel, global::GrpcService.Protos.CommentModel>(serviceImpl.GetCommentById));
    }

  }
}
#endregion