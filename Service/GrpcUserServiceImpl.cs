using Comparing_Apis.Service;
using Grpc.Core;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using GrpcUserService;

public class GrpcUserServiceImpl : GrpcUserService.User.UserBase
{
    private readonly IUserService _userService;
    private readonly ILogger<GrpcUserServiceImpl> _logger;

    public GrpcUserServiceImpl(IUserService userService, ILogger<GrpcUserServiceImpl> logger)
    {
        _userService = userService;
        _logger = logger;
    }

    public override Task<GetUserResponse> GetUser(GetUserRequest request, ServerCallContext context)
    {
        var user = _userService.GetUser(request.UserId);
        return Task.FromResult(new GetUserResponse
        {
            UserId = user.UserId,
            Name = user.Name,
            Email = user.Email
        });
    }

    public override Task<AddUserResponse> AddUser(AddUserRequest request, ServerCallContext context)
    {
        var userId = _userService.AddUser(request.Name, request.Email);
        return Task.FromResult(new AddUserResponse
        {
            UserId = userId
        });
    }
}