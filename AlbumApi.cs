using Grpc.Core;
using System;
using System.Collections.Concurrent;

namespace AlbumAPI.Services
{
    public class AlbumApi:AlbumAPI.AlbumService.AlbumServiceBase
    {
        private static readonly ConcurrentDictionary<string, GetAlbumResponse> albums = new();

        public override Task<GetAlbumResponse> GetAlbum(GetAlbumRequest request, ServerCallContext context)
        {
            if (albums.TryGetValue(request.AlbumId, out var album))
            {
                return Task.FromResult(album);
            }
            else
            {
                throw new RpcException(new Status(StatusCode.NotFound, $"Album not found for the Album ID that was provided: {request.AlbumId}"));

            }
        }
        public override Task<CreateAlbumResponse> CreateAlbum(CreateAlbumRequest request, ServerCallContext context)
        {
            var albumID = Guid.NewGuid().ToString();

            var album = new GetAlbumResponse
            {

                AlbumId = albumID,
                Title = request.Title,
                Artist = request.Artist,
                Genre = request.Genre,
                Year = request.Year,
                Available = request.Available
            };
            if (albums.TryAdd(albumID, album))
            {
                return Task.FromResult(new CreateAlbumResponse { AlbumId = albumID });
            }
            else
            {
                throw new RpcException(new Status(StatusCode.Internal, "Failed to add a new album"));
            }
        }


        public override Task<UpdateAlbumResponse> UpdateAlbum(UpdateAlbumRequest request, ServerCallContext context)
        {
            if (albums.TryGetValue(request.AlbumId, out var album))
            {
                album.Title = request.Title;
                album.Artist = request.Artist;
                album.Genre = request.Genre;
                album.Year = request.Year;
                album.Available = request.Available;

                var updateAlbum = new UpdateAlbumResponse
                {
                    AlbumId = album.AlbumId,
                    Title = album.Title,
                    Artist = album.Artist,
                    Genre = album.Genre,
                    Year = album.Year,
                    Available = album.Available
                };
                return Task.FromResult(updateAlbum);
            }
            //the first 3 lines are real update function, and the second var {...}block is more like a confirmation letter
            //to send back to the user
            else
            {
                throw new RpcException(new Status(StatusCode.Internal, "Failed to update a album"));
            }
        }

        public override Task<DeleteAlbumResponse> DeleteAlbum(DeleteAlbumRequest request, ServerCallContext context)
        {
            if (albums.Remove(request.AlbumId, out var removedAlbum))
            {
                return Task.FromResult(new DeleteAlbumResponse { Message = "Album deleted successfully" });
            }
            else
            {
                throw new RpcException(new Status(StatusCode.NotFound, $"Album not found for the album ID that was provided: {request.AlbumId}"));
            }
        }

        public override Task<ListAlbumsResponse> ListAlbum(ListAlbumsRequest request, ServerCallContext context)
        {
            var response = new ListAlbumsResponse();
            foreach (var album in albums)
            {
                var albumResponse = new AlbumResponse
                {
                    AlbumId = album.Value.AlbumId,
                    Title =album.Value.Title,
                    Artist = album.Value.Artist,
                    Genre = album.Value.Genre,
                    Year = album.Value.Year,
                    Available =album.Value.Available
                  
                };
                response.Albums.Add(albumResponse);
            }
            return Task.FromResult(response);
        }
    }
   
}
