using BertoniTest.Data.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text.Json;
using System.Web;

namespace BertoniTest.Data
{
    public class AlbumService
    {
        public List<Album> GetAlbums()
        {
            List<Album> albums = new List<Album>();
            WebRequest request = WebRequest.Create("https://jsonplaceholder.typicode.com/albums");
            WebResponse response = request.GetResponse();
            using (Stream dataStream = response.GetResponseStream())
            {   
                StreamReader reader = new StreamReader(dataStream);
                string responseFromServer = reader.ReadToEnd();
                albums = JsonSerializer.Deserialize<List<Album>>(responseFromServer);
            }

            return albums;
        }

        public List<Photo> GetPhotos(int albumId)
        {
            List<Photo> photos = new List<Photo>();
            WebRequest request = WebRequest.Create($"https://jsonplaceholder.typicode.com/photos?albumId={albumId}");
            WebResponse response = request.GetResponse();
            using (Stream dataStream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(dataStream);
                string responseFromServer = reader.ReadToEnd();
                photos = JsonSerializer.Deserialize<List<Photo>>(responseFromServer);
            }

            return photos;
        }

        public List<Comment> GetComments(int postId)
        {
            List<Comment> comments = new List<Comment>();
            WebRequest request = WebRequest.Create($"https://jsonplaceholder.typicode.com/comments?postId={postId}");
            WebResponse response = request.GetResponse();
            using (Stream dataStream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(dataStream);
                string responseFromServer = reader.ReadToEnd();
                comments = JsonSerializer.Deserialize<List<Comment>>(responseFromServer);
            }

            return comments;
        }
    }
}
