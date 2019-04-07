using System;
using StringWorker;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WrapperTest
{
    [TestClass]
    public class WrapperTestClass
    {
        [TestMethod]
        public void append_validString_validLength()
        {
            string testString = "test";
            string toAppend = "123";
            Wrapper wrapper = new Wrapper(testString);
            int result = wrapper.append(toAppend);
            Assert.AreEqual(result, 7);
        }

        [TestMethod]
        public void append_validString_validInternalString()
        {
            string testString = "test";
            string toAppend = "123";
            Wrapper wrapper = new Wrapper(testString);
            wrapper.append(toAppend);
            string result = wrapper.getValue();
            Assert.AreEqual(result, "test123");
        }

        [TestMethod]
        public void prepend_validString_validLength()
        {
            string testString = "test";
            string toAppend = "123";
            Wrapper wrapper = new Wrapper(testString);
            int result = wrapper.prepend(toAppend);
            Assert.AreEqual(result, 7);
        }

        [TestMethod]
        public void prepend_validString_validInternalString()
        {
            string testString = "test";
            string toAppend = "123";
            Wrapper wrapper = new Wrapper(testString);
            wrapper.prepend(toAppend);
            string result = wrapper.getValue();
            Assert.AreEqual(result, "123test");
        }

        [TestMethod]
        public void removeCharAt_validPosition_validLength()
        {
            string testString = "test";
            int toRemove = 1;
            Wrapper wrapper = new Wrapper(testString);
            int result = wrapper.removeCharAt(toRemove);
            Assert.AreEqual(result, 3);
        }

        [TestMethod]
        public void removeCharAt_validPosition_validInternalString()
        {
            string testString = "test";
            int toRemove = 1;
            Wrapper wrapper = new Wrapper(testString);
            wrapper.removeCharAt(toRemove);
            string result = wrapper.getValue();
            Assert.AreEqual(result, "tst");
        }

        [TestMethod]
        public void emptyString_always_0Length()
        {
            string testString = "test";
            Wrapper wrapper = new Wrapper(testString);
            int result = wrapper.emptyString();
            Assert.AreEqual(result, 1);
        }
    }
}
