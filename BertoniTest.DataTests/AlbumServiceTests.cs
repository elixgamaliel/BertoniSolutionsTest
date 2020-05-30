using BertoniTest.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace BertoniTest.Data.Tests
{
    [TestClass()]
    public class AlbumServiceTests
    {
        [TestMethod()]
        public void GetAlbumsTest()
        {
            AlbumService service = new AlbumService();
            var albums = service.GetAlbums();
            Assert.IsNotNull(albums);
            Assert.IsTrue(albums.Count > 0);
        }

        [TestMethod()]
        public void GetPhotosTest()
        {
            AlbumService service = new AlbumService();
            var photos = service.GetPhotos(2);
            Assert.IsNotNull(photos);
            Assert.IsTrue(photos.Count > 0);
        }

        [TestMethod()]
        public void GetCommentsTest()
        {
            AlbumService service = new AlbumService();
            var comments = service.GetComments(2);
            Assert.IsNotNull(comments);
            Assert.IsTrue(comments.Count > 0);
        }
    }
}