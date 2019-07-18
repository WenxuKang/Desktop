using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using sec006_2_COMP123_04;
using System.Drawing;
using System.Drawing.Imaging;

namespace AreaTest
{
    [TestClass]
    public class AreaTests
    {
        [TestMethod]
        public void Test_Rectangle_Area()
        {
            //Arrange
            double height = 10.0;
            double width = 5.0;
            double expected = 50.0;

            //Act  
            Rectangle rectangle = new Rectangle();
            rectangle.Height =(int) height;
            rectangle.Width = (int) width;
            DrawableRectangle testRectangle =new  DrawableRectangle(Color.White, true, rectangle);
            double actual =  testRectangle.Area();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_Ellipse_Area()
        {
            //Arrange
            double height = 10.0;
            double width = 5.0;
            double expected = Math.PI * width * height;
            
            //Act  
            Rectangle rectangle = new Rectangle();
            rectangle.Height = (int)height;
            rectangle.Width = (int)width;
            DrawableEllipse testEllipse = new DrawableEllipse(Color.White, true, rectangle);
            double actual = testEllipse.Area();
            
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
