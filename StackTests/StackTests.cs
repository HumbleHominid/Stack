using NUnit.Framework;
using Stack;

namespace StackTests
{
    [TestFixture]
    public class StackTests
    {
        [Test]
        public void Creation()
        {
            Stack<int> s = new Stack<int>(3);
            Assert.AreEqual(0, s.Size);
        }

        [Test]
        public void Push_Pop()
        {
            Stack<int> s = new Stack<int>(1);
            s.Push(1);
            Assert.AreEqual(1, s.Pop());
        }

        [Test]
        public void Too_Much_Pop()
        {
            Stack<int> s = new Stack<int>(3);
            Assert.Throws<ExpenditureProhibitedException>(() => s.Pop());
        }

        [Test]
        public void Too_Much_Push()
        {
            Stack<int> s = new Stack<int>(1);
            s.Push(1);
            Assert.Throws<ExceededSizeException>(() => s.Push(2));
        }

        [Test]
        public void Peek_Element()
        {
            Stack<int> s = new Stack<int>(1);
            s.Push(1);
            Assert.AreEqual(1, s.Peek());
        }

        [Test]
        public void Peek_Exception() {
            Stack<int> s = new Stack<int>(1);
            Assert.Throws<ExpenditureProhibitedException>(() => s.Peek());
        }
    }
}
