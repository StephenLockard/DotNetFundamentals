using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repository_Pattern;

namespace Value_Types
{
    [TestClass]
    public class StreamingContent_RepositoryPattern_Tests
    {
        [TestMethod]
        public void StreamingContent_SetTitle_ShouldBeCorrectString()
        {

            StreamingContent stream = new StreamingContent();
            stream.ContentID = "Shrek";
            stream.Length = 100;
            stream.Rating = 4.5f;
            stream.Genre = "Children's Animated Comedy";
            stream.IsMature = false;

            string actual = stream.ContentID;
            string expected = "Shrek";

            Assert.AreEqual(actual, expected);
            Assert.AreEqual(stream.Length, 100);
            Assert.AreEqual(stream.Rating, 4, 5f);
            Assert.AreEqual(stream.Genre, "Comedy");
            Assert.AreEqual(stream.IsMature, false);
        }

        [TestMethod]
        public void StreamingContent_SetIsMatureBoolean_ShouldReturnTrue()
        {
            StreamingContent stream = new StreamingContent("Police Academy", 5, "Comedy", 95, true);
            stream.IsMature = true;

            bool actual = stream.IsMature;
            bool expected = true;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StreamingContent_Constructor_ShouldHoldCorrectValues()
        {
            StreamingContent stream = new StreamingContent("Police Academy", 5, "Comedy", 95, true);

            bool actual = stream.IsMature;
            bool expected = true;

            string actualTwo = stream.ContentID;
            string expectedTwo = "Police Academy";

            Assert.AreEqual(actual, expected);
            Assert.AreEqual(actualTwo, expectedTwo);
        }

        [TestMethod]
        public void StreamingContentRepository_AddToList_ShouldReturn_CorrectCount()
        {
            //Arrange
            StreamingContent stream = new StreamingContent();
            StreamingContent streamTwo = new StreamingContent();
            StreamingContentRepository repo = new StreamingContentRepository();

            //Act
            repo.AppendContentToList(stream);
            repo.AppendContentToList(streamTwo);

            int actual = repo.GetStreamingContentList().Count;
            int expected = 2;

            //Assert

            Assert.AreEqual(actual, expected);
        }
    }
}
